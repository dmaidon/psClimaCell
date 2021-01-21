Imports System.IO
Imports System.Text

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpgradeMySettings()
        LoadProgramSettings()
        CreateProgramFolders()
        StartLogfile()
        PerformLogMaintenance()

        Text = $"psClimaCell 15-Day Weather Forecast - Tr: {My.Settings.TimesRun}"
        TsslCpy.Text = Cpy
        TsslVer.Text = Application.ProductVersion
        LblAbout.Text = $"Written by: Dennis N Maidon{vbLf}PAROLE Software{vbLf}VB.Net{vbLf}.Net Framework 4.8{vbLf}Compiled: {ParseVersion()}"
        Show()

        SetMidnightRollover()

        If String.IsNullOrEmpty(My.Settings.ApiKey.Trim) Then
            TcOpt.SelectedTab = TpOptMain
        Else
            If My.Settings.Fetch_Daily Then
                FetchDailyData()
            End If
            If My.Settings.Fetch_Hourly Then
                FetchHourData()
            End If
            If My.Settings.Fetch_Nowcast Then
                FetchNowcastData()
            End If
            If My.Settings.Fetch_Realtime Then
                FetchRealtimeData()
            End If
        End If

        SaveLogs()
        TmrClock.Start()
    End Sub


    Private Sub SetMidnightRollover()
        ''set the date to midnight + 5 seconds for the next day.
        Dim st = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).AddDays(1)
        Dim _int As Long = Date2Unix(st) - Date2Unix(Now)
        MidDuration = New TimeSpan(0, 0, 0, CInt(_int))
        MidNextUpdate = Date.Now + MidDuration
        TmrMidnight.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
        TmrMidnight.Start()
        PrintLog($"=> Set midnight rollover: {st} -> Interval: {_int} seconds{vbLf}")
    End Sub

    Friend Shared Function ParseVersion() As String
        Dim dtArr As String() = Application.ProductVersion.Split("."c)
        Dim nd As New Date(CInt(dtArr(0)) + 2000, CType(dtArr(1), Integer), CType(dtArr(2), Integer))
        Return $"{nd:D}"
    End Function

    Private Shared Sub UpgradeMySettings()
        'https://stackoverflow.com/questions/1702260/losing-vb-net-my-settings-with-each-new-clickonce-deployment-release
        If My.Settings.MustUpgrade Then
            My.Settings.Upgrade()
            My.Settings.MustUpgrade = False
            My.Settings.Save()
            PrintLog($"Settings upgraded.{vbLf}")
        End If
    End Sub

    Private Shared Sub CreateProgramFolders()
        Dim fName As New List(Of String)({LogDir, TempDir, DataDir, IconDir}) ', AstroDir, ChartDir, SettingsDir, RecDir, ArcDir, ArcDirYr, NoaaDir, CalDir, StationDir})

        For j = 0 To fName.Count - 1
            Try
                If Not Directory.Exists(fName(j)) Then
                    Directory.CreateDirectory(fName(j))
                    PrintLog($"{fName(j)} ==> created.{vbLf}")
                Else
                    PrintLog($"{fName(j)} --> exists.{vbLf}")
                End If
            Catch ex As Exception
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Finally
                'a
            End Try
        Next
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
        PrintLog($"Program closed @ {Now:F}.{vbLf}")
        SaveLogs()
    End Sub

    Private Sub LoadProgramSettings()
        NumLatiutude.Value = CDec(My.Settings.cLatitude)
        NumLongitude.Value = CDec(My.Settings.cLongitude)
        NumDailyInterval.Value = My.Settings.UpdateInterval_Daily
        NumHourlyInterval.Value = My.Settings.UpdateInterval_Hourly
        NumNowcastInterval.Value = My.Settings.UpdateInterval_Nowcast
        NumRtInterval.Value = My.Settings.UpdateInterval_Realtime
        TmrInt(0) = My.Settings.UpdateInterval_Daily
        TmrInt(1) = My.Settings.UpdateInterval_Hourly
        TmrInt(2) = My.Settings.UpdateInterval_Nowcast
        TmrInt(3) = My.Settings.UpdateInterval_Realtime
        NumNcTimeStep.Value = CDec(My.Settings.Nc_TimeStep)

        TxtApiKey.Text = My.Settings.ApiKey

        For j = 0 To TmrArr.Count - 1
            If TmrInt(j) > 0 Then
                TmrArr(j).Interval = TimeSpan.FromMinutes(TmrInt(j)).TotalMilliseconds
                Select Case j
                    Case 0
                        DlyDuration = New TimeSpan(0, 0, TmrInt(j), 0)
                        DlyNextUp = Date.Now + DlyDuration
                    Case 1
                        HrDuration = New TimeSpan(0, 0, TmrInt(j), 0)
                        HrNextUp = Date.Now + HrDuration
                    Case 2
                        NcDuration = New TimeSpan(0, 0, TmrInt(j), 0)
                        NcNextUp = Date.Now + NcDuration
                    Case 3
                        RtDuration = New TimeSpan(0, 0, TmrInt(j), 0)
                        RtNextUp = Date.Now + RtDuration
                    Case Else
                        Exit Select
                End Select
                TmrArr(j).Start()
                Application.DoEvents()
            End If
        Next

        ChkFetchDaily.Checked = My.Settings.Fetch_Daily
        ChkFetchHourly.Checked = My.Settings.Fetch_Hourly
        ChkFetchNowcast.Checked = My.Settings.Fetch_Nowcast
        ChkFetchRt.Checked = My.Settings.Fetch_Realtime
        ChkLogHeaders.Checked = My.Settings.Log_Headers
        ChkLogImages.Checked = My.Settings.Log_Images

        LoadDailySettings()
        LoadHrSettings()
        LoadNcSettings()
        LoadRtSettings()

        Select Case My.Settings.Units
            Case 0
                RbUnitUS.Checked = True
            Case 1
                RbUnitSI.Checked = True
            Case Else
                RbUnitUS.Checked = True
        End Select
    End Sub

#Region "Options"

#Region "Main "

    Private Sub TxtApiKey_TextChanged(sender As Object, e As EventArgs) Handles TxtApiKey.TextChanged
        My.Settings.ApiKey = TxtApiKey.Text
        My.Settings.Save()
    End Sub

    Private Sub Units_CheckedChanged(sender As Object, e As EventArgs) Handles RbUnitUS.CheckedChanged, RbUnitSI.CheckedChanged
        Dim ct = DirectCast(sender, RadioButton)
        My.Settings.Units = CInt(ct.Tag)
        My.Settings.Save()
    End Sub

    Private Sub Num_Enter(sender As Object, e As EventArgs) Handles NumLatiutude.Enter, NumLongitude.Enter, NumDailyInterval.Enter, NumHourlyInterval.Enter, NumNowcastInterval.Enter, NumRtInterval.Enter
        Dim ct = DirectCast(sender, NumericUpDown)
        ct.Select(0, ct.Text.Length)
    End Sub

    Private Sub UpdateIntervals(sender As Object, e As EventArgs) Handles NumDailyInterval.ValueChanged, NumHourlyInterval.ValueChanged, NumNowcastInterval.ValueChanged, NumRtInterval.ValueChanged
        With DirectCast(sender, NumericUpDown)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.UpdateInterval_Daily = CInt(.Value)
                    TmrInt(0) = CInt(.Value)
                Case 1
                    My.Settings.UpdateInterval_Hourly = CInt(.Value)
                    TmrInt(1) = CInt(.Value)
                Case 2
                    My.Settings.UpdateInterval_Nowcast = CInt(.Value)
                    TmrInt(2) = CInt(.Value)
                Case 3
                    My.Settings.UpdateInterval_Realtime = CInt(.Value)
                    TmrInt(3) = CInt(.Value)
                Case Else
                    Exit Select
            End Select
        End With
    End Sub

    Private Sub LocationData(sender As Object, e As EventArgs) Handles NumLatiutude.ValueChanged, NumLongitude.ValueChanged
        With DirectCast(sender, NumericUpDown)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.cLatitude = .Value
                Case 1
                    My.Settings.cLongitude = .Value
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
    End Sub

    Private Sub FetchData(sender As Object, e As EventArgs) Handles ChkFetchDaily.CheckedChanged, ChkFetchHourly.CheckedChanged, ChkFetchNowcast.CheckedChanged, ChkFetchRt.CheckedChanged, ChkLogImages.CheckedChanged, ChkLogHeaders.CheckedChanged
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Fetch_Daily = .Checked
                Case 1
                    My.Settings.Fetch_Hourly = .Checked
                Case 2
                    My.Settings.Fetch_Nowcast = .Checked
                Case 3
                    My.Settings.Fetch_Realtime = .Checked
                Case 4
                Case 5
                Case Else
                    Exit Select
            End Select
        End With
    End Sub

#End Region

#Region "Daily Forecast"

    Private Sub DailyForecast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTemp.CheckedChanged, ChkBP.CheckedChanged, ChkDewpoint.CheckedChanged, ChkFeelsLike.CheckedChanged, ChkHumidity.CheckedChanged, ChkPrecipAcc.CheckedChanged, ChkPrecip.CheckedChanged, ChkPrecipProb.CheckedChanged, ChkSunrise.CheckedChanged, ChkSunset.CheckedChanged, ChkSunset.CheckedChanged, ChkVis.CheckedChanged, ChkWindDir.CheckedChanged, ChkWindSpeed.CheckedChanged, ChkWxCode.CheckedChanged, ChkMoonPhase.CheckedChanged

        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Daily_Temp = .Checked
                Case 1
                    My.Settings.Daily_FeelsLike = .Checked
                Case 2
                    My.Settings.Daily_Dewpoint = .Checked
                Case 3
                    My.Settings.Daily_Humidity = .Checked
                Case 4
                    My.Settings.Daily_WindSpeed = .Checked
                Case 5
                    My.Settings.Daily_WindDir = .Checked
                Case 6
                    My.Settings.Daily_Bp = .Checked
                Case 7
                    My.Settings.Daily_Precip = .Checked
                Case 8
                    My.Settings.Daily_PrecipProb = .Checked
                Case 9
                    My.Settings.Daily_PrecipAcc = .Checked
                Case 10
                    My.Settings.Daily_Sunrise = .Checked
                Case 11
                    My.Settings.Daily_Sunset = .Checked
                Case 12
                    My.Settings.Daily_Vis = .Checked
                Case 13
                    My.Settings.Daily_WxCode = .Checked
                Case 14
                    My.Settings.Daily_MoonPhase = .Checked
                Case Else
                    Exit Select
            End Select
            My.Settings.Save()
        End With

    End Sub

    Private Sub DailyCheckAll(sender As Object, e As EventArgs) Handles ChkAllDaily.CheckedChanged
        For Each c As CheckBox In FlpDaily.Controls.OfType(Of CheckBox)()
            If Not c.Checked And c.Enabled Then
                c.Checked = True
            End If
        Next
    End Sub

    Private Sub ChkUncheckAllDaily_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllDaily.CheckedChanged
        For Each c As CheckBox In FlpDaily.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
    End Sub

#End Region

#Region "Hourly Forecast"

    Private Sub HourlyCheckAll(sender As Object, e As EventArgs) Handles ChkAllHourly.CheckedChanged
        For Each c As CheckBox In FlpHourly.Controls.OfType(Of CheckBox)()
            If Not c.Checked And c.Enabled Then
                c.Checked = True
            End If
        Next
    End Sub

    Private Sub ChkUncheckAllHr_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllHr.CheckedChanged
        For Each c As CheckBox In FlpHourly.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
    End Sub

    Private Sub HourlyForecast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHrBP.CheckedChanged, ChkHrCloudBase.CheckedChanged, ChkHrCloudCeil.CheckedChanged, ChkHrCloudCover.CheckedChanged, ChkHrDewpoint.CheckedChanged, ChkHrMoonPhase.CheckedChanged, ChkHrPrecip.CheckedChanged, ChkHrPrecipProb.CheckedChanged, ChkHrPrecipType.CheckedChanged, ChkHrRH.CheckedChanged, ChkHrSSR.CheckedChanged, ChkHrSunrise.CheckedChanged, ChkHrSunset.CheckedChanged, ChkHrTemp.CheckedChanged, ChkHrVis.CheckedChanged, ChkHrWindDir.CheckedChanged, ChkHrWindGust.CheckedChanged, ChkHrWindSpeed.CheckedChanged, ChkHrWxCode.CheckedChanged, ChkHrFeelsLike.CheckedChanged, ChkHrTreePollen.CheckedChanged, ChkHrWeedPollen.CheckedChanged, ChkHrGrassPollen.CheckedChanged, ChkHrTreeAcacia.CheckedChanged, ChkHrTreeAsh.CheckedChanged, ChkHrTreeBeech.CheckedChanged, ChkHrTreeBirch.CheckedChanged, ChkHrTreeCedar.CheckedChanged, ChkHrTreeCottonwood.CheckedChanged, ChkHrTreeCypress.CheckedChanged, ChkHrTreeElder.CheckedChanged, ChkHrTreeElm.CheckedChanged, ChkHrGrass.CheckedChanged, ChkHrTreeHemlock.CheckedChanged, ChkHrTreeHickory.CheckedChanged, ChkHrTreeJuniper.CheckedChanged, ChkHrTreeMahogany.CheckedChanged, ChkHrTreeMaple.CheckedChanged, ChkHrTreeMulberry.CheckedChanged, ChkHrTreePine.CheckedChanged, ChkHrRagweed.CheckedChanged, ChkHrTreeSpruce.CheckedChanged, ChkHrTreeSycamore.CheckedChanged, ChkHrTreeWalnut.CheckedChanged, ChkHrTreeWillow.CheckedChanged, ChkHrTreeOak.CheckedChanged, ChkHrAqiPm10.CheckedChanged, ChkHrAqiPm25.CheckedChanged, ChkHrAqiO3.CheckedChanged, ChkHrAqiNo2.CheckedChanged, ChkHrAqiCo.CheckedChanged, ChkHrAqiSo2.CheckedChanged, ChkHrEpaAqi.CheckedChanged, ChkHrEpaConcern.CheckedChanged, ChkHrEpaPollutant.CheckedChanged, ChkHrChinaAqi.CheckedChanged, ChkHrChinaConcern.CheckedChanged, ChkHrChinaPollutant.CheckedChanged, ChkHrRiskCondition.CheckedChanged, ChkHrRiskConfidence.CheckedChanged, ChkHrRoadRisk.CheckedChanged, ChkHrRiskScore.CheckedChanged, ChkHrHailRisk.CheckedChanged

        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Hour_Temp = .Checked
                Case 1
                    My.Settings.Hour_FeelsLike = .Checked
                Case 2
                    My.Settings.Hour_Dewpoint = .Checked
                Case 3
                    My.Settings.Hour_Humidity = .Checked
                Case 4
                    My.Settings.Hour_WindSpeed = .Checked
                Case 5
                    My.Settings.Hour_WindDir = .Checked
                Case 6
                    My.Settings.Hour_WindGust = .Checked
                Case 7
                    My.Settings.Hour_Bp = .Checked
                Case 8
                    My.Settings.Hour_Precip = .Checked
                Case 9
                    My.Settings.Hour_PrecipType = .Checked
                Case 10
                    My.Settings.Hour_PrecipProb = .Checked
                Case 11
                    My.Settings.Hour_Sunrise = .Checked
                Case 12
                    My.Settings.Hour_Sunset = .Checked
                Case 13
                    My.Settings.Hour_Vis = .Checked
                Case 14
                    My.Settings.Hour_CloudCover = .Checked
                Case 15
                    My.Settings.Hour_CloudBase = .Checked
                Case 16
                    My.Settings.Hour_CloudCeil = .Checked
                Case 17
                    My.Settings.Hour_SSR = .Checked
                Case 18
                    My.Settings.Hour_MoonPhase = .Checked
                Case 19
                    My.Settings.Hour_WxCode = .Checked
                Case 20
                    My.Settings.Hour_TreePollen = .Checked
                Case 21
                    My.Settings.Hour_WeedPollen = .Checked
                Case 22
                    My.Settings.Hour_GrassPollen = .Checked
                Case 23
                    My.Settings.Hour_TreeAcacia = .Checked
                Case 24
                    My.Settings.Hour_TreeAsh = .Checked
                Case 25
                    My.Settings.Hour_TreeBeech = .Checked
                Case 26
                    My.Settings.Hour_TreeBirch = .Checked
                Case 27
                    My.Settings.Hour_TreeCedar = .Checked
                Case 28
                    My.Settings.Hour_TreeCypress = .Checked
                Case 29
                    My.Settings.Hour_TreeElder = .Checked
                Case 30
                    My.Settings.Hour_TreeElm = .Checked
                Case 31
                    My.Settings.Hour_TreeHemlock = .Checked
                Case 32
                    My.Settings.Hour_TreeHickory = .Checked
                Case 33
                    My.Settings.Hour_TreeJuniper = .Checked
                Case 34
                    My.Settings.Hour_TreeMahogany = .Checked
                Case 35
                    My.Settings.Hour_TreeMaple = .Checked
                Case 36
                    My.Settings.Hour_TreeMulberry = .Checked
                Case 37
                    My.Settings.Hour_TreeOak = .Checked
                Case 38
                    My.Settings.Hour_TreePine = .Checked
                Case 39
                    My.Settings.Hour_TreeCottonwood = .Checked
                Case 40
                    My.Settings.Hour_TreeSpruce = .Checked
                Case 41
                    My.Settings.Hour_TreeSycamore = .Checked
                Case 42
                    My.Settings.Hour_TreeWalnut = .Checked
                Case 43
                    My.Settings.Hour_TreeWillow = .Checked
                Case 44
                    My.Settings.Hour_Ragweed = .Checked
                Case 45
                    My.Settings.Hour_Grass = .Checked
                Case 46
                    My.Settings.Hour_Pm10 = .Checked
                Case 47
                    My.Settings.Hour_Pm25 = .Checked
                Case 48
                    My.Settings.Hour_O3 = .Checked
                Case 49
                    My.Settings.Hour_No2 = .Checked
                Case 50
                    My.Settings.Hour_Co = .Checked
                Case 51
                    My.Settings.Hour_So2 = .Checked
                Case 52
                    My.Settings.Hour_EpaAqi = .Checked
                Case 53
                    My.Settings.Hour_EpaHealthConcern = .Checked
                Case 54
                    My.Settings.Hour_EpaPrimaryPollutant = .Checked
                Case 55
                    My.Settings.Hour_ChinaAqi = .Checked
                Case 56
                    My.Settings.Hour_ChinaHealthConcern = .Checked
                Case 57
                    My.Settings.Hour_ChinaPrimaryPollutant = .Checked
                Case 58
                    My.Settings.Hour_RoadRisk = .Checked
                Case 59
                    My.Settings.Hour_RiskScore = .Checked
                Case 60
                    My.Settings.Hour_RiskConfidence = .Checked
                Case 61
                    My.Settings.Hour_RiskCondition = .Checked
                Case 62
                    My.Settings.Hour_HailRisk = .Checked
                Case Else
                    Exit Select
            End Select
            My.Settings.Save()
        End With

    End Sub

#End Region

#Region "Nowcast"

    Private Sub Nowcast_Data(sender As Object, e As EventArgs) Handles ChkNcBP.CheckedChanged, ChkNcCloudBase.CheckedChanged, ChkNcCloudCeil.CheckedChanged, ChkNcCloudCover.CheckedChanged, ChkNcDewpoint.CheckedChanged, ChkNcPrecip.CheckedChanged, ChkNcPrecipType.CheckedChanged, ChkNcRH.CheckedChanged, ChkNcSSR.CheckedChanged, ChkNcSunrise.CheckedChanged, ChkNcSunset.CheckedChanged, ChkNcTemp.CheckedChanged, ChkNcVis.CheckedChanged, ChkNcWindDir.CheckedChanged, ChkNcWindGust.CheckedChanged, ChkNcWindSpeed.CheckedChanged, ChkNcWxCode.CheckedChanged, ChkNcFeelsLike.CheckedChanged, ChkNcTreePollen.CheckedChanged, ChkNcWeedPollen.CheckedChanged, ChkNcGrassPollen.CheckedChanged, ChkNcAcacia.CheckedChanged, ChkNcAsh.CheckedChanged, ChkNcBeech.CheckedChanged, ChkNcBirch.CheckedChanged, ChkNcCedar.CheckedChanged, ChkNcCottonwood.CheckedChanged, ChkNcCypress.CheckedChanged, ChkNcElder.CheckedChanged, ChkNcElm.CheckedChanged, ChkNcGrass.CheckedChanged, ChkNcHemlock.CheckedChanged, ChkNcHickory.CheckedChanged, ChkNcJuniper.CheckedChanged, ChkNcMahogany.CheckedChanged, ChkNcMaple.CheckedChanged, ChkNcMulberry.CheckedChanged, ChkNcPine.CheckedChanged, ChkNcRagweed.CheckedChanged, ChkNcSpruce.CheckedChanged, ChkNcSycamore.CheckedChanged, ChkNcWalnut.CheckedChanged, ChkNcWillow.CheckedChanged, ChkNcOak.CheckedChanged, ChkNcPm10.CheckedChanged, ChkNcPm25.CheckedChanged, ChkNcO3.CheckedChanged, ChkNcNo2.CheckedChanged, ChkNcCo.CheckedChanged, ChkNcSo2.CheckedChanged, ChkNcEpaAqi.CheckedChanged, ChkNcEpaConcern.CheckedChanged, ChkNcEpaPollutant.CheckedChanged, ChkNcChinaAqi.CheckedChanged, ChkNcChinaConcern.CheckedChanged, ChkNcChinaPollutant.CheckedChanged, ChkNcRiskCondition.CheckedChanged, ChkNcRiskConfidence.CheckedChanged, ChkNcRoadRisk.CheckedChanged, ChkNcRiskScore.CheckedChanged, ChkNcHailRisk.CheckedChanged

        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Nc_Temp = .Checked
                Case 1
                    My.Settings.Nc_FeelsLike = .Checked
                Case 2
                    My.Settings.Nc_RH = .Checked
                Case 3
                    My.Settings.Nc_WindDir = .Checked
                Case 4
                    My.Settings.Nc_WindGust = .Checked
                Case 5
                    My.Settings.Nc_Precip = .Checked
                Case 6
                    My.Settings.Nc_PrecipType = .Checked
                Case 7
                    My.Settings.Nc_Sunrise = .Checked
                Case 8
                    My.Settings.Nc_Vis = .Checked
                Case 9
                    My.Settings.Nc_CloudCover = .Checked
                Case 10
                    My.Settings.Nc_CloudCeil = .Checked
                Case 11
                    My.Settings.Nc_WxCode = .Checked
                Case 12
                    My.Settings.Nc_Sunset = .Checked
                Case 13
                    My.Settings.Nc_Dewpoint = .Checked
                Case 14
                    My.Settings.Nc_WindSpeed = .Checked
                Case 15
                    My.Settings.Nc_CloudBase = .Checked
                Case 16
                    My.Settings.Nc_Bp = .Checked
                Case 17
                    My.Settings.Nc_SSR = .Checked
                Case 18
                    My.Settings.Nc_HailRisk = .Checked
                Case 19
                    My.Settings.Nc_TreePollen = .Checked
                Case 20
                    My.Settings.Nc_WeedPollen = .Checked
                Case 21
                    My.Settings.Nc_GrassPollen = .Checked
                Case 22
                    My.Settings.Nc_Acacia = .Checked
                Case 23
                    My.Settings.Nc_Birch = .Checked
                Case 24
                    My.Settings.Nc_Elder = .Checked
                Case 25
                    My.Settings.Nc_Hickory = .Checked
                Case 26
                    My.Settings.Nc_Maple = .Checked
                Case 27
                    My.Settings.Nc_Willow = .Checked
                Case 28
                    My.Settings.Nc_Ash = .Checked
                Case 29
                    My.Settings.Nc_Cedar = .Checked
                Case 30
                    My.Settings.Nc_Elm = .Checked
                Case 31
                    My.Settings.Nc_Juniper = .Checked
                Case 32
                    My.Settings.Nc_Mulberry = .Checked
                Case 33
                    My.Settings.Nc_Ragweed = .Checked
                Case 34
                    My.Settings.Nc_Beech = .Checked
                Case 35
                    My.Settings.Nc_Cypress = .Checked
                Case 36
                    My.Settings.Nc_Hemlock = .Checked
                Case 37
                    My.Settings.Nc_Mahogany = .Checked
                Case 38
                    My.Settings.Nc_Oak = .Checked
                Case 39
                    My.Settings.Nc_Grass = .Checked
                Case 40
                    My.Settings.Nc_Pine = .Checked
                Case 41
                    My.Settings.Nc_Cottonwood = .Checked
                Case 42
                    My.Settings.Nc_Spruce = .Checked
                Case 43
                    My.Settings.Nc_Sycamore = .Checked
                Case 44
                    My.Settings.Nc_Walnut = .Checked
                Case 45
                    My.Settings.Nc_Pm10 = .Checked
                Case 46
                    My.Settings.Nc_Pm25 = .Checked
                Case 47
                    My.Settings.NC_O3 = .Checked
                Case 48
                    My.Settings.Nc_Co = .Checked
                Case 49
                    My.Settings.Nc_So2 = .Checked
                Case 50
                    My.Settings.NC_No2 = .Checked
                Case 51
                    My.Settings.Nc_EpaAqi = .Checked
                Case 52
                    My.Settings.Nc_EpaHealthConcern = .Checked
                Case 53
                    My.Settings.NC_EpaPrimaryPollutant = .Checked
                Case 54
                    My.Settings.NC_ChinaAqi = .Checked
                Case 55
                    My.Settings.Nc_ChinaHealthConcern = .Checked
                Case 56
                    My.Settings.Nc_ChinaPrimaryPollutant = .Checked
                Case 57
                    My.Settings.Nc_RoadRisk = .Checked
                Case 58
                    My.Settings.Nc_RiskScore = .Checked
                Case 59
                    My.Settings.Nc_RiskConfidence = .Checked
                Case 60
                    My.Settings.Nc_RiskCondition = .Checked
                Case Else
                    Exit Select
            End Select
            My.Settings.Save()
        End With
    End Sub

    Private Sub NowcastCheckAll(sender As Object, e As EventArgs) Handles ChkAllNowcast.CheckedChanged
        For Each c As CheckBox In FlpNowcast.Controls.OfType(Of CheckBox)()
            If Not c.Checked And c.Enabled Then
                c.Checked = True
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub ChkUncheckAllNowcast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllNowcast.CheckedChanged
        For Each c As CheckBox In FlpNowcast.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub NumNcTimeStep_ValueChanged(sender As Object, e As EventArgs) Handles NumNcTimeStep.ValueChanged
        My.Settings.Nc_TimeStep = CInt(NumNcTimeStep.Value)
        My.Settings.Save()
    End Sub

#End Region

#End Region

#Region "Timers & Clock"

    Private Sub TmrUpdateDaily_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateDaily.Elapsed
        PrintLog($"Daily Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Daily Then
            DlyDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Daily, 0)
            DlyNextUp = Date.Now + DlyDuration
            PrintLog($"Next Daily Update @ {DlyNextUp:T}.{vbLf}")
            FetchDailyData()
        Else
            TmrUpdateDaily.Stop()
            PrintLog($"Daily update timer stopped.{vbLf}")
            TsslNextDaily.Text = My.Resources.daily_stop
        End If
    End Sub

    Private Sub TmrUpdateHourly_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateHourly.Elapsed
        PrintLog($"Hourly Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Hourly Then
            HrDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Hourly, 0)
            HrNextUp = Date.Now + HrDuration
            PrintLog($"Next Hourly Update @ {HrNextUp:T}.{vbLf}")
            FetchHourData()
        Else
            TmrUpdateHourly.Stop()
            PrintLog($"Hourly update timer stopped.{vbLf}")
            TsslNextHourly.Text = My.Resources.hourly_stop
        End If
    End Sub

    Private Sub TmrUpdateNowcast_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateNowcast.Elapsed
        PrintLog($"Nowcast Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Nowcast Then
            NcDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Nowcast, 0)
            NcNextUp = Date.Now + NcDuration
            PrintLog($"Next Nowcast Update @ {NcNextUp:T}.{vbLf}")
            FetchNowcastData()
        Else
            TmrUpdateNowcast.Stop()
            PrintLog($"Nowcast update timer stopped.{vbLf}")
            TsslNextNowcast.Text = My.Resources.nowcast_stop
        End If
    End Sub

    Private Sub TmrUpdateRt_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateRt.Elapsed
        PrintLog($"Realtime Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Nowcast Then
            RtDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Realtime, 0)
            RtNextUp = Date.Now + RtDuration
            PrintLog($"Next Realtime Update @ {RtNextUp:T}.{vbLf}")
            FetchRealtimeData()
        Else
            TmrUpdateRt.Stop()
            PrintLog($"Realtime update timer stopped.{vbLf}")
            TsslNextRt.Text = My.Resources.realtime_stop
        End If
    End Sub

    Private Sub TmrClock_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrClock.Elapsed
        TsslClock.Text = Now.ToLongTimeString

        If TmrUpdateDaily.Enabled Then
            TsslNextDaily.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, DlyNextUp) < 1,
     $"Dly: {DateDiff(DateInterval.Second, Date.Now, DlyNextUp):N0}",
     $"Dly: {DateDiff(DateInterval.Minute, Date.Now, DlyNextUp):N0}")
        End If

        If TmrUpdateHourly.Enabled Then
            TsslNextHourly.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, HrNextUp) < 1,
     $"Hr: {DateDiff(DateInterval.Second, Date.Now, HrNextUp):N0}",
     $"Hr: {DateDiff(DateInterval.Minute, Date.Now, HrNextUp):N0}")
        End If

        If TmrUpdateNowcast.Enabled Then
            TsslNextNowcast.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, NcNextUp) < 1,
    $"Nc: {DateDiff(DateInterval.Second, Date.Now, NcNextUp):N0}",
    $"Nc: {DateDiff(DateInterval.Minute, Date.Now, NcNextUp):N0}")
        End If

        If TmrUpdateRt.Enabled Then
            TsslNextRt.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, RtNextUp) < 1,
    $"Rt: {DateDiff(DateInterval.Second, Date.Now, RtNextUp):N0}",
    $"Rt: {DateDiff(DateInterval.Minute, Date.Now, RtNextUp):N0}")
        End If
    End Sub

    Private Sub TmrMidnight_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrMidnight.Elapsed
        Try
            PrintLog($"=> Midnight timer elapsed and stopped @ {Now:T}.{vbLf}")
            TmrMidnight.Stop()
            Dim _st As Date = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).AddDays(1)
            Dim _int As Long = Date2Unix(_st) - Date2Unix(Now)
            MidDuration = New TimeSpan(0, 0, 0, CInt(_int))
            MidNextUpdate = Date.Now + MidDuration
            TmrMidnight.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
            TmrMidnight.Start()
            PrintLog($"<== Midnight timer restarted @ {Now:T}.{vbLf}     Interval: {_int} seconds{vbLf}")

            Check4NewLogFile()
            SaveLogs()
        Catch ex As ArgumentNullException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            'a
        End Try
    End Sub

#End Region

#Region "Realtime"

    Private Sub ChkRtCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRtCheckAll.CheckedChanged
        For Each c As CheckBox In FlpRtOpt.Controls.OfType(Of CheckBox)()
            If Not c.Checked And c.Enabled Then
                c.Checked = True
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub ChkRtUncheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRtUncheckAll.CheckedChanged
        For Each c As CheckBox In FlpRtOpt.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub RtData(sender As Object, e As EventArgs) Handles ChkRtCore0.CheckedChanged, ChkRtCore1.CheckedChanged, ChkRtCore2.CheckedChanged, ChkRtCore3.CheckedChanged, ChkRtCore4.CheckedChanged, ChkRtCore5.CheckedChanged, ChkRtCore6.CheckedChanged, ChkRtCore7.CheckedChanged, ChkRtCore8.CheckedChanged, ChkRtCore9.CheckedChanged, ChkRtCore10.CheckedChanged, ChkRtCore11.CheckedChanged, ChkRtCore12.CheckedChanged, ChkRtCore13.CheckedChanged, ChkRtCore14.CheckedChanged, ChkRtCore15.CheckedChanged, ChkRtCore16.CheckedChanged, ChkRtCore17.CheckedChanged, ChkRtCore18.CheckedChanged, ChkRtCore19.CheckedChanged, ChkRtCore20.CheckedChanged, ChkRtPol0.CheckedChanged, ChkRtPol1.CheckedChanged, ChkRtPol2.CheckedChanged, ChkRtPol3.CheckedChanged, ChkRtPol4.CheckedChanged, ChkRtPol5.CheckedChanged, ChkRtPol6.CheckedChanged, ChkRtPol7.CheckedChanged, ChkRtPol8.CheckedChanged, ChkRtPol9.CheckedChanged, ChkRtPol10.CheckedChanged, ChkRtPol11.CheckedChanged, ChkRtPol12.CheckedChanged, ChkRtPol13.CheckedChanged, ChkRtPol14.CheckedChanged, ChkRtPol15.CheckedChanged, ChkRtPol16.CheckedChanged, ChkRtPol17.CheckedChanged, ChkRtPol18.CheckedChanged, ChkRtPol19.CheckedChanged, ChkRtPol20.CheckedChanged, ChkRtPol21.CheckedChanged, ChkRtPol22.CheckedChanged, ChkRtPol24.CheckedChanged, ChkRtPol23.CheckedChanged, ChkRtPol25.CheckedChanged, ChkRtRoad0.CheckedChanged, ChkRtRoad1.CheckedChanged, ChkRtRoad2.CheckedChanged, ChkRtRoad3.CheckedChanged, ChkRtFire0.CheckedChanged, ChkRtHail0.CheckedChanged, ChkRtAqi0.CheckedChanged, ChkRtAqi1.CheckedChanged, ChkRtAqi2.CheckedChanged, ChkRtAqi3.CheckedChanged, ChkRtAqi4.CheckedChanged, ChkRtAqi5.CheckedChanged, ChkRtAqi6.CheckedChanged, ChkRtAqi7.CheckedChanged, ChkRtAqi8.CheckedChanged, ChkRtAqi9.CheckedChanged, ChkRtAqi10.CheckedChanged, ChkRtAqi11.CheckedChanged
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Rt_Core0 = .Checked
                Case 1
                    My.Settings.Rt_Core1 = .Checked
                Case 2
                    My.Settings.Rt_Core2 = .Checked
                Case 3
                    My.Settings.Rt_Core3 = .Checked
                Case 4
                    My.Settings.Rt_Core4 = .Checked
                Case 5
                    My.Settings.Rt_Core5 = .Checked
                Case 6
                    My.Settings.Rt_Core6 = .Checked
                Case 7
                    My.Settings.Rt_Core7 = .Checked
                Case 8
                    My.Settings.Rt_Core8 = .Checked
                Case 9
                    My.Settings.Rt_Core9 = .Checked
                Case 10
                    My.Settings.Rt_Core10 = .Checked
                Case 11
                    My.Settings.Rt_Core11 = .Checked
                Case 12
                    My.Settings.Rt_Core12 = .Checked
                Case 13
                    My.Settings.Rt_Core13 = .Checked
                Case 14
                    My.Settings.Rt_Core14 = .Checked
                Case 15
                    My.Settings.Rt_Core15 = .Checked
                Case 16
                    My.Settings.Rt_Core16 = .Checked
                Case 17
                    My.Settings.Rt_Core17 = .Checked
                Case 18
                    My.Settings.Rt_Core18 = .Checked
                Case 19
                    My.Settings.Rt_Core19 = .Checked
                Case 20
                    My.Settings.Rt_Core20 = .Checked
                Case 21
                    My.Settings.Rt_Pol0 = .Checked
                Case 22
                    My.Settings.Rt_Pol1 = .Checked
                Case 23
                    My.Settings.Rt_Pol2 = .Checked
                Case 24
                    My.Settings.Rt_Pol3 = .Checked
                Case 25
                    My.Settings.Rt_Pol4 = .Checked
                Case 26
                    My.Settings.Rt_Pol5 = .Checked
                Case 27
                    My.Settings.Rt_Pol6 = .Checked
                Case 28
                    My.Settings.Rt_Pol7 = .Checked
                Case 29
                    My.Settings.Rt_Pol8 = .Checked
                Case 30
                    My.Settings.Rt_Pol9 = .Checked
                Case 31
                    My.Settings.Rt_Pol10 = .Checked
                Case 32
                    My.Settings.Rt_Pol11 = .Checked
                Case 33
                    My.Settings.Rt_Pol12 = .Checked
                Case 34
                    My.Settings.Rt_Pol13 = .Checked
                Case 35
                    My.Settings.Rt_Pol14 = .Checked
                Case 36
                    My.Settings.Rt_Pol15 = .Checked
                Case 37
                    My.Settings.Rt_Pol16 = .Checked
                Case 38
                    My.Settings.Rt_Pol17 = .Checked
                Case 39
                    My.Settings.Rt_Pol18 = .Checked
                Case 40
                    My.Settings.Rt_Pol19 = .Checked
                Case 41
                    My.Settings.Rt_Pol20 = .Checked
                Case 42
                    My.Settings.Rt_Pol21 = .Checked
                Case 43
                    My.Settings.Rt_Pol22 = .Checked
                Case 44
                    My.Settings.Rt_Pol23 = .Checked
                Case 45
                    My.Settings.Rt_Pol24 = .Checked
                Case 46
                    My.Settings.Rt_Pol25 = .Checked
                Case 47
                    My.Settings.Rt_Road0 = .Checked
                Case 48
                    My.Settings.Rt_Road1 = .Checked
                Case 49
                    My.Settings.Rt_Road2 = .Checked
                Case 50
                    My.Settings.Rt_Road3 = .Checked
                Case 51
                    My.Settings.Rt_Fire0 = .Checked
                Case 52
                    My.Settings.Rt_Hail0 = .Checked
                Case 53
                    My.Settings.Rt_Aqi0 = .Checked
                Case 54
                    My.Settings.Rt_Aqi1 = .Checked
                Case 55
                    My.Settings.Rt_Aqi2 = .Checked
                Case 56
                    My.Settings.Rt_Aqi3 = .Checked
                Case 57
                    My.Settings.Rt_Aqi4 = .Checked
                Case 58
                    My.Settings.Rt_Aqi5 = .Checked
                Case 59
                    My.Settings.Rt_Aqi6 = .Checked
                Case 60
                    My.Settings.Rt_Aqi7 = .Checked
                Case 61
                    My.Settings.Rt_Aqi8 = .Checked
                Case 62
                    My.Settings.Rt_Aqi9 = .Checked
                Case 63
                    My.Settings.Rt_Aqi10 = .Checked
                Case 64
                    My.Settings.Rt_Aqi11 = .Checked
                Case Else
                    Exit Select
            End Select
        End With
    End Sub

#End Region

End Class
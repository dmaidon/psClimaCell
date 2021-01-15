Imports System.IO

Public Class FrmMain

    'C:\Users\dmaid\AppData\Local\PAROLE_Software\ClimaCell.exe_Url_2dgbsvwgjqedz0grtx5rs15dcfk2xfjp
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpgradeMySettings()
        LoadProgramSettings()
        CreateProgramFolders()
        StartLogfile()
        PerformLogMaintenance()

        Text = $"ClimaCell 15-Day Weather Forecast - Tr: {My.Settings.TimesRun}"
        TsslCpy.Text = Cpy
        TsslVer.Text = Application.ProductVersion
        LblAbout.Text = $"Written by: Dennis N Maidon{vbLf}PAROLE Software{vbLf}VB.Net{vbLf}.Net Framework 4.8{vbLf}Compiled: {ParseVersion()}"

        SetMidnightRollover()

        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
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
        'TsslMN.ForeColor = Color.Green
        'TsslMidnight.Visible = True
        'CalMonth.SetDate(Now)
        'CalMonth.Refresh()
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


        ''Daily settings
        ChkBP.Checked = My.Settings.Daily_Bp
        ChkDewpoint.Checked = My.Settings.Daily_Dewpoint
        ChkFeelsLike.Checked = My.Settings.Daily_FeelsLike
        ChkHumidity.Checked = My.Settings.Daily_Humidity
        ChkPrecip.Checked = My.Settings.Daily_Precip
        ChkPrecipAcc.Checked = My.Settings.Daily_PrecipAcc
        ChkPrecipProb.Checked = My.Settings.Daily_PrecipProb
        ChkSunrise.Checked = My.Settings.Daily_Sunrise
        ChkSunset.Checked = My.Settings.Daily_Sunset
        ChkTemp.Checked = My.Settings.Daily_Temp
        ChkVis.Checked = My.Settings.Daily_Vis
        ChkWindDir.Checked = My.Settings.Daily_WindDir
        ChkWindSpeed.Checked = My.Settings.Daily_WindSpeed
        ChkWxCode.Checked = My.Settings.Daily_WxCode
        ChkMoonPhase.Checked = My.Settings.Daily_MoonPhase

        'Hour settings
        ChkHourBP.Checked = My.Settings.Hour_Bp
        ChkHourDewpoint.Checked = My.Settings.Hour_Dewpoint
        ChkHourFeelsLike.Checked = My.Settings.Hour_FeelsLike
        ChkHourRH.Checked = My.Settings.Hour_Humidity
        ChkHourPrecip.Checked = My.Settings.Hour_Precip
        ChkHourPrecipType.Checked = My.Settings.Hour_PrecipType
        ChkHourPrecipProb.Checked = My.Settings.Hour_PrecipProb
        ChkHourSunrise.Checked = My.Settings.Hour_Sunrise
        ChkHourSunset.Checked = My.Settings.Hour_Sunset
        ChkHourTemp.Checked = My.Settings.Hour_Temp
        ChkHourVis.Checked = My.Settings.Hour_Vis
        ChkHourWindDir.Checked = My.Settings.Hour_WindDir
        ChkHourWindSpeed.Checked = My.Settings.Hour_WindSpeed
        ChkHourWindGust.Checked = My.Settings.Hour_WindGust
        ChkHourWxCode.Checked = My.Settings.Hour_WxCode
        ChkHourMoonPhase.Checked = My.Settings.Hour_MoonPhase
        ChkHourSSR.Checked = My.Settings.Hour_SSR
        ChkHourCloudBase.Checked = My.Settings.Hour_CloudBase
        ChkHourCloudCeil.Checked = My.Settings.Hour_CloudCeil
        ChkHourCloudCover.Checked = My.Settings.Hour_CloudCover
        ChkHourTreePollen.Checked = My.Settings.Hour_TreePollen
        ChkHourWeedPollen.Checked = My.Settings.Hour_WeedPollen
        ChkHourGrassPollen.Checked = My.Settings.Hour_GrassPollen
        ChkHourTreeAcacia.Checked = My.Settings.Hour_TreeAcacia
        ChkHourTreeAsh.Checked = My.Settings.Hour_TreeAsh
        ChkHourTreeBeech.Checked = My.Settings.Hour_TreeBeech
        ChkHourTreeBirch.Checked = My.Settings.Hour_TreeBirch
        ChkHourTreeCedar.Checked = My.Settings.Hour_TreeCedar
        ChkHourTreeCottonwood.Checked = My.Settings.Hour_TreeCottonwood
        ChkHourTreeCypress.Checked = My.Settings.Hour_TreeCypress
        ChkHourTreeElder.Checked = My.Settings.Hour_TreeElder
        ChkHourTreeElm.Checked = My.Settings.Hour_TreeElm
        ChkHourGrass.Checked = My.Settings.Hour_Grass
        ChkHourTreeHemlock.Checked = My.Settings.Hour_TreeHemlock
        ChkHourTreeHickory.Checked = My.Settings.Hour_TreeHickory
        ChkHourTreeJuniper.Checked = My.Settings.Hour_TreeJuniper
        ChkHourTreeMahogany.Checked = My.Settings.Hour_TreeMahogany
        ChkHourTreeMaple.Checked = My.Settings.Hour_TreeMaple
        ChkHourTreeMulberry.Checked = My.Settings.Hour_TreeMulberry
        ChkHourTreeOak.Checked = My.Settings.Hour_TreeOak
        ChkHourTreePine.Checked = My.Settings.Hour_TreePine
        ChkHourRagweed.Checked = My.Settings.Hour_Ragweed
        ChkHourTreeSpruce.Checked = My.Settings.Hour_TreeSpruce
        ChkHourTreeSycamore.Checked = My.Settings.Hour_TreeSycamore
        ChkHourTreeWalnut.Checked = My.Settings.Hour_TreeWalnut
        ChkHourTreeWillow.Checked = My.Settings.Hour_TreeWillow
        ChkHourAqiPm10.Checked = My.Settings.Hour_Pm10
        ChkHourAqiPm25.Checked = My.Settings.Hour_Pm25
        ChkHourAqiO3.Checked = My.Settings.Hour_O3
        ChkHourAqiNo2.Checked = My.Settings.Hour_No2
        ChkHourAqiCo.Checked = My.Settings.Hour_Co
        ChkHourAqiSo2.Checked = My.Settings.Hour_So2
        ChkHourEpaAqi.Checked = My.Settings.Hour_EpaAqi
        ChkHourEpaConcern.Checked = My.Settings.Hour_EpaHealthConcern
        ChkHourEpaPollutant.Checked = My.Settings.Hour_EpaPrimaryPollutant
        ChkHourChinaAqi.Checked = My.Settings.Hour_ChinaAqi
        ChkHourChinaConcern.Checked = My.Settings.Hour_ChinaHealthConcern
        ChkHourChinaPollutant.Checked = My.Settings.Hour_ChinaPrimaryPollutant
        ChkHrRoadRisk.Checked = My.Settings.Hour_RoadRisk
        ChkHrRiskScore.Checked = My.Settings.Hour_RiskScore
        ChkHrRiskConfidence.Checked = My.Settings.Hour_RiskConfidence
        ChkHrRiskCondition.Checked = My.Settings.Hour_RiskCondition
        ChkHrHailRisk.Checked = My.Settings.Hour_HailRisk

        'Nowcast settings

        ChkNcBP.Checked = My.Settings.Nc_Bp
        ChkNcDewpoint.Checked = My.Settings.Nc_Dewpoint
        ChkNcFeelsLike.Checked = My.Settings.Nc_FeelsLike
        ChkNcRH.Checked = My.Settings.Nc_RH
        ChkNcPrecip.Checked = My.Settings.Nc_Precip
        ChkNcPrecipType.Checked = My.Settings.Nc_PrecipType
        ChkNcSunrise.Checked = My.Settings.Nc_Sunrise
        ChkNcSunset.Checked = My.Settings.Nc_Sunset
        ChkNcTemp.Checked = My.Settings.Nc_Temp
        ChkNcVis.Checked = My.Settings.Nc_Vis
        ChkNcWindDir.Checked = My.Settings.Nc_WindDir
        ChkNcWindSpeed.Checked = My.Settings.Nc_WindSpeed
        ChkNcWindGust.Checked = My.Settings.Nc_WindGust
        ChkNcWxCode.Checked = My.Settings.Nc_WxCode
        ChkNcSSR.Checked = My.Settings.Nc_SSR
        ChkNcCloudBase.Checked = My.Settings.Nc_CloudBase
        ChkNcCloudCeil.Checked = My.Settings.Nc_CloudCeil
        ChkNcCloudCover.Checked = My.Settings.Nc_CloudCover
        ChkNcTreePollen.Checked = My.Settings.Nc_TreePollen
        ChkNcWeedPollen.Checked = My.Settings.Nc_WeedPollen
        ChkNcGrassPollen.Checked = My.Settings.Nc_GrassPollen
        ChkNcAcacia.Checked = My.Settings.Nc_Acacia
        ChkNcAsh.Checked = My.Settings.Nc_Ash
        ChkNcBeech.Checked = My.Settings.Nc_Beech
        ChkNcBirch.Checked = My.Settings.Nc_Birch
        ChkNcCedar.Checked = My.Settings.Nc_Cedar
        ChkNcCottonwood.Checked = My.Settings.Nc_Cottonwood
        ChkNcCypress.Checked = My.Settings.Nc_Cypress
        ChkNcElder.Checked = My.Settings.Nc_Elder
        ChkNcElm.Checked = My.Settings.Nc_Elm
        ChkNcGrass.Checked = My.Settings.Nc_Grass
        ChkNcHemlock.Checked = My.Settings.Nc_Hemlock
        ChkNcHickory.Checked = My.Settings.Nc_Hickory
        ChkNcJuniper.Checked = My.Settings.Nc_Juniper
        ChkNcMahogany.Checked = My.Settings.Nc_Mahogany
        ChkNcMaple.Checked = My.Settings.Nc_Maple
        ChkNcMulberry.Checked = My.Settings.Nc_Mulberry
        ChkNcOak.Checked = My.Settings.Nc_Oak
        ChkNcPine.Checked = My.Settings.Nc_Pine
        ChkNcRagweed.Checked = My.Settings.Nc_Ragweed
        ChkNcSpruce.Checked = My.Settings.Nc_Spruce
        ChkNcSycamore.Checked = My.Settings.Nc_Sycamore
        ChkNcWalnut.Checked = My.Settings.Nc_Walnut
        ChkNcWillow.Checked = My.Settings.Nc_Willow
        ChkNcPm10.Checked = My.Settings.Nc_Pm10
        ChkNcPm25.Checked = My.Settings.Nc_Pm25
        ChkNcO3.Checked = My.Settings.NC_O3
        ChkNcNo2.Checked = My.Settings.NC_No2
        ChkNcCo.Checked = My.Settings.Nc_Co
        ChkNcSo2.Checked = My.Settings.Nc_So2
        ChkNcEpaAqi.Checked = My.Settings.Nc_EpaAqi
        ChkNcEpaConcern.Checked = My.Settings.Nc_EpaHealthConcern
        ChkNcEpaPollutant.Checked = My.Settings.NC_EpaPrimaryPollutant
        ChkNcChinaAqi.Checked = My.Settings.NC_ChinaAqi
        ChkNcChinaConcern.Checked = My.Settings.Nc_ChinaHealthConcern
        ChkNcChinaPollutant.Checked = My.Settings.Nc_ChinaPrimaryPollutant
        ChkNcRoadRisk.Checked = My.Settings.Nc_RoadRisk
        ChkNcRiskScore.Checked = My.Settings.Nc_RiskScore
        ChkNcRiskConfidence.Checked = My.Settings.Nc_RiskConfidence
        ChkNcRiskCondition.Checked = My.Settings.Nc_RiskCondition
        ChkNcHailRisk.Checked = My.Settings.Nc_HailRisk

        ''realtime settings
        ChkRtCore0.Checked = My.Settings.Rt_Core0
        ChkRtCore1.Checked = My.Settings.Rt_Core1
        ChkRtCore2.Checked = My.Settings.Rt_Core2
        ChkRtCore3.Checked = My.Settings.Rt_Core3
        ChkRtCore4.Checked = My.Settings.Rt_Core4
        ChkRtCore5.Checked = My.Settings.Rt_Core5
        ChkRtCore6.Checked = My.Settings.Rt_Core6
        ChkRtCore7.Checked = My.Settings.Rt_Core7
        ChkRtCore8.Checked = My.Settings.Rt_Core8
        ChkRtCore9.Checked = My.Settings.Rt_Core9
        ChkRtCore10.Checked = My.Settings.Rt_Core10
        ChkRtCore11.Checked = My.Settings.Rt_Core11
        ChkRtCore12.Checked = My.Settings.Rt_Core12
        ChkRtCore13.Checked = My.Settings.Rt_Core13
        ChkRtCore14.Checked = My.Settings.Rt_Core14
        ChkRtCore15.Checked = My.Settings.Rt_Core15
        ChkRtCore16.Checked = My.Settings.Rt_Core16
        ChkRtCore17.Checked = My.Settings.Rt_Core17
        ChkRtCore18.Checked = My.Settings.Rt_Core18
        ChkRtCore19.Checked = My.Settings.Rt_Core19
        ChkRtCore20.Checked = My.Settings.Rt_Core20


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

    Private Sub FetchData(sender As Object, e As EventArgs) Handles ChkFetchDaily.CheckedChanged, ChkFetchHourly.CheckedChanged, ChkFetchNowcast.CheckedChanged, ChkFetchRt.CheckedChanged
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
        For Each c As CheckBox In TlpDaily.Controls.OfType(Of CheckBox)()
            If Not c.Checked Then
                c.Checked = True
            End If
        Next
    End Sub

    Private Sub ChkUncheckAllDaily_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllDaily.CheckedChanged
        For Each c As CheckBox In TlpDaily.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
    End Sub

#End Region

#Region "Hourly Forecast"

    Private Sub HourlyCheckAll(sender As Object, e As EventArgs) Handles ChkAllHourly.CheckedChanged
        For Each c As CheckBox In TlpHourly.Controls.OfType(Of CheckBox)()
            If Not c.Checked Then
                c.Checked = True
            End If
        Next
    End Sub

    Private Sub ChkUncheckAllHr_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllHr.CheckedChanged
        For Each c As CheckBox In TlpHourly.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
    End Sub

    Private Sub HourlyForecast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHourBP.CheckedChanged, ChkHourCloudBase.CheckedChanged, ChkHourCloudCeil.CheckedChanged, ChkHourCloudCover.CheckedChanged, ChkHourDewpoint.CheckedChanged, ChkHourMoonPhase.CheckedChanged, ChkHourPrecip.CheckedChanged, ChkHourPrecipProb.CheckedChanged, ChkHourPrecipType.CheckedChanged, ChkHourRH.CheckedChanged, ChkHourSSR.CheckedChanged, ChkHourSunrise.CheckedChanged, ChkHourSunset.CheckedChanged, ChkHourTemp.CheckedChanged, ChkHourVis.CheckedChanged, ChkHourWindDir.CheckedChanged, ChkHourWindGust.CheckedChanged, ChkHourWindSpeed.CheckedChanged, ChkHourWxCode.CheckedChanged, ChkHourFeelsLike.CheckedChanged, ChkHourTreePollen.CheckedChanged, ChkHourWeedPollen.CheckedChanged, ChkHourGrassPollen.CheckedChanged, ChkHourTreeAcacia.CheckedChanged, ChkHourTreeAsh.CheckedChanged, ChkHourTreeBeech.CheckedChanged, ChkHourTreeBirch.CheckedChanged, ChkHourTreeCedar.CheckedChanged, ChkHourTreeCottonwood.CheckedChanged, ChkHourTreeCypress.CheckedChanged, ChkHourTreeElder.CheckedChanged, ChkHourTreeElm.CheckedChanged, ChkHourGrass.CheckedChanged, ChkHourTreeHemlock.CheckedChanged, ChkHourTreeHickory.CheckedChanged, ChkHourTreeJuniper.CheckedChanged, ChkHourTreeMahogany.CheckedChanged, ChkHourTreeMaple.CheckedChanged, ChkHourTreeMulberry.CheckedChanged, ChkHourTreePine.CheckedChanged, ChkHourRagweed.CheckedChanged, ChkHourTreeSpruce.CheckedChanged, ChkHourTreeSycamore.CheckedChanged, ChkHourTreeWalnut.CheckedChanged, ChkHourTreeWillow.CheckedChanged, ChkHourTreeOak.CheckedChanged, ChkHourAqiPm10.CheckedChanged, ChkHourAqiPm25.CheckedChanged, ChkHourAqiO3.CheckedChanged, ChkHourAqiNo2.CheckedChanged, ChkHourAqiCo.CheckedChanged, ChkHourAqiSo2.CheckedChanged, ChkHourEpaAqi.CheckedChanged, ChkHourEpaConcern.CheckedChanged, ChkHourEpaPollutant.CheckedChanged, ChkHourChinaAqi.CheckedChanged, ChkHourChinaConcern.CheckedChanged, ChkHourChinaPollutant.CheckedChanged, ChkHrRiskCondition.CheckedChanged, ChkHrRiskConfidence.CheckedChanged, ChkHrRoadRisk.CheckedChanged, ChkHrRiskScore.CheckedChanged, ChkHrHailRisk.CheckedChanged

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
        For Each c As CheckBox In TlpNowcast.Controls.OfType(Of CheckBox)()
            If Not c.Checked Then
                c.Checked = True
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub ChkUncheckAllNowcast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUncheckAllNowcast.CheckedChanged
        For Each c As CheckBox In TlpNowcast.Controls.OfType(Of CheckBox)()
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
        End If
    End Sub

    Private Sub TmrUpdateHourly_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateHourly.Elapsed
        PrintLog($"Hourly Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Hourly Then
            HrDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Hourly, 0)
            HrNextUp = Date.Now + HrDuration
            PrintLog($"Next Hourly Update @ {HrNextUp:T}.{vbLf}")
            FetchHourData()
        End If
    End Sub

    Private Sub TmrUpdateNowcast_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateNowcast.Elapsed
        PrintLog($"Nowcast Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Nowcast Then
            NcDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Nowcast, 0)
            NcNextUp = Date.Now + NcDuration
            PrintLog($"Next Nowcast Update @ {NcNextUp:T}.{vbLf}")
            FetchNowcastData()
        End If
    End Sub


    Private Sub TmrUpdateRt_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdateRt.Elapsed
        PrintLog($"Realtime Update timer elapsed @ {Now:T}.{vbLf}")
        If My.Settings.Fetch_Nowcast Then
            RtDuration = New TimeSpan(0, 0, My.Settings.UpdateInterval_Realtime, 0)
            RtNextUp = Date.Now + RtDuration
            PrintLog($"Next Realtime Update @ {RtNextUp:T}.{vbLf}")
            FetchRealtimeData()
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
            If Not c.Checked Then
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

    Private Sub RtData(sender As Object, e As EventArgs) Handles ChkRtCore0.CheckedChanged, ChkRtCore1.CheckedChanged, ChkRtCore2.CheckedChanged, ChkRtCore3.CheckedChanged, ChkRtCore4.CheckedChanged, ChkRtCore5.CheckedChanged, ChkRtCore6.CheckedChanged, ChkRtCore7.CheckedChanged, ChkRtCore8.CheckedChanged, ChkRtCore9.CheckedChanged, ChkRtCore10.CheckedChanged, ChkRtCore11.CheckedChanged, ChkRtCore12.CheckedChanged, ChkRtCore13.CheckedChanged, ChkRtCore14.CheckedChanged, ChkRtCore15.CheckedChanged, ChkRtCore16.CheckedChanged, ChkRtCore17.CheckedChanged, ChkRtCore18.CheckedChanged, ChkRtCore19.CheckedChanged, ChkRtCore20.CheckedChanged
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
                Case Else
                    Exit Select
            End Select
        End With
    End Sub

#End Region
End Class
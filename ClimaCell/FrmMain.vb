Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers

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

        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
            TC.SelectedTab = TpSettings
        Else
            If My.Settings.Fetch_Daily Then
                FetchDailyData()
            End If
            If My.Settings.Fetch_Hourly Then
                FetchHourData()
            End If
        End If

        SaveLogs()
        TmrClock.Start()
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

    Private Sub TmrUpdate_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrUpdate.Elapsed
        PrintLog($"Update timer elapsed @ {Now:T}.{vbLf}")
        Duration = New TimeSpan(0, 0, tSpan, 0)
        NextUp = Date.Now + Duration
        FetchDailyData()
        FetchHourData()
    End Sub

    Private Sub TmrClock_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrClock.Elapsed
        TsslClock.Text = Now.ToLongTimeString
        If TmrUpdate.Enabled Then
            With DgvDaily
                TsslNextUpdate.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, NextUp) < 1,
                    $"{DateDiff(DateInterval.Second, Date.Now, NextUp):N0} sec",
                    $"{DateDiff(DateInterval.Minute, Date.Now, NextUp):N0} min")
            End With
        End If
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
        PrintLog($"Program closed @ {Now:F}.{vbLf}")
        SaveLogs()
    End Sub

    Private Sub NumLatiutude_ValueChanged(sender As Object, e As EventArgs) Handles NumLatiutude.ValueChanged, NumLongitude.ValueChanged, NumUpdateInterval.ValueChanged
        With DirectCast(sender, NumericUpDown)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.cLatitude = .Value
                Case 1
                    My.Settings.cLongitude = .Value
                Case 2
                    My.Settings.UpdateInterval = CInt(.Value)
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
    End Sub

    Private Sub Num_Enter(sender As Object, e As EventArgs) Handles NumLatiutude.Enter, NumLongitude.Enter, NumUpdateInterval.Enter
        Dim ct = DirectCast(sender, NumericUpDown)
        ct.Select(0, ct.Text.Length)
    End Sub

    Private Sub LoadProgramSettings()
        NumLatiutude.Value = CDec(My.Settings.cLatitude)
        NumLongitude.Value = CDec(My.Settings.cLongitude)
        NumUpdateInterval.Value = My.Settings.UpdateInterval
        TxtApiKey.Text = My.Settings.ApiKey
        tSpan = My.Settings.UpdateInterval
        If tSpan > 0 Then
            TmrUpdate.Interval = TimeSpan.FromMinutes(tSpan).TotalMilliseconds
            Duration = New TimeSpan(0, 0, tSpan, 0)
            NextUp = Date.Now + Duration
            TmrUpdate.Start()
        End If

        ChkFetchDaily.Checked = My.Settings.Fetch_Daily
        ChkFetchHourly.Checked = My.Settings.Fetch_Hourly

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
        ChkRoadRisk.Checked = My.Settings.Hour_RoadRisk
        ChkRiskScore.Checked = My.Settings.Hour_RiskScore
        ChkRiskConfidence.Checked = My.Settings.Hour_RiskConfidence
        ChkRiskCondition.Checked = My.Settings.Hour_RiskCondition
        ChkHailRisk.Checked = My.Settings.Hour_HailRisk

        Select Case My.Settings.Units
            Case 0
                RbUnitUS.Checked = True
            Case 1
                RbUnitSI.Checked = True
            Case Else
                RbUnitUS.Checked = True
        End Select
    End Sub

    Private Sub TxtApiKey_TextChanged(sender As Object, e As EventArgs) Handles TxtApiKey.TextChanged
        My.Settings.ApiKey = TxtApiKey.Text
        My.Settings.Save()
    End Sub

    Private Sub Units_CheckedChanged(sender As Object, e As EventArgs) Handles RbUnitUS.CheckedChanged, RbUnitSI.CheckedChanged
        Dim ct = DirectCast(sender, RadioButton)
        My.Settings.Units = CInt(ct.Tag)
        My.Settings.Save()
    End Sub

    'Private Shared Async Sub FetchLocationID()
    '    Using client As New HttpClient()
    '        Using request = New HttpRequestMessage(New HttpMethod("POST"), $"https://api.climacell.co/v3/locations?apikey={My.Settings.ApiKey}")
    '            request.Content = New StringContent("{""point"": {""lat"":35.625556,""lon"":-78.328611},""name"":""Wilsons Mills, NC""}")
    '            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json")

    '            Using response = Await client.SendAsync(request)
    '                ' Dim dStr = response
    '                'Using reader = New StreamReader(dStr)
    '                '    Dim resp As String = Await reader.ReadToEndAsync()
    '                '    File.WriteAllText(Path.Combine(Application.StartupPath, TempDir, "location.json"), resp)
    '                'End Using
    '                MsgBox(response.ToString)
    '            End Using
    '        End Using
    '    End Using

    'End Sub

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
        For Each c As CheckBox In GbDailyFields.Controls.OfType(Of CheckBox)()
            c.Checked = Not c.Checked
        Next
    End Sub

#End Region

#Region "Hourly Forecast"

    Private Sub HourlyCheckAll(sender As Object, e As EventArgs) Handles ChkAllHourly.CheckedChanged
        For Each c As CheckBox In GbHourlyFields.Controls.OfType(Of CheckBox)()
            If Not c.Checked Then
                c.Checked = True
            End If
        Next
    End Sub

    Private Sub HourlyForecast_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHourBP.CheckedChanged, ChkHourCloudBase.CheckedChanged, ChkHourCloudCeil.CheckedChanged, ChkHourCloudCover.CheckedChanged, ChkHourDewpoint.CheckedChanged, ChkHourMoonPhase.CheckedChanged, ChkHourPrecip.CheckedChanged, ChkHourPrecipProb.CheckedChanged, ChkHourPrecipType.CheckedChanged, ChkHourRH.CheckedChanged, ChkHourSSR.CheckedChanged, ChkHourSunrise.CheckedChanged, ChkHourSunset.CheckedChanged, ChkHourTemp.CheckedChanged, ChkHourVis.CheckedChanged, ChkHourWindDir.CheckedChanged, ChkHourWindGust.CheckedChanged, ChkHourWindSpeed.CheckedChanged, ChkHourWxCode.CheckedChanged, ChkHourFeelsLike.CheckedChanged, ChkHourTreePollen.CheckedChanged, ChkHourWeedPollen.CheckedChanged, ChkHourGrassPollen.CheckedChanged, ChkHourTreeAcacia.CheckedChanged, ChkHourTreeAsh.CheckedChanged, ChkHourTreeBeech.CheckedChanged, ChkHourTreeBirch.CheckedChanged, ChkHourTreeCedar.CheckedChanged, ChkHourTreeCottonwood.CheckedChanged, ChkHourTreeCypress.CheckedChanged, ChkHourTreeElder.CheckedChanged, ChkHourTreeElm.CheckedChanged, ChkHourGrass.CheckedChanged, ChkHourTreeHemlock.CheckedChanged, ChkHourTreeHickory.CheckedChanged, ChkHourTreeJuniper.CheckedChanged, ChkHourTreeMahogany.CheckedChanged, ChkHourTreeMaple.CheckedChanged, ChkHourTreeMulberry.CheckedChanged, ChkHourTreePine.CheckedChanged, ChkHourRagweed.CheckedChanged, ChkHourTreeSpruce.CheckedChanged, ChkHourTreeSycamore.CheckedChanged, ChkHourTreeWalnut.CheckedChanged, ChkHourTreeWillow.CheckedChanged, ChkHourTreeOak.CheckedChanged, ChkHourAqiPm10.CheckedChanged, ChkHourAqiPm25.CheckedChanged, ChkHourAqiO3.CheckedChanged, ChkHourAqiNo2.CheckedChanged, ChkHourAqiCo.CheckedChanged, ChkHourAqiSo2.CheckedChanged, ChkHourEpaAqi.CheckedChanged, ChkHourEpaConcern.CheckedChanged, ChkHourEpaPollutant.CheckedChanged, ChkHourChinaAqi.CheckedChanged, ChkHourChinaConcern.CheckedChanged, ChkHourChinaPollutant.CheckedChanged, ChkRiskCondition.CheckedChanged, ChkRiskConfidence.CheckedChanged, ChkRoadRisk.CheckedChanged, ChkRiskScore.CheckedChanged, ChkHailRisk.CheckedChanged

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

    Private Sub FetchData(sender As Object, e As EventArgs) Handles ChkFetchDaily.CheckedChanged, ChkFetchHourly.CheckedChanged
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Fetch_Daily = .Checked
                Case 1
                    My.Settings.Fetch_Hourly = .Checked
                Case Else
                    Exit Select
            End Select
        End With
    End Sub

#End Region

End Class
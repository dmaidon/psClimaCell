﻿Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Security
Imports System.Text
Imports System.Text.Json
Imports psClimaCellv4.Modules.DayColors

Friend Module TimeLineRoutinesV4

    Private tlNfo As CcTimelinesModel
    Private ie As String = "- N/A -"

    Friend Sub FetchTimeLines(Optional OverRide As Boolean = False)
        Dim tlFile As String = Path.Combine(TempDir, $"tlData_{Now:Mddyy-HH}.json")
        With FrmMainv4
            .TC.TabPages.Remove(.TpDaily)
            .TC.TabPages.Remove(.TpHourly)
            .TC.TabPages.Remove(.TpCurrent)
            .TC.TabPages.Remove(.Tp1Min)
            .TC.TabPages.Remove(.Tp5Min)
            .TC.TabPages.Remove(.Tp15Min)
            .TC.TabPages.Remove(.Tp30Min)
        End With
        'GetTimeline(tlFile)
        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
            FrmMainv4.TC.SelectedTab = FrmMainv4.TpAppOptions
            Exit Sub
        End If

        If OverRide Then
            'force a new download, doesn't matter how old the current data
            DownloadTimeLines(tlFile)
        Else
            If File.Exists(tlFile) Then
                Dim ab As Double = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(tlFile))) / 60
                If ab >= 30 Then
                    DownloadTimeLines(tlFile)
                Else
                    ParseTimeLines(ab, tlFile)
                End If
            Else
                DownloadTimeLines(tlFile)
            End If
        End If
    End Sub

    Private Async Sub DownloadTimeLines(fn As String)
        Try
            Dim url As String = $"https://data.climacell.co/v4/timelines?apikey={My.Settings.ApiKey}&location={My.Settings.cLatitude},{My.Settings.cLongitude}&units={unitArr(My.Settings.Units)}&timesteps={GetTimeStepString()}&fields={GetFieldsString()}"

            PrintLog($"TimeLines Url: {url}{vbLf}{vbLf}")

            Dim request = CType(WebRequest.Create(New Uri(url)), HttpWebRequest)
            With request
                .KeepAlive = False
                .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
                .Accept = "application/json"
                .Timeout = 300000
                .ReadWriteTimeout = 120000
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .UserAgent = Use_Agent
            End With
            Using response = CType(Await request.GetResponseAsync.ConfigureAwait(True), HttpWebResponse)
                If My.Settings.Log_Headers Then
                    PrintLog($"{vbLf}{vbLf}ClimaCell Timeline Headers:{vbLf}{vbLf}")
                    For j = 0 To response.Headers.Count - 1
                        PrintLog($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                    Next
                End If
                FrmMainv4.TsslCallRemaining.Text = String.Format(FrmMainv4.TsslCallRemaining.Tag.ToString, response.GetResponseHeader("X-RateLimit-Remaining-Day"))
                My.Settings.CallsRemaining = CInt(response.GetResponseHeader("X-RateLimit-Remaining-Day"))
                My.Settings.Save()
                PrintLog($"{My.Resources.separator}{vbLf}{vbLf}")
                If response IsNot Nothing Then
                    If response.StatusCode = HttpStatusCode.OK Then
                        PrintLog($"Download Timelines Data @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                        Dim dStr = response.GetResponseStream()
                        Using reader = New StreamReader(dStr)
                            Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                            File.WriteAllText(fn, resp)
                            PrintLog($"Timeline file saved -> {fn}{vbLf}")

                            tlNfo = JsonSerializer.Deserialize(Of CcTimelinesModel)(resp)
                            Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                                Await aTxt.WriteLineAsync($"{My.Resources.separator}{vbLf}").ConfigureAwait(True)
                                Await aTxt.WriteLineAsync($"ClimaCell Timeline Forecast Data @ {Now:T}{vbLf}ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                            End Using

                            For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                                Select Case tlNfo.WxData.TimeLines(j).TimeStep
                                    Case "1m"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp1Min)
                                        Write1mData(j)
                                    Case "5m"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp5Min)
                                        Write5mData(j)
                                    Case "15m"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp15Min)
                                        Write15mData(j)
                                    Case "30m"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp30Min)
                                        Write30mData(j)
                                    Case "1h"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpHourly)
                                        WriteHourlyData(j)
                                    Case "1d"
                                        FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.TpDaily)
                                        WriteDailyData(j)
                                    Case "current"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpCurrent)
                                        WriteCurrentData(j)
                                    Case Else
                                        Exit Select
                                End Select
                            Next

                            If tlNfo.Warnings IsNot Nothing Then
                                WriteWarnings()
                            End If

                        End Using
                        With FrmMainv4
                            .TmrReset.Stop()
                            .TsslReset.Visible = False
                            ResetCounter = 0
                        End With
                    Else
                        PrintLog($"Download Rt Data @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                        SaveLogs()
                        Return
                    End If
                Else
                    PrintLog($"{vbLf}Response received from server was null.{vbLf}")
                End If
            End Using
            FrmMainv4.TC.SelectedIndex = 0
        Catch ex As WebException
            PrintLog($"DownloadTimelines failed @ {Now:T} -> {ex.Message}{vbLf}{vbLf}")
            If ex.InnerException IsNot Nothing Then
                ie = ex.InnerException.ToString
            End If
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            With FrmMainv4
                ResetCounter += 1
                If ResetCounter <= 3 AndAlso DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, MidNextUpdate) >= 15 Then
                    ResetDuration = New TimeSpan(0, 0, 3, 0)
                    ResetNextUpdate = Date.Now + ResetDuration
                    .TsslReset.Visible = True
                    .TmrReset.Start()
                    PrintLog($"Reset timer started @ {Now:F} for 3 minutes. Counter: {ResetCounter}{vbLf}")
                Else
                    PrintLog($"ResetCounter set to 0. Counter: {ResetCounter}{vbLf}")
                    ResetCounter = 0
                End If
            End With
            ' Exit Sub
        Catch ex As Exception When _
                    TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is ProtocolViolationException OrElse TypeOf ex Is NotSupportedException OrElse
                    TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is OutOfMemoryException OrElse
                    TypeOf ex Is IOException OrElse TypeOf ex Is Exception
            If ex.InnerException IsNot Nothing Then
                ie = ex.InnerException.ToString
            End If
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
        Finally
            SaveLogs()
        End Try

    End Sub

    Private Function GetFieldsString() As String
        Try
            'temperature field is set to fetch Min and Max temperature for time period.
            Dim tlFields As New List(Of String)({"temperature,temperatureMax,temperatureMin,temperatureMaxTime,temperatureMinTime", "temperatureApparent", "dewPoint", "humidity", "windSpeed", "windDirection", "windGust", "pressureSurfaceLevel", "pressureSeaLevel", "precipitationIntensity", "precipitationProbability", "precipitationType", "sunriseTime", "sunsetTime", "moonPhase", "solarGHI", "visibility", "cloudCover", "cloudBase", "cloudCeiling", "weatherCode", "particulateMatter25", "particulateMatter10", "pollutantO3", "pollutantNO2", "pollutantCO", "pollutantSO2", "mepIndex", "mepPrimaryPollutant", "mepHealthConcern", "epaIndex", "epaPrimaryPollutant", "epaHealthConcern", "treeIndex", "treeAcaciaIndex", "treeAshIndex", "treeBeechIndex", "treeBirchIndex", "treeCedarIndex", "treeCypressIndex", "treeElderIndex", "treeElmIndex", "treeHemlockIndex", "teeHickoryIndex", "treeJuniperIndex", "treeMahagonyIndex", "treeMapleIndex", "treeMulberryIndex", "treeOakIndex", "treePineIndex", "treeCottonwoodIndex", "treeSpruceIndex", "treeSycamoreIndex", "treeWalnutIndex", "treeWillowIndex", "grassIndex", "grassGrassIndex", "weedIndex", "weedGrassweedIndex", "hailBinary", "fireIndex", "solarGHI", "solarDNI", "solarDHI", "waveSignificantHeight", "waveDirection", "waveMeanPeriod", "windWaveSignificantHeight", "windWaveDirection", "windWaveMeanPeriod", "primarySwellSignificantHeight", "primarySwellDirection", "primarySwellMeanPeriod", "secondarySwellSignificantHeight", "secondarySwellDirection", "secondarySwellMeanPeriod", "tertiarySwellMeanPeriod", "tertiarySwellFromDirection", "tertiarySwellSignificantHeight", "soilMoistureVolumetric0To10", "soilMoistureVolumetric10To40", "soilMoistureVolumetric40To100", "soilMoistureVolumetric100To200", "soilMoistureVolumetric0To200", "soilTemperature0To10", "soilTemperature10To40", "soilTemperature40To100", "soilTemperature100To200", "soilTemperature0To200"})
            Dim sb = New StringBuilder()
            For Each c As CheckBox In FrmMainv4.FlpDataFields.Controls.OfType(Of CheckBox)()
                If c.Checked Then
                    sb.Append(tlFields(CInt(c.Tag)))
                    If Not String.IsNullOrEmpty(CStr(CInt(c.Tag))) Then
                        sb.Append(",")
                    End If
                End If
            Next
            Dim aa = sb.ToString
            If String.IsNullOrEmpty(aa) Then
                Return "temperature"
            Else
                Return Left(aa, aa.Length - 1)
            End If
        Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
            If ex.InnerException IsNot Nothing Then
                ie = ex.InnerException.ToString
            End If
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Return "temperature"
        Finally
            ''
        End Try
    End Function

    Private Function GetTimeStepString() As String
        Try
            Dim tsArr As New List(Of String)({"1m", "5m", "15m", "30m", "1h", "1d", "current"})
            Dim sb = New StringBuilder()
            For Each c As CheckBox In FrmMainv4.GbTimeSteps.Controls.OfType(Of CheckBox)()
                If c.Checked Then
                    sb.Append(tsArr(CInt(c.Tag)))
                    sb.Append(",")
                End If
            Next
            Dim aa = sb.ToString
            'strip the trailing comma ",", if there is one
            Return Left(aa, aa.Length - 1)
        Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Return ""
        Finally
            ''
        End Try
    End Function

    Private Function GetWindString(winSpd As Double, winGst As Double, Optional winDir As Double = vbNull) As String
        Try
            If winSpd <= 0 OrElse winDir = vbNull Then
                Return "Calm"
            Else
                Dim sb As New StringBuilder()
                sb.Append($"{Deg2Compass(winDir)} @ {winSpd:N0} {unitNfo.WindSpeed}")
                If winGst >= 1 Then
                    sb.Append($" gusting to {winGst:N0} {unitNfo.WindSpeed}")
                End If
                Return sb.ToString
            End If
        Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Return "Calm"
        Finally
            ''
        End Try
    End Function

    Private Async Sub ParseTimeLines(ab As Double, fn As String)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                    Await aTxt.WriteLineAsync($"{My.Resources.separator}{vbLf}").ConfigureAwait(True)
                    Await aTxt.WriteLineAsync($"Parsed ClimaCell Timeline Forecast Data @ {Now:T}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                End Using
                tlNfo = JsonSerializer.Deserialize(Of CcTimelinesModel)(resp)
                PrintLog($"[Parsed] Timeline Forecast Data @ {Now:T}{vbLf}File age: {ab:N2} minutes{vbLf}{vbLf}")
                FrmMainv4.TsslCallRemaining.Text = String.Format(FrmMainv4.TsslCallRemaining.Tag.ToString, My.Settings.CallsRemaining)
                For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                    Select Case tlNfo.WxData.TimeLines(j).TimeStep
                        Case "1m"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp1Min)
                            Write1mData(j)
                        Case "5m"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp5Min)
                            Write5mData(j)
                        Case "15m"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp15Min)
                            Write15mData(j)
                        Case "30m"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp30Min)
                            Write30mData(j)
                        Case "1h"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpHourly)
                            WriteHourlyData(j)
                        Case "1d"
                            FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.TpDaily)
                            WriteDailyData(j)
                        Case "current"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpCurrent)
                            WriteCurrentData(j)
                        Case Else
                            Exit Select
                    End Select
                Next
                If InStr(resp, "warnings") > 0 Then
                    WriteWarnings()
                End If
            End Using
            FrmMainv4.TC.SelectedIndex = 0
        Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub

    Private Sub Write15mData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines Fifteen Minute data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Fifteen Minute data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.Dgv15Min
                    .Rows.Clear()
                    PrintLog($"Fifteen Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
                        .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                        .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                        .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                        .Rows.Add("", "", "Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
                        .Rows.Add("", "", "Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.DewPoint}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add("", "", "Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
                        .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        .Rows.Add("", "", "Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
                        If tl.CloudBase.HasValue Then
                            .Rows.Add("", "", "Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_base
                        End If
                        If tl.CloudCeiling.HasValue Then
                            .Rows.Add("", "", "Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_celiing
                        End If
                        .Rows.Add("", "", "Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("", "", "EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                        'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                        'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                        .Rows(.Rows.Count - 1).Cells(3).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("", "", "EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add("", "", $"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add("", "", $"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add("", "", $"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add("", "", $"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add("", "", $"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add("", "", $"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .Rows.Add("", "", $"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
                        .Rows.Add("", "", $"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}%")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}°F")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}°F")
                        .ClearSelection()
                        Application.DoEvents()
                    Next
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub Write1mData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines One Minute data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"One Minute data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.Dgv1Min
                    .Rows.Clear()
                    PrintLog($"One Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
                        .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                        .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                        If tl.TempMax IsNot Nothing AndAlso tl.TempMax.HasValue Then
                            .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                        End If
                        .Rows.Add("", "", "Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
                        .Rows.Add("", "", "Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.DewPoint}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add("", "", "Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
                        .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        .Rows.Add("", "", "Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
                        If tl.CloudBase.HasValue Then
                            .Rows.Add("", "", "Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_base
                        End If
                        If tl.CloudCeiling.HasValue Then
                            .Rows.Add("", "", "Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_celiing
                        End If
                        .Rows.Add("", "", "Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("", "", "EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                        'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                        'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                        .Rows(.Rows.Count - 1).Cells(3).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("", "", "EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add("", "", $"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add("", "", $"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add("", "", $"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add("", "", $"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add("", "", $"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add("", "", $"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .Rows.Add("", "", $"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
                        .Rows.Add("", "", $"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}%")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}°F")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}°F")
                        .ClearSelection()
                        Application.DoEvents()
                    Next
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub Write30mData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines Thirth Minute data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Thirty Minute data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.Dgv30Min
                    .Rows.Clear()
                    PrintLog($"Thirty Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
                        .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                        .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                        .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                        .Rows.Add("", "", "Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
                        .Rows.Add("", "", "Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.DewPoint}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add("", "", "Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
                        .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        .Rows.Add("", "", "Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
                        If tl.CloudBase.HasValue Then
                            .Rows.Add("", "", "Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_base
                        End If
                        If tl.CloudCeiling.HasValue Then
                            .Rows.Add("", "", "Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_celiing
                        End If
                        .Rows.Add("", "", "Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("", "", "EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                        'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                        'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                        .Rows(.Rows.Count - 1).Cells(3).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("", "", "EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add("", "", $"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add("", "", $"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add("", "", $"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add("", "", $"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add("", "", $"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add("", "", $"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .Rows.Add("", "", $"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
                        .Rows.Add("", "", $"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}%")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}°F")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}°F")
                        .ClearSelection()
                        Application.DoEvents()
                    Next
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub Write5mData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines Five Minute data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Five Minute data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.Dgv5Min
                    .Rows.Clear()
                    PrintLog($"Five Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
                        .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                        .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                        .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                        .Rows.Add("", "", "Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
                        .Rows.Add("", "", "Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.DewPoint}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add("", "", "Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
                        .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        .Rows.Add("", "", "Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
                        If tl.CloudBase.HasValue Then
                            .Rows.Add("", "", "Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_base
                        End If
                        If tl.CloudCeiling.HasValue Then
                            .Rows.Add("", "", "Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_celiing
                        End If
                        .Rows.Add("", "", "Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("", "", "EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                        'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                        'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                        .Rows(.Rows.Count - 1).Cells(3).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("", "", "EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add("", "", $"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add("", "", $"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add("", "", $"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add("", "", $"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add("", "", $"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add("", "", $"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .Rows.Add("", "", $"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
                        .Rows.Add("", "", $"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}%")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}°F")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}°F")
                        .ClearSelection()
                        Application.DoEvents()
                    Next
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub WriteCurrentData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines current data @ {Now:F}.{vbLf}{vbLf}")
        'no error checking to make sure individual fields exist in json file

        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Current data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvCurrent
                    .Rows.Clear()
                    PrintLog($"Current records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        .Rows.Add("Time", $"{tlNfo.WxData.TimeLines(ct).Intervals(j).StartTime.ToLocalTime:h:mm tt}")
                        .Rows.Add($"Temperature", $"{tl.Temp:N0}{unitNfo.Temperature}")
                        .Rows.Add($"Feels Like", $"{tl.TempApparent.Value:N0}{unitNfo.Temperature}")
                        .Rows.Add($"Weather", $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add($"Wind", $"{GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd)}{vbLf}")
                        .Rows.Add($"Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add($"Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}")
                        .Rows.Add($"Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}")
                        .Rows.Add($"Barometric Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}")
                        .Rows.Add($"Visibility", $"{tl.Visibility.Value:N0} {unitNfo.Visibility}")
                        .Rows.Add("Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(1).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(1).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(1).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("Health Concern Notes", $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows.Add("EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add($"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add($"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add($"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add($"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add($"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add($"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .ClearSelection()
                        Dim icn As String = Path.Combine(IconDir, "PNG", "Color", ImgStyleArr(My.Settings.ImageStyle), $"{tl.WxCode.Value}.png")
                        If My.Settings.Log_Images Then PrintLog($"{j}. Current: {icn} --> Load{vbLf}")
                        Dim bgClr = If(Date2Unix(CDate(Now)) >= Date2Unix(CDate(tlNfo.WxData.TimeLines(ct).Intervals(0).Values.Sunrise.ToLocalTime)) And Date2Unix(Now) <= Date2Unix(CDate(tlNfo.WxData.TimeLines(ct).Intervals(0).Values.Sunset.ToLocalTime)),
                           Color.LightSkyBlue,
                           Color.Gray)
                        With FrmMainv4
                            .TpCurrent.BackColor = bgClr
                            .DgvCurrent.BackgroundColor = bgClr
                            .PbCurImage.BackgroundImage = If(File.Exists(icn),
                            Image.FromFile(icn),
                            Image.FromFile(Path.Combine(IconDir, "PNG", "Color", ImgStyleArr(My.Settings.ImageStyle), "0.png")))
                        End With
                        Application.DoEvents()
                    Next
                    'write the current weather to the Tray Icon
                    FrmMainv4.TIcon.Text = unitNfo.WeatherCode(CStr(tlNfo.WxData.TimeLines(ct).Intervals(0).Values.WxCode.Value))
                    .ClearSelection()
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub WriteDailyData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines daily data @ {Now:F}.{vbLf}{vbLf}")

        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Daily data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvDaily
                    .Visible = False
                    .Rows.Clear()
                    .Columns.Clear()
                    For j = 0 To 7
                        .Columns.Add(New DataGridViewImageColumn With {.ImageLayout = DataGridViewImageCellLayout.Zoom})
                        .Columns(j).Name = $"dDay{j}"
                        .Rows.Add()
                        Application.DoEvents()
                    Next

                    For j = 0 To 7
                        .Rows(1).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        .Rows(2).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        .Rows(3).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        .Rows(5).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        .Rows(6).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        .Rows(7).Cells(j) = New DataGridViewTextBoxCell With {.Value = ""}
                        Application.DoEvents()
                    Next

                    If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 15 Then
                        .Rows(4).Cells(7).Value = Transparent2Color(My.Resources.PS_LOGO_transparent_190x150, Color.MintCream)
                        .Rows(6).Cells(7).Style.BackColor = Color.DarkGray
                        .Rows(7).Cells(7).Style.BackColor = Color.DarkGray
                    End If

                    PrintLog($"Daily records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim sb As New StringBuilder()
                        sb.Append($"Temp: {tl.TempMax.Value:N0}{unitNfo.Temperature} - {tl.TempMin.Value:N0}{unitNfo.Temperature}{vbLf}")
                        sb.Append($"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}{vbLf}")
                        Dim wd = If(tl.WindDir, vbNull)
                        sb.Append($"Wind {GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd)}{vbLf}")
                        sb.Append($"Precip: {tl.PrecipPct.Value:N0}{unitNfo.PrecipitationProbability}{vbLf}")
                        sb.Append($"Type: {unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        sb.Append($"Intensity: {tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        sb.Append($"Bp: {tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        sb.Append($"Sr: {tl.Sunrise.ToLocalTime:t}{vbLf}")
                        sb.Append($"Ss: {tl.Sunset.ToLocalTime:t}{vbLf}")

                        Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                        sb.Append($"{unitNfo.MoonPhase.Values(tlNfo.WxData.TimeLines(ct).Intervals(j).Values.MoonPhase.Value)}{vbLf}")
                        sb.Append($"Vis: {tl.Visibility.Value:N0} {unitNfo.Visibility}{vbLf}")

                        Dim icn As String = Path.Combine(IconDir, "PNG", "Color", ImgStyleArr(My.Settings.ImageStyle), $"{tl.WxCode.Value}.png")

                        If My.Settings.Log_Images Then PrintLog($"{j}. Daily: {icn} --> Bitmap{vbLf}")

                        Dim bgClr = If(Date2Unix(CDate(Now)) >= Date2Unix(CDate(tlNfo.WxData.TimeLines(ct).Intervals(0).Values.Sunrise.ToLocalTime)) And Date2Unix(Now) <= Date2Unix(CDate(tlNfo.WxData.TimeLines(ct).Intervals(0).Values.Sunset.ToLocalTime)),
                            Color.LightSkyBlue,
                            Color.Gray)
                        Using bmp1 As New Bitmap(icn)
                            Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", ImgStyleArr(My.Settings.ImageStyle), "0.png"))
                                If j <= 7 Then
                                    .Rows(0).Cells(j).Style.BackColor = bgClr
                                    .Rows(0).Cells(j).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                    .Rows(0).Cells(j).ToolTipText = unitNfo.WeatherCode(tl.WxCode.Value.ToString)
                                    .Rows(1).Cells(j).Value = sb.ToString
                                    .Rows(2).Cells(j).Value = $"{tlNfo.WxData.TimeLines(ct).Intervals(j).StartTime:dddd}"
                                    .Rows(2).Cells(j).Style.BackColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Bg
                                    .Rows(2).Cells(j).Style.ForeColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Fg
                                    .Rows(3).Cells(j).Value = $"{tlNfo.WxData.TimeLines(ct).Intervals(j).StartTime:MMM d}"
                                ElseIf j >= 8 Then
                                    .Rows(4).Cells(j - 8).Style.BackColor = bgClr
                                    .Rows(4).Cells(j - 8).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                    .Rows(4).Cells(j - 8).ToolTipText = unitNfo.WeatherCode(tl.WxCode.Value.ToString)
                                    .Rows(5).Cells(j - 8).Value = sb.ToString
                                    .Rows(6).Cells(j - 8).Value = $"{tlNfo.WxData.TimeLines(ct).Intervals(j).StartTime:dddd}"
                                    .Rows(6).Cells(j - 8).Style.BackColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Bg
                                    .Rows(6).Cells(j - 8).Style.ForeColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Fg
                                    .Rows(7).Cells(j - 8).Value = $"{tlNfo.WxData.TimeLines(ct).Intervals(j).StartTime:MMM d}"
                                    .Rows(7).Cells(j - 8).Style.BackColor = Color.Gainsboro
                                End If
                            End Using
                        End Using
                        sb.Clear()
                        Application.DoEvents()
                    Next

                    '.Rows(4).Cells(7).Value = Transparent2Color(My.Resources.PS_LOGO_transparent_190x150, Color.MintCream)
                    .Rows(1).DefaultCellStyle.BackColor = Color.DarkGray
                    .Rows(3).DefaultCellStyle.BackColor = Color.Gainsboro
                    .Rows(5).DefaultCellStyle.BackColor = Color.DarkGray
                    .Rows(7).DefaultCellStyle.BackColor = Color.Gainsboro

                    .Rows(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Rows(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Rows(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Rows(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Rows(0).Height = 78
                    .Rows(1).Height = 187
                    .Rows(4).Height = 78
                    .Rows(5).Height = 187

                    .Rows(2).DefaultCellStyle.Font = New Font("", 13, FontStyle.Bold)
                    .Rows(3).DefaultCellStyle.Font = New Font("", 14, FontStyle.Bold)
                    .Rows(6).DefaultCellStyle.Font = New Font("", 13, FontStyle.Bold)
                    .Rows(7).DefaultCellStyle.Font = New Font("", 14, FontStyle.Bold)
                    .Visible = True
                    .ClearSelection()
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub WriteHourlyData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines hourly data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Hourly data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvHour
                    .Rows.Clear()
                    PrintLog($"Hourly records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
                        .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                        .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                        .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                        .Rows.Add("", "", "Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
                        .Rows.Add("", "", "Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.DewPoint}")
                        Dim wd = If(tl.WindDir, vbNull)
                        .Rows.Add("", "", "Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
                        .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                        .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        .Rows.Add("", "", "Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
                        If tl.CloudBase.HasValue Then
                            .Rows.Add("", "", "Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_base
                        End If
                        If tl.CloudCeiling.HasValue Then
                            .Rows.Add("", "", "Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                            .Rows(.Rows.Count - 1).Cells(2).ToolTipText = My.Resources.cloud_celiing
                        End If
                        .Rows.Add("", "", "Air Quality Index", $"{tl.EpaIndex.Value}")
                        .Rows.Add("", "", "EPA Health Concern", $"{unitNfo.EpaHealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                        'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                        'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                        'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                        .Rows(.Rows.Count - 1).Cells(3).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.EpaBgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.EpaFgColor(tl.EpaHealthConcern.Value.ToString)}")
                        .Rows(.Rows.Count - 1).Cells(3).ToolTipText = $"{unitNfo.EpaConcernText(tl.EpaHealthConcern.Value.ToString)}"
                        .Rows.Add("", "", "EPA Primary Pollutant", $"{unitNfo.EpaPrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
                        .Rows.Add("", "", $"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
                        .Rows.Add("", "", $"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
                        .Rows.Add("", "", $"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
                        .Rows.Add("", "", $"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
                        .Rows.Add("", "", $"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
                        .Rows.Add("", "", $"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
                        .Rows.Add("", "", $"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
                        .Rows.Add("", "", $"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}%")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}°F")
                        .Rows.Add("", "", $"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}°F")
                        .ClearSelection()
                        Application.DoEvents()
                    Next
                End With
            Catch ex As Exception When TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is Exception
                If ex.InnerException IsNot Nothing Then
                    ie = ex.InnerException.ToString
                End If
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
            Finally
                'SaveLogs()
            End Try
        End If
    End Sub

    Private Sub WriteWarnings()
        Try
            With FrmMainv4.DgvWarnings
                .Rows.Clear()
                ' .ColumnCount = 3
                PrintLog($"Warning records total count: {tlNfo.Warnings.Count}{vbLf}")
                For j = 0 To tlNfo.Warnings.Count - 1
                    Dim tw = tlNfo.Warnings(j)
                    .Rows.Add("Code", tw.Code)
                    .Rows.Add("", "Type", tw.Type)
                    .Rows.Add("", "Message", tw.Message)
                    .Rows.Add("", "Meta ↓↓↓")
                    Select Case tw.Code
                        Case 246001, 246003
                            .Rows.Add("", "Field", tw.Meta.Field)
                            .Rows.Add("", "Dates", $"{CDate(tw.Meta.From).ToLocalTime:F} to {CDate(tw.Meta.To).ToLocalTime:F}")
                        Case 246002
                            .Rows.Add("", "Field", tw.Meta.Field)
                            .Rows.Add("", "Location", tw.Meta.location)
                        Case 246008
                            .Rows.Add("", "Field", tw.Meta.Field)
                            .Rows.Add("", "Timesteps ↓↓↓")
                            For k = 0 To tw.Meta.Timesteps.Count - 1
                                .Rows.Add("", "", tw.Meta.Timesteps(k))
                            Next
                        Case 246009
                            .Rows.Add("", "Timestep", tw.Meta.Timestep)
                            .Rows.Add("", "From / To", $"{tw.Meta.From} to {tw.Meta.To}")
                        Case Else
                            .Rows.Add("Code", tw.Code, "Information Missing.")
                            PrintLog($"Warning information missing -> Code: {tw.Code}.{vbLf}")
                    End Select
                    Application.DoEvents()
                Next
                .ClearSelection()
            End With
        Catch ex As Exception When TypeOf ex Is ArgumentOutOfRangeException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is Exception
            If ex.InnerException IsNot Nothing Then
                ie = ex.InnerException.ToString
            End If
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString, ie)
        Finally
            'SaveLogs()
        End Try
    End Sub

End Module
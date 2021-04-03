Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Security
Imports System.Text
Imports System.Text.Json
Imports psClimaCellv4.Modules.DayColors

Friend Module TimeLineRoutinesV4

    Private ie As String = "- N/A -"
    Private tlNfo As CcTimelinesModel

    Friend Sub FetchTimeLines(Optional OverRide As Boolean = False)
        Dim tlFile As String = Path.Combine(TempDir, $"tlData_{Now:Mddyy-HH}.json")
        With FrmMainv4
            .TC.TabPages.Remove(.Tp1Day)
            .TC.TabPages.Remove(.Tp1dFull)
            .TC.TabPages.Remove(.Tp1Hr)
            .TC.TabPages.Remove(.TpCurrent)
            .TC.TabPages.Remove(.TpBest)
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
        FrmMainv4.CollectMemoryGarbage(True)
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
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp1Hr)
                                        Write1hData(j)
                                    Case "1d"
                                        FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.Tp1Day)
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp1dFull)
                                        Write1dData(j)
                                        Write1dFullData(j)
                                    Case "current"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpCurrent)
                                        WriteCurrentData(j)
                                    Case "best"
                                        FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpBest)
                                        WriteBestData(j)
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
            Dim tlFields As New List(Of String)({"temperature,temperatureMax,temperatureMin", "temperatureApparent", "dewPoint", "humidity", "windSpeed", "windDirection", "windGust", "pressureSurfaceLevel", "pressureSeaLevel", "precipitationIntensity", "precipitationProbability", "precipitationType", "sunriseTime", "sunsetTime", "moonPhase", "", "visibility", "cloudCover", "cloudBase", "cloudCeiling", "weatherCode", "particulateMatter25", "particulateMatter10", "pollutantO3", "pollutantNO2", "pollutantCO", "pollutantSO2", "mepIndex", "mepPrimaryPollutant", "mepHealthConcern", "epaIndex", "epaPrimaryPollutant", "epaHealthConcern", "treeIndex", "treeAcaciaIndex", "treeAshIndex", "treeBeechIndex", "treeBirchIndex", "treeCedarIndex", "treeCypressIndex", "treeElderIndex", "treeElmIndex", "treeHemlockIndex", "treeHickoryIndex", "treeJuniperIndex", "treeMahagonyIndex", "treeMapleIndex", "treeMulberryIndex", "treeOakIndex", "treePineIndex", "treeCottonwoodIndex", "treeSpruceIndex", "treeSycamoreIndex", "treeWalnutIndex", "treeWillowIndex", "grassIndex", "grassGrassIndex", "weedIndex", "weedRagweedIndex", "hailBinary", "fireIndex", "solarGHI", "solarDNI", "solarDHI", "waveSignificantHeight", "waveDirection", "waveMeanPeriod", "windWaveSignificantHeight", "windWaveDirection", "windWaveMeanPeriod", "primarySwellSignificantHeight", "primarySwellDirection", "primarySwellMeanPeriod", "secondarySwellSignificantHeight", "secondarySwellDirection", "secondarySwellMeanPeriod", "tertiarySwellMeanPeriod", "tertiarySwellFromDirection", "tertiarySwellSignificantHeight", "soilMoistureVolumetric0To10", "soilMoistureVolumetric10To40", "soilMoistureVolumetric40To100", "soilMoistureVolumetric100To200", "soilMoistureVolumetric0To200", "soilTemperature0To10", "soilTemperature10To40", "soilTemperature40To100", "soilTemperature100To200", "soilTemperature0To200", "snowAccumulation", "iceAccumulation"})
            '#15 = solarGHI
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

    Private Function GetPollenValue(val As Double) As String

        Select Case val
            Case 0
                Return "None"
            Case 0.01 To 1.49
                Return "Very Low"
            Case 1.5 To 2.49
                Return "Low"
            Case 2.5 To 3.49
                Return "Medium"
            Case 3.5 To 4.49
                Return "High"
            Case > 4.5
                Return "Very High"
            Case Else
                Return "Very Low"
        End Select
    End Function

    Private Function GetTimeStepString() As String
        Try
            Dim tsArr As New List(Of String)({"1m", "5m", "15m", "30m", "1h", "1d", "current", "best"})
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
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.Tp1Hr)
                            Write1hData(j)
                        Case "1d"
                            FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.Tp1dFull)
                            FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.Tp1Day)
                            Write1dFullData(j)
                            Write1dData(j)
                        Case "current"
                            FrmMainv4.TC.TabPages.Insert(0, FrmMainv4.TpCurrent)
                            WriteCurrentData(j)
                        Case "best"
                            FrmMainv4.TC.TabPages.Insert(1, FrmMainv4.TpBest)
                            WriteBestData(j)
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
                    PrintLog($"**> Fifteen Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.Dgv15Min, ct, j)
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
                '
            End Try
        End If
    End Sub

    Private Sub Write1dData(ct As Integer)
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

                    PrintLog($"**> Daily records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
                        Dim sb As New StringBuilder()
                        If tl.TempMax IsNot Nothing AndAlso tl.TempMax.HasValue Then
                            sb.Append($"Temp: {tl.TempMax.Value:N0}{unitNfo.Temperature} - {tl.TempMin.Value:N0}{unitNfo.Temperature}{vbLf}")
                        End If

                        If tl.WxCode IsNot Nothing AndAlso tl.WxCode.HasValue Then
                            sb.Append($"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}{vbLf}")
                        End If

                        If tl.WindSpeed IsNot Nothing AndAlso tl.WindSpeed.HasValue Then
                            Dim wd = If(tl.WindDir, vbNull)
                            sb.Append($"Wind {GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd)}{vbLf}")
                        End If

                        If tl.PrecipPct IsNot Nothing AndAlso tl.PrecipPct.HasValue Then
                            sb.Append($"Precip: {tl.PrecipPct.Value:N0}{unitNfo.PrecipitationProbability}{vbLf}")
                        End If

                        If tl.PrecipType IsNot Nothing AndAlso tl.PrecipType.HasValue Then
                            sb.Append($"Type: {unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                        End If

                        If tl.PrecipIntensity IsNot Nothing AndAlso tl.PrecipIntensity.HasValue Then
                            sb.Append($"Intensity: {tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                        End If

                        If tl.PressureSurfaceLevel IsNot Nothing AndAlso tl.PressureSurfaceLevel.HasValue Then
                            sb.Append($"Bp: {tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                        End If

                        sb.Append($"Sr: {tl.Sunrise.ToLocalTime:t}{vbLf}")
                        sb.Append($"Ss: {tl.Sunset.ToLocalTime:t}{vbLf}")

                        'Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                        If tl.MoonPhase IsNot Nothing AndAlso tl.MoonPhase.HasValue Then
                            sb.Append($"{unitNfo.MoonPhase.Values(tl.MoonPhase.Value)}{vbLf}")
                        End If

                        If tl.Visibility IsNot Nothing AndAlso tl.Visibility.HasValue Then
                            sb.Append($"Vis: {tl.Visibility.Value:N0} {unitNfo.Visibility}{vbLf}")
                        End If

                        If tl.SolarGHI IsNot Nothing AndAlso tl.SolarGHI.HasValue Then
                            sb.Append($"SolRad: {tl.SolarGHI.Value:N0} {unitNfo.Solar}")
                        End If

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

    Private Sub Write1dFullData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines Daily - Full data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Daily - full data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.Dgv1dFull
                    .Rows.Clear()
                    PrintLog($"**> Daily - Full data records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.Dgv1dFull, ct, j)
                        Application.DoEvents()
                    Next
                    .ClearSelection()
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

    Private Sub Write1hData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines hourly data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Hourly data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvHour
                    .Rows.Clear()
                    PrintLog($"**> Hourly records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.DgvHour, ct, j)
                        Application.DoEvents()
                    Next
                    .ClearSelection()
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
                    PrintLog($"**> One Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.Dgv1Min, ct, j)
                        Application.DoEvents()
                    Next
                    .ClearSelection()
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
                    PrintLog($"**> Thirty Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.Dgv30Min, ct, j)
                        Application.DoEvents()
                    Next
                    .ClearSelection()
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
                    PrintLog($"**> Five Minute records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.Dgv5Min, ct, j)
                        Application.DoEvents()
                    Next
                    .ClearSelection()
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

    Private Sub WriteBestData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines Best data @ {Now:F}.{vbLf}{vbLf}")
        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Best data does not exist @ {Now:F}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvBest
                    .Rows.Clear()
                    PrintLog($"**> Best records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    For j = 0 To tlNfo.WxData.TimeLines(ct).Intervals.Count - 1
                        WriteData(FrmMainv4.DgvBest, ct, j)
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
                '
            End Try
        End If
    End Sub

    Private Sub WriteCurrentData(ct As Integer)
        PrintLog($"{vbLf}Writing timelines current data @ {Now:F}.{vbLf}{vbLf}")
        'no error checking to make sure individual fields exist in json file

        If tlNfo.WxData.TimeLines(ct).Intervals.Count <= 0 Then
            PrintLog($"Current data does not exist @ {Now:f}.{vbLf}{vbLf}")
        Else
            Try
                With FrmMainv4.DgvCurrent
                    Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(0).Values
                    .Rows.Clear()
                    PrintLog($"**> Current records total count: {tlNfo.WxData.TimeLines(ct).Intervals.Count}{vbLf}")
                    WriteData(FrmMainv4.DgvCurrent, ct, 0)

                    Dim icn As String = Path.Combine(IconDir, "PNG", "Color", ImgStyleArr(My.Settings.ImageStyle), $"{tl.WxCode.Value}.png")
                    If My.Settings.Log_Images Then PrintLog($"{0}. Current: {icn} --> Load{vbLf}")
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

    Private Sub WriteData(ctl As DataGridView, ct As Integer, j As Integer)
        Dim tl = tlNfo.WxData.TimeLines(ct).Intervals(j).Values
        Dim tld = tlNfo.WxData.TimeLines(ct).Intervals(j)
        With ctl
            .Rows.Add()
            '.Rows.Add($"{tld.StartTime.ToLocalTime:f}")
            .Rows.Add($"{tld.StartTime.ToLocalTime.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"))}", $"{tld.StartTime.ToLocalTime.ToString("MMMM d, yyyy h:mm tt", CultureInfo.CreateSpecificCulture("en-US"))}")
            .Rows(.Rows.Count - 1).DefaultCellStyle.Font = New Font("", 9, FontStyle.Bold)
            .Rows(.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Maroon
            .Rows(.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Honeydew

            If tl.TempMax IsNot Nothing AndAlso tl.TempMax.HasValue Then
                .Rows.Add("Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
            End If

            If tl.WxCode IsNot Nothing AndAlso tl.WxCode.HasValue Then
                .Rows.Add($"Weather", $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}")
            End If

            If tl.RH IsNot Nothing AndAlso tl.RH.HasValue Then
                .Rows.Add("Relative Humidity", $"{tl.RH.Value}{unitNfo.Humidity}")
            End If

            If tl.Dewpoint IsNot Nothing AndAlso tl.Dewpoint.HasValue Then
                .Rows.Add("Dewpoint", $"{tl.Dewpoint.Value:N0}{unitNfo.Temperature}")
            End If

            If tl.WindSpeed IsNot Nothing AndAlso tl.WindSpeed.HasValue Then
                Dim wd = If(tl.WindDir, vbNull)
                .Rows.Add("Wind", GetWindString(tl.WindSpeed.Value, tl.WindGust.Value, wd))
            End If

            If tl.PrecipPct IsNot Nothing AndAlso tl.PrecipPct.HasValue Then
                .Rows.Add("Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
            End If

            If tl.PrecipType IsNot Nothing AndAlso tl.PrecipType.HasValue Then
                .Rows.Add("Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}")
            End If

            If tl.PrecipIntensity IsNot Nothing AndAlso tl.PrecipIntensity.HasValue Then
                .Rows.Add("Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}")
            End If

            If tl.SnowAccumulation IsNot Nothing AndAlso tl.SnowAccumulation.HasValue Then
                .Rows.Add("Snow Accumulation", $"{tl.SnowAccumulation.Value:N3} {unitNfo.SnowAccumulation}")
            End If

            If tl.IceAccumulation IsNot Nothing AndAlso tl.IceAccumulation.HasValue Then
                .Rows.Add("Ice Accumulation", $"{tl.IceAccumulation.Value:N3} {unitNfo.IceAccumulation}")
            End If

            If tl.HailProbability IsNot Nothing AndAlso tl.HailProbability.HasValue Then
                Dim hp As Boolean
                If tl.HailProbability <> 0 Then hp = True
                .Rows.Add("Chance of Hail", $"{hp}")
            End If

            If tl.PressureSurfaceLevel IsNot Nothing AndAlso tl.PressureSurfaceLevel.HasValue Then
                .Rows.Add($"Barometric Pressure{vbLf}Surface Level", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}")
            End If

            If tl.PressureSeaLevel IsNot Nothing AndAlso tl.PressureSeaLevel.HasValue Then
                .Rows.Add($"Barometric Pressure{vbLf}Sea Level", $"{tl.PressureSeaLevel.Value} {unitNfo.PressureSeaLevel}")
            End If

            If tl.CloudCover IsNot Nothing AndAlso tl.CloudCover.HasValue Then
                .Rows.Add("Cloud Cover", $"{tl.CloudCover:N0}{unitNfo.CloudCover}")
            End If

            If tl.CloudBase IsNot Nothing AndAlso tl.CloudBase.HasValue Then
                .Rows.Add("Cloud Base", $"{tl.CloudBase.Value * 5280:N0} ft.")
                .Rows(.Rows.Count - 1).Cells(1).ToolTipText = My.Resources.cloud_base
            End If

            If tl.CloudCeiling IsNot Nothing AndAlso tl.CloudCeiling.HasValue Then
                .Rows.Add("Cloud Ceiling", $"{tl.CloudCeiling.Value * 5280:N0} ft.")
                .Rows(.Rows.Count - 1).Cells(1).ToolTipText = My.Resources.cloud_celiing
            End If

            If tl.Visibility IsNot Nothing AndAlso tl.Visibility.HasValue Then
                .Rows.Add($"Visibility", $"{tl.Visibility.Value:N0} {unitNfo.Visibility}")
            End If

            'EPA
            If tl.EpaIndex IsNot Nothing AndAlso tl.EpaIndex.HasValue Then
                .Rows.Add("Air Quality Index", $"{tl.EpaIndex.Value}")
            End If

            If tl.EpaHealthConcern IsNot Nothing AndAlso tl.EpaHealthConcern.HasValue Then
                .Rows.Add("EPA Health Concern", $"{unitNfo.HealthConcern(tl.EpaHealthConcern.Value.ToString)}")
                'color the Epa Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                'https://cfpub.epa.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                .Rows(.Rows.Count - 1).Cells(1).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.BgColor(tl.EpaHealthConcern.Value.ToString)}")
                .Rows(.Rows.Count - 1).Cells(1).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.FgColor(tl.EpaHealthConcern.Value.ToString)}")
                .Rows(.Rows.Count - 1).Cells(1).ToolTipText = $"{unitNfo.ConcernText(tl.EpaHealthConcern.Value.ToString)}"
            End If

            If tl.EpaHealthConcern IsNot Nothing AndAlso tl.EpaHealthConcern.HasValue Then
                .Rows.Add("Health Concern Notes", $"{unitNfo.ConcernText(tl.EpaHealthConcern.Value.ToString)}")
            End If

            If tl.EpaPrimaryPollutant IsNot Nothing AndAlso tl.EpaPrimaryPollutant.HasValue Then
                .Rows.Add("EPA Primary Pollutant", $"{unitNfo.PrimaryPollutant(tl.EpaPrimaryPollutant.Value.ToString)}")
            End If

            'MEP China
            If tl.MepIndex IsNot Nothing AndAlso tl.MepIndex.HasValue Then
                .Rows.Add("Air Quality Index", $"{tl.MepIndex.Value}")
            End If

            If tl.MepHealthConcern IsNot Nothing AndAlso tl.MepHealthConcern.HasValue Then
                .Rows.Add("MEP Health Concern", $"{unitNfo.HealthConcern(tl.MepHealthConcern.Value.ToString)}")
                'color the MEP Health Concern cell with the appropriate color for the level of concern. Colors from https://AirNow.gov.
                'https://cfpub.MEP.gov/airnow/index.cfm?action=aqi_brochure.index#:~:text=An%20AQI%20value%20of%20100%20generally%20corresponds%20to,below%20100%20are%20generally%20thought%20of%20as%20satisfactory.
                'https://www.airnow.gov/sites/default/files/2020-05/aqi-technical-assistance-document-sept2018.pdf
                .Rows(.Rows.Count - 1).Cells(1).Style.BackColor = ColorTranslator.FromHtml($"{unitNfo.BgColor(tl.MepHealthConcern.Value.ToString)}")
                .Rows(.Rows.Count - 1).Cells(1).Style.ForeColor = ColorTranslator.FromHtml($"{unitNfo.FgColor(tl.MepHealthConcern.Value.ToString)}")
                .Rows(.Rows.Count - 1).Cells(1).ToolTipText = $"{unitNfo.ConcernText(tl.MepHealthConcern.Value.ToString)}"
            End If

            If tl.MepHealthConcern IsNot Nothing AndAlso tl.MepHealthConcern.HasValue Then
                .Rows.Add("Health Concern Notes", $"{unitNfo.ConcernText(tl.MepHealthConcern.Value.ToString)}")
            End If

            If tl.MepPrimaryPollutant IsNot Nothing AndAlso tl.MepPrimaryPollutant.HasValue Then
                .Rows.Add("MEP Primary Pollutant", $"{unitNfo.PrimaryPollutant(tl.MepPrimaryPollutant.Value.ToString)}")
            End If

            If tl.PM25 IsNot Nothing AndAlso tl.PM25.HasValue Then
                .Rows.Add($"PM25{vbLf}Particulate Matter < 2.5 mic", $"{tl.PM25.Value} {unitNfo.ParticulateMatter25}")
            End If

            If tl.PM10 IsNot Nothing AndAlso tl.PM10.HasValue Then
                .Rows.Add($"PM10{vbLf}Particulate Matter < 10 mic", $"{tl.PM10.Value} {unitNfo.ParticulateMatter10}")
            End If

            If tl.O3 IsNot Nothing AndAlso tl.O3.HasValue Then
                .Rows.Add($"O3{vbLf}Ozone", $"{tl.O3.Value} {unitNfo.PollutantO3}")
            End If

            If tl.NO2 IsNot Nothing AndAlso tl.NO2.HasValue Then
                .Rows.Add($"NO2{vbLf}Nitrogen Dioxide", $"{tl.NO2.Value} {unitNfo.PollutantNO2}")
            End If

            If tl.CO IsNot Nothing AndAlso tl.CO.HasValue Then
                .Rows.Add($"CO{vbLf}Carbon Monoxide", $"{tl.CO.Value} {unitNfo.PollutantCO}")
            End If

            If tl.SO2 IsNot Nothing AndAlso tl.SO2.HasValue Then
                .Rows.Add($"SO2{vbLf}Sulfur Dioxide", $"{tl.SO2.Value} {unitNfo.PollutantSO2}")
            End If

            If tl.FireIndex IsNot Nothing AndAlso tl.FireIndex.HasValue Then
                .Rows.Add($"FWI{vbLf}Fosberg Fire Weather Index", $"{tl.FireIndex.Value}")
            End If

            If tl.SolarGHI IsNot Nothing AndAlso tl.SolarGHI.HasValue Then
                .Rows.Add($"Shortwave Radiation received{vbLf}Surface horizontal to ground", $"{tl.SolarGHI} {unitNfo.Solar}")
            End If

            If tl.SolarDHI IsNot Nothing AndAlso tl.SolarDHI.HasValue Then
                .Rows.Add($"Diffused, scattered component of{vbLf}Solar Radiation reaching ground", $"{tl.SolarDHI} {unitNfo.Solar}")
            End If

            If tl.SolarDNI IsNot Nothing AndAlso tl.SolarDNI.HasValue Then
                .Rows.Add($"Direct component of{vbLf}Solar Radiation reaching ground", $"{tl.SolarDNI} {unitNfo.Solar}")
            End If

            If tl.Moisture0To10 IsNot Nothing AndAlso tl.Moisture0To10.HasValue Then
                .Rows.Add($"Soil Moisture Volume{vbLf}0 to 10 cm", $"{tl.Moisture0To10}{unitNfo.SoilMoistureVolume}")
            End If

            If tl.Moisture10To40 IsNot Nothing AndAlso tl.Moisture10To40.HasValue Then
                .Rows.Add($"Soil Moisture Volume{vbLf}10 to 40 cm", $"{tl.Moisture10To40}{unitNfo.SoilMoistureVolume}")
            End If

            If tl.Moisture40To100 IsNot Nothing AndAlso tl.Moisture40To100.HasValue Then
                .Rows.Add($"Soil Moisture Volume{vbLf}40 to 100 cm", $"{tl.Moisture40To100}{unitNfo.SoilMoistureVolume}")
            End If

            If tl.Moisture100To200 IsNot Nothing AndAlso tl.Moisture100To200.HasValue Then
                .Rows.Add($"Soil Moisture Volume{vbLf}100 to 200 cm", $"{tl.Moisture100To200}{unitNfo.SoilMoistureVolume}")
            End If

            If tl.Moisture0To200 IsNot Nothing AndAlso tl.Moisture0To200.HasValue Then
                .Rows.Add($"Soil Moisture Volume{vbLf}0 to 200 cm", $"{tl.Moisture0To200}{unitNfo.SoilMoistureVolume}")
            End If

            If tl.SoilTemp0To10 IsNot Nothing AndAlso tl.SoilTemp0To10.HasValue Then
                .Rows.Add($"Soil Temperature{vbLf}0 to 10 cm", $"{tl.SoilTemp0To10}{unitNfo.Temperature}")
            End If

            If tl.SoilTemp10To40 IsNot Nothing AndAlso tl.SoilTemp10To40.HasValue Then
                .Rows.Add($"Soil Temperature{vbLf}10 to 40 cm", $"{tl.SoilTemp10To40}{unitNfo.Temperature}")
            End If

            If tl.SoilTemp40To100 IsNot Nothing AndAlso tl.SoilTemp40To100.HasValue Then
                .Rows.Add($"Soil Temperature{vbLf}40 to 100 cm", $"{tl.SoilTemp40To100}{unitNfo.Temperature}")
            End If

            If tl.SoilTemp100To200 IsNot Nothing AndAlso tl.SoilTemp100To200.HasValue Then
                .Rows.Add($"Soil Temperature{vbLf}100 to 200 cm", $"{tl.SoilTemp100To200}{unitNfo.Temperature}")
            End If

            If tl.SoilTemp0To200 IsNot Nothing AndAlso tl.SoilTemp0To200.HasValue Then
                .Rows.Add($"Soil Temperature{vbLf}0 to 200 cm", $"{tl.SoilTemp0To200}{unitNfo.Temperature}")
            End If

            If tl.Tree IsNot Nothing AndAlso tl.Tree.HasValue Then
                .Rows.Add("Tree Pollen Index", $"{GetPollenValue(tl.Tree.Value)}")
            End If
            If tl.TreeAcacia IsNot Nothing AndAlso tl.TreeAcacia.HasValue Then
                .Rows.Add("Acacia Tree Pollen Index", $"{GetPollenValue(tl.TreeAcacia.Value)}")
            End If

            If tl.TreeAsh IsNot Nothing AndAlso tl.TreeAsh.HasValue Then
                .Rows.Add("Ash Tree Pollen Index", $"{GetPollenValue(tl.TreeAsh.Value)}")
            End If

            If tl.TreeBeech IsNot Nothing AndAlso tl.TreeBeech.HasValue Then
                .Rows.Add("Beech Tree Pollen Index", $"{GetPollenValue(tl.TreeBeech.Value)}")
            End If

            If tl.TreeBirch IsNot Nothing AndAlso tl.TreeBirch.HasValue Then
                .Rows.Add("Birch Tree Pollen Index", $"{GetPollenValue(tl.TreeBirch.Value)}")
            End If

            If tl.TreeCedar IsNot Nothing AndAlso tl.TreeCedar.HasValue Then
                .Rows.Add("Cedar Tree Pollen Index", $"{GetPollenValue(tl.TreeCedar.Value)}")
            End If

            If tl.TreeCottonwood IsNot Nothing AndAlso tl.TreeCottonwood.HasValue Then
                .Rows.Add("Cottonwood Tree Pollen Index", $"{GetPollenValue(tl.TreeCottonwood.Value)}")
            End If

            If tl.TreeCypress IsNot Nothing AndAlso tl.TreeCypress.HasValue Then
                .Rows.Add("Cypress Tree Pollen Index", $"{GetPollenValue(tl.TreeCypress.Value)}")
            End If

            If tl.TreeElder IsNot Nothing AndAlso tl.TreeElder.HasValue Then
                .Rows.Add("Elder Tree Pollen Index", $"{GetPollenValue(tl.TreeElder.Value)}")
            End If

            If tl.TreeElm IsNot Nothing AndAlso tl.TreeElm.HasValue Then
                .Rows.Add("Elm Tree Pollen Index", $"{GetPollenValue(tl.TreeElm.Value)}")
            End If

            If tl.TreeHemlock IsNot Nothing AndAlso tl.TreeHemlock.HasValue Then
                .Rows.Add("Hemlock Tree Pollen Index", $"{GetPollenValue(tl.TreeHemlock.Value)}")
            End If

            If tl.TreeHickory IsNot Nothing AndAlso tl.TreeHickory.HasValue Then
                .Rows.Add("Hickory Tree Pollen Index", $"{GetPollenValue(tl.TreeHickory.Value)}")
            End If

            If tl.TreeJuniper IsNot Nothing AndAlso tl.TreeJuniper.HasValue Then
                .Rows.Add("Juniper Tree Pollen Index", $"{GetPollenValue(tl.TreeJuniper.Value)}")
            End If

            If tl.TreeMahogany IsNot Nothing AndAlso tl.TreeMahogany.HasValue Then
                .Rows.Add("Mahogany Tree Pollen Index", $"{GetPollenValue(tl.TreeMahogany.Value)}")
            End If

            If tl.TreeMaple IsNot Nothing AndAlso tl.TreeMaple.HasValue Then
                .Rows.Add("Maple Tree Pollen Index", $"{GetPollenValue(tl.TreeMaple.Value)}")
            End If

            If tl.TreeMulberry IsNot Nothing AndAlso tl.TreeMulberry.HasValue Then
                .Rows.Add("Mulberry Tree Pollen Index", $"{GetPollenValue(tl.TreeMulberry.Value)}")
            End If

            If tl.TreeOak IsNot Nothing AndAlso tl.TreeOak.HasValue Then
                .Rows.Add("Oak Tree Pollen Index", $"{GetPollenValue(tl.TreeOak.Value)}")
            End If

            If tl.TreePine IsNot Nothing AndAlso tl.TreePine.HasValue Then
                .Rows.Add("Pine Tree Pollen Index", $"{GetPollenValue(tl.TreePine.Value)}")
            End If

            If tl.TreeSpruce IsNot Nothing AndAlso tl.TreeSpruce.HasValue Then
                .Rows.Add("Spruce Tree Pollen Index", $"{GetPollenValue(tl.TreeSpruce.Value)}")
            End If

            If tl.TreeSycamore IsNot Nothing AndAlso tl.TreeSycamore.HasValue Then
                .Rows.Add("Sycamore Tree Pollen Index", $"{GetPollenValue(tl.TreeSycamore.Value)}")
            End If

            If tl.TreeWalnut IsNot Nothing AndAlso tl.TreeWalnut.HasValue Then
                .Rows.Add("Walnut Tree Pollen Index", $"{GetPollenValue(tl.TreeWalnut.Value)}")
            End If

            If tl.TreeWillow IsNot Nothing AndAlso tl.TreeWillow.HasValue Then
                .Rows.Add("Willow Tree Pollen Index", $"{GetPollenValue(tl.TreeWillow.Value)}")
            End If

            If tl.Grass IsNot Nothing AndAlso tl.Grass.HasValue Then
                .Rows.Add("Grass Pollen Index", $"{GetPollenValue(tl.Grass.Value)}")
            End If

            If tl.GrassGrass IsNot Nothing AndAlso tl.GrassGrass.HasValue Then
                .Rows.Add("Grass Grass Pollen Index", $"{GetPollenValue(tl.GrassGrass.Value)}")
            End If

            If tl.Weed IsNot Nothing AndAlso tl.Weed.HasValue Then
                .Rows.Add("Weed Pollen Index", $"{GetPollenValue(tl.Weed.Value)}")
            End If

            If tl.WeedRagweed IsNot Nothing AndAlso tl.WeedRagweed.HasValue Then
                .Rows.Add("Ragweed Pollen Index", $"{GetPollenValue(tl.WeedRagweed.Value)}")
            End If

            'Maritime data

            If tl.WindWaveSignificantHeight IsNot Nothing AndAlso tl.WindWaveSignificantHeight.HasValue Then
                .Rows.Add("Height of combined wind waves and swells", $"{tl.WindWaveSignificantHeight.Value} {unitNfo.WaveSignificantHeight}")
            End If

            If tl.WaveDirection IsNot Nothing AndAlso tl.WaveDirection.HasValue Then
                .Rows.Add("Direction the combined wind waves and swells are moving in", $"{tl.WaveDirection.Value}{unitNfo.WaveDirection}")
            End If

            If tl.WaveMeanPeriod IsNot Nothing AndAlso tl.WaveMeanPeriod.HasValue Then
                .Rows.Add("Frequency of combined wind waves and swells; or, the space and time between each wave", $"{tl.WaveMeanPeriod.Value} {unitNfo.WaveMeanPeriod}")
            End If

            If tl.WindWaveSignificantHeight IsNot Nothing AndAlso tl.WindWaveSignificantHeight.HasValue Then
                .Rows.Add("Height of wind waves", $"{tl.WindWaveSignificantHeight.Value} {unitNfo.WindWaveSignificantHeight}")
            End If

            If tl.WindWaveDirection IsNot Nothing AndAlso tl.WindWaveDirection.HasValue Then
                .Rows.Add("Direction the combined wind waves and swells are moving in", $"{tl.WindWaveDirection.Value}{unitNfo.WindWaveDirection}")
            End If

            If tl.WindWaveMeanPeriod IsNot Nothing AndAlso tl.WindWaveMeanPeriod.HasValue Then
                .Rows.Add("Frequency of combined wind waves and swells; or, the space and time between each wave", $"{tl.WindWaveMeanPeriod.Value} {unitNfo.WindWaveMeanperiod}")
            End If

            If tl.PrimarySwellSignificantHeight IsNot Nothing AndAlso tl.PrimarySwellSignificantHeight.HasValue Then
                .Rows.Add("Height of primary swell", $"{tl.PrimarySwellSignificantHeight.Value} {unitNfo.PrimarySwellSignificantHeight}")
            End If

            If tl.PrimarySwellDirection IsNot Nothing AndAlso tl.PrimarySwellDirection.HasValue Then
                .Rows.Add("Direction the primary swells are moving in", $"{tl.PrimarySwellDirection.Value}{unitNfo.PrimarySwellDirection}")
            End If

            If tl.PrimarySwellMeanPeriod IsNot Nothing AndAlso tl.PrimarySwellMeanPeriod.HasValue Then
                .Rows.Add("Frequency of primary swells; or, the space and time between each wave", $"{tl.PrimarySwellMeanPeriod.Value} {unitNfo.PrimarySwellMeanPeriod}")
            End If

            If tl.SecondarySwellSignificantHeight IsNot Nothing AndAlso tl.SecondarySwellSignificantHeight.HasValue Then
                .Rows.Add("Height of secondary swells", $"{tl.SecondarySwellSignificantHeight.Value} {unitNfo.SecondarySwellSignificantHeight}")
            End If

            If tl.SecondarySwellDirection IsNot Nothing AndAlso tl.SecondarySwellDirection.HasValue Then
                .Rows.Add("Direction the secondary swells are moving in", $"{tl.SecondarySwellDirection.Value}{unitNfo.SecondarySwellDirection}")
            End If

            If tl.SecondarySwellMeanPeriod IsNot Nothing AndAlso tl.SecondarySwellMeanPeriod.HasValue Then
                .Rows.Add("Frequency of secondary swells; or, the space and time between each wave", $"{tl.SecondarySwellMeanPeriod.Value} {unitNfo.SecondarySwellMeanPeriod}")
            End If

            If tl.TertiarySwellSignificantHeight IsNot Nothing AndAlso tl.TertiarySwellSignificantHeight.HasValue Then
                .Rows.Add("Height of tertiary swells", $"{tl.TertiarySwellSignificantHeight.Value} {unitNfo.TertiarySwellSignificantHeight}")
            End If

            If tl.TertiarySwellDirection IsNot Nothing AndAlso tl.TertiarySwellDirection.HasValue Then
                .Rows.Add("Direction the tertiary swells are moving in", $"{tl.TertiarySwellDirection.Value}{unitNfo.TertiarySwellDirection}")
            End If

            If tl.TertiarySwellMeanPeriod IsNot Nothing AndAlso tl.TertiarySwellMeanPeriod.HasValue Then
                .Rows.Add("Frequency of tertiary swells; or, the space and time between each wave", $"{tl.TertiarySwellMeanPeriod.Value} {unitNfo.TertiarySwellMeanPeriod}")
            End If
        End With
    End Sub

    Private Sub WriteWarnings()
        Try
            With FrmMainv4.DgvWarnings
                .Rows.Clear()
                ' .ColumnCount = 3
                PrintLog($"**> Warning records total count: {tlNfo.Warnings.Count}{vbLf}")
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
                            .Rows.Add("", "Location", tw.Meta.Location)
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
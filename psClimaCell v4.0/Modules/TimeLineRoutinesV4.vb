Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.Json
Imports psClimaCell_v4._0.Modules.DayColors

Friend Module TimeLineRoutinesV4

    Private tlNfo As CcTimelinesModel

    Friend Sub FetchTimeLines()
        Dim tlFile As String = Path.Combine(TempDir, $"tlData_{Now:Mddyy-HH}.json")
        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
            FrmMainv4.TC.SelectedTab = FrmMainv4.TpAppOptions
            Exit Sub
        End If

        If File.Exists(tlFile) Then
            Dim ab As Double = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(tlFile))) / 60
            If ab >= My.Settings.UpdateInt_Timelines - 1 Then
                DownloadTimeLines(tlFile)
            Else
                ParseTimeLines(ab, tlFile)
            End If
        Else
            DownloadTimeLines(tlFile)
        End If

    End Sub

    Private Async Sub DownloadTimeLines(fn As String)
        Try
            Dim url As String = $"https://data.climacell.co/v4/timelines?apikey={My.Settings.ApiKey}&location={My.Settings.cLatitude},{My.Settings.cLongitude}&timesteps={GetTimeStepString()}&fields={GetFieldsString()}&units={unitArr(My.Settings.Units)}"

            PrintLog($"TimeLines Url: {url}{vbLf}{vbLf}")

            Dim request = CType(WebRequest.Create(New Uri(url)), HttpWebRequest)
            With request
                .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
                .Accept = "application/json"
                .Timeout = 120000
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .UserAgent = Use_Agent
            End With
            Using response = CType(Await request.GetResponseAsync().ConfigureAwait(True), HttpWebResponse)
                If My.Settings.Log_Headers Then
                    Dim sc As New StringBuilder()
                    PrintLog($"{vbLf}{vbLf}ClimaCell Realtime Headers:{vbLf}{vbLf}")
                    For j = 0 To response.Headers.Count - 1
                        PrintLog($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                        sc.Append($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                    Next
                    sc.Clear()
                End If
                PrintLog($"{My.Resources.separator}{vbLf}{vbLf}")
                If response.StatusCode = 200 Then
                    PrintLog($"Download Rt Data @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                    Dim dStr = response.GetResponseStream()
                    Using reader = New StreamReader(dStr)
                        Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)   'ddd
                        File.WriteAllText(fn, resp)
                        PrintLog($"Realtime file saved -> {fn}{vbLf}")
                        'I prefer to search the Json file and replace the NULLs with "0"s.  Probably could use "-1" and then trap for the "-1".  do not write the correct Json file to disk
                        'so that you will have the original data for reference.  Apply same thing to ParseTimeLines
                        tlNfo = JsonSerializer.Deserialize(Of CcTimelinesModel)(resp.Replace("null", "0"))
                        Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                            Await aTxt.WriteLineAsync($"{My.Resources.separator}{vbLf}").ConfigureAwait(True)
                            Await aTxt.WriteLineAsync($"ClimaCell Realtime Forecast Data @ {Now:T}{vbLf}ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                        End Using

                        Dim TsCnt As Integer
                        'seatch for "1d" data stream
                        If CBool(InStr(resp, "timestep"":""1d", CompareMethod.Text)) Then
                            For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                                If tlNfo.WxData.TimeLines(j).TimeStep = "1d" Then
                                    TsCnt = j
                                    WriteTimeLinesData(TsCnt)
                                    Exit For
                                End If
                            Next
                        End If

                        If CBool(InStr(resp, "timestep"":""current", CompareMethod.Text)) Then
                            For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                                If tlNfo.WxData.TimeLines(j).TimeStep = "current" Then
                                    TsCnt = j
                                    WriteCurrentData(TsCnt)
                                    Exit For
                                End If
                            Next
                        End If

                        'search for "1h' data stream
                        If CBool(InStr(resp, "timestep"":""1h", CompareMethod.Text)) Then
                            For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                                If tlNfo.WxData.TimeLines(j).TimeStep = "1h" Then
                                    TsCnt = j
                                    WriteHourlyData(TsCnt)
                                    Exit For
                                End If
                            Next
                        End If
                    End Using
                Else
                    PrintLog($"Download Rt Data @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                    SaveLogs()
                    Return
                End If
            End Using
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try

    End Sub
    Private Function GetFieldsString() As String
        'temperature field is set to fetch Min and Max temperature for time period.
        Dim tlFields As New List(Of String)({"temperature%2CtemperatureMax%2CtemperatureMin%2CtemperatureMaxTime%2CtemperatureMinTime", "temperatureApparent", "dewPoint", "humidity", "windSpeed", "windDirection", "windGust", "pressureSurfaceLevel", "pressureSeaLevel", "precipitationIntensity", "precipitationProbability", "precipitationType", "sunriseTime", "sunsetTime", "moonPhase", "solarGHI", "visibility", "cloudCover", "cloudBase", "cloudCeiling", "weatherCode", "particulateMatter25", "particulateMatter10", "pollutantO3", "pollutantNO2", "pollutantCO", "pollutantSO2", "mepIndex", "mepPrimaryPollutant", "mepHealthConcern", "epaIndex", "epaPrimaryPollutant", "epaHealthConcern", "treeIndex", "treeAcaciaIndex", "treeAshIndex", "treeBeechIndex", "treeBirchIndex", "treeCedarIndex", "treeCypressIndex", "treeElderIndex", "treeElmIndex", "treeHemlockIndex", "teeHickoryIndex", "treeJuniperIndex", "treeMahagonyIndex", "treeMapleIndex", "treeMulberryIndex", "treeOakIndex", "treePineIndex", "treeCottonwoodIndex", "treeSpruceIndex", "treeSycamoreIndex", "treeWalnutIndex", "treeWillowIndex", "grassIndex", "grassGrassIndex", "weedIndex", "", "hailBinary", "fireIndex"})
        '58 = weedGrassweedIndex
        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMainv4.FlpDataFields.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                sb.Append(tlFields(CInt(c.Tag)))
                If Not String.IsNullOrEmpty(CStr(CInt(c.Tag))) Then
                    sb.Append("%2C")
                End If
            End If
        Next
        Dim aa = sb.ToString
        If String.IsNullOrEmpty(aa) Then
            Return "temperature"
        Else
            Return Left(aa, aa.Length - 3)
        End If
    End Function

    Private Function GetTimeStepString() As String
        Dim tsArr As New List(Of String)({"1m", "5m", "15m", "30m", "1h", "1d", "current"})
        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMainv4.GbTimeSteps.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                sb.Append(tsArr(CInt(c.Tag)))
                sb.Append("%2C")
            End If
        Next
        Dim aa = sb.ToString
        Return Left(aa, aa.Length - 3)
    End Function

    Private Async Sub ParseTimeLines(ab As Double, fn As String)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                    Await aTxt.WriteLineAsync($"{My.Resources.separator}{vbLf}").ConfigureAwait(True)
                    Await aTxt.WriteLineAsync($"Parsed ClimaCell Realtime Forecast Data @ {Now:T}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                End Using
                tlNfo = JsonSerializer.Deserialize(Of CcTimelinesModel)(resp.Replace("null", "0"))
                PrintLog($"[Parsed] Realtime Forecast Data @ {Now:T}{vbLf}File age: {ab:N2} minutes{vbLf}{vbLf}")

                'need to determine which timeline has the "1d" forecast for the "Daily" tab
                Dim TsCnt As Integer
                If CBool(InStr(resp, "timestep"":""1d", CompareMethod.Text)) Then
                    For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                        If tlNfo.WxData.TimeLines(j).TimeStep = "1d" Then
                            TsCnt = j
                            WriteTimeLinesData(TsCnt)
                            Exit For
                        End If
                    Next
                End If

                If CBool(InStr(resp, "timestep"":""current", CompareMethod.Text)) Then
                    For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                        If tlNfo.WxData.TimeLines(j).TimeStep = "current" Then
                            TsCnt = j
                            WriteCurrentData(TsCnt)
                            Exit For
                        End If
                    Next
                End If

                If CBool(InStr(resp, "timestep"":""1h", CompareMethod.Text)) Then
                    For j = 0 To tlNfo.WxData.TimeLines.Count - 1
                        If tlNfo.WxData.TimeLines(j).TimeStep = "1h" Then
                            TsCnt = j
                            WriteHourlyData(TsCnt)
                            Exit For
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub


    Private Sub WriteCurrentData(TsCnt As Integer)
        PrintLog($"Writing timelines current data @ {Now:F}.{vbLf}")

        Try
            With FrmMainv4.DgvCurrent
                .Rows.Clear()

                For j = 0 To tlNfo.WxData.TimeLines(TsCnt).Intervals.Count - 1
                    Dim tl = tlNfo.WxData.TimeLines(TsCnt).Intervals(j).Values
                    .Rows.Add("Time", $"{tlNfo.WxData.TimeLines(TsCnt).Intervals(j).StartTime.ToLocalTime:h:mm tt}")
                    .Rows.Add($"Temperature", $"{tl.Temp:N0}{unitNfo.Temperature}")
                    .Rows.Add($"Weather", $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}")
                    .Rows.Add($"Wind", $"{Deg2Compass(CDbl(tl.WindDir.Value))} @ {Math.Ceiling(CDec(tl.WindSpeed.Value)):N0} {unitNfo.WindSpeed}")
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
                Next

            End With

        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            'SaveLogs()
        End Try
    End Sub
    Private Sub WriteTimeLinesData(tsCnt As Integer)
        PrintLog($"Writing timelines daily data @ {Now:F}.{vbLf}")
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

                For j = 0 To tlNfo.WxData.TimeLines(tsCnt).Intervals.Count - 1
                    Dim tl = tlNfo.WxData.TimeLines(tsCnt).Intervals(j).Values
                    Dim sb As New StringBuilder()
                    sb.Append($"Temp: {tl.TempMax.Value:N0}{unitNfo.Temperature} - {tl.TempMin.Value:N0}{unitNfo.Temperature}{vbLf}")
                    sb.Append($"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}{vbLf}")
                    sb.Append($"Wind {Deg2Compass(CDbl(tl.WindDir.Value))} @ {Math.Ceiling(CDec(tl.WindSpeed.Value)):N0} {unitNfo.WindSpeed}{vbLf}")
                    sb.Append($"Precip: {tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}{vbLf}")
                    sb.Append($"Type: {unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                    sb.Append($"Intensity: {tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                    sb.Append($"Bp: {tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
                    sb.Append($"Sr: {tl.Sunrise.ToLocalTime:t}{vbLf}")
                    sb.Append($"Ss: {tl.Sunset.ToLocalTime:t}{vbLf}")

                    Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                    sb.Append($"{unitNfo.MoonPhase.Values(tlNfo.WxData.TimeLines(tsCnt).Intervals(j).Values.MoonPhase.Value)}{vbLf}")
                    sb.Append($"Vis: {tl.Visibility.Value:N0} {unitNfo.Visibility}{vbLf}")

                    Dim icn As String = Path.Combine(IconDir, "PNG", "Color", $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString).ToLower.Replace(" ", "_")}.png")
                    If My.Settings.Log_Images Then PrintLog($"{j}. Daily: {icn} --> Bitmap{vbLf}")

                    Dim bgClr = If(Date2Unix(CDate(Now)) >= Date2Unix(CDate(tlNfo.WxData.TimeLines(tsCnt).Intervals(0).Values.Sunrise.ToLocalTime)) And Date2Unix(Now) <= Date2Unix(CDate(tlNfo.WxData.TimeLines(tsCnt).Intervals(0).Values.Sunset.ToLocalTime)),
                        Color.LightSkyBlue,
                        Color.Gray)
                    Using bmp1 As New Bitmap(icn)
                        Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", $"na.png"))
                            If j <= 7 Then
                                .Rows(0).Cells(j).Style.BackColor = bgClr
                                '.Rows(0).Cells(j).Value = Transparent2Color(bmp1, bgClr)
                                .Rows(0).Cells(j).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                .Rows(0).Cells(j).ToolTipText = $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}{vbLf}"
                                .Rows(1).Cells(j).Value = sb.ToString
                                .Rows(2).Cells(j).Value = $"{tlNfo.WxData.TimeLines(tsCnt).Intervals(j).StartTime:dddd}"
                                .Rows(2).Cells(j).Style.BackColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Bg
                                .Rows(2).Cells(j).Style.ForeColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Fg
                                .Rows(3).Cells(j).Value = $"{tlNfo.WxData.TimeLines(tsCnt).Intervals(j).StartTime:MMM d}"
                            ElseIf j >= 8 Then
                                '.Rows(4).Cells(j - 8).Value = Transparent2Color(bmp1, bgClr)
                                .Rows(4).Cells(j - 8).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                .Rows(4).Cells(j - 8).Style.BackColor = bgClr
                                .Rows(0).Cells(j - 8).ToolTipText = $"{unitNfo.WeatherCode(tl.WxCode.Value.ToString)}{vbLf}"
                                .Rows(5).Cells(j - 8).Value = sb.ToString
                                .Rows(6).Cells(j - 8).Value = $"{tlNfo.WxData.TimeLines(tsCnt).Intervals(j).StartTime:dddd}"
                                .Rows(6).Cells(j - 8).Style.BackColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Bg
                                .Rows(6).Cells(j - 8).Style.ForeColor = DgvColorDay(CDbl(tl.TempMax.Value), CDbl(tl.TempMin.Value)).Fg
                                .Rows(7).Cells(j - 8).Value = $"{tlNfo.WxData.TimeLines(tsCnt).Intervals(j).StartTime:MMM d}"
                            End If
                        End Using
                    End Using
                    sb.Clear()
                    Application.DoEvents()
                Next

                .Rows(4).Cells(7).Value = Transparent2Color(My.Resources.PS_LOGO_transparent_190x150, Color.MintCream)
                .Rows(1).DefaultCellStyle.BackColor = Color.DarkGray
                .Rows(3).DefaultCellStyle.BackColor = Color.Gainsboro
                .Rows(5).DefaultCellStyle.BackColor = Color.DarkGray
                .Rows(7).DefaultCellStyle.BackColor = Color.Gainsboro
                .Rows(6).Cells(7).Style.BackColor = Color.DarkGray
                .Rows(7).Cells(7).Style.BackColor = Color.DarkGray

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
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            'SaveLogs()
        End Try
    End Sub

    Private Sub WriteHourlyData(TsCnt As Integer)
        PrintLog($"Writing timelines hourly data @ {Now:F}.{vbLf}")
        Try
            With FrmMainv4.DgvHour
                .Rows.Clear()
                For j = 0 To tlNfo.WxData.TimeLines(TsCnt).Intervals.Count - 1
                    Dim tl = tlNfo.WxData.TimeLines(TsCnt).Intervals(j).Values
                    Dim tld = tlNfo.WxData.TimeLines(TsCnt).Intervals(j)
                    .Rows.Add($"{tld.StartTime.ToLocalTime:MMM d}")
                    .Rows.Add("", $"{tld.StartTime.ToLocalTime:h:mm tt}")
                    .Rows.Add("", "", "Temperature", $"{tl.TempMax.Value:N0}{unitNfo.Temperature}")
                    .Rows.Add("", "", "Wind", $"{Deg2Compass(tl.WindDir.Value)} @ {Math.Ceiling(CDec(tl.WindSpeed.Value)):N0} {unitNfo.WindSpeed} gusting to {Math.Ceiling(CDec(tl.WindGust.Value)):N0} {unitNfo.WindGust}")
                    .Rows.Add("", "", "Precipitation", $"{tl.PrecipPct.Value}{unitNfo.PrecipitationProbability}")
                    .Rows.Add("", "", "Precipitation Type", $"{unitNfo.PrecipitationType(tl.PrecipType.Value.ToString)}{vbLf}")
                    .Rows.Add("", "", "Precipitation Intensity", $"{tl.PrecipIntensity.Value:N3} {unitNfo.PrecipitationIntensity}{vbLf}")
                    .Rows.Add("", "", "Surface Level Pressure", $"{tl.PressureSurfaceLevel.Value} {unitNfo.PressureSurfaceLevel}{vbLf}")
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
                    .ClearSelection()
                Next

            End With
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            'SaveLogs()
        End Try
    End Sub
End Module
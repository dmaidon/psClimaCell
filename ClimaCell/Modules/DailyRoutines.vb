Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.Json
Imports ClimaCell.Models
Imports ClimaCell.Modules

Friend Module DailyRoutines

    Private dNfo As DailyData()

    Friend Sub FetchDailyData()
        Dim pFile As String = Path.Combine(TempDir, $"daily-{Now:Mdyy_HH}.json")
        If File.Exists(pFile) Then
            Dim ab = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(pFile))) / 60
            If ab >= My.Settings.UpdateInterval_Daily - 1 Then
                DownloadDailyData(pFile)
            Else
                ParseDailyData(ab, pFile)
            End If
        Else
            DownloadDailyData(pFile)
        End If
    End Sub

    Private Async Sub DownloadDailyData(fn As String)
        Try
            Dim url = $"https://api.climacell.co/v3/weather/forecast/daily?lat={My.Settings.cLatitude}&lon={My.Settings.cLongitude}&unit_system={uArr(My.Settings.Units)}&start_time=now&fields={GetDailyString()}&apikey={My.Settings.ApiKey}"
            PrintLog($"{vbLf}Daily Url: {url}{vbLf}")
            Dim request = CType(WebRequest.Create(New Uri(url)), HttpWebRequest)
            With request
                .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
                .Accept = "application/json"
                .Timeout = 120000
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .UserAgent = Use_Agent
            End With
            Using response = CType(Await request.GetResponseAsync().ConfigureAwait(True), HttpWebResponse)
                Dim sc As New StringBuilder()
                PrintLog($"{vbLf}{vbLf}ClimaCell Daily Headers:{vbLf}{vbLf}")
                For j = 0 To response.Headers.Count - 1
                    PrintLog($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                    sc.Append($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                Next
                sc.Clear()
                PrintLog($"{Separator}{vbLf}{vbLf}")

                If response.StatusCode = 200 Then
                    PrintLog($"Download @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                    Dim dStr = response.GetResponseStream()
                    Using reader = New StreamReader(dStr)
                        Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)   'ddd
                        File.WriteAllText(fn, resp)
                        PrintLog($"Daily file saved -> {fn}{vbLf}")
                        dNfo = JsonSerializer.Deserialize(Of DailyData())(resp)
                        Using aTxt As StreamWriter = File.AppendText(dlyDataFile)
                            Await aTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                            Await aTxt.WriteLineAsync($"ClimaCell Daily Forecast Data @ {Now:T}{vbLf}ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                        End Using
                        WriteDgvDaily()
                    End Using
                Else
                    PrintLog($"Download @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
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
    Private Function GetDailyString() As String
        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMain.TlpDaily.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                Select Case CInt(c.Tag)
                    Case 0
                        sb.Append("temp")
                    Case 1
                        sb.Append("feels_like")
                    Case 2
                        sb.Append("dewpoint")
                    Case 3
                        sb.Append("humidity")
                    Case 4
                        sb.Append("wind_speed")
                    Case 5
                        sb.Append("wind_direction")
                    Case 6
                        sb.Append("baro_pressure")
                    Case 7
                        sb.Append("precipitation")
                    Case 8
                        sb.Append("precipitation_probability")
                    Case 9
                        sb.Append("precipitation_accumulation")
                    Case 10
                        sb.Append("sunrise")
                    Case 11
                        sb.Append("sunset")
                    Case 12
                        sb.Append("visibility")
                    Case 13
                        sb.Append("weather_code")
                    Case 14
                        sb.Append("moon_phase")
                    Case Else
                        sb.Append("")
                End Select
                sb.Append("%2C")
            End If
            Application.DoEvents()
        Next
        Dim aa = sb.ToString
        Return Left(aa, aa.Length - 3)
    End Function
    Private Async Sub ParseDailyData(fa As Double, fn As String)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using aTxt As StreamWriter = File.AppendText(dlyDataFile)
                    Await aTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                    Await aTxt.WriteLineAsync($"Parsed ClimaCell Daily Forecast Data @ {Now:T}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                End Using
                dNfo = JsonSerializer.Deserialize(Of DailyData())(resp)
                PrintLog($"[Parsed] Daily Forecast Data @ {Now:T}{vbLf}File age: {fa:N2} minutes{vbLf}{vbLf}")
            End Using
            WriteDgvDaily()
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub

    Private Sub WriteDgvDaily()
        PrintLog($"Writing daily data.{vbLf}")
        'Dim sr = Date2Unix(dNfo(0).Sunrise.Value)
        'Dim ss = Date2Unix(dNfo(0).Sunset.Value)
        'Dim Daylight As Boolean = Date2Unix(Now) > sr AndAlso Date2Unix(Now) < ss
        'PrintLog($"Daylight set: {Daylight}{vbLf}")
        Try
            With FrmMain.DgvDaily
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

                For j = 0 To dNfo.Length - 1
                    Dim sb As New StringBuilder()
                    sb.Append($"Hi: {dNfo(j).Temp(1).Max.Value:N0}°F   Lo: {dNfo(j).Temp(0).Min.Value:N0}°F{vbLf}")
                    sb.Append($"Wind {Deg2Compass(CDbl(dNfo(j).WindDirection(1).Max.Value))} @ {Math.Ceiling(CDec(dNfo(j).WindSpeed(1).Max.Value))} mph{vbLf}")
                    sb.Append($"Precip: {dNfo(j).PrecipitationProbability.Value}%{vbLf}")
                    sb.Append($"Accum: {dNfo(j).PrecipitationAccumulation.Value} in.{vbLf}")
                    sb.Append($"Bp: {dNfo(j).BaroPressure(0).Min.Value} - {dNfo(j).BaroPressure(1).Max.Value} inHg{vbLf}")
                    sb.Append($"Sr: {dNfo(j).Sunrise.Value:t}{vbLf}")
                    sb.Append($"Ss: {dNfo(j).Sunset.Value:t}{vbLf}")

                    Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                    sb.Append($"{myTI.ToTitleCase(dNfo(j).MoonPhase.Value).Replace("_", " ")}{vbLf}")
                    sb.Append($"Vis: {dNfo(j).Visibility(0).Min.Value} mi{vbLf}")
                    sb.Append($"{myTI.ToTitleCase(dNfo(j).WeatherCode.Value).Replace("_", " ")}{vbLf}")
                    Dim icn As String = Path.Combine(IconDir, "PNG", "Color", $"{dNfo(j).WeatherCode.Value}.png")
                    PrintLog($"{j}. Dly: {icn} --> Bitmap{vbLf}")

                    Dim isDay As Boolean
                    Dim bgClr As Color
                    If Date2Unix(CDate(dNfo(j).ObservationTime.Value)) >= Date2Unix(CDate(dNfo(j).Sunrise.Value)) And Date2Unix(CDate(dNfo(j).ObservationTime.Value)) <= Date2Unix(CDate(dNfo(j).Sunset.Value)) Then
                        isDay = True
                        bgClr = Color.LightSkyBlue
                    Else
                        isDay = False
                        bgClr = Color.Gray
                    End If
                    Using bmp1 As New Bitmap(icn)
                        Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", $"na.png"))
                            If j <= 7 Then
                                .Rows(0).Cells(j).Style.BackColor = bgClr
                                '.Rows(0).Cells(j).Value = Transparent2Color(bmp1, bgClr)
                                .Rows(0).Cells(j).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                .Rows(1).Cells(j).Value = sb.ToString
                                .Rows(2).Cells(j).Value = $"{dNfo(j).ObservationTime.Value:dddd}"
                                .Rows(2).Cells(j).Style.BackColor = DgvColorDay(CDbl(dNfo(j).Temp(1).Max.Value), CDbl(dNfo(j).Temp(0).Min.Value)).Bg
                                .Rows(2).Cells(j).Style.ForeColor = DgvColorDay(CDbl(dNfo(j).Temp(1).Max.Value), CDbl(dNfo(j).Temp(0).Min.Value)).Fg
                                .Rows(3).Cells(j).Value = $"{dNfo(j).ObservationTime.Value:MMM d}"
                            ElseIf j >= 8 Then
                                '.Rows(4).Cells(j - 8).Value = Transparent2Color(bmp1, bgClr)
                                .Rows(4).Cells(j - 8).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                                .Rows(4).Cells(j - 8).Style.BackColor = bgClr
                                .Rows(5).Cells(j - 8).Value = sb.ToString
                                .Rows(6).Cells(j - 8).Value = $"{dNfo(j).ObservationTime.Value:dddd}"
                                .Rows(6).Cells(j - 8).Style.BackColor = DgvColorDay(CDbl(dNfo(j).Temp(1).Max.Value), CDbl(dNfo(j).Temp(0).Min.Value)).Bg
                                .Rows(6).Cells(j - 8).Style.ForeColor = DgvColorDay(CDbl(dNfo(j).Temp(1).Max.Value), CDbl(dNfo(j).Temp(0).Min.Value)).Fg
                                .Rows(7).Cells(j - 8).Value = $"{dNfo(j).ObservationTime.Value:MMM d}"
                            End If
                        End Using
                    End Using
                        sb.Clear()
                    Application.DoEvents()
                Next

                .Rows(4).Cells(7).Value = Transparent2Color(My.Resources.PS_LOGO_transparent_190x150, Color.MintCream)
                .Rows(1).DefaultCellStyle.BackColor = Color.LemonChiffon
                .Rows(3).DefaultCellStyle.BackColor = Color.Gainsboro
                .Rows(5).DefaultCellStyle.BackColor = Color.LemonChiffon
                .Rows(7).DefaultCellStyle.BackColor = Color.Gainsboro
                .Rows(6).Cells(7).Style.BackColor = Color.LemonChiffon
                .Rows(7).Cells(7).Style.BackColor = Color.LemonChiffon

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
            SaveLogs()
        End Try
    End Sub

End Module
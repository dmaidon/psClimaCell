Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.Json
Imports psClimaCell.Models

Friend Module HourlyRoutines

    Dim hNfo As HourNum()

    Friend Sub FetchHourData()
        Dim hFile As String = Path.Combine(TempDir, $"hourly-{Now:Mdyy_HH}.json")
        If File.Exists(hFile) Then
            Dim ab = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(hFile))) / 60
            If ab >= My.Settings.UpdateInterval_Hourly - 1 Then
                DownloadHourData(hFile)
            Else
                ParseHourData(ab, hFile)
            End If
        Else
            DownloadHourData(hFile)
        End If

        SaveLogs()
    End Sub

    Private Async Sub DownloadHourData(fn As String)
        Try
            Dim url = $"https://api.climacell.co/v3/weather/forecast/hourly?lat={My.Settings.cLatitude}&lon={My.Settings.cLongitude}&unit_system={uArr(My.Settings.Units)}&start_time=now&fields={GetHourString()}&apikey={My.Settings.ApiKey}"
            PrintLog($"{vbLf}Hour Url: {url}{vbLf}")
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
                PrintLog($"{vbLf}{vbLf}ClimaCell Hourly Headers:{vbLf}{vbLf}")
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
                        Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)  'ddd
                        Using bTxt As StreamWriter = File.AppendText(hrDataFile)
                            Await bTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                            Await bTxt.WriteLineAsync($"ClimaCell Hourly Forecast Data @ {Now:T}").ConfigureAwait(True)
                            Await bTxt.WriteLineAsync($"ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}").ConfigureAwait(True)
                        End Using
                        File.WriteAllText(fn, resp)
                        PrintLog($"Hourle data file saved -> {fn}{vbLf}")
                        hNfo = JsonSerializer.Deserialize(Of HourNum())(resp)
                        WriteHourData()
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

    Private Function GetHourString() As String
        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMain.TlpHourly.Controls.OfType(Of CheckBox)()
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
                        sb.Append("wind_gust")
                    Case 7
                        sb.Append("baro_pressure")
                    Case 8
                        sb.Append("precipitation")
                    Case 9
                        sb.Append("precipitation_type")
                    Case 10
                        sb.Append("precipitation_probability")
                    Case 11
                        sb.Append("sunrise")
                    Case 12
                        sb.Append("sunset")
                    Case 13
                        sb.Append("visibility")
                    Case 14
                        sb.Append("cloud_cover")
                    Case 15
                        sb.Append("cloud_base")
                    Case 16
                        sb.Append("cloud_ceiling")
                    Case 17
                        sb.Append("surface_shortwave_radiation")
                    Case 18
                        sb.Append("moon_phase")
                    Case 19
                        sb.Append("weather_code")
                    Case 20
                        sb.Append("pollen_tree")
                    Case 21
                        sb.Append("pollen_weed")
                    Case 22
                        sb.Append("pollen_grass")
                    Case 23
                        sb.Append("pollen_tree_acacia")
                    Case 24
                        sb.Append("pollen_tree_ash")
                    Case 25
                        sb.Append("pollen_tree_beech")
                    Case 26
                        sb.Append("pollen_tree_birch")
                    Case 27
                        sb.Append("pollen_tree_cedar")
                    Case 28
                        sb.Append("pollen_tree_cypress")
                    Case 29
                        sb.Append("pollen_tree_elder")
                    Case 30
                        sb.Append("pollen_tree_elm")
                    Case 31
                        sb.Append("pollen_tree_hemlock")
                    Case 32
                        sb.Append("pollen_tree_hickory")
                    Case 33
                        sb.Append("pollen_tree_juniper")
                    Case 34
                        sb.Append("pollen_tree_mahogany")
                    Case 35
                        sb.Append("pollen_tree_maple")
                    Case 36
                        sb.Append("pollen_tree_mulberry")
                    Case 37
                        sb.Append("pollen_tree_oak")
                    Case 38
                        sb.Append("pollen_tree_pine")
                    Case 39
                        sb.Append("pollen_tree_cottonwood")
                    Case 40
                        sb.Append("pollen_tree_spruce")
                    Case 41
                        sb.Append("pollen_tree_sycamore")
                    Case 42
                        sb.Append("pollen_tree_walnut")
                    Case 43
                        sb.Append("pollen_tree_willow")
                    Case 44
                        sb.Append("pollen_weed_ragweed")
                    Case 45
                        sb.Append("pollen_grass_grass")
                    Case 46
                        sb.Append("pm10")
                    Case 47
                        sb.Append("pm25")
                    Case 48
                        sb.Append("o3")
                    Case 49
                        sb.Append("no2")
                    Case 50
                        sb.Append("co")
                    Case 51
                        sb.Append("so2")
                    Case 52
                        sb.Append("epa_aqi")
                    Case 53
                        sb.Append("epa_health_concern")
                    Case 54
                        sb.Append("epa_primary_pollutant")
                    Case 55
                        sb.Append("china_aqi")
                    Case 56
                        sb.Append("china_health_concern")
                    Case 57
                        sb.Append("china_primary_pollutant")
                    Case 58
                        sb.Append("road_risk")
                    Case 59
                        sb.Append("road_risk_score")
                    Case 60
                        sb.Append("road_risk_confidence")
                    Case 61
                        sb.Append("road_risk_conditions")
                    Case 62
                        sb.Append("hail_binary")
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

    Private Async Sub ParseHourData(fa As Double, fn As String)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using bTxt As StreamWriter = File.AppendText(hrDataFile)
                    Await bTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                    Await bTxt.WriteLineAsync($"Parsed ClimaCell Hourly Forecast Data @ {Now:T}").ConfigureAwait(True)
                    Await bTxt.WriteLineAsync($"{resp}{vbLf}").ConfigureAwait(True)
                End Using
                hNfo = JsonSerializer.Deserialize(Of HourNum())(resp)
                PrintLog($"[Parsed] Hourly Forecast Data @ {Now:T}{vbLf}File age: {fa:N2} minutes{vbLf}{vbLf}")
            End Using
            WriteHourData()
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub
    Private Sub WriteHourData()
        Try
            With FrmMain.DgvHourly
                .Rows.Clear()
                For j = 0 To hNfo.Length - 1

                    .Rows.Add()
                    Dim Icn As String = Path.Combine(IconDir, "PNG", "Color", $"{hNfo(j).WxCode.Value}.png")
                    PrintLog($"{j}. Hr: {Icn}{vbLf}")
                    Dim bgClr = If(Date2Unix(CDate(hNfo(j).ObservationTime.Value).ToLocalTime) >= Date2Unix(CDate(hNfo(j).Sunrise.Value).ToLocalTime) And Date2Unix(CDate(hNfo(j).ObservationTime.Value).ToLocalTime) <= Date2Unix(CDate(hNfo(j).Sunset.Value).ToLocalTime),
                        Color.LightSkyBlue,
                        Color.Gray)

                    Using bmp1 As New Bitmap(Icn)
                        Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", $"na.png"))
                            .Rows(j).Cells(2).Value = If(File.Exists(Icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                        End Using
                    End Using
                    .Rows(j).Cells(2).Style.BackColor = bgClr
                    .Rows(j).Cells(0).Value = $"{CDate(hNfo(j).ObservationTime.Value):MMM d}"
                    .Rows(j).Cells(1).Value = $"{CDate(hNfo(j).ObservationTime.Value):h:mm tt}"

                    Dim sb As New StringBuilder()
                    sb.Append($"Day: {CDate(hNfo(j).ObservationTime.Value):MMM d}   Hour: {CDate(hNfo(j).ObservationTime.Value):h tt}{vbLf}")
                    sb.Append($"Temp: {hNfo(j).Temp.Value:N1}°{hNfo(j).Temp.Units}{vbLf}")
                    sb.Append($"Cloud Base: {hNfo(j).CloudBase.Value} {hNfo(j).CloudBase.Units}{vbLf}")
                    sb.Append($"Cloud Cover: {hNfo(j).CloudCover.Value:N2} {hNfo(j).CloudCover.Units}{vbLf}")
                    sb.Append($"Wind {Deg2Compass(CDbl(hNfo(j).WindDir.Value))} @ {Math.Round(CDbl(hNfo(j).WindSpeed.Value)):N0} {hNfo(j).WindSpeed.Units}, gusting to {Math.Round(CDbl(hNfo(j).WindGust.Value)):N0} {hNfo(j).WindGust.Units}{vbLf}")
                    Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                    sb.Append($"Weather: {myTI.ToTitleCase(hNfo(j).WxCode.Value.Replace("_", " "))}{vbLf}")
                    sb.Append($"Precipitation: {hNfo(j).PrecipiProb.Value}{hNfo(j).PrecipiProb.Units} chance of {hNfo(j).PrecipType.Value.Replace("none", "precipitation")}{vbLf} ")
                    'If My.Settings.Hour_HailRisk AndAlso (hNfo(j).HailRisk.Value = 0 OrElse hNfo(j).HailRisk.Value = 1) Then
                    '   sb.append($"Hail Risk: {CBool(hNfo(j).HailRisk.Value)}{vbLf}")
                    'End If
                    .Rows(j).Cells(3).Value = sb.ToString
                    sb.Clear()
                    Application.DoEvents()
                Next
                .ClearSelection()
            End With
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            ''
        End Try
    End Sub

End Module
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.Json
Imports psClimaCell.Models

Friend Module RealtimeRoutines
    Private rtNfo As HourNum

    Friend Sub FetchRealtimeData()
        'quad variable limits saving realtime data to increments of a minimum of 15 minutes
        Dim quad As String
        Select Case Minute(Now)
            Case 0 To 15
                quad = "A"
            Case 16 To 30
                quad = "B"
            Case 31 To 45
                quad = "C"
            Case 45 To 59
                quad = "D"
            Case Else
                quad = "E"
        End Select

        Dim rtFile As String = Path.Combine(TempDir, $"realtime-{Now:Mdyy_HH}{quad}.json")
        If File.Exists(rtFile) Then
            Dim ab As Double = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(rtFile))) / 60
            If ab >= My.Settings.UpdateInterval_Realtime - 1 Then
                DownloadRtData(rtFile)
            Else
                ParseRtData(ab, rtFile)
            End If
        Else
            DownloadRtData(rtFile)
        End If
    End Sub

    Private Async Sub DownloadRtData(fn As String)
        Try
            Dim url As String = $"https://api.climacell.co/v3/weather/realtime?lat={My.Settings.cLatitude}&lon={My.Settings.cLongitude}&unit_system={uArr(My.Settings.Units)}&fields={GetRtString()}&apikey={My.Settings.ApiKey}"
            '&start_time=now
            PrintLog($"{vbLf}Realtime Url: {url}{vbLf}")
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
                PrintLog($"{vbLf}{vbLf}ClimaCell Realtime Headers:{vbLf}{vbLf}")
                For j = 0 To response.Headers.Count - 1
                    PrintLog($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                    sc.Append($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                Next
                sc.Clear()
                PrintLog($"{Separator}{vbLf}{vbLf}")

                If response.StatusCode = 200 Then
                    PrintLog($"Download Rt Data @ {Now:T}{vbLf}{response.StatusCode}{vbLf}{response.StatusDescription}{vbLf}*****{vbLf}")
                    Dim dStr = response.GetResponseStream()
                    Using reader = New StreamReader(dStr)
                        Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)   'ddd
                        File.WriteAllText(fn, resp)
                        PrintLog($"Realtime file saved -> {fn}{vbLf}")
                        rtNfo = JsonSerializer.Deserialize(Of HourNum)(resp)
                        Using aTxt As StreamWriter = File.AppendText(rtDataFile)
                            Await aTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                            Await aTxt.WriteLineAsync($"ClimaCell Realtime Forecast Data @ {Now:T}{vbLf}ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                        End Using
                        WriteRtData()
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

    Private Function GetRtString() As String
        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMain.FlpRtOpt.Controls.OfType(Of CheckBox)()
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
                        sb.Append("")   '("barometer")
                    Case 8
                        sb.Append("precipitation")
                    Case 9
                        sb.Append("precipitation_type")
                    Case 10
                        sb.Append("")   '("precipitation_probability")
                    Case 11
                        sb.Append("")   '("precipitation_accumulation")
                    Case 12
                        sb.Append("sunrise")
                    Case 13
                        sb.Append("sunset")
                    Case 14
                        sb.Append("moon_phase")
                    Case 15
                        sb.Append("visibility")
                    Case 16
                        sb.Append("cloud_cover")
                    Case 17
                        sb.Append("cloud_base")
                    Case 18
                        sb.Append("cloud_ceiling")
                    Case 19
                        sb.Append("surface_shortwave_radiation")
                    Case 20
                        sb.Append("weather_code")
                    Case 21
                        sb.Append("pollen_tree")
                    Case 22
                        sb.Append("pollen_weed")
                    Case 23
                        sb.Append("pollen_grass")
                    Case 24
                        sb.Append("pollen_weed_ragweed")
                    Case 25
                        sb.Append("pollen_grass_grass")
                    Case 26
                        sb.Append("pollen_tree_acacia")
                    Case 27
                        sb.Append("pollen_tree_ash")
                    Case 28
                        sb.Append("pollen_tree_beech")
                    Case 29
                        sb.Append("pollen_tree_birch")
                    Case 30
                        sb.Append("pollen_tree_cedar")
                    Case 31
                        sb.Append("pollen_tree_cypress")
                    Case 32
                        sb.Append("pollen_tree_elder")
                    Case 33
                        sb.Append("pollen_tree_elm")
                    Case 34
                        sb.Append("pollen_tree_hemlock")
                    Case 35
                        sb.Append("pollen_tree_hickory")
                    Case 36
                        sb.Append("pollen_tree_juniper")
                    Case 37
                        sb.Append("pollen_tree_mahogany")
                    Case 38
                        sb.Append("pollen_tree_maple")
                    Case 39
                        sb.Append("pollen_tree_mulberry")
                    Case 40
                        sb.Append("pollen_tree_oak")
                    Case 41
                        sb.Append("pollen_tree_pine")
                    Case 42
                        sb.Append("pollen_tree_cottonwood")
                    Case 43
                        sb.Append("pollen_tree_spruce")
                    Case 44
                        sb.Append("pollen_tree_sycamore")
                    Case 45
                        sb.Append("pollen_tree_walnut")
                    Case 46
                        sb.Append("pollen_tree_willow")
                    Case 47
                        sb.Append("road_risk_score")
                    Case 48
                        sb.Append("road_risk")
                    Case 49
                        sb.Append("road_risk_confidence")
                    Case 50
                        sb.Append("road_risk_conditions")
                    Case 51
                        sb.Append("fire_index")
                    Case 52
                        sb.Append("hail_binary")
                    Case 53
                        sb.Append("pm25")
                    Case 54
                        sb.Append("pm10")
                    Case 55
                        sb.Append("o3")
                    Case 56
                        sb.Append("no2")
                    Case 57
                        sb.Append("co")
                    Case 58
                        sb.Append("so2")
                    Case 59
                        sb.Append("epa_aqi")
                    Case 60
                        sb.Append("epa_primary_pollutant")
                    Case 61
                        sb.Append("epa_health_concern")
                    Case 62
                        sb.Append("china_aqi")
                    Case 63
                        sb.Append("china_primary_pollutant")
                    Case 64
                        sb.Append("china_health_concern")
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

    Private Async Sub ParseRtData(fa As Double, fn As String)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using aTxt As StreamWriter = File.AppendText(rtDataFile)
                    Await aTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                    Await aTxt.WriteLineAsync($"Parsed ClimaCell Realtime Forecast Data @ {Now:T}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                End Using
                rtNfo = JsonSerializer.Deserialize(Of HourNum)(resp)
                PrintLog($"[Parsed] Realtime Forecast Data @ {Now:T}{vbLf}File age: {fa:N2} minutes{vbLf}{vbLf}")
            End Using
            WriteRtData()
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub

    Private Sub WriteRtData()
        Try
            Dim RtArr As New List(Of String)({"Temperature", "Feels Like", "Dewpoint", "Humidity", "Wind Speed", "Wind Gust", "Wind Direction", "Visibility", "Precipitation", "Precipitation Type", "Cloud Cover", "Cloud Ceiling", "Cloud Base", "Solar Radiation", "Sunrise", "Sunset", "Moon Phase", "Weather", "Observation Time", "Air Quality"})

            Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
            Dim Icn As String = Path.Combine(IconDir, "PNG", "Color", $"{rtNfo.WxCode.Value}.png")
            FrmMain.TpRealtime.BackgroundImageLayout = ImageLayout.None
            Dim bgClr = If(Date2Unix(CDate(rtNfo.ObservationTime.Value).ToLocalTime) >= Date2Unix(CDate(rtNfo.Sunrise.Value).ToLocalTime) And Date2Unix(CDate(rtNfo.ObservationTime.Value).ToLocalTime) <= Date2Unix(CDate(rtNfo.Sunset.Value).ToLocalTime),
                Color.LightSkyBlue,
                Color.Gray)

            Using bmp1 As New Bitmap(Icn)
                Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", $"na.png"))
                    If File.Exists(Icn) Then
                        FrmMain.TpRealtime.BackgroundImage = Transparent2Color(bmp1, bgClr)
                    Else
                        FrmMain.TpRealtime.BackgroundImage = Transparent2Color(bmp2, bgClr)
                    End If
                    FrmMain.TpRealtime.BackColor = bgClr
                End Using
            End Using

            With FrmMain.DgvRt
                .Rows.Clear()
                .BackgroundColor = bgClr
                For j = 0 To RtArr.Count - 1
                    .Rows.Add(RtArr(j), "")
                    .Rows(j).Cells(0).Style.Font = New Font("", 10, FontStyle.Bold)
                    .Rows(j).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Rows(j).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next
                .Rows(0).Cells(1).Value = $"{rtNfo.Temp.Value}°{rtNfo.Temp.Units}"
                .Rows(1).Cells(1).Value = $"{rtNfo.FeelsLike.Value}°{rtNfo.FeelsLike.Units}"
                .Rows(2).Cells(1).Value = $"{rtNfo.Dewpoint.Value}°{rtNfo.Dewpoint.Units}"
                .Rows(3).Cells(1).Value = $"{rtNfo.RH.Value}{rtNfo.RH.Units}"
                .Rows(4).Cells(1).Value = $"{rtNfo.WindSpeed.Value} {rtNfo.WindSpeed.Units}"
                .Rows(5).Cells(1).Value = $"{rtNfo.WindGust.Value} {rtNfo.WindGust.Units}"
                .Rows(6).Cells(1).Value = $"{Deg2Compass(CDbl(rtNfo.WindDir.Value))}"
                .Rows(7).Cells(1).Value = $"{rtNfo.Visibility.Value} {rtNfo.Visibility.Units}"
                .Rows(8).Cells(1).Value = $"{rtNfo.Precip.Value} {rtNfo.Precip.Units}"
                .Rows(9).Cells(1).Value = $"{myTI.ToTitleCase(rtNfo.PrecipType.Value).Replace("_", " ")}"
                .Rows(10).Cells(1).Value = $"{rtNfo.CloudCover.Value}{rtNfo.CloudCover.Units}"
                .Rows(11).Cells(1).Value = $"{rtNfo.CloudCeiling.Value} {rtNfo.CloudCeiling.Units}"
                .Rows(12).Cells(1).Value = $"{rtNfo.CloudBase.Value} {rtNfo.CloudBase.Units}"
                .Rows(13).Cells(1).Value = $"{rtNfo.SSR.Value:N1} {rtNfo.SSR.Units}"
                .Rows(14).Cells(1).Value = $"{CDate(rtNfo.Sunrise.Value):T}"
                .Rows(15).Cells(1).Value = $"{CDate(rtNfo.Sunset.Value):T}"
                .Rows(16).Cells(1).Value = $"{myTI.ToTitleCase(rtNfo.MoonPhase.Value).Replace("_", " ")}"
                .Rows(17).Cells(1).Value = $"{myTI.ToTitleCase(rtNfo.WxCode.Value).Replace("_", " ")}"
                .Rows(18).Cells(1).Value = $"{CDate(rtNfo.ObservationTime.Value):F}"
                .Rows(19).Cells(1).Value = $"AQI: {rtNfo.EpaAqi.Value:N0}  ->  Primary Pollutant: {rtNfo.EpaPrimaryPollutant.Value}"
                .ClearSelection()
            End With
            RtArr.Clear()
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            ''
        End Try
    End Sub

End Module
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.Json
Imports ClimaCell.Models

Friend Module NowcastRoutines

    Private ncNfo As HourNum()

    Friend Sub FetchNowcastData()
        Try
            Dim ncFile As String = Path.Combine(TempDir, $"nowcast-{Now:Mdyy_HH}.json")

            If File.Exists(ncFile) Then
                Dim ab = (Date2Unix(Now) - Date2Unix(File.GetLastWriteTime(ncFile))) / 60
                If ab <= My.Settings.UpdateInterval_Nowcast - 1 Then
                    ParseNowcastData(ncFile, ab)
                Else
                    DownloadNowCastData(ncFile)
                End If
            Else
                DownloadNowCastData(ncFile)
            End If
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub

    Private Async Sub DownloadNowCastData(fn As String)
        Try
            Dim url As String = $"https://api.climacell.co/v3/weather/nowcast?lat={My.Settings.cLatitude}&lon={My.Settings.cLongitude}&unit_system={uArr(My.Settings.Units)}&timestep=15&start_time=now&fields={GetNowcastString()}&apikey={My.Settings.ApiKey}"
            PrintLog($"{vbLf}Nowcast Url: {url}{vbLf}")
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
                PrintLog($"{vbLf}{vbLf}ClimaCell Nowcast Headers:{vbLf}{vbLf}")
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
                        PrintLog($"Nowcast file saved -> {fn}{vbLf}")
                        ncNfo = JsonSerializer.Deserialize(Of HourNum())(resp)
                        Using cTxt As StreamWriter = File.AppendText(ncDataFile)
                            Await cTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                            Await cTxt.WriteLineAsync($"ClimaCell Nowcast Forecast Data @ {Now:T}{vbLf}ID: {response.GetResponseHeader("X-Correlation-ID")}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                        End Using
                        WriteDgvNowcast()
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

    Private Function GetNowcastString() As String

        Dim sb = New StringBuilder()
        For Each c As CheckBox In FrmMain.TlpNowcast.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                Select Case CInt(c.Tag)
                    Case 0
                        sb.Append("temp")
                    Case 1
                        sb.Append("feels_like")
                    Case 2
                        sb.Append("humidity")
                    Case 3
                        sb.Append("wind_direction")
                    Case 4
                        sb.Append("wind_gust")
                    Case 5
                        sb.Append("precipitation")
                    Case 6
                        sb.Append("precipitation_type")
                    Case 7
                        sb.Append("sunrise")
                    Case 8
                        sb.Append("visibility")
                    Case 9
                        sb.Append("cloud_cover")
                    Case 10
                        sb.Append("cloud_ceiling")
                    Case 11
                        sb.Append("weather_code")
                    Case 12
                        sb.Append("sunset")
                    Case 13
                        sb.Append("dewpoint")
                    Case 14
                        sb.Append("wind_speed")
                    Case 15
                        sb.Append("cloud_base")
                    Case 16
                        sb.Append("baro_pressure")
                    Case 17
                        sb.Append("surface_shortwave_radiation")
                    Case 18
                        sb.Append("hail_binary")
                    Case 19
                        sb.Append("pollen_tree")
                    Case 20
                        sb.Append("pollen_weed")
                    Case 21
                        sb.Append("pollen_grass")
                    Case 22
                        sb.Append("pollen_tree_acacia")
                    Case 23
                        sb.Append("pollen_tree_birch")
                    Case 24
                        sb.Append("pollen_tree_elder")
                    Case 25
                        sb.Append("pollen_tree_hickory")
                    Case 26
                        sb.Append("pollen_tree_maple")
                    Case 27
                        sb.Append("pollen_tree_willow")
                    Case 28
                        sb.Append("pollen_tree_ash")
                    Case 29
                        sb.Append("pollen_tree_cedar")
                    Case 30
                        sb.Append("pollen_tree_elm")
                    Case 31
                        sb.Append("pollen_tree_juniper")
                    Case 32
                        sb.Append("pollen_tree_mulberry")
                    Case 33
                        sb.Append("pollen_weed_ragweed")
                    Case 34
                        sb.Append("pollen_tree_beech")
                    Case 35
                        sb.Append("pollen_tree_cypress")
                    Case 36
                        sb.Append("pollen_tree_hemlock")
                    Case 37
                        sb.Append("pollen_tree_mahogany")
                    Case 38
                        sb.Append("pollen_tree_oak")
                    Case 39
                        sb.Append("pollen_grass_grass")
                    Case 40
                        sb.Append("pollen_tree_pine")
                    Case 41
                        sb.Append("pollen_tree_cottonwood")
                    Case 42
                        sb.Append("pollen_tree_spruce")
                    Case 43
                        sb.Append("pollen_tree_sycamore")
                    Case 44
                        sb.Append("pollen_tree_walnut")
                    Case 45
                        sb.Append("pm10")
                    Case 46
                        sb.Append("pm25")
                    Case 47
                        sb.Append("o3")
                    Case 48
                        sb.Append("co")
                    Case 49
                        sb.Append("so2")
                    Case 50
                        sb.Append("no2")
                    Case 51
                        sb.Append("epa_aqi")
                    Case 52
                        sb.Append("epa_health_concern")
                    Case 53
                        sb.Append("epa_primary_pollutant")
                    Case 54
                        sb.Append("china_aqi")
                    Case 55
                        sb.Append("china_health_concern")
                    Case 56
                        sb.Append("china_primary_pollutant")
                    Case 57
                        sb.Append("")   'road_risk
                    Case 58
                        sb.Append("road_risk_score")
                    Case 59
                        sb.Append("road_risk_confidence")
                    Case 60
                        sb.Append("road_risk_conditions")
                    Case Else
                        sb.Append("")
                End Select
                If Right(sb.ToString, 3) <> "%2C" Then
                    sb.Append("%2C")
                End If
            End If
            Application.DoEvents()
        Next
        Dim aa = sb.ToString
        Return Left(aa, aa.Length - 3)
    End Function

    Private Async Sub ParseNowcastData(fn As String, fa As Double)
        Try
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                Using cTxt As StreamWriter = File.AppendText(ncDataFile)
                    Await cTxt.WriteLineAsync($"{Separator}{vbLf}").ConfigureAwait(True)
                    Await cTxt.WriteLineAsync($"Parsed ClimaCell Nowcast Forecast Data @ {Now:T}{vbLf}{resp}{vbLf}{vbLf}").ConfigureAwait(True)
                End Using
                ncNfo = JsonSerializer.Deserialize(Of HourNum())(resp)
                PrintLog($"[Parsed] Nowcast Forecast Data @ {Now:T}{vbLf}File age: {fa:N2} minutes{vbLf}{vbLf}")
            End Using
            WriteDgvNowcast()
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
        Finally
            SaveLogs()
        End Try
    End Sub
    Private Sub WriteDgvNowcast()

        Dim bgClr As Color = Color.LightSkyBlue
        Try
            With FrmMain.DgvNowcast
                .Rows.Clear()
                For j = 0 To ncNfo.Length - 1
                    .Rows.Add()
                    Dim icn As String = Path.Combine(IconDir, "PNG", "Color", $"{ncNfo(j).WxCode.Value}.png")
                    PrintLog($"{j}. Nc: {icn}{vbLf}")
                    Using bmp1 As New Bitmap(icn)
                        Using bmp2 As New Bitmap(Path.Combine(IconDir, "PNG", "Color", $"na.png"))
                            .Rows(j).Cells(2).Value = If(File.Exists(icn), Transparent2Color(bmp1, bgClr), Transparent2Color(bmp2, bgClr))
                        End Using
                    End Using
                    .Rows(j).Cells(2).Style.BackColor = bgClr
                    .Rows(j).Cells(0).Value = $"{CDate(ncNfo(j).ObservationTime.Value):MMM d}"
                    .Rows(j).Cells(1).Value = $"{CDate(ncNfo(j).ObservationTime.Value):h:mm tt}"
                    Dim sb As New StringBuilder()
                    sb.Append($"Date/Time: {CDate(ncNfo(j).ObservationTime.Value):MMM d  h:mm tt}{vbLf}")
                    sb.Append($"Temp: {ncNfo(j).Temp.Value:N1}°{ncNfo(j).Temp.Units}{vbLf}Feels Like: {ncNfo(j).FeelsLike.Value}°{ncNfo(j).FeelsLike.Units}{vbLf}")
                    sb.Append($"Dewpoint: {ncNfo(j).Dewpoint.Value:N1}°{ncNfo(j).Dewpoint.Units}{vbLf}")
                    sb.Append($"Wind {Deg2Compass(CDbl(ncNfo(j).WindDir.Value))} @ {Math.Ceiling(CDec(ncNfo(j).WindSpeed.Value))} mph, gusting to {Math.Round(CDbl(ncNfo(j).WindGust.Value)):N0} {ncNfo(j).WindGust.Units}{vbLf}")
                    sb.Append($"AQI: {Math.Ceiling(CDbl(ncNfo(j).EpaAqi.Value))}{vbLf}")
                    sb.Append($"Primary Pollutant: {ncNfo(j).EpaPrimaryPollutant.Value}{vbLf}")
                    Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
                    sb.Append($"Forecast: {myTI.ToTitleCase(ncNfo(j).WxCode.Value.Replace("_", " "))}{vbLf}")
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
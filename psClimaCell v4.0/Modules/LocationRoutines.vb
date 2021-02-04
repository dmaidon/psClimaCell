Imports System.IO
Imports System.Net
Imports System.Text.Json

Friend Module LocationRoutines

    Private locNfo As CcLocationModel

    Friend Async Sub CreateNewPointLocation()
        Try
            Dim request = CType(WebRequest.Create(New Uri($"https://data.climacell.co/v4/locations?apikey={My.Settings.ApiKey}")), HttpWebRequest)
            With request
                .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
                .Timeout = 120000
                .ContentType = "application/json"
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .UserAgent = Use_Agent
                .Headers.Add("name", $"{FrmMainv4.TxtLocationName.Text}")
                .Headers.Add("geometry", $"{FrmMainv4.TxtPointLat.Text},{FrmMainv4.TxtPointLong.Text}")
            End With
            Using response = CType(Await request.GetResponseAsync().ConfigureAwait(True), HttpWebResponse)
                If My.Settings.Log_Headers Then
                    PrintLog($"{vbLf}{vbLf}ClimaCell Create Location Headers:{vbLf}{vbLf}")
                    For j = 0 To response.Headers.Count - 1
                        PrintLog($"   {response.Headers.Keys(j)}: {response.Headers.Item(j)}{vbLf}")
                    Next
                End If
                Dim dStr = response.GetResponseStream()
                Using reader = New StreamReader(dStr)
                    Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)   'ddd
                    'MsgBox(resp)
                    locNfo = JsonSerializer.Deserialize(Of CcLocationModel)(resp)
                    Dim fn = Path.Combine(LocationDir, $"{locNfo.LocData.Locations(0).Id}.json")
                    PrintLog($"Writing location file to disk: {fn}.{vbLf}")
                    File.WriteAllText(fn, resp)
                    'MsgBox(locNfo.LocData.Locations.Item(0).Id)
                End Using
            End Using
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            SaveLogs()
        End Try
    End Sub

    Friend Async Sub ParseLocationData()
        Try
            Dim fn = Path.Combine(LocationDir, "location_2221-455.json")
            If File.Exists(fn) Then
                Using reader = New StreamReader(fn)
                    Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                    locNfo = JsonSerializer.Deserialize(Of CcLocationModel)(resp)
                End Using
                'MsgBox(locNfo.LocData.Locations(0).Id)
            End If
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
    End Sub



End Module
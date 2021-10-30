Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Imports psTomorrowIO.Models

Friend Module WildfireRoutines

    Private wfNfo As FireApiData

    Friend Sub FetchWildfireData()
        Dim wfFile As String = Path.Combine(TempDir, $"wfData_{Now:Mddyy-HH}.geojson")
        'FrmMainv4.TpWildfire.Text = "Wildfires(0)"
        If IO.File.Exists(wfFile) Then
            Dim ab As Double = (Date2Unix(Now) - Date2Unix(IO.File.GetLastWriteTime(wfFile))) / 60
            If ab >= 30 Then
                DownloadWildfireData(wfFile)
            Else
                ParseWildfireData(wfFile)
            End If
        Else
            DownloadWildfireData(wfFile)
        End If
    End Sub

    Private Async Sub DownloadWildfireData(fn As String)
        Try
            Dim url As String = "https://opendata.arcgis.com/datasets/9838f79fb30941d2adde6710e9d6b0df_0.geojson"

            Using cl As New HttpClient
                cl.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))
                cl.DefaultRequestHeaders.Add("User-Agent", Use_Agent)

                Using resp As HttpResponseMessage = Await cl.GetAsync(New Uri(url))
                    If My.Settings.Log_Headers Then
                        Dim aHdr As String = Enumerable.Empty(Of (name As String, value As String))().Concat(resp.Headers.SelectMany(Function(kvp) kvp.Value.Select(Function(v) (name:=kvp.Key, value:=v)))).Concat(resp.Content.Headers.SelectMany(Function(kvp) kvp.Value.Select(Function(v) (name:=kvp.Key, value:=v)))).Aggregate(seed:=New StringBuilder(), func:=Function(sb, pair) sb.Append(pair.name).Append(": ").Append(pair.value).AppendLine(), resultSelector:=Function(sb) sb.ToString())

                        For j = 0 To aHdr.Length - 1
                            PrintLog($"{aHdr(j)}")
                        Next
                        PrintLog($"{vbLf}")
                    End If
                    resp.EnsureSuccessStatusCode()
                    Dim rb As String = Await resp.Content.ReadAsStringAsync()
                    IO.File.WriteAllText(fn, rb.ToString)
                    'PrintLog($"Wildfire Data @ {Now:T}.{vbLf}{rb}{vbLf}")
                    PrintLog($"Writing Wildfire data to disk --> {fn}.{vbLf}")
                    wfNfo = JsonSerializer.Deserialize(Of FireApiData)(rb)
                    'Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                    '    Await aTxt.WriteLineAsync($"{My.Resources.separator}{vbLf}").ConfigureAwait(False)
                    '    Await aTxt.WriteLineAsync($"Wildfires Data @ {Now:T}{vbLf}{rb}{vbLf}{vbLf}").ConfigureAwait(False)
                    'End Using

                    WriteWildfireData()
                End Using
            End Using
        Catch ex As Exception When TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is ArgumentOutOfRangeException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''
        End Try
    End Sub

    Private Async Sub ParseWildfireData(fn As String)
        Try
            PrintLog($"Parsing Wildfire data --> {fn}.{vbLf}")
            Using reader = New StreamReader(fn)
                Dim resp As String = Await reader.ReadToEndAsync().ConfigureAwait(True)
                wfNfo = JsonSerializer.Deserialize(Of FireApiData)(resp)
                WriteWildfireData()
            End Using
        Catch ex As Exception When TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is ArgumentOutOfRangeException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''
        End Try
    End Sub

    Private Sub WriteWildfireData()
        Try
            PrintLog($"Writing Wildfire data to tab.{vbLf}")
            Dim ta As Double
            Dim wfCnt As Integer = wfNfo.Features.Count
            With FrmMainv4.DgvWildfire
                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 4
                .Columns(0).Width = 50
                .Columns(1).Width = 175
                'FrmMainv4.TpWildfire.Text = $"Wildfires({wfNfo.Features.Count})"
                For j = 0 To wfCnt - 1
                    Dim wf = wfNfo.Features(j).Properties
                    .Rows.Add(j + 1, "Name", wf.IncidentName, "")

                    If wf.IncidentShortDescription IsNot vbNullString Then
                        .Rows.Add("", "Short Description", wf.IncidentShortDescription, "")
                    End If

                    .Rows.Add("", "Location", "County", wf.PooCounty)

                    If wf.PooCity IsNot vbNullString Then
                        .Rows.Add("", "", "City", wf.PooCity)
                    End If

                    .Rows.Add("", "", "State", wf.PooState.Replace("US-", ""))

                    If wf.InitialLatitude.HasValue Then
                        .Rows.Add("", "", "Latitude", wf.InitialLatitude.Value)
                    End If

                    If wf.InitialLongitude.HasValue Then
                        .Rows.Add("", "", "Longitude", wf.InitialLongitude.Value)
                    End If

                    If wf.FireCause IsNot vbNullString Then
                        If wf.FireCauseGeneral = "" Then
                            wf.FireCauseGeneral = " "
                        End If
                        .Rows.Add("", "Cause", wf.FireCause, wf.FireCauseGeneral)
                    End If

                    .Rows.Add("", "Discovered", wf.FireDiscoveryDateTime.ToLocalTime, "")

                    If wf.CalculatedAcres.HasValue Then
                        .Rows.Add("", "Calculated Acres", $"{wf.CalculatedAcres:N2}", "")
                        ta = CDbl(ta + wf.CalculatedAcres)
                    End If

                    If wf.PredominantFuelGroup IsNot vbNullString Then
                        .Rows.Add("", "Predominate Fuel Group", wf.PredominantFuelGroup, "")
                    End If

                    If wf.PredominantFuelModel IsNot vbNullString Then
                        .Rows.Add("", "Predominate Fuel Model", wf.PredominantFuelModel, "")
                    End If

                    If wf.PrimaryFuelModel IsNot vbNullString Then
                        .Rows.Add("", "Primary Fuel Model", wf.PrimaryFuelModel, "")
                    End If

                    If wf.SecondaryFuelModel IsNot vbNullString Then
                        .Rows.Add("", "Secondary Fuel Model", wf.SecondaryFuelModel, "")
                    End If

                    If wf.FireBehaviorGeneral IsNot vbNullString Then
                        .Rows.Add("", "Behavior", wf.FireBehaviorGeneral, "")
                    End If

                    If wf.FireBehaviorGeneral1 IsNot vbNullString Then
                        .Rows.Add("", "Behavior 1", wf.FireBehaviorGeneral2, "")
                    End If

                    If wf.FireBehaviorGeneral2 IsNot vbNullString Then
                        .Rows.Add("", "Behavior 2", wf.FireBehaviorGeneral2, "")
                    End If

                    If wf.FireBehaviorGeneral3 IsNot vbNullString Then
                        .Rows.Add("", "Behavior 3", wf.FireBehaviorGeneral3, "")
                    End If

                    If wf.PooLandownerKind IsNot vbNullString Then
                        .Rows.Add("", "Land Owner", wf.PooLandownerKind, "")
                    End If

                    If wf.PooProtectingAgency IsNot vbNullString Then
                        .Rows.Add("", "Protecting Agency", wf.PooProtectingAgency, "")
                    End If
                    Application.DoEvents()
                Next
                .Rows.Add()
                .Rows.Add("", "", "Total Burned Acres", $"{ta:N2}")
                FrmMainv4.LblWfData.Text = String.Format(CStr(FrmMainv4.LblWfData.Tag), wfCnt, $"{ta:N2}")
                PrintLog($"Total Wildfires: {wfCnt}{vbLf}Acres Burned: {ta:N2}{vbLf}")
                FrmMainv4.TpWildfire.Text = $"Wildfires ({wfCnt})"
                .ClearSelection()
            End With
        Catch ex As Exception When TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is ArgumentOutOfRangeException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''
        End Try
    End Sub
End Module

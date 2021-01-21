Imports System.IO
Imports System.Text.Json

Friend Module UnitRoutinesV4

    ''' <summary>
    ''' Parse the Selected Field Units data fil.  The "Imperial" and "Metric" data files are located in the Data directory.
    ''' The Field Unit data files are modified versions of those from ClimaCell.
    ''' </summary>
    Friend Sub ParseDataFieldUnits()
        Try
            Dim fn As String = Path.Combine(DataDir, $"{unitArr(My.Settings.Units)}_field_units.json")
            If File.Exists(fn) Then
                Using reader = New StreamReader(fn)
                    Dim resp As String = reader.ReadToEnd()        '.ConfigureAwait(True)
                    unitNfo = JsonSerializer.Deserialize(Of FieldUnitsModel)(resp)
                    PrintLog($"[Parsed] Data Field Units ->{fn}{vbLf}{vbLf}")
                End Using
            Else
                PrintLog($"Data Field Units file missing ->{fn}{vbLf}{vbLf}")
            End If
        Catch ex As ArgumentNullException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            SaveLogs()
        End Try

    End Sub
End Module

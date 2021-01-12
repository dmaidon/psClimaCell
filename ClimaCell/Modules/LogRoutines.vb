Imports System.IO
Imports System.Security
Imports System.Text

Friend Module LogRoutines

    Friend Sub PrintLog(m As String, Optional et As Boolean = False)
        'ResetError()
        With FrmMain
            If et Then
                'GotErr = True
                '_numErr += 1
                '.TsslError.ForeColor = Color.Red
                '.TsslError.ToolTipText = My.Resources.err_in_pgm
                '.TsslError.Text = $"{_numErr}"
                .RtbLog.SelectionColor = Color.Red
                .RtbLog.AppendText($"{ErrSeparator}{vbLf}{vbLf}")
                .RtbLog.SelectionColor = Color.Black
                .RtbLog.AppendText($"{m}")
                .RtbLog.SelectionColor = Color.Red
                .RtbLog.AppendText($"{vbLf}{Separator }{vbLf}{vbLf}")
                .RtbLog.SelectionColor = Color.Black
                .RtbError.SelectionColor = Color.Red
                .RtbError.AppendText($"{ErrSeparator}{vbLf}{vbLf}")
                .RtbError.SelectionColor = Color.Black
                .RtbError.AppendText($"{m}")
                .RtbError.SelectionColor = Color.Red
                .RtbError.AppendText($"{vbLf}{Separator }{vbLf}{vbLf}")
            Else
                .RtbLog.AppendText($"{m}")
            End If
        End With
    End Sub

    'Friend Sub PrintData(t As String, m As String)
    '    FrmMain.RtbData.AppendText($"{Separator}{vbLf}{t}{vbLf}{m}{vbLf}{Separator}{vbLf}")
    'End Sub

    Friend Sub PrintErr(msg As String, trg As String, stk As String, src As String, Optional gbe As String = "- Empty -")
        'ResetError()
        'GotErr = True
        '_numErr += 1
        Dim em As String =
                $"   Error:{vbLf}{msg}{vbLf}{vbLf}   Location:{vbLf}{trg}{vbLf}{vbLf}   Trace:{vbLf}{stk}{vbLf}{vbLf}   Source:{vbLf}{src}{vbLf}{vbLf}   Base Exception:{ _
                vbLf}{gbe}{vbLf}"
        With FrmMain
            '.TsslError.ForeColor = Color.Red
            '.TsslError.ToolTipText = My.Resources.err_in_pgm
            '.TsslError.Text = $"{_numErr}"
            .RtbLog.SelectionColor = Color.Red
            .RtbLog.AppendText($"{vbLf}{ErrSeparator}{vbLf}Time: {Now:T}{vbLf}")
            .RtbLog.SelectionColor = Color.Black
            .RtbLog.AppendText(em)
            .RtbLog.SelectionColor = Color.Red
            .RtbLog.AppendText($"{Separator}{vbLf}{vbLf}")
            .RtbLog.SelectionColor = Color.Black

            ''write same information to error log
            .RtbError.SelectionColor = Color.Red
            .RtbError.AppendText($"{vbLf}{ErrSeparator}{vbLf}Time: {Now:T}{vbLf}")
            .RtbError.SelectionColor = Color.Black
            .RtbError.AppendText(em)
            .RtbError.SelectionColor = Color.Red
            .RtbError.AppendText($"{Separator}{vbLf}{vbLf}")
        End With

        SaveLogs()
    End Sub

    Public Sub SaveLogs()
        Try
            PrintLog($"¥{vbLf}")
            With FrmMain
                .RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
                '.RtbData.SaveFile(DataFile, RichTextBoxStreamType.PlainText)
                .RtbError.SaveFile(ErrFile, RichTextBoxStreamType.PlainText)
            End With
        Catch ex As IOException
            Return
        Finally
            'a
        End Try
    End Sub

    Public Sub StartLogfile()
        Try
            Timesrun = My.Settings.TimesRun + 1
            My.Settings.TimesRun = Timesrun
            My.Settings.Save()
            LogFile = Path.Combine(LogDir, $"ccell{Now:Mdyyyy}_{Timesrun}.log")
            DataFile = Path.Combine(LogDir, $"data{Now:Mdyyyy}_{Timesrun}.log")
            ErrFile = Path.Combine(LogDir, $"err{Now:Mdyyyy}_{Timesrun}.log")

            PrintLog(GetLogHeader())
            PrintErrLog(GetLogHeader())
            'Using aTxt As StreamWriter = File.CreateText(DataFile)
            '    aTxt.WriteLine(GetLogHeader())
            'End Using
        Catch ex As Exception When _
              TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
    End Sub

    Private Function GetLogHeader() As String
        Try
            Dim sb = New StringBuilder($"Log file started: {Now:F}{vbLf}")
            sb.Append($"Program: {Application.ProductName} v{Application.ProductVersion}{vbLf}")
            sb.Append($"Log file: {LogFile}{vbLf}")
            sb.Append($"Data file: {DataFile}{vbLf}")
            sb.Append($"Error file: {ErrFile}{vbLf}")
            sb.Append($"Times run: {Timesrun}{vbLf}")
            sb.Append($"Controls: {NumControls(FrmMain)}{vbLf}")
            sb.Append($"Daily Update interval: {My.Settings.UpdateInterval_Daily} minutes{vbLf}")
            sb.Append($"Hourly Update interval: {My.Settings.UpdateInterval_Hourly} minutes{vbLf}")
            sb.Append($"Nowcast Update interval: {My.Settings.UpdateInterval_Nowcast} minutes{vbLf}")
            'sb.Append($"Location-> Latitude: {CLatitude}     Longitude: {CLongitude}{vbLf}")
            sb.Append($"OS Version: {Environment.OSVersion}{vbLf}")
            sb.Append($"Machine Name: {Environment.MachineName}{vbLf}")

            Return sb.ToString()
        Catch ex As Exception When _
                  TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
        Return $"- Invalid Log Header -{vbLf}"
    End Function

    Private Function NumControls(parent As Control) As Integer
        Return parent.Controls.Count + parent.Controls.Cast(Of Control)().Sum(Function(ctrl) NumControls(ctrl))
    End Function

    Friend Sub PrintErrLog(m As String)
        FrmMain.RtbError.AppendText($"{Now:T}{vbLf}{m}{vbLf}")
    End Sub

    Public Sub PerformLogMaintenance()
        Try
            With FrmMain
                PrintLog($"<{Separator}{vbLf}")

                Dim intDays As Double = 3
                If intDays <= 0 Then
                    PrintLog($"Logs set to keep all.{vbLf}")
                    Return
                End If

                Dim fc As Integer

                Try
                    For Each file In From file1 In New DirectoryInfo(LogDir).GetFiles() Where (Now - file1.LastWriteTime).Days >= intDays
                        fc += 1
                        file.Delete()
                        PrintLog($">> Deleted: {file.FullName}.  Date: {file.CreationTime}{vbLf}")
                    Next

                    For Each file In From file1 In New DirectoryInfo(TempDir).GetFiles() Where (Now - file1.LastWriteTime).Days >= intDays
                        fc += 1
                        file.Delete()
                        PrintLog($">> Deleted: {file.FullName}.  Date: {file.CreationTime}{vbLf}")
                    Next

                    For Each file In From file1 In New DirectoryInfo(DataDir).GetFiles("*.*", SearchOption.AllDirectories) Where (Now - file1.LastWriteTime).Days >= intDays
                        fc += 1
                        file.Delete()
                        PrintLog($">> Deleted: {file.FullName}.  Date: {file.CreationTime}{vbLf}")
                    Next

                Catch ex As Exception When _
                    TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
                    PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
                Finally
                    ''trap error
                End Try

                PrintLog($"Log Maintenance performed.{vbLf}Files over {intDays} days old deleted.{vbLf}{fc} files deleted.{vbLf}{Separator}>{vbLf}")

            End With
        Catch ex As Exception When _
              TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
        SaveLogs()
    End Sub


End Module
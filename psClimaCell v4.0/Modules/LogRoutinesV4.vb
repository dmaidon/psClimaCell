Imports System.IO
Imports System.Security
Imports System.Text

Friend Module LogRoutinesV4
    Private _numErr As Integer

    Friend Async Sub Check4NewLogFile()
        Dim si = LogFile.Substring _
                (LogFile.LastIndexOf("-", StringComparison.Ordinal) + 1, (LogFile.LastIndexOf("_", StringComparison.Ordinal) - LogFile.LastIndexOf("-", StringComparison.Ordinal) - 1))

        With FrmMainv4
            If si <> $"{Now:Mdyyyy}" Then
                Try
                    ''close old log file
                    PrintLog($"{vbLf}{My.Resources.separator}>{vbLf}Errors this run: { .TsslErr.Text}{vbLf}{My.Resources.separator}>{vbLf}Closing log: {Now:T}{vbLf}", False)
                    PrintErrLog($"{vbLf}{My.Resources.separator}>{vbLf}Errors this run: { .TsslErr.Text}{vbLf}{My.Resources.separator}>{vbLf}Closing log: {Now:T}{vbLf}")
                    Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                        Await aTxt.WriteLineAsync($"{vbLf}{My.Resources.separator}>{vbLf}Closing log: {Now:T}{vbLf}")
                    End Using

                    ''save old log file
                    .RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
                    .RtbError.SaveFile(ErrFile, RichTextBoxStreamType.PlainText)
                    FrmMainv4.CollectMemoryGarbage(True)
                Catch ex As IOException
                    PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
                Finally
                    'a
                End Try
                'PrintLog($"-{vbLf}")
                StartNewLogFile()
            Else
                PrintLog($"Check for new log -> File date: {si}  Current Date: { Replace($"{Now:d}", "/", String.Empty)}{vbLf}")
            End If
        End With
    End Sub

    Friend Sub PerformLogMaintenance()
        Try
            With FrmMainv4
                PrintLog($"<{My.Resources.separator}{vbLf}")

                Dim intDays As Integer = My.Settings.Log_KeepDays
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

                    'For Each file In From file1 In New DirectoryInfo(DataDir).GetFiles("*.*", SearchOption.AllDirectories) Where (Now - file1.LastWriteTime).Days >= intDays
                    '    fc += 1
                    '    file.Delete()
                    '    PrintLog($">> Deleted: {file.FullName}.  Date: {file.CreationTime}{vbLf}")
                    'Next
                Catch ex As Exception When _
                    TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
                    PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
                Finally
                    ''trap error
                End Try

                PrintLog($"Log Maintenance performed.{vbLf}Files over {intDays} days old deleted.{vbLf}{fc} files deleted.{vbLf}{My.Resources.separator}>{vbLf}")

            End With
        Catch ex As Exception When _
              TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
        SaveLogs()
    End Sub

    Friend Sub PrintErr(msg As String, trg As String, stk As String, src As String, gbe As String, Optional ie As String = "- N/A -")
        ResetError()
        GotErr = True
        _numErr += 1
        Dim em As String =
                $"   Error:{vbLf}{msg}{vbLf}{vbLf}   Location:{vbLf}{trg}{vbLf}{vbLf}   Trace:{vbLf}{stk}{vbLf}{vbLf}   Source:{vbLf}{src}{vbLf}{vbLf}   Base Exception:{ _
                vbLf}{gbe}{vbLf}Inner Exception:{vbLf}{ie}{vbLf} "
        With FrmMainv4
            .TsslErr.ForeColor = Color.Red
            .TsslErr.ToolTipText = My.Resources.err_in_pgm
            .TsslErr.Text = $"{_numErr}"
            .RtbLog.SelectionColor = Color.Red
            .RtbLog.AppendText($"{vbLf}{My.Resources.separator}{vbLf}Time: {Now:T}{vbLf}")
            .RtbLog.SelectionColor = Color.Black
            .RtbLog.AppendText(em)
            .RtbLog.SelectionColor = Color.Red
            .RtbLog.AppendText($"{My.Resources.separator}{vbLf}{vbLf}")
            .RtbLog.SelectionColor = Color.Black

            ''write same information to error log
            .RtbError.SelectionColor = Color.Red
            .RtbError.AppendText($"{vbLf}{My.Resources.err_separator}{vbLf}Time: {Now:T}{vbLf}")
            .RtbError.SelectionColor = Color.Black
            .RtbError.AppendText(em)
            .RtbError.SelectionColor = Color.Red
            .RtbError.AppendText($"{My.Resources.err_separator}{vbLf}{vbLf}")
        End With

        SaveLogs()
    End Sub

    Friend Sub PrintErrLog(m As String)
        FrmMainv4.RtbError.AppendText($"{Now:T}{vbLf}{m}{vbLf}")
    End Sub

    Friend Sub PrintLog(m As String, Optional et As Boolean = False)
        ResetError()
        With FrmMainv4
            If et Then
                GotErr = True
                _numErr += 1
                .TsslErr.ForeColor = Color.Red
                .TsslErr.ToolTipText = My.Resources.err_in_pgm
                .TsslErr.Text = $"{_numErr}"
                .RtbLog.SelectionColor = Color.Red
                .RtbLog.AppendText($"{My.Resources.err_separator}{vbLf}{vbLf}")
                .RtbLog.SelectionColor = Color.Black
                .RtbLog.AppendText($"{m}")
                .RtbLog.SelectionColor = Color.Red
                .RtbLog.AppendText($"{vbLf}{My.Resources.err_separator }{vbLf}{vbLf}")
                .RtbLog.SelectionColor = Color.Black
                .RtbError.SelectionColor = Color.Red
                .RtbError.AppendText($"{My.Resources.err_separator}{vbLf}{vbLf}")
                .RtbError.SelectionColor = Color.Black
                .RtbError.AppendText($"{m}")
                .RtbError.SelectionColor = Color.Red
                .RtbError.AppendText($"{vbLf}{My.Resources.err_separator }{vbLf}{vbLf}")
            Else
                .RtbLog.AppendText($"{m}")
            End If
        End With
    End Sub

    Friend Sub SaveLogs()
        Try
            PrintLog($"¥{vbLf}")
            With FrmMainv4
                .RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
                .RtbError.SaveFile(ErrFile, RichTextBoxStreamType.PlainText)
            End With
        Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is ArgumentException
            Return
        Finally
            'a
        End Try
    End Sub

    Friend Async Sub StartLogfile()
        Try
            Timesrun = My.Settings.TimesRun
            LogFile = Path.Combine(LogDir, $"ccell-{Now:Mdyyyy}_{Timesrun}.log")
            TlDataFile = Path.Combine(LogDir, $"tlData-{Now:Mdyyyy}_{Timesrun}.log")
            ErrFile = Path.Combine(LogDir, $"err-{Now:Mdyyyy}_{Timesrun}.log")
            PrintLog(GetLogHeader())
            PrintErrLog(GetLogHeader())
            Using aTxt As StreamWriter = File.AppendText(TlDataFile)
                Await aTxt.WriteAsync(GetLogHeader)
            End Using
        Catch ex As Exception When _
              TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
    End Sub

    Private Function GetLogHeader() As String
        Dim sb = New StringBuilder($"Log file started: {Now:F}{vbLf}", 128)
        sb.Append($"Program: {Application.ProductName} v{Application.ProductVersion}{vbLf}")
        sb.Append($"Application Startup Time: {AppStartTime:F}{vbLf}")
        sb.Append($"Log file: {LogFile}{vbLf}")
        sb.Append($"Error file: {ErrFile}{vbLf}")
        sb.Append($"Data file: {TlDataFile}{vbLf}")
        sb.Append($"Times run: {Timesrun}{vbLf}")
        sb.Append($"Controls: {NumControls(FrmMainv4)}{vbLf}")
        sb.Append($"Daily Update interval: {My.Settings.UpdateInt_Timelines} minutes{vbLf}")
        sb.Append($"OS Version: {Environment.OSVersion}{vbLf}")
        sb.Append($"Machine Name: {Environment.MachineName}{vbLf}")
        Return sb.ToString
    End Function

    Private Function NumControls(parent As Control) As Integer
        Return parent.Controls.Count + parent.Controls.Cast(Of Control)().Sum(Function(ctrl) NumControls(ctrl))
    End Function

    Private Sub ResetError()
        If ResetErr Then
            _numErr = 0
            ResetErr = False
        End If
    End Sub

    Private Sub StartNewLogFile()
        Try
            With FrmMainv4
                FrmMainv4.CollectMemoryGarbage(False)
                .RtbLog.SelectAll()
                .RtbLog.Clear()
                .RtbLog.Text = vbNullString
                .RtbError.SelectAll()
                .RtbError.Clear()
                .RtbError.Text = vbNullString
                GotErr = False
                ResetErr = True
                .TsslErr.ForeColor = Color.ForestGreen
                .TsslErr.ToolTipText = My.Resources.err_in_pgm
                .TsslErr.Text = $"!"
                LogFile = Path.Combine(LogDir, $"ccell-{Now:Mdyyyy}_{Timesrun}.log")
                ErrFile = Path.Combine(LogDir, $"err-{Now:Mdyyyy}_{Timesrun}.log")
                TlDataFile = Path.Combine(LogDir, $"tlData-{Now:Mdyyyy}_{Timesrun}.log")
                PrintLog(GetLogHeader())
                PrintErrLog(GetLogHeader())
                FrmMainv4.CollectMemoryGarbage(True)
                PerformLogMaintenance()
            End With
        Catch ex As ArgumentNullException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            SaveLogs()
        End Try
    End Sub

End Module
Imports System.IO
Imports System.Security
Imports System.Text

Friend Module LogRoutinesV4

    Friend Sub Check4NewLogFile()
        Dim si = LogFile.Substring _
                (LogFile.LastIndexOf("-", StringComparison.Ordinal) + 1, (LogFile.LastIndexOf("_", StringComparison.Ordinal) - LogFile.LastIndexOf("-", StringComparison.Ordinal) - 1))

        With FrmMainv4
            If si <> $"{Now:Mdyyyy}" Then
                Try
                    ''close old log file
                    PrintLog($"{vbLf}{My.Resources.separator}>{vbLf}Closing log: {Now:T}{vbLf}", False)
                    PrintErrLog($"{vbLf}{My.Resources.separator}>{vbLf}Closing log: {Now:T}{vbLf}")

                    ''save old log file
                    .RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
                    .RtbError.SaveFile(ErrFile, RichTextBoxStreamType.PlainText)
                Catch ex As IOException
                    PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
                Finally
                    'a
                End Try
                PrintLog($"-{vbLf}")
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

    Friend Sub PrintErr(msg As String, trg As String, stk As String, src As String, Optional gbe As String = "- Empty -")
        'ResetError()
        'GotErr = True
        '_numErr += 1
        Dim em As String =
                $"   Error:{vbLf}{msg}{vbLf}{vbLf}   Location:{vbLf}{trg}{vbLf}{vbLf}   Trace:{vbLf}{stk}{vbLf}{vbLf}   Source:{vbLf}{src}{vbLf}{vbLf}   Base Exception:{ _
                vbLf}{gbe}{vbLf}"
        With FrmMainv4
            '.TsslError.ForeColor = Color.Red
            '.TsslError.ToolTipText = My.Resources.err_in_pgm
            '.TsslError.Text = $"{_numErr}"
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
        'ResetError()
        With FrmMainv4
            If et Then
                'GotErr = True
                '_numErr += 1
                '.TsslError.ForeColor = Color.Red
                '.TsslError.ToolTipText = My.Resources.err_in_pgm
                '.TsslError.Text = $"{_numErr}"
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
            PrintLog($"¥{vbLf}")
            With FrmMainv4
                .RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
                .RtbError.SaveFile(ErrFile, RichTextBoxStreamType.PlainText)
            End With
        Catch ex As IOException
            Return
        Finally
            'a
        End Try
    End Sub

    Friend Sub StartLogfile()
        Try
            Timesrun = My.Settings.TimesRun + 1
            My.Settings.TimesRun = Timesrun
            My.Settings.Save()
            LogFile = Path.Combine(LogDir, $"ccell-{Now:Mdyyyy}_{Timesrun}.log")
            tlDataFile = Path.Combine(LogDir, $"tlData-{Now:Mdyyyy}_{Timesrun}.log")
            ErrFile = Path.Combine(LogDir, $"err-{Now:Mdyyyy}_{Timesrun}.log")
            PrintLog(GetLogHeader())
            PrintErrLog(GetLogHeader())
        Catch ex As Exception When _
              TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is SecurityException OrElse TypeOf ex Is DirectoryNotFoundException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''trap error
        End Try
    End Sub

    'Friend Sub PrintData(t As String, m As String)
    '    FrmMain.RtbData.AppendText($"{my.resources.separator}{vbLf}{t}{vbLf}{m}{vbLf}{my.resources.separator}{vbLf}")
    'End Sub
    Private Function GetLogHeader() As String
        Try
            Dim sb = New StringBuilder($"Log file started: {Now:F}{vbLf}")
            sb.Append($"Program: {Application.ProductName} v{Application.ProductVersion}{vbLf}")
            sb.Append($"Log file: {LogFile}{vbLf}")
            sb.Append($"Error file: {ErrFile}{vbLf}")
            sb.Append($"Times run: {Timesrun}{vbLf}")
            sb.Append($"Controls: {NumControls(FrmMainv4)}{vbLf}")
            sb.Append($"Daily Update interval: {My.Settings.UpdateInt_Timelines} minutes{vbLf}")
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

    Private Sub StartNewLogFile()
        Try
            With FrmMainv4
                .RtbError.Clear()
                .RtbLog.Clear()
                LogFile = Path.Combine(LogDir, $"ccell-{Now:Mdyyyy}_{Timesrun}.log")
                ErrFile = Path.Combine(LogDir, $"err-{Now:Mdyyyy}_{Timesrun}.log")
                PrintLog(GetLogHeader())
                PrintErrLog(GetLogHeader())
                PerformLogMaintenance()
            End With
        Catch ex As ArgumentNullException
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            'a
        End Try
    End Sub

End Module
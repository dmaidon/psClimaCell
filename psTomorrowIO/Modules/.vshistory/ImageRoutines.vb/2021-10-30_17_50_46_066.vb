Imports System.Drawing.Imaging
Imports System.IO

Friend Module ImageRoutines
    Private fMax As Boolean
    Friend Sub SaveForecastImages(ctl As Control, fn As String, str As String, sDir As String)
        ''https://www.aspsnippets.com/Articles/Convert-Export-DataGridView-to-Bitmap-PNG-Image-in-Windows-Forms-WinForms-Application-using-C-and-VBNet.aspx
        fMax = False

        ' MsgBox(FrmMainv4.WindowState)
        'If FrmMainv4.WindowState = vbMinimizedFocus Then
        '    MsgBox()
        'End If

        If CBool(FormWindowState.Minimized) Then
            FrmMainv4.WindowState = FormWindowState.Normal
            fMax = True
        End If

        Dim ax As String = Path.Combine(sDir, fn)
        PrintLog($"{vbLf}{My.Resources.separator}{vbLf}Saving {str} image: {ax}{vbLf}")

        Try
            If File.Exists(ax) Then
                File.Delete(ax)
                PrintLog($"{vbLf}Deleted {str} Image: {ax}{vbLf}")
            End If
            'Create a Bitmap and draw the control on it.
            PrintLog($"{vbLf}{ctl}: Width: {ctl.Width}     Height: {ctl.Height}{vbLf}")
            Using bmp = New Bitmap(ctl.Width, ctl.Height)
                ctl.DrawToBitmap(bmp, New Rectangle(0, 0, ctl.Width, ctl.Height))
                bmp.Save(ax, ImageFormat.Png)
                PrintLog($"{vbLf}Saved {str} Image: {ax}{vbLf}{vbLf}{My.Resources.separator}{vbLf}")
            End Using

            If fMax Then
                fMax = False
                FrmMainv4.WindowState = FormWindowState.Minimized
            End If
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
            'PrintLog($"Inner Exception: {ex.InnerException}{vbLf}")
            If ex.Data.Count > 0 Then
                For Each de As DictionaryEntry In ex.Data
                    PrintLog($"    Key: {de.Key}      Value: {de.Value}{vbLf}")
                Next
            End If
            'PrintLog($"Data: {ex.Data}{vbLf}")
            '1/1/20
            Return
        Finally
            SaveLogs()
        End Try
    End Sub

End Module
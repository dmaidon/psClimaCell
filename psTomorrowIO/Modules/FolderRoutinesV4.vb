Imports System.IO

Friend Module FolderRoutinesV4

    Friend Sub CreateProgramFolders()
        Dim fName As New List(Of String)({LogDir, TempDir, DataDir, IconDir, LocationDir, ImageDir})

        For j = 0 To fName.Count - 1
            Try
                If Not Directory.Exists(fName(j)) Then
                    Directory.CreateDirectory(fName(j))
                    PrintLog($"{fName(j)} ==> created.{vbLf}")
                Else
                    PrintLog($"{fName(j)} --> exists.{vbLf}")
                End If
            Catch ex As Exception
                PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Finally
                'a
            End Try
        Next
    End Sub

End Module

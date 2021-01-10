Imports System.IO

Module Globals

    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")
    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")
    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")
    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")

    Public LogFile, DataFile, ErrFile As String
    Public Cpy As String = $"©2020-{Now:yyyy} PAROLE Software - All rights reserved."

    Public uArr As New List(Of String)({"us", "si"})

    Public Timesrun As Long

    Public tSpan As Integer

    Public Use_Agent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36 Edg/85.0.564.44"

    Public Duration As TimeSpan
    Public NextUp As DateTime

    Public Separator As String = "------------------------------------------------------------------------------"
    Public ErrSeparator As String = "-------------------------------- Error ----------------------------------------"
End Module

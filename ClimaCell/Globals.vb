Imports System.IO

Module Globals

    'Folder declarations
    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")
    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")
    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")
    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")

    Public LogFile, DataFile, ErrFile As String


    Public Cpy As String = $"©2020-{Now:yyyy} PAROLE Software - All rights reserved."

    Public uArr As New List(Of String)({"us", "si"})

    'number of times that program has been run
    Public Timesrun As Long

    Public Use_Agent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36 Edg/85.0.564.44"

    'Daily update interval
    Public DlyDuration As TimeSpan

    Public DlyNextUp As DateTime

    'Hourly update interval
    Public HrDuration As TimeSpan

    Public HrNextUp As DateTime

    'Nowcast update interval
    Public NcDuration As TimeSpan

    Public NcNextUp As DateTime

    Public Separator As String = "------------------------------------------------------------------------------"
    Public ErrSeparator As String = "-------------------------------- Error ----------------------------------------"

    'dim timer lists
    Public TmrArr As New List(Of Timers.Timer)({FrmMain.TmrUpdateDaily, FrmMain.TmrUpdateHourly, FrmMain.TmrUpdateNowcast})
    Public TmrInt As New List(Of Integer)({My.Settings.UpdateInterval_Daily, My.Settings.UpdateInterval_Hourly, My.Settings.UpdateInterval_Nowcast})

End Module
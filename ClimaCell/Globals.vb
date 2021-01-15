Imports System.IO

Module Globals

    'Folder declarations
    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")

    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")
    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")
    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")

    Public LogFile, dlyDataFile, hrDataFile, ncDataFile, rtDataFile, ErrFile As String

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

    'Realtime update interval
    Public RtDuration As TimeSpan

    Public RtNextUp As DateTime

    'Midnight update
    Public MidDuration As TimeSpan

    Public MidNextUpdate As DateTime

    Public Separator As String = "------------------------------------------------------------------------------"
    Public ErrSeparator As String = "-------------------------------- Error ----------------------------------------"

    'dim timer lists
    Public TmrArr As New List(Of Timers.Timer)({FrmMain.TmrUpdateDaily, FrmMain.TmrUpdateHourly, FrmMain.TmrUpdateNowcast, FrmMain.TmrUpdateRt})

    Public TmrInt As New List(Of Integer)({My.Settings.UpdateInterval_Daily, My.Settings.UpdateInterval_Hourly, My.Settings.UpdateInterval_Nowcast, My.Settings.UpdateInterval_Realtime})

    'Public RtCoreArr As New List(Of CheckBox)({FrmMain.ChkRtCore0, FrmMain.ChkRtCore1, FrmMain.ChkRtCore2, FrmMain.ChkRtCore3, FrmMain.ChkRtCore4, FrmMain.ChkRtCore5, FrmMain.ChkRtCore6, FrmMain.ChkRtCore7, FrmMain.ChkRtCore8, FrmMain.ChkRtCore9, FrmMain.ChkRtCore10, FrmMain.ChkRtCore11, FrmMain.ChkRtCore12, FrmMain.ChkRtCore13, FrmMain.ChkRtCore14, FrmMain.ChkRtCore15, FrmMain.ChkRtCore16, FrmMain.ChkRtCore17, FrmMain.ChkRtCore18, FrmMain.ChkRtCore19, FrmMain.ChkRtCore20})

    'Public RtCoreSetArr As New List(Of Boolean)({My.Settings.Rt_Core0, My.Settings.Rt_Core1, My.Settings.Rt_Core2, My.Settings.Rt_Core3, My.Settings.Rt_Core4, My.Settings.Rt_Core5, My.Settings.Rt_Core6, My.Settings.Rt_Core7, My.Settings.Rt_Core8, My.Settings.Rt_Core9, My.Settings.Rt_Core10, My.Settings.Rt_Core11, My.Settings.Rt_Core12, My.Settings.Rt_Core13, My.Settings.Rt_Core14, My.Settings.Rt_Core15, My.Settings.Rt_Core16, My.Settings.Rt_Core17, My.Settings.Rt_Core18, My.Settings.Rt_Core19, My.Settings.Rt_Core20})

End Module
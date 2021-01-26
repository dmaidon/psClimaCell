Imports System.IO

Friend Module GlobalsV4

    'Folder declarations
    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")
    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")
    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")
    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")

    Public LogFile, TlDataFile, ErrFile As String

    Public Cpy As String = $"©2020-{Now:yyyy} PAROLE Software - All rights reserved."

    Public unitArr As New List(Of String)({"imperial", "metric"})

    Public unitNfo As FieldUnitsModel

    'Timelines update interval
    Public TlDuration As TimeSpan

    Public TlNextUpdate As DateTime


    'Midnight interval
    Public MidDuration As TimeSpan

    Public MidNextUpdate As DateTime

    'number of times that program has been run
    Public Timesrun As Long

    Public Use_Agent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36 Edg/85.0.564.44"


    Public suffixArr As New List(Of String)({"Max", "Min", "Avg", "MaxTime", "MinTime"})

End Module

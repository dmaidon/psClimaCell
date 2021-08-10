Imports System.IO

Friend Module GlobalsV4

    'Folder declarations
    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")
    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")
    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")
    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")
    Public LocationDir As String = Path.Combine(Application.StartupPath, "Locations")

    Public LogFile, TlDataFile, ErrFile As String

    Public Cpy As String = $"©2020-{Now:yyyy} PAROLE Software - All rights reserved."

    Public GotErr As Boolean
    Public ResetErr As Boolean

    Public unitArr As New List(Of String)({"imperial", "metric"})

    Public unitNfo As FieldUnitsModel

    ' Timelines update interval
    Public TlDuration As TimeSpan
    Public TlNextUpdate As DateTime

    ' download reset timer interval
    Public ResetDuration As TimeSpan
    Public ResetNextUpdate As DateTime
    Public ResetCounter As Integer


    ' Midnight interval
    Public MidDuration As TimeSpan
    Public MidNextUpdate As DateTime

    'number of times that program has been run
    Public Timesrun As Long

    Public Use_Agent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36 Edg/88.0.705.63"


    Public suffixArr As New List(Of String)({"Max", "Min", "Avg", "MaxTime", "MinTime"})
    Public ImgPbArr As New List(Of PictureBox)({FrmMainv4.PbImgStyle0, FrmMainv4.PbImgStyle1, FrmMainv4.PbImgStyle2, FrmMainv4.PbImgStyle3})

    Public ImgStyleArr As New List(Of String)({"A", "B"})
    Public ImgSamp As New List(Of String)({"1000.png", "1102.png", "4000.png", "5001.png"})

    'Public Enum PreX
    '    Max = &H1
    '    Min = &H2
    '    Avg = &H4
    '    MaxTime = &H8
    '    MinTime = &H10
    'End Enum

    'time value for when application starts up
    Public AppStartTime As DateTime
End Module

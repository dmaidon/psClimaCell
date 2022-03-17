Imports System.IO

Friend Module GlobalsV4

#Region "Folders"

    Public DataDir As String = Path.Combine(Application.StartupPath, "Data")

    Public DayDir, MonthDir, YearDir As String

    Public IconDir As String = Path.Combine(Application.StartupPath, "Icons")

    Public ImageDir As String = Path.Combine(Application.StartupPath, "ForecastImages")

    Public LocationDir As String = Path.Combine(Application.StartupPath, "Locations")

    Public LogDir As String = Path.Combine(Application.StartupPath, "Logs")

    Public LogFile, TlDataFile, ErrFile As String

    Public TempDir As String = Path.Combine(Application.StartupPath, "$tmp")

#End Region

#Region "Log Variables"

    Public GotErr As Boolean
    Public ResetErr As Boolean

#End Region

#Region "Data Variables"

    Public FetchWildfire As Boolean
    Public SaveFcImages As Boolean

    Public suffixArr As New List(Of String)({"Max", "Min", "Avg", "MaxTime", "MinTime"})
    Public unitArr As New List(Of String)({"imperial", "metric"})
    Public unitNfo As FieldUnitsModel

#End Region

#Region "Timer Variables"

    ' Midnight interval
    Public MidDuration As TimeSpan

    Public MidNextUpdate As DateTime

    Public ResetCounter As Integer

    ' download reset timer interval
    Public ResetDuration As TimeSpan

    Public ResetNextUpdate As DateTime

    ' Timelines update interval
    Public TlDuration As TimeSpan

    Public TlNextUpdate As DateTime

#End Region

#Region "Weather Icons"

    Public ImgPbArr As New List(Of PictureBox)({FrmMainv4.PbImgStyle0, FrmMainv4.PbImgStyle1, FrmMainv4.PbImgStyle2, FrmMainv4.PbImgStyle3})
    Public ImgSamp As New List(Of String)({"1000.png", "1102.png", "4000.png", "5001.png"})
    Public ImgStyleArr As New List(Of String)({"A", "B"})

#End Region

#Region "App Variables"

    'time value for when application starts up
    Public AppStartTime As DateTime

    Public Cpy As String = $"©2020-{Now:yyyy} PAROLE Software - All rights reserved."

    'number of times that program has been run
    Public Timesrun As Long

    Public Use_Agent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4324.4692 Safari/537.36 Edg/97.0.1072.62"

#End Region

#Region "Structures"

    Partial Public Class AstroData
        Public Property Sunrise As String
        Public Property Sunset As String
    End Class
#End Region

End Module
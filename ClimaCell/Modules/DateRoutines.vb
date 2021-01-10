Imports System.Globalization

Friend Module DateRoutines

    Friend Function Unix2Date(strUnixTime As Long) As Date
        Try
            Dim nDateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0)
            Return nDateTime.AddSeconds(CDbl(strUnixTime.ToString(CultureInfo.CurrentCulture)))
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Return New DateTime(Now.ToFileTimeUtc())
        Finally
            'a
        End Try
    End Function

    Friend Function Date2Unix(dateTime As Date) As Long
        Try
            Return CLng(Fix(dateTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds))
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException.ToString)
            Return 0
        Finally
            'a
        End Try
    End Function

    Friend Function Transparent2Color(bmp1 As Bitmap, target As Color) As Bitmap
        'https://stackoverflow.com/questions/27318549/replacing-transparent-background-with-white-color-in-png-images
        Dim bmp2 As New Bitmap(bmp1.Width, bmp1.Height)
        Dim rect As New Rectangle(Point.Empty, bmp1.Size)
        Using g As Graphics = Graphics.FromImage(bmp2)
            g.Clear(target)
            g.DrawImageUnscaledAndClipped(bmp1, rect)
        End Using
        Return bmp2
    End Function


    Friend Function Deg2Compass(num As Double) As String
        ''https://stackoverflow.com/questions/7490660/converting-wind-direction-in-angles-to-text-words
        num *= 10
        Dim cardinals As New List(Of String)({"N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N"})
        Return cardinals(CInt(Math.Truncate(Math.Round((num Mod 3600) / 225))))
    End Function
End Module

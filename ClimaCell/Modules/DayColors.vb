Namespace Modules
    Friend Module DayColors

        Friend Function DgvColorDay(ht As Double, lt As Double) As (Bg As Color, Fg As Color)
            If ht >= 105 Then
                Return (Color.Brown, Color.LightYellow)
            ElseIf ht >= 99 Then
                Return (Color.Firebrick, Color.LightYellow)
            ElseIf ht >= 95 Then
                Return (Color.Crimson, Color.Gold)
            ElseIf ht >= 90 Then
                Return (Color.OrangeRed, Color.Black)
            ElseIf ht >= 85 Then
                Return (Color.Salmon, Color.Black)
            ElseIf ht >= 80 Then
                Return (Color.DarkOrange, Color.Black)
            ElseIf ht >= 75 Then
                Return (Color.Orange, Color.Black)
            ElseIf ht >= 70 Then
                Return (Color.LemonChiffon, Color.Black)
            ElseIf ht >= 65 Then
                Return (Color.LightYellow, Color.Black)
            ElseIf lt > 32 Then
                Return (Color.SkyBlue, Color.Black)
            ElseIf lt <= 0 Then
                Return (Color.White, Color.Purple)
            ElseIf lt > 0 AndAlso lt <= 5 Then
                Return (Color.Lavender, Color.Black)
            ElseIf lt > 5 AndAlso lt <= 15 Then
                Return (Color.MediumPurple, Color.Black)
            ElseIf Not (lt > 15 AndAlso lt <= 25) Then
                Return (Color.Navy, Color.Gold)
            Else
                Return (Color.Purple, Color.Gold)
            End If
        End Function

        Friend Function NwsColorDay(ht As Double) As (Bg As Color, Fg As Color)
            If ht >= 105 Then
                Return (Color.Brown, Color.LightYellow)
            ElseIf ht >= 99 Then
                Return (Color.Firebrick, Color.LightYellow)
            ElseIf ht >= 95 Then
                Return (Color.Crimson, Color.Gold)
            ElseIf ht >= 90 Then
                Return (Color.OrangeRed, Color.Black)
            ElseIf ht >= 85 Then
                Return (Color.Salmon, Color.Black)
            ElseIf ht >= 80 Then
                Return (Color.DarkOrange, Color.Black)
            ElseIf ht >= 75 Then
                Return (Color.Orange, Color.Black)
            ElseIf ht >= 70 Then
                Return (Color.LemonChiffon, Color.Black)
            ElseIf ht >= 65 Then
                Return (Color.LightYellow, Color.Black)
            ElseIf ht >= 50 Then
                Return (Color.AliceBlue, Color.Black)
            ElseIf ht >= 40 Then
                Return (Color.SkyBlue, Color.Black)
            ElseIf ht > 32 Then
                Return (Color.CornflowerBlue, Color.Black)
            ElseIf ht <= 0 Then
                Return (Color.White, Color.Purple)
            ElseIf ht > 0 AndAlso ht <= 5 Then
                Return (Color.Lavender, Color.Black)
            ElseIf ht > 5 AndAlso ht <= 15 Then
                Return (Color.MediumPurple, Color.Black)
            ElseIf Not (ht > 15 AndAlso ht <= 25) Then
                Return (Color.Navy, Color.Gold)
            Else
                Return (Color.Purple, Color.Gold)
            End If
        End Function

    End Module
End Namespace
Public Class Form1
    Dim rollTotalArray(10, 10000) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RollDice()
    End Sub
    Private Sub RollDice()
        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim rollTotal As Integer
        For i = 1 To 1000
            diceOne = (VBMath.Rnd() * 5) + 1
            diceTwo = (VBMath.Rnd() * 5) + 1
            rollTotal = diceOne + diceTwo
            TotalDice(rollTotal)
        Next
    End Sub
    Private Sub TotalDice(rollTotal As Integer)
        Static trackertwo As Integer
        Static trackerThree As Integer
        Static trackerFour As Integer
        Static trackerFive As Integer
        Static trackerSix As Integer
        Static trackerSeven As Integer
        Static trackerEight As Integer
        Static trackerNine As Integer
        Static trackerTen As Integer
        Static trackerEleven As Integer
        Static trackerTwelve As Integer
        Dim tracker As Integer
        If rollTotal = 2 Then
            trackertwo += 1
            tracker = trackertwo
            WriteDiceTotal(0, tracker, rollTotal)
        End If
        If rollTotal = 3 Then
            trackerThree += 1
            tracker = trackerThree
            WriteDiceTotal(1, tracker, rollTotal)
        End If
        If rollTotal = 4 Then
            trackerFour += 1
            tracker = trackerFour
            WriteDiceTotal(2, tracker, rollTotal)
        End If
        If rollTotal = 5 Then
            trackerFive += 1
            tracker = trackerFive
            WriteDiceTotal(3, tracker, rollTotal)
        End If
        If rollTotal = 6 Then
            trackerSix += 1
            tracker = trackerSix
            WriteDiceTotal(4, tracker, rollTotal)
        End If
        If rollTotal = 7 Then
            trackerSeven += 1
            tracker = trackerSeven
            WriteDiceTotal(5, tracker, rollTotal)
        End If
        If rollTotal = 8 Then
            trackerEight += 1
            tracker = trackerEight
            WriteDiceTotal(6, tracker, rollTotal)
        End If
        If rollTotal = 9 Then
            trackerNine += 1
            tracker = trackerNine
            WriteDiceTotal(7, tracker, rollTotal)
        End If
        If rollTotal = 10 Then
            trackerTen += 1
            tracker = trackerTen
            WriteDiceTotal(8, tracker, rollTotal)
        End If
        If rollTotal = 11 Then
            trackerEleven += 1
            tracker = trackerEleven
            WriteDiceTotal(9, tracker, rollTotal)
        End If
        If rollTotal = 12 Then
            trackerTwelve += 1
            tracker = trackerTwelve
            WriteDiceTotal(10, tracker, rollTotal)
        End If
    End Sub
    Private Sub WriteDiceTotal(collumn As Integer, row As Integer, rolltotal As Integer)
        rollTotalArray(collumn, row) = rolltotal

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To 10
            ' Console.WriteLine(rollTotalArray(i, 100))
            'Console.WriteLine(CStr(rollTotalArray(0, i)).PadLeft(5), CStr(rollTotalArray(1, i)).PadLeft(5), CStr(rollTotalArray(2, i)).PadLeft(5), CStr(rollTotalArray(3, i)).PadLeft(5),
            '                  CStr(rollTotalArray(4, i)).PadLeft(5), CStr(rollTotalArray(5, i)).PadLeft(5), CStr(rollTotalArray(6, i)).PadLeft(5), CStr(rollTotalArray(7, i)).PadLeft(5),
            '                  CStr(rollTotalArray(8, i)).PadLeft(5), CStr(rollTotalArray(9, i)).PadLeft(5), CStr(rollTotalArray(10, i)).PadLeft(5))

        Next
        Console.WriteLine(CStr(rollTotalArray(0, 100)))
    End Sub

End Class
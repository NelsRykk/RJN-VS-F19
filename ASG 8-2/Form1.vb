'Rykken Nelson
'RCET0265
'asg 4-1
'Dice Roller
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/ASG%208-1
Public Class Form1
    Dim rollTotalArray(10, 10000) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RollDice()
    End Sub
    Private Sub RollDice()
        Dim dieOne As Integer
        Dim dieTwo As Integer
        Dim rollTotal As Integer
        For i = 1 To 10000
            dieOne = CInt((VBMath.Rnd() * 5) + 1)
            dieTwo = CInt((VBMath.Rnd() * 5) + 1)
            rollTotal = dieOne + dieTwo
            TotalDice(rollTotal)
        Next
    End Sub
    Private Sub TotalDice(rollTotal As Integer)
        Static trackerTwo As Integer
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
        If rollTotal = 13 Then
            WriteData(trackerSeven, trackerTwo, trackerThree, trackerFour, trackerFive, trackerSix, trackerSeven, trackerEight, trackerNine, trackerTen, trackerEleven, trackerTwelve)

        Else

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
        End If
    End Sub

    Private Sub WriteDiceTotal(collumn As Integer, row As Integer, rollTotal As Integer)
        rollTotalArray(collumn, row) = rollTotal
        Console.WriteLine(rollTotal & " " & "row:" & row)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TotalDice(13)
    End Sub
    Private Sub WriteData(lastStep, countTwo, countThree, countFour, countFive, countSix, countSeven, countEight, countNine, countTen, countEleven, countTwelve)
        Dim zero As String
        Dim one As String
        Dim two As String
        Dim three As String
        Dim four As String
        Dim five As String
        Dim six As String
        Dim seven As String
        Dim eight As String
        Dim nine As String
        Dim ten As String
        Dim row As String
        Dim setUp As String

        setUp = CStr(countTwo).PadLeft(7) & CStr(countThree).PadLeft(7) & CStr(countFour).PadLeft(6) & CStr(countFive).PadLeft(7) & CStr(countSix).PadLeft(6) & CStr(countSeven).PadLeft(7) & CStr(countEight).PadLeft(7) & CStr(countNine).PadLeft(6) & CStr(countTen).PadLeft(7) & CStr(countEleven).PadLeft(7) & CStr(countTwelve).PadLeft(6)
        ListSetup(lastStep, setUp)

        For j = 0 To lastStep
            row = CStr(j).PadLeft(4)
            Try
                If CInt(rollTotalArray(0, j)) = 2 Then
                    zero = "2".PadLeft(8)
                Else
                    zero = "/".PadLeft(8)
                End If
            Catch
                MessageBox.Show("No Data in array")
                Me.Close()
            End Try
            If CInt(rollTotalArray(1, j)) = 3 Then
                one = "3".PadLeft(5)
            Else
                one = "/".PadLeft(5)
            End If
            If CInt(rollTotalArray(2, j)) = 4 Then
                two = "4".PadLeft(6)
            Else
                two = "/".PadLeft(6)
            End If
            If CInt(rollTotalArray(3, j)) = 5 Then
                three = "5".PadLeft(7)
            Else
                three = "/".PadLeft(7)
            End If
            If CInt(rollTotalArray(4, j)) = 6 Then
                four = "6".PadLeft(6)
            Else
                four = "/".PadLeft(6)
            End If
            If CInt(rollTotalArray(5, j)) = 7 Then
                five = "7".PadLeft(6)
            Else
                five = "/".PadLeft(6)
            End If
            If CInt(rollTotalArray(6, j)) = 8 Then
                six = "8".PadLeft(8)
            Else
                six = "/".PadLeft(8)
            End If
            If CInt(rollTotalArray(7, j)) = 9 Then
                seven = "9".PadLeft(7)
            Else
                seven = "/".PadLeft(7)
            End If
            If CInt(rollTotalArray(8, j)) = 10 Then
                eight = "10".PadLeft(7)
            Else
                eight = "/".PadLeft(7)
            End If
            If CInt(rollTotalArray(9, j)) = 11 Then
                nine = "11".PadLeft(7)
            Else
                nine = "/".PadLeft(7)
            End If
            If CInt(rollTotalArray(10, j)) = 12 Then
                ten = "12".PadLeft(7)
            Else
                ten = "/".PadLeft(7)
            End If
            Console.WriteLine(zero & one & two & three & four & five & six & seven & eight & nine & ten)
            DiceRollListBox.Items.Add(row & zero & one & two & three & four & five & six & seven & eight & nine & ten)
        Next
    End Sub
    Private Sub ListSetup(lastStep, setup)
        DiceRollListBox.Items.Add("Collumn" & "two".PadLeft(5) & "three".PadLeft(7) & "four".PadLeft(7) & "five".PadLeft(6) & "six".PadLeft(6) & "seven".PadLeft(7) & "eight".PadLeft(7) & "nine".PadLeft(7) & "ten".PadLeft(5) & "eleven".PadLeft(8) & "twelve".PadLeft(9))
        DiceRollListBox.Items.Add("Total" & setup)

    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceRollListBox.Items.Clear()
        For j = 0 To 10000
            rollTotalArray(10, j) = ""
            rollTotalArray(9, j) = ""
            rollTotalArray(8, j) = ""
            rollTotalArray(7, j) = ""
            rollTotalArray(6, j) = ""
            rollTotalArray(5, j) = ""
            rollTotalArray(4, j) = ""
            rollTotalArray(3, j) = ""
            rollTotalArray(3, j) = ""
            rollTotalArray(2, j) = ""
            rollTotalArray(1, j) = ""
            rollTotalArray(0, j) = ""
        Next
    End Sub
End Class


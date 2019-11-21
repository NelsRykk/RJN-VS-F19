'Rykken Nelson
'RCET0265
'asg 8-1
'10 random numbers -10 to 10 
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/ASG%208-1

Option Explicit On
Option Strict On

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randNum As Integer
        Dim symbol As String = ""
        Dim symbolGen As Integer
        Dim symbolPad As String
        For i = 1 To 10

            randNum = CInt(VBMath.Rnd() * 10)
            symbolGen = CInt(VBMath.Rnd())
            If symbolGen = 0 Then
                symbol = "-"
            End If
            If symbolGen = 1 Then
                symbol = "+"
            End If
            If randNum = 0 Then
                symbol = ""
            End If

            If randNum = 10 Then
                SymbolPad = symbol.PadLeft(3)
            Else
                SymbolPad = symbol.PadLeft(4)

            End If
            RandomTen(symbolPad, randNum, i)
        Next

    End Sub

    Private Sub RandomTen(symbolRecieve As String, answer As Integer, j As Integer)
        Static randomFinal As String
        randomFinal += CStr(symbolRecieve & answer)
        If j = 10 Then
            Console.WriteLine(randomFinal)
            RndNumListBox.Items.Add(randomFinal)
            randomFinal = ""
        End If
        If j = 11 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RndNumListBox.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class

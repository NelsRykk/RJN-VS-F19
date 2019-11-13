'Rykken Nelson
'RCET0265
'asg 4-1
'10 random numbers -10 to 10 
'

Option Explicit Off
Option Strict Off

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randNum As Decimal
        Dim symbol As String = ""
        Dim symbolGen As Integer

        For i = 1 To 10

            randNum = CInt(VBMath.Rnd() * 10)
            symbolGen = VBMath.Rnd()
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

End Class

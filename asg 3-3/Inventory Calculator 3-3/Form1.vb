'Rykken Nelson
'RCET0265
'asg 3-3 
'Inventory Calculator
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/Asg2-5%20-%20Copy

Option Strict On
Option Explicit On

Public Class Form1
    Dim average As Decimal
    Dim turn As Decimal
    Dim beginning As Decimal
    Dim ending As Integer
    Dim beginningEntered As Integer
    Dim endingEntered As Integer
    Dim costEntered As Integer
    Dim goods As Integer

    Sub Filled()

        beginningEntered = Len(beginningIn.Text)
        endingEntered = Len(endingIn.Text)
        costEntered = Len(costGoods.Text)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Filled()
        Console.WriteLine(endingEntered)
        Console.WriteLine(beginningEntered)
        Console.WriteLine(costEntered)
        If beginningEntered >= 1 And endingEntered >= 1 Then
            Try
                beginning = CInt(beginningIn.Text)
                ending = CInt(endingIn.Text)
                goods = CInt(costGoods.Text)

                average = Math.Round((beginning + ending) / 2, 2)
                turn = Math.Round(goods / average, 2)
                averageIn.Text = average
                turnOver.Text = turn


            Catch ex As Exception
                MessageBox.Show("Type in integer value only")
            End Try
        Else
            MessageBox.Show("type integer value Into Beginning Inventory" & vbNewLine _
                            & "Ending Inventory, and Cost of Goods")

        End If
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        beginningIn.Text = ""
        endingIn.Text = ""
        costGoods.Text = ""
        turnOver.Text = ""
        averageIn.Text = ""
    End Sub
End Class

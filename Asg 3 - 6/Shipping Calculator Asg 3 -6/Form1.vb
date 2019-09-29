'Rykken Nelson
'RCET0265
'asg3-6
'Shipping Calculator
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/Asg%203%20-%206/Shipping%20Calculator%20Asg%203%20-6


Option Strict On
Option Explicit On
Public Class Form1
    Dim ship As Double
    Dim pounds As Integer
    Dim ounce As Integer
    Dim Id As Integer
    Dim weight As Double
    Sub Work()
        pounds = Len(pound.Text)
        ounce = Len(oz.Text)
        Id = Len(IDCode.Text)
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Work()
        ship = 0.12
        If pounds >= 1 And ounce >= 1 And Id = 6 Then
            Try
                ounce = Integer.Parse(oz.Text)
                pounds = CInt(pound.Text)
                weight = ((pounds * 16) + ounce)
                Console.WriteLine(weight)
                ship = CDec(Math.Round(0.12 * weight, 2))
                shipCost.Text = CStr("$" & ship)

            Catch ex As Exception
                MessageBox.Show("use integer values only")
            End Try
        Else
            MessageBox.Show("put in correct data")
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        shipCost.Text = ""
        oz.Text = ""
        IDCode.Text = ""
        pound.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        IDCode.Show()
    End Sub
End Class

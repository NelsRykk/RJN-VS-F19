Public Class Calculator

    Dim first1 As Integer
    Dim second1 As Integer



    Sub suma()
        first1 = first.Text
        Convert.ToDecimal(first1)
        second1 = second.Text
        Convert.ToDecimal(second1)

        result.Text = (first1 + second1)
        Console.WriteLine(result)
    End Sub


    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        first1 = first.Text
        Convert.ToDecimal(first1)
        second1 = second.Text
        Convert.ToDecimal(second1)

        result.Text = (first1 + second1)
        Console.WriteLine(result)
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        first1 = first.Text
        Convert.ToDecimal(first1)
        second1 = second.Text
        Convert.ToDecimal(second1)

        result.Text = (first1 - second1)
        Console.WriteLine(result)
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        first1 = first.Text
        Convert.ToDecimal(first1)
        second1 = second.Text
        Convert.ToDecimal(second1)

        result.Text = (first1 * second1)
        Console.WriteLine(result)
    End Sub

    Private Sub Devide_Click(sender As Object, e As EventArgs) Handles devide.Click
        first1 = first.Text
        Convert.ToDecimal(first1)
        second1 = second.Text
        Convert.ToDecimal(second1)

        result.Text = (first1 / second1)
        Console.WriteLine(result)
    End Sub
End Class

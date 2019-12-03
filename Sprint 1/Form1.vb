'Rykken Nelson
'VisualBasics 
'Sprint 1 
'12/3/19

Public Class Form1

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Console.WriteLine("lame")
        Dim convertString As Int32
        Try
            convertString = CType(StringIntegerTextBox.Text, Int32)
            ConvertedTextBox.Text = convertString
            StringIntegerTextBox.Text = ""
        Catch ex As Exception
            MessageBox.Show("This must be an Integer Value")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        StringIntegerTextBox.Select()
    End Sub
End Class

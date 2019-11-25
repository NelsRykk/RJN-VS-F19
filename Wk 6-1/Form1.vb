'Rykken Nelson
'RCET0265
'asg WK 6-1
'EtchOSketch
'
Public Class Form1
    Private Sub Draw()
        Dim graph As Graphics = PictureBox1.CreateGraphics
        ' graph.DrawLine(pens.Cyan, x1, y1, x2, y2)
        ' graph.FillRectangle(Brushes.Blue, x1, y1, x2, y2)
        ' graph.DrawRectangles(Pens.Cyan, x1, y1, x2, y2)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DrawButton.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 300 Then Me.Width = 300
        PictureBox1.Width = Me.Width - PictureBox1.Left - 25
        PictureBox1.Height = Me.Height - PictureBox1.Top - 75
        Label1.Left = 
    End Sub
End Class

'Rykken Nelson
'RCET0265
'asg WK 6-1
'EtchOSketch
'
Public Class DrawButton
    Dim newColor As Color


    Private Sub Draw()
        Dim graph As Graphics = PictureBox1.CreateGraphics
        ' graph.DrawLine(pens.Cyan, x1, y1, x2, y2)
        ' graph.FillRectangle(Brushes.Blue, x1, y1, x2, y2)
        ' graph.DrawRectangles(Pens.Cyan, x1, y1, x2, y2)

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, e As EventArgs) Handles Me.Resize
        'Sets the position of the buttons and drawing box when the form is resized
        If Me.Width < 300 Then Me.Width = 300
        PictureBox1.Width = Me.Width - PictureBox1.Left - 25
        PictureBox1.Height = Me.Height - PictureBox1.Top - 75
        DrawingButton.Left = PictureBox1.Left - 100
        RectangleButton.Left = PictureBox1.Left - 100
        CircleButton.Left = PictureBox1.Left - 100
        ColorButton.Left = PictureBox1.Left - 100
        ClearButton.Left = PictureBox1.Left - 100
        ExitButton.Left = PictureBox1.Left - 100
        ClearButton.Top = PictureBox1.Top + 200
        ExitButton.Top = PictureBox1.Top + 250
        DrawingButton.Top = PictureBox1.Top
        RectangleButton.Top = PictureBox1.Top + 50
        CircleButton.Top = PictureBox1.Top + 100
        ColorButton.Top = PictureBox1.Top + 150
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        'Draws the Picture
        Dim graph As Graphics = PictureBox1.CreateGraphics
        Dim blackPen As New Pen(newColor, 3)
        Static x1, y1 As Single
        If e.Button.ToString = "Left" And RectangleButton.Checked = False And CircleButton.Checked = False Then
            graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
            If DrawingButton.Checked = True Then
                If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newColor = Color.Black
                'graph.FillRectangle(Brushes.Cyan, x1, y1, e.X, e.Y)
                'graph.DrawRectangles(Pens.Cyan, x1, y1, e.X, e.Y)
            End If
        End If
        If RectangleButton.Checked = True And e.Button.ToString = "Left" Then
            Dim blueBrush As New SolidBrush(newColor)
            Dim rect As New Rectangle(x1, y1, 100, 100)
            graph.FillRectangle(blueBrush, rect)
            ' graph.FillRectangle(Brushes.Black, x1, y1, e.X, e.y)
            ' If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newColor = Color.Black
        End If
        If CircleButton.Checked = True And e.Button.ToString = "Left" Then
            ' Create solid brush.
            Dim blueBrush As New SolidBrush(newColor)
            ' Create rectangle.
            Dim rect As New Rectangle(x1, y1, 100, 100)
            ' Fill circle to screen.
            graph.FillEllipse(blueBrush, rect)
        End If

    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        'Changes the Color of the pen 
        ColorDialog1.ShowDialog()
        newColor = ColorDialog1.Color
    End Sub

    Private Sub FillRectangleRectangle(ByVal e As PaintEventArgs)

        ' Create solid brush.
        Dim blueBrush As New SolidBrush(Color.Blue)

        ' Create rectangle.
        Dim rect As New Rectangle(0, 0, 200, 200)

        ' Fill rectangle to screen.
        e.Graphics.FillRectangle(blueBrush, rect)
    End Sub

    Private Sub DrawButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawingButton.Select()
        newColor = ColorDialog1.Color
    End Sub
End Class

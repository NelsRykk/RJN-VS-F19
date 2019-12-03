'Rykken Nelson
'RCET0265
'asg WK 6-1
'EtchOSketch
'
Public Class DrawButton
    Dim newColor As Color
    Private Sub Form1_Resize(ByVal sender As Object, e As EventArgs) Handles Me.Resize
        'Sets the position of the buttons and drawing box when the form is resized
        If Me.Width < 300 Then Me.Width = 300
        PictureBox1.Width = Me.Width - PictureBox1.Left - 25
        PictureBox1.Height = Me.Height - PictureBox1.Top - 75
        DrawingRadioButton.Left = PictureBox1.Left - 120
        RectangleRadioButton.Left = PictureBox1.Left - 120

        CircleRadioButton.Left = PictureBox1.Left - 120
        EffectsRadioButton.Left = PictureBox1.Left - 120
        BrushSizeLable.Left = PictureBox1.Left - 120
        BrushSizeTextbox.Left = PictureBox1.Left - 120
        SineWaveButton.Left = PictureBox1.Left - 110
        ColorButton.Left = PictureBox1.Left - 110
        ClearButton.Left = PictureBox1.Left - 110
        ExitButton.Left = PictureBox1.Left - 110
        ClearButton.Top = PictureBox1.Top + 260
        ExitButton.Top = PictureBox1.Top + 300
        DrawingRadioButton.Top = PictureBox1.Top
        RectangleRadioButton.Top = PictureBox1.Top + 25
        CircleRadioButton.Top = PictureBox1.Top + 50
        SineWaveButton.Top = PictureBox1.Top + 180
        ColorButton.Top = PictureBox1.Top + 220
        EffectsRadioButton.Top = PictureBox1.Top + 75
        BrushSizeLable.Top = PictureBox1.Top + 100
        BrushSizeTextbox.Top = PictureBox1.Top + 120
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        'sets brush width 
        Dim brushSize As Decimal
        Try
            brushSize = CInt(BrushSizeTextbox.Text)
        Catch ex As Exception
            MessageBox.Show("This must contain only numeric values")
        End Try
        'Draws the Picture
        Dim graph As Graphics = PictureBox1.CreateGraphics
        Dim blackPen As New Pen(newColor, 3)
        Static x1, y1 As Single
        If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newColor = Color.Cyan
        If e.Button.ToString = "Left" Then

            If DrawingRadioButton.Checked = True Then
                graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
                'graph.FillRectangle(Brushes.Cyan, x1, y1, e.X, e.Y)
                'graph.DrawRectangles(Pens.Cyan, x1, y1, e.X, e.Y)
            End If
        End If
        If RectangleRadioButton.Checked = True And e.Button.ToString = "Left" Then
            Dim blueBrush As New SolidBrush(newColor)
            Dim rect As New Rectangle(x1 - 42, y1 - 55, brushSize, brushSize)
            graph.DrawRectangle(blackPen, rect)
            ' graph.FillRectangle(Brushes.Black, x1, y1, e.X, e.y)
            ' If x1 = 0 And y1 = 0 Then x1 = e.X : y1 = e.Y : newColor = Color.Black
        End If
        If CircleRadioButton.Checked = True And e.Button.ToString = "Left" Then
            ' Create solid brush.
            Dim blueBrush As New SolidBrush(newColor)
            ' Create rectangle.
            Dim circle As New Rectangle(x1 - 42, y1 - 55, brushSize, brushSize)
            ' Fill circle to screen.
            graph.FillEllipse(blueBrush, circle)
        End If
        If EffectsRadioButton.Checked = False Then
            x1 = e.X : y1 = e.Y
            Label1.Text = e.Button.ToString & "    " & e.X & "    " & e.Y
        Else
            graph.DrawLine(blackPen, x1, y1, e.X, e.Y)
        End If
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        'Changes the Color of the pen 
        ColorDialog1.ShowDialog()
        newColor = ColorDialog1.Color
    End Sub

    Private Sub DrawButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawingRadioButton.Select()
        newColor = ColorDialog1.Color
        BrushSizeTextbox.Text = 100
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PictureBox1.Height = PictureBox1.Height - 25
        PictureBox1.Width = PictureBox1.Width - 25
        Timer1.Enabled = True
        PictureBox1.Height = PictureBox1.Height + 25
        PictureBox1.Width = PictureBox1.Width + 25
        Timer1.Enabled = True
        PictureBox1.Height = PictureBox1.Height - 25
        PictureBox1.Width = PictureBox1.Width - 25
        PictureBox1.Refresh()
        Timer1.Enabled = True
        PictureBox1.Height = PictureBox1.Height + 25
        PictureBox1.Width = PictureBox1.Width + 25
        Timer1.Enabled = True
        PictureBox1.Height = PictureBox1.Height - 25
        PictureBox1.Width = PictureBox1.Width - 25
        Timer1.Enabled = True
        PictureBox1.Height = PictureBox1.Height + 25
        PictureBox1.Width = PictureBox1.Width + 25

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SineWaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SineWaveButton.Click
        Static x1, rad, y1, x2, y2 As Double
        Dim randomPen As New Pen(newColor, 5)
        Dim drawGraphics As Graphics
        drawGraphics = PictureBox1.CreateGraphics

        For rad = 5 To PictureBox1.Width - 5
            If rad = 5 Or rad = PictureBox1.Width - 5 Then
                y1 = PictureBox1.Height / 2
                y2 = y1
            Else
                y1 = Math.Sin(rad / ((PictureBox1.Width - 10) / 2) * Math.PI) * ((PictureBox1.Height / 2 - 10)) + (PictureBox1.Height / 2)
            End If
            'Math.Sin(rad / 175 * 2 * Math.PI) * 150 + 150
            x1 = rad

            Console.WriteLine(x1 & "  " & y1)
            drawGraphics.DrawLine(randomPen, CType(rad, Single), CType(y1, Single), CType(x2, Single), CType(y2, Single))
            x2 = x1 : y2 = y1
            'CType(x1, Single), CType(y1, Single), CType(x2, Single), CType(y2, Single)
            'randomPen, 0, 0, PictureBox1.Width, PictureBox1.Height

            'Dim graph As Graphics = PictureBox1.CreateGraphics
            'Dim brushSize As Decimal
            'Dim angle As Decimal
            'Dim blackPen As New Pen(newColor, 3)
            'Static x1, y1, x2, y2 As Single
            'Dim movement, radius, drawWidth, drawHeight As Single
            'If x1 = 0 And y1 = 0 Then x1 = x2 : y1 = y2 : newColor = Color.Cyan

            'Try
            '    brushSize = CInt(BrushSizeTextbox.Text)
            'Catch ex As Exception
            '    MessageBox.Show("This must contain only numeric values")
            'End Try

            'movement = 5I
            'drawWidth = PictureBox1.Width - movement
            'drawHeight = PictureBox1.Height - movement
            'radius = (drawHeight) / 2
            'For angle = 0 To 360 Step 1.0
            '    y2 = CSng(-radius * Math.Sin(angle / 57.3) + (drawHeight) / 2)
            '    x2 = angle * (drawWidth) / 360
            '    graph.DrawLine(Pens.Yellow, x1, x1, x2, y2)
            '    x1 = x2 : y1 = y2
        Next
    End Sub

End Class

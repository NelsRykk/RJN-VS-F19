Public Class Form1
    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ListBox1.Left = Me.Left + 5
        ListBox1.Width = Me.Width - 10
    End Sub
End Class
'If Me.Width < 300 Then Me.Width = 300
'        ListBox1.Left = Me.Left + 5
'ListBox1.Width = Me.Width - 10
'ListBox1.Top = Me.Top + 50
'ListBox1.Height = Me.Height - 100
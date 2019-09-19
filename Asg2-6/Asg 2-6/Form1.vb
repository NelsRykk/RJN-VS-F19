'Rykken Nelson
'RCET0265
'asg2-6
'State flag viewer program
'

Option Explicit On
Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = BackgroundImage
        Label1.Text = "Select State Flag"
    End Sub

    Private Sub Oregon_Click(sender As Object, e As EventArgs) Handles Oregon.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources.flag_oregon
    End Sub

    Private Sub Idaho_Click(sender As Object, e As EventArgs) Handles Idaho.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources.Idaho
    End Sub

    Private Sub Washington_Click(sender As Object, e As EventArgs) Handles Washington.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources.Washington
    End Sub

    Private Sub Cali_Click(sender As Object, e As EventArgs) Handles Cali.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources.California
    End Sub

    Private Sub Utah_Click(sender As Object, e As EventArgs) Handles Utah.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources.flag_of_utah
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Wyoming_Click(sender As Object, e As EventArgs) Handles Wyoming.Click
        PictureBox1.Image = Asg_2_6.My.Resources.Resources._41ANJDAT1DL__SX425_
    End Sub
End Class

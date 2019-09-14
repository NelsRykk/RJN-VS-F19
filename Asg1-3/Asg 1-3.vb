'Assignment: Asg1-3
'RCET0265
'Rykken Nelson
'Wisdom

Option Strict Off
Option Explicit Off

Public Class Form1
    Dim bot As Integer
    Dim pic As Integer

    Private Sub MLKJr_Click(sender As Object, e As EventArgs) Handles MLKJr.Click
        WisdomBox.Text = "nothing pains someone more then having to think - MLK_Jr"
        pic = 1
        portrait()
    End Sub

    Private Sub Faraday_Click(sender As Object, e As EventArgs) Handles Faraday.Click
        WisdomBox.Text = "A man who is certain he is right is almost sure to be wrong." & "Micheal Faraday"
        pic = 2
        Portrait()
    End Sub

    Private Sub Newton_Click(sender As Object, e As EventArgs) Handles Newton.Click
        WisdomBox.Text = "My powers are ordinary. Only my application brings me success." & "Isaac Newton"
        pic = 3
        Portrait()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pic = 4
        Portrait()
        SelectiveWisdom()                       'this starts up the selective wisdom case
    End Sub

    Sub SelectiveWisdom()
        bot = CInt(Math.Ceiling(Rnd() * 4))     'a way to generate a random number from 1 to 4
        If bot = 1 Then
            WisdomBox.Text = "We all have genius within us, never doubt that fact."
        ElseIf bot = 2 Then
            WisdomBox.Text = "Failure is success in progress"
        ElseIf bot = 3 Then
            WisdomBox.Text = "Tomorrow is often the busiest day of the week"
        ElseIf bot = 4 Then
            WisdomBox.Text = "A bad excuse is better than none"
        End If
    End Sub
    Sub Portrait()
        If pic = 1 Then                            'This allows to change the image in this sub which is controlled by another sub
            PictureBox1.Image = Asg1_3.My.Resources.Resources.MLK2
        ElseIf pic = 2 Then
            PictureBox1.Image = Asg1_3.My.Resources.Resources.Faraday
        ElseIf pic = 3 Then
            PictureBox1.Image = Asg1_3.My.Resources.Resources.og_isaac_newton_124
        ElseIf pic = 4 Then
            PictureBox1.Image = Asg1_3.My.Resources.Resources.anon_hack
        End If
    End Sub

    Private Sub Wizzed_Click(sender As Object, e As EventArgs) Handles Wizzed.Click
        PictureBox1.Image = Asg1_3.My.Resources.Resources.This_Is_Goodbye_For_now
        Me.Close()
    End Sub
End Class

'Tim Rossiter
'RCET0265
'asg2-5
'Address label display program
'


Option Explicit On
Option Strict On
Public Class Form1


    Dim firstName As String
    Dim lastName As String
    Dim address As String
    Dim city As String
    Dim state As String
    Dim zip As String


    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        firstName = MaskedTextBox1.Text
        lastName = MaskedTextBox2.Text
        address = MaskedTextBox3.Text
        city = MaskedTextBox4.Text
        state = MaskedTextBox5.Text
        zip = MaskedTextBox6.Text
        AddDisplay.Text = firstName & vbNewLine & lastName & vbNewLine & address & vbNewLine & city & vbNewLine & state & vbNewLine & zip
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        AddDisplay.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles leave.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "First Name"
        Label2.Text = "Last Name"
        Label3.Text = "Adress"
        Label4.Text = "State"
        Label5.Text = "City"
        Label6.Text = "Zip Code"
        AddDisplay.Text = ""
        MaskedTextBox1.Select()
    End Sub

End Class

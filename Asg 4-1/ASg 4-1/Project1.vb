'Rykken Nelson
'RCET0265
'asg 4-1
'Grade school mathematics 
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/Asg%204-1/ASg%204-1

Option Strict On
Option Explicit On
Public Class Project1
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim answerCorrect As String
    Dim person As String
    Dim age As Integer
    Dim grade As Integer
    Dim answer As Integer
    Dim initialized As Integer
    Dim whatIGet As String
    Dim correctCount As Integer
    Dim IncorrectCount As Integer
    Dim total As Integer

    Sub FindNum()                                                           ' this will randomize the number 
        If grade = 1 And initialized = 0 Then                               'Initialized has to be zero to find new number 
            firstNumber = CInt(Rnd() * 10)
            secondNumber = CInt(Rnd() * 10)
            FirstGrade()
        Else
            firstNumber = CInt(Rnd() * 100)
            secondNumber = CInt(Rnd()) * 100
        End If
        If grade = 2 Then
            Try
                firstNumber = CInt(Rnd() * 10)
                secondNumber = CInt(Rnd() * 10)
                SecondGrade()
            Catch ex As Exception
                MessageBox.Show("Enter number in First Number Box and Second Number Box")
            End Try
        End If
        If grade = 3 Then
            Try
                firstNumber = CInt(Rnd() * 10)
                secondNumber = CInt(Rnd() * 10)
                ThirdGrade()
            Catch ex As Exception
                MessageBox.Show("Enter number in First Number Box and Second Number Box")
            End Try
        End If
        If grade = 4 And RadioButtonDivide.Checked = True Then
            Try
                firstNumber = CInt(Rnd() * 50)
                secondNumber = CInt(Rnd() * 10)
                FourthGrade()
            Catch ex As Exception
                MessageBox.Show("Enter number in First Number Box and Second Number Box")
            End Try

        ElseIf grade = 4 And RadioButtonMultiply.Checked = True Then
            Try
                firstNumber = CInt(Rnd() * 50)
                secondNumber = CInt(Rnd() * 10)
                FourthGrade()
            Catch ex As Exception
                MessageBox.Show("Enter number in First Number Box and Second Number Box")
            End Try
        ElseIf grade = 4 And RadioButtonDivide.Checked = False Then
            Try
                firstNumber = CInt(Rnd() * 50)
                secondNumber = CInt(Rnd() * 50)
                FourthGrade()
            Catch ex As Exception
                MessageBox.Show("Enter number in First Number Box and Second Number Box")
            End Try
        End If
    End Sub

    Sub Add()
        If answerBox.Text = CStr(answer) And summaryButton.CausesValidation Then
            whatIGet = "Correct"

        End If
        Console.WriteLine(answerCorrect)
        answerCorrect = CStr(answerCorrect & vbNewLine & whatIGet & " " & firstNumber & " " & secondNumber & " " & "=" & " " & answer)
    End Sub

    Sub FirstGrade()
        RadioButtonSubtract.Hide()
        RadioButtonMultiply.Hide()
        RadioButtonDivide.Hide()
        If initialized = 0 Then
            If RadioButtonAdd.Checked = True Then
                firstNumberBox.Text = CStr(firstNumber)
                secondNumberBox.Text = CStr(secondNumber)
                answer = firstNumber + secondNumber
                initialized = 1
            End If
        End If
    End Sub

    Sub SecondGrade()
        RadioButtonAdd.Show()
        RadioButtonSubtract.Show()
        RadioButtonMultiply.Hide()
        RadioButtonDivide.Hide()
        If RadioButtonAdd.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber + secondNumber
            initialized = 1
        End If
        If RadioButtonSubtract.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber - secondNumber
            initialized = 1
        End If
    End Sub

    Sub ThirdGrade()
        RadioButtonAdd.Show()
        RadioButtonSubtract.Show()
        RadioButtonMultiply.Show()
        RadioButtonDivide.Hide()
        If RadioButtonAdd.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber + secondNumber
            initialized = 1
        End If
        If RadioButtonSubtract.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber - secondNumber
            initialized = 1
        End If
        If RadioButtonMultiply.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber * secondNumber
            initialized = 1
        End If
    End Sub

    Sub FourthGrade()
        RadioButtonAdd.Show()
        RadioButtonSubtract.Show()
        RadioButtonMultiply.Show()
        RadioButtonDivide.Show()
        If RadioButtonAdd.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber + secondNumber
            initialized = 1
        End If
        If RadioButtonSubtract.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber - secondNumber
            initialized = 1
        End If
        If RadioButtonMultiply.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            answer = firstNumber * secondNumber
            initialized = 1
        End If
        If RadioButtonDivide.Checked = True Then
            firstNumberBox.Text = CStr(firstNumber)
            secondNumberBox.Text = CStr(secondNumber)
            If firstNumber >= secondNumber And firstNumber Mod secondNumber = 0 And secondNumber >= 1 Then
                answer = firstNumber \ secondNumber
                initialized = 1
            Else initialized = 0
                FindNum()
            End If
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        person = nameBox.Text
        If initialized = 0 Then                                     'This will enable a random first number and second number to be generated when initialized = 0
            Try
                age = CInt(ageBox.Text)
            Catch ex As Exception
                MessageBox.Show("Enter Correct age In the Age Box below")
            End Try
            Try
                grade = CInt(gradeBox.Text)
            Catch ex As Exception
                MessageBox.Show("Enter correct Grade in grade box as number ")
            End Try

            If Len(person) > 1 Then
                If grade = 1 Then
                    FindNum()
                End If
                If grade = 2 Then
                    FindNum()
                End If
                If grade = 3 Then
                    FindNum()
                End If
                If grade = 4 Then
                    FindNum()
                End If
                FindNum()
            ElseIf Len(person) = 0 Then
                MessageBox.Show("Enter Your name in the NameBox")
            End If
        End If
        If initialized = 1 Then                             'When initialized = 1 then the math problem has not been answered 
            If answerBox.Text = CStr(answer) Then
                whatIGet = "Correct"
                correctCount += 1
            Else
                whatIGet = "Incorrect"
                IncorrectCount += 1
            End If
            answerCorrect = CStr(answerCorrect & " " & vbNewLine & whatIGet & " " & firstNumber & " " & secondNumber & " " & "=" & " " & answer)
            answerBox.Clear()
            initialized = 0                                 'Since the answer has now been answered a new number needs to be found initialized = 0
            FindNum()
            Console.WriteLine(answerCorrect)
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        initialized = 0
        Me.Close()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        total = correctCount + IncorrectCount - 1
        MessageBox.Show(CStr(correctCount) & "OUTOF" & CStr(total))
        initialized = 0
        FindNum()
    End Sub

    Private Sub Project1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialized = 0
    End Sub



    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        firstNumber = 0
        secondNumber = 0
        total = 0
        correctCount = 0
        IncorrectCount = 0
        firstNumberBox.Clear()
        secondNumberBox.Clear()
        answerBox.Clear()
        initialized = 0
        RadioButtonAdd.Checked = False
        RadioButtonSubtract.Checked = False
        RadioButtonMultiply.Checked = False
        RadioButtonDivide.Checked = False

    End Sub
End Class

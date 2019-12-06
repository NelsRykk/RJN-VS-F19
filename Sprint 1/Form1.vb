'Rykken Nelson
'VisualBasics 
'Sprint 1 
'12/3/19
'https://github.com/NelsRykk/RJN-VS-F19/tree/master/Sprint%201
Option Explicit On
Option Strict On
Public Class Form1

    'Sprint 1
    'Private Sub ConvertButton_Click(typedString As String, convertString As Int32) Handles ConvertButton.Click
    '    Try
    '        typedString = StringIntegerTextBox.Text
    '        convertString = CType(StringIntegerTextBox.Text, Int32)
    '        ConvertedTextBox.Text = CStr(convertString)
    '        StringIntegerTextBox.Text = ""
    '    Catch ex As Exception
    '        MessageBox.Show("This must be an Integer Value")
    '    End Try
    '    ValidateAndConvert(typedString, convertString)
    'End Sub

    Private Sub Collect(ByVal integerData As Integer)
        'TestValidateAndCovert(integerData)
        ' GetUserInput(integerData)

    End Sub
    'Sprint2
    'Private Sub TestValidateAndCovert(ByVal integerData As Integer) Handles Me.Load
    '    Dim collumn As Integer
    '    Dim Result As Integer = 0
    '    Dim Count As Integer = 0
    '    Dim pad As Integer = 15
    '    Dim report As String = ""
    '    Dim temp As String = ""
    '    Dim TestData = New String(4, 4) {{"5", "2", "17", "8", "42"},
    '        {"6.7", "3.14", "5.4", "5.5", "0.125"},
    '        {"-21", "-32.1", "-4", "-4.5", "-4.4"},
    '        {"", "", "", "", ""},
    '        {"True", "False", "lOOlO", "9O2lO", "dog"}}
    '    '   For row = 0 to​ 4 
    '    For collumn = 0 To 4
    '            Result = 0
    '            ' temp = ValidateAndConvert(TestData(row, column), Result)
    '            '  report &= ("Trying: " & TestData(CInt(row), column)).PadRight(pad)
    '            ' If​ row < 3 ​Then 
    '            'If​ CStr​(CInt​(TestData(row, column))) <> CStr​(Result) ​Or​ temp <> ​""​ ​Then
    '            report &= " TEST FAIL" & vbNewLine

    '        Next
    '    ' Next

    'End Sub

    'Sprint 3
    'This is the working code from Sprints 1 and 2
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String = ""
        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            message = "Must contain a number"
            If convertThisString = "" Then message = "is empty"
        End Try
        Return message
    End Function

    'Do Not change this code other that comment/uncomment the lines indicated
    'Private Sub GetUserInput() Handles Me.Load
    '    Me.Hide()
    '    Dim tempNum As Integer = 0
    '    Dim userMessage As String = "Please Enter A Number Between 0 and 15" _
    '        & vbNewLine & "Type Q to Quit"
    '    Do
    '        userMessage = InputBox(userMessage, "Hello", "")
    '        If userMessage <> "Q" And userMessage <> "" Then
    '            userMessage = ValidateAndConvert(userMessage, tempNum)
    '            If userMessage = "" Then userMessage = IsWayTooLong(tempNum)        'Replace this Line
    '            'If userMessage = "" Then userMessage = ShortAndSweet(tempNum)      'With this one
    '        End If
    '    Loop Until userMessage = "Q" Or userMessage = ""
    '    Me.Close()
    'End Sub

    'Private Function IsWayTooLong(ByVal numberFromZeroToFifteen As Integer) As String
    '    If numberFromZeroToFifteen = 0 Then
    '        Return "Your number is: Zero"
    '    End If
    '    If numberFromZeroToFifteen = 1 Then
    '        Return "Your number is: One"
    '    End If
    '    If numberFromZeroToFifteen = 2 Then
    '        Return "Your number is: Two"
    '    End If
    '    If numberFromZeroToFifteen = 3 Then
    '        Return "Your number is: Three"
    '    End If
    '    If numberFromZeroToFifteen = 4 Then
    '        Return "Your number is: Four"
    '    End If
    '    If numberFromZeroToFifteen = 5 Then
    '        Return "Your number is: Five"
    '    End If
    '    If numberFromZeroToFifteen = 6 Then
    '        Return "Your number is: Six"
    '    End If
    '    If numberFromZeroToFifteen = 7 Then
    '        Return "Your number is: Seven"
    '    End If
    '    If numberFromZeroToFifteen = 8 Then
    '        Return "Your number is: Eight"
    '    End If
    '    If numberFromZeroToFifteen = 9 Then
    '        Return "Your number is: Nine"
    '    End If
    '    If numberFromZeroToFifteen = 10 Then
    '        Return "Your number is: Ten"
    '    End If
    '    If numberFromZeroToFifteen = 11 Then
    '        Return "Your number is: Eleven"
    '    End If
    '    If numberFromZeroToFifteen = 12 Then
    '        Return "Your number is: Twelve"
    '    End If
    '    If numberFromZeroToFifteen = 13 Then
    '        Return "Your number is: Thirteen"
    '    End If
    '    If numberFromZeroToFifteen = 14 Then
    '        Return "Your number is: Fourteen"
    '    End If
    '    If numberFromZeroToFifteen = 15 Then
    '        Return "Your number is: Fifteen"
    '    End If
    '    If numberFromZeroToFifteen < 0 Then
    '        Return "Your number is: Too Low"
    '    End If
    '    If numberFromZeroToFifteen > 15 Then
    '        Return "Your number is: Too High"
    '    End If
    'End Function

    'Do Not change this code other that comment/uncomment the lines indicated
    Private Sub GetUserInput() Handles Me.Load
        Me.Hide()
        Dim tempNum As Integer = 0
        Dim userMessage As String = "Please Enter A Number Between 0 and 15" _
            & vbNewLine & "Type Q to Quit"
        Do
            userMessage = InputBox(userMessage, "Hello", "")
            If userMessage <> "Q" And userMessage <> "" Then
                userMessage = ValidateAndConvert(userMessage, tempNum)
                ' If userMessage = "" Then userMessage = IsWayTooLong(tempNum)        'Replace this Line
                If userMessage = "" Then userMessage = ShortAndSweet(tempNum)      'With this one
            End If
        Loop Until userMessage = "Q" Or userMessage = ""
        Me.Close()
    End Sub

    'In as few lines as possible produce the same results as the function IsWayTooLong()
    'Hint use a loop and a List or Array
    'Also only have one return statement at the end
    'Private Function ShortAndSweet(ByVal numberFromZeroToFifteen As Integer) As String
    '    'Your code here
    '    If numberFromZeroToFifteen = 0 Then : Return "Your Number is : Zero"
    '    ElseIf numberFromZeroToFifteen = 0 Then : Return "Your Number is : Zero"
    '    ElseIf numberFromZeroToFifteen = 1 Then : Return "Your Number is : One"
    '    ElseIf numberFromZeroToFifteen = 2 Then : Return "Your Number is : Two"
    '    ElseIf numberFromZeroToFifteen = 3 Then : Return "Your Number is : Three"
    '    ElseIf numberFromZeroToFifteen = 4 Then : Return "Your Number is : Four"
    '    ElseIf numberFromZeroToFifteen = 5 Then : Return "Your Number is : Five"
    '    ElseIf numberFromZeroToFifteen = 6 Then : Return "Your Number is : Six"
    '    ElseIf numberFromZeroToFifteen = 7 Then : Return "Your Number is : Seven"
    '    ElseIf numberFromZeroToFifteen = 8 Then : Return "Your Number is : Eight"
    '    ElseIf numberFromZeroToFifteen = 9 Then : Return "Your Number is : Nine"
    '    ElseIf numberFromZeroToFifteen = 10 Then : Return "Your Number is : Ten"
    '    ElseIf numberFromZeroToFifteen = 11 Then : Return "Your Number is : Eleven"
    '    ElseIf numberFromZeroToFifteen = 12 Then : Return "Your Number is : Twelve"
    '    ElseIf numberFromZeroToFifteen = 13 Then : Return "Your Number is : Thirteen"
    '    ElseIf numberFromZeroToFifteen = 14 Then : Return "Your Number is : Fourteen"
    '    ElseIf numberFromZeroToFifteen = 15 Then : Return "Your Number is : Fifteen"
    '    ElseIf numberFromZeroToFifteen < 0 Or numberFromZeroToFifteen > 15 Then : Return "your number is outside of specified parameters"
    '    End If
    'End Function
    Private Function ShortAndSweet(ByVal numberFromZeroToFifteen As Integer) As String
        Dim numberArray(16, 0) As String
        Dim word As String
        numberArray = {{"Zero"}, {"One"}, {"Two"}, {"Three"}, {"Four"}, {"Five"}, {"Six"}, {"Seven"}, {"Eight"}, {"Nine"}, {"Ten"}, {"Eleven"}, {"Twelve"}, {"Thirteen"}, {"Fourteen"}, {"Fifteen"}}
        If numberFromZeroToFifteen > 15 Or numberFromZeroToFifteen < 0 Then : Return "your number is outside of specified parameters"
        Else word = CStr(numberArray(numberFromZeroToFifteen, 0)) : Return word
        End If
    End Function


End Class

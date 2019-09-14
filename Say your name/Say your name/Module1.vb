Option Explicit On
Option Compare Text
Module Module1

    Sub Main()
        Dim user As String
        Dim Rykken As String
        Dim Tim As String
        Dim Emily As String
        Dim Tod As String

        Rykken = "Rykken"
        Tim = "Tim"
        Emily = "Emily"
        Tod = "Tod"

        Console.WriteLine("Whats your name?")

        user = Console.ReadLine()
        Console.WriteLine(user)
        Console.WriteLine("haha")



        If user = Rykken Then
            Console.WriteLine("Ive been expecting you Rykken")
        ElseIf user = Tim Then
            Console.WriteLine("Looks like an A, Tim")
        ElseIf user = Emily Then
            Console.WriteLine("Greetings Emily ")
        ElseIf user = Tod Then
            Console.WriteLine("Greetings Tod")
        End If


        Console.ReadLine()





    End Sub

End Module

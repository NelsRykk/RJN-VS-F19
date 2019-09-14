Option Explicit On

Module Module1

    'Rykken Nelson
    '9/13/19
    'Times Table
    'IdahoStateUniversity

    Sub Main()
        Dim Rows As Long
        Dim one As String
        Dim two As String
        Dim three As String
        Dim four As String
        Dim five As String
        Dim Six As String
        Dim Seven As String
        Dim eight As String
        Dim nine As String
        Dim ten As String
        Dim eleven As String
        Dim twelve As String


        For Rows = 1 To 12


            one = CStr(Rows * 1).PadLeft(4)
            two = CStr(Rows * 2).PadLeft(4)
            three = CStr(Rows * 3).PadLeft(4)
            four = CStr(Rows * 4).PadLeft(4)
            five = CStr(Rows * 5).PadLeft(4)
            Six = CStr(Rows * 6).PadLeft(4)
            Seven = CStr(Rows * 7).PadLeft(4)
            eight = CStr(Rows * 8).PadLeft(4)
            nine = CStr(Rows * 9).PadLeft(4)
            ten = CStr(Rows * 10).PadLeft(4)
            eleven = CStr(Rows * 11).PadLeft(4)
            twelve = CStr(Rows * 12).PadLeft(4)

            Convert.ToDecimal(one)
            Convert.ToDecimal(two)
            Convert.ToDecimal(three)
            Convert.ToDecimal(four)

            Convert.ToDecimal(five)
            Convert.ToDecimal(Six)
            Convert.ToDecimal(Seven)
            Convert.ToDecimal(eight)
            Convert.ToDecimal(nine)
            Convert.ToDecimal(ten)
            Convert.ToDecimal(eleven)
            Convert.ToDecimal(twelve)





            Console.WriteLine(one & two & three & four & five & Six & Seven & eight & nine & ten & eleven & twelve)
            Console.ReadLine()







        Next




    End Sub

End Module







Module Module1

    Sub Main()
        Dim a, b, NewA, NewB, FirstA, FirstB, Finala, Finalb, Finalstring As String
        Dim charA, charB As Char
        Dim C, D As Integer
        a = " "
        b = " "
        NewA = ""
        NewB = ""
        FirstA = " "
        FirstB = " "
        Finala = " "
        Finalb = " "
        Finalstring = " "
        charA = " "
        charB = " "
        C = 0
        D = 0

        Console.WriteLine("Enter your first string")
        a = Console.ReadLine()
        Console.WriteLine("Enter your second string")
        b = Console.ReadLine()

        For C = 3 To Len(a)
            charA = Mid(a, C, 1)
            NewA = NewA & charA

        Next

        FirstB = Left(b, 2)
        Finala = FirstB & NewA

        For D = 3 To Len(b)
            charB = Mid(b, D, 1)
            NewB = NewB & charB

        Next

        FirstA = Left(a, 2)
        Finalb = FirstA & NewB

        Finalstring = Finala & " " & Finalb

        Console.WriteLine("Your final string is: " & Finalstring)
        Console.ReadKey()


    End Sub

End Module


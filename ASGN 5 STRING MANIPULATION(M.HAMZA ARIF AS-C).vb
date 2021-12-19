Module Module1

    Sub Main()
        Dim str1 As String
        Dim charA As Char
        Dim Acounter, Ecounter, Icounter, Ocounter, Ucounter As Integer
        Dim c As Integer

        str1 = " "
        charA = " "
        Acounter = 0
        Ecounter = 0
        Icounter = 0
        Ocounter = 0
        Ucounter = 0

        c = 0

        Console.WriteLine("Enter your string")
        str1 = Console.ReadLine()

        For c = 1 To Len(str1)
            charA = Mid(str1, c, 1)
            charA = UCase(charA)

            If charA = "A" Then
                Acounter = Acounter + 1

            ElseIf charA = "E" Then
                Ecounter = Ecounter + 1

            ElseIf charA = "I" Then
                Icounter = Icounter + 1

            ElseIf charA = "O" Then
                Ocounter = Ocounter + 1

            ElseIf charA = "U" Then
                Ucounter = Ucounter + 1

            End If
        Next

        Console.WriteLine("The number of A's in your string are:  " & Acounter)
        Console.WriteLine("The number of E's in your string are:  " & Ecounter)
        Console.WriteLine("The number of I's in your string are:  " & Icounter)
        Console.WriteLine("The number of O's in your string are:  " & Ocounter)
        Console.WriteLine("The number of U's in your string are:  " & Ucounter)

        Console.ReadKey()





    End Sub

End Module
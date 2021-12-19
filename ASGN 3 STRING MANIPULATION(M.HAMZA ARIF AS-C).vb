Module Module1

    Sub Main()
        Dim str1 As String
        Dim charR, CharA, CharB As Char
        Dim alphcounter, Othcount, ncount, C, D, charcount As Integer
        alphcounter = 0
        Othcount = 0
        ncount = 0
        charcount = 0
        C = 0
        D = 0
        charR = " "
        CharA = " "
        CharB = " "


        Console.WriteLine("Enter your string")
        str1 = Console.ReadLine()

        Console.WriteLine("Enter the character in your string for which the count is to be known.")
        CharA = Console.ReadLine()

        For D = 1 To Len(str1)
            CharB = Mid(str1, D, 1)
            If CharA = CharB Then
                charcount = charcount + 1
            End If
        Next

        For C = 1 To Len(str1)
            charR = Mid(str1, C, 1)

            If charR >= "A" And charR <= "Z" Or charR >= "a" And charR <= "z" Then
                alphcounter = alphcounter + 1

            ElseIf charR >= "0" And charR <= "9" Then
                ncount = ncount + 1

            Else
                Othcount = Othcount + 1
            End If
        Next
        Console.WriteLine("The seleted character count is: " & charcount)

        Console.WriteLine("Number of other characters are: " & Othcount)

        Console.WriteLine("Number of digits are: " & ncount)

        Console.WriteLine("Number of alphabets are: " & alphcounter)

        Console.ReadKey()
    End Sub

End Module

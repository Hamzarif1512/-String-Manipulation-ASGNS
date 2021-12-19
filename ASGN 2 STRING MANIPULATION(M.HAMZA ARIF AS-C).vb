Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim charA, charB, charC As Char
        Dim C As Integer

        str1 = " "
        str2 = " "
        C = 0
        charA = " "
        charB = " "
        charC = " "

        Console.WriteLine("please enter your string")
        str1 = Console.ReadLine()
        Console.WriteLine("enter the character which you would like to be replaced")
        charA = Console.ReadLine()
        Console.WriteLine("enter the character you would like to replace with")
        charC = Console.ReadLine()

        For C = 1 To Len(str1)
            charB = Mid(str1, C, 1)

            If charA = charB Then
                str2 = str2 & charC
            Else
                str2 = str2 & charB
            End If
        Next
        Console.WriteLine("this is your new string: " & str2)

        Console.ReadKey()

    End Sub

End Module








       




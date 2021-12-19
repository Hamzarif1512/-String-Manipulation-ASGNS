Module Module1

    Sub Main()
        Dim str1, str2, Finalstring As String
        str1 = " "
        str2 = " "
        Finalstring = " "

        Console.WriteLine(" Please enter a string")
        str1 = Console.ReadLine()

        If Len(str1) < 3 Then
            Console.WriteLine("Your final string is: " & str1)
            Console.ReadKey()
        Else
            str2 = Right(str1, 3)
            If "ing" = str2 Then
                Finalstring = str1 & "ly"
            Else
                Finalstring = str1 & "ing"

            End If
            Console.WriteLine("Your final string is: " & Finalstring)

        End If
        Console.ReadKey()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim s, str2, str3, finalstring As String
        s = " "
        str2 = " "
        str3 = " "
        finalstring = " "

        Console.WriteLine("Please enter your string.")
        s = Console.ReadLine

        If Len(s) > 2 Then
            str2 = Left(s, 2)
            str3 = Right(s, 2)
            finalstring = str2 & str3
            Console.WriteLine("Your final string is: " & finalstring)
            Console.ReadKey()

        Else
            Console.WriteLine("Your final string is: " & s)
            Console.ReadKey()
        End If
    End Sub

End Module

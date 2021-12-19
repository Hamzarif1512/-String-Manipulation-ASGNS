Module Module1

    Sub Main()
        Dim Str1, NOTlocator, BADlocator, textselect1, textselect2, finalstring As String
        Dim C As Integer
        Str1 = " "
        NOTlocator = " "
        BADlocator = " "
        textselect1 = " "
        textselect2 = " "
        finalstring = " "
        C = 0

        Console.WriteLine("Please enter your string.")
        Str1 = Console.ReadLine()
        Str1 = LCase(Str1)
        NOTlocator = InStr(Str1, "not ")
        BADlocator = InStr(Str1, "bad ") Or InStr(Str1, "bad")

        If NOTlocator < BADlocator Then

            For C = 1 To (NOTlocator - 1)
                textselect1 = Left(Str1, C)
            Next

            textselect2 = Mid(Str1, BADlocator + 3)


            
            finalstring = textselect1 & "good" & textselect2

            Console.WriteLine("Your new string is: " & finalstring)
            Console.ReadKey()
        Else
            Console.WriteLine("WRONG STRING ENTERED. Ensure that BAD follows NOT in your string.")
            Console.ReadKey()
        End If
    End Sub

End Module
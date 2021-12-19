Module Module1

    Sub Main()
        Dim str1, str3 As String
        Dim charA, selectchar, finalchar As Char
        Dim charcount, maxcount, C, D As Integer

        str1 = " "
        str3 = " "
        charA = " "
        selectchar = " "
        finalchar = " "
        C = 0
        D = 0
        charcount = 0
        maxcount = -100000
        

        Console.WriteLine("Please enter your string.")
        str1 = Console.ReadLine()

        For C = 1 To Len(str1)
            charA = Mid(str1, C, 1)
            charcount = 0
            For D = 1 To Len(str1)

                selectchar = Mid(str1, D, 1)
                If charA = selectchar Then
                    charcount = charcount + 1
                End If
            Next D
            If charcount > maxcount Then
                maxcount = charcount
                finalchar = charA


            End If

        Next C

        Console.WriteLine("The most repeated character in your string is: " & finalchar)
        Console.ReadKey()
    End Sub

End Module

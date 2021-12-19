Module Module1

    Sub Main()
        Dim s, Finalstring As String
        Dim Initialchar, Selectchar As Char
        s = " "
        Finalstring = " "
        Initialchar = " "
        Selectchar = " "


        Console.WriteLine("Please enter your string.")
        s = Console.ReadLine()
        Initialchar = Left(s, 1)
        Finalstring = Finalstring & Initialchar

        For C = 2 To Len(s)
            Selectchar = Mid(s, C, 1)

            If Selectchar = Initialchar Then
                Selectchar = "*"
                Finalstring = Finalstring & selectchar


            Else
                Finalstring = Finalstring & selectchar

            End If
        Next

        Console.WriteLine("Your final string is: " & Finalstring)
        Console.ReadKey()
    End Sub

End Module

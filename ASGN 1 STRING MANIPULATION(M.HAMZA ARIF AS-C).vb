Module Module1

    Sub Main()
        Dim str1 As String
        Dim ispangram As Boolean
        Dim str2 As String
        Dim C As Integer
        Dim charA As Char

        str1 = " "
        str2 = "abcdefghijklmnopqrstuvwxyz"
        ispangram = True
        C = 0
        charA = " "

        Console.WriteLine("kindly enter your string")
        str1 = Console.ReadLine()
        str1 = LCase(str1)
        For C = 1 To Len(str2)


            charA = Mid(str2, C, 1)
            If InStr(str1, charA) = 0 Then
                ispangram = False
            End If
        Next


        If ispangram = True Then


            Console.WriteLine("Your string contains all the alphabets")
            Console.ReadKey()
        Else
            Console.WriteLine("your string does not contain all the alphabets.")
            Console.ReadKey()
        End If





    End Sub

End Module





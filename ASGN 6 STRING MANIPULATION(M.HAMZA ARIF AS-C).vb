Module Module1

    Sub Main()
        Dim Donutcount As Integer
        Donutcount = 0

        Console.WriteLine("Welcome! Please enter the number of donuts you would like to purchase.")
        Donutcount = Console.ReadLine()

        If Donutcount >= 10 Then
            Console.WriteLine("Number of Donuts: Many")
            Console.ReadKey()
        Else
            Console.WriteLine("Number of Donuts: " & Donutcount)
            Console.ReadKey()
        End If
    End Sub

End Module


                                           



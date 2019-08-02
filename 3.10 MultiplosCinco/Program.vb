Imports System

Module MultiplosCinco
    Sub Main(args As String())
        Dim multiplos1, multiplos2, n1, n2 As Integer
        Dim n = 5

        Console.WriteLine("Ingresar un numero: ")
        n1 = Console.ReadLine()

        Console.WriteLine("Ingresar otro numero: ")
        n2 = Console.ReadLine()

        Do While n1 And n2 <> 0
            For a = 1 To 10 Step 1
                multiplos1 = n1 * n
                multiplos2 = n2 * n
                Console.WriteLine("Multiplos de 5 entre estos numeros: " & multiplos1, multiplos2)
            Next
            Exit Do
        Loop

    End Sub
End Module

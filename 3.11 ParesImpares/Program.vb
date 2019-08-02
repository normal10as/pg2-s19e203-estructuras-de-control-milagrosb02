Imports System

Module Program
    Sub Main(args As String())
        Dim pares, impares As Integer
        Dim x As Integer = 1

        Do While x > 0
            Console.WriteLine("Ingresar numero: ")
            x = Console.ReadLine()
            If (x Mod 2 = 0) Then
                pares = pares + 1
            Else
                impares = impares + 1
            End If
        Loop

        Console.WriteLine("Cantidad de pares: " & pares)
        Console.WriteLine("Cantidad de impares: " & impares)





    End Sub
End Module

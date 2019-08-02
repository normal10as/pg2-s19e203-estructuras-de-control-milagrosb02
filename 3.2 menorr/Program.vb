Imports System

Module Menor
    Sub Main(args As String())
        Dim A, C, S As Byte

        Console.WriteLine("Ingresar primer numero: ")
        A = Console.ReadLine()

        Console.WriteLine("Ingresar segundo numero: ")
        C = Console.ReadLine()

        Console.WriteLine("Ingresar tercer numero: ")
        S = Console.ReadLine()

        If A < C And A < S Then
            Console.WriteLine("El menor es: " & A)
        End If
        If C < A And C < S Then
            Console.WriteLine("El menor es: " & C)
        End If
        If S < A And S < C Then
            Console.WriteLine("El menor es: " & S)
        End If
    End Sub
End Module

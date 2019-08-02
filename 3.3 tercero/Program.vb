Imports System

Module Tercero
    Sub Main(args As String())
        Dim M, B, G, S, T As Integer

        Console.WriteLine("Ingresar valor 1: ")
        M = Console.ReadLine()

        Console.WriteLine("Ingresar valor 2: ")
        B = Console.ReadLine()

        Console.WriteLine("Ingresar valor 3: ")
        G = Console.ReadLine()

        Console.WriteLine("Ingresar valor 4: ")
        S = Console.ReadLine()

        Console.WriteLine("Ingresar valor 5: ")
        T = Console.ReadLine()

        If M > B And M > G And M > S And M > T Then
            Console.WriteLine("El mayor valor es el primero: " & M)
        End If
        If B > M And B > G And B > S And B > T Then
            Console.WriteLine("El mayor valor es el segundo: " & B)
        End If
        If G > M And G > B And G > S And G > T Then
            Console.WriteLine("El mayor valor es el tercero: " & G)
        End If
        If S > M And S > B And S > G And S > T Then
            Console.WriteLine("El mayor valor es el cuarto: " & S)
        End If
        If T > M And T > B And T > G And T > S Then
            Console.WriteLine("El mayor valor es el quinto: " & T)
        End If
    End Sub
End Module

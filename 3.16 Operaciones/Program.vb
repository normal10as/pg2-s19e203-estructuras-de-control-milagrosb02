Imports System

Module Operaciones
    Enum Valores
        N1 = 1
        N2
        N3
        N4
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Suma: " & Suma(Operaciones.Suma 5, 7))
    End Sub

    Function Suma(N1, N4)
        Return N1 + N4
    End Function

    Function Multiplicacion(N2, N3, N4)
        Return N2 * N3 * N4
    End Function

    Function Division(N1, N4)
        Return N1 / N4
    End Function
End Module

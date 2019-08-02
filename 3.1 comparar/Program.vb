Imports System

Module comparar
    Sub Main(args As String())
        Dim A, B As Integer

        A = IngresarDato("Ingresar un valor: ")
        B = IngresarDato("Ingresar otro valor: ")


        If A > B Then
            Console.WriteLine(": " & A)
        ElseIf A = B Then
            Console.WriteLine("Estos numeros son iguales: " & A & B)
        Else
            Console.WriteLine("0 es igual que 1", A, B)
        End If

    End Sub

    Private Function IngresarDato(mensaje As String) As Integer
        Dim c As Integer = Console.ReadLine()
        Return c
    End Function
End Module

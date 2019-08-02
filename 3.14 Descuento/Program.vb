Imports System

Module Descuento
    Sub Main(args As String())
        Dim precio, total, descuento As Decimal
        Dim cantidad As Integer = 1

        Do While cantidad <> 0
            Console.Write("Ingresar cantidad de articulo: ")
            cantidad = Console.ReadLine()
            Console.Write("Ingresar precio unitario: ")
            precio = Console.ReadLine()
            Select Case cantidad
                Case 10 To 50
                    descuento = 0.5

                Case 51 To 250
                    descuento = 0.1

                Case Is > 251
                    descuento = 0.2

            End Select
            total = cantidad * precio
            Console.WriteLine("el sub total es: " & total)
            Console.WriteLine("el descuento es {0}%: {1}", descuento * 100, total * descuento)
            total -= total * descuento
            Console.WriteLine("el total es: " & total)
        Loop

    End Sub
End Module

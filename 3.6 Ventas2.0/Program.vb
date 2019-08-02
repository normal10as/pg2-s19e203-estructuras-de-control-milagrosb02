Imports System

Module Ventas20
    Sub Main(args As String())
        Dim cantidad As Byte
        Dim precio, descuento, total As Decimal

        Console.Write("Ingresar la cantidad: ")
        cantidad = Console.ReadLine()

        Console.Write("Ingresar el precio unitario: ")
        precio = Console.ReadLine()

        Select Case cantidad
            Case 10 To 50
                descuento = 0.5

            Case 51 To 250
                descuento = 0.1

            Case Is > 250
                descuento = 0.2
        End Select
        total = cantidad * precio
        Console.WriteLine("el sub total es: " & total)
        Console.WriteLine("el descuento es {0}%: {1}", descuento * 100, total * descuento)
        total -= total * descuento
        Console.WriteLine("el total es: " & total)

    End Sub
End Module

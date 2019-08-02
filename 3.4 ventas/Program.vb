Imports System

Module Ventas
    Sub Main(args As String())
        Dim cantidad As Byte
        Dim precio, total, descuento As Decimal

        Console.Write("Ingresar la cantidad: ")
        cantidad = Console.ReadLine()

        Console.Write("Ingresar el precio unitario: ")
        precio = Console.ReadLine()

        If cantidad = 10 And 50 Then
            descuento = 0.2

        ElseIf cantidad = 51 And 250 Then
            descuento = 0.1

        ElseIf cantidad > 251 Then
            descuento = 0.05
        End If

        total = cantidad * precio
        Console.WriteLine("el sub total es: " & total)
        Console.WriteLine("el descuento es {0}%: {1}", descuento * 100, total * descuento)
        total -= total * descuento
        Console.WriteLine("el total es: " & total)


    End Sub
End Module

Imports System

Module Angulo
    Sub Main(args As String())
        Dim tamanio As Integer
        Console.WriteLine("Ingresar tamaño del angulo en grados: ")
        tamanio = Console.ReadLine()

        Select Case tamanio
            Case 0 To 90
                Console.WriteLine("Es un angulo agudo")

            Case 90
                Console.WriteLine("Es un angulo recto")

            Case 90 To 180
                Console.WriteLine("Es un angulo obtuso")

            Case 4
                If tamanio = 180 Then
                    Console.WriteLine("Es un angulo llano")
                End If
            Case 5
                If tamanio > 180 And tamanio < 360 Then
                    Console.WriteLine("Es un angulo concavo")
                End If
            Case 6
                If tamanio < 0 Or tamanio > 360 Then
                    Console.WriteLine("Error")
                End If

        End Select
    End Sub
End Module

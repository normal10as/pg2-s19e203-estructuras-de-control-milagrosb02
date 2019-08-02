Imports System

Module Deposito
    Sub Main(args As String())
        Const interesanual As Single = 36.0
        Dim mes As UShort
        Dim capital, interes, saldo, totalinteres, tasamensual As Decimal

        Console.Write("Ingresar capital inicial: ")
        capital = Console.ReadLine()

        Console.Write("Ingresar cantidad de meses: ")
        mes = Console.ReadLine()

        Informe("MES | CAPITAL | INTERES | SALDO")
        tasamensual = interesanual / 12

        For Nmeses = 1 To mes
            interes = capital * tasamensual
            saldo = capital + tasamensual
            Console.WriteLine(Nmeses & "      " & capital & "     " & interes & "    " & saldo)
            totalinteres += interes
            capital = saldo
        Next
        Console.WriteLine("Interes ganado: " & totalinteres)

    End Sub
    Private Sub Informe(mensaje1)
        Console.WriteLine(mensaje1)
    End Sub
End Module

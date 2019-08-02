Imports System

Module DiaMes
    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main(args As String())
        Dim mes As Byte
        Dim anio As UShort
        Console.Write("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case Meses.Febrero
                Console.Write("Indique el a�o: ")
                anio = Console.ReadLine()
                If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then

                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
            Case Meses.Enero, Meses.Marzo, Meses.Mayo, Meses.Julio, Meses.Agosto, Meses.Octubre, Meses.Diciembre
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.Abril, Meses.Junio, Meses.Septiembre, Meses.Noviembre
                Console.WriteLine("El mes tiene 30 dias")
            Case Else
                Console.WriteLine("mes incorrecto.")
        End Select


    End Sub
End Module

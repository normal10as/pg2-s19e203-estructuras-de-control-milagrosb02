Imports System

Module NombreMes
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
        Console.Write("Ingresar valor numerico: ")
        mes = Console.ReadLine()

        Select Case mes
            Case Meses.Enero
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Enero)
            Case Meses.Febrero
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Febrero)
            Case Meses.Marzo
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Marzo)
            Case Meses.Abril
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Abril)
            Case Meses.Mayo
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Mayo)
            Case Meses.Junio
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Junio)
            Case Meses.Julio
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Julio)
            Case Meses.Agosto
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Agosto)
            Case Meses.Septiembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Septiembre)
            Case Meses.Octubre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Octubre)
            Case Meses.Noviembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Noviembre)
            Case Meses.Diciembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", mes, Meses.Diciembre)
            Case Else
                Console.WriteLine("El numero de mes ingresado es incorrecto")
        End Select

    End Sub


End Module

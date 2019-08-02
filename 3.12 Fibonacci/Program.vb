Imports System

Module Program
    Sub Main(args As String())
        Dim primero As Integer = 0
        Dim segundo As Integer = 1

        For c = 0 To 6000
            c = primero + segundo
            primero = segundo
            segundo = c
            Console.WriteLine(c)
        Next c
    End Sub
End Module

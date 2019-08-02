Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Dim i As Integer
        Dim b As Boolean
        For n = 1 To 999
            b = True
            For i = 2 To Math.Sqrt(n)
                If n Mod i = 0 Then
                    b = False
                    Exit For
                End If
            Next
            If b Then
                Console.WriteLine(n)
            End If
        Next




    End Sub
End Module

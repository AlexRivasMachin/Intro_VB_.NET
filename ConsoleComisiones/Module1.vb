Module Module1

    Sub Main()
        Dim c As New Comisiones__Labo_1___Alex_Rivas.Ventas
        Console.WriteLine("Ingrese el total de ventas")
        Dim tv As Integer = Console.ReadLine
        Console.WriteLine("Ingrese el numero de ventas")
        Dim nv As Integer = Console.ReadLine
        Console.WriteLine("La comision es: " & c.comision(tv, nv))
        Console.ReadKey()

    End Sub

End Module

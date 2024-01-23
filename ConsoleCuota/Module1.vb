Module Module1

    Sub Main()
        Dim c As New CuotaAnual.Cuota
        Console.WriteLine("Inglrese el capital total")
        Dim cap As Integer = Console.ReadLine
        Console.WriteLine("Ingrese el plazo")
        Dim p As Integer = Console.ReadLine
        Console.WriteLine("Ingrese el interes")
        Dim i As Integer = Console.ReadLine
        Console.WriteLine("La comision es: " & c.cuotaAnual(cap, p, i))
        Console.ReadKey()

    End Sub

End Module

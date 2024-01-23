Public Class Ventas
    Public Property TotalVentas As Integer = 1000000.0
    Public Property NumeroVentas As Integer = 10000
    Public Function Comision() As Single
        Comision = TotalVentas * 0.025 + ((TotalVentas / NumeroVentas) * 0.05)
    End Function
End Class

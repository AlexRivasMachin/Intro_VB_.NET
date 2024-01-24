Public Class Ventas
    Public Property TotalVentas As Single = 1000000
    Public Property NumeroVentas As Integer = 10000
    Public Function comision() As Single
        comision = TotalVentas * 0.025 + ((TotalVentas / NumeroVentas) * 0.05)
    End Function
    Public Function comision(ByVal TotalVentas As Single, ByVal NumeroVentas As Integer) As Double
        comision = TotalVentas * 0.025 + ((TotalVentas / NumeroVentas) * 0.05)
    End Function

End Class
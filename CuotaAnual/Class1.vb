Public Class Cuota
    Public Property Capital As Integer = 1800000.0
    Public Property Plazo As Integer = 30
    Public Property Interes As Double = 0.012

    Public Function CuotaAnual() As Double
        CuotaAnual = Capital * Interes / (1 - (1 + Interes) ^ -Plazo)
    End Function
End Class

Public Class Cuota
    Public Property Capital As Integer = 1800000.0
    Public Property Plazo As Integer = 30
    Public Property Interes As Integer = 0.012

    Public Function cuotaAnual() As Single
        cuotaAnual = Capital * Interes / (1 - (1 + Interes) ^ -Plazo)
    End Function

    Public Function cuotaAnual(ByVal Capital As Integer, ByVal Plazo As Integer, ByVal Interes As Double) As Single
        cuotaAnual = Capital * Interes / (1 - (1 + Interes) ^ -Plazo)
    End Function
End Class

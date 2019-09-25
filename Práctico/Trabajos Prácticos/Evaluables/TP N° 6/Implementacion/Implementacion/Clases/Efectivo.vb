Public Class Efectivo
    Inherits TipoPago

    Private montoPago As Decimal

    Public Sub New(montoTotal As Decimal, montoPago As Decimal)
        MyBase.New(montoTotal)
        Me.montoPago = montoPago
    End Sub

    Public Property MontoPago1 As Decimal
        Get
            Return montoPago
        End Get
        Set(value As Decimal)
            montoPago = value
        End Set
    End Property

    Function saldoRestante() As Decimal
        Return MyBase.MontoTotal1 - Me.montoPago
    End Function


    Public Overrides Function ToString() As String
        Return MyBase.ToString + " - Monto a Pagar: $" + Me.montoPago + " - Monto Restante: $" + saldoRestante()
    End Function
End Class

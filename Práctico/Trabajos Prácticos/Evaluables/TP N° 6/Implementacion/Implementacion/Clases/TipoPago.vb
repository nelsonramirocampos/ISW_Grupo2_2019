Public Class TipoPago
    Private montoTotal As Decimal

    Public Sub New(montoTotal As Decimal)
        Me.montoTotal = montoTotal
    End Sub

    Public Property MontoTotal1 As Decimal
        Get
            Return montoTotal
        End Get
        Set(value As Decimal)
            montoTotal = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Monto total: $" + Me.montoTotal
    End Function
End Class

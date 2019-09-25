Imports Implementacion

Public Class Detalle_Pedido
    Private local As Comercio
    Private item As Producto
    Private cantidad As Integer
    Private subTotal As Decimal


    Public Sub New(local As Comercio, item As Producto, cantidad As Integer, subTotal As Decimal)
        Me.local = local
        Me.item = item
        Me.cantidad = cantidad
        Me.subTotal = subTotal
    End Sub

    Public Property Local1 As Comercio
        Get
            Return local
        End Get
        Set(value As Comercio)
            local = value
        End Set
    End Property

    Public Property Item1 As Producto
        Get
            Return item
        End Get
        Set(value As Producto)
            item = value
        End Set
    End Property

    Public Property Cantidad1 As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    Public Property SubTotal1 As Decimal
        Get
            Return subTotal
        End Get
        Set(value As Decimal)
            subTotal = value
        End Set
    End Property

End Class

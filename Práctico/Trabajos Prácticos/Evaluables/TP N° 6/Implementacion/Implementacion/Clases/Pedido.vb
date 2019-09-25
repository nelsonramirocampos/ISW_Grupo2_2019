Imports Implementacion

Public Class Pedido

    Private detalles As List(Of Detalle_Pedido)
    Private total As Decimal
    Private direccion As Direccion
    Private fechaHora As TiempoEnvio


    Public Sub New()
    End Sub

    Public Sub New(detalles As List(Of Detalle_Pedido), total As Decimal)
        Me.detalles = detalles
        Me.total = total
    End Sub

    Public Property Detalles1 As List(Of Detalle_Pedido)
        Get
            Return detalles
        End Get
        Set(value As List(Of Detalle_Pedido))
            detalles = value
        End Set
    End Property

    Public Property Total1 As Decimal
        Get
            Return total
        End Get
        Set(value As Decimal)
            total = value
        End Set
    End Property

    Public Property Direccion1 As Direccion
        Get
            Return direccion
        End Get
        Set(value As Direccion)
            direccion = value
        End Set
    End Property

    Public Property FechaHora1 As TiempoEnvio
        Get
            Return fechaHora
        End Get
        Set(value As TiempoEnvio)
            fechaHora = value
        End Set
    End Property

    Public Sub agregarDetalle(detalle As Detalle_Pedido)
        If detalles Is Nothing Then
            detalles = New List(Of Detalle_Pedido)
        End If

        If detalle IsNot Nothing Then
            detalles.Add(detalle)
        End If
    End Sub
End Class

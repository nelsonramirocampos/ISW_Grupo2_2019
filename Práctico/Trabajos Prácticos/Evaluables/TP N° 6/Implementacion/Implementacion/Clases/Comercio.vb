Imports Implementacion

Public Class Comercio
    Private idComercio As Integer
    Private nombre As String
    Private productos As List(Of Producto)

    Public Sub New(idComercio As Integer, nombre As String)
        Me.IdComercio1 = idComercio
        Me.Nombre1 = nombre
        Me.Productos1 = New List(Of Producto)
    End Sub

    Public Property IdComercio1 As Integer
        Get
            Return idComercio
        End Get
        Set(value As Integer)
            idComercio = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Productos1 As List(Of Producto)
        Get
            Return productos
        End Get
        Set(value As List(Of Producto))
            productos = value
        End Set
    End Property

    Sub agregarProducto(p As Producto)
        Me.productos.Add(p)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre1
    End Function
End Class

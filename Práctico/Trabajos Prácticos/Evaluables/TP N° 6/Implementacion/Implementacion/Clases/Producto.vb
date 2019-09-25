Public Class Producto
    Private idProducto As Integer
    Private nombre As String
    Private precio As Decimal
    Private imagen As String 'ruta donde se encuentra la imagen

    Public Sub New(idProducto As Integer, nombre As String, precio As Decimal, imagen As String)
        Me.idProducto = idProducto
        Me.nombre = nombre
        Me.precio = precio
        Me.imagen = imagen
    End Sub

    Public Property IdProducto1 As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
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

    Public Property Precio1 As Decimal
        Get
            Return precio
        End Get
        Set(value As Decimal)
            precio = value
        End Set
    End Property

    Public Property Imagen1 As String
        Get
            Return imagen
        End Get
        Set(value As String)
            imagen = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.nombre + " - $" + Me.precio.ToString
    End Function
End Class

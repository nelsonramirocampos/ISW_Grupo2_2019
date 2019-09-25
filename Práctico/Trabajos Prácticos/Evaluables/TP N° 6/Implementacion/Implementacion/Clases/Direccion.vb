Public Class Direccion
    Private calle As String
    Private nro As Integer
    Private ciudad As String
    Private referencia As String

    Public Sub New(calle As String, nro As Integer, ciudad As String, referencia As String)
        Me.calle = calle
        Me.nro = nro
        Me.ciudad = ciudad
        Me.referencia = referencia
    End Sub

    Public Sub New()
    End Sub

    Public Property Calle1 As String
        Get
            Return calle
        End Get
        Set(value As String)
            calle = value
        End Set
    End Property

    Public Property Nro1 As Integer
        Get
            Return nro
        End Get
        Set(value As Integer)
            nro = value
        End Set
    End Property

    Public Property Ciudad1 As String
        Get
            Return ciudad
        End Get
        Set(value As String)
            ciudad = value
        End Set
    End Property

    Public Property Referencia1 As String
        Get
            Return referencia
        End Get
        Set(value As String)
            referencia = value
        End Set
    End Property
End Class

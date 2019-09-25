Public Class Tarjeta
    Inherits TipoPago

    Private nroTarjeta As String
    Private nombreTitular As String
    Private apellidoTitular As String
    Private fechaVencimiento As Date
    Private cvc As Integer


    Public Sub New(montoTotal As Decimal, nroTarjeta As String, nombreTitular As String, apellidoTitular As String, fechaVencimiento As Date, cvc As Integer)
        MyBase.New(montoTotal)

        Me.nroTarjeta = nroTarjeta
        Me.nombreTitular = nombreTitular
        Me.apellidoTitular = apellidoTitular
        Me.fechaVencimiento = fechaVencimiento
        Me.cvc = cvc
    End Sub

    Public Property NroTarjeta1 As String
        Get
            Return nroTarjeta
        End Get
        Set(value As String)
            nroTarjeta = value
        End Set
    End Property

    Public Property NombreTitular1 As String
        Get
            Return nombreTitular
        End Get
        Set(value As String)
            nombreTitular = value
        End Set
    End Property

    Public Property ApellidoTitular1 As String
        Get
            Return apellidoTitular
        End Get
        Set(value As String)
            apellidoTitular = value
        End Set
    End Property

    Public Property FechaVencimiento1 As Date
        Get
            Return fechaVencimiento
        End Get
        Set(value As Date)
            fechaVencimiento = value
        End Set
    End Property

    Public Property Cvc1 As Integer
        Get
            Return cvc
        End Get
        Set(value As Integer)
            cvc = value
        End Set
    End Property


End Class

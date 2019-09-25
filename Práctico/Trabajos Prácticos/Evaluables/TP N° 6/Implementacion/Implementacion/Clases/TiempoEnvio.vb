Public Class TiempoEnvio
    Private nombre As String
    Private fechaHora As DateTime

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property FechaHora1 As Date
        Get
            Return fechaHora
        End Get
        Set(value As Date)
            fechaHora = value
        End Set
    End Property

    Public Sub New(nombre As String, fechaHora As Date)
        Me.Nombre1 = nombre
        Me.FechaHora1 = fechaHora
    End Sub
End Class

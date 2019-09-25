Public Class FormaPago
    Private pedidoCompleto As Pedido

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(pedidoCompleto As Pedido)
        Me.New()

        Me.pedidoCompleto = pedidoCompleto
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("¿Desea cancelar el Pedido?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub FormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.Hide()
        Dim frm As DatosEnvio = New DatosEnvio(pedidoCompleto)
        frm.ShowDialog()
        Me.Close()

    End Sub
End Class
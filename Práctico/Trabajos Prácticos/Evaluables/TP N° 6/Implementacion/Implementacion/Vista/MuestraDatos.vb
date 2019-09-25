Public Class MuestraDatos
    Private pedidoCompleto As Pedido

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(pedidoCompleto As Pedido)
        Me.New()

        Me.pedidoCompleto = pedidoCompleto
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        MessageBox.Show("Pedido Confirmado")
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("¿Desea cancelar el Pedido?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MuestraDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaDatos()
    End Sub

    Private Sub cargaDatos()
        txtCiudad.Text = Me.pedidoCompleto.Direccion1.Ciudad1
        txtCalle.Text = Me.pedidoCompleto.Direccion1.Calle1
        txtNro.Text = Me.pedidoCompleto.Direccion1.Nro1
        txtReferencia.Text = Me.pedidoCompleto.Direccion1.Referencia1


        txtFecha.Text = Me.pedidoCompleto.FechaHora1.FechaHora1.Date
        txtHora.Text = Me.pedidoCompleto.FechaHora1.FechaHora1.TimeOfDay.ToString


        If TypeOf Me.pedidoCompleto.TipoPago1 Is Efectivo Then
            rbEfectivo.Checked = True

            Dim pago As Efectivo = Me.pedidoCompleto.TipoPago1
            txtMonto.Text = pago.MontoPago1
            txtVuelto.Text = Math.Abs(pago.saldoRestante)
        ElseIf TypeOf Me.pedidoCompleto.TipoPago1 Is Tarjeta Then
            rbTarjeta.Checked = True

            Dim pago As Tarjeta = Me.pedidoCompleto.TipoPago1
            txtNombreTitular.Text = pago.NombreTitular1
            txtApellidoTitular.Text = pago.ApellidoTitular1
            txtNroTarjeta.Text = pago.NroTarjeta1
            txtFechaVencimiento.Text = pago.FechaVencimiento1.Month.ToString + "/" + pago.FechaVencimiento1.Year.ToString
            txtCvc.Text = pago.Cvc1
        End If


        For Each dp As Detalle_Pedido In Me.pedidoCompleto.Detalles1
            Dim p As Producto = dp.Item1

            dgvDetallePedido.Rows.Add(p.Nombre1, p.Precio1, dp.Cantidad1, dp.SubTotal1)
        Next

        txtTotal.Text = Me.pedidoCompleto.Total1
    End Sub
End Class
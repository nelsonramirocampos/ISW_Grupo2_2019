Public Class TiempoRecepcion
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

    Private Sub TiempoRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Radio button Lo antes posible seleccionado por default
        rdoAntesPosible.Checked = True
        txtFecha.Enabled = False
        txtHora.Enabled = False
    End Sub

    Private Sub rdoFechaHora_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFechaHora.CheckedChanged
        txtFecha.Enabled = True
        txtHora.Enabled = True

        'Hardcodeado: Agrega 30 min a la hora actual
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = DateTime.Now.AddMinutes(30).ToShortTimeString()
    End Sub

    Private Sub rdoAntesPosible_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAntesPosible.CheckedChanged
        txtFecha.Enabled = False
        txtHora.Enabled = False
        txtFecha.Text = ""
        txtHora.Text = ""
    End Sub

    Private Sub txtHora_Leave(sender As Object, e As EventArgs) Handles txtHora.Leave

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fechaHora As DateTime

        'Harcodeado 30 min a partir de ahora
        Dim fechaHoraValida = DateTime.Now.AddMinutes(30)
        fechaHora = fechaHoraValida

        'Si el boton ingresar una fechaHora esta chequeado utilizo esa
        If rdoFechaHora.Checked Then
            Dim fecha As String() = txtFecha.Text.Split(New Char() {"/"c})
            Dim hora As String() = txtHora.Text.Split(New Char() {":"c})
            fechaHora = New DateTime(Convert.ToInt32(fecha(2)), Convert.ToInt32(fecha(1)), Convert.ToInt32(fecha(0)), Convert.ToInt32(hora(0)), Convert.ToInt32(hora(1)), 59)

            'Comparo la fechaHora con la fechaHora válida
            Dim comparación As Int16 = DateTime.Compare(fechaHora, fechaHoraValida)
            If (comparación < 0) Then
                MsgBox("La fecha y/o hora son inválidas")
                Exit Sub
                'Acá cancela el proceso y pide que ingrese nueva fecha/hora
            End If

            Me.pedidoCompleto.FechaHora1 = New TiempoEnvio(rdoFechaHora.Text, fechaHora)

        Else
            Me.pedidoCompleto.FechaHora1 = New TiempoEnvio(rdoAntesPosible.Text, fechaHora)
        End If


        'finalizacion()

        Me.Hide()
        Dim frm As MuestraDatos = New MuestraDatos(Me.pedidoCompleto)
        frm.ShowDialog()
        Me.Close()

    End Sub

    Private Sub finalizacion()
        Dim result As Integer = MessageBox.Show("¿Confirmar Pedido?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MessageBox.Show("Pedido confirmado. Llegara en " + pedidoCompleto.FechaHora1.FechaHora1)
            Me.Close()
        End If
    End Sub
End Class
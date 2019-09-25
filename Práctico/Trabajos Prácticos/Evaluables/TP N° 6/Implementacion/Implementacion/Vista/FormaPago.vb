Public Class frmFormaPago
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
        txtMontoTotal.Text = Me.pedidoCompleto.Total1
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim pago As TipoPago

        If rdoEfectivo.Checked = True Then
            If String.IsNullOrEmpty(txtMonto.Text) Then
                MessageBox.Show("Debe ingresar el monto a abonar")
                Exit Sub
            End If

            Dim montoTotal As Decimal = Decimal.Parse(txtMontoTotal.Text)
            Dim monto As Decimal = Decimal.Parse(txtMonto.Text)

            If montoTotal > monto Then
                MessageBox.Show("El monto ingresado es menor al monto total")
                Exit Sub
            End If

            pago = New Efectivo(montoTotal, monto)
        Else
            If String.IsNullOrEmpty(mtxNroTarjeta.Text) Then
                MessageBox.Show("Debe ingresar el numero de tarjeta")
                Exit Sub
            Else
                If mtxNroTarjeta.Text.Count < 16 Then
                    MessageBox.Show("El numero de tarjeta debe ser de 16 digitos")
                    Exit Sub
                End If
            End If
            If String.IsNullOrEmpty(txtNombreTitular.Text) Then
                MessageBox.Show("Debe ingresar el nombre del titular de la tarjeta")
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtApellidoTitular.Text) Then
                MessageBox.Show("Debe ingresar el apellido del titular de la tarjeta")
                Exit Sub
            End If
            If mtxFechaVencimiento.MaskCompleted = False Then
                MessageBox.Show("Debe ingresar la fecha de vencimiento de la tarjeta")
                Exit Sub
            Else
                Dim fecha As Date = Date.Parse(mtxFechaVencimiento.Text)
                If mtxFechaVencimiento.Text.Substring(0, 2) > 12 And mtxFechaVencimiento.Text.Substring(0, 2) < 1 Then
                    MessageBox.Show("El mes de la fecha es incorrecto")
                    Exit Sub
                End If
                If mtxFechaVencimiento.Text.Substring(3) < Now.Year Then
                    MessageBox.Show("El año de la fecha es incorrecta")
                    Exit Sub
                End If

            End If
            If String.IsNullOrEmpty(mtxCvc.Text) Then
                MessageBox.Show("Debe ingresar el cvc de la tarjeta")
                Exit Sub
            Else
                If mtxCvc.Text.Count < 3 Then
                    MessageBox.Show("El cvc debe ser de 3 digitos")
                    Exit Sub
                End If
            End If

            Dim auxiliar As String = mtxNroTarjeta.Text.Substring(0, 1)
            If auxiliar <> "4" Then
                MessageBox.Show("Solo se acepta tarjeta Visa")
                Exit Sub
            End If

            Dim montoTotal As Decimal = Decimal.Parse(txtMontoTotal.Text)
            Dim nroTarjeta As String = mtxNroTarjeta.Text
            Dim nombreTitular As String = txtNombreTitular.Text
            Dim apellidoTitular As String = txtApellidoTitular.Text
            Dim fechaVencimiento As Date = Date.Parse(mtxFechaVencimiento.Text)
            Dim cvc As Integer = Integer.Parse(mtxCvc.Text)

            pago = New Tarjeta(montoTotal, nroTarjeta, nombreTitular, apellidoTitular, fechaVencimiento, cvc)
        End If


        Me.pedidoCompleto.TipoPago1 = pago



        Me.Hide()
        Dim frm As frmDatosEnvio = New frmDatosEnvio(Me.pedidoCompleto)
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub txtNombreTitular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreTitular.KeyPress
        SoloLetras(e)
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtApellidoTitular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoTitular.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub rbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTarjeta.CheckedChanged
        txtMonto.Text = ""
        txtMonto.Enabled = False

        mtxNroTarjeta.Text = ""
        mtxNroTarjeta.Enabled = True
        txtNombreTitular.Text = ""
        txtNombreTitular.Enabled = True
        txtApellidoTitular.Text = ""
        txtApellidoTitular.Enabled = True
        mtxFechaVencimiento.Text = ""
        mtxFechaVencimiento.Enabled = True
        mtxCvc.Text = ""
        mtxCvc.Enabled = True
    End Sub

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEfectivo.CheckedChanged
        txtMonto.Text = ""
        txtMonto.Enabled = True

        mtxNroTarjeta.Text = ""
        mtxNroTarjeta.Enabled = False
        txtNombreTitular.Text = ""
        txtNombreTitular.Enabled = False
        txtApellidoTitular.Text = ""
        txtApellidoTitular.Enabled = False
        mtxFechaVencimiento.Text = ""
        mtxFechaVencimiento.Enabled = False
        mtxCvc.Text = ""
        mtxCvc.Enabled = False
    End Sub
End Class
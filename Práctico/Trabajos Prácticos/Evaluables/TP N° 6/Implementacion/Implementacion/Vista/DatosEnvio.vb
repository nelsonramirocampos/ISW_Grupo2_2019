Public Class DatosEnvio
    Private pedidoCompleto As Pedido

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(pedidoCompleto As Pedido)
        Me.New()

        Me.pedidoCompleto = pedidoCompleto
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If String.IsNullOrWhiteSpace(txtCalle.Text) Then
            MessageBox.Show("Debe ingresar la calle")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNro.Text) Then
            MessageBox.Show("Debe ingresar el numero")
            Exit Sub
        End If

        Dim calle As String = txtCalle.Text
        Dim nro As Integer = Integer.Parse(txtNro.Text)
        Dim ciudad As String = cbCiudades.Text
        Dim referencia As String = txtReferencia.Text

        Dim dire As Direccion = New Direccion(calle, nro, ciudad, referencia)
        pedidoCompleto.Direccion1 = dire

        Dim frm As TiempoRecepcion = New TiempoRecepcion(pedidoCompleto)
        Me.Close()
        frm.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("¿Desea cancelar el Pedido?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DatosEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Impide que el usuario escriba en el combobox
        cbCiudades.DropDownStyle = ComboBoxStyle.DropDownList

        'Ciudades hardcodeadas
        Dim columns As String() = {"Córdoba", "Buenos Aires", "Rosario"}
        cbCiudades.MaxDropDownItems = columns.Length
        For Each column As String In columns
            cbCiudades.Items.Add(column)
        Next
    End Sub

    Private Sub txtNro_TextChanged(sender As Object, e As EventArgs) Handles txtNro.TextChanged
        If (System.Text.RegularExpressions.Regex.IsMatch(txtNro.Text, "[^0-9]")) Then
            MessageBox.Show("Solo números.")
            txtNro.Text = txtNro.Text.Remove(txtNro.Text.Length - 1)
        End If
    End Sub
End Class
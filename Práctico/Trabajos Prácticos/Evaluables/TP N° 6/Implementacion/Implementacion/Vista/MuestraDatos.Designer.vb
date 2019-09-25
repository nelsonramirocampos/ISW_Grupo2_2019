<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestraDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbPedido = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.cProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDatosEnvio = New System.Windows.Forms.GroupBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFormaPago = New System.Windows.Forms.GroupBox()
        Me.txtCvc = New System.Windows.Forms.MaskedTextBox()
        Me.txtNroTarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidoTitular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.gbPedido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosEnvio.SuspendLayout()
        Me.gbFormaPago.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPedido
        '
        Me.gbPedido.Controls.Add(Me.txtTotal)
        Me.gbPedido.Controls.Add(Me.Label9)
        Me.gbPedido.Controls.Add(Me.Panel1)
        Me.gbPedido.Enabled = False
        Me.gbPedido.Location = New System.Drawing.Point(15, 335)
        Me.gbPedido.Name = "gbPedido"
        Me.gbPedido.Size = New System.Drawing.Size(579, 294)
        Me.gbPedido.TabIndex = 1
        Me.gbPedido.TabStop = False
        Me.gbPedido.Text = "Pedido"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(464, 261)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.Text = "0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total: $"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDetallePedido)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 236)
        Me.Panel1.TabIndex = 0
        '
        'dgvDetallePedido
        '
        Me.dgvDetallePedido.AllowUserToAddRows = False
        Me.dgvDetallePedido.AllowUserToDeleteRows = False
        Me.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProducto, Me.cPrecio, Me.cCantidad, Me.cSubTotal})
        Me.dgvDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetallePedido.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetallePedido.Name = "dgvDetallePedido"
        Me.dgvDetallePedido.ReadOnly = True
        Me.dgvDetallePedido.Size = New System.Drawing.Size(558, 236)
        Me.dgvDetallePedido.TabIndex = 1
        '
        'cProducto
        '
        Me.cProducto.HeaderText = "Producto"
        Me.cProducto.Name = "cProducto"
        Me.cProducto.ReadOnly = True
        '
        'cPrecio
        '
        Me.cPrecio.HeaderText = "Precio"
        Me.cPrecio.Name = "cPrecio"
        Me.cPrecio.ReadOnly = True
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        '
        'cSubTotal
        '
        Me.cSubTotal.HeaderText = "SubTotal"
        Me.cSubTotal.Name = "cSubTotal"
        Me.cSubTotal.ReadOnly = True
        '
        'gbDatosEnvio
        '
        Me.gbDatosEnvio.Controls.Add(Me.txtCiudad)
        Me.gbDatosEnvio.Controls.Add(Me.Label4)
        Me.gbDatosEnvio.Controls.Add(Me.txtReferencia)
        Me.gbDatosEnvio.Controls.Add(Me.Label3)
        Me.gbDatosEnvio.Controls.Add(Me.txtNro)
        Me.gbDatosEnvio.Controls.Add(Me.Label2)
        Me.gbDatosEnvio.Controls.Add(Me.txtCalle)
        Me.gbDatosEnvio.Controls.Add(Me.Label1)
        Me.gbDatosEnvio.Enabled = False
        Me.gbDatosEnvio.Location = New System.Drawing.Point(15, 12)
        Me.gbDatosEnvio.Name = "gbDatosEnvio"
        Me.gbDatosEnvio.Size = New System.Drawing.Size(579, 128)
        Me.gbDatosEnvio.TabIndex = 2
        Me.gbDatosEnvio.TabStop = False
        Me.gbDatosEnvio.Text = "Datos Envio"
        '
        'txtCiudad
        '
        Me.txtCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCiudad.Location = New System.Drawing.Point(55, 19)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(149, 20)
        Me.txtCiudad.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(10, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Referencia"
        '
        'txtReferencia
        '
        Me.txtReferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReferencia.Location = New System.Drawing.Point(75, 45)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(492, 73)
        Me.txtReferencia.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(9, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ciudad"
        '
        'txtNro
        '
        Me.txtNro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNro.Location = New System.Drawing.Point(516, 19)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(51, 20)
        Me.txtNro.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(483, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nro."
        '
        'txtCalle
        '
        Me.txtCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCalle.Location = New System.Drawing.Point(256, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(219, 20)
        Me.txtCalle.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(220, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Calle"
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.txtFechaVencimiento)
        Me.gbFormaPago.Controls.Add(Me.txtCvc)
        Me.gbFormaPago.Controls.Add(Me.txtNroTarjeta)
        Me.gbFormaPago.Controls.Add(Me.txtVuelto)
        Me.gbFormaPago.Controls.Add(Me.Label8)
        Me.gbFormaPago.Controls.Add(Me.Label6)
        Me.gbFormaPago.Controls.Add(Me.Label5)
        Me.gbFormaPago.Controls.Add(Me.txtApellidoTitular)
        Me.gbFormaPago.Controls.Add(Me.Label7)
        Me.gbFormaPago.Controls.Add(Me.txtNombreTitular)
        Me.gbFormaPago.Controls.Add(Me.Label10)
        Me.gbFormaPago.Controls.Add(Me.Label11)
        Me.gbFormaPago.Controls.Add(Me.txtMonto)
        Me.gbFormaPago.Controls.Add(Me.Label12)
        Me.gbFormaPago.Controls.Add(Me.rbTarjeta)
        Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
        Me.gbFormaPago.Enabled = False
        Me.gbFormaPago.Location = New System.Drawing.Point(15, 203)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(579, 126)
        Me.gbFormaPago.TabIndex = 26
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Forma de Pago"
        '
        'txtCvc
        '
        Me.txtCvc.Location = New System.Drawing.Point(522, 92)
        Me.txtCvc.Mask = "999"
        Me.txtCvc.Name = "txtCvc"
        Me.txtCvc.Size = New System.Drawing.Size(42, 20)
        Me.txtCvc.TabIndex = 52
        '
        'txtNroTarjeta
        '
        Me.txtNroTarjeta.Location = New System.Drawing.Point(186, 92)
        Me.txtNroTarjeta.Mask = "9999999999999999"
        Me.txtNroTarjeta.Name = "txtNroTarjeta"
        Me.txtNroTarjeta.Size = New System.Drawing.Size(109, 20)
        Me.txtNroTarjeta.TabIndex = 51
        '
        'txtVuelto
        '
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtVuelto.Location = New System.Drawing.Point(353, 29)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(82, 20)
        Me.txtVuelto.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(295, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Vuelto ($)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(488, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "CVC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(310, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'txtApellidoTitular
        '
        Me.txtApellidoTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtApellidoTitular.Location = New System.Drawing.Point(414, 66)
        Me.txtApellidoTitular.Name = "txtApellidoTitular"
        Me.txtApellidoTitular.Size = New System.Drawing.Size(150, 20)
        Me.txtApellidoTitular.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(332, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Apellido Titular"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreTitular.Location = New System.Drawing.Point(199, 66)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreTitular.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(117, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Nombre Titular"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(117, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Nro. Tarjeta"
        '
        'txtMonto
        '
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(193, 29)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(73, 20)
        Me.txtMonto.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(92, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Monto a abonar ($)"
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbTarjeta.Location = New System.Drawing.Point(15, 67)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(85, 17)
        Me.rbTarjeta.TabIndex = 39
        Me.rbTarjeta.Text = "Tarjeta VISA"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Checked = True
        Me.rbEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbEfectivo.Location = New System.Drawing.Point(15, 30)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 38
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(15, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 51)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Momento de Entrega"
        '
        'txtFecha
        '
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFecha.Location = New System.Drawing.Point(56, 20)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(73, 20)
        Me.txtFecha.TabIndex = 54
        '
        'txtHora
        '
        Me.txtHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHora.Location = New System.Drawing.Point(198, 20)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(47, 20)
        Me.txtHora.TabIndex = 18
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(151, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Hora"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(13, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(302, 635)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(173, 23)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(123, 635)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(173, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(414, 92)
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(61, 20)
        Me.txtFechaVencimiento.TabIndex = 55
        '
        'MuestraDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 668)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbFormaPago)
        Me.Controls.Add(Me.gbDatosEnvio)
        Me.Controls.Add(Me.gbPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MuestraDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MuestraDatos"
        Me.gbPedido.ResumeLayout(False)
        Me.gbPedido.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosEnvio.ResumeLayout(False)
        Me.gbDatosEnvio.PerformLayout()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPedido As GroupBox
    Friend WithEvents dgvDetallePedido As DataGridView
    Friend WithEvents gbDatosEnvio As GroupBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbFormaPago As GroupBox
    Friend WithEvents txtCvc As MaskedTextBox
    Friend WithEvents txtNroTarjeta As MaskedTextBox
    Friend WithEvents txtVuelto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidoTitular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHora As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cProducto As DataGridViewTextBoxColumn
    Friend WithEvents cPrecio As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtFechaVencimiento As TextBox
End Class

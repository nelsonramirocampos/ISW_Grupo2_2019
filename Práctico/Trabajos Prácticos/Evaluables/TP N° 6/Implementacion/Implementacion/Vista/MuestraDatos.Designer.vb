<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuestraDatos
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
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.cProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDatosEnvio = New System.Windows.Forms.GroupBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.grpFormaPago = New System.Windows.Forms.GroupBox()
        Me.mtxFechaVencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCvc = New System.Windows.Forms.MaskedTextBox()
        Me.mtxNroTarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtApellidoTitular = New System.Windows.Forms.TextBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.rdoTarjeta = New System.Windows.Forms.RadioButton()
        Me.rdoEfectivo = New System.Windows.Forms.RadioButton()
        Me.grpEntrega = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.mtxHora = New System.Windows.Forms.MaskedTextBox()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbPedido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosEnvio.SuspendLayout()
        Me.grpFormaPago.SuspendLayout()
        Me.grpEntrega.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPedido
        '
        Me.gbPedido.Controls.Add(Me.txtTotal)
        Me.gbPedido.Controls.Add(Me.lbl9)
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
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Location = New System.Drawing.Point(413, 264)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(43, 13)
        Me.lbl9.TabIndex = 13
        Me.lbl9.Text = "Total: $"
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
        'grpDatosEnvio
        '
        Me.grpDatosEnvio.Controls.Add(Me.txtCiudad)
        Me.grpDatosEnvio.Controls.Add(Me.lbl4)
        Me.grpDatosEnvio.Controls.Add(Me.txtReferencia)
        Me.grpDatosEnvio.Controls.Add(Me.lbl3)
        Me.grpDatosEnvio.Controls.Add(Me.txtNro)
        Me.grpDatosEnvio.Controls.Add(Me.lbl2)
        Me.grpDatosEnvio.Controls.Add(Me.txtCalle)
        Me.grpDatosEnvio.Controls.Add(Me.lbl1)
        Me.grpDatosEnvio.Enabled = False
        Me.grpDatosEnvio.Location = New System.Drawing.Point(15, 12)
        Me.grpDatosEnvio.Name = "grpDatosEnvio"
        Me.grpDatosEnvio.Size = New System.Drawing.Size(579, 128)
        Me.grpDatosEnvio.TabIndex = 2
        Me.grpDatosEnvio.TabStop = False
        Me.grpDatosEnvio.Text = "Datos Envio"
        '
        'txtCiudad
        '
        Me.txtCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCiudad.Location = New System.Drawing.Point(55, 19)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(149, 20)
        Me.txtCiudad.TabIndex = 25
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl4.Location = New System.Drawing.Point(10, 48)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 24
        Me.lbl4.Text = "Referencia"
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
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl3.Location = New System.Drawing.Point(9, 22)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(40, 13)
        Me.lbl3.TabIndex = 22
        Me.lbl3.Text = "Ciudad"
        '
        'txtNro
        '
        Me.txtNro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNro.Location = New System.Drawing.Point(516, 19)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(51, 20)
        Me.txtNro.TabIndex = 21
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl2.Location = New System.Drawing.Point(483, 22)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(27, 13)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "Nro."
        '
        'txtCalle
        '
        Me.txtCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCalle.Location = New System.Drawing.Point(256, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(219, 20)
        Me.txtCalle.TabIndex = 19
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.Location = New System.Drawing.Point(220, 22)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(30, 13)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "Calle"
        '
        'grpFormaPago
        '
        Me.grpFormaPago.Controls.Add(Me.mtxFechaVencimiento)
        Me.grpFormaPago.Controls.Add(Me.mtxCvc)
        Me.grpFormaPago.Controls.Add(Me.mtxNroTarjeta)
        Me.grpFormaPago.Controls.Add(Me.txtVuelto)
        Me.grpFormaPago.Controls.Add(Me.lbl8)
        Me.grpFormaPago.Controls.Add(Me.lbl6)
        Me.grpFormaPago.Controls.Add(Me.lbl5)
        Me.grpFormaPago.Controls.Add(Me.txtApellidoTitular)
        Me.grpFormaPago.Controls.Add(Me.lbl7)
        Me.grpFormaPago.Controls.Add(Me.txtNombreTitular)
        Me.grpFormaPago.Controls.Add(Me.lbl10)
        Me.grpFormaPago.Controls.Add(Me.lbl11)
        Me.grpFormaPago.Controls.Add(Me.txtMonto)
        Me.grpFormaPago.Controls.Add(Me.lbl12)
        Me.grpFormaPago.Controls.Add(Me.rdoTarjeta)
        Me.grpFormaPago.Controls.Add(Me.rdoEfectivo)
        Me.grpFormaPago.Enabled = False
        Me.grpFormaPago.Location = New System.Drawing.Point(15, 203)
        Me.grpFormaPago.Name = "grpFormaPago"
        Me.grpFormaPago.Size = New System.Drawing.Size(579, 126)
        Me.grpFormaPago.TabIndex = 26
        Me.grpFormaPago.TabStop = False
        Me.grpFormaPago.Text = "Forma de Pago"
        '
        'mtxFechaVencimiento
        '
        Me.mtxFechaVencimiento.Location = New System.Drawing.Point(414, 92)
        Me.mtxFechaVencimiento.Mask = "00/0000"
        Me.mtxFechaVencimiento.Name = "mtxFechaVencimiento"
        Me.mtxFechaVencimiento.Size = New System.Drawing.Size(58, 20)
        Me.mtxFechaVencimiento.TabIndex = 53
        '
        'mtxCvc
        '
        Me.mtxCvc.Location = New System.Drawing.Point(522, 92)
        Me.mtxCvc.Mask = "999"
        Me.mtxCvc.Name = "mtxCvc"
        Me.mtxCvc.Size = New System.Drawing.Size(42, 20)
        Me.mtxCvc.TabIndex = 52
        '
        'mtxNroTarjeta
        '
        Me.mtxNroTarjeta.Location = New System.Drawing.Point(186, 92)
        Me.mtxNroTarjeta.Mask = "9999999999999999"
        Me.mtxNroTarjeta.Name = "mtxNroTarjeta"
        Me.mtxNroTarjeta.Size = New System.Drawing.Size(109, 20)
        Me.mtxNroTarjeta.TabIndex = 51
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
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl8.Location = New System.Drawing.Point(295, 32)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(52, 13)
        Me.lbl8.TabIndex = 49
        Me.lbl8.Text = "Vuelto ($)"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl6.Location = New System.Drawing.Point(488, 95)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(28, 13)
        Me.lbl6.TabIndex = 48
        Me.lbl6.Text = "CVC"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5.Location = New System.Drawing.Point(310, 95)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(98, 13)
        Me.lbl5.TabIndex = 47
        Me.lbl5.Text = "Fecha Vencimiento"
        '
        'txtApellidoTitular
        '
        Me.txtApellidoTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtApellidoTitular.Location = New System.Drawing.Point(414, 66)
        Me.txtApellidoTitular.Name = "txtApellidoTitular"
        Me.txtApellidoTitular.Size = New System.Drawing.Size(150, 20)
        Me.txtApellidoTitular.TabIndex = 46
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl7.Location = New System.Drawing.Point(332, 69)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(76, 13)
        Me.lbl7.TabIndex = 45
        Me.lbl7.Text = "Apellido Titular"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreTitular.Location = New System.Drawing.Point(199, 66)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreTitular.TabIndex = 44
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl10.Location = New System.Drawing.Point(117, 69)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(76, 13)
        Me.lbl10.TabIndex = 43
        Me.lbl10.Text = "Nombre Titular"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl11.Location = New System.Drawing.Point(117, 95)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(63, 13)
        Me.lbl11.TabIndex = 42
        Me.lbl11.Text = "Nro. Tarjeta"
        '
        'txtMonto
        '
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(193, 29)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(73, 20)
        Me.txtMonto.TabIndex = 41
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl12.Location = New System.Drawing.Point(92, 32)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(97, 13)
        Me.lbl12.TabIndex = 40
        Me.lbl12.Text = "Monto a abonar ($)"
        '
        'rdoTarjeta
        '
        Me.rdoTarjeta.AutoSize = True
        Me.rdoTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoTarjeta.Location = New System.Drawing.Point(15, 67)
        Me.rdoTarjeta.Name = "rdoTarjeta"
        Me.rdoTarjeta.Size = New System.Drawing.Size(85, 17)
        Me.rdoTarjeta.TabIndex = 39
        Me.rdoTarjeta.Text = "Tarjeta VISA"
        Me.rdoTarjeta.UseVisualStyleBackColor = True
        '
        'rdoEfectivo
        '
        Me.rdoEfectivo.AutoSize = True
        Me.rdoEfectivo.Checked = True
        Me.rdoEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoEfectivo.Location = New System.Drawing.Point(15, 30)
        Me.rdoEfectivo.Name = "rdoEfectivo"
        Me.rdoEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rdoEfectivo.TabIndex = 38
        Me.rdoEfectivo.TabStop = True
        Me.rdoEfectivo.Text = "Efectivo"
        Me.rdoEfectivo.UseVisualStyleBackColor = True
        '
        'grpEntrega
        '
        Me.grpEntrega.Controls.Add(Me.txtFecha)
        Me.grpEntrega.Controls.Add(Me.mtxHora)
        Me.grpEntrega.Controls.Add(Me.lbl13)
        Me.grpEntrega.Controls.Add(Me.lbl14)
        Me.grpEntrega.Enabled = False
        Me.grpEntrega.Location = New System.Drawing.Point(15, 146)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Size = New System.Drawing.Size(579, 51)
        Me.grpEntrega.TabIndex = 26
        Me.grpEntrega.TabStop = False
        Me.grpEntrega.Text = "Momento de Entrega"
        '
        'txtFecha
        '
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFecha.Location = New System.Drawing.Point(56, 20)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(73, 20)
        Me.txtFecha.TabIndex = 54
        '
        'mtxHora
        '
        Me.mtxHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mtxHora.Location = New System.Drawing.Point(198, 20)
        Me.mtxHora.Mask = "00:00"
        Me.mtxHora.Name = "mtxHora"
        Me.mtxHora.Size = New System.Drawing.Size(47, 20)
        Me.mtxHora.TabIndex = 18
        Me.mtxHora.ValidatingType = GetType(Date)
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl13.Location = New System.Drawing.Point(151, 23)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(30, 13)
        Me.lbl13.TabIndex = 17
        Me.lbl13.Text = "Hora"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl14.Location = New System.Drawing.Point(13, 23)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(37, 13)
        Me.lbl14.TabIndex = 16
        Me.lbl14.Text = "Fecha"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(302, 635)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(173, 23)
        Me.btnConfirmar.TabIndex = 27
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(123, 635)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(173, 23)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmMuestraDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 668)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grpEntrega)
        Me.Controls.Add(Me.grpFormaPago)
        Me.Controls.Add(Me.grpDatosEnvio)
        Me.Controls.Add(Me.gbPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMuestraDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MuestraDatos"
        Me.gbPedido.ResumeLayout(False)
        Me.gbPedido.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosEnvio.ResumeLayout(False)
        Me.grpDatosEnvio.PerformLayout()
        Me.grpFormaPago.ResumeLayout(False)
        Me.grpFormaPago.PerformLayout()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPedido As GroupBox
    Friend WithEvents dgvDetallePedido As DataGridView
    Friend WithEvents grpDatosEnvio As GroupBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents grpFormaPago As GroupBox
    Friend WithEvents mtxFechaVencimiento As MaskedTextBox
    Friend WithEvents mtxCvc As MaskedTextBox
    Friend WithEvents mtxNroTarjeta As MaskedTextBox
    Friend WithEvents txtVuelto As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtApellidoTitular As TextBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lbl12 As Label
    Friend WithEvents rdoTarjeta As RadioButton
    Friend WithEvents rdoEfectivo As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents grpEntrega As GroupBox
    Friend WithEvents mtxHora As MaskedTextBox
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cProducto As DataGridViewTextBoxColumn
    Friend WithEvents cPrecio As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtFecha As TextBox
End Class

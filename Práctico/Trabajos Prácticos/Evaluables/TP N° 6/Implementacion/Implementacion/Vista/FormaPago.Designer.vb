<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormaPago
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
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtApellidoTitular = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.rdoTarjeta = New System.Windows.Forms.RadioButton()
        Me.rdoEfectivo = New System.Windows.Forms.RadioButton()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.mtxNroTarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCvc = New System.Windows.Forms.MaskedTextBox()
        Me.mtxFechaVencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl6.Location = New System.Drawing.Point(40, 244)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(28, 13)
        Me.lbl6.TabIndex = 27
        Me.lbl6.Text = "CVC"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5.Location = New System.Drawing.Point(40, 218)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(98, 13)
        Me.lbl5.TabIndex = 25
        Me.lbl5.Text = "Fecha Vencimiento"
        '
        'txtApellidoTitular
        '
        Me.txtApellidoTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtApellidoTitular.Location = New System.Drawing.Point(337, 189)
        Me.txtApellidoTitular.Name = "txtApellidoTitular"
        Me.txtApellidoTitular.Size = New System.Drawing.Size(124, 20)
        Me.txtApellidoTitular.TabIndex = 24
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl4.Location = New System.Drawing.Point(255, 192)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(76, 13)
        Me.lbl4.TabIndex = 23
        Me.lbl4.Text = "Apellido Titular"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreTitular.Location = New System.Drawing.Point(122, 189)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreTitular.TabIndex = 22
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl3.Location = New System.Drawing.Point(40, 192)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(76, 13)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "Nombre Titular"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl2.Location = New System.Drawing.Point(40, 166)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(63, 13)
        Me.lbl2.TabIndex = 19
        Me.lbl2.Text = "Nro. Tarjeta"
        '
        'txtMonto
        '
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(141, 90)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(73, 20)
        Me.txtMonto.TabIndex = 18
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.Location = New System.Drawing.Point(40, 93)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(97, 13)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "Monto a abonar ($)"
        '
        'rdoTarjeta
        '
        Me.rdoTarjeta.AutoSize = True
        Me.rdoTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoTarjeta.Location = New System.Drawing.Point(15, 139)
        Me.rdoTarjeta.Name = "rdoTarjeta"
        Me.rdoTarjeta.Size = New System.Drawing.Size(85, 17)
        Me.rdoTarjeta.TabIndex = 16
        Me.rdoTarjeta.Text = "Tarjeta VISA"
        Me.rdoTarjeta.UseVisualStyleBackColor = True
        '
        'rdoEfectivo
        '
        Me.rdoEfectivo.AutoSize = True
        Me.rdoEfectivo.Checked = True
        Me.rdoEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoEfectivo.Location = New System.Drawing.Point(15, 65)
        Me.rdoEfectivo.Name = "rdoEfectivo"
        Me.rdoEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rdoEfectivo.TabIndex = 15
        Me.rdoEfectivo.TabStop = True
        Me.rdoEfectivo.Text = "Efectivo"
        Me.rdoEfectivo.UseVisualStyleBackColor = True
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(115, 9)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(252, 37)
        Me.lbl7.TabIndex = 29
        Me.lbl7.Text = "Forma de Pago"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(305, 269)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(386, 269)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 30
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMontoTotal.Location = New System.Drawing.Point(379, 90)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtMontoTotal.TabIndex = 33
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl8.Location = New System.Drawing.Point(294, 93)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(79, 13)
        Me.lbl8.TabIndex = 32
        Me.lbl8.Text = "Monto Total ($)"
        '
        'mtxNroTarjeta
        '
        Me.mtxNroTarjeta.Location = New System.Drawing.Point(109, 163)
        Me.mtxNroTarjeta.Mask = "9999999999999999"
        Me.mtxNroTarjeta.Name = "mtxNroTarjeta"
        Me.mtxNroTarjeta.Size = New System.Drawing.Size(188, 20)
        Me.mtxNroTarjeta.TabIndex = 34
        '
        'mtxCvc
        '
        Me.mtxCvc.Location = New System.Drawing.Point(74, 241)
        Me.mtxCvc.Mask = "999"
        Me.mtxCvc.Name = "mtxCvc"
        Me.mtxCvc.Size = New System.Drawing.Size(42, 20)
        Me.mtxCvc.TabIndex = 35
        '
        'mtxFechaVencimiento
        '
        Me.mtxFechaVencimiento.Location = New System.Drawing.Point(144, 215)
        Me.mtxFechaVencimiento.Mask = "00/0000"
        Me.mtxFechaVencimiento.Name = "mtxFechaVencimiento"
        Me.mtxFechaVencimiento.Size = New System.Drawing.Size(58, 20)
        Me.mtxFechaVencimiento.TabIndex = 36
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl9.Location = New System.Drawing.Point(208, 218)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(58, 13)
        Me.lbl9.TabIndex = 37
        Me.lbl9.Text = "(mm/aaaa)"
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 300)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.mtxFechaVencimiento)
        Me.Controls.Add(Me.mtxCvc)
        Me.Controls.Add(Me.mtxNroTarjeta)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.txtApellidoTitular)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtNombreTitular)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.rdoTarjeta)
        Me.Controls.Add(Me.rdoEfectivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtApellidoTitular As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents rdoTarjeta As RadioButton
    Friend WithEvents rdoEfectivo As RadioButton
    Friend WithEvents lbl7 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents mtxNroTarjeta As MaskedTextBox
    Friend WithEvents mtxCvc As MaskedTextBox
    Friend WithEvents mtxFechaVencimiento As MaskedTextBox
    Friend WithEvents lbl9 As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormaPago
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidoTitular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNroTarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.txtCvc = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaVencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(40, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "CVC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(40, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'txtApellidoTitular
        '
        Me.txtApellidoTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtApellidoTitular.Location = New System.Drawing.Point(337, 189)
        Me.txtApellidoTitular.Name = "txtApellidoTitular"
        Me.txtApellidoTitular.Size = New System.Drawing.Size(124, 20)
        Me.txtApellidoTitular.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(255, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Apellido Titular"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreTitular.Location = New System.Drawing.Point(122, 189)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreTitular.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(40, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre Titular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(40, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nro. Tarjeta"
        '
        'txtMonto
        '
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(141, 90)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(73, 20)
        Me.txtMonto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(40, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Monto a abonar ($)"
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbTarjeta.Location = New System.Drawing.Point(15, 139)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(85, 17)
        Me.rbTarjeta.TabIndex = 16
        Me.rbTarjeta.Text = "Tarjeta VISA"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Checked = True
        Me.rbEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbEfectivo.Location = New System.Drawing.Point(15, 65)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 15
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(115, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 37)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Forma de Pago"
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
        Me.btnSiguiente.TabIndex = 7
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(294, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Monto Total ($)"
        '
        'txtNroTarjeta
        '
        Me.txtNroTarjeta.Location = New System.Drawing.Point(109, 163)
        Me.txtNroTarjeta.Mask = "9999999999999999"
        Me.txtNroTarjeta.Name = "txtNroTarjeta"
        Me.txtNroTarjeta.Size = New System.Drawing.Size(188, 20)
        Me.txtNroTarjeta.TabIndex = 2
        '
        'txtCvc
        '
        Me.txtCvc.Location = New System.Drawing.Point(74, 241)
        Me.txtCvc.Mask = "999"
        Me.txtCvc.Name = "txtCvc"
        Me.txtCvc.Size = New System.Drawing.Size(42, 20)
        Me.txtCvc.TabIndex = 6
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(144, 215)
        Me.txtFechaVencimiento.Mask = "00/0000"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(58, 20)
        Me.txtFechaVencimiento.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(208, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "(mm/aaaa)"
        '
        'FormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 300)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFechaVencimiento)
        Me.Controls.Add(Me.txtCvc)
        Me.Controls.Add(Me.txtNroTarjeta)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellidoTitular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreTitular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbTarjeta)
        Me.Controls.Add(Me.rbEfectivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidoTitular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNroTarjeta As MaskedTextBox
    Friend WithEvents txtCvc As MaskedTextBox
    Friend WithEvents txtFechaVencimiento As MaskedTextBox
    Friend WithEvents Label9 As Label
End Class

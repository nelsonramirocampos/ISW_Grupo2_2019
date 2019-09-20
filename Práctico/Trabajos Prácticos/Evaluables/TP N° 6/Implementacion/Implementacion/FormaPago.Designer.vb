<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtNroTarjeta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidoTitular = New System.Windows.Forms.TextBox()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCvc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton1.Location = New System.Drawing.Point(12, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Efectivo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton2.Location = New System.Drawing.Point(12, 124)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Tarjeta VISA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(37, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monto ($)"
        '
        'txtMonto
        '
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(95, 75)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 3
        '
        'txtNroTarjeta
        '
        Me.txtNroTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNroTarjeta.Location = New System.Drawing.Point(106, 148)
        Me.txtNroTarjeta.Name = "txtNroTarjeta"
        Me.txtNroTarjeta.Size = New System.Drawing.Size(262, 20)
        Me.txtNroTarjeta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(37, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nro. Tarjeta"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreTitular.Location = New System.Drawing.Point(119, 174)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreTitular.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(37, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Titular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(252, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido Titular"
        '
        'txtApellidoTitular
        '
        Me.txtApellidoTitular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtApellidoTitular.Location = New System.Drawing.Point(334, 174)
        Me.txtApellidoTitular.Name = "txtApellidoTitular"
        Me.txtApellidoTitular.Size = New System.Drawing.Size(120, 20)
        Me.txtApellidoTitular.TabIndex = 9
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(141, 200)
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(54, 20)
        Me.txtFechaVencimiento.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'txtCvc
        '
        Me.txtCvc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCvc.Location = New System.Drawing.Point(71, 226)
        Me.txtCvc.Name = "txtCvc"
        Me.txtCvc.Size = New System.Drawing.Size(54, 20)
        Me.txtCvc.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(37, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CVC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(186, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "FORMA DE PAGO"
        '
        'FormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 262)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCvc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFechaVencimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellidoTitular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreTitular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNroTarjeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormaPago"
        Me.Text = "FormaPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtNroTarjeta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellidoTitular As TextBox
    Friend WithEvents txtFechaVencimiento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCvc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

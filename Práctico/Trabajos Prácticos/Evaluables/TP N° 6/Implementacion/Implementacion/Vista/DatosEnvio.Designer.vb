Imports Implementacion

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosEnvio
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
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.cboCiudades = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5.Location = New System.Drawing.Point(12, 280)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(222, 13)
        Me.lbl5.TabIndex = 17
        Me.lbl5.Text = "Los campos con * (asterisco) son obligatorios."
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl4.Location = New System.Drawing.Point(12, 148)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 16
        Me.lbl4.Text = "Referencia"
        '
        'txtReferencia
        '
        Me.txtReferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReferencia.Location = New System.Drawing.Point(77, 142)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(219, 122)
        Me.txtReferencia.TabIndex = 15
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl3.Location = New System.Drawing.Point(12, 118)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(44, 13)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "Ciudad*"
        '
        'txtNro
        '
        Me.txtNro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNro.Location = New System.Drawing.Point(77, 89)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(51, 20)
        Me.txtNro.TabIndex = 13
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl2.Location = New System.Drawing.Point(12, 92)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(31, 13)
        Me.lbl2.TabIndex = 12
        Me.lbl2.Text = "Nro.*"
        '
        'txtCalle
        '
        Me.txtCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCalle.Location = New System.Drawing.Point(77, 63)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(219, 20)
        Me.txtCalle.TabIndex = 11
        '
        'cboCiudades
        '
        Me.cboCiudades.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboCiudades.FormattingEnabled = True
        Me.cboCiudades.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboCiudades.Location = New System.Drawing.Point(77, 115)
        Me.cboCiudades.Name = "cboCiudades"
        Me.cboCiudades.Size = New System.Drawing.Size(121, 21)
        Me.cboCiudades.TabIndex = 10
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.Location = New System.Drawing.Point(12, 66)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Calle*"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(32, 9)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(247, 37)
        Me.lbl6.TabIndex = 18
        Me.lbl6.Text = "Datos de Envio"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(140, 311)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(221, 311)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 19
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'frmDatosEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 344)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.cboCiudades)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDatosEnvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Envio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents cboCiudades As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
End Class

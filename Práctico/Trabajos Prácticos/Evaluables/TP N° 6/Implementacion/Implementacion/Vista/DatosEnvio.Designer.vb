Imports Implementacion

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosEnvio
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.cbCiudades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(12, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Los campos con * (asterisco) son obligatorios."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Referencia"
        '
        'txtReferencia
        '
        Me.txtReferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReferencia.Location = New System.Drawing.Point(77, 142)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(219, 122)
        Me.txtReferencia.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ciudad*"
        '
        'txtNro
        '
        Me.txtNro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNro.Location = New System.Drawing.Point(77, 89)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(51, 20)
        Me.txtNro.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nro.*"
        '
        'txtCalle
        '
        Me.txtCalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCalle.Location = New System.Drawing.Point(77, 63)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(219, 20)
        Me.txtCalle.TabIndex = 1
        '
        'cbCiudades
        '
        Me.cbCiudades.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbCiudades.FormattingEnabled = True
        Me.cbCiudades.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbCiudades.Location = New System.Drawing.Point(77, 115)
        Me.cbCiudades.Name = "cbCiudades"
        Me.cbCiudades.Size = New System.Drawing.Size(121, 21)
        Me.cbCiudades.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Calle*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datos de Envio"
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
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'DatosEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 344)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.cbCiudades)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DatosEnvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Envio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents cbCiudades As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
End Class

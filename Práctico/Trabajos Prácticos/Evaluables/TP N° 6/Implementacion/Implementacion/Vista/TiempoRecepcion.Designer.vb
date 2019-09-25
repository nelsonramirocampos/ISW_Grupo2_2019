Imports Implementacion

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiempoRecepcion
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
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoFechaHora = New System.Windows.Forms.RadioButton()
        Me.rdoAntesPosible = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFecha.Location = New System.Drawing.Point(99, 127)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtHora
        '
        Me.txtHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHora.Location = New System.Drawing.Point(99, 153)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 4
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(52, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hora"
        '
        'rdoFechaHora
        '
        Me.rdoFechaHora.AutoSize = True
        Me.rdoFechaHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoFechaHora.Location = New System.Drawing.Point(20, 94)
        Me.rdoFechaHora.Name = "rdoFechaHora"
        Me.rdoFechaHora.Size = New System.Drawing.Size(83, 17)
        Me.rdoFechaHora.TabIndex = 2
        Me.rdoFechaHora.TabStop = True
        Me.rdoFechaHora.Text = "Fecha/Hora"
        Me.rdoFechaHora.UseVisualStyleBackColor = True
        '
        'rdoAntesPosible
        '
        Me.rdoAntesPosible.AutoSize = True
        Me.rdoAntesPosible.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoAntesPosible.Location = New System.Drawing.Point(20, 71)
        Me.rdoAntesPosible.Name = "rdoAntesPosible"
        Me.rdoAntesPosible.Size = New System.Drawing.Size(102, 17)
        Me.rdoAntesPosible.TabIndex = 1
        Me.rdoAntesPosible.TabStop = True
        Me.rdoAntesPosible.Text = "Lo antes posible"
        Me.rdoAntesPosible.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(52, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(372, 37)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Momento de Recepcion"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(227, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(308, 181)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'TiempoRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 216)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdoFechaHora)
        Me.Controls.Add(Me.rdoAntesPosible)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TiempoRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiempo Recepcion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtHora As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoFechaHora As RadioButton
    Friend WithEvents rdoAntesPosible As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
End Class

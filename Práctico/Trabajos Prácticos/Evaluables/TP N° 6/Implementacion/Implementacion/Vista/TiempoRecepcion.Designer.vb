Imports Implementacion

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempoRecepcion
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
        Me.mtxFecha = New System.Windows.Forms.MaskedTextBox()
        Me.mtxHora = New System.Windows.Forms.MaskedTextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.rdoFechaHora = New System.Windows.Forms.RadioButton()
        Me.rdoAntesPosible = New System.Windows.Forms.RadioButton()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtxFecha
        '
        Me.mtxFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mtxFecha.Location = New System.Drawing.Point(99, 127)
        Me.mtxFecha.Mask = "00/00/0000"
        Me.mtxFecha.Name = "mtxFecha"
        Me.mtxFecha.Size = New System.Drawing.Size(100, 20)
        Me.mtxFecha.TabIndex = 15
        Me.mtxFecha.ValidatingType = GetType(Date)
        '
        'mtxHora
        '
        Me.mtxHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mtxHora.Location = New System.Drawing.Point(99, 153)
        Me.mtxHora.Mask = "00:00"
        Me.mtxHora.Name = "mtxHora"
        Me.mtxHora.Size = New System.Drawing.Size(100, 20)
        Me.mtxHora.TabIndex = 14
        Me.mtxHora.ValidatingType = GetType(Date)
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl2.Location = New System.Drawing.Point(52, 156)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(30, 13)
        Me.lbl2.TabIndex = 12
        Me.lbl2.Text = "Hora"
        '
        'rdoFechaHora
        '
        Me.rdoFechaHora.AutoSize = True
        Me.rdoFechaHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoFechaHora.Location = New System.Drawing.Point(20, 94)
        Me.rdoFechaHora.Name = "rdoFechaHora"
        Me.rdoFechaHora.Size = New System.Drawing.Size(83, 17)
        Me.rdoFechaHora.TabIndex = 11
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
        Me.rdoAntesPosible.TabIndex = 10
        Me.rdoAntesPosible.TabStop = True
        Me.rdoAntesPosible.Text = "Lo antes posible"
        Me.rdoAntesPosible.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.Location = New System.Drawing.Point(52, 130)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(37, 13)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Fecha"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(12, 9)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(372, 37)
        Me.lbl6.TabIndex = 19
        Me.lbl6.Text = "Momento de Recepcion"
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
        Me.btnSiguiente.TabIndex = 21
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'frmTiempoRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 216)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.mtxFecha)
        Me.Controls.Add(Me.mtxHora)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.rdoFechaHora)
        Me.Controls.Add(Me.rdoAntesPosible)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTiempoRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiempo Recepcion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxFecha As MaskedTextBox
    Friend WithEvents mtxHora As MaskedTextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents rdoFechaHora As RadioButton
    Friend WithEvents rdoAntesPosible As RadioButton
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
End Class

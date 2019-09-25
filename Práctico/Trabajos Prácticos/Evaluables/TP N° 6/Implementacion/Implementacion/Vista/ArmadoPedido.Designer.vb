<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmadoPedido
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboComercios = New System.Windows.Forms.ComboBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.cIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdComercio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(287, 102)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cboProducto
        '
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(69, 104)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(212, 21)
        Me.cboProducto.TabIndex = 8
        '
        'cboComercios
        '
        Me.cboComercios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComercios.FormattingEnabled = True
        Me.cboComercios.Location = New System.Drawing.Point(69, 77)
        Me.cboComercios.Name = "cboComercios"
        Me.cboComercios.Size = New System.Drawing.Size(212, 21)
        Me.cboComercios.TabIndex = 7
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(12, 107)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(50, 13)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Producto"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 80)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(51, 13)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Comercio"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDetallePedido)
        Me.Panel1.Location = New System.Drawing.Point(12, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 166)
        Me.Panel1.TabIndex = 10
        '
        'dgvDetallePedido
        '
        Me.dgvDetallePedido.AllowUserToAddRows = False
        Me.dgvDetallePedido.AllowUserToDeleteRows = False
        Me.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdProducto, Me.cIdComercio, Me.cProducto, Me.cPrecio, Me.cCantidad, Me.cSubTotal})
        Me.dgvDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetallePedido.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetallePedido.Name = "dgvDetallePedido"
        Me.dgvDetallePedido.ReadOnly = True
        Me.dgvDetallePedido.Size = New System.Drawing.Size(502, 166)
        Me.dgvDetallePedido.TabIndex = 0
        '
        'cIdProducto
        '
        Me.cIdProducto.HeaderText = "idProducto"
        Me.cIdProducto.Name = "cIdProducto"
        Me.cIdProducto.ReadOnly = True
        Me.cIdProducto.Visible = False
        '
        'cIdComercio
        '
        Me.cIdComercio.HeaderText = "idComercio"
        Me.cIdComercio.Name = "cIdComercio"
        Me.cIdComercio.ReadOnly = True
        Me.cIdComercio.Visible = False
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
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(363, 366)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(43, 13)
        Me.lbl3.TabIndex = 11
        Me.lbl3.Text = "Total: $"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(414, 363)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        Me.txtTotal.Text = "0.0"
        '
        'imgFoto
        '
        Me.imgFoto.Location = New System.Drawing.Point(371, 77)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(143, 108)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto.TabIndex = 13
        Me.imgFoto.TabStop = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(439, 406)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 14
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(358, 406)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 37)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Armado de Pedido"
        '
        'frmArmadoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 438)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.imgFoto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.cboComercios)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmArmadoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents cboComercios As ComboBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDetallePedido As DataGridView
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cIdProducto As DataGridViewTextBoxColumn
    Friend WithEvents cIdComercio As DataGridViewTextBoxColumn
    Friend WithEvents cProducto As DataGridViewTextBoxColumn
    Friend WithEvents cPrecio As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label4 As Label
End Class

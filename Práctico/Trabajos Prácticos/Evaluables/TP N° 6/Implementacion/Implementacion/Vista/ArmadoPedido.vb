Imports Implementacion

Public Class frmArmadoPedido
    Private pedidoCompleto As Pedido
    Private comercios As List(Of Comercio)

    Public Sub New()
        InitializeComponent()
    End Sub


    Public Sub New(pedidoCompleto As Pedido)
        Me.New()

        If pedidoCompleto Is Nothing Then
            pedidoCompleto = New Pedido()
        End If

        Me.pedidoCompleto = pedidoCompleto
    End Sub

    Private Sub ArmadoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboboxComercio()
    End Sub

    Sub cargarComercios(c As List(Of Comercio))
        Me.comercios = c
    End Sub

    Sub cargarComboboxComercio()
        cboComercios.DisplayMember = "nombre"
        cboComercios.ValueMember = "idComercio"
        cboComercios.DataSource = comercios
    End Sub

    Private Sub cargarComboboxProductos(x As List(Of Producto))
        cboProducto.DisplayMember = "nombre"
        cboProducto.ValueMember = "idProducto"
        cboProducto.DataSource = x
    End Sub

    Private Sub cbComercios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComercios.SelectedIndexChanged
        Dim x As Comercio = cboComercios.SelectedItem

        cargarComboboxProductos(x.Productos1)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim p As Producto = cboProducto.SelectedItem
        Dim c As Comercio = cboComercios.SelectedItem

        Dim exist As Boolean = False

        For Each fila As DataGridViewRow In dgvDetallePedido.Rows
            If Integer.Parse(fila.Cells("cIdProducto").Value) = p.IdProducto1 And Integer.Parse(fila.Cells("cIdComercio").Value) = c.IdComercio1 Then
                fila.Cells("cCantidad").Value = Integer.Parse(fila.Cells("cCantidad").Value) + 1
                fila.Cells("cSubTotal").Value = Decimal.Parse(fila.Cells("cPrecio").Value) * Integer.Parse(fila.Cells("cCantidad").Value)

                exist = True
                Exit For
            End If
        Next

        If exist = False Then
            dgvDetallePedido.Rows.Add(p.IdProducto1, c.IdComercio1, p.Nombre1, p.Precio1, 1, p.Precio1)
        End If

        actualizarTotal()
    End Sub

    Private Sub actualizarTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In dgvDetallePedido.Rows
            total = total + Decimal.Parse(fila.Cells("cSubTotal").Value)
        Next

        txtTotal.Text = total
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        Dim x As Producto = cboProducto.SelectedItem

        imgFoto.Image = Image.FromFile(x.Imagen1)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As Integer = MessageBox.Show("¿Desea cancelar el Pedido?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If dgvDetallePedido.Rows.Count < 1 Then
            MessageBox.Show("Debe aunque sea cargar 1 (uno) producto")
            Exit Sub
        Else
            For Each fila As DataGridViewRow In dgvDetallePedido.Rows
                Dim com As Comercio = busquedaComercio(Integer.Parse(fila.Cells("cIdComercio").Value))
                If com Is Nothing Then
                    MessageBox.Show("Error. No se pudo crear el Pedido. No se encontró el Comercio")
                    Exit Sub
                End If


                Dim pro As Producto = busquedaProducto(Integer.Parse(fila.Cells("cIdProducto").Value), com.Productos1)
                If pro Is Nothing Then
                    MessageBox.Show("Error. No se pudo crear el Pedido. No se encontró el Producto")
                    Exit Sub
                End If


                Dim cant As Integer = Integer.Parse(fila.Cells("cCantidad").Value)


                Dim subTotal As Decimal = Decimal.Parse(fila.Cells("cSubTotal").Value)


                pedidoCompleto.agregarDetalle(New Detalle_Pedido(com, pro, cant, subTotal))
            Next

            pedidoCompleto.Total1 = Decimal.Parse(txtTotal.Text)
        End If

        Me.Hide()
        Dim frm As frmFormaPago = New frmFormaPago(pedidoCompleto)
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Function busquedaProducto(id As Integer, productos As List(Of Producto)) As Producto
        For Each p In productos
            If p.IdProducto1 = id Then
                Return p
            End If
        Next
        Return Nothing
    End Function

    Private Function busquedaComercio(id As Integer) As Comercio
        For Each c In comercios
            If c.IdComercio1 = id Then
                Return c
            End If
        Next
        Return Nothing
    End Function
End Class
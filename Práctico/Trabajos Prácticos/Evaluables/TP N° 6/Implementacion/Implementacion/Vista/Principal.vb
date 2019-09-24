Imports Implementacion

Public Class Principal
    Private comercios As List(Of Comercio)

    Public Property Comercios1 As List(Of Comercio)
        Get
            Return comercios
        End Get
        Set(value As List(Of Comercio))
            comercios = value
        End Set
    End Property

    Sub valoresHardCode()
        Me.comercios = New List(Of Comercio)

        Dim c1 As Comercio = New Comercio(1, "Fast Food")
        c1.agregarProducto(New Producto(1, "Lomito simple", 100, ".\\Imagenes\\Fast Food\\Lomito Simple.jpg"))
        c1.agregarProducto(New Producto(2, "Lomito completo", 240, ".\\Imagenes\\Fast Food\\Lomito Completo.png"))

        Dim c2 As Comercio = New Comercio(1, "Doña Ana")
        c2.agregarProducto(New Producto(1, "Sandwich  Milanesa", 150, ".\\Imagenes\\Doña Ana\\Sandwich Milanesa.jpeg"))
        c2.agregarProducto(New Producto(2, "Pizza comun", 50, ".\\Imagenes\\Doña Ana\\Pizza Comun.jpg"))

        comercios.Add(c1)
        comercios.Add(c2)
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valoresHardCode()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim pedidoCompleto As Pedido = New Pedido()

        Dim frm As ArmadoPedido = New ArmadoPedido(pedidoCompleto)
        frm.cargarComercios(comercios)
        frm.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("¿Seguro desea salir?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
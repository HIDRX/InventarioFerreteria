Imports System.Windows.Forms
Imports MySqlConnector
Public Class FrmProductos
    Private ReadOnly _productos As New ProductoRepositorio()
    Private ReadOnly _categorias As New CategoriaRepositorio()
    Private _idSeleccionado As Integer = 0
    Private Sub grpDatos_Enter(sender As Object, e As EventArgs) Handles grpDatos.Enter

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub grpAcciones_Enter(sender As Object, e As EventArgs) Handles grpAcciones.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mensaje As String = ""

        If Not ConexionBD.ProbarConexion(mensaje) Then
            MessageBox.Show("No fue posible conectar con MariaDB." & vbCrLf & mensaje,
                            "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblEstado.Text = "Sin conexión: revise el servicio MariaDB y ConexionBD.vb"
            grpDatos.Enabled = False
            grpAcciones.Enabled = False
            txtBuscar.Enabled = False
            btnBuscar.Enabled = False
            Return
        End If

        lblEstado.Text = mensaje
        CargarCategorias()
        CargarProductos()
        PrepararNuevo()
    End Sub
    Private Sub CargarCategorias()
        Try
            cboCategoria.DisplayMember = "Nombre"        ' lo que ve el usuario
            cboCategoria.ValueMember = "IdCategoria"     ' lo que usa el programa
            cboCategoria.DataSource = _categorias.Listar()
            cboCategoria.SelectedIndex = -1
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
    Private Sub CargarProductos(Optional filtro As String = "")
        Try
            dgvProductos.DataSource = _productos.Listar(filtro)
            FormatearGrid()
            dgvProductos.ClearSelection()
            lblTotal.Text = $"{dgvProductos.Rows.Count} producto(s)"
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
    Private Sub FormatearGrid()
        With dgvProductos
            .Columns("id_producto").Visible = False
            .Columns("codigo").HeaderText = "Código"
            .Columns("nombre").HeaderText = "Producto"
            .Columns("nombre").FillWeight = 220
            .Columns("categoria").HeaderText = "Categoría"
            .Columns("unidad").HeaderText = "Unidad"
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").DefaultCellStyle.Format = "'C$' #,##0.00"
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("existencia").HeaderText = "Existencia"
            .Columns("existencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("activo").HeaderText = "Activo"
        End With
    End Sub
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles dgvProductos.CellClick

        If e.RowIndex < 0 Then Return                   ' clic en el encabezado

        Dim id As Integer = CInt(dgvProductos.Rows(e.RowIndex).Cells("id_producto").Value)

        Try
            Dim p As Producto = _productos.ObtenerPorId(id)
            If p Is Nothing Then
                lblEstado.Text = "Ese producto ya no existe; se recargó la lista."
                CargarProductos(txtBuscar.Text)
                Return
            End If
            MostrarProducto(p)
            PrepararEdicion()
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarProductos(txtBuscar.Text)
        PrepararNuevo()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True                   ' evita el "beep"
            btnBuscar.PerformClick()
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        PrepararNuevo()
        txtCodigo.Focus()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Not ValidarFormulario() Then Return

            Dim nuevo As Producto = LeerFormulario()
            Dim idNuevo As Integer = _productos.Insertar(nuevo)

            CargarProductos(txtBuscar.Text)
            PrepararNuevo()
            lblEstado.Text = $"Agregado: «{nuevo.Nombre}» con ID {idNuevo}."
            txtCodigo.Focus()
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If _idSeleccionado = 0 Then Return

        Try
            If Not ValidarFormulario() Then Return

            Dim editado As Producto = LeerFormulario()
            Dim filas As Integer = _productos.Actualizar(editado)

            If filas = 0 Then
                MessageBox.Show("El producto ya no existe en la base de datos.",
                                "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lblEstado.Text = $"Actualizado: «{editado.Nombre}»."
            End If

            CargarProductos(txtBuscar.Text)
            SeleccionarFila(editado.IdProducto)
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If _idSeleccionado = 0 Then Return

        Dim respuesta As DialogResult =
            MessageBox.Show($"¿Eliminar definitivamente «{txtNombre.Text}»?" & vbCrLf &
                            "Esta acción no se puede deshacer.",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2)

        If respuesta <> DialogResult.Yes Then Return

        Try
            Dim nombre As String = txtNombre.Text
            _productos.Eliminar(_idSeleccionado)
            CargarProductos(txtBuscar.Text)
            PrepararNuevo()
            lblEstado.Text = $"Eliminado: «{nombre}»."
        Catch ex As MySqlException
            MostrarErrorBD(ex)
        End Try
    End Sub
End Class
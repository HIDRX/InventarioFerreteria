Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmProductos

    Private ReadOnly dtProductos As New DataTable()

    Private txtId As TextBox
    Private txtNombre As TextBox
    Private txtDescripcion As TextBox
    Private txtPrecio As TextBox
    Private txtStock As TextBox

    Private btnNuevo As Button
    Private btnGuardar As Button
    Private btnEditar As Button
    Private btnEliminar As Button

    Private dgvProductos As DataGridView

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarFormulario()
        CrearControles()
        CrearTabla()
        CargarDatosPrueba()
    End Sub

    Private Sub ConfigurarFormulario()

        Me.Text = "Inventario de Ferretería - Productos"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(950, 600)
        Me.MinimumSize = New Size(850, 550)

    End Sub

    Private Sub CrearControles()

        Dim lblTitulo As New Label()
        lblTitulo.Text = "Registro de Productos"
        lblTitulo.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(30, 20)
        Me.Controls.Add(lblTitulo)

        ' ID
        Dim lblId As New Label()
        lblId.Text = "ID:"
        lblId.Location = New Point(30, 80)
        lblId.AutoSize = True
        Me.Controls.Add(lblId)

        txtId = New TextBox()
        txtId.Location = New Point(150, 75)
        txtId.Width = 200
        txtId.ReadOnly = True
        Me.Controls.Add(txtId)

        ' Nombre
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre:"
        lblNombre.Location = New Point(30, 120)
        lblNombre.AutoSize = True
        Me.Controls.Add(lblNombre)

        txtNombre = New TextBox()
        txtNombre.Location = New Point(150, 115)
        txtNombre.Width = 250
        Me.Controls.Add(txtNombre)

        ' Descripción
        Dim lblDescripcion As New Label()
        lblDescripcion.Text = "Descripción:"
        lblDescripcion.Location = New Point(30, 160)
        lblDescripcion.AutoSize = True
        Me.Controls.Add(lblDescripcion)

        txtDescripcion = New TextBox()
        txtDescripcion.Location = New Point(150, 155)
        txtDescripcion.Width = 350
        Me.Controls.Add(txtDescripcion)

        ' Precio
        Dim lblPrecio As New Label()
        lblPrecio.Text = "Precio:"
        lblPrecio.Location = New Point(30, 200)
        lblPrecio.AutoSize = True
        Me.Controls.Add(lblPrecio)

        txtPrecio = New TextBox()
        txtPrecio.Location = New Point(150, 195)
        txtPrecio.Width = 150
        Me.Controls.Add(txtPrecio)

        ' Stock
        Dim lblStock As New Label()
        lblStock.Text = "Stock:"
        lblStock.Location = New Point(330, 200)
        lblStock.AutoSize = True
        Me.Controls.Add(lblStock)

        txtStock = New TextBox()
        txtStock.Location = New Point(390, 195)
        txtStock.Width = 110
        Me.Controls.Add(txtStock)

        ' Botón Nuevo
        btnNuevo = New Button()
        btnNuevo.Text = "Nuevo"
        btnNuevo.Location = New Point(30, 245)
        btnNuevo.Size = New Size(100, 35)
        AddHandler btnNuevo.Click, AddressOf btnNuevo_Click
        Me.Controls.Add(btnNuevo)

        ' Botón Guardar
        btnGuardar = New Button()
        btnGuardar.Text = "Guardar"
        btnGuardar.Location = New Point(145, 245)
        btnGuardar.Size = New Size(100, 35)
        AddHandler btnGuardar.Click, AddressOf btnGuardar_Click
        Me.Controls.Add(btnGuardar)

        ' Botón Editar
        btnEditar = New Button()
        btnEditar.Text = "Editar"
        btnEditar.Location = New Point(260, 245)
        btnEditar.Size = New Size(100, 35)
        AddHandler btnEditar.Click, AddressOf btnEditar_Click
        Me.Controls.Add(btnEditar)

        ' Botón Eliminar
        btnEliminar = New Button()
        btnEliminar.Text = "Eliminar"
        btnEliminar.Location = New Point(375, 245)
        btnEliminar.Size = New Size(100, 35)
        AddHandler btnEliminar.Click, AddressOf btnEliminar_Click
        Me.Controls.Add(btnEliminar)

        ' Tabla
        dgvProductos = New DataGridView()
        dgvProductos.Location = New Point(30, 310)
        dgvProductos.Size = New Size(870, 220)
        dgvProductos.Anchor =
            AnchorStyles.Top Or
            AnchorStyles.Bottom Or
            AnchorStyles.Left Or
            AnchorStyles.Right

        dgvProductos.ReadOnly = True
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.MultiSelect = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        AddHandler dgvProductos.CellClick, AddressOf dgvProductos_CellClick

        Me.Controls.Add(dgvProductos)

    End Sub

    Private Sub CrearTabla()

        dtProductos.Columns.Add("Id", GetType(Integer))
        dtProductos.Columns.Add("Nombre", GetType(String))
        dtProductos.Columns.Add("Descripcion", GetType(String))
        dtProductos.Columns.Add("Precio", GetType(Decimal))
        dtProductos.Columns.Add("Stock", GetType(Integer))

        dgvProductos.DataSource = dtProductos

    End Sub

    Private Sub CargarDatosPrueba()

        dtProductos.Rows.Add(1, "Martillo", "Martillo de acero", 250D, 15)
        dtProductos.Rows.Add(2, "Destornillador", "Destornillador estrella", 120D, 25)
        dtProductos.Rows.Add(3, "Taladro", "Taladro eléctrico", 2500D, 5)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)

        LimpiarCampos()
        txtNombre.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

        If Not ValidarCampos() Then
            Exit Sub
        End If

        Dim precio As Decimal
        Dim stock As Integer

        Decimal.TryParse(txtPrecio.Text, precio)
        Integer.TryParse(txtStock.Text, stock)

        Dim nuevoId As Integer = ObtenerNuevoId()

        dtProductos.Rows.Add(
            nuevoId,
            txtNombre.Text.Trim(),
            txtDescripcion.Text.Trim(),
            precio,
            stock
        )

        MessageBox.Show(
            "Producto guardado correctamente.",
            "Inventario",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        LimpiarCampos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

        If txtId.Text = "" Then

            MessageBox.Show(
                "Seleccione un producto para editar.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        If Not ValidarCampos() Then
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(txtId.Text)

        Dim filas() As DataRow =
            dtProductos.Select("Id = " & id)

        If filas.Length > 0 Then

            Dim precio As Decimal
            Dim stock As Integer

            Decimal.TryParse(txtPrecio.Text, precio)
            Integer.TryParse(txtStock.Text, stock)

            filas(0)("Nombre") = txtNombre.Text.Trim()
            filas(0)("Descripcion") = txtDescripcion.Text.Trim()
            filas(0)("Precio") = precio
            filas(0)("Stock") = stock

            MessageBox.Show(
                "Producto actualizado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LimpiarCampos()

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

        If txtId.Text = "" Then

            MessageBox.Show(
                "Seleccione un producto para eliminar.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If respuesta <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(txtId.Text)

        Dim filas() As DataRow =
            dtProductos.Select("Id = " & id)

        If filas.Length > 0 Then

            dtProductos.Rows.Remove(filas(0))

            MessageBox.Show(
                "Producto eliminado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LimpiarCampos()

        End If

    End Sub

    Private Sub dgvProductos_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs)

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim fila As DataGridViewRow =
            dgvProductos.Rows(e.RowIndex)

        txtId.Text = fila.Cells("Id").Value.ToString()
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
        txtPrecio.Text = fila.Cells("Precio").Value.ToString()
        txtStock.Text = fila.Cells("Stock").Value.ToString()

    End Sub

    Private Function ValidarCampos() As Boolean

        If txtNombre.Text.Trim() = "" Then

            MessageBox.Show("Ingrese el nombre del producto.")
            txtNombre.Focus()
            Return False

        End If

        Dim precio As Decimal

        If Not Decimal.TryParse(txtPrecio.Text, precio) Then

            MessageBox.Show("Ingrese un precio válido.")
            txtPrecio.Focus()
            Return False

        End If

        If precio < 0 Then

            MessageBox.Show("El precio no puede ser negativo.")
            txtPrecio.Focus()
            Return False

        End If

        Dim stock As Integer

        If Not Integer.TryParse(txtStock.Text, stock) Then

            MessageBox.Show("Ingrese un stock válido.")
            txtStock.Focus()
            Return False

        End If

        If stock < 0 Then

            MessageBox.Show("El stock no puede ser negativo.")
            txtStock.Focus()
            Return False

        End If

        Return True

    End Function

    Private Function ObtenerNuevoId() As Integer

        If dtProductos.Rows.Count = 0 Then
            Return 1
        End If

        Dim mayor As Integer = 0

        For Each fila As DataRow In dtProductos.Rows

            Dim id As Integer =
                Convert.ToInt32(fila("Id"))

            If id > mayor Then
                mayor = id
            End If

        Next

        Return mayor + 1

    End Function

    Private Sub LimpiarCampos()

        txtId.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtStock.Clear()

        dgvProductos.ClearSelection()

    End Sub

End Class

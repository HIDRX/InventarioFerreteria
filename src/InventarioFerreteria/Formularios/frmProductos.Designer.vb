<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        components = New ComponentModel.Container()
        lblTitulo = New System.Windows.Forms.Label()
        lblIdValor = New System.Windows.Forms.Label()
        txtCodigo = New System.Windows.Forms.TextBox()
        txtNombre = New System.Windows.Forms.TextBox()
        cboCategoria = New System.Windows.Forms.ComboBox()
        cboUnidad = New System.Windows.Forms.ComboBox()
        nudPrecio = New System.Windows.Forms.NumericUpDown()
        nudExistencia = New System.Windows.Forms.NumericUpDown()
        chkActivo = New System.Windows.Forms.CheckBox()
        grpAcciones = New System.Windows.Forms.GroupBox()
        btnEliminar = New System.Windows.Forms.Button()
        btnActualizar = New System.Windows.Forms.Button()
        btnAgregar = New System.Windows.Forms.Button()
        btnNuevo = New System.Windows.Forms.Button()
        grpDatos = New System.Windows.Forms.GroupBox()
        txtBuscar = New System.Windows.Forms.TextBox()
        btnBuscar = New System.Windows.Forms.Button()
        dgvProductos = New System.Windows.Forms.DataGridView()
        ssEstados = New System.Windows.Forms.StatusStrip()
        lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        errValidacion = New System.Windows.Forms.ErrorProvider(components)
        ttAyuda = New System.Windows.Forms.ToolTip(components)
        CType(nudPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).BeginInit()
        grpAcciones.SuspendLayout()
        grpDatos.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        ssEstados.SuspendLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Segoe UI Light", 14F)
        lblTitulo.Location = New System.Drawing.Point(16, 12)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(208, 25)
        lblTitulo.TabIndex = 4
        lblTitulo.Text = "Inventario de productos "
        ' 
        ' lblIdValor
        ' 
        lblIdValor.AutoSize = True
        lblIdValor.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        lblIdValor.Location = New System.Drawing.Point(120, 32)
        lblIdValor.Name = "lblIdValor"
        lblIdValor.Size = New System.Drawing.Size(48, 15)
        lblIdValor.TabIndex = 0
        lblIdValor.Text = "(nuevo)"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txtCodigo.Location = New System.Drawing.Point(120, 64)
        txtCodigo.MaxLength = 15
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New System.Drawing.Size(200, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New System.Drawing.Point(120, 93)
        txtNombre.MaxLength = 100
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(200, 23)
        txtNombre.TabIndex = 2
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New System.Drawing.Point(120, 122)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New System.Drawing.Size(121, 23)
        cboCategoria.TabIndex = 3
        ' 
        ' cboUnidad
        ' 
        cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboUnidad.FormattingEnabled = True
        cboUnidad.Items.AddRange(New Object() {"Unidad", "Libra", "Galón", "Metro", "Bolsa", "Caja", "Rollo", " "})
        cboUnidad.Location = New System.Drawing.Point(120, 151)
        cboUnidad.Name = "cboUnidad"
        cboUnidad.Size = New System.Drawing.Size(121, 23)
        cboUnidad.TabIndex = 4
        ' 
        ' nudPrecio
        ' 
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudPrecio.Location = New System.Drawing.Point(120, 180)
        nudPrecio.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New System.Drawing.Size(120, 23)
        nudPrecio.TabIndex = 5
        nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudPrecio.ThousandsSeparator = True
        ' 
        ' nudExistencia
        ' 
        nudExistencia.Location = New System.Drawing.Point(120, 209)
        nudExistencia.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExistencia.Name = "nudExistencia"
        nudExistencia.Size = New System.Drawing.Size(120, 23)
        nudExistencia.TabIndex = 6
        nudExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudExistencia.ThousandsSeparator = True
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        chkActivo.Location = New System.Drawing.Point(120, 247)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New System.Drawing.Size(110, 19)
        chkActivo.TabIndex = 7
        chkActivo.Text = "Producto activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' grpAcciones
        ' 
        grpAcciones.Controls.Add(btnEliminar)
        grpAcciones.Controls.Add(btnActualizar)
        grpAcciones.Controls.Add(btnAgregar)
        grpAcciones.Controls.Add(btnNuevo)
        grpAcciones.Location = New System.Drawing.Point(16, 368)
        grpAcciones.Name = "grpAcciones"
        grpAcciones.Size = New System.Drawing.Size(340, 124)
        grpAcciones.TabIndex = 6
        grpAcciones.TabStop = False
        grpAcciones.Text = "Operaciones"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Location = New System.Drawing.Point(219, 88)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(75, 23)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "&Eliminar "
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Enabled = False
        btnActualizar.Location = New System.Drawing.Point(24, 88)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New System.Drawing.Size(75, 23)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = " A&ctualizar "
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New System.Drawing.Point(186, 36)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New System.Drawing.Size(148, 36)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = " &Agregar "
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New System.Drawing.Point(6, 36)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(148, 36)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = " &Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' grpDatos
        ' 
        grpDatos.Controls.Add(chkActivo)
        grpDatos.Controls.Add(nudExistencia)
        grpDatos.Controls.Add(nudPrecio)
        grpDatos.Controls.Add(cboUnidad)
        grpDatos.Controls.Add(cboCategoria)
        grpDatos.Controls.Add(txtNombre)
        grpDatos.Controls.Add(txtCodigo)
        grpDatos.Controls.Add(lblIdValor)
        grpDatos.Location = New System.Drawing.Point(16, 52)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New System.Drawing.Size(340, 306)
        grpDatos.TabIndex = 5
        grpDatos.TabStop = False
        grpDatos.Text = "Datos el producto"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        txtBuscar.Location = New System.Drawing.Point(420, 65)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Código o nombre del producto"
        txtBuscar.Size = New System.Drawing.Size(420, 23)
        txtBuscar.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnBuscar.Location = New System.Drawing.Point(913, 65)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New System.Drawing.Size(75, 23)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = " &Buscar "
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New System.Drawing.Point(408, 119)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.ReadOnly = True
        dgvProductos.RowHeadersVisible = False
        dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New System.Drawing.Size(545, 373)
        dgvProductos.TabIndex = 1
        ' 
        ' ssEstados
        ' 
        ssEstados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {lblEstado, lblTotal})
        ssEstados.Location = New System.Drawing.Point(0, 564)
        ssEstados.Name = "ssEstados"
        ssEstados.Size = New System.Drawing.Size(1000, 22)
        ssEstados.TabIndex = 3
        ssEstados.Text = "StatusStrip1"
        ' 
        ' lblEstado
        ' 
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(492, 17)
        lblEstado.Spring = True
        lblEstado.Text = "ToolStripStatusLabel1"
        lblEstado.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' lblTotal
        ' 
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(492, 17)
        lblTotal.Spring = True
        lblTotal.Text = "ToolStripStatusLabel1"
        lblTotal.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' errValidacion
        ' 
        errValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        errValidacion.ContainerControl = Me
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1000, 586)
        Controls.Add(ssEstados)
        Controls.Add(dgvProductos)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(grpAcciones)
        Controls.Add(grpDatos)
        Controls.Add(lblTitulo)
        MinimumSize = New System.Drawing.Size(1016, 569)
        Name = "FrmProductos"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Ferretería Los Robles · Inventario ·"
        CType(nudPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).EndInit()
        grpAcciones.ResumeLayout(False)
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ssEstados.ResumeLayout(False)
        ssEstados.PerformLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblIdValor As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents grpAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ssEstados As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents errValidacion As System.Windows.Forms.ErrorProvider
    Friend WithEvents ttAyuda As System.Windows.Forms.ToolTip
End Class

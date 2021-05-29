<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peliculas
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvListar = New System.Windows.Forms.DataGridView()
        Me.Movie_CenterDataSet = New WindowsApplication1.Movie_CenterDataSet()
        Me.PELICULASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PELICULASTableAdapter = New WindowsApplication1.Movie_CenterDataSetTableAdapters.PELICULASTableAdapter()
        Me.NumiventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdiomasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumrentasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumejemplaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mm = New System.Windows.Forms.Label()
        Me.dad = New System.Windows.Forms.Label()
        Me.dsd = New System.Windows.Forms.Label()
        Me.wd = New System.Windows.Forms.Label()
        Me.lblSin = New System.Windows.Forms.Label()
        Me.lblNr = New System.Windows.Forms.Label()
        Me.lblNe = New System.Windows.Forms.Label()
        Me.txtNi = New System.Windows.Forms.TextBox()
        Me.txtTi = New System.Windows.Forms.TextBox()
        Me.txtGe = New System.Windows.Forms.TextBox()
        Me.txtIdi = New System.Windows.Forms.TextBox()
        Me.txtSin = New System.Windows.Forms.TextBox()
        Me.txtNr = New System.Windows.Forms.TextBox()
        Me.txtNe = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PELICULASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListar
        '
        Me.dgvListar.AutoGenerateColumns = False
        Me.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumiventarioDataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.IdiomasDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn, Me.NumrentasDataGridViewTextBoxColumn, Me.NumejemplaresDataGridViewTextBoxColumn})
        Me.dgvListar.DataSource = Me.PELICULASBindingSource
        Me.dgvListar.Location = New System.Drawing.Point(50, 122)
        Me.dgvListar.Name = "dgvListar"
        Me.dgvListar.Size = New System.Drawing.Size(743, 220)
        Me.dgvListar.TabIndex = 0
        '
        'Movie_CenterDataSet
        '
        Me.Movie_CenterDataSet.DataSetName = "Movie_CenterDataSet"
        Me.Movie_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PELICULASBindingSource
        '
        Me.PELICULASBindingSource.DataMember = "PELICULAS"
        Me.PELICULASBindingSource.DataSource = Me.Movie_CenterDataSet
        '
        'PELICULASTableAdapter
        '
        Me.PELICULASTableAdapter.ClearBeforeFill = True
        '
        'NumiventarioDataGridViewTextBoxColumn
        '
        Me.NumiventarioDataGridViewTextBoxColumn.DataPropertyName = "Num_iventario"
        Me.NumiventarioDataGridViewTextBoxColumn.HeaderText = "Num_iventario"
        Me.NumiventarioDataGridViewTextBoxColumn.Name = "NumiventarioDataGridViewTextBoxColumn"
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        '
        'IdiomasDataGridViewTextBoxColumn
        '
        Me.IdiomasDataGridViewTextBoxColumn.DataPropertyName = "Idiomas"
        Me.IdiomasDataGridViewTextBoxColumn.HeaderText = "Idiomas"
        Me.IdiomasDataGridViewTextBoxColumn.Name = "IdiomasDataGridViewTextBoxColumn"
        '
        'SinopsisDataGridViewTextBoxColumn
        '
        Me.SinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.Name = "SinopsisDataGridViewTextBoxColumn"
        '
        'NumrentasDataGridViewTextBoxColumn
        '
        Me.NumrentasDataGridViewTextBoxColumn.DataPropertyName = "Num_rentas"
        Me.NumrentasDataGridViewTextBoxColumn.HeaderText = "Num_rentas"
        Me.NumrentasDataGridViewTextBoxColumn.Name = "NumrentasDataGridViewTextBoxColumn"
        '
        'NumejemplaresDataGridViewTextBoxColumn
        '
        Me.NumejemplaresDataGridViewTextBoxColumn.DataPropertyName = "Num_ejemplares"
        Me.NumejemplaresDataGridViewTextBoxColumn.HeaderText = "Num_ejemplares"
        Me.NumejemplaresDataGridViewTextBoxColumn.Name = "NumejemplaresDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de Películas"
        '
        'mm
        '
        Me.mm.AutoSize = True
        Me.mm.Location = New System.Drawing.Point(23, 370)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(81, 13)
        Me.mm.TabIndex = 2
        Me.mm.Text = "Num_inventario"
        '
        'dad
        '
        Me.dad.AutoSize = True
        Me.dad.Location = New System.Drawing.Point(168, 370)
        Me.dad.Name = "dad"
        Me.dad.Size = New System.Drawing.Size(33, 13)
        Me.dad.TabIndex = 3
        Me.dad.Text = "Titulo"
        '
        'dsd
        '
        Me.dsd.AutoSize = True
        Me.dsd.Location = New System.Drawing.Point(277, 370)
        Me.dsd.Name = "dsd"
        Me.dsd.Size = New System.Drawing.Size(42, 13)
        Me.dsd.TabIndex = 4
        Me.dsd.Text = "Genero"
        '
        'wd
        '
        Me.wd.AutoSize = True
        Me.wd.Location = New System.Drawing.Point(396, 370)
        Me.wd.Name = "wd"
        Me.wd.Size = New System.Drawing.Size(43, 13)
        Me.wd.TabIndex = 5
        Me.wd.Text = "Idiomas"
        '
        'lblSin
        '
        Me.lblSin.AutoSize = True
        Me.lblSin.Location = New System.Drawing.Point(518, 370)
        Me.lblSin.Name = "lblSin"
        Me.lblSin.Size = New System.Drawing.Size(46, 13)
        Me.lblSin.TabIndex = 6
        Me.lblSin.Text = "Sinopsis"
        '
        'lblNr
        '
        Me.lblNr.AutoSize = True
        Me.lblNr.Location = New System.Drawing.Point(617, 370)
        Me.lblNr.Name = "lblNr"
        Me.lblNr.Size = New System.Drawing.Size(69, 13)
        Me.lblNr.TabIndex = 7
        Me.lblNr.Text = "Num_Rentas"
        '
        'lblNe
        '
        Me.lblNe.AutoSize = True
        Me.lblNe.Location = New System.Drawing.Point(735, 370)
        Me.lblNe.Name = "lblNe"
        Me.lblNe.Size = New System.Drawing.Size(85, 13)
        Me.lblNe.TabIndex = 8
        Me.lblNe.Text = "Num_ejemplares"
        '
        'txtNi
        '
        Me.txtNi.Location = New System.Drawing.Point(16, 403)
        Me.txtNi.Name = "txtNi"
        Me.txtNi.Size = New System.Drawing.Size(100, 20)
        Me.txtNi.TabIndex = 9
        '
        'txtTi
        '
        Me.txtTi.Location = New System.Drawing.Point(131, 403)
        Me.txtTi.Name = "txtTi"
        Me.txtTi.Size = New System.Drawing.Size(100, 20)
        Me.txtTi.TabIndex = 10
        '
        'txtGe
        '
        Me.txtGe.Location = New System.Drawing.Point(248, 403)
        Me.txtGe.Name = "txtGe"
        Me.txtGe.Size = New System.Drawing.Size(100, 20)
        Me.txtGe.TabIndex = 11
        '
        'txtIdi
        '
        Me.txtIdi.Location = New System.Drawing.Point(366, 403)
        Me.txtIdi.Name = "txtIdi"
        Me.txtIdi.Size = New System.Drawing.Size(100, 20)
        Me.txtIdi.TabIndex = 12
        '
        'txtSin
        '
        Me.txtSin.Location = New System.Drawing.Point(484, 403)
        Me.txtSin.Name = "txtSin"
        Me.txtSin.Size = New System.Drawing.Size(100, 20)
        Me.txtSin.TabIndex = 13
        '
        'txtNr
        '
        Me.txtNr.Location = New System.Drawing.Point(603, 403)
        Me.txtNr.Name = "txtNr"
        Me.txtNr.Size = New System.Drawing.Size(100, 20)
        Me.txtNr.TabIndex = 14
        '
        'txtNe
        '
        Me.txtNe.Location = New System.Drawing.Point(720, 403)
        Me.txtNe.Name = "txtNe"
        Me.txtNe.Size = New System.Drawing.Size(100, 20)
        Me.txtNe.TabIndex = 15
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(87, 445)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 16
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(216, 445)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(364, 445)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(509, 445)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(729, 445)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Regresar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Peliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 484)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtNe)
        Me.Controls.Add(Me.txtNr)
        Me.Controls.Add(Me.txtSin)
        Me.Controls.Add(Me.txtIdi)
        Me.Controls.Add(Me.txtGe)
        Me.Controls.Add(Me.txtTi)
        Me.Controls.Add(Me.txtNi)
        Me.Controls.Add(Me.lblNe)
        Me.Controls.Add(Me.lblNr)
        Me.Controls.Add(Me.lblSin)
        Me.Controls.Add(Me.wd)
        Me.Controls.Add(Me.dsd)
        Me.Controls.Add(Me.dad)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvListar)
        Me.Name = "Peliculas"
        Me.Text = "Peliculas"
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PELICULASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListar As System.Windows.Forms.DataGridView
    Friend WithEvents Movie_CenterDataSet As WindowsApplication1.Movie_CenterDataSet
    Friend WithEvents PELICULASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PELICULASTableAdapter As WindowsApplication1.Movie_CenterDataSetTableAdapters.PELICULASTableAdapter
    Friend WithEvents NumiventarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdiomasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumrentasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumejemplaresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mm As System.Windows.Forms.Label
    Friend WithEvents dad As System.Windows.Forms.Label
    Friend WithEvents dsd As System.Windows.Forms.Label
    Friend WithEvents wd As System.Windows.Forms.Label
    Friend WithEvents lblSin As System.Windows.Forms.Label
    Friend WithEvents lblNr As System.Windows.Forms.Label
    Friend WithEvents lblNe As System.Windows.Forms.Label
    Friend WithEvents txtNi As System.Windows.Forms.TextBox
    Friend WithEvents txtTi As System.Windows.Forms.TextBox
    Friend WithEvents txtGe As System.Windows.Forms.TextBox
    Friend WithEvents txtIdi As System.Windows.Forms.TextBox
    Friend WithEvents txtSin As System.Windows.Forms.TextBox
    Friend WithEvents txtNr As System.Windows.Forms.TextBox
    Friend WithEvents txtNe As System.Windows.Forms.TextBox
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class

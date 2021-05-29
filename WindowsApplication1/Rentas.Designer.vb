<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rentas
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
        Me.RENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RENTATableAdapter = New WindowsApplication1.Movie_CenterDataSetTableAdapters.RENTATableAdapter()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeliculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecharentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRentas = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ada = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtus = New System.Windows.Forms.TextBox()
        Me.txtpel = New System.Windows.Forms.TextBox()
        Me.txtcos = New System.Windows.Forms.TextBox()
        Me.txtfr = New System.Windows.Forms.TextBox()
        Me.txtfe = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListar
        '
        Me.dgvListar.AutoGenerateColumns = False
        Me.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioDataGridViewTextBoxColumn, Me.PeliculaDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.FecharentaDataGridViewTextBoxColumn, Me.FechaentregaDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn})
        Me.dgvListar.DataSource = Me.RENTABindingSource
        Me.dgvListar.Location = New System.Drawing.Point(109, 160)
        Me.dgvListar.Name = "dgvListar"
        Me.dgvListar.Size = New System.Drawing.Size(642, 150)
        Me.dgvListar.TabIndex = 0
        '
        'Movie_CenterDataSet
        '
        Me.Movie_CenterDataSet.DataSetName = "Movie_CenterDataSet"
        Me.Movie_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RENTABindingSource
        '
        Me.RENTABindingSource.DataMember = "RENTA"
        Me.RENTABindingSource.DataSource = Me.Movie_CenterDataSet
        '
        'RENTATableAdapter
        '
        Me.RENTATableAdapter.ClearBeforeFill = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'PeliculaDataGridViewTextBoxColumn
        '
        Me.PeliculaDataGridViewTextBoxColumn.DataPropertyName = "Pelicula"
        Me.PeliculaDataGridViewTextBoxColumn.HeaderText = "Pelicula"
        Me.PeliculaDataGridViewTextBoxColumn.Name = "PeliculaDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'FecharentaDataGridViewTextBoxColumn
        '
        Me.FecharentaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_renta"
        Me.FecharentaDataGridViewTextBoxColumn.HeaderText = "Fecha_renta"
        Me.FecharentaDataGridViewTextBoxColumn.Name = "FecharentaDataGridViewTextBoxColumn"
        '
        'FechaentregaDataGridViewTextBoxColumn
        '
        Me.FechaentregaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.HeaderText = "Fecha_entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.Name = "FechaentregaDataGridViewTextBoxColumn"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'lblRentas
        '
        Me.lblRentas.AutoSize = True
        Me.lblRentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentas.Location = New System.Drawing.Point(261, 51)
        Me.lblRentas.Name = "lblRentas"
        Me.lblRentas.Size = New System.Drawing.Size(336, 42)
        Me.lblRentas.TabIndex = 1
        Me.lblRentas.Text = "Control de Rentas"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(71, 331)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.lblusuario.TabIndex = 2
        Me.lblusuario.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pelicula"
        '
        'ada
        '
        Me.ada.AutoSize = True
        Me.ada.Location = New System.Drawing.Point(318, 331)
        Me.ada.Name = "ada"
        Me.ada.Size = New System.Drawing.Size(34, 13)
        Me.ada.TabIndex = 4
        Me.ada.Text = "Costo"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(435, 331)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(67, 13)
        Me.lbl.TabIndex = 5
        Me.lbl.Text = "Fecha_renta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(548, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha_entrega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(696, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Codigo"
        '
        'txtus
        '
        Me.txtus.Location = New System.Drawing.Point(38, 360)
        Me.txtus.Name = "txtus"
        Me.txtus.Size = New System.Drawing.Size(100, 20)
        Me.txtus.TabIndex = 8
        '
        'txtpel
        '
        Me.txtpel.Location = New System.Drawing.Point(157, 360)
        Me.txtpel.Name = "txtpel"
        Me.txtpel.Size = New System.Drawing.Size(100, 20)
        Me.txtpel.TabIndex = 9
        '
        'txtcos
        '
        Me.txtcos.Location = New System.Drawing.Point(280, 359)
        Me.txtcos.Name = "txtcos"
        Me.txtcos.Size = New System.Drawing.Size(100, 20)
        Me.txtcos.TabIndex = 10
        '
        'txtfr
        '
        Me.txtfr.Location = New System.Drawing.Point(402, 359)
        Me.txtfr.Name = "txtfr"
        Me.txtfr.Size = New System.Drawing.Size(100, 20)
        Me.txtfr.TabIndex = 11
        '
        'txtfe
        '
        Me.txtfe.Location = New System.Drawing.Point(527, 359)
        Me.txtfe.Name = "txtfe"
        Me.txtfe.Size = New System.Drawing.Size(100, 20)
        Me.txtfe.TabIndex = 12
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(660, 359)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 20)
        Me.txtcod.TabIndex = 13
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(109, 398)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 14
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(252, 398)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(388, 398)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(536, 398)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 17
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(676, 398)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 18
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Rentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 468)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txtfe)
        Me.Controls.Add(Me.txtfr)
        Me.Controls.Add(Me.txtcos)
        Me.Controls.Add(Me.txtpel)
        Me.Controls.Add(Me.txtus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.ada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblRentas)
        Me.Controls.Add(Me.dgvListar)
        Me.Name = "Rentas"
        Me.Text = "Rentas"
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListar As System.Windows.Forms.DataGridView
    Friend WithEvents Movie_CenterDataSet As WindowsApplication1.Movie_CenterDataSet
    Friend WithEvents RENTABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RENTATableAdapter As WindowsApplication1.Movie_CenterDataSetTableAdapters.RENTATableAdapter
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeliculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecharentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaentregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRentas As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ada As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtus As System.Windows.Forms.TextBox
    Friend WithEvents txtpel As System.Windows.Forms.TextBox
    Friend WithEvents txtcos As System.Windows.Forms.TextBox
    Friend WithEvents txtfr As System.Windows.Forms.TextBox
    Friend WithEvents txtfe As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class

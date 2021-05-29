<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.IDUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonomovilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoFijoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_CenterDataSet = New WindowsApplication1.Movie_CenterDataSet()
        Me.CLIENTETableAdapter = New WindowsApplication1.Movie_CenterDataSetTableAdapters.CLIENTETableAdapter()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdir = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtco = New System.Windows.Forms.TextBox()
        Me.txtem = New System.Windows.Forms.TextBox()
        Me.txttm = New System.Windows.Forms.TextBox()
        Me.txttf = New System.Windows.Forms.TextBox()
        Me.txtdi = New System.Windows.Forms.TextBox()
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListar
        '
        Me.dgvListar.AutoGenerateColumns = False
        Me.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUsuarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonomovilDataGridViewTextBoxColumn, Me.TelefonoFijoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.dgvListar.DataSource = Me.CLIENTEBindingSource
        Me.dgvListar.Location = New System.Drawing.Point(84, 107)
        Me.dgvListar.Name = "dgvListar"
        Me.dgvListar.Size = New System.Drawing.Size(744, 193)
        Me.dgvListar.TabIndex = 0
        '
        'IDUsuarioDataGridViewTextBoxColumn
        '
        Me.IDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.Name = "IDUsuarioDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelefonomovilDataGridViewTextBoxColumn
        '
        Me.TelefonomovilDataGridViewTextBoxColumn.DataPropertyName = "Telefono_movil"
        Me.TelefonomovilDataGridViewTextBoxColumn.HeaderText = "Telefono_movil"
        Me.TelefonomovilDataGridViewTextBoxColumn.Name = "TelefonomovilDataGridViewTextBoxColumn"
        '
        'TelefonoFijoDataGridViewTextBoxColumn
        '
        Me.TelefonoFijoDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Fijo"
        Me.TelefonoFijoDataGridViewTextBoxColumn.HeaderText = "Telefono_Fijo"
        Me.TelefonoFijoDataGridViewTextBoxColumn.Name = "TelefonoFijoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.Movie_CenterDataSet
        '
        'Movie_CenterDataSet
        '
        Me.Movie_CenterDataSet.DataSetName = "Movie_CenterDataSet"
        Me.Movie_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(84, 419)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 1
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(227, 419)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(403, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(547, 419)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(681, 420)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Administrar Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID_Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(498, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefono_movil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(615, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Telefono_Fijo"
        '
        'txtdir
        '
        Me.txtdir.AutoSize = True
        Me.txtdir.Location = New System.Drawing.Point(731, 329)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(52, 13)
        Me.txtdir.TabIndex = 13
        Me.txtdir.Text = "Direccion"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 364)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 14
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(133, 363)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 20)
        Me.txtNo.TabIndex = 15
        '
        'txtco
        '
        Me.txtco.Location = New System.Drawing.Point(254, 363)
        Me.txtco.Name = "txtco"
        Me.txtco.Size = New System.Drawing.Size(100, 20)
        Me.txtco.TabIndex = 16
        '
        'txtem
        '
        Me.txtem.Location = New System.Drawing.Point(369, 363)
        Me.txtem.Name = "txtem"
        Me.txtem.Size = New System.Drawing.Size(100, 20)
        Me.txtem.TabIndex = 17
        '
        'txttm
        '
        Me.txttm.Location = New System.Drawing.Point(485, 364)
        Me.txttm.Name = "txttm"
        Me.txttm.Size = New System.Drawing.Size(100, 20)
        Me.txttm.TabIndex = 18
        '
        'txttf
        '
        Me.txttf.Location = New System.Drawing.Point(602, 363)
        Me.txttf.Name = "txttf"
        Me.txttf.Size = New System.Drawing.Size(100, 20)
        Me.txttf.TabIndex = 19
        '
        'txtdi
        '
        Me.txtdi.Location = New System.Drawing.Point(718, 363)
        Me.txtdi.Name = "txtdi"
        Me.txtdi.Size = New System.Drawing.Size(100, 20)
        Me.txtdi.TabIndex = 20
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 454)
        Me.Controls.Add(Me.txtdi)
        Me.Controls.Add(Me.txttf)
        Me.Controls.Add(Me.txttm)
        Me.Controls.Add(Me.txtem)
        Me.Controls.Add(Me.txtco)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtdir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.dgvListar)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_CenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListar As System.Windows.Forms.DataGridView
    Friend WithEvents Movie_CenterDataSet As WindowsApplication1.Movie_CenterDataSet
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As WindowsApplication1.Movie_CenterDataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents IDUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonomovilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoFijoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdir As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents txtco As System.Windows.Forms.TextBox
    Friend WithEvents txtem As System.Windows.Forms.TextBox
    Friend WithEvents txttm As System.Windows.Forms.TextBox
    Friend WithEvents txttf As System.Windows.Forms.TextBox
    Friend WithEvents txtdi As System.Windows.Forms.TextBox
End Class

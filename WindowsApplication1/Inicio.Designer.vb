<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.sesion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcont = New System.Windows.Forms.TextBox()
        Me.lblval = New System.Windows.Forms.Label()
        Me.btnsesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sesion
        '
        Me.sesion.AutoSize = True
        Me.sesion.Font = New System.Drawing.Font("Candara", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sesion.Location = New System.Drawing.Point(337, 27)
        Me.sesion.Name = "sesion"
        Me.sesion.Size = New System.Drawing.Size(218, 42)
        Me.sesion.TabIndex = 0
        Me.sesion.Text = "Iniciar Sesión"
        Me.sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(532, 182)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(198, 20)
        Me.Txtusuario.TabIndex = 3
        '
        'txtcont
        '
        Me.txtcont.Location = New System.Drawing.Point(532, 248)
        Me.txtcont.Name = "txtcont"
        Me.txtcont.Size = New System.Drawing.Size(198, 20)
        Me.txtcont.TabIndex = 4
        Me.txtcont.UseSystemPasswordChar = True
        '
        'lblval
        '
        Me.lblval.AutoSize = True
        Me.lblval.ForeColor = System.Drawing.Color.Red
        Me.lblval.Location = New System.Drawing.Point(548, 303)
        Me.lblval.Name = "lblval"
        Me.lblval.Size = New System.Drawing.Size(0, 13)
        Me.lblval.TabIndex = 5
        '
        'btnsesion
        '
        Me.btnsesion.Location = New System.Drawing.Point(582, 333)
        Me.btnsesion.Name = "btnsesion"
        Me.btnsesion.Size = New System.Drawing.Size(85, 23)
        Me.btnsesion.TabIndex = 7
        Me.btnsesion.Text = "Iniciar Sesión"
        Me.btnsesion.UseCompatibleTextRendering = True
        Me.btnsesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 291)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsesion)
        Me.Controls.Add(Me.lblval)
        Me.Controls.Add(Me.txtcont)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sesion)
        Me.Name = "Inicio"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sesion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcont As System.Windows.Forms.TextBox
    Friend WithEvents lblval As System.Windows.Forms.Label
    Friend WithEvents btnsesion As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

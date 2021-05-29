Public Class Inicio

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcont.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtusuario.TextChanged

    End Sub

    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide() 'Inicio
        Registro.Show()
    End Sub

    Private Sub btnsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsesion.Click

        Dim usuario, contraseña As String
        Dim existe As Boolean

        existe = False
        usuario = Txtusuario.Text
        contraseña = txtcont.Text

        If usuario <> "" And contraseña <> "" Then
            If usuario = "jorgeguzman" And contraseña = "12070942" Then
                existe = True
            End If

            If usuario = "isaivega" And contraseña = "12071652" Then
                existe = True
            End If

            If usuario = "JulioLeyva" And contraseña = "12071063" Then
                existe = True
            End If

            If usuario = "Josema" And contraseña = "12071652" Then
                existe = True
            End If

            If usuario = "EduardoHernandez" And contraseña = "12071652" Then
                existe = True
            End If


            If existe = True Then
                Me.Hide() 'Inicio
                AdmMenu.Show()
            Else
                Txtusuario.Text = usuario
                txtcont.Text = contraseña
                lblval.Text = "Datos incorrectos intente de nuevo."
            End If
        Else
            lblval.Text = "Favor de ingresar los datos requeridos."
        End If




    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class

Public Class Peliculas

    Private Sub Peliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Movie_CenterDataSet.PELICULAS' Puede moverla o quitarla según sea necesario.
        Me.PELICULASTableAdapter.Fill(Me.Movie_CenterDataSet.PELICULAS)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide() 'Peliculas
        AdmMenu.Show()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("select*from PELICULAS", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        dgvListar.DataSource = miDataSet.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListar.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("insert into PELICULAS (Num_iventario, Titulo, Genero, Idiomas, Sinopsis, Num_rentas,Num_ejemplares) values('" & Me.txtNi.Text.Trim & "','" & Me.txtTi.Text.Trim & "','" & Me.txtGe.Text.Trim & "','" & Me.txtIdi.Text.Trim & "','" & Me.txtSin.Text.Trim & "','" & Me.txtNr.Text.Trim & "','" & Me.txtNe.Text.Trim & "')", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub

    Private Sub txtGe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dsd.Click

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("update PELICULAS set Num_iventario='" & txtNi.Text.Trim & "' , Titulo='" & txtTi.Text.Trim & "' , Genero='" & txtGe.Text.Trim & "' , Idiomas='" & txtIdi.Text.Trim & "' , Sinopsis='" & txtSin.Text.Trim & "' , Num_rentas='" & txtNr.Text.Trim & "' , Num_ejemplares='" & txtNe.Text.Trim & "' where Num_iventario='" & txtNi.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim miDataSet As New Data.DataSet

        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("delete from PELICULAS where Num_iventario= '" & txtNi.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub
End Class
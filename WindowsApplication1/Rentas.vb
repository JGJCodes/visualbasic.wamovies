Public Class Rentas

    Private Sub Rentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Movie_CenterDataSet.RENTA' Puede moverla o quitarla según sea necesario.
        Me.RENTATableAdapter.Fill(Me.Movie_CenterDataSet.RENTA)

    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide() 'Rentas
        AdmMenu.Show()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("select*from RENTA", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        dgvListar.DataSource = miDataSet.Tables(0)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("insert into RENTA (Usuario, Pelicula , Costo , Fecha_renta , Fecha_entrega, Codigo) values('" & Me.txtus.Text.Trim & "','" & Me.txtpel.Text.Trim & "','" & Me.txtcos.Text.Trim & "','" & Me.txtfr.Text.Trim & "','" & Me.txtfe.Text.Trim & "','" & Me.txtcod.Text.Trim & "')", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("update RENTA set Usuario='" & txtus.Text.Trim & "' , Pelicula='" & txtpel.Text.Trim & "' , Costo='" & txtcos.Text.Trim & "' ,Fecha_renta='" & txtfr.Text.Trim & "', Fecha_entrega='" & txtfe.Text.Trim & "' , Codigo='" & txtcod.Text.Trim & "'  where Codigo='" & txtcod.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim miDataSet As New Data.DataSet

        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("delete from RENTA where Codigo= '" & txtcod.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub
End Class
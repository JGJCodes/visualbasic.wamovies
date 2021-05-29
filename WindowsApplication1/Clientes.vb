Public Class Clientes



    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Movie_CenterDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.Movie_CenterDataSet.CLIENTE)

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("select*from CLIENTE", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        dgvListar.DataSource = miDataSet.Tables(0)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("insert into CLIENTE (ID_Usuario, Nombre, Contraseña, Email, Telefono_movil, Telefono_Fijo,Direccion) values('" & Me.txtID.Text.Trim & "','" & Me.txtNo.Text.Trim & "','" & Me.txtco.Text.Trim & "','" & Me.txtem.Text.Trim & "','" & Me.txttm.Text.Trim & "','" & Me.txttf.Text.Trim & "','" & Me.txtdi.Text.Trim & "')", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")
        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttf.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdir.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide() 'Clientes
        AdmMenu.Show()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim miDataSet As New Data.DataSet
        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("update CLIENTE set Nombre='" & txtNo.Text.Trim & "' , Contraseña='" & txtco.Text.Trim & "' , Email='" & txtem.Text.Trim & "' , Telefono_movil='" & txttm.Text.Trim & "' , Telefono_Fijo='" & txttf.Text.Trim & "' , Direccion='" & txtdi.Text.Trim & "' where ID_Usuario='" & txtID.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim miDataSet As New Data.DataSet

        Dim miDataAdapter As New Data.SqlClient.SqlDataAdapter("delete from CLIENTE where ID_Usuario= '" & txtID.Text.Trim & "'", "Data Source=ISAI-PC;Initial Catalog=Movie_Center;Integrated Security=True")

        miDataAdapter.Fill(miDataSet)
        Me.btnListar_Click(sender, e)
    End Sub
End Class
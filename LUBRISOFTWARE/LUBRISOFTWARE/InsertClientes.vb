Imports MySql.Data.MySqlClient
Public Class InsertClientes
    'DECLARO VARIABLES PARA HACER LA CONEXION Y LOS INSERT Y SELECTS 
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim comandos As MySqlCommand = New MySqlCommand

    'CONECTA Y VALIDA LA BASE DE DATOS PARA HACER EL INSERT
    Private Sub Load_Conect(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConexion.ConnectionString = "Server=localhost;Database=visualB; user id=root; password=;"
            MysqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            comandos = New MySqlCommand("INSERT INTO clientes (id_cliente ,nombre_cliente ,apellido_cliente ,tel_cliente ,patente)" & Chr(13) & "VALUES (@id,@nombre,@apellido,@tel,@patente);", MysqlConexion)
            comandos.Parameters.AddWithValue("@id", txt_id.Text)
            comandos.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            comandos.Parameters.AddWithValue("@apellido", txt_apellido.Text)
            comandos.Parameters.AddWithValue("@tel", txt_telefono.Text)
            comandos.Parameters.AddWithValue("@patente", txt_patente.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Almacenados")
            txt_id.Clear()
            txt_nombre.Clear()
            txt_apellido.Clear()
            txt_telefono.Clear()
            txt_patente.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
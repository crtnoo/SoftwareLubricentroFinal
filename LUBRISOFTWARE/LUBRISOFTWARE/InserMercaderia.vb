Imports MySql.Data.MySqlClient
Public Class InserMercaderia
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            comandos = New MySqlCommand("INSERT INTO stock (id_stock ,articulo ,cantidad)" & Chr(13) & "VALUES (@id,@art,@cant);", MysqlConexion)
            comandos.Parameters.AddWithValue("@id", txt_id.Text)
            comandos.Parameters.AddWithValue("@art", txt_articulo.Text)
            comandos.Parameters.AddWithValue("@cant", txt_cantidad.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Almacenados")
            txt_id.Clear()
            txt_articulo.Clear()
            txt_cantidad.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InserMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConexion.ConnectionString = "Server=localhost;Database=visualB; user id=root; password=;"
            MysqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Hide()
    End Sub
End Class
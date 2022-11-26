Imports MySql.Data.MySqlClient
Public Class InsertarPedidos
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub InsertarPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            comandos = New MySqlCommand("INSERT INTO pedidos (id_pedido ,fecha_pedido ,cliente ,id_stock)" & Chr(13) & "VALUES (@id_p,@fecha,@id_cli,@id_s);", MysqlConexion)
            comandos.Parameters.AddWithValue("@id_p", txt_id.Text)
            comandos.Parameters.AddWithValue("@fecha", txt_fecha.Text)
            comandos.Parameters.AddWithValue("@id_cli", txt_id_cliente.Text)
            comandos.Parameters.AddWithValue("@id_s", txt_id_stock.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Almacenados")
            txt_id.Clear()
            txt_fecha.Clear()
            txt_id_cliente.Clear()
            txt_id_stock.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
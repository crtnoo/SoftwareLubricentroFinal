Imports MySql.Data.MySqlClient
Public Class InsertFacturas
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            comandos = New MySqlCommand("INSERT INTO facturas (id_factura ,fecha_emision,id_pedido)" & Chr(13) & "VALUES (@id_f,@fecha,@id_p);", MysqlConexion)
            comandos.Parameters.AddWithValue("@id_f", txt_id_f.Text)
            comandos.Parameters.AddWithValue("@fecha", txt_fecha.Text)
            comandos.Parameters.AddWithValue("@id_p", txt_id_p.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Almacenados")
            txt_id_f.Clear()
            txt_fecha.Clear()
            txt_id_p.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Hide()
    End Sub

    Private Sub InsertFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConexion.ConnectionString = "Server=localhost;Database=visualB; user id=root; password=;"
            MysqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
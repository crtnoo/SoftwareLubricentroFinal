Imports MySql.Data.MySqlClient
Public Class BuscarMercaderia
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim buscar As MySqlCommand = New MySqlCommand
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Hide()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        buscar = New MySqlCommand("SELECT * FROM stock WHERE id_stock = @id_busc ;", MysqlConexion)
        buscar.Parameters.AddWithValue("@id_busc", txt_id.Text)
        buscar.ExecuteNonQuery()
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(buscar)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        txt_id.Clear()
    End Sub

    Private Sub BuscarMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConexion.ConnectionString = "Server=localhost;Database=visualB; user id=root; password=;"
            MysqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
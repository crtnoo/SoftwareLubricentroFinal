Imports MySql.Data.MySqlClient

Public Class Clientes
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Dim seleccion As MySqlCommand = New MySqlCommand
    Dim eliminar As MySqlCommand = New MySqlCommand
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Private Sub Load_Conect(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConexion.ConnectionString = "Server=localhost;Database=visualB; user id=root; password=;"
            MysqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btn_probar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        seleccion.Connection = MysqlConexion
        seleccion.CommandText = "SELECT * FROM clientes;"
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(seleccion)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        InsertClientes.Show()
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        BuscarClientes.Show()
    End Sub

End Class
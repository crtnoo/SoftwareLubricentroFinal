Imports MySql.Data.MySqlClient
Public Class Pedidos
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Dim seleccion As MySqlCommand = New MySqlCommand
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Public Sub Prueba()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion Establecida")
        Catch ex As Exception
            MsgBox("Error en la conexion")
        End Try
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_conectar_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        InsertarPedidos.Show()
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        seleccion.Connection = MysqlConexion
        seleccion.CommandText = "SELECT * FROM pedidos;"
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(seleccion)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarPedidos.Show()
    End Sub
End Class
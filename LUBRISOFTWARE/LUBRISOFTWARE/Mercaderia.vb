Imports MySql.Data.MySqlClient
Public Class Mercaderia
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
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Mercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Prueba()
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        seleccion.Connection = MysqlConexion
        seleccion.CommandText = "SELECT * FROM stock;"
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(seleccion)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        MysqlConexion.Close()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        InserMercaderia.Show()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        BuscarMercaderia.Show()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Main
    Dim connectionString As String = "Server=localhost;Database=visualB; user id=root; password=;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Public Sub Prueba()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion Establecida")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("Error en la conexion")
        End Try
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mercaderia_Click(sender As Object, e As EventArgs) Handles btn_mercaderia.Click
        Mercaderia.Show()
        Me.Hide()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_facturas_Click(sender As Object, e As EventArgs) Handles btn_facturas.Click
        Facturas.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Prueba()
    End Sub
End Class
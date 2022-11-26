Public Class Login
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txt_Usuario.Text
        contraseña = txt_Contraseña.Text
        If (usuario = "fabian") And (contraseña = "lubri123") Then
            Main.Show()
            Me.Hide()
        Else
            MsgBox("Usuario u Contraseña incorreto, intente denuevo")

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

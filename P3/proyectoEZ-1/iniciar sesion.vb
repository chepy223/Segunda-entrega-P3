Imports MySql.Data.MySqlClient
Public Class Forminiciosesion
    Private Sub Forminiciosesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub
    Private Sub Buttoningresar_Click(sender As Object, e As EventArgs) Handles Buttoningresar.Click
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=localhost; database=mercado_lider;Uid=root;Pwd=;"
        Try
            conexion.Open()
            If usuarioregistro(txtemail.Text) = True Then
                Dim contra As String = contraseña(txtemail.Text)
                If contra.Equals(txtcontraseña.Text) = True Then
                    Me.Hide()
                    If consultartipousuario(txtemail.Text) = 1 Then
                        Formmenuadmin.Show()
                        Me.Hide()
                    ElseIf consultartipousuario(txtemail.Text) = 2 Then
                        Formtienda.Show()
                        Me.Hide()
                    Else
                        Formvenderproducto.Show()
                        Me.Hide()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Buttonatras_Click(sender As Object, e As EventArgs) Handles Buttonatras.Click
        formmenu.Show()
        Me.Hide()
    End Sub


End Class

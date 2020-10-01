Public Class Formmenuadmin
    Private Sub Buttonatras_Click(sender As Object, e As EventArgs) Handles Buttonatras.Click
        formmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonlistacliente_Click(sender As Object, e As EventArgs) Handles Buttonlistacliente.Click
        Formlistacliente.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonalmacen_Click(sender As Object, e As EventArgs) Handles Buttonalmacen.Click
        Formalmacen.Show()
        Me.Hide()
    End Sub
End Class
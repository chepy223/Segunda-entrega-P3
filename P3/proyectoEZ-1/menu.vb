Public Class formmenu
    Private Sub Buttoniniciarsesion_Click(sender As Object, e As EventArgs) Handles Buttoniniciarsesion.Click

        Forminiciosesion.Show()
        Me.Hide()

    End Sub

    Private Sub Buttonregistrar_Click(sender As Object, e As EventArgs) Handles Buttonregistrar.Click

        formregistro.Show()
        Me.Hide()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿desea salir de la aplicasion?", vbQuestion + vbYesNo, "pregunta") = vbYes Then
            End
        End If
    End Sub
End Class

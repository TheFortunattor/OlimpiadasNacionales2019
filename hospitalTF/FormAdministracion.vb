Public Class FormAdministracion
    Private Sub BtnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        FormAgregarPaciente.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormVerFichaPac.Show()
        Me.Hide()

    End Sub

    Private Sub BtnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        FormPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IngresarUsuario.Show()
        Me.Hide()
    End Sub
End Class
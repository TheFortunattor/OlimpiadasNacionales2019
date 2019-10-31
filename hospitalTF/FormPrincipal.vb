Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call coneccion()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAlarm_Click(sender As Object, e As EventArgs) Handles btnAlarm.Click
        Me.Hide()
        FormActivarAlarma.Show()

    End Sub

    Private Sub BtnViewAlarm_Click(sender As Object, e As EventArgs) Handles btnViewAlarm.Click
        Me.Hide()
        FormVerAlarmas.Show()



    End Sub

    Private Sub BtnSetRespusta_Click(sender As Object, e As EventArgs) Handles btnSetRespusta.Click
        FormResponderLLamado.Show()
        Me.Hide()
    End Sub
End Class

Public Class FormAgregarPaciente
    Private Sub FormAgregarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        FormAdministracion.Show()
    End Sub

    Private Sub BtnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then

            flag = 1
            sql = ("insert into pacientes values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "')")
            Try
                MsgBox(sql)
                Call ejecutar(sql)

                MsgBox("Paciente ingresado!")
            Catch ex As Exception

            End Try

        Else
            MsgBox("Complete todos los campos")
        End If

    End Sub
End Class
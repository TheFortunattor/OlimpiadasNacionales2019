Public Class IngresarUsuario
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            sql = "insert into usuarios values ('','" & TextBox1.Text & "','" & TextBox2.Text & "',1)"
        Else
            sql = "insert into usuarios values ('','" & TextBox1.Text & "','" & TextBox2.Text & "',2)"
        End If
        ejecutar(sql)
    End Sub
End Class
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sql = "select dni from pacientes"
        eje(Sql)
        While rs.read
            ComboBox1.Items.Add(rs(0))
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sql = "select p.nombre, p.apellido, p.dni, p.telefono, p.tipo_de_sangre, p.ph, sh.sector, sh.habitacion, d.apellido from pacientes p join secthab sh on p.idhab=sh.id join doctores d on p.dnidoct=d.dni"
    End Sub
End Class
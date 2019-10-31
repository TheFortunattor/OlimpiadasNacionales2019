Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flag = 1
        sql = "select dni from pacientes"
        ejecutar(sql)
        While rs1.Read
            ComboBox1.Items.Add(rs1(0))
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select p.nombre, p.apellido, p.dni, p.telefono, p.tipo_de_sangre, p.ph, sh.sector, sh.habitacion, d.apellido from pacientes p join secthab sh on p.idhab=sh.id join doctores d on p.dnidoct=d.dni"
        ejecutar(sql)
        FichaPaciente.Label10.Text = rs1(0)
        FichaPaciente.Label11.Text = rs1(1)
        FichaPaciente.Label12.Text = rs1(2)
        FichaPaciente.Label13.Text = rs1(3)
        FichaPaciente.Label14.Text = rs1(4)
        FichaPaciente.Label15.Text = rs1(5)
        FichaPaciente.Label16.Text = rs1(6)
        FichaPaciente.Label17.Text = rs1(7)
        FichaPaciente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPrincipal.show
        Me.Close()
    End Sub
End Class
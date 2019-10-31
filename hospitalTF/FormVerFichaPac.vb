Public Class FormVerFichaPac
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flag = 1
        sql = "select dni from pacientes"
        ejecutar(sql)
        While rs1.Read
            ComboBox1.Items.Add(rs1(0))
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select p.nombre, p.apellido, p.dni, p.telefono, p.tipo_de_sangre, p.ph, sh.sector, sh.habitacion, d.apellido from pacientes p join secthab sh on p.idhab=sh.id join doctores d on p.dnidoct=d.dni where p.dni= " & ComboBox1.Text & ""
        ejecutar(sql)
        rs1.Read()
        FormFichaPaciente.Label10.Text = rs1(0)
        FormFichaPaciente.Label11.Text = rs1(1)
        FormFichaPaciente.Label12.Text = rs1(2)
        FormFichaPaciente.Label13.Text = rs1(3)
        FormFichaPaciente.Label14.Text = rs1(4)
        FormFichaPaciente.Label15.Text = rs1(5)
        FormFichaPaciente.Label16.Text = rs1(6)
        FormFichaPaciente.Label17.Text = rs1(7)
        FormFichaPaciente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPrincipal.Show()
        Me.Close()
    End Sub
End Class
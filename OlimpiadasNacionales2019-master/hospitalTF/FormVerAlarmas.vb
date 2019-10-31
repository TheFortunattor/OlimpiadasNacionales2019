Public Class FormVerAlarmas

    Dim id_ultOcupado = 0
    Dim habitacion = ""
    Dim sector = 0
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxAlrm1.Enter

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        FormPrincipal.Show()

    End Sub

    Private Sub FormVerAlarmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flag = 1
        sql = ("select max(id) from secthab where ocupado = 1")

        Try
            Call ejecutar(sql)
            rs1.Read()
            id_ultOcupado = rs1(0)
        Catch ex As Exception

        End Try

        sql = ("select habitacion from secthab where ocupado = 1 and id = '" & id_ultOcupado & "'")

        Try
            Call ejecutar(sql)
            rs1.Read()
            habitacion = rs1(0)

        Catch ex As Exception

        End Try

        sql = ("select sector from secthab where ocupado = 1 and id = '" & id_ultOcupado & "'")

        Try
            Call ejecutar(sql)
            rs1.Read()
            sector = rs1(0)
        Catch ex As Exception

        End Try
        lblSec1.Text = sector
        lblSec2.Text = sector
        lblSec3.Text = sector
        lblSec4.Text = sector

        lblNumero.Text = habitacion
        lblNumero2.Text = habitacion
        lblNumero3.Text = habitacion
        lblNUmero4.Text = habitacion



    End Sub

End Class
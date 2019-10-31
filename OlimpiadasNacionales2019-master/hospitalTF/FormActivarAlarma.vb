Public Class FormActivarAlarma
    Dim id_desocupado
    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        FormPrincipal.Show()

    End Sub

    Private Sub BtnActivateAlarm_Click(sender As Object, e As EventArgs) Handles btnActivateAlarm.Click
        flag = 1
        sql = ("select id from secthab where ocupado = 0 limit 1")
        Try
            Call ejecutar(sql)
            rs1.Read()
            id_desocupado = rs1(0)

        Catch ex As Exception

        End Try

        sql = ("insert into alarma values('',curdate(),curtime(),null,1,'" & id_desocupado & "')")
        Try
            Call ejecutar(sql)

        Catch ex As Exception

        End Try

        sql = ("update secthab set ocupado = 1 where id = '" & id_desocupado & "'")

        Try
            Call ejecutar(sql)
            MsgBox("Alarma Activada")

        Catch ex As Exception

        End Try



    End Sub

    Private Sub FormActivarAlarma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
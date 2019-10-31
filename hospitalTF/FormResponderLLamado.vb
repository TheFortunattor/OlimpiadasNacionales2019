Public Class FormResponderLLamado
    Private Sub FormResponderLLamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRespuesta.Items.Clear()
        flag = 1
        sql = ("select fkidsec from alarma where tiempo_resp is NULL")

        Try
            Call ejecutar(sql)
            While rs1.Read
                ComboBoxRespuesta.Items.Add(rs1(0))
            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        FormPrincipal.Show()

    End Sub

    Private Sub BtnSetRsp_Click(sender As Object, e As EventArgs) Handles btnSetRsp.Click
        flag = 1
        sql = ("update alarma set tiempo_resp = curtime() where fkidsec = '" & ComboBoxRespuesta.Text & "'")

        Try
            Call ejecutar(sql)
            MsgBox("Alerta respondida!")




            ComboBoxRespuesta.Items.Clear()
            flag = 1
            sql = ("select fkidsec from alarma where tiempo_resp is NULL")

            Try
                Call ejecutar(sql)
                While rs1.Read
                    ComboBoxRespuesta.Items.Add(rs1(0))
                End While
            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
    End Sub
End Class
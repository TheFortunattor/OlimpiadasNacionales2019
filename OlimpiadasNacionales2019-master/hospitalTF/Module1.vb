Imports System.Data.Odbc

Module Module1

    Public cnn As OdbcConnection
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public cmd As OdbcCommand
    Public sql As String
    Public flag As Integer


    Public Function coneccion()
        Try
            cnn = New OdbcConnection("DSN=DBHOSP")
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function
    Public Function ejecutar(ByVal consulta As String)
        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text
        If flag = 1 Then
            rs1 = cmd.ExecuteReader()
        ElseIf flag = 2 Then
            rs2 = cmd.ExecuteReader()
        ElseIf flag = 3 Then
            rs3 = cmd.ExecuteReader()
        End If
        cmd.Dispose()
        Return 0
    End Function

End Module

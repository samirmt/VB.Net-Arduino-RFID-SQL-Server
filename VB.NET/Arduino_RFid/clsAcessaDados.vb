Public Class clsAcessaDados
    Dim dao As New clsConexaoDB
    Dim SQL As String

    Public Function BuscarPessoa(ByVal tag As String) As clsPessoa
        Dim pessoa As New clsPessoa

        SQL = "SELECT * FROM tbl_Pessoa WHERE pess_Tag LIKE '%" & tag & "%'"

        Try
            dao.cn = dao.getConexaoDB
            Dim da As New OleDb.OleDbDataAdapter(SQL, dao.cn)
            Dim dt As New DataTable

            da.Fill(dt)

            If dt.Rows(0).Item("pess_Id") > 0 Then
                pessoa.nome = dt.Rows(0).Item("pess_Nome")
                pessoa.email = dt.Rows(0).Item("pess_Email")
                pessoa.tag = dt.Rows(0).Item("pess_Tag")
            Else
                Form1.retornoLinha = ""
                pessoa = Nothing
                MsgBox("Pessoa não encontrada!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao buscar a pessoa!" & vbCrLf & ex.Message, MsgBoxStyle.Information)
        Finally
            dao.closeConexaoDB(dao.cn)
        End Try

        Return pessoa
    End Function

    Public Function SalvarPessoa(ByVal p As clsPessoa) As Boolean
        Dim result As Boolean = False

        SQL = "INSERT INTO tbl_Pessoa "
        SQL = SQL & "(pess_Nome, pess_Email, pess_Tag) "
        SQL = SQL & "VALUES "
        SQL = SQL & "("
        SQL = SQL & "'" & p.nome & "', "
        SQL = SQL & "'" & p.email & "', "
        SQL = SQL & "'" & p.tag & "' "
        SQL = SQL & ")"

        Try
            dao.cn = dao.getConexaoDB
            Dim Cmd As New OleDb.OleDbCommand

            Cmd.Connection = dao.cn
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            result = True
        Catch ex As Exception
            result = False
        End Try

        SalvarPessoa = result

        Return SalvarPessoa
    End Function
End Class

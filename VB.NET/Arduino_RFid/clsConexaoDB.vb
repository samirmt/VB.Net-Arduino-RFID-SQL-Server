Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb

Public Class clsConexaoDB
    Public Da As New OleDbDataAdapter
    Public Dt As DataTable
    Public Cmd As New OleDbCommand
    Public cn As New OleDb.OleDbConnection

    Public Function getConexaoDB() As OleDbConnection
        Try
            cn.ConnectionString = ConfigurationManager.ConnectionStrings("SQL-Server").ConnectionString
            cn.Open()
            Return cn
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao servidor!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Throw ex
        End Try
    End Function

    Public Sub closeConexaoDB(ByVal cn As OleDbConnection)
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class

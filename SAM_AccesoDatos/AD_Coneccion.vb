Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Configuration

Public Class AD_Coneccion
    Public cnn As SqlConnection
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet

    Public Function AbrirConeccion() As SqlConnection
        Dim con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("cnxString").ToString())
        con.Open()
        Return con
    End Function

    Public Function CerrarConeccion() As SqlConnection
        Dim con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("cnxString").ToString())
        con.Close()
        Return con
    End Function

End Class

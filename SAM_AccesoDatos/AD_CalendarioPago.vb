Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlServerCe
Imports SAM_Entidades
Imports System.Data.SqlClient
Public Class AD_CalendarioPago
    Inherits AD_Coneccion
    Dim cmd As SqlCommand

    Function NlistaCalendarioPago() As DataTable
        cmd = New SqlCommand("dbo.SP_FechaCierre_EnLista")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "CalendarioPago"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function
End Class

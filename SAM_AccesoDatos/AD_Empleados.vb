Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlServerCe
Imports SAM_Entidades
Imports System.Data.SqlClient
Public Class AD_Empleados
    Inherits AD_Coneccion
    Dim cmd As SqlCommand
    Function NlistaEmpleadosPorPuesto() As DataTable
        cmd = New SqlCommand("dbo.Sp_Emp_EnlistaEmpleados")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "ListaEmpleados"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
        Return Nothing
    End Function
End Class

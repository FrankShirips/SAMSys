Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlServerCe
Imports SAM_Entidades
Imports System.Data.SqlClient
Public Class AD_PeriodosDePago
    Inherits AD_Coneccion
    Dim cmd As SqlCommand
    Function NlistaPeriodosDePago() As DataTable
        cmd = New SqlCommand("dbo.SP_PeriodosPago_EnLista")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "PeriodosDePago"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
        Return Nothing
    End Function
    Public Function InsertarPeriodosDePago(ByVal TM_Campos As EN_PeriodosPago) As Boolean

        cmd = New SqlCommand("dbo.SP_PeriodosPago_Insert")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@cDescripcion", SqlDbType.VarChar, 50)
        cmd.Parameters.Add("@cAbreviatura", SqlDbType.VarChar, 50)

        cmd.Parameters("@cDescripcion").Value = TM_Campos.gcDescripcion
        cmd.Parameters("@cAbreviatura").Value = TM_Campos.gcAbreviatura

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()
    End Function
    Public Function EliminarPeriodosDePago(ByVal TM_Campos As EN_PeriodosPago) As Boolean

        cmd = New SqlCommand("dbo.SP_PeriodosPago_Delete")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@Codigo", SqlDbType.Int)

        cmd.Parameters("@Codigo").Value = TM_Campos.gnCodPeriodo

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()
    End Function

    Public Function EstaEnUso(ByVal Codigo As Integer) As Integer
        cmd = New SqlCommand("dbo.SP_Puestos_ValidaRelacion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 10)
        cmd.Parameters("@Codigo").Value = Codigo

        Dim dataReader As SqlDataReader = cmd.ExecuteReader()

        If dataReader.Read Then
            Dim Valida As Integer
            Valida = dataReader("Valida")
            Return Valida
        End If

        CerrarConeccion()
        Return Nothing

    End Function
End Class

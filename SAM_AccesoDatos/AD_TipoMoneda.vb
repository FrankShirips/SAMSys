Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlServerCe
Imports SAM_Entidades
Imports System.Data.SqlClient
Public Class AD_TipoMoneda
    Inherits AD_Coneccion
    Dim cmd As SqlCommand
    Function NlistaTipoDeMoneda() As DataTable
        cmd = New SqlCommand("dbo.SP_TIPOMONEDA_NLISTA")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "TipoMoneda"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
        Return Nothing
    End Function

    Function NlistaTodasLasMonedasDelMundo() As DataTable
        cmd = New SqlCommand("dbo.SP_TIPOMONEDA_NLISTATODOELMUNDO")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "TodasLasMonedas"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
        Return Nothing
    End Function
    Public Function InsertarTipodeMoneda(ByVal TM_Campos As EN_TipoMoneda) As Boolean

        cmd = New SqlCommand("SP_TIPOMONEDA_INSERT")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@cPais", SqlDbType.VarChar, 100)
        cmd.Parameters.Add("@cDescripcion", SqlDbType.VarChar, 200)
        cmd.Parameters.Add("@cCodigoISO", SqlDbType.VarChar, 100)
        cmd.Parameters.Add("@nCodEstado", SqlDbType.Int)
        cmd.Parameters.Add("@nCodUsuarioGraba", SqlDbType.Int)

        cmd.Parameters("@cPais").Value = TM_Campos.gcPais
        cmd.Parameters("@cDescripcion").Value = TM_Campos.gcDescripcion
        cmd.Parameters("@cCodigoISO").Value = TM_Campos.gcCodigoISO
        cmd.Parameters("@nCodEstado").Value = TM_Campos.gnCodEstado
        cmd.Parameters("@nCodUsuarioGraba").Value = TM_Campos.gnCodUsuarioGraba

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()

    End Function
    Public Function EliminarTipodeMoneda(ByVal TM_Campos As EN_TipoMoneda) As Boolean

        cmd = New SqlCommand("dbo.SP_TipoMoneda_Delete")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@cCodigoISO", SqlDbType.VarChar, 100)
        cmd.Parameters("@cCodigoISO").Value = TM_Campos.gcCodigoISO

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()

    End Function
    Public Function EstaEnUso(ByVal Codigo As String) As Integer
        cmd = New SqlCommand("dbo.SP_TipoMoneda_ValidaRelacion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@cCodigoISO", SqlDbType.VarChar, 100)
        cmd.Parameters("@cCodigoISO").Value = Codigo

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

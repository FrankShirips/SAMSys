Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlServerCe
Imports SAM_Entidades
Imports System.Data.SqlClient
Public Class AD_PrestacionesLey
    Inherits AD_Coneccion
    Dim cmd As SqlCommand
    Function NlistaPrestaciones() As DataTable
        cmd = New SqlCommand("dbo.SP_Prestaciones_EnLista")
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dt.TableName = "PrestacionesLey"
            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()

    End Function
    Public Function EstaEnUso(ByVal TM_Campos As EN_PrestacionesLey) As Integer
        cmd = New SqlCommand("dbo.Sp_Prestaciones_ValidaExiste")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@nCodAño", SqlDbType.Int)
        cmd.Parameters.Add("@fFechaInicia", SqlDbType.DateTime)
        cmd.Parameters.Add("@fFechaFinaliza", SqlDbType.DateTime)

        cmd.Parameters("@nCodAño").Value = TM_Campos.gnCodAño
        cmd.Parameters("@fFechaInicia").Value = TM_Campos.gfFechaInicia
        cmd.Parameters("@fFechaFinaliza").Value = TM_Campos.gfFechaFinaliza


        Dim dataReader As SqlDataReader = cmd.ExecuteReader()

        If dataReader.Read Then
            Dim Valida As Integer
            Valida = dataReader("Valida")
            Return Valida
        End If

        CerrarConeccion()


    End Function
    Public Function InsertarPrestaciones(ByVal TM_Campos As EN_PrestacionesLey) As Boolean

        cmd = New SqlCommand("dbo.SP_Prestaciones_Insert")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = AbrirConeccion()

        cmd.Parameters.Add("@nCodAño", SqlDbType.Int)
        cmd.Parameters.Add("@nInssLab", SqlDbType.Decimal)
        cmd.Parameters.Add("@nInssPat", SqlDbType.Decimal)
        cmd.Parameters.Add("@nInatec", SqlDbType.Decimal)
        cmd.Parameters.Add("@nVacaciones", SqlDbType.Decimal)
        cmd.Parameters.Add("@nTreceavo", SqlDbType.Decimal)
        cmd.Parameters.Add("@nIndemnizacion", SqlDbType.Decimal)
        cmd.Parameters.Add("@fFechaInicia", SqlDbType.DateTime)
        cmd.Parameters.Add("@fFechaFinaliza", SqlDbType.DateTime)
        cmd.Parameters.Add("@fFechaRegistro", SqlDbType.DateTime)
        cmd.Parameters.Add("@cEquipoRegistro", SqlDbType.VarChar, 300)
        cmd.Parameters.Add("@nUsuarioRegistra", SqlDbType.Int)

        cmd.Parameters("@nCodAño").Value = TM_Campos.gnCodAño
        cmd.Parameters("@nInssLab").Value = TM_Campos.gnInssLab
        cmd.Parameters("@nInssPat").Value = TM_Campos.gnInssPat
        cmd.Parameters("@nInatec").Value = TM_Campos.gnInatec
        cmd.Parameters("@nVacaciones").Value = TM_Campos.gnVacaciones
        cmd.Parameters("@nTreceavo").Value = TM_Campos.gnTreceavo
        cmd.Parameters("@nIndemnizacion").Value = TM_Campos.gnIndemnizacion
        cmd.Parameters("@fFechaInicia").Value = TM_Campos.gfFechaInicia
        cmd.Parameters("@fFechaFinaliza").Value = TM_Campos.gfFechaFinaliza
        cmd.Parameters("@fFechaRegistro").Value = TM_Campos.gfFechaRegistro
        cmd.Parameters("@cEquipoRegistro").Value = TM_Campos.gcEquipoRegistro
        cmd.Parameters("@nUsuarioRegistra").Value = TM_Campos.gUsuario

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()

    End Function
End Class

Imports System.Data.SqlClient
Imports SAM_Entidades

Public Class AD_VacPerm
    Inherits AD_Coneccion

    ''' <summary>
    ''' Obtiene todos los registros de vaciones y permisos.
    ''' </summary>
    ''' <returns></returns>
    Function ObtenerVacPerm() As DataTable
        Dim cmd As New SqlCommand()

        cmd.CommandText = "ObtenerVacOPerm"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "VacacionesPermisos"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function

    ''' <summary>
    ''' Registra o actualiza Un registro de vaciones o permisos
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <param name="accion"></param>
    ''' <returns></returns>
    Function InsertarOActualizarVacPerm(ByVal campos As EN_VacPerm, ByVal accion As String) As Boolean
        Dim cmd As New SqlCommand()

        If accion.Equals("A") Then
            cmd.CommandText = "dbo.ActualizarVacOPerm"
            cmd.Connection = AbrirConeccion()
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID", campos.Id)
        Else
            cmd.CommandText = "dbo.InsertarVacOPerm"
            cmd.Connection = AbrirConeccion()
            cmd.CommandType = CommandType.StoredProcedure
        End If

        cmd.Parameters.AddWithValue("@EMPLEADO", campos.Empleado)
        cmd.Parameters.AddWithValue("@FECHAINI", campos.fechaIni)
        cmd.Parameters.AddWithValue("@FECHAFIN", campos.fechaFin)
        cmd.Parameters.AddWithValue("@CONCEPTO", campos.ConceptoOTipo)
        cmd.Parameters.AddWithValue("@DURACION", campos.Duracion)
        cmd.Parameters.AddWithValue("@TIPODURACION", campos.TipoDuracion)
        cmd.Parameters.AddWithValue("@USUARIO", 1)
        cmd.Parameters.AddWithValue("@EQUIPO", Environment.MachineName)

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()
    End Function

    ''' <summary>
    ''' Borra un registros
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function BorrarVacPerm(ByVal campos As EN_VacPerm) As Boolean
        Dim cmd As New SqlCommand("BorrarVacOPerm")
        cmd.Connection = AbrirConeccion()
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@ID", campos.Id)

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()
    End Function

    Function ObtenerConceptosOTiposDuracion(ByVal Acciones As String) As DataTable
        Dim cmd As New SqlCommand()

        If Acciones.Equals("C") Then
            cmd.CommandText = "SELECT Id, CodConcept, Descripcion FROM ConceptoOTipo"
            cmd.CommandType = CommandType.Text
        Else
            If Acciones.Equals("T") Then
                cmd.CommandText = "SELECT Id, Descripcion FROM TipoDuracion"
                cmd.CommandType = CommandType.Text
            End If
        End If

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "Conceptos"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function

    Function ObtenerConceptosOTiposDuracionByDescripcion(ByVal tipoDuracion As EN_TipoDuracion,
                                                         ByVal conceptoTipo As EN_ConceptoDuracion, ByVal Acciones As String) As DataTable
        Dim cmd As New SqlCommand()

        If Acciones.Equals("C") Then
            cmd.CommandText = "GetIdConceptoByDescripcion"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@DESCRIPCION", conceptoTipo.Descripcion)
        Else
            If Acciones.Equals("T") Then
                cmd.CommandText = "GetIdTipoDuracionByDescripcion"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@DESCRIPCION", tipoDuracion.Descripcion)
            End If
        End If

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "Ids"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function

    Function ObtenerConceptosOTiposDuracionByID(ByVal tipoDuracion As EN_TipoDuracion,
                                                         ByVal conceptoTipo As EN_ConceptoDuracion, ByVal Acciones As String) As DataTable
        Dim cmd As New SqlCommand()

        If Acciones.Equals("C") Then
            cmd.CommandText = "GetDescripcionConceptoById"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID", conceptoTipo.Id)
        Else
            If Acciones.Equals("T") Then
                cmd.CommandText = "GetDescripcionTipoDuracionById"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ID", tipoDuracion.Id)
            End If
        End If

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "Ids"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function
End Class

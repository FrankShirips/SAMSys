Imports System.Data.SqlClient
Imports SAM_Entidades

Public Class AD_IR
    Inherits AD_Coneccion
    ''' <summary>
    ''' Obtiene la tabla IR
    ''' </summary>
    ''' <returns></returns>
    Function ObtenerIR() As DataTable
        Dim cmd As New SqlCommand()

        cmd.CommandText = "ObtenerIR"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "IR"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function

    ''' <summary>
    ''' Actualiza un registro de la tabla IR
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function InsertarOActualizarIR(ByVal campos As EN_IR, ByVal accion As String) As Boolean
        Dim cmd As New SqlCommand()

        If accion.Equals("A") Then
            cmd.CommandText = "dbo.ActualizarIR"
            cmd.Connection = AbrirConeccion()
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID", campos.Id)
        Else
            cmd.CommandText = "dbo.InsertarIR"
            cmd.Connection = AbrirConeccion()
            cmd.CommandType = CommandType.StoredProcedure
        End If

        cmd.Parameters.AddWithValue("@CODANIO", campos.codAnio)
        cmd.Parameters.AddWithValue("@FECHAINI", campos.fechaInica)
        cmd.Parameters.AddWithValue("@FECHAFIN", campos.fechaFinal)
        cmd.Parameters.AddWithValue("@MINIMO", campos.minimo)
        cmd.Parameters.AddWithValue("@MAXIMO", campos.maximo)
        cmd.Parameters.AddWithValue("@PORCAPLICA", campos.porcAplica)
        cmd.Parameters.AddWithValue("@IMPUESTOBASE", campos.impuestoBase)
        cmd.Parameters.AddWithValue("@SOBREEXCESO", campos.sobreExceso)
        cmd.Parameters.AddWithValue("@EQUIPOREGISTRA", Environment.MachineName)
        cmd.Parameters.AddWithValue("@USUARIOREGISTRA", 1)

        If Not accion.Equals("A") Then
            cmd.Parameters.Add("@SMS", SqlDbType.Int).Direction = ParameterDirection.Output
        End If

        If cmd.ExecuteNonQuery Then
            If Not accion.Equals("A") Then
                Dim sms As Integer = CType(cmd.Parameters("@SMS").Value, Integer)

                If sms = 0 Then
                    Return False
                ElseIf sms = 1
                    Return True
                End If
            Else
                Return True
            End If
        End If

        CerrarConeccion()
    End Function

    ''' <summary>
    ''' Borra un registro mediante su Id de Tabla.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function BorrarIR(ByVal campos As EN_IR) As Boolean
        Dim cmd As New SqlCommand("BorrarIR")
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
End Class

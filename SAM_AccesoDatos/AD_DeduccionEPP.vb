﻿Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports DevExpress.Office.Utils
Imports SAM_Entidades

Public Class AD_DeduccionEPP
    Inherits AD_Coneccion

    ''' <summary>
    ''' Obtienen todas las deducciones de EPP o un registro mediante su Id.
    ''' </summary>
    ''' <returns></returns>
    Function ObtenerDeducionesEPP(ByVal campos As EN_DeduccionEPP, ByVal Accion As String) As DataTable
        Dim cmd As New SqlCommand()

        If Accion.Equals("T") Then
            cmd.CommandText = "ObtenerDeduccionesEPP"
            cmd.CommandType = CommandType.StoredProcedure
        Else
            If Accion.Equals("U") Then
                cmd.CommandText = "ObtenerDeduccionesEPPPorId"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", campos.DId)
            End If
        End If

        cmd.Connection = AbrirConeccion()

        If cmd.ExecuteNonQuery Then
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
            dt.TableName = "DeducionesEPP"

            Return dt
        Else
            Return Nothing
        End If

        CerrarConeccion()
    End Function

    ''' <summary>
    ''' Funcion Actualiza o Inserta una deduccion de EPP dependiendo del criterio que se establezca.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <param name="Accion"></param>
    ''' <returns></returns>
    Function InsertarActualizarDeducionesEPP(ByVal campos As EN_DeduccionEPP, ByVal Accion As String) As Boolean
        Dim cmd As New SqlCommand()

        If Accion.Equals("I") Then
            cmd.CommandText = "dbo.InsertarDeduccionesEPP"
            cmd.Connection = AbrirConeccion()
            cmd.CommandType = CommandType.StoredProcedure
        Else
            If Accion.Equals("A") Then
                cmd.CommandText = "dbo.ActualizarDeduccionesEPP"
                cmd.Connection = AbrirConeccion()
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ID", campos.DId)
            End If
        End If

        cmd.Parameters.AddWithValue("@FECHA", campos.DFecha)
        cmd.Parameters.AddWithValue("@N_EMPL", campos.DN_Empl)
        cmd.Parameters.AddWithValue("@PROYECTO", campos.DProyecto)
        cmd.Parameters.AddWithValue("@NOMBRE", campos.DNombre)
        cmd.Parameters.AddWithValue("@MONTO", campos.DMonto)
        cmd.Parameters.AddWithValue("@CONCEPTO", campos.DConcepto)

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()

    End Function

    ''' <summary>
    ''' Borra un registro mediante su Id de Tabla.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function BorrarDeduccionesEPP(ByVal campos As EN_DeduccionEPP) As Boolean
        Dim cmd As New SqlCommand("dbo.BorrarDeduccionesEPP")
        cmd.Connection = AbrirConeccion()
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@ID", campos.DId)

        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        CerrarConeccion()
    End Function
End Class

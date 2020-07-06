Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports SAM_AccesoDatos
Imports SAM_Entidades
Imports System.Data.Entity
Imports System.Text
Public Class LN_CalendarioPago
    Public ReadOnly stringBuilder As StringBuilder = New StringBuilder
    Function EnListaCalendarioPago() As DataTable
        Dim Enlistar As New AD_CalendarioPago
        Return Enlistar.NlistaCalendarioPago
    End Function
End Class

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
Public Class LN_PeriodosDePago
    Public ReadOnly stringBuilder As StringBuilder = New StringBuilder
    Function EnlistaPeriodosDePago() As DataTable
        Dim Enlista As New AD_PeriodosDePago
        Return Enlista.NlistaPeriodosDePago
    End Function

    Function InsertPeriodosPago(ByVal PerPa_Campos As EN_PeriodosPago) As Boolean
        Dim Insertar As New AD_PeriodosDePago
        Return Insertar.InsertarPeriodosDePago(PerPa_Campos)
    End Function
    Function ValidarRelacion(ByVal codigo As Integer) As Integer
        Dim Valida As New AD_PeriodosDePago
        Dim Id = Valida.EstaEnUso(codigo)
        Return Id
    End Function
    Function EliminarPeriodoPago(ByVal PerPa_Campos As EN_PeriodosPago) As Boolean
        Dim Eliminar As New AD_PeriodosDePago
        Return Eliminar.EliminarPeriodosDePago(PerPa_Campos)
    End Function
End Class

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
Public Class LN_Prestaciones
    Public ReadOnly stringBuilder As StringBuilder = New StringBuilder
    Function EnListaPrestaciones() As DataTable
        Dim Enlistar As New AD_PrestacionesLey
        Return Enlistar.NlistaPrestaciones()
    End Function
    Function InsertaPrestaciones(ByVal Campos As EN_PrestacionesLey) As Boolean
        Dim Insertar As New AD_PrestacionesLey
        Insertar.InsertarPrestaciones(Campos)
    End Function
    Function ValidaSiExiste(ByVal Campos As EN_PrestacionesLey) As Integer
        Dim Validar As New AD_PrestacionesLey
        Dim Valor = Validar.EstaEnUso(Campos)
        Return Valor
    End Function
    Private Function ValidarCampos(ByVal Campos As EN_PrestacionesLey) As Boolean

        stringBuilder.Clear()

        If String.IsNullOrEmpty(Campos.gnCodAño) Then
            stringBuilder.Append("The 'Year' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnInssLab) Then
            stringBuilder.Append("The 'Inss Laboral' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnInssPat) Then
            stringBuilder.Append("The 'Inss Patronal' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnInatec) Then
            stringBuilder.Append("The 'Inatec' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnVacaciones) Then
            stringBuilder.Append("The 'Holidays' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnTreceavo) Then
            stringBuilder.Append("The 'Bonus' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gnIndemnizacion) Then
            stringBuilder.Append("The 'Compensation' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gfFechaInicia) Then
            stringBuilder.Append("The 'Start Date' field is mandatory")
        End If
        If String.IsNullOrEmpty(Campos.gfFechaFinaliza) Then
            stringBuilder.Append("The 'Final Date' field is mandatory")
        End If
        If DateAndTime.DateDiff(DateInterval.Day, CDate(Campos.gfFechaInicia), CDate(Campos.gfFechaFinaliza)) < 15 Then
            stringBuilder.Append("The minimum period to establish changes is 15 days")
        End If
        If CDate(Campos.gfFechaInicia) > CDate(Campos.gfFechaFinaliza) Then
            stringBuilder.Append("The Start Date is greater than the Final Date")
        End If
        Return (stringBuilder.Length = 0)
    End Function
End Class

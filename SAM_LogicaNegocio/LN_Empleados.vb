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
Public Class LN_Empleados
    Public ReadOnly stringBuilder As StringBuilder = New StringBuilder
    Function NListarEmpleados() As DataTable
        Dim Nlistar As New AD_Empleados
        Return Nlistar.NlistaEmpleadosPorPuesto
    End Function
End Class

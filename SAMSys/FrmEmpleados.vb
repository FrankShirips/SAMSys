Imports SAM_AccesoDatos
Imports SAM_Entidades
Imports SAM_LogicaNegocio
Public Class FrmEmpleados
    Dim Logica As New AD_Empleados
    Dim Entidades As New EN_Empleados
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GrdCtrEmp_Listado.DataSource = Logica.NlistaEmpleadosPorPuesto
    End Sub
End Class
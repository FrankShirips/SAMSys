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
Public Class LN_TipoMoneda
    Public ReadOnly stringBuilder As StringBuilder = New StringBuilder
    Function EnListarTipoMoneda() As DataTable
        Dim Nlistar As New AD_TipoMoneda
        Return Nlistar.NlistaTipoDeMoneda()
    End Function

    Function EnListaTodasLasMonedasDelMundo() As DataTable
        Dim Nlistar As New AD_TipoMoneda
        Return Nlistar.NlistaTodasLasMonedasDelMundo
    End Function

    Public Sub InsertarTipoMoneda(ByVal TM_Campos As EN_TipoMoneda)
        Dim Insertar As New AD_TipoMoneda
        Insertar.InsertarTipodeMoneda(TM_Campos)
    End Sub
    Function ValidarRelacion(ByVal codigo As String) As Integer
        Dim Valida As New AD_TipoMoneda
        Dim Id = Valida.EstaEnUso(codigo)
        Return Id
    End Function
    Public Sub EliminaTipoMoneda(ByVal TM_Campos As EN_TipoMoneda)
        Dim Eliminar As New AD_TipoMoneda
        Eliminar.EliminarTipodeMoneda(TM_Campos)
    End Sub
End Class

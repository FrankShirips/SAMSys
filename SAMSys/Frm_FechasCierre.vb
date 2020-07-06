
Imports DevExpress.XtraGrid.Views.Grid
Imports SAM_Entidades
Imports SAM_LogicaNegocio

Public Class Frm_FechasCierre
    Dim Resultados As New LN_CalendarioPago
    Dim ECampos As New EN_CalendarioDePago
    Private Sub Frm_FechasCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescaGrid(GrdCtrl_FechasCierre, Resultados.EnListaCalendarioPago())
    End Sub

    Private Sub GrdVw_FechasCierre_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GrdVw_FechasCierre.RowCellStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim Estado As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns(7))
            If Estado = "Cerrado" Then
                e.Appearance.BackColor = Color.Salmon
            End If
            If Estado = "Abierto" Then
                e.Appearance.BackColor = Color.Lime
            End If
            If Estado = "En Proceso" Then
                e.Appearance.BackColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub GrdVw_FechasCierre_MouseDown(sender As Object, e As MouseEventArgs) Handles GrdVw_FechasCierre.MouseDown
        If e.Button = MouseButtons.Right Then
            Menu_Derecho_CalendarioCierre.ShowPopup(Control.MousePosition)
        End If
    End Sub
End Class
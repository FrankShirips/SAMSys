Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports SAM_Entidades
Imports SAM_LogicaNegocio

Public Class Frm_PrestacionesLey
    Dim Resultados As New LN_Prestaciones
    Dim ECampos As New EN_PrestacionesLey

    Sub RefrescaGrid()
        Me.Grdctrl_Prestaciones.DataSource = Resultados.EnListaPrestaciones()
    End Sub

    Private Sub Frm_PrestacionesLey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescaGrid()
    End Sub
    Private Sub Cmd_InsertUpdatePrestaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Cmd_InsertUpdatePrestaciones.ItemClick
        Frm_InsertUpdate_Prestaciones.Show()
    End Sub

    Private Sub BandedGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles BandedGridView1.MouseDown
        If e.Button = MouseButtons.Right Then
            MenuReg_Prestaciones.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub CmdEditRegPrestaciones_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CmdEditRegPrestaciones.ItemClick

    End Sub
End Class
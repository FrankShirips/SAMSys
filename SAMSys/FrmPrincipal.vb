Public Class FrmPrincipal 

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.Close()
    End Sub

    Private Sub Cbo_TipoMoneda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Cbo_TipoMoneda.ItemClick
        Frm_TipoMoneda.Show()
    End Sub

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        FrmEmpleados.Show()
    End Sub

    Private Sub CmdCatPeriodosPago_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmdCatPeriodosPago.ItemClick
        Frm_PeriodosDePago.Show()
    End Sub

    Private Sub CmdPrestaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmdPrestaciones.ItemClick
        Frm_PrestacionesLey.Show()
    End Sub

    Private Sub CmdCatFechasCierre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmdCatFechasCierre.ItemClick
        Frm_FechasCierre.Show()
    End Sub
End Class
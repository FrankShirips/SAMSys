Imports SAM_Entidades
Imports SAM_LogicaNegocio
Public Class Frm_PeriodosDePago
    Dim Resultados As New LN_PeriodosDePago
    Dim ECampos As New EN_PeriodosPago
    Sub RefrescaGrid()
        Me.GrdCtrl_PeriodoPago.DataSource = Resultados.EnlistaPeriodosDePago()
    End Sub
    Sub LimpiaControles()
        Me.txtDescFrecuencia.Text = ""
        Me.txtAbreviatura.Text = ""
    End Sub
    Private Sub Frm_PeriodosDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescaGrid()
    End Sub

    Private Sub CmdAgregarFrec_Click(sender As Object, e As EventArgs) Handles CmdAgregarFrec.Click
        ECampos.gcDescripcion = Me.txtDescFrecuencia.Text
        ECampos.gcAbreviatura = Me.txtAbreviatura.Text

        Resultados.InsertPeriodosPago(ECampos)
        RefrescaGrid()
        LimpiaControles()
    End Sub

    Private Sub CmdEliminarFrec_Click(sender As Object, e As EventArgs) Handles CmdEliminarFrec.Click
        ''Valida que el registro no este en uso
        If Resultados.ValidarRelacion(CInt(Me.GrdVw_PeriodoPagos.GetRowCellValue(Me.GrdVw_PeriodoPagos.FocusedRowHandle(), Me.GrdVw_PeriodoPagos.Columns.Item(0)))) = 1 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("#1 - The record cannot be deleted because it is in use.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If (DevExpress.XtraEditors.XtraMessageBox.Show("Be sure to delete the record, you will not be able to undo this action.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None)) = DialogResult.No Then
                Exit Sub
            Else
                ECampos.gnCodPeriodo = CInt(Me.GrdVw_PeriodoPagos.GetRowCellValue(Me.GrdVw_PeriodoPagos.FocusedRowHandle(), Me.GrdVw_PeriodoPagos.Columns.Item(0)))
                Resultados.EliminarPeriodoPago(ECampos)
                RefrescaGrid()
            End If
        End If
    End Sub
End Class
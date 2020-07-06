Imports SAM_LogicaNegocio
Imports SAM_Entidades

Public Class Frm_TipoMoneda
    Dim Resultados As New LN_TipoMoneda
    Dim ECampos As New EN_TipoMoneda
    Sub RefrescaGrid()
        Me.GrdCtrl_TipoMoneda.DataSource = Resultados.EnListarTipoMoneda
    End Sub
    Private Sub CmdAgregaMoneda_Click(sender As Object, e As EventArgs) Handles CmdAgregaMoneda.Click
        ECampos.gcPais = CType(Me.TodasLasMonedasGrdVw.GetRowCellValue(TodasLasMonedasGrdVw.FocusedRowHandle(), TodasLasMonedasGrdVw.Columns.Item(0)), String)
        ECampos.gcDescripcion = CType(Me.TodasLasMonedasGrdVw.GetRowCellValue(TodasLasMonedasGrdVw.FocusedRowHandle(), TodasLasMonedasGrdVw.Columns.Item(1)), String)
        ECampos.gcCodigoISO = CType(Me.TodasLasMonedasGrdVw.GetRowCellValue(TodasLasMonedasGrdVw.FocusedRowHandle(), TodasLasMonedasGrdVw.Columns.Item(2)), String)
        ECampos.gnCodEstado = 1
        ECampos.gnCodUsuarioGraba = 2500

        Resultados.InsertarTipoMoneda(ECampos)

        Me.GrdCtrl_TipoMoneda.DataSource = Resultados.EnListarTipoMoneda

    End Sub

    Private Sub Frm_TipoMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cbo_TodosLosTiposMoneda.Properties.DataSource = Resultados.EnListaTodasLasMonedasDelMundo
        Me.Cbo_TodosLosTiposMoneda.Properties.DisplayMember = "cMoneda"
        Me.Cbo_TodosLosTiposMoneda.Properties.ValueMember = "cCodigoISO"

        RefrescaGrid()

    End Sub

    Private Sub CmdEliminarTipoMoneda_Click(sender As Object, e As EventArgs) Handles CmdEliminarTipoMoneda.Click
        ''Valida que el registro no este en uso
        If Resultados.ValidarRelacion(CStr(Me.GrdVw_TipoMoneda.GetRowCellValue(Me.GrdVw_TipoMoneda.FocusedRowHandle(), Me.GrdVw_TipoMoneda.Columns.Item(3)))) = 1 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("#1 - The record cannot be deleted because it is in use.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If (DevExpress.XtraEditors.XtraMessageBox.Show("Be sure to delete the record, you will not be able to undo this action.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.None)) = DialogResult.No Then
                Exit Sub
            Else
                ECampos.gcCodigoISO = CStr(Me.GrdVw_TipoMoneda.GetRowCellValue(Me.GrdVw_TipoMoneda.FocusedRowHandle(), Me.GrdVw_TipoMoneda.Columns.Item(3)))
                Resultados.EliminaTipoMoneda(ECampos)
                RefrescaGrid()
            End If
        End If
    End Sub
End Class
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports SAM_Entidades
Imports SAM_LogicaNegocio

Public Class FrmVacPerm
    Dim Result As New LN_VacPerm
    Dim Campos As New EN_VacPerm
    Dim TipoDuracion As New EN_TipoDuracion
    Dim ConceptoTipo As New EN_ConceptoDuracion

    Dim flag As Integer ' Indica si se debe actualizar insertar nuevo registro, 1 = Inserta - 2 = Actualiza

    ''' <summary>
    ''' Refresca el GridControl para Mostrar los Datos
    ''' </summary>
    Sub RefrescarGridView()
        Me.gdcVacPerm.DataSource = Result.ListarVacPerm
    End Sub

    ''' <summary>
    ''' Limpia los Controles
    ''' </summary>
    Sub ClearControls()
        dtInicial.EditValue = Nothing
        dtFinal.EditValue = Nothing
        txtEmpleado.Text = Nothing
        lueConcepto.EditValue = Nothing
        lueTipoDuracion.Text = Nothing
        txtDuracion.EditValue = Nothing
    End Sub

    ''' <summary>
    ''' Establece no habilitados los controles de entrada.
    ''' </summary>
    ''' <param name="Valor"></param>
    Sub SetDisabled(Valor As Boolean)
        txtEmpleado.Enabled = Valor
        dtInicial.Enabled = Valor
        dtFinal.Enabled = Valor
        lueConcepto.Enabled = Valor
        txtDuracion.Enabled = Valor
        lueTipoDuracion.Enabled = Valor

        btnSave.Enabled = Valor
    End Sub

    Sub FillLookups()
        lueConcepto.Properties.DataSource = Result.ListarConceptos
        lueConcepto.Properties.DisplayMember = "Descripcion"
        lueConcepto.Properties.ValueMember = "Id"

        lueTipoDuracion.Properties.DataSource = Result.ListarTipoDuracion
        lueTipoDuracion.Properties.DisplayMember = "Descripcion"
        lueTipoDuracion.Properties.ValueMember = "Id"

        lueConcepto.Properties.Columns.Add(New LookUpColumnInfo("Id", "Id", 20))
        lueConcepto.Properties.Columns.Add(New LookUpColumnInfo("Descripcion", "Descripcion", 100))

        Dim concepto As Integer = Convert.ToInt32(Result.ListarConceptos.Rows(0)("Id"))
        lueConcepto.EditValue = concepto

        lueTipoDuracion.Properties.Columns.Add(New LookUpColumnInfo("Id", "Id", 20))
        lueTipoDuracion.Properties.Columns.Add(New LookUpColumnInfo("Descripcion", "Descripcion", 100))

        Dim duracion As Integer = Convert.ToInt32(Result.ListarConceptos.Rows(0)("Id"))
        lueTipoDuracion.EditValue = duracion
    End Sub

    Private Sub FrmVacPerm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmptyGrid(gdcVacPerm, gdvVacPerm)
        FillLookups()
        SplitContainerControl.Collapsed = True
        SetDisabled(False)

        gdvVacPerm.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        gdvVacPerm.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gdvVacPerm.OptionsView.ShowGroupPanel = False

        gdvVacPerm.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False

        gdvVacPerm.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm

        gdvVacPerm.OptionsView.EnableAppearanceEvenRow = True

        gdvVacPerm.OptionsView.ColumnAutoWidth = False
        gdvVacPerm.BestFitColumns()

        AddColumn("Id", "Id", gdvVacPerm).Visible = False
        AddColumn("Empleado", "Empleado", gdvVacPerm).Width = 100
        AddColumn("Fecha Inicial", "fechaIni", gdvVacPerm).Width = 100
        AddColumn("Fecha Final", "fechaFin", gdvVacPerm).Width = 100

        Dim concepto = AddColumn("Concepto", "Concepto", gdvVacPerm)
        concepto.Width = 100

        AddColumn("Duración", "Duracion", gdvVacPerm).Width = 100
        AddColumn("Tipo de Duración", "TipoDuracion", gdvVacPerm).Width = 150

        RefrescarGridView()

        SetEmbeddedNavigator(gdcVacPerm)
    End Sub

    Private Sub bbtCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        SplitContainerControl.Collapsed = True
        SetDisabled(False)
        bbiCancelar.Enabled = False

        ClearControls()
        btnSave.Text = "&Guardar"
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        SplitContainerControl.Collapsed = False
        SetDisabled(True)
        bbiCancelar.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Campos.Empleado = txtEmpleado.Text
        Campos.fechaIni = CType(dtInicial.EditValue, DateTime)
        Campos.fechaFin = CType(dtFinal.EditValue, DateTime)
        Campos.ConceptoOTipo = CType(lueConcepto.EditValue, Integer)
        Campos.Duracion = CType(txtDuracion.Text, Integer)
        Campos.TipoDuracion = CType(lueTipoDuracion.EditValue, Integer)

        If flag = 2 Then
            Dim a As Boolean = Result.ActualizarVacPerm(Campos)

            If a Then
                XtraMessageBox.Show("Registro Actualizado con Exito!", "Actualización de Deducción de Clinica")

                RefrescarGridView()
                ClearControls()

                SplitContainerControl.Collapsed = True
                SetDisabled(False)
                bbiCancelar.Enabled = False

                flag = Nothing
            End If
        Else
            Dim i As Boolean = Result.InsertarVacPerm(Campos)

            If i Then
                XtraMessageBox.Show("Registro Agregado con Exito!", "Registro de Deducción de Clinica")

                RefrescarGridView()
                ClearControls()
            End If
        End If
    End Sub

    Private Sub gdvVacPerm_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gdvVacPerm.CustomDrawRowIndicator
        RowIndicator(sender, e)
    End Sub

    Private Sub gdvVacPerm_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gdvVacPerm.PopupMenuShowing
        Dim view As GridView = TryCast(sender, GridView)

        If e.MenuType = GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            Dim cellValue = view.GetRowCellValue(rowHandle, "Id")

            ConceptoTipo.Descripcion = CType(view.GetRowCellValue(rowHandle, "Concepto"), String)
            Dim IdConcepto As Integer = Convert.ToInt32(Result.ObtenerIdConceptoTipo(ConceptoTipo).Rows(0)("Id"))
            ConceptoTipo.Id = IdConcepto

            TipoDuracion.Descripcion = CType(view.GetRowCellValue(rowHandle, "TipoDuracion"), String)
            Dim IdTipoDuracion As Integer = Convert.ToInt32(Result.ObtenerIdTipoDuracion(TipoDuracion).Rows(0)("Id"))
            TipoDuracion.Id = IdTipoDuracion

            Campos.Id = Convert.ToInt32(cellValue)
            Campos.Empleado = CType(view.GetRowCellValue(rowHandle, "Empleado"), String)
            Campos.fechaIni = CType(view.GetRowCellValue(rowHandle, "fechaIni"), DateTime)
            Campos.fechaFin = CType(view.GetRowCellValue(rowHandle, "fechaFin"), DateTime)
            Campos.ConceptoOTipo = CType(IdConcepto, Integer)
            Campos.Duracion = CType(view.GetRowCellValue(rowHandle, "Duracion"), Integer)
            Campos.TipoDuracion = CType(IdTipoDuracion, Integer)

            e.Menu.Items.Clear()
            e.Menu.Items.Add(CreateItemActualizar(view, rowHandle))
            e.Menu.Items.Add(CreateItemBorrar(view, rowHandle))
        End If
    End Sub

    Private Function CreateItemBorrar(ByVal view As GridView, ByVal rowHandle As Integer) As DXMenuItem
        Dim menuItemDeleteRow As DXMenuItem = New DXMenuItem("&Borrar", New EventHandler(AddressOf OnDeleteRowClick))
        menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
        menuItemDeleteRow.ImageOptions.Image = ImageCollection.Images(0)
        menuItemDeleteRow.Enabled = view.IsDataRow(rowHandle)
        Return menuItemDeleteRow
    End Function

    Private Function CreateItemActualizar(ByVal view As GridView, ByVal rowHandle As Integer) As DXMenuItem
        Dim menuItemUpdateRow As DXMenuItem = New DXMenuItem("&Actualizar", New EventHandler(AddressOf OnUpdateRowClick))
        menuItemUpdateRow.Tag = New RowInfo(view, rowHandle)
        menuItemUpdateRow.ImageOptions.Image = ImageCollection.Images(1)
        menuItemUpdateRow.Enabled = view.IsDataRow(rowHandle)
        Return menuItemUpdateRow
    End Function

    ''' <summary>
    ''' Evento que borra un fila mediante su Id
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
        Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
        If ri IsNot Nothing Then
            If XtraMessageBox.Show("Borrar esta fila?", "Confirmar Operación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            ri.View.DeleteRow(ri.RowHandle)

            Dim r As Boolean = Result.BorrarVacPerm(Campos)

            If r Then
                RefrescarGridView()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Evento que Actualiza los datos de la fila.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OnUpdateRowClick(ByVal sender As Object, ByVal e As EventArgs)
        'Dim row As DataTable = Result.ListarDeduccionesClinicaPorId(Campos)

        txtEmpleado.Text = Campos.Empleado
        dtInicial.EditValue = Convert.ToDateTime(Campos.fechaIni)
        dtFinal.EditValue = Convert.ToDateTime(Campos.fechaFin)

        lueConcepto.EditValue = Campos.ConceptoOTipo
        txtDuracion.Text = CType(Campos.Duracion, String)
        lueTipoDuracion.EditValue = Campos.TipoDuracion

        btnSave.Text = "&Actualizar"
        SplitContainerControl.Collapsed = False
        SetDisabled(True)
        bbiCancelar.Enabled = True

        flag = 2
    End Sub

    ''' <summary>
    ''' Devuelve Informacion acerca de la fila seleccionada.
    ''' </summary>
    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub

        Public View As GridView
        Public RowHandle As Integer
    End Class
End Class
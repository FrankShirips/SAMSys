Imports System.ComponentModel
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.EditForm.Helpers.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports SAM_Entidades
Imports SAM_LogicaNegocio
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.Office.Utils

Public Class FrmIR
    Dim Result As New LN_IR
    Dim Campos As New EN_IR

    Dim anio As TextEdit
    Dim fechaInicia As DateEdit
    Dim fechaFinal As DateEdit
    Dim minimo As TextEdit
    Dim maximo As TextEdit
    Dim porcAplica As TextEdit
    Dim impuestoBase As TextEdit
    Dim sobreExceso As TextEdit

    Dim Acciones As String = "A"

    ''' <summary>
    ''' Refresca el GridControl para Mostrar los Datos
    ''' </summary>
    Sub RefrescarGridView()
        Me.gdcIR.DataSource = Result.ListarIR()
    End Sub

    Private Sub FrmIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmptyGrid(gdcIR, gdvIR)

        gdvIR.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        gdvIR.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gdvIR.OptionsView.ShowGroupPanel = False

        gdvIR.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False

        gdvIR.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm

        gdvIR.OptionsView.EnableAppearanceEvenRow = True

        gdvIR.OptionsView.ColumnAutoWidth = False
        gdvIR.BestFitColumns()

        AddColumn("Id", "Id", gdvIR).Visible = False
        AddColumn("Año", "nCodAño", gdvIR).Width = 100
        AddColumn("Fecha Inicial", "fFechaInicia", gdvIR).Width = 100
        AddColumn("Fecha Final", "fFechaFinal", gdvIR).Width = 100

        Dim minimo = AddColumn("Minimo", "nMinimo", gdvIR)
        minimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        minimo.DisplayFormat.FormatString = "c2"
        minimo.Width = 100

        Dim maximo = AddColumn("Maximo", "nMaximo", gdvIR)
        maximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        maximo.DisplayFormat.FormatString = "c2"
        maximo.Width = 100

        Dim porcentaje = AddColumn("% que Aplica", "nPorcAplica", gdvIR)
        porcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        porcentaje.DisplayFormat.FormatString = "{0:n0} %"
        porcentaje.Width = 120

        AddColumn("Impuesto Base", "nImpuestoBase", gdvIR).Width = 150
        AddColumn("Sobre Exceso", "nSobreExceso", gdvIR).Width = 150

        RefrescarGridView()
        SetEmbeddedNavigator(gdcIR)

    End Sub

    Private Sub gdvIR_EditFormPrepared(sender As Object, e As EditFormPreparedEventArgs) Handles gdvIR.EditFormPrepared
        anio = TryCast(e.BindableControls("nCodAño"), TextEdit)
        fechaInicia = TryCast(e.BindableControls("fFechaInicia"), DateEdit)
        fechaFinal = TryCast(e.BindableControls("fFechaFinal"), DateEdit)
        minimo = TryCast(e.BindableControls("nMinimo"), TextEdit)
        maximo = TryCast(e.BindableControls("nMaximo"), TextEdit)
        porcAplica = TryCast(e.BindableControls("nPorcAplica"), TextEdit)
        impuestoBase = TryCast(e.BindableControls("nImpuestoBase"), TextEdit)
        sobreExceso = TryCast(e.BindableControls("nSobreExceso"), TextEdit)
    End Sub

    Private Sub gdvIR_EditFormHidden(sender As Object, e As EditFormHiddenEventArgs) Handles gdvIR.EditFormHidden
        If e.Result = EditFormResult.Update Then
            Dim View As GridView = TryCast(sender, GridView)

            Dim cellValue = View.GetRowCellValue(e.RowHandle, "Id")

            Campos.Id = CType(cellValue, Integer)
            Campos.codAnio = CType(anio.Text, Integer)
            Campos.fechaInica = DirectCast(fechaInicia.EditValue, DateTime)
            Campos.fechaFinal = DirectCast(fechaFinal.EditValue, DateTime)
            Campos.minimo = minimo.Text
            Campos.maximo = maximo.Text
            Campos.porcAplica = porcAplica.Text
            Campos.impuestoBase = impuestoBase.Text
            Campos.sobreExceso = sobreExceso.Text

            Dim i As Boolean

            If Acciones.Equals("A") Then
                i = Result.ActualizarIR(Campos)

                If i Then
                    XtraMessageBox.Show("Los cambios son sastifactoriamente guardados.", "Actualizar Datos IR")
                End If
            Else
                If Acciones.Equals("I") Then
                    i = Result.InsertarIR(Campos)

                    If i Then
                        XtraMessageBox.Show("Los cambios son sastifactoriamente guardados.", "Guardar Datos IR")
                        Acciones = "A"
                    End If
                End If
            End If
        End If

        If e.Result = EditFormResult.Cancel Then
            Acciones = "A"
        End If
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Acciones = "I"
        gdvIR.OptionsView.NewItemRowPosition = NewItemRowPosition.None
        gdvIR.AddNewRow()
    End Sub

    Private Sub gdvIR_ShowingPopupEditForm(sender As Object, e As ShowingPopupEditFormEventArgs) Handles gdvIR.ShowingPopupEditForm
        e.EditForm.CloseBox = False
        e.EditForm.FormBorderEffect = FormBorderEffect.Shadow
        e.EditForm.FormBorderStyle = FormBorderStyle.FixedSingle

        e.EditForm.MaximizeBox = False

        If Acciones.Equals("I") Then
            ChangeNameEditForm("Guardar", "Cancelar", e)
        Else
            ChangeNameEditForm("Actualizar", "Cancelar", e)
        End If
    End Sub

    Sub ChangeNameEditForm(ByVal captionUpdate As String, ByVal captionCancel As String, ByVal e As ShowingPopupEditFormEventArgs)
        For Each control As Control In e.EditForm.Controls ' Por cada control en la lista de controles de EditForm
            If Not (TypeOf control Is EditFormContainer) Then ' Si control no es de tipo EditFormContainer
                Continue For ' Continuar con el For
            End If
            For Each nestedControl As Control In control.Controls ' Ppor cada control en la lista de controles
                If Not (TypeOf nestedControl Is PanelControl) Then ' SI control no es de tipo PanelControl
                    Continue For ' Continuar con el For
                End If
                For Each button As Control In nestedControl.Controls ' Por cada button en lista de controles
                    If TypeOf button Is SimpleButton Then ' Si button es de tipo SimpleButton
                        Dim simpleButton = TryCast(button, SimpleButton) ' Convierte button en SimpleButton

                        ChangeButtonCaption(simpleButton, captionUpdate, captionCancel) ' Metodo que cambia el nombre del boton
                        ChangeButtonSize(simpleButton) ' Metodo que cambia el tamaño del boton
                    End If
                Next button
            Next nestedControl
        Next control
    End Sub

    ''' <summary>
    ''' Cambia el titulo de los botonos en Edit Form
    ''' </summary>
    ''' <param name="btn"></param>
    ''' <param name="nameUpdate"></param>
    ''' <param name="nameCancel"></param>
    Private Shared Sub ChangeButtonCaption(ByVal btn As SimpleButton, ByVal nameUpdate As String, ByVal nameCancel As String)
        Dim newUpdateBtnText = nameUpdate
        Dim newCancelBtnText = nameCancel
        Dim btnText = btn.Text
        Select Case btnText
            Case "Actualizar"
                btn.Text = newUpdateBtnText
            Case "Cancelar"
                btn.Text = newCancelBtnText
            Case "Guardar"
                btn.Text = "Actualizar"
        End Select
    End Sub
    ''' <summary>
    ''' Calcula el mejor tamaño para los botones.
    ''' </summary>
    ''' <param name="btn"></param>
    Private Shared Sub ChangeButtonSize(ByVal btn As SimpleButton)
        btn.CalcBestSize()
    End Sub

    Private Sub gdvIR_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles gdvIR.PopupMenuShowing
        Dim view As GridView = TryCast(sender, GridView)

        If e.MenuType = GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            Dim cellValue = view.GetRowCellValue(rowHandle, "Id")
            Campos.Id = CType(cellValue, Integer)

            e.Menu.Items.Clear()
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

    ''' <summary>
    ''' Evento que borra un fila mediante su Id
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
        Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
        If ri IsNot Nothing Then
            If XtraMessageBox.Show("Borrar Fila?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

            Dim d As Boolean = Result.BorrarIR(Campos)

            If d Then
                ri.View.DeleteRow(ri.RowHandle)
            End If
        End If
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

    Private Sub gdvIR_KeyDown(sender As Object, e As KeyEventArgs) Handles gdvIR.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Borrar Fila?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Dim view As GridView = CType(sender, GridView)
            Dim cellValue = view.GetRowCellValue(view.FocusedRowHandle, "Id")

            Campos.Id = CType(cellValue, Integer)

            Dim d As Boolean = Result.BorrarIR(Campos)

            If d Then
                view.DeleteRow(Campos.Id)
            End If
        End If
    End Sub
End Class
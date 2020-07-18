Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports SAM_Entidades
Imports SAM_LogicaNegocio
Imports System.Configuration
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu

Public Class FrmDeducionesEPP
    Dim Result As New LN_DeduccionEPP
    Dim Campos As New EN_DeduccionEPP
    Dim workSheet As Worksheet
    Dim flag As Integer ' Indica si se debe actualizar insertar nuevo registro, 1 = Inserta - 2 = Actualiza

    ''' <summary>
    ''' Refresca el GridControl para Mostrar los Datos
    ''' </summary>
    Sub RefrescarGridView()
        Me.gdcDeducEPP.DataSource = Result.ListarDeduccionesEPP(Campos)
    End Sub

    ''' <summary>
    ''' Limpia los Controles
    ''' </summary>
    Sub ClearControls()
        dtFecha.EditValue = Nothing
        txtNEmpleado.Text = Nothing
        txtProyecto.Text = Nothing
        txtNombre.Text = Nothing
        txtMonto.EditValue = Nothing
        mmConcepto.EditValue = Nothing
    End Sub

    ''' <summary>
    ''' Establece no habilitados los controles de entrada.
    ''' </summary>
    ''' <param name="Valor"></param>
    Sub SetDisabled(Valor As Boolean)
        dtFecha.Enabled = Valor
        txtNEmpleado.Enabled = Valor
        txtProyecto.Enabled = Valor
        txtNombre.Enabled = Valor
        txtMonto.Enabled = Valor
        mmConcepto.Enabled = Valor

        btnSave.Enabled = Valor
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmDeducionesClinica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFecha.Properties.MaxValue = DateTime.Today
        SplitContainerControl.Collapsed = True
        SetDisabled(False)

        gdvDeducEPP.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        gdvDeducEPP.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gdvDeducEPP.OptionsView.ShowGroupPanel = False

        gdvDeducEPP.OptionsView.EnableAppearanceEvenRow = True

        gdvDeducEPP.OptionsView.ColumnAutoWidth = False
        gdvDeducEPP.BestFitColumns()

        AddColumn("Id", "Id", gdvDeducEPP).Visible = False
        AddColumn("Fecha", "Fecha", gdvDeducEPP).Width = 150
        AddColumn("# Empleado", "N_Empl", gdvDeducEPP).Width = 150
        AddColumn("Nombre", "Nombre", gdvDeducEPP).Width = 150
        AddColumn("Proyecto", "Proyecto", gdvDeducEPP).Width = 150
        AddColumn("Concepto", "Concepto", gdvDeducEPP).Width = 150
        AddColumn("Monto en C$", "Monto", gdvDeducEPP).Width = 150

        RefrescarGridView()
        EmptyGrid(gdcDeducEPP, gdvDeducEPP)
        SetEmbeddedNavigator(gdcDeducEPP)

        workSheet = SpreadsheetControl.Document.Worksheets(0)

        workSheet.Name = "Deducciones EPP"
    End Sub

    Private Sub bbiNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        SplitContainerControl.Collapsed = False
        SetDisabled(True)
        bbiCancelar.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim currentValue As DateTime = DateTime.Today

        If Not (currentValue.Month = Convert.ToDateTime(dtFecha.EditValue).Month And
          currentValue.Year = Convert.ToDateTime(dtFecha.EditValue).Year) Then

            DXErrorProvider.SetError(dtFecha, "Ingresa una fecha dentro del mes actual")
            DXErrorProvider.SetIconAlignment(dtFecha, ErrorIconAlignment.MiddleRight)

            Return
        Else
            dtFecha.ErrorText = Nothing
        End If

        If String.IsNullOrEmpty(txtNEmpleado.Text) Then
            EsNullOVacio(txtNEmpleado.Text, txtNEmpleado, "El numero de Empleado no tiene que ser null o estar vacio.")
            Return
        Else
            txtNEmpleado.ErrorText = Nothing
        End If

        If String.IsNullOrEmpty(txtNombre.Text) Then
            EsNullOVacio(txtNombre.Text, txtNombre, "El nombre de Empleado no tiene que ser null o estar vacio.")
            Return
        Else
            txtNombre.ErrorText = Nothing
        End If

        If String.IsNullOrEmpty(txtProyecto.Text) Then
            EsNullOVacio(txtProyecto.Text, txtProyecto, "El nombre del Proyecto no tiene que ser null o estar vacio.")
            Return
        Else
            txtProyecto.ErrorText = Nothing
        End If

        If String.IsNullOrEmpty(mmConcepto.Text) Then
            EsNullOVacio(mmConcepto.Text, mmConcepto, "El Concepto de deducion no tiene que ser null o estar vacio.")
            Return
        Else
            mmConcepto.ErrorText = Nothing
        End If

        If String.IsNullOrEmpty(CType(txtMonto.EditValue, String)) Then
            EsNullOVacio(CType(txtMonto.EditValue, String), txtMonto, "El monto deducido no tiene que ser null o estar vacio.")
            Return
        Else
            txtMonto.ErrorText = Nothing
        End If

        Campos.DFecha = CType(dtFecha.EditValue, DateTime)
        Campos.DN_Empl = txtNEmpleado.Text
        Campos.DProyecto = txtProyecto.Text
        Campos.DNombre = txtNombre.Text
        Campos.DMonto = Convert.ToDecimal(txtMonto.EditValue)
        Campos.DConcepto = mmConcepto.Text

        If flag = 2 Then
            Dim a As Boolean = Result.ActualizarDeduccionesEPP(Campos)

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
            Dim i As Boolean = Result.InsertDeducionesEPP(Campos)

            If i Then
                XtraMessageBox.Show("Registro Agregado con Exito!", "Registro de Deducción de Clinica")

                RefrescarGridView()
                ClearControls()
            End If
        End If
    End Sub

    Private Sub gdvDeducEPP_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gdvDeducEPP.CustomDrawRowIndicator, gdvDeducEPP.CustomDrawRowIndicator
        RowIndicator(sender, e)
    End Sub

    Private Sub bbiCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancelar.ItemClick
        SplitContainerControl.Collapsed = True
        SetDisabled(False)
        bbiCancelar.Enabled = False

        ClearControls()
        btnSave.Text = "&Guardar"
    End Sub

    Private Sub bbiImportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImportarExcel.ItemClick
        Using ofd As New XtraOpenFileDialog()
            ofd.InitialDirectory = Application.StartupPath
            ofd.Title = "Abrir Archivo"
            ofd.DefaultExt = "xlsx"
            ofd.Filter = "Excel Archivos|*.xls;*.xlsx"
            ofd.FilterIndex = 2
            ofd.ValidateNames = True
            ofd.RestoreDirectory = True

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim data As DataTable = ExcelToDataTable(ofd.FileName)

                For Each row As DataRow In data.Rows
                    Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnxString").ToString())
                        Dim cmd As New SqlCommand("dbo.InsertarDeduccionesEPP")
                        cmd.Connection = conn
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@FECHA", row(0))
                        cmd.Parameters.AddWithValue("@N_EMPL", row(1))
                        cmd.Parameters.AddWithValue("@NOMBRE", row(2))
                        cmd.Parameters.AddWithValue("@PROYECTO", row(3))
                        cmd.Parameters.AddWithValue("@CONCEPTO", row(4))
                        cmd.Parameters.AddWithValue("@MONTO", row(5))

                        conn.Open()

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                RefrescarGridView()
                XtraMessageBox.Show("Registro Agregado con Exito!", "Importar Datos de Excel")
            End If
        End Using
    End Sub

    Function ExcelToDataTable(fullFilePath As String) As DataTable
        Dim workbook As New Workbook()
        workbook.LoadDocument(fullFilePath, DocumentFormat.Xlsx)

        Dim workSheet As Worksheet
        workSheet = workbook.Worksheets(0)
        Dim usedRange = workSheet.GetUsedRange()
        Dim dataTable = workSheet.CreateDataTable(usedRange, True, True)

        For i = 0 To usedRange.RowCount - 1

            Dim newRow As DataRow = dataTable.NewRow()

            For j = 0 To usedRange.CurrentRegion.ColumnCount - 1
                newRow(j) = workSheet.Cells(i, j).DisplayText
            Next

            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function

    Private Sub btnSaveExcel_Click(sender As Object, e As EventArgs) Handles btnSaveExcel.Click
        Dim usedRange As CellRange = workSheet.GetUsedRange()
        Dim currentTable As New DataTable

        For i As Integer = 0 To usedRange.ColumnCount - 1
            currentTable.Columns.Add("Column" & i.ToString())
        Next i

        For i As Integer = 0 To usedRange.RowCount - 1
            Dim newRow As DataRow = currentTable.NewRow()
            For j As Integer = 0 To usedRange.ColumnCount - 1
                newRow(j) = workSheet.Cells(i, j).DisplayText
            Next j
            currentTable.Rows.Add(newRow)
        Next i

        For Each row As DataRow In currentTable.Rows
            Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnxString").ToString())
                Dim cmd As New SqlCommand("dbo.InsertarDeduccionesEPP")
                cmd.Connection = conn
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@FECHA", row(0))
                cmd.Parameters.AddWithValue("@N_EMPL", row(1))
                cmd.Parameters.AddWithValue("@NOMBRE", row(2))
                cmd.Parameters.AddWithValue("@PROYECTO", row(3))
                cmd.Parameters.AddWithValue("@CONCEPTO", row(4))
                cmd.Parameters.AddWithValue("@MONTO", row(5))

                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        Next

        RefrescarGridView()
        workSheet.Clear(usedRange)
        XtraMessageBox.Show("Registro Agregado con Exito!", "Copiar Datos de Excel a Base de Datos")
    End Sub

    Private Sub bbiCopiarDatosExcell2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCopiarDatosExcell2.ItemClick
        Dim rect As Rectangle = Screen.GetWorkingArea(Me)
        PopupControlContainer.ShowPopup(Cursor.Position)
    End Sub

    Private Sub gdvDeducEPP_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gdvDeducEPP.PopupMenuShowing, gdvDeducEPP.PopupMenuShowing
        Dim view As GridView = TryCast(sender, GridView)

        If e.MenuType = GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            Dim cellValue = view.GetRowCellValue(rowHandle, "Id")
            Campos.DId = Convert.ToInt32(cellValue)

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

            Dim r As Boolean = Result.BorrarDeducionesEPP(Campos)

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
        Dim row As DataTable = Result.ListarDeduccionesEPPPorId(Campos)

        dtFecha.EditValue = Convert.ToDateTime(row.Rows(0).Item(1).ToString())
        txtNEmpleado.Text = row.Rows(0).Item(2).ToString()
        txtNombre.Text = row.Rows(0).Item(3).ToString()
        txtProyecto.Text = row.Rows(0).Item(4).ToString()
        mmConcepto.Text = row.Rows(0).Item(5).ToString()
        txtMonto.EditValue = row.Rows(0).Item(6)

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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            DxErrorProvider.SetError(dtFecha, "El nombre debe ser solo letras y espacios.")
            DxErrorProvider.SetIconAlignment(dtFecha, ErrorIconAlignment.MiddleRight)
            e.Handled = True
        End If
    End Sub

    Sub EsNullOVacio(ByVal textControl As String, ByVal control As Object, ByVal mensaje As String)
        DXErrorProvider.SetError(CType(control, Control), mensaje)
        DXErrorProvider.SetIconAlignment(CType(control, Control), ErrorIconAlignment.MiddleRight)
    End Sub
End Class
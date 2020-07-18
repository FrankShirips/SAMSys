Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports SAM_Entidades
Imports SAM_LogicaNegocio
Module Mod_Generales
#Region "Variables Generales"

    Public CodigoUsuario As String
    Public NombreUsuario As String

#End Region
#Region "Funciones Generales"
    Public Sub LimpiaControles(ByVal Formulario As Form)
        For Each Elemento In Formulario.Controls
            Dim TipoElemento As Type = Elemento.GetType
            If TipoElemento.FullName = "DevExpress.XtraEditors.TextEdit" Then
                Dim Obj As TextEdit = DirectCast(Elemento, TextEdit)
                Obj.Text = ""
            ElseIf TipoElemento.FullName = "DevExpress.XtraEditors.DateEdit" Then
                Dim Obj As DateEdit = DirectCast(Elemento, DateEdit)
                Obj.Text = ""
            ElseIf TipoElemento.FullName = "DevExpress.XtraEditors.ComboBoxEdit" Then
                Dim Obj As ComboBoxEdit = DirectCast(Elemento, ComboBoxEdit)
                Obj.Text = ""
            End If
        Next
    End Sub
    Public Sub RefrescaGrid(ByVal Grid As DevExpress.XtraGrid.GridControl, ByVal Datos As DataTable)
        Grid.DataSource = Datos
        Grid.Refresh()
    End Sub
    Public Sub Mensage(Mensage As String, Boton As MessageBoxButtons, Icono As MessageBoxIcon, ByVal Titulo As String)
        Dim Result As DialogResult
        Result = DevExpress.XtraEditors.XtraMessageBox.Show(Mensage, Titulo, Boton, Icono)
    End Sub

    ''' <summary>
    ''' Muestra un mensaje cuando el GridView no tiene ningun registro.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub EmptyGrid(ByVal gridControl As GridControl, ByVal gridView As GridView)
        Dim noMatchesFoundTextFont As New Font("Tahoma", 10, FontStyle.Bold)
        Dim noMatchesFoundText As String = "No hay Elementos en Esta Vista"
        Dim noMatchesFoundBounds As Rectangle = Rectangle.Empty
        Dim offset As Integer = 10

        AddHandler gridView.CustomDrawEmptyForeground, Sub(s, e)
                                                           e.DefaultDraw()
                                                           e.Appearance.Options.UseFont = True
                                                           e.Appearance.Font = noMatchesFoundTextFont

                                                           Dim size As Size = e.Appearance.CalcTextSize(e.Cache, noMatchesFoundText, e.Bounds.Width).ToSize()
                                                           Dim x As Integer = (e.Bounds.Width - size.Width) \ 2
                                                           Dim y As Integer = e.Bounds.Y + offset
                                                           noMatchesFoundBounds = New Rectangle(New Point(x, y), size)
                                                           e.Appearance.DrawString(e.Cache, noMatchesFoundText, noMatchesFoundBounds)
                                                       End Sub
    End Sub

    ''' <summary>
    ''' Muestra Panel de Navegacion de los Registros en El GridControl
    ''' </summary>
    ''' <param name="gridcontrol"></param>
    Public Sub SetEmbeddedNavigator(gridcontrol As GridControl)
        gridcontrol.UseEmbeddedNavigator = True
        Dim navigator As ControlNavigator = gridcontrol.EmbeddedNavigator
        navigator.Buttons.BeginUpdate()
        Try
            navigator.Buttons.Append.Visible = False
            navigator.Buttons.Remove.Visible = False
            navigator.Buttons.Edit.Visible = False
            navigator.Buttons.Remove.Visible = False
            navigator.Buttons.CancelEdit.Visible = False
            navigator.Buttons.EndEdit.Visible = False
        Finally
            navigator.Buttons.EndUpdate()
        End Try
    End Sub

    ''' <summary>
    ''' Dibuja el indicador de numero en el GridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub RowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs)
        If e.RowHandle < 0 Then
            Return
        End If

        e.Info.ImageIndex = -1
        e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        e.Appearance.DrawString(e.Cache, Convert.ToString(e.RowHandle + 1), e.Bounds)
        e.Handled = True
    End Sub

    ''' <summary>
    ''' Funcion que agrega Columnas a GridView
    ''' </summary>
    ''' <param name="caption"></param>
    ''' <param name="fieldname"></param>
    ''' <param name="view"></param>
    ''' <returns></returns>
    Public Function AddColumn(caption As String, fieldname As String, view As GridView) As GridColumn
        Dim column As GridColumn = view.Columns.Add()
        column.Caption = caption
        column.FieldName = fieldname
        column.Visible = True
        column.AppearanceHeader.Font = New Font("Tahoma", 9, FontStyle.Bold)
        column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Return column
    End Function
#End Region
End Module

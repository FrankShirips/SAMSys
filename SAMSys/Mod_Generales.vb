Imports DevExpress.XtraEditors
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
#End Region
End Module

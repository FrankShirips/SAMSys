<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVacPerm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVacPerm))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDuracion = New DevExpress.XtraEditors.TextEdit()
        Me.lueTipoDuracion = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueConcepto = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtFinal = New DevExpress.XtraEditors.DateEdit()
        Me.dtInicial = New DevExpress.XtraEditors.DateEdit()
        Me.gdcVacPerm = New DevExpress.XtraGrid.GridControl()
        Me.gdvVacPerm = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bbiCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl.SuspendLayout()
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl.SuspendLayout()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoDuracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcVacPerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvVacPerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.AllowQuickCustomization = False
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiNuevo, Me.bbiCancelar})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 2
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "&Nuevo"
        Me.bbiNuevo.Id = 0
        Me.bbiNuevo.ImageOptions.ImageUri.Uri = "spreadsheet/insertsheetrows"
        Me.bbiNuevo.Name = "bbiNuevo"
        ToolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        ToolTipTitleItem1.Appearance.Options.UseFont = True
        ToolTipTitleItem1.Text = "Nuevo"
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Habilita una nuneva fila para ingresar datos."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.bbiNuevo.SuperTip = SuperToolTip1
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(922, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 411)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(922, 18)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 383)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(922, 28)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 383)
        '
        'SplitContainerControl
        '
        Me.SplitContainerControl.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl.IsSplitterFixed = True
        Me.SplitContainerControl.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainerControl.Name = "SplitContainerControl"
        Me.SplitContainerControl.Panel1.Controls.Add(Me.GroupControl)
        Me.SplitContainerControl.Panel1.Text = "Panel1"
        Me.SplitContainerControl.Panel2.Controls.Add(Me.gdcVacPerm)
        Me.SplitContainerControl.Panel2.Text = "Panel2"
        Me.SplitContainerControl.Size = New System.Drawing.Size(922, 383)
        Me.SplitContainerControl.SplitterPosition = 334
        Me.SplitContainerControl.TabIndex = 9
        '
        'GroupControl
        '
        Me.GroupControl.AutoSize = True
        Me.GroupControl.Controls.Add(Me.txtEmpleado)
        Me.GroupControl.Controls.Add(Me.btnSave)
        Me.GroupControl.Controls.Add(Me.LabelControl6)
        Me.GroupControl.Controls.Add(Me.LabelControl5)
        Me.GroupControl.Controls.Add(Me.LabelControl4)
        Me.GroupControl.Controls.Add(Me.LabelControl3)
        Me.GroupControl.Controls.Add(Me.LabelControl2)
        Me.GroupControl.Controls.Add(Me.LabelControl1)
        Me.GroupControl.Controls.Add(Me.txtDuracion)
        Me.GroupControl.Controls.Add(Me.lueTipoDuracion)
        Me.GroupControl.Controls.Add(Me.lueConcepto)
        Me.GroupControl.Controls.Add(Me.dtFinal)
        Me.GroupControl.Controls.Add(Me.dtInicial)
        Me.GroupControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.Size = New System.Drawing.Size(334, 383)
        Me.GroupControl.TabIndex = 0
        Me.GroupControl.Text = "VACACIONES Y PERMISOS"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(115, 44)
        Me.txtEmpleado.MenuManager = Me.BarManager
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpleado.TabIndex = 31
        '
        'btnSave
        '
        Me.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSave.Appearance.Options.UseBackColor = True
        Me.btnSave.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.btnSave.Location = New System.Drawing.Point(38, 213)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(258, 28)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "&GUARDAR"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(12, 177)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Tipo de Duración:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(56, 151)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Duración:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(53, 125)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Concepto:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(44, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Fecha Final:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(36, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Fecha Inicial:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(51, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Empleado:"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(115, 148)
        Me.txtDuracion.MenuManager = Me.BarManager
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(62, 20)
        Me.txtDuracion.TabIndex = 5
        '
        'lueTipoDuracion
        '
        Me.lueTipoDuracion.Location = New System.Drawing.Point(115, 174)
        Me.lueTipoDuracion.MenuManager = Me.BarManager
        Me.lueTipoDuracion.Name = "lueTipoDuracion"
        Me.lueTipoDuracion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoDuracion.Size = New System.Drawing.Size(208, 20)
        Me.lueTipoDuracion.TabIndex = 4
        '
        'lueConcepto
        '
        Me.lueConcepto.Location = New System.Drawing.Point(115, 122)
        Me.lueConcepto.MenuManager = Me.BarManager
        Me.lueConcepto.Name = "lueConcepto"
        Me.lueConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueConcepto.Size = New System.Drawing.Size(208, 20)
        Me.lueConcepto.TabIndex = 3
        '
        'dtFinal
        '
        Me.dtFinal.EditValue = Nothing
        Me.dtFinal.Location = New System.Drawing.Point(115, 96)
        Me.dtFinal.MenuManager = Me.BarManager
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Size = New System.Drawing.Size(208, 20)
        Me.dtFinal.TabIndex = 2
        '
        'dtInicial
        '
        Me.dtInicial.EditValue = Nothing
        Me.dtInicial.Location = New System.Drawing.Point(115, 70)
        Me.dtInicial.MenuManager = Me.BarManager
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicial.Size = New System.Drawing.Size(208, 20)
        Me.dtInicial.TabIndex = 1
        '
        'gdcVacPerm
        '
        Me.gdcVacPerm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcVacPerm.Location = New System.Drawing.Point(0, 0)
        Me.gdcVacPerm.MainView = Me.gdvVacPerm
        Me.gdcVacPerm.Name = "gdcVacPerm"
        Me.gdcVacPerm.Size = New System.Drawing.Size(578, 383)
        Me.gdcVacPerm.TabIndex = 5
        Me.gdcVacPerm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvVacPerm})
        '
        'gdvVacPerm
        '
        Me.gdvVacPerm.GridControl = Me.gdcVacPerm
        Me.gdvVacPerm.Name = "gdvVacPerm"
        '
        'bbiCancelar
        '
        Me.bbiCancelar.Caption = "&Cancelar"
        Me.bbiCancelar.Id = 1
        Me.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel"
        Me.bbiCancelar.Name = "bbiCancelar"
        ToolTipTitleItem2.Text = "Cancelar"
        ToolTipItem2.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem2.Text = "Cancela la agregacion o edicion de vacaciones o permisos"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.bbiCancelar.SuperTip = SuperToolTip2
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "delete_32x32.png")
        Me.ImageCollection.Images.SetKeyName(1, "recurrence_32x32.png")
        '
        'FrmVacPerm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 429)
        Me.Controls.Add(Me.SplitContainerControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVacPerm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Vacaciones y Permisos"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl.ResumeLayout(False)
        CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl.ResumeLayout(False)
        Me.GroupControl.PerformLayout()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoDuracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcVacPerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvVacPerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gdcVacPerm As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvVacPerm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueConcepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDuracion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueTipoDuracion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bbiCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
End Class

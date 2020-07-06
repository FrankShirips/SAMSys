<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FechasCierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_FechasCierre))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GrdCtrl_FechasCierre = New DevExpress.XtraGrid.GridControl()
        Me.GrdVw_FechasCierre = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gnIDReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gAño = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gQuincena = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gFecIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gFecFin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gFecPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Menu_Derecho_CalendarioCierre = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GrdCtrl_FechasCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVw_FechasCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_Derecho_CalendarioCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GrdCtrl_FechasCierre)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(732, 373)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GrdCtrl_FechasCierre
        '
        Me.GrdCtrl_FechasCierre.Location = New System.Drawing.Point(12, 12)
        Me.GrdCtrl_FechasCierre.MainView = Me.GrdVw_FechasCierre
        Me.GrdCtrl_FechasCierre.Name = "GrdCtrl_FechasCierre"
        Me.GrdCtrl_FechasCierre.Size = New System.Drawing.Size(708, 349)
        Me.GrdCtrl_FechasCierre.TabIndex = 4
        Me.GrdCtrl_FechasCierre.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVw_FechasCierre})
        '
        'GrdVw_FechasCierre
        '
        Me.GrdVw_FechasCierre.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gnIDReg, Me.gAño, Me.gMes, Me.gQuincena, Me.gFecIni, Me.gFecFin, Me.gFecPago, Me.gEstado})
        Me.GrdVw_FechasCierre.GridControl = Me.GrdCtrl_FechasCierre
        Me.GrdVw_FechasCierre.Name = "GrdVw_FechasCierre"
        Me.GrdVw_FechasCierre.OptionsBehavior.Editable = False
        Me.GrdVw_FechasCierre.OptionsView.ShowGroupPanel = False
        '
        'gnIDReg
        '
        Me.gnIDReg.Caption = "Id"
        Me.gnIDReg.FieldName = "nIdReg"
        Me.gnIDReg.Name = "gnIDReg"
        Me.gnIDReg.Visible = True
        Me.gnIDReg.VisibleIndex = 0
        Me.gnIDReg.Width = 60
        '
        'gAño
        '
        Me.gAño.Caption = "Year"
        Me.gAño.FieldName = "Año"
        Me.gAño.Name = "gAño"
        Me.gAño.Visible = True
        Me.gAño.VisibleIndex = 1
        '
        'gMes
        '
        Me.gMes.Caption = "Month"
        Me.gMes.FieldName = "Mes"
        Me.gMes.Name = "gMes"
        Me.gMes.Visible = True
        Me.gMes.VisibleIndex = 2
        Me.gMes.Width = 122
        '
        'gQuincena
        '
        Me.gQuincena.Caption = "Biweekly"
        Me.gQuincena.FieldName = "Quincena"
        Me.gQuincena.Name = "gQuincena"
        Me.gQuincena.Visible = True
        Me.gQuincena.VisibleIndex = 3
        Me.gQuincena.Width = 105
        '
        'gFecIni
        '
        Me.gFecIni.Caption = "Start Date"
        Me.gFecIni.FieldName = "FechaInicio"
        Me.gFecIni.Name = "gFecIni"
        Me.gFecIni.Visible = True
        Me.gFecIni.VisibleIndex = 4
        Me.gFecIni.Width = 105
        '
        'gFecFin
        '
        Me.gFecFin.Caption = "Final Date"
        Me.gFecFin.FieldName = "FechaFinal"
        Me.gFecFin.Name = "gFecFin"
        Me.gFecFin.Visible = True
        Me.gFecFin.VisibleIndex = 5
        Me.gFecFin.Width = 105
        '
        'gFecPago
        '
        Me.gFecPago.Caption = "Payment Day"
        Me.gFecPago.FieldName = "FechaPago"
        Me.gFecPago.Name = "gFecPago"
        Me.gFecPago.Visible = True
        Me.gFecPago.VisibleIndex = 6
        Me.gFecPago.Width = 105
        '
        'gEstado
        '
        Me.gEstado.Caption = "State"
        Me.gEstado.FieldName = "cDesEstado"
        Me.gEstado.Name = "gEstado"
        Me.gEstado.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.gEstado.Width = 120
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(732, 373)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GrdCtrl_FechasCierre
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(712, 353)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Import"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "   Closed   "
        Me.BarStaticItem1.Id = 2
        Me.BarStaticItem1.ItemAppearance.Normal.BackColor = System.Drawing.Color.Salmon
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseBackColor = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem2.Caption = "  In Progress  "
        Me.BarStaticItem2.Id = 3
        Me.BarStaticItem2.ItemAppearance.Normal.BackColor = System.Drawing.Color.Yellow
        Me.BarStaticItem2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseBackColor = True
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem3.Caption = "  Open  "
        Me.BarStaticItem3.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center
        Me.BarStaticItem3.Id = 4
        Me.BarStaticItem3.ItemAppearance.Normal.BackColor = System.Drawing.Color.Lime
        Me.BarStaticItem3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseBackColor = True
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(732, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 401)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(732, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 373)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(732, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 373)
        '
        'Menu_Derecho_CalendarioCierre
        '
        Me.Menu_Derecho_CalendarioCierre.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3)})
        Me.Menu_Derecho_CalendarioCierre.Manager = Me.BarManager1
        Me.Menu_Derecho_CalendarioCierre.Name = "Menu_Derecho_CalendarioCierre"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Delete Selection"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Edit"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'Frm_FechasCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 401)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_FechasCierre"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Closing Calendar"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GrdCtrl_FechasCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVw_FechasCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_Derecho_CalendarioCierre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GrdCtrl_FechasCierre As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVw_FechasCierre As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gnIDReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gAño As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gQuincena As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gFecIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gFecFin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gFecPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_Derecho_CalendarioCierre As DevExpress.XtraBars.PopupMenu
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PrestacionesLey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PrestacionesLey))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Grdctrl_Prestaciones = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gAño = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gInicia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gFin = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gInssLab = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gnInssPat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gInatec = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gVacaciones = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gAguinaldo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gIndemnizacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Cmd_InsertUpdatePrestaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.CmdEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.CmdEditRegPrestaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.CmdEliminaRegPrestaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuReg_Prestaciones = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Grdctrl_Prestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuReg_Prestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Grdctrl_Prestaciones)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(852, 265)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Grdctrl_Prestaciones
        '
        Me.Grdctrl_Prestaciones.Location = New System.Drawing.Point(11, 10)
        Me.Grdctrl_Prestaciones.MainView = Me.BandedGridView1
        Me.Grdctrl_Prestaciones.Name = "Grdctrl_Prestaciones"
        Me.Grdctrl_Prestaciones.Size = New System.Drawing.Size(830, 245)
        Me.Grdctrl_Prestaciones.TabIndex = 4
        Me.Grdctrl_Prestaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.gId, Me.gAño, Me.gInssLab, Me.gnInssPat, Me.gInatec, Me.gVacaciones, Me.gAguinaldo, Me.gIndemnizacion, Me.gInicia, Me.gFin})
        Me.BandedGridView1.GridControl = Me.Grdctrl_Prestaciones
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Period of validity"
        Me.GridBand1.Columns.Add(Me.gId)
        Me.GridBand1.Columns.Add(Me.gAño)
        Me.GridBand1.Columns.Add(Me.gInicia)
        Me.GridBand1.Columns.Add(Me.gFin)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 287
        '
        'gId
        '
        Me.gId.Caption = "Id"
        Me.gId.FieldName = "nIdReg"
        Me.gId.Name = "gId"
        Me.gId.Visible = True
        Me.gId.Width = 39
        '
        'gAño
        '
        Me.gAño.Caption = "Year"
        Me.gAño.FieldName = "nCodAño"
        Me.gAño.Name = "gAño"
        Me.gAño.Visible = True
        Me.gAño.Width = 82
        '
        'gInicia
        '
        Me.gInicia.Caption = "Start"
        Me.gInicia.FieldName = "fFechaInicia"
        Me.gInicia.Name = "gInicia"
        Me.gInicia.Visible = True
        Me.gInicia.Width = 82
        '
        'gFin
        '
        Me.gFin.Caption = "End"
        Me.gFin.FieldName = "fFechaFinaliza"
        Me.gFin.Name = "gFin"
        Me.gFin.Visible = True
        Me.gFin.Width = 84
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Deductions"
        Me.gridBand2.Columns.Add(Me.gInssLab)
        Me.gridBand2.Columns.Add(Me.gnInssPat)
        Me.gridBand2.Columns.Add(Me.gInatec)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 255
        '
        'gInssLab
        '
        Me.gInssLab.Caption = "Laboral"
        Me.gInssLab.FieldName = "nInssLab"
        Me.gInssLab.Name = "gInssLab"
        Me.gInssLab.Visible = True
        Me.gInssLab.Width = 83
        '
        'gnInssPat
        '
        Me.gnInssPat.Caption = "Patronal"
        Me.gnInssPat.FieldName = "nInssPat"
        Me.gnInssPat.Name = "gnInssPat"
        Me.gnInssPat.Visible = True
        Me.gnInssPat.Width = 83
        '
        'gInatec
        '
        Me.gInatec.Caption = "Inatec"
        Me.gInatec.FieldName = "nInatec"
        Me.gInatec.Name = "gInatec"
        Me.gInatec.Visible = True
        Me.gInatec.Width = 89
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Benefits"
        Me.gridBand3.Columns.Add(Me.gVacaciones)
        Me.gridBand3.Columns.Add(Me.gAguinaldo)
        Me.gridBand3.Columns.Add(Me.gIndemnizacion)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 259
        '
        'gVacaciones
        '
        Me.gVacaciones.Caption = "Holidays"
        Me.gVacaciones.FieldName = "nVacaciones"
        Me.gVacaciones.Name = "gVacaciones"
        Me.gVacaciones.Visible = True
        Me.gVacaciones.Width = 85
        '
        'gAguinaldo
        '
        Me.gAguinaldo.Caption = "Bonus"
        Me.gAguinaldo.FieldName = "nTreceavo"
        Me.gAguinaldo.Name = "gAguinaldo"
        Me.gAguinaldo.Visible = True
        Me.gAguinaldo.Width = 85
        '
        'gIndemnizacion
        '
        Me.gIndemnizacion.Caption = "Compensation"
        Me.gIndemnizacion.FieldName = "nIndemnizacion"
        Me.gIndemnizacion.Name = "gIndemnizacion"
        Me.gIndemnizacion.Visible = True
        Me.gIndemnizacion.Width = 89
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(852, 265)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Grdctrl_Prestaciones
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(834, 249)
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Cmd_InsertUpdatePrestaciones, Me.CmdEditar, Me.CmdEditRegPrestaciones, Me.CmdEliminaRegPrestaciones})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Cmd_InsertUpdatePrestaciones)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'Cmd_InsertUpdatePrestaciones
        '
        Me.Cmd_InsertUpdatePrestaciones.Caption = "New"
        Me.Cmd_InsertUpdatePrestaciones.Id = 0
        Me.Cmd_InsertUpdatePrestaciones.ImageOptions.SvgImage = CType(resources.GetObject("Cmd_InsertUpdatePrestaciones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Cmd_InsertUpdatePrestaciones.Name = "Cmd_InsertUpdatePrestaciones"
        Me.Cmd_InsertUpdatePrestaciones.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(852, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 293)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(852, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 265)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(852, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 265)
        '
        'CmdEditar
        '
        Me.CmdEditar.Caption = "Edit"
        Me.CmdEditar.Id = 1
        Me.CmdEditar.ImageOptions.SvgImage = CType(resources.GetObject("CmdEditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdEditar.Name = "CmdEditar"
        Me.CmdEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'CmdEditRegPrestaciones
        '
        Me.CmdEditRegPrestaciones.Caption = "Edit"
        Me.CmdEditRegPrestaciones.Id = 2
        Me.CmdEditRegPrestaciones.ImageOptions.SvgImage = CType(resources.GetObject("CmdEditRegPrestaciones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdEditRegPrestaciones.Name = "CmdEditRegPrestaciones"
        Me.CmdEditRegPrestaciones.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'CmdEliminaRegPrestaciones
        '
        Me.CmdEliminaRegPrestaciones.Caption = "Delete Selection"
        Me.CmdEliminaRegPrestaciones.Id = 3
        Me.CmdEliminaRegPrestaciones.ImageOptions.SvgImage = CType(resources.GetObject("CmdEliminaRegPrestaciones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdEliminaRegPrestaciones.Name = "CmdEliminaRegPrestaciones"
        Me.CmdEliminaRegPrestaciones.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'MenuReg_Prestaciones
        '
        Me.MenuReg_Prestaciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CmdEditRegPrestaciones), New DevExpress.XtraBars.LinkPersistInfo(Me.CmdEliminaRegPrestaciones)})
        Me.MenuReg_Prestaciones.Manager = Me.BarManager1
        Me.MenuReg_Prestaciones.Name = "MenuReg_Prestaciones"
        '
        'Frm_PrestacionesLey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 293)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_PrestacionesLey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Percentage of benefits of law"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Grdctrl_Prestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuReg_Prestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Grdctrl_Prestaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Cmd_InsertUpdatePrestaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gAño As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gInicia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gFin As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gInssLab As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gnInssPat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gInatec As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gVacaciones As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gAguinaldo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gIndemnizacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CmdEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CmdEditRegPrestaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CmdEliminaRegPrestaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuReg_Prestaciones As DevExpress.XtraBars.PopupMenu
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class

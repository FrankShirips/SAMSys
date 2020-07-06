<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TipoMoneda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TipoMoneda))
        Me.Cbo_TodosLosTiposMoneda = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TodasLasMonedasGrdVw = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.c_Pais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.c_Moneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.c_CodigoISO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrdCtrl_TipoMoneda = New DevExpress.XtraGrid.GridControl()
        Me.GrdVw_TipoMoneda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cCodigoISO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmdAgregaMoneda = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmdEliminarTipoMoneda = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.Cbo_TodosLosTiposMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodasLasMonedasGrdVw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCtrl_TipoMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVw_TipoMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbo_TodosLosTiposMoneda
        '
        Me.Cbo_TodosLosTiposMoneda.Location = New System.Drawing.Point(12, 19)
        Me.Cbo_TodosLosTiposMoneda.Name = "Cbo_TodosLosTiposMoneda"
        Me.Cbo_TodosLosTiposMoneda.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.Cbo_TodosLosTiposMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cbo_TodosLosTiposMoneda.Properties.NullText = ""
        Me.Cbo_TodosLosTiposMoneda.Properties.PopupView = Me.TodasLasMonedasGrdVw
        Me.Cbo_TodosLosTiposMoneda.Size = New System.Drawing.Size(475, 20)
        Me.Cbo_TodosLosTiposMoneda.TabIndex = 0
        '
        'TodasLasMonedasGrdVw
        '
        Me.TodasLasMonedasGrdVw.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.c_Pais, Me.c_Moneda, Me.c_CodigoISO})
        Me.TodasLasMonedasGrdVw.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.TodasLasMonedasGrdVw.Name = "TodasLasMonedasGrdVw"
        Me.TodasLasMonedasGrdVw.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.TodasLasMonedasGrdVw.OptionsView.ShowGroupPanel = False
        '
        'c_Pais
        '
        Me.c_Pais.Caption = "Pais"
        Me.c_Pais.FieldName = "cPais"
        Me.c_Pais.Name = "c_Pais"
        Me.c_Pais.Visible = True
        Me.c_Pais.VisibleIndex = 0
        '
        'c_Moneda
        '
        Me.c_Moneda.Caption = "Moneda"
        Me.c_Moneda.FieldName = "cMoneda"
        Me.c_Moneda.Name = "c_Moneda"
        Me.c_Moneda.Visible = True
        Me.c_Moneda.VisibleIndex = 1
        '
        'c_CodigoISO
        '
        Me.c_CodigoISO.Caption = "Codigo ISO"
        Me.c_CodigoISO.FieldName = "cCodigoISO"
        Me.c_CodigoISO.Name = "c_CodigoISO"
        Me.c_CodigoISO.Visible = True
        Me.c_CodigoISO.VisibleIndex = 2
        '
        'GrdCtrl_TipoMoneda
        '
        Me.GrdCtrl_TipoMoneda.Location = New System.Drawing.Point(12, 85)
        Me.GrdCtrl_TipoMoneda.MainView = Me.GrdVw_TipoMoneda
        Me.GrdCtrl_TipoMoneda.Name = "GrdCtrl_TipoMoneda"
        Me.GrdCtrl_TipoMoneda.Size = New System.Drawing.Size(475, 177)
        Me.GrdCtrl_TipoMoneda.TabIndex = 1
        Me.GrdCtrl_TipoMoneda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVw_TipoMoneda})
        '
        'GrdVw_TipoMoneda
        '
        Me.GrdVw_TipoMoneda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nId, Me.cPais, Me.cMoneda, Me.cCodigoISO})
        Me.GrdVw_TipoMoneda.GridControl = Me.GrdCtrl_TipoMoneda
        Me.GrdVw_TipoMoneda.Name = "GrdVw_TipoMoneda"
        Me.GrdVw_TipoMoneda.OptionsBehavior.Editable = False
        Me.GrdVw_TipoMoneda.OptionsView.ShowGroupPanel = False
        '
        'nId
        '
        Me.nId.Caption = "Id"
        Me.nId.FieldName = "nCodigo"
        Me.nId.Name = "nId"
        Me.nId.Width = 41
        '
        'cPais
        '
        Me.cPais.Caption = "Country"
        Me.cPais.FieldName = "cPais"
        Me.cPais.Name = "cPais"
        Me.cPais.Visible = True
        Me.cPais.VisibleIndex = 0
        Me.cPais.Width = 164
        '
        'cMoneda
        '
        Me.cMoneda.Caption = "Currency"
        Me.cMoneda.FieldName = "cDescripcion"
        Me.cMoneda.Name = "cMoneda"
        Me.cMoneda.Visible = True
        Me.cMoneda.VisibleIndex = 1
        Me.cMoneda.Width = 178
        '
        'cCodigoISO
        '
        Me.cCodigoISO.Caption = "ISO Code"
        Me.cCodigoISO.FieldName = "cCodigoISO"
        Me.cCodigoISO.Name = "cCodigoISO"
        Me.cCodigoISO.Visible = True
        Me.cCodigoISO.VisibleIndex = 2
        Me.cCodigoISO.Width = 71
        '
        'CmdAgregaMoneda
        '
        Me.CmdAgregaMoneda.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.CmdAgregaMoneda.Appearance.ForeColor = System.Drawing.Color.White
        Me.CmdAgregaMoneda.Appearance.Options.UseBackColor = True
        Me.CmdAgregaMoneda.Appearance.Options.UseForeColor = True
        Me.CmdAgregaMoneda.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmdAgregaMoneda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.CmdAgregaMoneda.ImageOptions.SvgImage = CType(resources.GetObject("CmdAgregaMoneda.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdAgregaMoneda.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.CmdAgregaMoneda.Location = New System.Drawing.Point(387, 45)
        Me.CmdAgregaMoneda.Name = "CmdAgregaMoneda"
        Me.CmdAgregaMoneda.Size = New System.Drawing.Size(100, 34)
        Me.CmdAgregaMoneda.TabIndex = 2
        Me.CmdAgregaMoneda.Text = "Add New"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Select a currency"
        '
        'CmdEliminarTipoMoneda
        '
        Me.CmdEliminarTipoMoneda.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.CmdEliminarTipoMoneda.Appearance.ForeColor = System.Drawing.Color.White
        Me.CmdEliminarTipoMoneda.Appearance.Options.UseBackColor = True
        Me.CmdEliminarTipoMoneda.Appearance.Options.UseForeColor = True
        Me.CmdEliminarTipoMoneda.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmdEliminarTipoMoneda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.CmdEliminarTipoMoneda.ImageOptions.SvgImage = CType(resources.GetObject("CmdEliminarTipoMoneda.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdEliminarTipoMoneda.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.CmdEliminarTipoMoneda.Location = New System.Drawing.Point(387, 268)
        Me.CmdEliminarTipoMoneda.Name = "CmdEliminarTipoMoneda"
        Me.CmdEliminarTipoMoneda.Size = New System.Drawing.Size(100, 34)
        Me.CmdEliminarTipoMoneda.TabIndex = 4
        Me.CmdEliminarTipoMoneda.Text = "Delete "
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "List of active currencies"
        '
        'Frm_TipoMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 314)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CmdEliminarTipoMoneda)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmdAgregaMoneda)
        Me.Controls.Add(Me.GrdCtrl_TipoMoneda)
        Me.Controls.Add(Me.Cbo_TodosLosTiposMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_TipoMoneda"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Currency Types"
        CType(Me.Cbo_TodosLosTiposMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodasLasMonedasGrdVw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCtrl_TipoMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVw_TipoMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo_TodosLosTiposMoneda As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents TodasLasMonedasGrdVw As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrdCtrl_TipoMoneda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVw_TipoMoneda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cCodigoISO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmdAgregaMoneda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents c_Pais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents c_Moneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents c_CodigoISO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmdEliminarTipoMoneda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class

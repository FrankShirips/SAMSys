<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PeriodosDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PeriodosDePago))
        Me.txtDescFrecuencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtAbreviatura = New DevExpress.XtraEditors.TextEdit()
        Me.GrdCtrl_PeriodoPago = New DevExpress.XtraGrid.GridControl()
        Me.GrdVw_PeriodoPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbreviatura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CmdEliminarFrec = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdAgregarFrec = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDescFrecuencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCtrl_PeriodoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVw_PeriodoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescFrecuencia
        '
        Me.txtDescFrecuencia.Location = New System.Drawing.Point(12, 28)
        Me.txtDescFrecuencia.Name = "txtDescFrecuencia"
        Me.txtDescFrecuencia.Size = New System.Drawing.Size(272, 20)
        Me.txtDescFrecuencia.TabIndex = 0
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(290, 28)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(88, 20)
        Me.txtAbreviatura.TabIndex = 2
        '
        'GrdCtrl_PeriodoPago
        '
        Me.GrdCtrl_PeriodoPago.Location = New System.Drawing.Point(12, 96)
        Me.GrdCtrl_PeriodoPago.MainView = Me.GrdVw_PeriodoPagos
        Me.GrdCtrl_PeriodoPago.Name = "GrdCtrl_PeriodoPago"
        Me.GrdCtrl_PeriodoPago.Size = New System.Drawing.Size(366, 192)
        Me.GrdCtrl_PeriodoPago.TabIndex = 3
        Me.GrdCtrl_PeriodoPago.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVw_PeriodoPagos})
        '
        'GrdVw_PeriodoPagos
        '
        Me.GrdVw_PeriodoPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCode, Me.gcDescripcion, Me.gcAbreviatura})
        Me.GrdVw_PeriodoPagos.GridControl = Me.GrdCtrl_PeriodoPago
        Me.GrdVw_PeriodoPagos.Name = "GrdVw_PeriodoPagos"
        Me.GrdVw_PeriodoPagos.OptionsBehavior.Editable = False
        Me.GrdVw_PeriodoPagos.OptionsView.ShowGroupPanel = False
        '
        'gcCode
        '
        Me.gcCode.Caption = "Code"
        Me.gcCode.FieldName = "cCodigo"
        Me.gcCode.Name = "gcCode"
        Me.gcCode.Visible = True
        Me.gcCode.VisibleIndex = 0
        Me.gcCode.Width = 61
        '
        'gcDescripcion
        '
        Me.gcDescripcion.Caption = "Description"
        Me.gcDescripcion.FieldName = "cDescripcion"
        Me.gcDescripcion.Name = "gcDescripcion"
        Me.gcDescripcion.Visible = True
        Me.gcDescripcion.VisibleIndex = 1
        Me.gcDescripcion.Width = 235
        '
        'gcAbreviatura
        '
        Me.gcAbreviatura.Caption = "Abbreviation"
        Me.gcAbreviatura.FieldName = "cAbreviatura"
        Me.gcAbreviatura.Name = "gcAbreviatura"
        Me.gcAbreviatura.Visible = True
        Me.gcAbreviatura.VisibleIndex = 2
        Me.gcAbreviatura.Width = 80
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(293, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Abbreviation"
        '
        'CmdEliminarFrec
        '
        Me.CmdEliminarFrec.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.CmdEliminarFrec.Appearance.ForeColor = System.Drawing.Color.White
        Me.CmdEliminarFrec.Appearance.Options.UseBackColor = True
        Me.CmdEliminarFrec.Appearance.Options.UseForeColor = True
        Me.CmdEliminarFrec.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmdEliminarFrec.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.CmdEliminarFrec.ImageOptions.SvgImage = CType(resources.GetObject("CmdEliminarFrec.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdEliminarFrec.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.CmdEliminarFrec.Location = New System.Drawing.Point(290, 294)
        Me.CmdEliminarFrec.Name = "CmdEliminarFrec"
        Me.CmdEliminarFrec.Size = New System.Drawing.Size(88, 34)
        Me.CmdEliminarFrec.TabIndex = 9
        Me.CmdEliminarFrec.Text = "Delete "
        '
        'CmdAgregarFrec
        '
        Me.CmdAgregarFrec.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.CmdAgregarFrec.Appearance.ForeColor = System.Drawing.Color.White
        Me.CmdAgregarFrec.Appearance.Options.UseBackColor = True
        Me.CmdAgregarFrec.Appearance.Options.UseForeColor = True
        Me.CmdAgregarFrec.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmdAgregarFrec.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.CmdAgregarFrec.ImageOptions.SvgImage = CType(resources.GetObject("CmdAgregarFrec.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdAgregarFrec.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.CmdAgregarFrec.Location = New System.Drawing.Point(290, 56)
        Me.CmdAgregarFrec.Name = "CmdAgregarFrec"
        Me.CmdAgregarFrec.Size = New System.Drawing.Size(88, 34)
        Me.CmdAgregarFrec.TabIndex = 8
        Me.CmdAgregarFrec.Text = "Add New"
        '
        'Frm_PeriodosDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 339)
        Me.Controls.Add(Me.CmdEliminarFrec)
        Me.Controls.Add(Me.CmdAgregarFrec)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtDescFrecuencia)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.GrdCtrl_PeriodoPago)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_PeriodosDePago"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Payment Frecuency"
        CType(Me.txtDescFrecuencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCtrl_PeriodoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVw_PeriodoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdCtrl_PeriodoPago As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVw_PeriodoPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbreviatura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAbreviatura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescFrecuencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmdEliminarFrec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdAgregarFrec As DevExpress.XtraEditors.SimpleButton
End Class

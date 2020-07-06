Partial Public Class FrmLogin
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txt_Log_Usuario = New DevExpress.XtraEditors.TextEdit()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Log_Contraseña = New DevExpress.XtraEditors.TextEdit()
        Me.Chck_Log_VerContraseña = New DevExpress.XtraEditors.CheckEdit()
        Me.RdBt_Log_SeleccionIdioma = New DevExpress.XtraEditors.RadioGroup()
        Me.Chck_Log_RecordarSeleccion = New DevExpress.XtraEditors.CheckEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CmdIngresarLogin = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Log_Usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Log_Contraseña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chck_Log_VerContraseña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RdBt_Log_SeleccionIdioma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chck_Log_RecordarSeleccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Log_Usuario
        '
        Me.txt_Log_Usuario.Location = New System.Drawing.Point(38, 212)
        Me.txt_Log_Usuario.Name = "txt_Log_Usuario"
        Me.txt_Log_Usuario.Properties.Appearance.Image = CType(resources.GetObject("txt_Log_Usuario.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txt_Log_Usuario.Properties.Appearance.Options.UseImage = True
        Me.txt_Log_Usuario.Properties.AutoHeight = False
        Me.txt_Log_Usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.txt_Log_Usuario.Properties.ContextImageOptions.Image = CType(resources.GetObject("txt_Log_Usuario.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txt_Log_Usuario.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.txt_Log_Usuario.Size = New System.Drawing.Size(271, 30)
        Me.txt_Log_Usuario.TabIndex = 0
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LbUsuario.Location = New System.Drawing.Point(36, 195)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(31, 14)
        Me.LbUsuario.TabIndex = 2
        Me.LbUsuario.Text = "User"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(96, 61)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(139, 129)
        Me.PictureEdit1.TabIndex = 12
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(36, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Password"
        '
        'txt_Log_Contraseña
        '
        Me.txt_Log_Contraseña.Location = New System.Drawing.Point(38, 271)
        Me.txt_Log_Contraseña.Name = "txt_Log_Contraseña"
        Me.txt_Log_Contraseña.Properties.Appearance.Image = CType(resources.GetObject("txt_Log_Contraseña.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txt_Log_Contraseña.Properties.Appearance.Options.UseImage = True
        Me.txt_Log_Contraseña.Properties.AutoHeight = False
        Me.txt_Log_Contraseña.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.txt_Log_Contraseña.Properties.ContextImageOptions.Image = CType(resources.GetObject("txt_Log_Contraseña.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txt_Log_Contraseña.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.txt_Log_Contraseña.Size = New System.Drawing.Size(271, 30)
        Me.txt_Log_Contraseña.TabIndex = 13
        '
        'Chck_Log_VerContraseña
        '
        Me.Chck_Log_VerContraseña.Location = New System.Drawing.Point(177, 307)
        Me.Chck_Log_VerContraseña.Name = "Chck_Log_VerContraseña"
        Me.Chck_Log_VerContraseña.Properties.AllowFocused = False
        Me.Chck_Log_VerContraseña.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Chck_Log_VerContraseña.Properties.Appearance.Options.UseForeColor = True
        Me.Chck_Log_VerContraseña.Properties.Caption = "Show password"
        Me.Chck_Log_VerContraseña.Size = New System.Drawing.Size(132, 20)
        Me.Chck_Log_VerContraseña.TabIndex = 15
        '
        'RdBt_Log_SeleccionIdioma
        '
        Me.RdBt_Log_SeleccionIdioma.Location = New System.Drawing.Point(37, 320)
        Me.RdBt_Log_SeleccionIdioma.Name = "RdBt_Log_SeleccionIdioma"
        Me.RdBt_Log_SeleccionIdioma.Properties.AllowFocused = False
        Me.RdBt_Log_SeleccionIdioma.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RdBt_Log_SeleccionIdioma.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.RdBt_Log_SeleccionIdioma.Properties.Appearance.Options.UseBackColor = True
        Me.RdBt_Log_SeleccionIdioma.Properties.Appearance.Options.UseForeColor = True
        Me.RdBt_Log_SeleccionIdioma.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RdBt_Log_SeleccionIdioma.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Español"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "English")})
        Me.RdBt_Log_SeleccionIdioma.Size = New System.Drawing.Size(142, 67)
        Me.RdBt_Log_SeleccionIdioma.TabIndex = 16
        '
        'Chck_Log_RecordarSeleccion
        '
        Me.Chck_Log_RecordarSeleccion.Location = New System.Drawing.Point(37, 393)
        Me.Chck_Log_RecordarSeleccion.Name = "Chck_Log_RecordarSeleccion"
        Me.Chck_Log_RecordarSeleccion.Properties.AllowFocused = False
        Me.Chck_Log_RecordarSeleccion.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Chck_Log_RecordarSeleccion.Properties.Appearance.Options.UseForeColor = True
        Me.Chck_Log_RecordarSeleccion.Properties.Caption = "Remember my language selection"
        Me.Chck_Log_RecordarSeleccion.Size = New System.Drawing.Size(256, 20)
        Me.Chck_Log_RecordarSeleccion.TabIndex = 17
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(346, 598)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 39
        Me.LineShape1.X2 = 292
        Me.LineShape1.Y1 = 387
        Me.LineShape1.Y2 = 387
        '
        'CmdIngresarLogin
        '
        Me.CmdIngresarLogin.AllowFocus = False
        Me.CmdIngresarLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.CmdIngresarLogin.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.CmdIngresarLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CmdIngresarLogin.Appearance.ForeColor = System.Drawing.Color.White
        Me.CmdIngresarLogin.Appearance.Options.UseBackColor = True
        Me.CmdIngresarLogin.Appearance.Options.UseBorderColor = True
        Me.CmdIngresarLogin.Appearance.Options.UseFont = True
        Me.CmdIngresarLogin.Appearance.Options.UseForeColor = True
        Me.CmdIngresarLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.CmdIngresarLogin.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmdIngresarLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.CmdIngresarLogin.ImageOptions.SvgImage = CType(resources.GetObject("CmdIngresarLogin.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CmdIngresarLogin.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.CmdIngresarLogin.Location = New System.Drawing.Point(37, 432)
        Me.CmdIngresarLogin.Name = "CmdIngresarLogin"
        Me.CmdIngresarLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.CmdIngresarLogin.Size = New System.Drawing.Size(272, 44)
        Me.CmdIngresarLogin.TabIndex = 19
        Me.CmdIngresarLogin.Text = "Follow"
        '
        'FrmLogin
        '
        Me.ClientSize = New System.Drawing.Size(346, 598)
        Me.Controls.Add(Me.CmdIngresarLogin)
        Me.Controls.Add(Me.Chck_Log_RecordarSeleccion)
        Me.Controls.Add(Me.RdBt_Log_SeleccionIdioma)
        Me.Controls.Add(Me.Chck_Log_VerContraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Log_Contraseña)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.LbUsuario)
        Me.Controls.Add(Me.txt_Log_Usuario)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.txt_Log_Usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Log_Contraseña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chck_Log_VerContraseña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RdBt_Log_SeleccionIdioma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chck_Log_RecordarSeleccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Log_Usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LbUsuario As System.Windows.Forms.Label
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Log_Contraseña As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Chck_Log_VerContraseña As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RdBt_Log_SeleccionIdioma As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Chck_Log_RecordarSeleccion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CmdIngresarLogin As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape

#End Region

End Class

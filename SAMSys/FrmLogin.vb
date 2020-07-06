Imports SAM_Entidades
Imports SAM_LogicaNegocio
Imports System.ComponentModel
Imports System.Text


Public Class FrmLogin
    Inherits DevExpress.XtraEditors.XtraForm
    Dim VerConn As New GetConn
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CmdIngresarLogin_Click(sender As Object, e As EventArgs) Handles CmdIngresarLogin.Click
        If Not VerConn.VerifyConnection Then
            MsgBox("No se pudo establecer coneccion con el servidor, porfavor verifique que esté en linea")
            Exit Sub
        Else
            FrmPrincipal.Show()
        End If
    End Sub


End Class

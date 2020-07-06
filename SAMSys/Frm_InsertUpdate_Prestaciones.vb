Imports SAM_Entidades
Imports SAM_LogicaNegocio

Public Class Frm_InsertUpdate_Prestaciones
    Dim Resultados As New LN_Prestaciones
    Dim ECampos As New EN_PrestacionesLey


    Private Sub Frm_InsertUpdate_Prestaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtAño.Focus()
    End Sub
#Region "Navegacion en los controles"
    Private Sub txtAño_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAño.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtFechaInicial.Focus()
        End If
    End Sub
    Private Sub txtFechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtFechaFinal.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtAño.Focus()
        End If
    End Sub
    Private Sub txtFechaFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtInssLab.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtFechaInicial.Focus()
        End If
    End Sub
    Private Sub txtInssLab_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInssLab.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtInssPat.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtFechaFinal.Focus()
        End If
    End Sub
    Private Sub txtInssPat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInssPat.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtInatec.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtInssLab.Focus()
        End If
    End Sub
    Private Sub txtInatec_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInatec.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtVac.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtInssPat.Focus()
        End If
    End Sub
    Private Sub txtVac_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVac.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtAguinaldo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtInatec.Focus()
        End If
    End Sub
    Private Sub txtAguinaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAguinaldo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.txtIndenmizacion.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtVac.Focus()
        End If
    End Sub
    Private Sub txtIndenmizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIndenmizacion.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.CmdAceptar_Prestaciones.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            Me.txtAguinaldo.Focus()
        End If
    End Sub

#End Region

#Region "Administracion de Datos"
    Private Sub CmdAceptar_Prestaciones_Click(sender As Object, e As EventArgs) Handles CmdAceptar_Prestaciones.Click
        ECampos.gnCodAño = CInt(Me.txtAño.Text)
        ECampos.gnInssLab = CDec(Me.txtInssLab.Text)
        ECampos.gnInssPat = CDec(Me.txtInssPat.Text)
        ECampos.gnInatec = CDec(Me.txtInatec.Text)
        ECampos.gnVacaciones = CDec(Me.txtVac.Text)
        ECampos.gnTreceavo = CDec(Me.txtAguinaldo.Text)
        ECampos.gnIndemnizacion = CDec(Me.txtIndenmizacion.Text)
        ECampos.gfFechaInicia = CDate(Me.txtFechaInicial.Text)
        ECampos.gfFechaFinaliza = CDate(Me.txtFechaFinal.Text)
        ECampos.gfFechaRegistro = CDate(Now())
        ECampos.gcEquipoRegistro = Environment.MachineName()
        ECampos.gUsuario = CInt(0)

        If Me.txtIdRegistro.Text = "" Then 'Si esta vacio entonces procede a ingresar el registro, sino elimina el que esta e inserta el nuevo
            If Resultados.ValidaSiExiste(ECampos) = 0 Then
                Resultados.InsertaPrestaciones(ECampos)
                LimpiaControles(Me)
                RefrescaGrid(Frm_PrestacionesLey.Grdctrl_Prestaciones, Resultados.EnListaPrestaciones)
                Me.Close()
            Else
                Mensage("There is already a record in the same year and with the same period of validity." & Chr(13) &
                        "Check and try again.", MessageBoxButtons.OK, MessageBoxIcon.Error, Me.Text)
                Exit Sub
            End If
        End If
    End Sub


#End Region
End Class

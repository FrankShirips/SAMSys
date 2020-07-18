Imports SAM_AccesoDatos
Imports SAM_Entidades

Public Class LN_IR
    ''' <summary>
    ''' Metodo que obtiene la informacion de IR
    ''' </summary>
    ''' <returns></returns>
    Function ListarIR() As DataTable
        Dim IR As New AD_IR()
        Return IR.ObtenerIR()
    End Function

    ''' <summary>
    ''' Actualiza la tabla IR
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function ActualizarIR(ByVal Campos As EN_IR) As Boolean
        Dim Actualizar As New AD_IR

        Return Actualizar.InsertarOActualizarIR(Campos, "A")
    End Function

    ''' <summary>
    ''' Insertar Nuevo Registro de IR
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function InsertarIR(ByVal Campos As EN_IR) As Boolean
        Dim Insertar As New AD_IR
        Return Insertar.InsertarOActualizarIR(Campos, "I")
    End Function

    ''' <summary>
    ''' Borrar un registro de IR
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function BorrarIR(ByVal Campos As EN_IR) As Boolean
        Dim Borrar As New AD_IR
        Return Borrar.BorrarIR(Campos)
    End Function
End Class

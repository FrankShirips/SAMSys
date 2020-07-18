Imports SAM_Entidades
Imports SAM_AccesoDatos

Public Class LN_DeduccionEPP
    ''' <summary>
    ''' Lista Todas las Deducciones por EPP de los Empleados.
    ''' </summary>
    ''' <returns></returns>
    Function ListarDeduccionesEPP(ByVal campos As EN_DeduccionEPP) As DataTable
        Dim listDeduccEPP As New AD_DeduccionEPP
        Return listDeduccEPP.ObtenerDeducionesEPP(campos, "T")
    End Function

    Function ListarDeduccionesEPPPorId(ByVal campos As EN_DeduccionEPP) As DataTable
        Dim ListById As New AD_DeduccionEPP
        Return ListById.ObtenerDeducionesEPP(campos, "U")
    End Function

    ''' <summary>
    ''' Inserta las deducciones que van presentando los Empleados.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function InsertDeducionesEPP(ByVal campos As EN_DeduccionEPP) As Boolean
        Dim Insertar As New AD_DeduccionEPP()
        Return Insertar.InsertarActualizarDeducionesEPP(campos, "I")
    End Function

    ''' <summary>
    ''' Actualiza las deducciones que van presentando los Empleados.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function ActualizarDeduccionesEPP(ByVal campos As EN_DeduccionEPP) As Boolean
        Dim Actualizar As New AD_DeduccionEPP
        Return Actualizar.InsertarActualizarDeducionesEPP(campos, "A")
    End Function

    ''' <summary>
    ''' Borra un registro de deducciones de EPP.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function BorrarDeducionesEPP(ByVal campos As EN_DeduccionEPP) As Boolean
        Dim Borrar As New AD_DeduccionEPP()

        Return Borrar.BorrarDeduccionesEPP(campos)
    End Function
End Class

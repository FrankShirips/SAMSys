Imports SAM_Entidades
Imports SAM_AccesoDatos

Public Class LN_DeduccionClinica
    ''' <summary>
    ''' Lista Todas las Deducciones por Clinica de los Empleados.
    ''' </summary>
    ''' <returns></returns>
    Function ListarDeduccionesClinica(ByVal campos As EN_DeduccionClinica) As DataTable
        Dim listDeduccClin As New AD_DeduccionClinica
        Return listDeduccClin.ObtenerDeducionesClinica(campos, "T")
    End Function

    Function ListarDeduccionesClinicaPorId(ByVal campos As EN_DeduccionClinica) As DataTable
        Dim ListById As New AD_DeduccionClinica
        Return ListById.ObtenerDeducionesClinica(campos, "U")
    End Function

    ''' <summary>
    ''' Inserta las deducciones que van presentando los Empleados.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function InsertDeducionesClinica(ByVal campos As EN_DeduccionClinica) As Boolean
        Dim Insertar As New AD_DeduccionClinica()
        Return Insertar.InsertarActualizarDeducionesClinica(campos, "I")
    End Function

    ''' <summary>
    ''' Actualiza las deducciones que van presentando los Empleados.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function ActualizarDeduccionesClinica(ByVal campos As EN_DeduccionClinica) As Boolean
        Dim Actualizar As New AD_DeduccionClinica
        Return Actualizar.InsertarActualizarDeducionesClinica(campos, "A")
    End Function

    ''' <summary>
    ''' Borra un registro de deducciones de clinica.
    ''' </summary>
    ''' <param name="campos"></param>
    ''' <returns></returns>
    Function BorrarDeducionesClinica(ByVal campos As EN_DeduccionClinica) As Boolean
        Dim Borrar As New AD_DeduccionClinica()

        Return Borrar.BorrarDeduccionesClinica(campos)
    End Function
End Class

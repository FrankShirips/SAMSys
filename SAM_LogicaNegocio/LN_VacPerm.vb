Imports SAM_AccesoDatos
Imports SAM_Entidades

Public Class LN_VacPerm
    ''' <summary>
    ''' Lista todos los registros de Vaciones o Permisos.
    ''' </summary>
    ''' <returns></returns>
    Function ListarVacPerm() As DataTable
        Dim Listar As New AD_VacPerm
        Return Listar.ObtenerVacPerm
    End Function

    ''' <summary>
    ''' Actualiza la tabla Vacaciones Permisos
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function ActualizarVacPerm(ByVal Campos As EN_VacPerm) As Boolean
        Dim Actualizar As New AD_VacPerm

        Return Actualizar.InsertarOActualizarVacPerm(Campos, "A")
    End Function

    ''' <summary>
    ''' Insertar Nuevo Registro de Vacaciones o Permisos
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function InsertarVacPerm(ByVal Campos As EN_VacPerm) As Boolean
        Dim Insertar As New AD_VacPerm
        Return Insertar.InsertarOActualizarVacPerm(Campos, "I")
    End Function

    ''' <summary>
    ''' Borrar un registro de Vacaciones o Permisos
    ''' </summary>
    ''' <param name="Campos"></param>
    ''' <returns></returns>
    Function BorrarVacPerm(ByVal Campos As EN_VacPerm) As Boolean
        Dim Borrar As New AD_VacPerm
        Return Borrar.BorrarVacPerm(Campos)
    End Function

    Function ListarConceptos() As DataTable
        Dim listar As New AD_VacPerm
        Return listar.ObtenerConceptosOTiposDuracion("C")
    End Function

    Function ListarTipoDuracion() As DataTable
        Dim listar As New AD_VacPerm
        Return listar.ObtenerConceptosOTiposDuracion("T")
    End Function

    Function ObtenerIdConceptoTipo(ByVal conceptoTipo As EN_ConceptoDuracion) As DataTable
        Dim obtener As New AD_VacPerm
        Return obtener.ObtenerConceptosOTiposDuracionByDescripcion(Nothing, conceptoTipo, "C")
    End Function

    Function ObtenerIdTipoDuracion(ByVal tipoDuracion As EN_TipoDuracion) As DataTable
        Dim obtener As New AD_VacPerm
        Return obtener.ObtenerConceptosOTiposDuracionByDescripcion(tipoDuracion, Nothing, "T")
    End Function

    Function ObtenerDescripcionConceptoTipo(ByVal conceptoTipo As EN_ConceptoDuracion) As String
        Dim obtener As New AD_VacPerm
        Return obtener.ObtenerConceptosOTiposDuracionByID(Nothing, conceptoTipo, "C")
    End Function

    Function ObtenerDescripcionTipoDuracion(ByVal tipoDuracion As EN_TipoDuracion) As String
        Dim obtener As New AD_VacPerm
        Return obtener.ObtenerConceptosOTiposDuracionByID(tipoDuracion, Nothing, "T")
    End Function
End Class

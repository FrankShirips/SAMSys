Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class EN_Empleados
    Dim nCodEmp As Integer
    Dim cPrimerNombre As String
    Dim cSegundoNombre As String
    Dim cPrimerApellido As String
    Dim cSegundoApellido As String
    Dim cNumIdentificacion As String
    Dim fFechaNacimiento As Date
    Dim cGenero As String
    Dim cEstadoCivil As String
    Dim nNumHijos As Integer
    Dim cNumInss As String
    Dim cDireccion As String
    Dim cTelefono As String
    Dim cNombreCasoEmergencia As String
    Dim cParentezcoCasoEmergencia As String
    Dim cTelefonoCasoEmergencia As String
    Dim fFechaGraba As Date
    Dim nCodUsuarioGraba As Integer
    Dim nCodEstado As Integer

    Public Property gnCodEmp As Integer
        Get
            Return nCodEmp
        End Get
        Set(ByVal value As Integer)
            nCodEmp = value
        End Set
    End Property
    Public Property gcPrimerNombre As String
        Get
            Return cPrimerNombre
        End Get
        Set(ByVal value As String)
            cPrimerNombre = value
        End Set
    End Property
    Public Property gcSegundoNombre As String
        Get
            Return cSegundoNombre
        End Get
        Set(ByVal value As String)
            cSegundoNombre = value
        End Set
    End Property
    Public Property gcPrimerApellido As String
        Get
            Return cPrimerApellido
        End Get
        Set(ByVal value As String)
            cPrimerApellido = value
        End Set
    End Property
    Public Property gcSegundoApellido As String
        Get
            Return cSegundoApellido
        End Get
        Set(ByVal value As String)
            cSegundoApellido = value
        End Set
    End Property
    Public Property gcNumIdentificacion As String
        Get
            Return cNumIdentificacion
        End Get
        Set(ByVal value As String)
            cNumIdentificacion = value
        End Set
    End Property
    Public Property gfFechaNacimiento As Date
        Get
            Return fFechaNacimiento
        End Get
        Set(ByVal value As Date)
            fFechaNacimiento = value
        End Set
    End Property
    Public Property gcGenero As String
        Get
            Return cGenero
        End Get
        Set(ByVal value As String)
            cGenero = value
        End Set
    End Property
    Public Property gcEstadoCivil As String
        Get
            Return cEstadoCivil
        End Get
        Set(ByVal value As String)
            cEstadoCivil = value
        End Set
    End Property
    Public Property gnNumHijos As Integer
        Get
            Return nNumHijos
        End Get
        Set(ByVal value As Integer)
            nNumHijos = value
        End Set
    End Property
    Public Property gcNumInss As String
        Get
            Return cNumInss
        End Get
        Set(ByVal value As String)
            cNumInss = value
        End Set
    End Property
    Public Property gcDireccion As String
        Get
            Return cDireccion
        End Get
        Set(ByVal value As String)
            cDireccion = value
        End Set
    End Property
    Public Property gcTelefono As String
        Get
            Return cTelefono
        End Get
        Set(ByVal value As String)
            cTelefono = value
        End Set
    End Property
    Public Property gcNombreCasoEmergencia As String
        Get
            Return cNombreCasoEmergencia
        End Get
        Set(ByVal value As String)
            cNombreCasoEmergencia = value
        End Set
    End Property
    Public Property gcParentezcoCasoEmergencia As String
        Get
            Return cParentezcoCasoEmergencia
        End Get
        Set(ByVal value As String)
            cParentezcoCasoEmergencia = value
        End Set
    End Property
    Public Property gcTelefonoCasoEmergencia As String
        Get
            Return cTelefonoCasoEmergencia
        End Get
        Set(ByVal value As String)
            cTelefonoCasoEmergencia = value
        End Set
    End Property
    Public Property gfFechaGraba As Date
        Get
            Return fFechaGraba
        End Get
        Set(ByVal value As Date)
            fFechaGraba = value
        End Set
    End Property
    Public Property gnCodUsuarioGraba As Integer
        Get
            Return nCodUsuarioGraba
        End Get
        Set(ByVal value As Integer)
            nCodUsuarioGraba = value
        End Set
    End Property
    Public Property gnCodEstado As Integer
        Get
            Return nCodEstado
        End Get
        Set(ByVal value As Integer)
            nCodEstado = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(ByVal nCodEmp As Integer, ByVal cPrimerNombre As String, ByVal cSegundoNombre As String, ByVal cPrimerApellido As String,
                   ByVal cSegundoApellido As String, ByVal cNumIdentificacion As String, ByVal fFechaNacimiento As Date, ByVal cGenero As String,
                   ByVal cEstadoCivil As String, ByVal nNumHijos As Integer, ByVal cNumInss As String, ByVal cDireccion As String, ByVal cTelefono As String,
                   ByVal cNombreCasoEmergencia As String, ByVal cParentezcoCasoEmergencia As String, ByVal cTelefonoCasoEmergencia As String,
                   ByVal fFechaGraba As Date, ByVal nCodUsuarioGraba As Integer, ByVal nCodEstado As Integer)
        gnCodEmp = nCodEmp
        gcPrimerNombre = cPrimerNombre
        gcSegundoNombre = cSegundoNombre
        gcPrimerApellido = cPrimerApellido
        gcSegundoApellido = cSegundoApellido
        gcNumIdentificacion = cNumIdentificacion
        gfFechaNacimiento = fFechaNacimiento
        gcGenero = cGenero
        gcEstadoCivil = cEstadoCivil
        gnNumHijos = nNumHijos
        gcNumInss = cNumInss
        gcDireccion = cDireccion
        gcTelefono = cTelefono
        gcNombreCasoEmergencia = cNombreCasoEmergencia
        gcParentezcoCasoEmergencia = cParentezcoCasoEmergencia
        gcTelefonoCasoEmergencia = cTelefonoCasoEmergencia
        gfFechaGraba = fFechaGraba
        gnCodUsuarioGraba = nCodUsuarioGraba
        gnCodEstado = nCodEstado


    End Sub

End Class

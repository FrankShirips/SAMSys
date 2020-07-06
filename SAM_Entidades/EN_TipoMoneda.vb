Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class EN_TipoMoneda
    Dim nCodigo As Integer
    Dim nCodUsuarioGraba As Integer
    Dim nCodEstado As Integer
    Dim cPais As String
    Dim cDescripcion As String
    Dim cCodigoISO As String

    Public Property gnCodigo As Integer
        Get
            Return nCodigo
        End Get
        Set(ByVal value As Integer)
            nCodigo = value
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
    Public Property gcPais As String
        Get
            Return cPais
        End Get
        Set(ByVal value As String)
            cPais = value
        End Set
    End Property
    Public Property gcDescripcion As String
        Get
            Return cDescripcion
        End Get
        Set(ByVal value As String)
            cDescripcion = value
        End Set
    End Property
    Public Property gcCodigoISO As String
        Get
            Return cCodigoISO
        End Get
        Set(ByVal value As String)
            cCodigoISO = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(ByVal nCodigo As Integer, ByVal nCodUsuarioGraba As Integer, ByVal nCodEstado As Integer, cPais As String, cDescripcion As String, cCodigoISO As String)
        gnCodigo = nCodigo
        gnCodUsuarioGraba = nCodUsuarioGraba
        gnCodEstado = nCodEstado
        gcPais = cPais
        gcDescripcion = cDescripcion
        gcCodigoISO = cCodigoISO
    End Sub
End Class

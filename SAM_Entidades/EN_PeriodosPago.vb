
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class EN_PeriodosPago
    Dim nCodigo As Integer
    Dim cDescripcion As String
    Dim cAbreviatura As String
    Dim Usuario As Integer

    Public Property gnCodPeriodo As Integer
        Get
            Return nCodigo
        End Get
        Set(ByVal value As Integer)
            nCodigo = value
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
    Public Property gcAbreviatura As String
        Get
            Return cAbreviatura
        End Get
        Set(ByVal value As String)
            cAbreviatura = value
        End Set
    End Property
    Public Property gUsuario As Integer
        Get
            Return Usuario
        End Get
        Set(ByVal value As Integer)
            Usuario = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(ByVal nCodigo As Integer, ByVal cDescripcion As String, ByVal cAbreviatura As String, ByVal Usuario As Integer)
        gnCodPeriodo = nCodigo
        gcDescripcion = cDescripcion
        gcAbreviatura = cAbreviatura
        gUsuario = Usuario
    End Sub
End Class

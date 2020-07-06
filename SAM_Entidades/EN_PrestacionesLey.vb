
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class EN_PrestacionesLey
    Dim nCodAño As Integer
    Dim nInssLab As Decimal
    Dim nInssPat As Decimal
    Dim nInatec As Decimal
    Dim nVacaciones As Decimal
    Dim nTreceavo As Decimal
    Dim nIndemnizacion As Decimal
    Dim fFechaInicia As Date
    Dim fFechaFinaliza As Date
    Dim fFechaRegistro As Date
    Dim cEquipoRegistro As String
    Dim nUsuarioRegistra As Integer

    Public Property gnCodAño As Integer
        Get
            Return nCodAño
        End Get
        Set(ByVal value As Integer)
            nCodAño = value
        End Set
    End Property
    Public Property gnInssLab As Decimal
        Get
            Return nInssLab
        End Get
        Set(ByVal value As Decimal)
            nInssLab = value
        End Set
    End Property
    Public Property gnInssPat As Decimal
        Get
            Return nInssPat
        End Get
        Set(ByVal value As Decimal)
            nInssPat = value
        End Set
    End Property
    Public Property gnInatec As Decimal
        Get
            Return nInatec
        End Get
        Set(ByVal value As Decimal)
            nInatec = value
        End Set
    End Property
    Public Property gnVacaciones As Decimal
        Get
            Return nVacaciones
        End Get
        Set(ByVal value As Decimal)
            nVacaciones = value
        End Set
    End Property
    Public Property gnTreceavo As Decimal
        Get
            Return nTreceavo
        End Get
        Set(ByVal value As Decimal)
            nTreceavo = value
        End Set
    End Property
    Public Property gnIndemnizacion As Decimal
        Get
            Return nIndemnizacion
        End Get
        Set(ByVal value As Decimal)
            nIndemnizacion = value
        End Set
    End Property
    Public Property gfFechaInicia As Date
        Get
            Return fFechaInicia
        End Get
        Set(ByVal value As Date)
            fFechaInicia = value
        End Set
    End Property
    Public Property gfFechaFinaliza As Date
        Get
            Return fFechaFinaliza
        End Get
        Set(ByVal value As Date)
            fFechaFinaliza = value
        End Set
    End Property
    Public Property gfFechaRegistro As Date
        Get
            Return fFechaRegistro
        End Get
        Set(ByVal value As Date)
            fFechaRegistro = value
        End Set
    End Property
    Public Property gcEquipoRegistro As String
        Get
            Return cEquipoRegistro
        End Get
        Set(ByVal value As String)
            cEquipoRegistro = value
        End Set
    End Property
    Public Property gUsuario As Integer
        Get
            Return nUsuarioRegistra
        End Get
        Set(ByVal value As Integer)
            nUsuarioRegistra = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(ByVal nCodAño As Integer, ByVal nInssLab As Decimal, ByVal nInssPat As Decimal, ByVal nInatec As Decimal,
                   ByVal nVacaciones As Decimal, ByVal nTreceavo As Decimal, ByVal nIndemnizacion As Decimal, ByVal fFechaInicia As Date,
                   ByVal fFechaFinaliza As Date, ByVal fFechaRegistro As Date, ByVal cEquipoRegistro As String, ByVal nUsuarioRegistra As Integer)
        gnCodAño = nCodAño
        gnInssLab = nInssLab
        gnInssPat = nInssPat
        gnInatec = nInatec
        gnVacaciones = nVacaciones
        gnTreceavo = nTreceavo
        gnIndemnizacion = nIndemnizacion
        gfFechaInicia = fFechaInicia
        gfFechaFinaliza = fFechaFinaliza
        gfFechaRegistro = fFechaRegistro
        gcEquipoRegistro = cEquipoRegistro
        gUsuario = nUsuarioRegistra

    End Sub

End Class

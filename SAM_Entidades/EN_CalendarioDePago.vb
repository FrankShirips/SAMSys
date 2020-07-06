Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class EN_CalendarioDePago
    Dim nAño As Integer
    Dim nCodMes As Integer
    Dim nCodQuincena As Integer
    Dim fFechaIncio As Date
    Dim fFechaFinal As Date
    Dim fFechaDePago As Date
    Dim fFechaGraba As Date
    Dim nUsuarioGraba As Integer
    Dim nCodPeriodoPago As Integer
    Dim nCodEstado As Integer

    Public Property gnAño As Integer
        Get
            Return nAño
        End Get
        Set(ByVal value As Integer)
            nAño = value
        End Set
    End Property
    Public Property gnCodMes As Integer
        Get
            Return nCodMes
        End Get
        Set(ByVal value As Integer)
            nCodMes = value
        End Set
    End Property
    Public Property gnCodQuincena As Integer
        Get
            Return nCodQuincena
        End Get
        Set(ByVal value As Integer)
            nCodQuincena = value
        End Set
    End Property
    Public Property gfFechaIncio As Date
        Get
            Return fFechaIncio
        End Get
        Set(ByVal value As Date)
            fFechaIncio = value
        End Set
    End Property
    Public Property gfFechaFinal As Date
        Get
            Return fFechaFinal
        End Get
        Set(ByVal value As Date)
            fFechaFinal = value
        End Set
    End Property
    Public Property gfFechaDePago As Date
        Get
            Return fFechaDePago
        End Get
        Set(ByVal value As Date)
            fFechaDePago = value
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
    Public Property gnUsuarioGraba As Integer
        Get
            Return nUsuarioGraba
        End Get
        Set(ByVal value As Integer)
            nUsuarioGraba = value
        End Set
    End Property
    Public Property gnCodEstado As Integer
        Get
            Return nCodPeriodoPago
        End Get
        Set(ByVal value As Integer)
            nCodEstado = value
        End Set
    End Property
    Public Property gnCodPeriodoPago As Integer
        Get
            Return nCodPeriodoPago
        End Get
        Set(ByVal value As Integer)
            nCodPeriodoPago = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(ByVal nAño As Integer, ByVal nCodMes As Integer, ByVal nCodQuincena As Integer, ByVal fFechaInicio As Date, ByVal fFechaFinaliza As Date,
                   ByVal fFechaDePago As Date, ByVal fFechaGraba As Date, ByVal nUsuarioGraba As Integer, ByVal nCodPeriodoPago As Integer, ByVal nCodEstado As Integer)
        gnAño = nAño
        gnCodMes = nCodMes
        gnCodQuincena = nCodQuincena
        gfFechaIncio = fFechaInicio
        gfFechaFinal = fFechaFinaliza
        gfFechaDePago = fFechaDePago
        gfFechaGraba = fFechaGraba
        gnUsuarioGraba = nUsuarioGraba
        gnCodPeriodoPago = nCodPeriodoPago
        gnCodEstado = nCodEstado

    End Sub
End Class

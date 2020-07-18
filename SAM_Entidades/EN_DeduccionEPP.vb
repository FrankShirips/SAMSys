Public Class EN_DeduccionEPP
    Dim Id As Integer
    Dim Fecha As DateTime
    Dim N_Empl As String
    Dim Proyecto As String
    Dim Nombre As String
    Dim Monto As Decimal
    Dim Concepto As String

    Public Property DId() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property

    Public Property DFecha() As DateTime
        Get
            Return Fecha
        End Get
        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property

    Public Property DN_Empl() As String
        Get
            Return N_Empl
        End Get
        Set(ByVal value As String)
            N_Empl = value
        End Set
    End Property

    Public Property DProyecto() As String
        Get
            Return Proyecto
        End Get
        Set(ByVal value As String)
            Proyecto = value
        End Set
    End Property

    Public Property DNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property DMonto() As Decimal
        Get
            Return Monto
        End Get
        Set(ByVal value As Decimal)
            Monto = value
        End Set
    End Property

    Public Property DConcepto() As String
        Get
            Return Concepto
        End Get
        Set(ByVal value As String)
            Concepto = value
        End Set
    End Property
End Class

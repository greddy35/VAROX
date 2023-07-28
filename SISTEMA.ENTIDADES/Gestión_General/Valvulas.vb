Public Class Valvulas
    Private _id As String
    Private _idClase As String
    Private _idTipoMed As String
    Private _idTipoVal As String
    Private _concepto As String
    Private _valvula As String
    Private _valvulaPadre As String
    Private _alias As String
    Private _estado As Char
    Private _creadoPor As String
    Private _creadoEl As String
    Private _modificadoPor As String
    Private _modificadoEl As String

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property IdClase As String
        Get
            Return _idClase
        End Get
        Set(value As String)
            _idClase = value
        End Set
    End Property

    Public Property IdTipoMed As String
        Get
            Return _idTipoMed
        End Get
        Set(value As String)
            _idTipoMed = value
        End Set
    End Property

    Public Property IdTipoVal As String
        Get
            Return _idTipoVal
        End Get
        Set(value As String)
            _idTipoVal = value
        End Set
    End Property

    Public Property Concepto As String
        Get
            Return _concepto
        End Get
        Set(value As String)
            _concepto = value
        End Set
    End Property

    Public Property Valvula As String
        Get
            Return _valvula
        End Get
        Set(value As String)
            _valvula = value
        End Set
    End Property

    Public Property [Alias] As String
        Get
            Return _alias
        End Get
        Set(value As String)
            _alias = value
        End Set
    End Property

    Public Property Estado As Char
        Get
            Return _estado
        End Get
        Set(value As Char)
            _estado = value
        End Set
    End Property

    Public Property CreadoPor As String
        Get
            Return _creadoPor
        End Get
        Set(value As String)
            _creadoPor = value
        End Set
    End Property

    Public Property CreadoEl As String
        Get
            Return _creadoEl
        End Get
        Set(value As String)
            _creadoEl = value
        End Set
    End Property

    Public Property ModificadoPor As String
        Get
            Return _modificadoPor
        End Get
        Set(value As String)
            _modificadoPor = value
        End Set
    End Property

    Public Property ModificadoEl As String
        Get
            Return _modificadoEl
        End Get
        Set(value As String)
            _modificadoEl = value
        End Set
    End Property

    Public Property ValvulaPadre As String
        Get
            Return _valvulaPadre
        End Get
        Set(value As String)
            _valvulaPadre = value
        End Set
    End Property
End Class

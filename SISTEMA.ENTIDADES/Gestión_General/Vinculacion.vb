Public Class Vinculacion
    Private _id As String
    Private _idCliente As String
    Private _idLocal As String
    Private _idValvula As String
    Private _fecha As String
    Private _fechaIniRige As String
    Private _fechaFinRige As String
    Private _estado As Char
    Private _observ As String
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

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property IdLocal As String
        Get
            Return _idLocal
        End Get
        Set(value As String)
            _idLocal = value
        End Set
    End Property

    Public Property IdValvula As String
        Get
            Return _idValvula
        End Get
        Set(value As String)
            _idValvula = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property FechaIniRige As String
        Get
            Return _fechaIniRige
        End Get
        Set(value As String)
            _fechaIniRige = value
        End Set
    End Property

    Public Property FechaFinRige As String
        Get
            Return _fechaFinRige
        End Get
        Set(value As String)
            _fechaFinRige = value
        End Set
    End Property

    Public Property Observ As String
        Get
            Return _observ
        End Get
        Set(value As String)
            _observ = value
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

    Public Property Estado As Char
        Get
            Return _estado
        End Get
        Set(value As Char)
            _estado = value
        End Set
    End Property
End Class

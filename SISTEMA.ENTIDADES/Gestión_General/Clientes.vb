Public Class Clientes
    Private _id As String
    Private _nombre As String
    Private _alias As String
    Private _estado As Char
    Private _codigo As String
    Private _nit As String
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

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nit As String
        Get
            Return _nit
        End Get
        Set(value As String)
            _nit = value
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
End Class

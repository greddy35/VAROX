Public Class Clases
    Private _id As String
    Private _clase As String
    Private _concepto As String
    Private _activo As Char
    Private _charInicioD As Char
    Private _charFinD As Char
    Private _creadoEl As String
    Private _creadoPor As String
    Private _modificadoEl As String
    Private _modificadoPor As String

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Clase As String
        Get
            Return _clase
        End Get
        Set(value As String)
            _clase = value
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

    Public Property Activo As Char
        Get
            Return _activo
        End Get
        Set(value As Char)
            _activo = value
        End Set
    End Property

    Public Property CharInicioD As Char
        Get
            Return _charInicioD
        End Get
        Set(value As Char)
            _charInicioD = value
        End Set
    End Property

    Public Property CharFinD As Char
        Get
            Return _charFinD
        End Get
        Set(value As Char)
            _charFinD = value
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

    Public Property CreadoPor As String
        Get
            Return _creadoPor
        End Get
        Set(value As String)
            _creadoPor = value
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

    Public Property ModificadoPor As String
        Get
            Return _modificadoPor
        End Get
        Set(value As String)
            _modificadoPor = value
        End Set
    End Property
End Class

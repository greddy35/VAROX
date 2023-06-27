Public Class TipoMed_TiposValv
    Private _id As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _creadoPor As String
    Private _creadoEl As String
    Private _modificadoPor As String
    Private _modificadoEl As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
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

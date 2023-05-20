Public Class Login
    Private _usuario As String
    Private _contraseña As String
    Private _rol As String
    Private _nombre As String

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Rol As String
        Get
            Return _rol
        End Get
        Set(value As String)
            _rol = value
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
End Class

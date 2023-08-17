Public Class Usuarios
    'Tabla Modulos'
    Private _idModulo As String
    Private _nombreModulo As String
    Private _siglasModulo As String
    Private _descModulo As String
    'Tabla Rol_Usuario'
    Private _idRolUsuario As String
    'Tabla Rol'
    Private _idRol As String
    Private _nombreRol As String
    Private _descRol As String
    'Tabla  Acciones'
    Private _idAccion As String
    Private _nombreAccion As String
    Private _descAccion As String
    'Tabla Privilegio_Usuario'
    Private _idPrivUsuario As String
    'Tbala Usuarios'
    Private _idUsuario As String
    Private _usuario As String
    Private _pass As String
    Private _nombreUsuario As String
    Private _estado As String
    Private _modificadoPor As String


    Public Property IdModulo As String
        Get
            Return _idModulo
        End Get
        Set(value As String)
            _idModulo = value
        End Set
    End Property

    Public Property NombreModulo As String
        Get
            Return _nombreModulo
        End Get
        Set(value As String)
            _nombreModulo = value
        End Set
    End Property

    Public Property SiglasModulo As String
        Get
            Return _siglasModulo
        End Get
        Set(value As String)
            _siglasModulo = value
        End Set
    End Property

    Public Property DescModulo As String
        Get
            Return _descModulo
        End Get
        Set(value As String)
            _descModulo = value
        End Set
    End Property

    Public Property IdRolUsuario As String
        Get
            Return _idRolUsuario
        End Get
        Set(value As String)
            _idRolUsuario = value
        End Set
    End Property

    Public Property IdRol As String
        Get
            Return _idRol
        End Get
        Set(value As String)
            _idRol = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _nombreRol
        End Get
        Set(value As String)
            _nombreRol = value
        End Set
    End Property

    Public Property DescRol As String
        Get
            Return _descRol
        End Get
        Set(value As String)
            _descRol = value
        End Set
    End Property

    Public Property IdAccion As String
        Get
            Return _idAccion
        End Get
        Set(value As String)
            _idAccion = value
        End Set
    End Property

    Public Property NombreAccion As String
        Get
            Return _nombreAccion
        End Get
        Set(value As String)
            _nombreAccion = value
        End Set
    End Property

    Public Property DescAccion As String
        Get
            Return _descAccion
        End Get
        Set(value As String)
            _descAccion = value
        End Set
    End Property

    Public Property IdPrivUsuario As String
        Get
            Return _idPrivUsuario
        End Get
        Set(value As String)
            _idPrivUsuario = value
        End Set
    End Property

    Public Property IdUsuario As String
        Get
            Return _idUsuario
        End Get
        Set(value As String)
            _idUsuario = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
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

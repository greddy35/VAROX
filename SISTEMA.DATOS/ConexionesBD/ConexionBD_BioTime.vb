Imports System.Data.SqlClient

Public Class ConexionBD_BioTime
    Private _Base As String
    Private _Servidor As String
    Private _Usuario As String
    Private _Clave As String
    Private _Seguridad As Boolean = False
    Public conn As SqlConnection
    Public Property Base() As String
        Get
            Return _Base
        End Get
        Set(ByVal value As String)
            _Base = value
        End Set
    End Property

    Public Property Servidor() As String
        Get
            Return _Servidor
        End Get
        Set(ByVal value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

    Public Property Seguridad() As Boolean
        Get
            Return _Seguridad
        End Get
        Set(ByVal value As Boolean)
            _Seguridad = value
        End Set
    End Property

    Public Sub New()
        Me.Base = bdExterno '"BIOTIMEPRO"
        Me.Servidor = servExterno '"10.0.6.18"
        Me.Usuario = usuarioExterno '"biosoft"
        Me.Clave = claveExterno '"$B1@S0FT$"
        Me.conn = New SqlConnection(CrearCadena)
    End Sub

    Public Function CrearCadena() As String
        Dim cadena As String
        cadena = "Server=" & Me.Servidor & "; Database=" & Me.Base & ";"
        If Me.Seguridad Then
            cadena = cadena & "Integrated Security= SSPI"
        Else
            cadena = cadena & "User Id=" & Me.Usuario & ";Password=" & Me.Clave
        End If
        Return cadena
    End Function

    Public Function probarConexiónBioTimePro() As Boolean
        Try
            conn.Open()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try
    End Function
End Class


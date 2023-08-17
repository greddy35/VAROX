Imports SISTEMA.ENTIDADES
Imports SISTEMA.DATOS
Imports System.Data

Public Class NUsuarios
#Region "Funciones de Usuarios"
    Public Function NInsertar(Obj As Usuarios) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DUsuarios
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(Obj As Usuarios) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DUsuarios
            msj = Datos.Modificar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function
    Public Function NBuscar(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DUsuarios
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NLoginUsuario(ByVal usuario As String, ByVal contraseña As String) As DataTable
        Try
            Dim Datos As New DUsuarios       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataTable              'Se crea un objeto DataTable para encapsular el resultado
            Tabla = Datos.cargarCredenciales(usuario, contraseña)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function
    Public Function NRestablecerPass(ByVal id As String, ByVal pass As String) As Boolean
        Try
            Dim Datos As New DUsuarios
            Datos.RestablecerPass(id, pass)
            Return True
        Catch ex As Exception
            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return False                         'En caso de error o cero resultado, retornamos FALSE
        End Try
    End Function

    Public Function NConsultarUsuarios()
        Try
            Dim Datos As New DUsuarios
            Dim Tabla As New DataTable
            Tabla = Datos.ConsultarUsuarios()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Funciones de Roles"

    Public Function NCargarRoles() As DataSet
        Try
            Dim Datos As New DUsuarios
            Dim Tabla As New DataSet
            Tabla = Datos.CargarRoles()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Funciones de Privilegios"
    Public Function NGuardarPrivilegios(Obj As Usuarios, ByVal opcion As String) As Boolean
        Try
            Dim Datos As New DUsuarios
            Dim ret As Integer = Datos.GuardarPrivilegios(Obj, opcion)
            Return True
        Catch ex As Exception
            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return False                         'En caso de error o cero resultado, retornamos FALSE
        End Try
    End Function

    Public Function NActualizarRolDeUsuario(Obj As Usuarios) As Boolean
        Try
            Dim Datos As New DUsuarios
            Datos.ActualizarRolDeUsuario(Obj)
            Return True
        Catch ex As Exception
            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return False                         'En caso de error o cero resultado, retornamos FALSE
        End Try
    End Function

    Public Function NBuscarSiglasModulo(Valor As String) As DataTable
        Try
            Dim Datos As New DUsuarios              'Se instancia la Clase
            Dim Tabla As New DataTable              'Se crea un objeto DataTable para encapsular el resultado
            Tabla = Datos.BuscarSiglasModulo(Valor)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function
    Public Function NCargarModulos() As DataSet
        Try
            Dim Datos As New DUsuarios
            Dim Tabla As New DataSet
            Tabla = Datos.CargarModulos()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

    Public Function NCargarAcciones() As DataSet
        Try
            Dim Datos As New DUsuarios
            Dim Tabla As New DataSet
            Tabla = Datos.CargarModulos()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function


    Public Function NCargarPrivilegios(ByVal id_rol As String, ByVal id_usuario As String) As DataSet
        Try
            Dim Datos As New DUsuarios       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataSet              'Se crea un objeto DataSet para encapsular el resultado
            Tabla = Datos.cargarPrivilegios(id_rol, id_usuario)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function

    Public Function NCargarPrivilegiosTodos(ByVal id_modulo As String) As DataSet
        Try
            Dim Datos As New DUsuarios       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataSet              'Se crea un objeto DataSet para encapsular el resultado
            Tabla = Datos.cargarPrivilegiosTodos(id_modulo)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function
#End Region
End Class

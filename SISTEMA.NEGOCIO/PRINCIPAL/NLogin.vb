Imports System.Data
Imports SISTEMA.DATOS

Public Class NLogin

    Public Function NLoginUsuario(ByVal usuario As String, ByVal contraseña As String) As DataTable
        Try
            Dim Datos As New DLogin       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataTable              'Se crea un objeto DataTable para encapsular el resultado
            Tabla = Datos.cargarCredenciales(usuario, contraseña)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function

    Public Function NCargarPrivilegios(ByVal id_rol As String, ByVal id_usuario As String) As DataSet
        Try
            Dim Datos As New DLogin       'Se instancia la Clase Datos ConceptoHorario
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
            Dim Datos As New DLogin       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataSet              'Se crea un objeto DataSet para encapsular el resultado
            Tabla = Datos.cargarPrivilegiosTodos(id_modulo)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function

    Public Function NRestablecerPass(ByVal id As String, ByVal pass As String) As Boolean
        Try
            Dim Datos As New DLogin
            Datos.RestablecerPass(id, pass)
            Return True
        Catch ex As Exception
            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return False                         'En caso de error o cero resultado, retornamos FALSE
        End Try
    End Function
End Class

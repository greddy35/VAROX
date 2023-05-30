Imports SISTEMA.ENTIDADES
Imports SISTEMA.DATOS
Imports System.Data

Public Class NUsuarios
#Region "Funciones de Usuarios"
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

    'Public Function NActualizarClasificacion(Obj As Clasificacion) As Boolean
    '    Try
    '        Dim Datos As New DClasificacion
    '        Datos.ActualizarClasificacion(Obj)
    '        Return True
    '    Catch ex As Exception
    '        ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return False                         'En caso de error o cero resultado, retornamos FALSE
    '    End Try
    'End Function

    'Public Function NEliminarClasificacion(ByVal valor As String) As Boolean
    '    Try
    '        Dim Datos As New DClasificacion
    '        Datos.EliminarClasificacion(valor)
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return False                         'En caso de error o cero resultado, retornamos FALSE
    '    End Try
    'End Function

    'Public Function NBuscarClasificacion(Valor As String) As DataTable
    '    Try
    '        Dim Datos As New DClasificacion       'Se instancia la Clase Datos ConceptoHorario
    '        Dim Tabla As New DataTable              'Se crea un objeto DataTable para encapsular el resultado
    '        Tabla = Datos.BuscarClasificacion(Valor)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
    '        Return Tabla                            'Se retorna la tabla resultado
    '    Catch ex As Exception
    '        MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
    '    End Try
    'End Function

    'Public Function NBuscarClasificacionPorNombre(Valor As String) As String
    '    Try
    '        Dim Datos As New DClasificacion       'Se instancia la Clase Datos ConceptoHorario
    '        Dim Result As String
    '        Result = Datos.BuscarClasificacionPorNombre(Valor).ToString     'Se almacena el resultado del Metodo Buscar de la Capa Datos
    '        Return Result                            'Se retorna la tabla resultado
    '    Catch ex As Exception
    '        MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
    '    End Try
    'End Function

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

    'Public Function NSincronizarUsuarios() As Boolean
    '    Try
    '        Dim Datos As New DUsuarios
    '        Datos.SincronizarUsuarios()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return False
    '    End Try
    'End Function
#End Region

#Region "Funciones de Roles"
    '    Public Function NInsertarClasificacion(Obj As Clasificacion) As Boolean
    '        Try
    '            Dim Datos As New DClasificacion
    '            Datos.InsertarClasificacion(Obj)
    '            Return True
    '        Catch ex As Exception
    '            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return False                         'En caso de error o cero resultado, retornamos FALSE
    '        End Try
    '    End Function

    '    Public Function NActualizarClasificacion(Obj As Clasificacion) As Boolean
    '        Try
    '            Dim Datos As New DClasificacion
    '            Datos.ActualizarClasificacion(Obj)
    '            Return True
    '        Catch ex As Exception
    '            ''MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return False                         'En caso de error o cero resultado, retornamos FALSE
    '        End Try
    '    End Function

    '    Public Function NEliminarClasificacion(ByVal valor As String) As Boolean
    '        Try
    '            Dim Datos As New DClasificacion
    '            Datos.EliminarClasificacion(valor)
    '            Return True
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return False                         'En caso de error o cero resultado, retornamos FALSE
    '        End Try
    '    End Function

    '    Public Function NBuscarClasificacion(Valor As String) As DataTable
    '        Try
    '            Dim Datos As New DClasificacion       'Se instancia la Clase Datos ConceptoHorario
    '            Dim Tabla As New DataTable              'Se crea un objeto DataTable para encapsular el resultado
    '            Tabla = Datos.BuscarClasificacion(Valor)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
    '            Return Tabla                            'Se retorna la tabla resultado
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
    '        End Try
    '    End Function

    '    Public Function NBuscarClasificacionPorNombre(Valor As String) As String
    '        Try
    '            Dim Datos As New DClasificacion       'Se instancia la Clase Datos ConceptoHorario
    '            Dim Result As String
    '            Result = Datos.BuscarClasificacionPorNombre(Valor).ToString     'Se almacena el resultado del Metodo Buscar de la Capa Datos
    '            Return Result                            'Se retorna la tabla resultado
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
    '        End Try
    '    End Function

    '    Public Function NConsultarClasificacion()
    '        Try
    '            Dim Datos As New DClasificacion
    '            Dim Tabla As New DataTable
    '            Tabla = Datos.ConsultarClasificacion()
    '            Return Tabla
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return Nothing
    '        End Try
    '    End Function


    Public Function NCargarRoles()
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

    '    Public Function NEliminarClasificacion(ByVal valor As String) As Boolean
    '        Try
    '            Dim Datos As New DClasificacion
    '            Datos.EliminarClasificacion(valor)
    '            Return True
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return False                         'En caso de error o cero resultado, retornamos FALSE
    '        End Try
    '    End Function

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

    '    Public Function NBuscarClasificacionPorNombre(Valor As String) As String
    '        Try
    '            Dim Datos As New DClasificacion       'Se instancia la Clase Datos ConceptoHorario
    '            Dim Result As String
    '            Result = Datos.BuscarClasificacionPorNombre(Valor).ToString     'Se almacena el resultado del Metodo Buscar de la Capa Datos
    '            Return Result                            'Se retorna la tabla resultado
    '        Catch ex As Exception
    '            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
    '        End Try
    '    End Function

    'Public Function NConsultarClasificacion()
    '    Try
    '        Dim Datos As New DClasificacion
    '        Dim Tabla As New DataTable
    '        Tabla = Datos.ConsultarClasificacion()
    '        Return Tabla
    '    Catch ex As Exception
    '        MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
    '        Return Nothing
    '    End Try
    'End Function
    Public Function NCargarModulos()
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

    Public Function NCargarAcciones()
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
#End Region
End Class

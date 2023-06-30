Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NClases

    Public Function NInsertarClase(Obj As Clases) As Boolean
        Try
            Dim Datos As New DClases
            Datos.InsertarClase(Obj)
            Return True
        Catch ex As Exception
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

    Public Function NConsultarClases()
        Try
            Dim Datos As New DClases
            Dim Tabla As New DataTable
            Tabla = Datos.ConsultarClases()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarListado()
        Try
            Dim Datos As New DClases
            Dim Tabla As New DataTable
            Tabla = Datos.CargarListado()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

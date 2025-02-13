Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NClases

    Public Function NInsertar(Obj As Clases) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DClases
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj                         'En caso de error o cero resultado, retornamos FALSE
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

    Public Function NEliminar(ByVal valor As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DClases
            Datos.Eliminar(valor)
            Return ""
        Catch ex As Exception
            Return msj                        'En caso de error o cero resultado, retornamos FALSE
        End Try
    End Function

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

    Public Function NBuscar(Valor As String, Valor2 As String, Valor3 As String) As DataTable
        Try
            Dim Datos As New DClases       'Se instancia la Clase Datos ConceptoHorario
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor, Valor2, Valor3)     'Se almacena el resultado del Metodo Buscar de la Capa Datos
            Return Tabla                            'Se retorna la tabla resultado
        Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
            Return Nothing                          'En caso de error o cero resultado, retornamos Nothing
        End Try
    End Function

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

    Public Function NBuscarRegistrosClase(ByVal valor As String) As DataSet
        Try
            Dim Datos As New DClases
            Dim Tabla As New DataSet
            Tabla = Datos.BuscarRegistrosClase(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function NEjecutarTransacciones(ByVal sqlString As ArrayList) As Integer

        Dim msj As Integer = 0
        Try
            Dim Datos As New DClases
            msj = Datos.EjecutarTransacciones(sqlString)
            Return msj
        Catch ex As Exception
            Return msj
        End Try

    End Function
End Class

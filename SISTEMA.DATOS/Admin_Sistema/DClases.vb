Imports System.Data.SqlClient
Imports SISTEMA.ENTIDADES

Public Class DClases

    Inherits ConexionBD_Local
    Public Sub InsertarClase(ByVal Obj As Clases)
        Try
            Dim Comando As New SqlCommand("AS_insertarClase", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            'Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.Tipo
            'Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.Clasificacion
            'Comando.Parameters.Add("@categoria", SqlDbType.VarChar).Value = Obj.Categoria
            'Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
            'Comando.Parameters.Add("@modificado_por", SqlDbType.VarChar).Value = Obj.ModificadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Sub

    '    Public Sub ActualizarClasificacion(ByVal Obj As Clasificacion)
    '        Try
    '            Dim Comando As New SqlCommand("actualizarClasificacion", MyBase.conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = Obj.IdClasificacion
    '            Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.Tipo
    '            Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.Clasificacion
    '            Comando.Parameters.Add("@categoria", SqlDbType.VarChar).Value = Obj.Categoria
    '            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
    '            Comando.Parameters.Add("@modificado_por", SqlDbType.VarChar).Value = Obj.ModificadoPor
    '            MyBase.conn.Open()
    '            Comando.ExecuteNonQuery()
    '            MyBase.conn.Close()
    '        Catch ex As Exception
    '#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '            Throw ex
    '#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '        End Try
    '    End Sub

    '    Public Function BuscarClasificacion(ByVal valor As String) As DataTable
    '        Try
    '            Dim Resultado As SqlDataReader
    '            Dim Tabla As New DataTable
    '            Dim Comando As New SqlCommand("buscarClasificacion", MyBase.conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
    '            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
    '            Resultado = Comando.ExecuteReader()
    '            Tabla.Load(Resultado)                                                            'Se llena el DataSet con la consulta guardada en el adaptador
    '            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
    '            Return Tabla
    '        Catch ex As Exception
    '#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '            Throw ex
    '#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '        End Try
    '    End Function

    '    Public Function BuscarClasificacionPorNombre(ByVal valor As String) As String
    '        Try
    '            Dim Resultado As SqlDataReader
    '            Dim Tabla As New DataTable
    '            Dim Comando As New SqlCommand("buscarClasificacionPorNombre", MyBase.conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor
    '            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
    '            Resultado = Comando.ExecuteReader()
    '            'Tabla.Load(Resultado)                                                            'Se llena el DataSet con la consulta guardada en el adaptador
    '            Resultado.Read()
    '            Dim resul As String = Resultado(0)
    '            MyBase.conn.Close()  'Cerramos la conexion a BD
    '            Return resul
    '        Catch ex As Exception
    '#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '            Throw ex
    '#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '        End Try
    '    End Function


    Public Function ConsultarClases() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AS_consultarClases", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
            Console.WriteLine("Error en Function")
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

    Public Function CargarListado() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AS_cargarListado", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Comando.CommandTimeout = 300
            'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
            Console.WriteLine("Error en Function")
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
End Class

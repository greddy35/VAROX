Imports System.Data.SqlClient
Imports SISTEMA.ENTIDADES

Public Class DClases

    Inherits ConexionBD_Local
    Public Function Insertar(ByVal Obj As Clases) As String
        Try
            Dim Comando As New SqlCommand("AS_insertarClase", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = Obj.Clase
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = Obj.Concepto
            Comando.Parameters.Add("@palabra", SqlDbType.VarChar).Value = Obj.CharInicioD
            Comando.Parameters.Add("@ajuste", SqlDbType.VarChar).Value = Obj.Ajuste
            Comando.Parameters.Add("@numCaract", SqlDbType.VarChar).Value = Obj.NumCaractExt
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.CreadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Public Function Eliminar(ByVal valor As String) As String
        Try
            Dim Comando As New SqlCommand("AS_eliminarClase", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
    Public Function Buscar(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AS_buscarClase", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = valor2
            Comando.Parameters.Add("@palabra", SqlDbType.VarChar).Value = valor3
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)                                                            'Se llena el DataSet con la consulta guardada en el adaptador
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

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

    Public Function BuscarRegistrosClase(ByVal valor As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("AS_buscarRegistrosClase", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Tabla)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

End Class

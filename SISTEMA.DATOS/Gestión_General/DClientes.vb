Imports SISTEMA.ENTIDADES
Imports System.Data.SqlClient

Public Class DClientes
    Inherits ConexionBD_Local
    Public Function Insertar(ByVal Obj As Clientes) As String
        Try
            Dim Comando As New SqlCommand("GG_insertarCliente", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@alias", SqlDbType.VarChar).Value = Obj.Alias
            Comando.Parameters.Add("@activo", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@idNIT", SqlDbType.Int).Value = Obj.IdNit
            Comando.Parameters.Add("@iva", SqlDbType.Int).Value = Obj.Iva
            Comando.Parameters.Add("@NIT", SqlDbType.VarChar).Value = Obj.Nit
            Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Obj.Correo
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.CreadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function Modificar(ByVal Obj As Clientes) As String
        Try
            Dim Comando As New SqlCommand("GG_actualizarCliente", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = Obj.Id
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@alias", SqlDbType.VarChar).Value = Obj.Alias
            Comando.Parameters.Add("@activo", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@idNIT", SqlDbType.Int).Value = Obj.IdNit
            Comando.Parameters.Add("@iva", SqlDbType.Int).Value = Obj.Iva
            Comando.Parameters.Add("@NIT", SqlDbType.VarChar).Value = Obj.Nit
            Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Obj.Correo
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.ModificadoPor
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
            Dim Comando As New SqlCommand("GG_eliminarCliente", MyBase.conn)
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

    Public Function Consultar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("GG_consultarClientes", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

    Public Function Buscar(ByVal valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("GG_buscarCliente", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
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
    Public Function CargarTiposNIT(ByVal valor As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarTiposNIT", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = valor
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

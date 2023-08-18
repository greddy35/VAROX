Imports SISTEMA.ENTIDADES
Imports System.Data
Imports System.Data.SqlClient

Public Class DUsuarios
    Inherits ConexionBD_Local

#Region "METODOS DE USUARIOS"
    Public Function Insertar(ByVal Obj As Usuarios) As String
        Try
            Dim Comando As New SqlCommand("insertarUsuario", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.Usuario
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.NombreUsuario
            Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.Estado
            Comando.Parameters.Add("@modificado", SqlDbType.VarChar).Value = Obj.ModificadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function Modificar(ByVal Obj As Usuarios) As String
        Try
            Dim Comando As New SqlCommand("actualizarUsuario", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = Obj.IdUsuario
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.NombreUsuario
            Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.Estado
            Comando.Parameters.Add("@modificado", SqlDbType.VarChar).Value = Obj.ModificadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Public Function Buscar(ByVal valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("buscarUsuarios", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = valor
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

    Public Function cargarCredenciales(ByVal usuario As String, ByVal contraseña As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("cargarCredenciales", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario
            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Sub RestablecerPass(ByVal id As String, ByVal pass As String)
        Try
            Dim Comando As New SqlCommand("restablecerPass", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id
            Comando.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Sub

    Public Function ConsultarUsuarios() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("consultarUsuarios", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)                                                          'Se llena el DataSet con la consulta guardada en el adaptador
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
            Console.WriteLine("Error en Function")
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
#End Region

#Region "METODOS DE ROLES"

    Public Function CargarRoles() As DataSet
        Try
            Dim Datos As New DataSet
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("cargarRoles", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Datos)
            'Resultado = Comando.ExecuteReader()
            'Tabla.Load(Resultado)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Datos                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
#End Region

#Region "METODOS DE PRIVILEGIOS"

    Public Function GuardarPrivilegios(Obj As Usuarios, opcion As String) As Boolean
        Try
            Dim Comando As New SqlCommand("guardarPrivilegios", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@opcion", SqlDbType.VarChar).Value = opcion
            Comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = Obj.IdUsuario
            Comando.Parameters.Add("@id_modulo", SqlDbType.VarChar).Value = Obj.IdModulo
            Comando.Parameters.Add("@id_accion", SqlDbType.VarChar).Value = Obj.IdAccion
            'Comando.Parameters.Add("@respuesta", SqlDbType.Int)
            'Comando.Parameters("@respuesta").Direction = ParameterDirection.Output
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            'Dim resp = Comando.Parameters("@respuesta").Value
            MyBase.conn.Close()
            Return True
        Catch ex As Exception
            Return False
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

    Public Sub ActualizarRolDeUsuario(ByVal Obj As Usuarios)
        Try
            Dim Comando As New SqlCommand("actualizarRolDeUsuario", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = Obj.IdUsuario
            Comando.Parameters.Add("@id_rol", SqlDbType.VarChar).Value = Obj.IdRol
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Sub

    Public Function BuscarSiglasModulo(ByVal valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("buscarSiglasModulo", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_modulo", SqlDbType.VarChar).Value = valor
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

    Public Function CargarModulos() As DataSet
        Try
            Dim Datos As New DataSet
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("cargarModulos", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Datos)
            'Resultado = Comando.ExecuteReader()
            'Tabla.Load(Resultado)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Datos                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
    Public Function cargarPrivilegios(ByVal id_rol As String, ByVal id_usuario As String) As DataSet
        Try
            Dim Datos As New DataSet
            'Dim Resultado As SqlDataReader
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("cargarPrivilegios", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id_usuario
            Comando.Parameters.Add("@id_rol", SqlDbType.VarChar).Value = id_rol
            MyBase.conn.Open()
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Datos)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Datos                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

    Public Function cargarPrivilegiosTodos(ByVal id_modulo As String) As DataSet
        Try
            Dim Datos As New DataSet
            'Dim Resultado As SqlDataReader
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("cargarPrivilegiosTodos", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id_modulo", SqlDbType.VarChar).Value = id_modulo
            MyBase.conn.Open()
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Datos)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Datos                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
#End Region
End Class

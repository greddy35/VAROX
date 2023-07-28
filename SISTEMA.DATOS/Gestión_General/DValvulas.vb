Imports SISTEMA.ENTIDADES
Imports System.Data.SqlClient

Public Class DValvulas
    Inherits ConexionBD_Local
    Public Function Insertar(ByVal Obj As Valvulas) As String
        Try
            Dim Comando As New SqlCommand("GG_insertarValvula", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idC", SqlDbType.VarChar).Value = Obj.IdClase
            Comando.Parameters.Add("@idTV", SqlDbType.VarChar).Value = Obj.IdTipoVal
            Comando.Parameters.Add("@idTM", SqlDbType.VarChar).Value = Obj.IdTipoMed
            Comando.Parameters.Add("@alias", SqlDbType.VarChar).Value = Obj.Alias
            Comando.Parameters.Add("@activo", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@valvula", SqlDbType.VarChar).Value = Obj.Valvula
            Comando.Parameters.Add("@valvulaPadre", SqlDbType.VarChar).Value = Obj.ValvulaPadre
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.CreadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function Modificar(ByVal Obj As Valvulas) As String
        Try
            Dim Comando As New SqlCommand("GG_actualizarValvula", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = Obj.Id
            Comando.Parameters.Add("@idC", SqlDbType.VarChar).Value = Obj.IdClase
            Comando.Parameters.Add("@idTV", SqlDbType.VarChar).Value = Obj.IdTipoVal
            Comando.Parameters.Add("@idTM", SqlDbType.VarChar).Value = Obj.IdTipoMed
            Comando.Parameters.Add("@alias", SqlDbType.VarChar).Value = Obj.Alias
            Comando.Parameters.Add("@activo", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@valvula", SqlDbType.VarChar).Value = Obj.Valvula
            Comando.Parameters.Add("@valvulaPadre", SqlDbType.VarChar).Value = Obj.ValvulaPadre
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
            Dim Comando As New SqlCommand("GG_eliminarValvula", MyBase.conn)
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
            Dim Comando As New SqlCommand("GG_consultarValvulas", MyBase.conn)
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
            Dim Comando As New SqlCommand("GG_buscarValvula", MyBase.conn)
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
    Public Function Buscar2(ByVal valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("GG_buscarValvula2", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valvula", SqlDbType.VarChar).Value = valor
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
    Public Function CargarListaValvulas(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarListaValvulas", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@CHAR_I", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@caracteres", SqlDbType.VarChar).Value = valor2
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = valor3
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = valor4
            Comando.Parameters.Add("@ajuste", SqlDbType.VarChar).Value = valor5
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
    Public Function CargarTiposMedicion() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarTiposMedicion", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
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
    Public Function CargarTiposValvula() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarTiposValvula", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
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
    Public Function CargarClases() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarClases", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
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
    Public Function ConsultarDetalleClase(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarDetalleClases", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = valor2
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
    Public Function CargarValvulasPadres() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarValvulasPadre", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
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

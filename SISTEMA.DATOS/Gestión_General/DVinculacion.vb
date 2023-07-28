Imports SISTEMA.ENTIDADES
Imports System.Data.SqlClient

Public Class DVinculacion
    Inherits ConexionBD_Local
    Public Function Insertar(ByVal Obj As Vinculacion) As String
        Try
            Dim Comando As New SqlCommand("GG_insertarVinculacion", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idC", SqlDbType.VarChar).Value = Obj.IdCliente
            Comando.Parameters.Add("@idL", SqlDbType.VarChar).Value = Obj.IdLocal
            Comando.Parameters.Add("@idV", SqlDbType.VarChar).Value = Obj.IdValvula
            Comando.Parameters.Add("@fecha", SqlDbType.VarChar).Value = Obj.Fecha
            Comando.Parameters.Add("@fechaInicio", SqlDbType.Char).Value = Obj.FechaIniRige
            Comando.Parameters.Add("@fechaFin", SqlDbType.VarChar).Value = Obj.FechaFinRige
            Comando.Parameters.Add("@estado", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@observ", SqlDbType.VarChar).Value = Obj.Observ
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.CreadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function Modificar(ByVal Obj As Vinculacion) As String
        Try
            Dim Comando As New SqlCommand("GG_actualizarVinculacion", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = Obj.Id
            Comando.Parameters.Add("@idC", SqlDbType.VarChar).Value = Obj.IdCliente
            Comando.Parameters.Add("@idL", SqlDbType.VarChar).Value = Obj.IdLocal
            Comando.Parameters.Add("@idV", SqlDbType.VarChar).Value = Obj.IdValvula
            Comando.Parameters.Add("@fecha", SqlDbType.VarChar).Value = Obj.Fecha
            Comando.Parameters.Add("@fechaInicio", SqlDbType.Char).Value = Obj.FechaIniRige
            Comando.Parameters.Add("@fechaFin", SqlDbType.VarChar).Value = Obj.FechaFinRige
            Comando.Parameters.Add("@estado", SqlDbType.Char).Value = Obj.Estado
            Comando.Parameters.Add("@observ", SqlDbType.VarChar).Value = Obj.Observ
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.ModificadoPor
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function Aprobar(ByVal valor As String, ByVal valor2 As String) As String
        Try
            Dim Comando As New SqlCommand("GG_aprobarVinculacion", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = valor2
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Public Function Anular(ByVal valor As String, ByVal valor2 As String) As String
        Try
            Dim Comando As New SqlCommand("GG_anularVinculacion", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = valor2
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
            Dim Comando As New SqlCommand("GG_eliminarVinculacion", MyBase.conn)
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

    Public Function Consultar(ByVal filtro As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("GG_consultarVinculacion", MyBase.conn)
            Comando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro
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
            Dim Comando As New SqlCommand("GG_buscarVinculacion", MyBase.conn)
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

    Public Function CargarClientes() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarClientes", MyBase.conn)
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

    Public Function CargarLocales() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarLocales", MyBase.conn)
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

    Public Function CargarValvulas() As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_cargarValvulas", MyBase.conn)
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
    Public Function ConsultarDetalleCliente(ByVal valor As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarDetalleCliente", MyBase.conn)
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
    Public Function ConsultarDetalleLocal(ByVal valor As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarDetalleLocal", MyBase.conn)
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
    Public Function ConsultarDetalleValvula(ByVal valor As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarDetalleValvula", MyBase.conn)
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

    Public Function ConsultarMaxRigeDesde(ByVal Obj As Vinculacion) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarMaxRigeDesde", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idC", SqlDbType.VarChar).Value = Obj.IdCliente
            Comando.Parameters.Add("@idL", SqlDbType.VarChar).Value = Obj.IdLocal
            Comando.Parameters.Add("@idV", SqlDbType.VarChar).Value = Obj.IdValvula
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

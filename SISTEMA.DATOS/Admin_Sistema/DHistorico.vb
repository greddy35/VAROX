Imports SISTEMA.ENTIDADES
Imports System.Data.SqlClient

Public Class DHistorico
    Inherits ConexionBD_Externa

    Public Function CargarListado() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AS_cargarListado", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Comando.CommandTimeout = 600
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
    Public Function CargarListaValvulas(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("GG_cargarListaValvulas", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@CHAR_I", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@caracteres", SqlDbType.VarChar).Value = valor2
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = valor3
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = valor4
            Comando.Parameters.Add("@ajuste", SqlDbType.VarChar).Value = valor5
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            'Dim adapter As New SqlDataAdapter(Comando)
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            'adapter.Fill(Tabla)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
End Class

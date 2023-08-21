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
    Public Function CargarValoresValvula(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String, ByVal valor7 As String, ByVal valor8 As String, ByVal valor9 As String, ByVal valor10 As String, ByVal valor11 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_consultarValoresValvula", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@char_i", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@caracteres", SqlDbType.VarChar).Value = valor2
            Comando.Parameters.Add("@clase", SqlDbType.VarChar).Value = valor3
            Comando.Parameters.Add("@concepto", SqlDbType.VarChar).Value = valor4
            Comando.Parameters.Add("@ajuste", SqlDbType.VarChar).Value = valor5
            Comando.Parameters.Add("@valvula", SqlDbType.VarChar).Value = valor6
            Comando.Parameters.Add("@valvula2", SqlDbType.VarChar).Value = valor11
            Comando.Parameters.Add("@fechaIni", SqlDbType.DateTime).Value = valor7
            Comando.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = valor8
            Comando.Parameters.Add("@rigeIni", SqlDbType.DateTime).Value = valor9
            Comando.Parameters.Add("@rigeFin", SqlDbType.DateTime).Value = valor10
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Tabla)
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
            MyBase.conn.Close()
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
End Class

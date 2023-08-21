Imports System.Data.SqlClient
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports SISTEMA.ENTIDADES

Public Class DReportes
    Inherits ConexionBD_Local
    Public Function CrearListadoValvulas(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("GG_crearListadoValvulasPorFecha", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fechaIni", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@fechaFin", SqlDbType.VarChar).Value = valor2
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Tabla)                                                            'Se llena el DataSet con la consulta guardada en el adaptador
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla
        Catch ex As Exception
            MyBase.conn.Close()
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function


    Public Function Consultar(ByVal valor As String, ByVal valor2 As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("R_consultarHistorico", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fechaIni", SqlDbType.DateTime).Value = valor
            Comando.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = valor2
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla                                                                    'Retornamos el DataSet
        Catch ex As Exception
            MyBase.conn.Close()
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function
    Public Function Consultar2(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("R_consultarHistorico", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fechaIni", SqlDbType.DateTime).Value = valor
            Comando.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = valor2
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
    Public Function Insertar(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String) As String
        Try
            Dim Comando As New SqlCommand("R_insertarHistorico", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = valor2
            Comando.Parameters.Add("@disp", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@anterior", SqlDbType.Float).Value = valor6
            Comando.Parameters.Add("@valor", SqlDbType.Float).Value = valor3
            Comando.Parameters.Add("@consumo", SqlDbType.Float).Value = valor4
            Comando.Parameters.Add("@revision", SqlDbType.VarChar).Value = valor5
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            MyBase.conn.Close()
            Return ex.ToString
        End Try
    End Function

    Public Function Modificar(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String, ByVal valor7 As String) As String
        Try
            Dim Comando As New SqlCommand("R_actualizarHistorico", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@id", SqlDbType.VarChar).Value = valor
            Comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = valor3
            Comando.Parameters.Add("@disp", SqlDbType.VarChar).Value = valor2
            Comando.Parameters.Add("@anterior", SqlDbType.Float).Value = valor7
            Comando.Parameters.Add("@valor", SqlDbType.Float).Value = valor4
            Comando.Parameters.Add("@consumo", SqlDbType.Float).Value = valor5
            Comando.Parameters.Add("@revision", SqlDbType.VarChar).Value = valor6
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
            Return ""
        Catch ex As Exception
            MyBase.conn.Close()
            Return ex.ToString
        End Try
    End Function

    Public Function BuscarHistorico(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Tabla As New DataSet
            Dim Comando As New SqlCommand("R_buscarHistorico", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = valor2
            Comando.Parameters.Add("@disp", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()                                                              'Abrimos conexion a la BD
            Dim adapter As New SqlDataAdapter(Comando)
            adapter.Fill(Tabla)                                                       'Se llena el DataSet con la consulta guardada en el adaptador
            MyBase.conn.Close()                                                             'Cerramos la conexion a BD
            Return Tabla
        Catch ex As Exception
            MyBase.conn.Close()
#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
            Throw ex
#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
        End Try
    End Function

    '-----------------------SQLDataSource------------------------------
    Public Function ConsultarHistorico_sqlds(ByVal valor As String, ByVal valor2 As String) As SqlDataSource
        ' Instantiate a SqlDataSource
        Dim ds As SqlDataSource = New SqlDataSource()

        'Specify the name of the connection and parameters required to connect to a specific data provider.
        ds.ConnectionName = "DataBaseConnection"
        ds.ConnectionParameters = New MsSqlConnectionParameters(GlobalesConexiones.servLocal, GlobalesConexiones.bdLocal, GlobalesConexiones.usuarioLocal, GlobalesConexiones.claveLocal, MsSqlAuthorizationType.SqlServer)

        ' Create a stored procedure query to access fields of the 'SalesByCategory' stored procedure. 
        Dim spQuery As DevExpress.DataAccess.Sql.StoredProcQuery = New StoredProcQuery("R_consultarHistorico", "R_consultarHistorico")
        ' Initialize stored procedure parameters 
        ' The @CategoryName parameter Is initialized as an expression and bound to the report's 'pCategoryName' parameter.
        spQuery.Parameters.Add(New QueryParameter(
                               name:="@fechaIni",
                               type:=GetType(DateTime),
                               value:=valor))
        spQuery.Parameters.Add(New QueryParameter(
                               name:="@fechaFin",
                               type:=GetType(DateTime),
                               value:=valor2))
        ds.Queries.Add(spQuery)
        ds.Fill()
        Return ds
    End Function
End Class

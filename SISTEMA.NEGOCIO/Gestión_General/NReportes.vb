Imports DevExpress.DataAccess.Sql
Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NReportes

    Public Function NCrearListadoValvulas(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Datos As New DReportes
            Dim Tabla As New DataSet
            Tabla = Datos.CrearListadoValvulas(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarValoresValvula(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String, ByVal valor7 As String, ByVal valor8 As String, ByVal valor9 As String, ByVal valor10 As String, ByVal valor11 As String) As DataSet
        Try
            Dim Datos As New DReportes
            Dim Tabla As New DataSet
            Tabla = Datos.CargarValoresValvula(valor, valor2, valor3, valor4, valor5, valor6, valor7, valor8, valor9, valor10, valor11)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NConsultar(ByVal valor As String, ByVal valor2 As String) As DataTable
        Try
            Dim Datos As New DReportes
            Dim Tabla As New DataTable
            Tabla = Datos.Consultar(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NConsultar2(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Datos As New DReportes
            Dim Tabla As New DataSet
            Tabla = Datos.Consultar2(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NConsultarHistorico_sqlds(ByVal valor As String, ByVal valor2 As String) As SqlDataSource
        Try
            Dim Datos As New DReportes
            Dim Tabla As New SqlDataSource
            Tabla = Datos.ConsultarHistorico_sqlds(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NInsertar(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DReportes
            msj = Datos.Insertar(valor, valor2, valor3, valor4, valor5, valor6)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String, ByVal valor7 As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DReportes
            msj = Datos.Modificar(valor, valor2, valor3, valor4, valor5, valor6, valor7)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function
    Public Function NBuscarHistorico(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Datos As New DReportes
            Dim Tabla As New DataSet
            Tabla = Datos.BuscarHistorico(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

Imports SISTEMA.DATOS

Public Class NHistorico
    Public Function NCargarListado()
        Try
            Dim Datos As New DHistorico
            Dim Tabla As New DataTable
            Tabla = Datos.CargarListado()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function NCargarListaValvulas(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String) As DataTable
        Try
            Dim Datos As New DHistorico
            Dim Tabla As New DataTable
            Tabla = Datos.CargarListaValvulas(valor, valor2, valor3, valor4, valor5)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NCargarValoresValvula(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String, ByVal valor6 As String, ByVal valor7 As String, ByVal valor8 As String, ByVal valor9 As String, ByVal valor10 As String, ByVal valor11 As String) As DataSet
        Try
            Dim Datos As New DHistorico
            Dim Tabla As New DataSet
            Tabla = Datos.CargarValoresValvula(valor, valor2, valor3, valor4, valor5, valor6, valor7, valor8, valor9, valor10, valor11)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class


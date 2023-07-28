Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NValvulas
    Public Function NInsertar(Obj As Valvulas) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DValvulas
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(Obj As Valvulas) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DValvulas
            msj = Datos.Modificar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NEliminar(ByVal valor As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DValvulas
            msj = Datos.Eliminar(valor)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NConsultar() As DataTable
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataTable
            Tabla = Datos.Consultar()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar2(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar2(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarListaValvulas(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String) As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.CargarListaValvulas(valor, valor2, valor3, valor4, valor5)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarTiposValvula() As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.CargarTiposValvula()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarTiposMedicion() As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.CargarTiposMedicion()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NConsultarDetalleClase(ByVal valor As String, ByVal valor2 As String) As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.ConsultarDetalleClase(valor, valor2)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarClases() As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.CargarClases()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarValvulasPadres() As DataSet
        Try
            Dim Datos As New DValvulas
            Dim Tabla As New DataSet
            Tabla = Datos.CargarValvulasPadres()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

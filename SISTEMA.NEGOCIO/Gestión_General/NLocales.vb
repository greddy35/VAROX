Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NLocales
    Public Function NInsertar(Obj As Locales) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DLocales
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(Obj As Locales) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DLocales
            msj = Datos.Modificar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NEliminar(ByVal valor As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DLocales
            msj = Datos.Eliminar(valor)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NConsultar() As DataTable
        Try
            Dim Datos As New DLocales
            Dim Tabla As New DataTable
            Tabla = Datos.Consultar()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DLocales
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar2(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DLocales
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar2(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarUbicaciones() As DataSet
        Try
            Dim Datos As New DLocales
            Dim Tabla As New DataSet
            Tabla = Datos.CargarUbicaciones()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

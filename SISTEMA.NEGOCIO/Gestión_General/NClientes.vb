Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NClientes
    Public Function NInsertar(Obj As Clientes) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DClientes
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(Obj As Clientes) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DClientes
            msj = Datos.Modificar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NEliminar(ByVal valor As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DClientes
            Datos.Eliminar(valor)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NConsultar() As DataTable
        Try
            Dim Datos As New DClientes
            Dim Tabla As New DataTable
            Tabla = Datos.Consultar()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DClientes
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

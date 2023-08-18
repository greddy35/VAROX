Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES

Public Class NVinculacion
    Public Function NInsertar(Obj As Vinculacion) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Insertar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NModificar(Obj As Vinculacion) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Modificar(Obj)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NAprobar(ByVal valor As String, ByVal valor2 As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Aprobar(valor, valor2)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NAnular(ByVal valor As String, ByVal valor2 As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Anular(valor, valor2)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function
    Public Function NEliminar(ByVal valor As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Eliminar(valor)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function

    Public Function NConsultar(ByVal filtro As String) As DataTable
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataTable
            Tabla = Datos.Consultar(filtro)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NBuscar(ByVal valor As String) As DataTable
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NCargarClientes() As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.CargarClientes()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NCargarLocales() As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.CargarLocales()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NConsultarDetalleCliente(ByVal valor As String) As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.ConsultarDetalleCliente(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NConsultarDetalleLocal(ByVal valor As String) As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.ConsultarDetalleLocal(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function NConsultarDetalleValvula(ByVal valor As String) As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.ConsultarDetalleValvula(valor)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NConsultarMaxRigeDesde(Obj As Vinculacion) As DataSet
        Try
            Dim Datos As New DVinculacion
            Dim Tabla As New DataSet
            Tabla = Datos.ConsultarMaxRigeDesde(Obj)
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function NExtender(id As String, fecha As String, observ As String, usuario As String) As String
        Dim msj As String = ""
        Try
            Dim Datos As New DVinculacion
            msj = Datos.Extender(id, fecha, observ, usuario)
            Return msj
        Catch ex As Exception
            Return msj
        End Try
    End Function
End Class

﻿Imports System.Data
Imports System.Data.SqlClient
Imports SISTEMA.ENTIDADES

Public Class DLogin
    Inherits ConexionBD_Local

    '    Public Function cargarCredenciales(ByVal usuario As String, ByVal contraseña As String) As DataTable
    '        Try
    '            Dim Resultado As SqlDataReader
    '            Dim Tabla As New DataTable
    '            Dim Comando As New SqlCommand("cargarCredenciales", MyBase.conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario
    '            Comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña
    '            MyBase.conn.Open()
    '            Resultado = Comando.ExecuteReader()
    '            Tabla.Load(Resultado)
    '            MyBase.conn.Close()
    '            Return Tabla
    '        Catch ex As Exception
    '            Throw
    '        End Try
    '    End Function

    '    Public Sub RestablecerPass(ByVal id As String, ByVal pass As String)
    '        Try
    '            Dim Comando As New SqlCommand("restablecerPass", MyBase.conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id
    '            Comando.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass
    '            MyBase.conn.Open()
    '            Comando.ExecuteNonQuery()
    '            MyBase.conn.Close()
    '        Catch ex As Exception
    '#Disable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '            Throw ex
    '#Enable Warning CA2200 ' Iniciar de nuevo para preservar los detalles de la pila
    '        End Try
    '    End Sub

End Class

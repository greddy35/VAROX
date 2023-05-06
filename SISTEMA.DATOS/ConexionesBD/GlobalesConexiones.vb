﻿Imports System.Runtime.InteropServices
Imports System.Text

Public Module GlobalesConexiones

#Region "Usuario y Roles"
    'Variables de configuracion del sistema - Se cargan del archivo config.ini
    Public company As String, correo As String = ""
    Public servLocal As String = "", bdLocal As String = "", usuarioLocal As String = "", claveLocal As String = "" 'BASE DE DATOS LOCAL
    Public servExterno As String = "", bdExterno As String = "", usuarioExterno As String = "", claveExterno As String = "" 'BASE DE DATOS EXTERNA
#End Region

    <DllImport("kernel32")>
    Public Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function


End Module

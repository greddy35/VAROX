Imports System.Data.SqlClient
Imports System.Threading
Imports Microsoft.SqlServer
Imports SISTEMA.DATOS

Public Class Login

#Region "Variables Globles"
    'Private gsLogin As New NLogin
    'Private conexion As New ConexionBD_Local
    Private comando As New SqlCommand

    Friend Config As Globalization.CultureInfo
    Dim estadoConexión As Boolean = False

#End Region

#Region "Acciones Generales"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'SINCRONIZACIÓN DE LOS USUARIOS BIOTIMEPRO<->BIOSOFT
            'cargarArchivoIni()
            Timer1.Start()
            'gsLogin.NSincronizarUsuarios()
            txtContraseña.PasswordChar = "*"
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region

#Region "Funciones y Metodos"
    Private Sub cargarArchivoIni()
        Try
            If GlobalesConexiones.GetIniValue("GENERAL", "Company", My.Application.Info.DirectoryPath & "\config.ini") <> "" Then
                'GENERAL
                company = GetIniValue("GENERAL", "Company", My.Application.Info.DirectoryPath & "\config.ini").Trim.ToString
                correo = GetIniValue("GENERAL", "Correo", My.Application.Info.DirectoryPath & "\config.ini").Trim.ToString
                ''BIOSOFT
                'servBiosoft = GetIniValue("BIOSOFT", "Servidor", My.Application.Info.DirectoryPath & "\config.ini")
                'bdLocal = GetIniValue("BIOSOFT", "BD", My.Application.Info.DirectoryPath & "\config.ini")
                'usuarioLocal = GetIniValue("BIOSOFT", "Usuario", My.Application.Info.DirectoryPath & "\config.ini")
                'claveLocal = GetIniValue("BIOSOFT", "Clave", My.Application.Info.DirectoryPath & "\config.ini")
                ''BIOTIMEPRO
                'servExterno = GetIniValue("BIOTIMEPRO", "Servidor", My.Application.Info.DirectoryPath & "\config.ini")
                'bdExterno = GetIniValue("BIOTIMEPRO", "BD", My.Application.Info.DirectoryPath & "\config.ini")
                'usuarioExterno = GetIniValue("BIOTIMEPRO", "Usuario", My.Application.Info.DirectoryPath & "\config.ini")
                'claveExterno = GetIniValue("BIOTIMEPRO", "Clave", My.Application.Info.DirectoryPath & "\config.ini")
                ''ERP
                'servERP = GetIniValue("ADA", "Servidor", My.Application.Info.DirectoryPath & "\config.ini")
                'bdERP = GetIniValue("ADA", "BD", My.Application.Info.DirectoryPath & "\config.ini")
                'usuarioERP = GetIniValue("ADA", "Usuario", My.Application.Info.DirectoryPath & "\config.ini")
                'claveERP = GetIniValue("ADA", "Clave", My.Application.Info.DirectoryPath & "\config.ini")
                'btnIngresar.Enabled = True
            Else
                MsgBox("¡¡¡EL ARCHIVO DE CONFIGURACIÓN NO EXISTE O NO FUE ENCONTRADO!!!" + vbLf + "Contacte al encargado de Sistemas", MsgBoxStyle.Critical, "Configuración")
                btnIngresar.Enabled = False
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub


    Private Sub cargarCredenciales() 'Carga el USUARIO y CONTRASEÑA del usuario ingresado en el login

        Dim user As String
        Dim contraseña As String

        'Captura del usuario y contraseña
        user = txtUsuario.Text.Trim
        contraseña = txtContraseña.Text.Trim
        Try
            If user = "" Then
                MsgBox("DEBES INGRESAR UN USUARIO", MsgBoxStyle.Exclamation, "Validación de datos")
            ElseIf (contraseña = "") Then
                MsgBox("DEBES INGRESAR UNA CONTRASEÑA", MsgBoxStyle.Exclamation, "Validación de datos")
            ElseIf (user <> "" And contraseña <> "") Then
                'Dim Tabla As New DataTable

                'Tabla = gsLogin.NLoginUsuario(user, contraseña)

                'If (Tabla.Rows.Count > 0) Then
                'Dim fila As DataRow = Tabla.Rows(0)
                'Console.WriteLine("Valida al usuario")
                usuario = user                  'Se almacena el usuario en una variable global
                'nombreUsuario = fila("nombre").ToString  '
                'idUsuario = CInt(fila("id_usuario"))  'Se almacena el id del usuario, homologo de la BD.BIOTIMEPRO = BD.BIOSOFT
                'idRol = CInt(fila("id_rol"))          'Se almacena el id del rol, es administrado en el BIOSOFT'
                'rol = CInt(fila("rol"))               'Se almacena el nombre de rol del usuario
                'company = cboCompañia.SelectedItem.ToString
                txtUsuario.Text = ""
                    txtContraseña.Text = ""
                'SE CARGAN LOS PRIVILEGIOS AL DATASET GLOBAL PRIVILEGIOS
                'Privilegios = gsLogin.NCargarPrivilegios(idRol, idUsuario)
                Me.Hide()
                    frmPrincipal.Show()
                'Else
                '    MsgBox("USUARIO Y/O CONTRASEÑA INCORRECTO/A", MsgBoxStyle.Critical, "Inicio de sesión")
                'End If
            End If

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

#End Region

#Region "Acciones de Objetos"
    Public Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As Integer
        respuesta = MessageBox.Show("¿Seguro que desea salir del Sistema?", "Cierre de Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (respuesta = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If estadoConexión = True Then
            cargarCredenciales()
        Else
            MsgBox("NO HAY CONEXIÓN AL SERVIDOR DE BASE DE DATOS:" + vbLf + vbLf +
                "Revise que tenga conexion a las redes de la compañia a traves de:" + vbLf +
                "1 - Red cableada" + vbLf + "2 - Red inalámbrica", MsgBoxStyle.Critical, "Sin conexión")
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContraseña.Focus() 'Traslado de Focus a txtContraseña
            txtContraseña.SelectAll()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIngresar.Focus()
            Call btnIngresar_Click(sender, Nothing) 'Llamada y ejecucion del boton Ingresar
            'MsgBox("Presiono enter")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        txtUsuario.SelectAll()
    End Sub

    Private Sub txtContraseña_Click(sender As Object, e As EventArgs) Handles txtContraseña.Click
        txtContraseña.SelectAll()
    End Sub

    Private Sub btnVerPass_Click(sender As Object, e As EventArgs) Handles btnVerPass.Click
        Try
            If txtContraseña.PasswordChar = "*" Then
                txtContraseña.PasswordChar = ""
            Else
                txtContraseña.PasswordChar = "*"
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If My.Computer.Network.Ping("10.0.6.18") Or My.Computer.Network.Ping("10.0.1.188") Then
                estadoConexión = True
            Else
                estadoConexión = False
            End If
        Catch ex As Exception
            estadoConexión = False
        End Try
    End Sub
#End Region
End Class
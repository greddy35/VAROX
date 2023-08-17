Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports Microsoft.SqlServer
Imports SISTEMA.DATOS
Imports SISTEMA.NEGOCIO

Public Class Login

#Region "Variables Globles"
    'Private gsLogin As New NLogin
    Private gsUsuario As New NUsuarios
    Private conexionL As New ConexionBD_Local
    Private conexionE As New ConexionBD_Externa
    Private comando As New SqlCommand

    Dim estadoConexión As Boolean = False

#End Region

#Region "Acciones Generales"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarArchivoIni()
            Timer1.Start()
            Label1.Parent = PictureBox1
            Label2.Parent = PictureBox1
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
                user_sesion = GetIniValue("SESION", "Usuario", My.Application.Info.DirectoryPath & "\config.ini").Trim.ToString
                ''SERVER
                'REGISTRA EN SISTEMA QUE SERVIDORES ESTAN ACTIVOS
                estadoLocal = GetIniValue("LOCAL", "Activo", My.Application.Info.DirectoryPath & "\config.ini").ToString
                estadoExterno = GetIniValue("EXTERNO", "Activo", My.Application.Info.DirectoryPath & "\config.ini").ToString

                servLocal = GetIniValue("LOCAL", "Servidor", My.Application.Info.DirectoryPath & "\config.ini")
                bdLocal = GetIniValue("LOCAL", "BD", My.Application.Info.DirectoryPath & "\config.ini")
                usuarioLocal = GetIniValue("LOCAL", "Usuario", My.Application.Info.DirectoryPath & "\config.ini")
                claveLocal = GetIniValue("LOCAL", "Clave", My.Application.Info.DirectoryPath & "\config.ini")

                servExterno = GetIniValue("EXTERNO", "Servidor", My.Application.Info.DirectoryPath & "\config.ini")
                bdExterno = GetIniValue("EXTERNO", "BD", My.Application.Info.DirectoryPath & "\config.ini")
                usuarioExterno = GetIniValue("EXTERNO", "Usuario", My.Application.Info.DirectoryPath & "\config.ini")
                claveExterno = GetIniValue("EXTERNO", "Clave", My.Application.Info.DirectoryPath & "\config.ini")

                If user_sesion.ToString <> "" Then
                    txtUsuario.Text = user_sesion.ToString
                    txtContraseña.Focus()
                End If
                btnIngresar.Enabled = True
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

                Dim Tabla As New DataTable

                Tabla = gsUsuario.NLoginUsuario(user, contraseña)

                If (Tabla.Rows.Count > 0) Then
                    Dim fila As DataRow = Tabla.Rows(0)
                    'Console.WriteLine("Valida al usuario")
                    If fila("activo").ToString.Equals("S") Then
                        usuario = user                  'Se almacena el usuario en una variable global
                        contraseña_actual = contraseña
                        nombreUsuario = fila("nombre").ToString  '
                        idUsuario = CInt(fila("id_usuario"))  'Se almacena el id del usuario, homologo de la BD.BIOTIMEPRO = BD.BIOSOFT
                        idRol = CInt(fila("id_rol"))          'Se almacena el id del rol, es administrado en el BIOSOFT'
                        rol = fila("rol").ToString               'Se almacena el nombre de rol del usuario
                        'company = cboCompañia.SelectedItem.ToString
                        txtUsuario.Text = ""
                        txtContraseña.Text = ""
                        'SE CARGAN LOS PRIVILEGIOS AL DATASET GLOBAL PRIVILEGIOS
                        Privilegios = gsUsuario.NCargarPrivilegios(idRol.ToString, idUsuario.ToString)
                        Me.Hide()
                        frmPrincipal.Show()
                    Else
                        MsgBox("USUARIO INACTIVO, CONSULTE AL ADMINISTRADOR DE SISTEMA", MsgBoxStyle.Critical, "Inicio de sesión")
                    End If
                Else
                    MsgBox("USUARIO Y/O CONTRASEÑA INCORRECTO/A", MsgBoxStyle.Critical, "Inicio de sesión")
                End If
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
        If estadoConexión = True Then 'CAMBIAR A TRUE
            cargarCredenciales()
        Else
            MsgBox("NO HAY CONEXIÓN AL SERVIDOR DE BASE DE DATOS:" + vbLf + vbLf +
                "Revise que tenga conexion a las redes de la compañia a traves de:" + vbLf +
                "1 - Red cableada" + vbLf + "2 - Red inalámbrica", MsgBoxStyle.Critical, "Sin conexión")
        End If
        'Me.Hide()
        'frmPrincipal.Show()
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
            If txtContraseña.UseSystemPasswordChar = True Then
                txtContraseña.PasswordChar = CChar("")
                txtContraseña.UseSystemPasswordChar = False
            Else
                txtContraseña.PasswordChar = CChar("●")
                txtContraseña.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If estadoLocal.Equals("SI") Then
                If My.Computer.Network.Ping(servLocal) Then
                    If estadoExterno.Equals("SI") Then
                        If My.Computer.Network.Ping(servExterno) Then
                            estadoConexión = True
                        Else
                            estadoConexión = False
                        End If
                    Else
                        estadoConexión = True
                    End If
                Else
                    estadoConexión = False
                End If
            End If
        Catch ex As Exception
            estadoConexión = False
        End Try
        'If conexionL.probarConexiónLocal() Then
        '    MsgBox("CONEXION LOCAL EXITOSA", MsgBoxStyle.Information, "Prueba de Conexión")
        'Else
        '    MsgBox("CONEXION LOCAL FÁLLIDA", MsgBoxStyle.Critical, "Prueba de Conexión")
        'End If
    End Sub
#End Region
End Class
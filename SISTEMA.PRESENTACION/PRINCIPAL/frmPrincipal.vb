Imports DevExpress.XtraEditors
Imports Microsoft.SqlServer
Imports SISTEMA.DATOS
Imports System.Globalization

Public Class frmPrincipal


    'Variables globales
    'Dim gsUsuarios As New NUsuarios
    'Dim biosoft As New ConexionBD_BioSoft

    Dim estadoConexión As Boolean = False

#Region "Funciones y Metodos"
    Private Sub TimerConexión_Tick(sender As Object, e As EventArgs) Handles TimerConexión.Tick
        Try

            If My.Computer.Network.Ping(servLocal, 100) And My.Computer.Network.Ping(servExterno, 100) Then
                If My.Computer.Network.Ping(servLocal, 100) Then
                    servLocal = servLocal
                End If
                If My.Computer.Network.Ping(servExterno, 100) Then
                    servExterno = servExterno
                End If
                bsiServidores.Caption = servLocal + "-" + servExterno
                estadoConexión = True
                AccordionControl1.Enabled = True
                PanelControl1.Enabled = True
                bsiConexión.Caption = "CONECTADO"
                'Debug.Print("HAY CONEXION...")
            Else
                bsiServidores.Caption = "---"
                bsiConexión.Caption = "DESCONECTADO"
                estadoConexión = False
                AccordionControl1.Enabled = False
                PanelControl1.Enabled = False
                'Debug.Print("SIN CONEXIÓN...")
            End If
        Catch ex As Exception
            estadoConexión = False
        End Try
    End Sub
    Private Sub AbrirFormulario(ByVal frmHijo As Object) 'METODO PARA CARGAR LOS FORMULARIOS EN EL PANEL CONTENEDOR
        Dim frm As Form         'Se crea el Form contenedor
        frm = CType(frmHijo, Form)           'Se asigna el objeto frmHijo recibido al form contenedor
        If PanelControl1.Controls.ContainsKey(frmHijo.Name) Then 'Consulta el estado del form False = CERRADO, True = ABIERTO
            Dim opcion As DialogResult
            'Se valida al cambiar de ventana o recargar la misma ventana
            opcion = MessageBox.Show("El " & frmHijo.Text & " ya se encuentra abierto", "Cambio de Módulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If (opcion = DialogResult.OK) Then
                Me.PanelControl1.Controls.RemoveAt(0)           'Se remueven los controles existentes
                frm.TopLevel = False                            'Asigna la ventana de nivel superior
                frm.Dock = DockStyle.Fill                       'Rellena el contenedor con el formulario hijo
                Me.PanelControl1.Controls.Add(frm)
                Me.PanelControl1.Tag = frm
                frm.Show()
                frm.BringToFront()                              'Envia el form al frente
            Else
                frm.BringToFront()
            End If
            'AGREGAR UNA CONFIRMACION SI DESEA CAMBIAR DE VENTANA
        Else
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            Me.PanelControl1.Controls.Add(frm)
            Me.PanelControl1.Tag = frm
            frm.Show()
            frm.BringToFront()
        End If
    End Sub



    Function ValidarPassword(ByVal pass As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pass) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pass).Count < numUpper Then Return False
        If lower.Matches(pass).Count < numLower Then Return False
        If number.Matches(pass).Count < numNumbers Then Return False
        If special.Matches(pass).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub btnVerPass_Click(sender As Object, e As EventArgs) Handles btnVerPass.Click
        Try
            If txtPass.PasswordChar = "*" Then
                txtPass.PasswordChar = CChar("")
                txtPassConfirma.PasswordChar = CChar("")
            Else
                txtPass.PasswordChar = CChar("*")
                txtPassConfirma.PasswordChar = CChar("*")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    '    Private Sub iniciarMenu()
    '        'PRINCIPALES
    '        AccordionControlElementPlanillas.Visible = False
    '        AccordionControlElementAdministracion.Visible = False
    '        AccordionControlElementSistema.Visible = False
    '        AccordionControlElementSesion.Visible = False
    '        'SECUNDARIOS
    '        AccordionControlElementFranjas.Visible = False
    '        AccordionControlElementJornadas.Visible = False
    '        AccordionControlElementConceptos.Visible = False
    '        AccordionControlElementVinculacion.Visible = False
    '        AccordionControlElementFechasEspeciales.Visible = False
    '        'BOTONES DE MODULOS
    '        btnModuloPlanilla.Visible = False
    '        btnModuloCargaERP.Visible = False
    '        btnModuloFranjasHorarias.Visible = False
    '        btnModuloJornadasxDepartamento.Visible = False
    '        btnModuloClasificacionConceptos.Visible = False
    '        btnModuloConceptos.Visible = False
    '        btnModuloConceptosHorarios.Visible = False
    '        btnModuloConceptosHorariosGenerales.Visible = False
    '        btnModuloUsuariosPrivilegios.Visible = False
    '        btnModuloAjustes.Visible = False
    '        btnCambiarContraseña.Visible = False
    '    End Sub

    '    Private Sub cargarModulos()
    '        Try
    '            If Privilegios Is Nothing Then
    '                MessageBox.Show("Usuario sin privilegios", "BIOSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return
    '            End If
    '            'MODULO PLANILLAS
    '            If Privilegios.Tables(0).Select("id_modulo='1'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='2'").Count > 0 Then
    '                AccordionControlElementPlanillas.Visible = True
    '                'Modulo Planillas
    '                If Privilegios.Tables(0).Select("id_modulo='1'").Count > 0 Then
    '                    btnModuloPlanilla.Visible = True
    '                End If
    '                'Modulo Carga ERP
    '                If Privilegios.Tables(0).Select("id_modulo='2'").Count > 0 Then
    '                    btnModuloCargaERP.Visible = True
    '                End If
    '            End If
    '            'MODULO ADMINISTRACION - GENERAL
    '            If Privilegios.Tables(0).Select("id_modulo='3'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='4'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='6'").Count > 0 Then
    '                AccordionControlElementAdministracion.Visible = True
    '                'Modulo Franjas
    '                If Privilegios.Tables(0).Select("id_modulo='3'").Count > 0 Then
    '                    AccordionControlElementFranjas.Visible = True
    '                    btnModuloFranjasHorarias.Visible = True
    '                End If
    '                'Modulo Jornadas por Departamento
    '                If Privilegios.Tables(0).Select("id_modulo='4'").Count > 0 Then
    '                    AccordionControlElementJornadas.Visible = True
    '                    btnModuloJornadasxDepartamento.Visible = True
    '                End If
    '                'MODULO CONCEPTOS
    '                If Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='6'").Count > 0 Then
    '                    AccordionControlElementConceptos.Visible = True
    '                    'Modulo Clasificacion de Conceptos
    '                    If Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Then
    '                        btnModuloClasificacionConceptos.Visible = True
    '                    End If
    '                    'Modulo Conceptos
    '                    If Privilegios.Tables(0).Select("id_modulo='6'").Count > 0 Then
    '                        btnModuloConceptos.Visible = True
    '                    End If
    '                End If
    '            End If
    '            'MODULO VINCULACION - VINCULACION
    '            If Privilegios.Tables(0).Select("id_modulo='7'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='8'").Count > 0 Then
    '                AccordionControlElementVinculacion.Visible = True
    '                'Modulo Conceptos y Horarios Generales
    '                If Privilegios.Tables(0).Select("id_modulo='7'").Count > 0 Then
    '                    btnModuloConceptosHorariosGenerales.Visible = True
    '                End If
    '                'Modulo Conceptos y Horarios de Asignacion
    '                If Privilegios.Tables(0).Select("id_modulo='8'").Count > 0 Then
    '                    btnModuloConceptosHorarios.Visible = True
    '                End If
    '            End If
    '            'MODULO FECHAS ESPECIALES
    '            If Privilegios.Tables(0).Select("id_modulo='11'").Count > 0 Then
    '                AccordionControlElementFechasEspeciales.Visible = True
    '                'Modulo Fechas Especiales
    '                If Privilegios.Tables(0).Select("id_modulo='11'").Count > 0 Then
    '                    btnModuloFechasEspeciales.Visible = True
    '                End If
    '            End If
    '            'MODULO DE SISTEMA
    '            If Privilegios.Tables(0).Select("id_modulo='9'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='10'").Count > 0 Then
    '                AccordionControlElementSistema.Visible = True
    '                'Modulo de Privilegios de Usuario
    '                If Privilegios.Tables(0).Select("id_modulo='9'").Count > 0 Then
    '                    btnModuloUsuariosPrivilegios.Visible = True
    '                End If
    '                'Modulo de Ajustes de Sistema
    '                If Privilegios.Tables(0).Select("id_modulo='10'").Count > 0 Then
    '                    'btnModuloAjustes.Visible = True
    '                End If
    '            End If
    '            'MODULO DE SESIONES (SIEMPRE HABILITADO POR LOS ROLES POR DEFECTO)
    '            If Privilegios.Tables(0).Select("id_modulo='20'").Count > 0 Then
    '                AccordionControlElementSesion.Visible = True
    '                btnCambiarContraseña.Visible = True
    '            End If
    '            Refresh()
    '        Catch ex As Exception
    '            mensajeError(ex)
    '        End Try
    '    End Sub

#End Region

#Region "Acciones Generales"
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.lblUser.Caption = usuario
            Me.lblRol.Caption = rol
            Me.lblNombre.Caption = nombreUsuario
            txtPass.PasswordChar = CChar("*")
            txtPassConfirma.PasswordChar = CChar("*")
            'ASIGNA COMO IDIOMA A LOS OBJETOS DE LA LIBRERIA DEVEXPRESS EL ESPAÑOL
            '----------------------------------------
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-ES")
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("en-US")
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture("es-ES")
            'HABILITA LOS MODULOS ASIGNADOS AL USUARIO
            'iniciarMenu()
            'cargarModulos()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub


#End Region
End Class

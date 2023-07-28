Imports DevExpress.XtraEditors
Imports Microsoft.SqlServer
Imports SISTEMA.DATOS
Imports SISTEMA.NEGOCIO
Imports System.Globalization

Public Class frmPrincipal


    'Variables globales
    Dim gsLogin As New NLogin
    'Dim biosoft As New ConexionBD_BioSoft

    Dim estadoConexión As Boolean = False

#Region "Funciones y Metodos"
    Private Sub TimerConexión_Tick(sender As Object, e As EventArgs) Handles TimerConexión.Tick
        Try
            bsiFecha.Caption = Format(Now, "dd/MM/yyyy hh:mm:ss")
            If estadoLocal.Equals("SI") Then
                If My.Computer.Network.Ping(servLocal) Then
                    If estadoExterno.Equals("SI") Then
                        If My.Computer.Network.Ping(servExterno) Then
                            bsiServidores.Caption = servLocal + "/" + servExterno
                            estadoConexión = True
                            AccordionControl1.Enabled = True
                            PanelControl1.Enabled = True
                            bsiConexión.Caption = "CONECTADO"
                        Else
                            bsiServidores.Caption = "---"
                            bsiConexión.Caption = "DESCONECTADO"
                            estadoConexión = False
                            AccordionControl1.Enabled = False
                            PanelControl1.Enabled = False
                        End If
                    Else
                        bsiServidores.Caption = servLocal
                        estadoConexión = True
                        AccordionControl1.Enabled = True
                        PanelControl1.Enabled = True
                        bsiConexión.Caption = "CONECTADO"
                    End If
                Else
                    bsiServidores.Caption = "---"
                    bsiConexión.Caption = "DESCONECTADO"
                    estadoConexión = False
                    AccordionControl1.Enabled = False
                    PanelControl1.Enabled = False
                End If
            End If
        Catch ex As Exception
            estadoConexión = False
        End Try
    End Sub


    Private Sub AbrirFormulario(ByVal frmHijo As Form) 'METODO PARA CARGAR LOS FORMULARIOS EN EL PANEL CONTENEDOR
        Dim frm As Form         'Se crea el Form contenedor

        frm = frmHijo           'Se asigna el objeto frmHijo recibido al form contenedor

        If PanelControl1.Controls.ContainsKey(frmHijo.Name) Then 'Consulta el estado del form False = CERRADO, True = ABIERTO
            Dim opcion As DialogResult
            'Se valida al cambiar de ventana o recargar la misma ventana
            opcion = MessageBox.Show(CStr("El " & frmHijo.Text & " ya se encuentra abierto"), "Cambio de Módulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If txtPass.UseSystemPasswordChar = True Then
                txtPass.PasswordChar = CChar("")
                txtPassConfirma.PasswordChar = CChar("")
                txtPass.UseSystemPasswordChar = False
                txtPassConfirma.UseSystemPasswordChar = False
            Else
                txtPass.PasswordChar = CChar("●")
                txtPassConfirma.PasswordChar = CChar("●")
                txtPass.UseSystemPasswordChar = True
                txtPassConfirma.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles accSalir.Click
        Dim respuesta As Integer
        respuesta = MessageBox.Show("¿Seguro que desea salir? " & vbLf & " Al salir perderá cualquier cambio que no haya guardado", "Cierre de Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (respuesta = DialogResult.OK) Then
            Me.Dispose()
            Login.Close()
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles accCerrarSesion.Click
        Dim respuesta As Integer
        respuesta = MessageBox.Show("¿Seguro que desea cerrar la sesión actual?", "Cierre de Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (respuesta = DialogResult.OK) Then
            Login.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles accCambiarContraseña.Click
        Centrar(GroupBoxRestabPass)
        txtPass.PasswordChar = CChar("*")
        txtPassConfirma.PasswordChar = CChar("*")
        txtPassActual.Text = ""
        txtPass.Text = ""
        txtPassConfirma.Text = ""
        GroupBoxRestabPass.Visible = True
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Try
            'AGREGAR VALIDACION DE CONTRASEÑA ACTUAL
            If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                If contraseña_actual.ToString = txtPassActual.Text.Trim Then
                    If ValidarPassword(txtPass.Text.Trim) = True Then
                        If gsLogin.NRestablecerPass(idUsuario.ToString, txtPass.Text) = True Then
                            MessageBox.Show("Contraseña restablecida correctamente", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            contraseña_actual = txtPassActual.Text.ToString
                            GroupBoxRestabPass.Visible = False
                        Else
                            MessageBox.Show("La contraseña no se logró cambiar", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("La contraseña no cumple con los requisitos mínimos de complejidad:" & vbLf &
                                        vbLf & "Mínimo: 8 caracteres" &
                                        vbLf & "Contener: 1 Mayúscula" &
                                        vbLf & "Contener: 2 Minúsculas" &
                                        vbLf & "Contener: 2 Números" &
                                        vbLf & "Contener: 2 caracteres especiales", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    txtPassActual.Text = ""
                    MessageBox.Show("La contraseña actual no es correcta, intente de nuevo", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnCancelarRestablecerPass_Click(sender As Object, e As EventArgs) Handles btnCancelarRestablecerPass.Click
        GroupBoxRestabPass.Visible = False
        txtPassActual.Text = ""
        txtPass.Text = ""
        txtPassConfirma.Text = ""
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
            Me.lblCompañia.Caption = company
            txtPass.PasswordChar = CChar("*")
            txtPassConfirma.PasswordChar = CChar("*")
            'ASIGNA COMO IDIOMA A LOS OBJETOS DE LA LIBRERIA DEVEXPRESS EL ESPAÑOL
            '----------------------------------------
            'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-ES")
            'CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("en-US")
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture("es-ES")
            'HABILITA LOS MODULOS ASIGNADOS AL USUARIO
            'iniciarMenu()
            'cargarModulos()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim respuesta As Integer
            respuesta = MessageBox.Show("¿Seguro que desea salir? " & vbLf & " Al salir perderá cualquier cambio que no haya guardado", "Cierre de Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (respuesta = DialogResult.OK) Then
                Me.Dispose()
                Login.Close()
            End If
        End If
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MessageBox.Show("¿Seguro que desea salir? " & vbLf & " Al salir perderá cualquier cambio que no haya guardado", "Cierre de Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (respuesta = DialogResult.OK) Then
            Me.Dispose()
            Login.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub AccordionControlConfigClavBloq_Click(sender As Object, e As EventArgs) Handles accConfBloq.Click
        AbrirFormulario(frmConfigClaveBloq)
    End Sub

    Private Sub AccordionControlUsuariosPrivilegios_Click(sender As Object, e As EventArgs) Handles accUsuariosPrivilegios.Click
        AbrirFormulario(frmUsuariosPrivilegios)
    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles accCorteGeneral.Click
        AbrirFormulario(frmReporteria)
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles accValvulas.Click
        AbrirFormulario(frmValvulas)
    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles accLocales.Click
        AbrirFormulario(frmLocales)
    End Sub

    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles accClientes.Click
        AbrirFormulario(frmClientes)
    End Sub

    Private Sub AccordionControlElement14_Click(sender As Object, e As EventArgs) Handles accClasesDispo.Click
        AbrirFormulario(frmClasesDispositivos)
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles accTiposValvulas.Click
        AbrirFormulario(frmTiposValvulas)
    End Sub

    Private Sub accValLocClien_Click(sender As Object, e As EventArgs) Handles accValLocClien.Click
        AbrirFormulario(frmValv_Loc_Cli)
    End Sub

    Private Sub accRoles_Click(sender As Object, e As EventArgs) Handles accRoles.Click
        AbrirFormulario(frmRoles)
    End Sub

    Private Sub accTiposMedicion_Click(sender As Object, e As EventArgs) Handles accTiposMedicion.Click
        AbrirFormulario(frmTiposMediciones)
    End Sub

    Private Sub accVisualizadorDashboard_Click(sender As Object, e As EventArgs) Handles accVisualizadorDashboard.Click
        AbrirFormulario(frmVisualizadorDashboard)
    End Sub

    Private Sub accDiseñadorDashboard_Click(sender As Object, e As EventArgs) Handles accDiseñadorDashboard.Click
        AbrirFormulario(frmDiseñadorDashboard)
    End Sub

    Private Sub accVisualizadorReportes_Click(sender As Object, e As EventArgs) Handles accVisualizadorReportes.Click
        AbrirFormulario(frmVisualizadorReportes)
    End Sub

    Private Sub accDiseñadorReportes_Click(sender As Object, e As EventArgs) Handles accDiseñadorReportes.Click
        AbrirFormulario(frmDiseñadorReportes)
    End Sub



#End Region
End Class

Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Microsoft.SqlServer
Imports SISTEMA.DATOS
Imports SISTEMA.NEGOCIO
Imports System.Globalization

Public Class frmPrincipal


    'Variables globales
    Dim gsLogin As New NLogin

    Dim estadoConexión As Boolean = False

    Dim activeSkinName As String = UserLookAndFeel.Default.ActiveSkinName
#Region "datasource"
    Private Property DataSource() As SqlDataSource
#End Region

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
            Login.cargarArchivoIni() 'Recarga las opciones de los campos de texto
            Login.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles accCambiarContraseña.Click
        frmCambioContraseña.ShowDialog()
    End Sub

    Private Sub iniciarMenu()
        'PRINCIPALES
        accModReportAnalisis.Visible = False
        accModGestionGeneral.Visible = False
        accModAdmSistema.Visible = False
        'SECUNDARIOS
        accSubModAnalisis.Visible = False
        accSubModReportes.Visible = False
        accSubModDashboard.Visible = False
        accSubModGestion.Visible = False
        accSubModMantenimientos.Visible = False
        accSubModSeguridad.Visible = False
        accSubModParametros.Visible = False
        'BOTONES DE MODULOS
        accAnalisisCortes.Visible = False
        accDiseñadorDashboard.Visible = False
        accVisualizadorDashboard.Visible = False
        accDiseñadorReportes.Visible = False
        accVisualizadorReportes.Visible = False
        accValLocClien.Visible = False
        accClientes.Visible = False
        accLocales.Visible = False
        accValvulas.Visible = False
        accUsuariosPrivilegios.Visible = False
        accTiposMedicion.Visible = False
        accTiposValvulas.Visible = False
        accClasesDispo.Visible = False
    End Sub

    Private Sub cargarModulos()
        Try
            If Privilegios Is Nothing Then
                MessageBox.Show("Usuario sin privilegios", "VAROX", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'MODULO REPORTERIA Y ANALISIS
            If Privilegios.Tables(0).Select("id_modulo='1'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='2'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='3'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='4'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Then
                accModReportAnalisis.Visible = True
                'Modulo Analisis
                If Privilegios.Tables(0).Select("id_modulo='1'").Count > 0 Then
                    'Ventana Analisis y Cortes
                    accSubModAnalisis.Visible = True
                    accAnalisisCortes.Visible = True
                End If
                'Modulo Reportes
                If Privilegios.Tables(0).Select("id_modulo='2'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='3'").Count > 0 Then
                    accSubModReportes.Visible = True
                    'Ventana Creacion Reportes 
                    If Privilegios.Tables(0).Select("id_modulo='2'").Count > 0 Then
                        accDiseñadorReportes.Visible = True
                    End If
                    'Ventana Visualizacion Reportes
                    If Privilegios.Tables(0).Select("id_modulo='3'").Count > 0 Then
                        accVisualizadorReportes.Visible = True
                    End If
                End If
                'Modulo Dashboard
                If Privilegios.Tables(0).Select("id_modulo='4'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Then
                    accSubModDashboard.Visible = True
                    'Ventana Creacion Reportes 
                    If Privilegios.Tables(0).Select("id_modulo='4'").Count > 0 Then
                        accDiseñadorDashboard.Visible = True
                    End If
                    'Ventana Visualizacion Reportes
                    If Privilegios.Tables(0).Select("id_modulo='5'").Count > 0 Then
                        accVisualizadorDashboard.Visible = True
                    End If
                End If
            End If
            '--------------------------------------------------------------------------------------
            'MODULO GESTION GENERAL
            If Privilegios.Tables(0).Select("id_modulo='20'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='21'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='22'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='23'").Count > 0 Then
                accModGestionGeneral.Visible = True
                'Modulo Gestion
                If Privilegios.Tables(0).Select("id_modulo='20'").Count > 0 Then
                    'Ventana Valvulas-Local-Cliente
                    accSubModGestion.Visible = True
                    accValLocClien.Visible = True
                End If
                'Modulo Mantenimientos
                If Privilegios.Tables(0).Select("id_modulo='21'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='22'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='23'").Count > 0 Then
                    accSubModMantenimientos.Visible = True
                    'Ventana Clientes 
                    If Privilegios.Tables(0).Select("id_modulo='21'").Count > 0 Then
                        accClientes.Visible = True
                    End If
                    'Ventana Locales
                    If Privilegios.Tables(0).Select("id_modulo='22'").Count > 0 Then
                        accLocales.Visible = True
                    End If
                    'Ventana Valvulas
                    If Privilegios.Tables(0).Select("id_modulo='23'").Count > 0 Then
                        accValvulas.Visible = True
                    End If
                End If
            End If
            '-------------------------------------------------------------------------------
            'MODULO ADMINISTRACION DE SISTEMA
            If Privilegios.Tables(0).Select("id_modulo='90'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='91'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='92'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='93'").Count > 0 Then
                accModAdmSistema.Visible = True
                'Modulo Seguridad
                If Privilegios.Tables(0).Select("id_modulo='90'").Count > 0 Then
                    'Ventana Usuarios y Privilegios
                    accSubModSeguridad.Visible = True
                    accUsuariosPrivilegios.Visible = True
                End If
                'Modulo Parametros
                If Privilegios.Tables(0).Select("id_modulo='91'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='92'").Count > 0 Or Privilegios.Tables(0).Select("id_modulo='93'").Count > 0 Then
                    accSubModParametros.Visible = True
                    'Ventana Tipos Medicion
                    If Privilegios.Tables(0).Select("id_modulo='91'").Count > 0 Then
                        accTiposMedicion.Visible = True
                    End If
                    'Ventana Tipo Valvula
                    If Privilegios.Tables(0).Select("id_modulo='92'").Count > 0 Then
                        accTiposValvulas.Visible = True
                    End If
                    'Ventana Clases Dispositivos
                    If Privilegios.Tables(0).Select("id_modulo='93'").Count > 0 Then
                        accClasesDispo.Visible = True
                    End If
                End If
            End If
            Refresh()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

#End Region

#Region "Acciones Generales"
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.lblUser.Caption = usuario
            Me.lblRol.Caption = rol
            Me.lblNombre.Caption = nombreUsuario
            Me.lblCompañia.Caption = company
            'ASIGNA COMO IDIOMA A LOS OBJETOS DE LA LIBRERIA DEVEXPRESS EL ESPAÑOL
            '----------------------------------------
            'Cambio de SKIN
            'UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI)
            '----------------------------------------
            'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-ES")
            'CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("en-US")
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture("es-ES")
            'HABILITA LOS MODULOS ASIGNADOS AL USUARIO
            iniciarMenu()
            cargarModulos()
            Dim respuesta As Integer
            respuesta = MessageBox.Show("¿Desea visualizar el Dashboard de Inicio?", "Dashboard Inicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (respuesta = DialogResult.Yes) Then
                AbrirFormulario(DashboardP)
            End If
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

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles accAnalisisCortes.Click
        AbrirFormulario(frmReporteria)
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
        AbrirFormulario(frmDashboardViewer)
    End Sub

    Private Sub accDiseñadorDashboard_Click(sender As Object, e As EventArgs) Handles accDiseñadorDashboard.Click
        frmDiseñadorDashboard.Show()
    End Sub

    Private Sub accVisualizadorReportes_Click(sender As Object, e As EventArgs) Handles accVisualizadorReportes.Click
        AbrirReporte()
    End Sub

    Private Sub accDiseñadorReportes_Click(sender As Object, e As EventArgs) Handles accDiseñadorReportes.Click
        OpenReportDesigner()
    End Sub

#Region "CREACIÓN DE DISEÑADOR DE REPORTERÍA y DISEÑADOR DE DASHBOARD"
    'METODOS PARA CARGAR EL DISEÑADOR DE REPORTES
    Private Sub OpenReportDesigner()
        CreateSqlDataSource() 'Crea el sqlDatSource
        Dim rep As XtraReport = CreateReport(DataSource) 'Crea el reporte vacío
        Dim designer As New ReportDesignTool(rep)
        designer.ShowRibbonDesigner()
    End Sub
    '-----------------GENERADOR DEL REPORTE Y SOURCE----------------------
    Public Sub CreateSqlDataSource()
        InitializeSqlDataSource()
        DataSource.Queries.Add(CreateStoredProcedureQuery())
        'Refresca el datasource y actualiza
        DataSource.RebuildResultSchema()
    End Sub
    '-----------------SE INICIALIZA LA CONEXIÓN-----------------------
    Private Sub InitializeSqlDataSource()
        CreateConnectionFromParameters()
    End Sub
    '------------------SE CREA LA CONEXIÓN CON LA BASE DE DATOS----------------------
    Private Sub CreateConnectionFromParameters()
        Dim connectionParameters As New MsSqlConnectionParameters() With
        {
        .ServerName = GlobalesConexiones.servLocal,
        .DatabaseName = GlobalesConexiones.bdLocal,
        .UserName = GlobalesConexiones.usuarioLocal,
        .Password = GlobalesConexiones.claveLocal,
        .AuthorizationType = MsSqlAuthorizationType.SqlServer}
        DataSource = New SqlDataSource(connectionParameters)
    End Sub

    '-------------------PRECARGAR EL PROCEDIMIENTO ALMACENADO---------------------
    Public Shared Function CreateStoredProcedureQuery() As SqlQuery
        Dim spQuery As New StoredProcQuery("R_cargarVista", "R_cargarVista")
        Return spQuery
    End Function
    '------------------CREAR EL REPORTE-----------------------------
    Public Shared Function CreateReport(ByVal dataSource As Object) As XtraReport
        Dim ds As SqlDataSource = TryCast(dataSource, SqlDataSource)
        If ds Is Nothing Then
            Return New XtraReport()
        End If
        ' Create an empty report.
        Dim report As New XtraReport()
        ' Bind the report to a data source.
        report.DataSource = ds
        report.DataMember = ds.Queries(0).Name
        report.Name = "Mi reporte"
        Return report
    End Function

    Private Sub btnGuardarTema_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarTema.ItemClick
        activeSkinName = UserLookAndFeel.Default.ActiveSkinName
        Console.WriteLine("Tema: " & activeSkinName)
        If saveINIkey(My.Application.Info.DirectoryPath & "\config.ini", "PERSONALIZACION", "Tema", activeSkinName) = True Then
            MsgBox("Se ha guardado el tema actual", MsgBoxStyle.Information, "Tema de Sistema")
        Else
            MsgBox("No se logró guardar el tema actual", MsgBoxStyle.Exclamation, "Tema de Sistema")
        End If
    End Sub

    Private Sub btnAbrirGuia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrirGuia.ItemClick
        Try

            Try
                Dim loPSI As New ProcessStartInfo
                Dim loProceso As New Process
                loPSI.FileName = System.AppDomain.CurrentDomain.BaseDirectory + "\Manual.pdf"
                loProceso = Process.Start(loPSI)

            Catch ex As Exception
                MsgBox("No se pudo abrir la Guía de Usuario, por favor intentelo más tarde", MsgBoxStyle.Exclamation)
            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub accDashboardInicio_Click(sender As Object, e As EventArgs) Handles accDashboardInicio.Click
        AbrirFormulario(DashboardP)
    End Sub
#End Region

#End Region
End Class

Imports System.Windows.Media
Imports DevExpress.CodeParser
Imports DevExpress.Office
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmValv_Loc_Cli

#Region "Variables Globales"
    Dim gestor As New NVinculacion
    Dim gestorH As New NHistorico
    Dim clase As New Vinculacion
#End Region

#Region "Funciones y Metodos"
    Private Sub Nuevo()
        inhabilitarTodo()
        habilitarEditables()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        Limpiar()
    End Sub
    Private Sub Modificar()
        inhabilitarTodo()
        habilitarEditables()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
    End Sub
    Private Sub Guardar_Cancelar_Eliminar_Refrescar()
        inhabilitarEditables()
        inhabilitarTodo()
        btnNuevo.Enabled = True
        btnRefrescar.Enabled = True
        Limpiar()
    End Sub
    Private Sub ClicGrid()
        inhabilitarTodo()
        inhabilitarEditables()
        btnModificar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub inhabilitarTodo()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnAprobar.Enabled = False
        btnAnular.Enabled = False
        btnExtender.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        deFechaVinc.EditValue = ""
        deDesde.EditValue = ""
        deHasta.EditValue = ""
        cboCliente.SelectedIndex = -1
        cboCliente.Text = ""
        cboLocal.SelectedIndex = -1
        cboLocal.Text = ""
        cboValvula.SelectedIndex = -1
        cboValvula.Text = ""
        txtValvulaP.Text = ""
        txtIdCliente.Text = ""
        txtNITCliente.Text = ""
        txtIdLocal.Text = ""
        txtCodLocal.Text = ""
        txtIdValvula.Text = ""
        txtIdClase.Text = ""
        txtClase.Text = ""
        txtConceptoClase.Text = ""
        txtIdTipoMedicion.Text = ""
        txtTipoMedicion.Text = ""
        txtIdTipoValvula.Text = ""
        txtTipoValvula.Text = ""
        txtEstado.Text = ""
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    Private Sub inhabilitarEditables()
        cboCliente.Enabled = False
        cboLocal.Enabled = False
        cboValvula.Enabled = False
        deDesde.Enabled = False
        deHasta.Enabled = False
        txtObserv.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        cboCliente.Enabled = True
        cboLocal.Enabled = True
        cboValvula.Enabled = True
        txtObserv.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If cboCliente.SelectedIndex = -1 Then
                mensaje += "Seleccione el Cliente" + vbCrLf
            End If
            If deDesde.Text = "" Then
                mensaje += "Fecha Rige Desde" + vbCrLf
            End If
            If deDesde.Text = "" Then
                mensaje += "Fecha Rige Desde" + vbCrLf
            End If

            If cboLocal.SelectedIndex = -1 Then
                mensaje += "Seleccione el Local" + vbCrLf
            End If
            If cboValvula.SelectedIndex = -1 Then
                mensaje += "Seleccione la Válvula" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function

    Private Sub cargarVinculaciones()
        Try
            Dim filtro As String = "%%"
            If chkPend.Checked Then
                filtro = "P"
            ElseIf chkApro.Checked Then
                filtro = "A"
            ElseIf chkAnul.Checked Then
                filtro = "E"
            End If
            Guardar_Cancelar_Eliminar_Refrescar()
            GridControlVinculacion.DataSource = gestor.NConsultar(filtro)   'Llenado del grid
            'GridViewVinculacion.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarClientes()
        Try
            Dim datos As DataSet = gestor.NCargarClientes()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboCliente
                    .DisplayMember = "NOMBRE_CLIENTE" 'VALORES A MOSTRAR
                    .ValueMember = "ID_CLIENTE"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboCliente.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Public Sub cargarLocales()
        Try
            Dim datos As DataSet = gestor.NCargarLocales()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboLocal
                    .DisplayMember = "NOMBRE_LOCAL" 'VALORES A MOSTRAR
                    .ValueMember = "ID_LOCAL"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboLocal.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Public Sub cargarValvulas()
        Try
            Dim datos As DataSet = gestorH.NCargarValvulas()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboValvula
                    .DisplayMember = "VALVULA" 'VALORES A MOSTRAR
                    .ValueMember = "ID_VALVULA"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboValvula.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub consultarDetalleCliente(ByVal valor As String)
        Try
            Dim tabla As DataSet = gestor.NConsultarDetalleCliente(valor) 'BUSCA POR ID
            If Not tabla Is Nothing Then
                For Each fila As DataRow In tabla.Tables(0).Rows
                    txtIdCliente.Text = CInt(fila(0)).ToString
                    txtNITCliente.Text = CStr(fila(1)).ToString
                Next
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub consultarDetalleLocal(ByVal valor As String)
        Try
            Dim tabla As DataSet = gestor.NConsultarDetalleLocal(valor) 'BUSCA POR ID
            If Not tabla Is Nothing Then
                For Each fila As DataRow In tabla.Tables(0).Rows
                    txtIdLocal.Text = CInt(fila(0)).ToString
                    txtCodLocal.Text = CStr(fila(1)).ToString
                Next
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub consultarDetalleValvula(ByVal valor As String)
        Try
            Dim tabla As DataSet = gestor.NConsultarDetalleValvula(valor) 'BUSCA POR ID
            If Not tabla Is Nothing Then
                For Each fila As DataRow In tabla.Tables(0).Rows
                    txtIdValvula.Text = CInt(fila(0)).ToString
                    txtIdClase.Text = CInt(fila(1)).ToString
                    txtConceptoClase.Text = CStr(fila(2)).ToString
                    txtIdTipoValvula.Text = CInt(fila(3)).ToString
                    txtTipoValvula.Text = CStr(fila(4)).ToString
                    txtIdTipoMedicion.Text = CInt(fila(5)).ToString
                    txtTipoMedicion.Text = CStr(fila(6)).ToString
                Next
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub validarFechaRigeDesde()
        Try
            If cboCliente.SelectedIndex <> -1 And cboLocal.SelectedIndex <> -1 And cboValvula.SelectedIndex <> -1 Then
                clase.IdCliente = txtIdCliente.Text.ToString
                clase.IdLocal = txtIdLocal.Text.ToString
                clase.IdValvula = txtIdValvula.Text.ToString
                Dim tabla As DataSet = gestor.NConsultarMaxRigeDesde(clase) 'BUSCA POR ID
                deDesde.Properties.MinValue = UltimoDiaDelMes(Today).AddMonths(-3)
                If Not tabla Is Nothing Then
                    For Each fila As DataRow In tabla.Tables(0).Rows
                        deDesde.Properties.MinValue = CDate(fila(6)).AddDays(1) 'FECHA FIN RIGE de la consulta
                    Next
                Else

                End If
                deDesde.Enabled = True
                deHasta.Enabled = False
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Private Sub inicializarModulo()
        'Ribbone
        RibbonPageEstado.Visible = False
        'Botones
        btnNuevo.Visibility = BarItemVisibility.Never
        btnGuardar.Visibility = BarItemVisibility.Never
        btnModificar.Visibility = BarItemVisibility.Never
        btnEliminar.Visibility = BarItemVisibility.Never
        btnRefrescar.Visibility = BarItemVisibility.Never
    End Sub

    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1).ToString = "20" And accion(4).ToString = "1" Then 'Nuevo / Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "2" Then 'Modificar
                    btnModificar.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "3" Then 'Eliminar
                    btnEliminar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "4" Then 'Aprobar
                    btnAprobar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "5" Then 'Anular
                    btnAnular.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "6" Then 'Extender
                    btnExtender.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "20" And accion(4).ToString = "14" Then 'Refrescar
                    RibbonPageEstado.Visible = True
                    btnRefrescar.Visibility = BarItemVisibility.Always
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region

#Region "Acciones Generales"
    Private Sub frmValv_Loc_Cli_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicializarModulo()
        cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarVinculaciones()
        GridViewVinculacion.BestFitColumns()
        cargarClientes()
        cargarLocales()
        cargarValvulas()
        Limpiar()
    End Sub
#End Region

#Region "Acciones de Botones"

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNuevo.ItemClick
        Nuevo()
        cargarClientes()
        cargarLocales()
        cargarValvulas()
        Limpiar()
        deFechaVinc.EditValue = Today()
        txtEstado.Text = "PENDIENTE"
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gestor.NBuscar(txtID.Text.ToString) 'BUSCA POR ID - txtID.Text.ToString
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.Id = txtID.Text.ToString
            clase.IdCliente = txtIdCliente.Text.ToString
            clase.IdLocal = txtIdLocal.Text.ToString
            clase.IdValvula = txtIdValvula.Text.ToString
            clase.Fecha = CDate(deFechaVinc.Text.ToString).ToString("yyyy-MM-dd HH:mm:ss")
            clase.FechaIniRige = CDate(deDesde.Text.ToString).ToString("yyyy-MM-dd 00:00:00")
            clase.FechaFinRige = CDate(deHasta.Text.ToString).ToString("yyyy-MM-dd 23:59:59")
            clase.Estado = CChar(Mid(txtEstado.Text, 1, 1)) 'PENDIENTE
            clase.Observ = txtObserv.Text.ToString
            clase.CreadoPor = ModuleGlobales.usuario
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                Dim tabla2 As DataTable = gestor.NBuscar(txtID.Text.Trim.ToString) 'BUSCA POR CODIGO
                If tabla2.Rows.Count = 0 Then
                    If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                        "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                        "VÁLVULA: " & cboValvula.Text.ToString, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                        Dim resp As String = gestor.NInsertar(clase)
                        If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                            MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarVinculaciones()
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cargarVinculaciones()
                        End If
                    End If
                Else
                    MessageBox.Show("Código de Local ya existe, busque el registro para modificarlo", "Registro ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "ID VINCULACIÓN: " & GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_VINC").ToString & vbCrLf &
                        "CLIENTE: " & GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "NOMBRE_CLIENTE").ToString & vbCrLf &
                        "LOCAL: " & GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "NOMBRE_LOCAL").ToString & vbCrLf & vbCrLf &
                        "VÁLVULA: " & GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "VALVULA").ToString & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                        "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                        "VÁLVULA: " & cboValvula.Text.ToString, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarVinculaciones()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarVinculaciones()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnModificar.ItemClick
        If txtEstado.Text = "PENDIENTE" Then
            Modificar()
        Else
            MessageBox.Show("Solo es posible editar las vinculaciones en estado: PENDIENTE", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEliminar.ItemClick
        If txtEstado.Text = "ANULADO" Then
            If ModuleGlobales.usuario = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "MODIFICADO_POR").ToString Then
                If MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbCrLf + vbCrLf +
                       "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                       "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                       "VÁLVULA: " & cboValvula.Text.ToString, "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        Dim valor As String = txtID.Text.ToString
                        Dim resp As String = gestor.NEliminar(valor)
                        If resp = "" Then
                            MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Limpiar()
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarVinculaciones()
                        ElseIf resp.Contains("0x80131904") Then
                            MessageBox.Show("Existen registros ligados a esta vinculación, no se puede eliminar", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        mensajeError(ex)
                    End Try
                End If
            Else
                MessageBox.Show("Las vinculaciones solo las puede eliminar el usuario que anuló el registro", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Solo es posible eliminar las vinculaciones en estado: ANULADO", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarVinculaciones()
    End Sub

    Private Sub deDesde_EditValueChanged(sender As Object, e As EventArgs) Handles deDesde.EditValueChanged
        Try
            If deDesde.EditValue IsNot "" Then
                deHasta.Properties.MinValue = CDate(deDesde.EditValue)
                deHasta.EditValue = Today
                deHasta.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        If cboCliente.SelectedIndex <> -1 Then
            txtIdCliente.Text = cboCliente.SelectedValue.ToString
            consultarDetalleCliente(txtIdCliente.Text.ToString)
            validarFechaRigeDesde()
        End If
    End Sub

    Private Sub cboLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocal.SelectedIndexChanged
        If cboLocal.SelectedIndex <> -1 Then
            txtIdLocal.Text = cboLocal.SelectedValue.ToString
            consultarDetalleLocal(txtIdLocal.Text.ToString)
            validarFechaRigeDesde()
        End If
    End Sub

    Private Sub cboValvula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboValvula.SelectedIndexChanged
        If cboValvula.SelectedIndex <> -1 Then
            txtIdValvula.Text = cboValvula.SelectedValue.ToString
            consultarDetalleValvula(txtIdValvula.Text.ToString)
            validarFechaRigeDesde()
        Else
            txtIdValvula.Text = ""
        End If
    End Sub

    Private Sub GridViewVinculacion_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewVinculacion.RowClick
        Try
            If GridViewVinculacion.GetSelectedRows.Count = 1 And GridViewVinculacion.IsFilterRow(e.RowHandle) = False And GridViewVinculacion.IsGroupRow(e.RowHandle) = False Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_VINC").ToString
                Dim fecha As Date = CDate(GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "FECHA_VINC").ToString)
                Dim idCli As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_CLIENTE").ToString
                Dim cliente As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "NOMBRE_CLIENTE").ToString
                Dim nit As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "NIT").ToString
                Dim idL As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_LOCAL").ToString
                Dim local As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "NOMBRE_LOCAL").ToString
                Dim codigo As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CODIGO_LOCAL").ToString
                Dim idV As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_VALVULA").ToString
                Dim idCla As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_CLASE").ToString
                Dim clase As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CLASE").ToString
                Dim concepto As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CONCEPTO").ToString
                Dim idTV As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_TIPO_VALVULA").ToString
                Dim tipoV As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "TIPO_VALVULA").ToString
                Dim idTM As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ID_TIPO_MEDICION").ToString
                Dim tipoM As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "TIPO_MEDICION").ToString
                Dim valvula As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "VALVULA").ToString
                Dim valvulaP As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "VALVULA_PADRE").ToString
                Dim rigeDesde As Date = CDate(GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "FECHA_INICIO_RIGE").ToString)
                Dim rigeHasta As Date = CDate(GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "FECHA_FIN_RIGE").ToString)
                Dim observ As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "OBSERVACION").ToString
                Dim estado As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "ESTADO").ToString
                Dim creadoPor As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                deFechaVinc.EditValue = CDate(fecha)
                txtIdCliente.Text = idCli.ToString
                txtNITCliente.Text = nit
                cboCliente.Text = cliente
                txtIdLocal.Text = idL.ToString
                cboLocal.Text = local
                txtCodLocal.Text = codigo
                txtIdValvula.Text = idV.ToString
                txtIdClase.Text = idCla
                txtClase.Text = clase
                txtConceptoClase.Text = concepto
                cboValvula.Text = valvula
                txtIdTipoValvula.Text = idTV
                txtTipoValvula.Text = tipoV
                txtIdTipoMedicion.Text = idTM
                txtTipoMedicion.Text = tipoM
                cboValvula.Text = valvula
                txtValvulaP.Text = valvulaP
                deDesde.EditValue = CDate(rigeDesde)
                deHasta.EditValue = CDate(rigeHasta)
                txtEstado.Text = estado
                txtObserv.Text = observ
                txtCreadoPor.Text = creadoPor.ToString
                txtCreadoEl.Text = creadoEl.ToString
                txtModificadoPor.Text = modificadoPor.ToString
                txtModificadoEl.Text = modificadoEl.ToString
                ClicGrid()
                If estado = "PENDIENTE" Then
                    btnAprobar.Enabled = True
                End If
                If estado = "APROBADO" Then
                    btnAnular.Enabled = True
                    btnExtender.Enabled = True
                End If
            Else
                Guardar_Cancelar_Eliminar_Refrescar()
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick
        If txtEstado.Text = "PENDIENTE" Then
            If ModuleGlobales.usuario <> GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "CREADO_POR").ToString Then
                If MessageBox.Show("¿Desea aprobar el registro seleccionado?" + vbCrLf + vbCrLf +
                   "ID VINC: " & txtID.Text.ToString & vbCrLf &
                   "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                   "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                   "VÁLVULA: " & cboValvula.Text.ToString, "Aprobar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        Dim valor As String = txtID.Text.ToString
                        Dim resp As String = gestor.NAprobar(valor, ModuleGlobales.usuario)
                        If resp = "" Then
                            MessageBox.Show("El registro de aprobó con éxito", "Aprobar  registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Limpiar()
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarVinculaciones()
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        mensajeError(ex)
                    End Try
                End If
            Else
                MessageBox.Show("El usuario que creó la vinculación no tiene permitido aprobar el registro", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Solo es posible aprobar las vinculaciones en estado: PENDIENTE", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick
        If txtEstado.Text = "APROBADO" Then
            If ModuleGlobales.usuario = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "MODIFICADO_POR").ToString Then
                If MessageBox.Show("¿Desea anular el registro seleccionado?" + vbCrLf + vbCrLf +
                   "ID VINC: " & txtID.Text.ToString & vbCrLf &
                   "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                   "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                   "VÁLVULA: " & cboValvula.Text.ToString, "Anular registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        Dim valor As String = txtID.Text.ToString
                        Dim resp As String = gestor.NAnular(valor, ModuleGlobales.usuario)
                        If resp = "" Then
                            MessageBox.Show("El registro de anuló con éxito", "Anular  registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Limpiar()
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarVinculaciones()
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        mensajeError(ex)
                    End Try
                End If
            Else
                MessageBox.Show("Solo el usuario que aprobó la vinculación tiene permitido anular el registro", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Solo es posible anular las vinculaciones en estado: APROBADO", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnExtender_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExtender.ItemClick
        If txtEstado.Text = "APROBADO" Then
            If ModuleGlobales.usuario = GridViewVinculacion.GetRowCellValue(GridViewVinculacion.FocusedRowHandle, "MODIFICADO_POR").ToString Then
                deVigenciaNueva.Properties.MinValue = CDate(deHasta.EditValue).AddDays(1)
                deVigenciaNueva.EditValue = CDate(deHasta.EditValue).AddDays(1)
                Centrar(GroupBox1)
                GroupBox1.Visible = True
            Else
                MessageBox.Show("Solo el usuario que aprobó la vinculación tiene permitido extender la fecha de vigencia del registro", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Solo es posible extender fechas de vigencia de las vinculaciones en estado: APROBADO", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub chkAll_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkAll.CheckedChanged
        cargarVinculaciones()
    End Sub

    Private Sub chkPend_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkPend.CheckedChanged
        cargarVinculaciones()
    End Sub

    Private Sub chkAnul_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkAnul.CheckedChanged
        cargarVinculaciones()
    End Sub

    Private Sub chkApro_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkApro.CheckedChanged
        cargarVinculaciones()
    End Sub

    Private Sub btnCambiarVigencia_Click_1(sender As Object, e As EventArgs) Handles btnCambiarVigencia.Click
        If deVigenciaNueva.Text IsNot "" And txtObservVigencia.Text IsNot "" Then
            If MessageBox.Show("¿Desea extender la vigencia del registro seleccionado?" + vbCrLf + vbCrLf +
                               "ID VINC: " & txtID.Text.ToString & vbCrLf &
                               "CLIENTE: " & cboCliente.Text.ToString & vbCrLf &
                               "LOCAL: " & cboLocal.Text.ToString & vbCrLf &
                               "VÁLVULA: " & cboValvula.Text.ToString & vbCrLf & vbCrLf &
                               "NUEVA VIGENCIA: " & CDate(deVigenciaNueva.EditValue).ToString("dd-MM-yyyy"), "Extender vigencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim id As String = txtID.Text.ToString
                    Dim fecha As String = CDate(deVigenciaNueva.Text.ToString).ToString("yyyy-MM-dd 23:59:59")
                    Dim observ As String = txtObservVigencia.Text.ToString
                    Dim resp As String = gestor.NExtender(id, fecha, observ, ModuleGlobales.usuario)
                    If resp = "" Then
                        MessageBox.Show("La vigencia del registro se extendió con éxito", "Extender vigencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarVinculaciones()
                        GroupBox1.Visible = False
                        txtObservVigencia.Text = ""
                        deVigenciaNueva.EditValue = CDate(Today)
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    mensajeError(ex)
                End Try
            End If
        Else
            MessageBox.Show("Selecciona una nueva fecha de vigencia e indica una observación del porqué de la extensión", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub btnCancelarVigencia_Click(sender As Object, e As EventArgs) Handles btnCancelarVigencia.Click
        GroupBox1.Visible = False
        deVigenciaNueva.EditValue = CDate(Today)
        txtObservVigencia.Text = ""
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("La fecha seleccionada, sustituye la fecha actual del registro" & vbCrLf &
                        "extiende la vigencia de la vinculación hasta la nueva fecha seleccionada", "Fecha Vigencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region
End Class
Imports System.Threading
Imports DevExpress.Office
Imports DevExpress.XtraBars
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmValvulas
#Region "Variables Globales"
    Dim gestor As New NValvulas
    Dim gestorH As New NHistorico
    Dim clase As New Valvulas
    Dim flag As Boolean = False
#End Region

#Region "Funciones y Metodos"
    Private Sub Nuevo()
        Limpiar()
        inhabilitarTodo()
        habilitarEditables()
        flag = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        chkEstado.CheckState = CheckState.Checked
    End Sub
    Private Sub Modificar()
        inhabilitarTodo()
        habilitarEditables()
        flag = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
    End Sub
    Private Sub Guardar_Cancelar_Eliminar_Refrescar()
        Limpiar()
        inhabilitarEditables()
        inhabilitarTodo()
        btnNuevo.Enabled = True
        btnRefrescar.Enabled = True
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
        chkEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        flag = False
        txtID.Text = ""
        txtAlias.Text = ""
        cboTipoMedicion.SelectedIndex = -1
        cboTipoValvula.SelectedIndex = -1
        cboClaseValvula.SelectedIndex = -1
        cboValvula.SelectedIndex = -1
        cboValvulaPadre.SelectedIndex = -1
        txtAlias.Text = ""
        txtConceptoClase.Text = ""
        txtCharIni.Text = ""
        txtCaracExtr.Text = ""
        chkEstado.Checked = False
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    Private Sub inhabilitarEditables()
        txtAlias.Enabled = False
        cboTipoValvula.Enabled = False
        cboTipoMedicion.Enabled = False
        cboClaseValvula.Enabled = False
        cboValvula.Enabled = False
        cboValvulaPadre.Enabled = False
        txtConceptoClase.Enabled = False
        chkEstado.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtAlias.Enabled = True
        cboTipoValvula.Enabled = True
        cboTipoMedicion.Enabled = True
        cboClaseValvula.Enabled = True
        cboValvula.Enabled = True
        cboValvulaPadre.Enabled = True
        txtConceptoClase.Enabled = True
        chkEstado.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If cboTipoValvula.Text.Length = 0 Then
                mensaje += "Tipo de Válvula" + vbCrLf
            End If
            If cboTipoMedicion.Text.Length = 0 Then
                mensaje += "Tipo de Medición" + vbCrLf
            End If
            If cboClaseValvula.Text.Trim.Length = 0 Then
                mensaje += "Clase de Válvula" + vbCrLf
            End If
            If cboValvula.SelectedIndex = -1 Then
                mensaje += "Seleccione la Válvula" + vbCrLf
            End If
            If txtAlias.Text.Trim.Length = 0 Then
                mensaje += "Alias de la válvula" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function

    Private Sub cargarValvulas()
        Try
            GridControlValvulas.DataSource = gestor.NConsultar()   'Llenado del grid
            GridViewValvulas.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarTiposValvula()
        Try
            Dim datos As DataSet = gestor.NCargarTiposValvula()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboTipoValvula
                    .DisplayMember = "TIPO_VALVULA" 'VALORES A MOSTRAR
                    .ValueMember = "ID_TIPO_VALVULA"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboTipoValvula.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarTiposMedicion()
        Try
            Dim datos As DataSet = gestor.NCargarTiposMedicion()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboTipoMedicion
                    .DisplayMember = "TIPO_MEDICION" 'VALORES A MOSTRAR
                    .ValueMember = "ID_TIPO_MEDICION"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboTipoMedicion.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarClases()
        Try
            Dim datos As DataSet = gestor.NCargarClases()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboClaseValvula
                    .DisplayMember = "CLASE" 'VALORES A MOSTRAR
                    .ValueMember = "CONCEPTO"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboClaseValvula.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Public Sub cargarListaValvulas(ByVal valor As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByVal valor5 As String)
        Try
            Dim datos As DataTable = gestorH.NCargarListaValvulas(valor, valor2, valor3, valor4, valor5)    'Llenado del combo
            If Not datos Is Nothing Then
                With cboValvula
                    .DisplayMember = "LOCAL_ACT" 'VALORES A MOSTRAR
                    .ValueMember = "LOCAL_ACT"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos
                End With
                cboValvula.SelectedIndex = -1
                cboValvulaPadre.Text = ""
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarValvulasPadres()
        Try
            Dim datos As DataSet = gestor.NCargarValvulasPadres()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboValvulaPadre
                    .DisplayMember = "VALVULA_PADRE" 'VALORES A MOSTRAR
                    .ValueMember = "VALVULA_PADRE"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboValvulaPadre.SelectedIndex = -1
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub consultarDetalleClase(ByVal valor As String, ByVal valor2 As String)
        Try
            Dim tabla As DataSet = gestor.NConsultarDetalleClase(valor, valor2) 'BUSCA POR CODIGO
            If Not tabla Is Nothing Then
                For Each fila As DataRow In tabla.Tables(0).Rows
                    txtCharIni.Text = CStr(fila(0)).ToString
                    txtCaracExtr.Text = CInt(fila(1)).ToString
                    txtIdClase.Text = CStr(fila(2)).ToString
                    txtAjuste.Text = CInt(fila(3)).ToString
                Next
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub inicializarModulo()
        btnNuevo.Visibility = BarItemVisibility.Never
        btnGuardar.Visibility = BarItemVisibility.Never
        btnModificar.Visibility = BarItemVisibility.Never
        btnEliminar.Visibility = BarItemVisibility.Never
        btnRefrescar.Visibility = BarItemVisibility.Never
    End Sub

    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1).ToString = "23" And accion(4).ToString = "1" Then 'Nuevo / Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "23" And accion(4).ToString = "2" Then 'Modificar
                    btnModificar.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "23" And accion(4).ToString = "3" Then 'Eliminar
                    btnEliminar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "23" And accion(4).ToString = "14" Then 'Refrescar
                    btnRefrescar.Visibility = BarItemVisibility.Always
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region

#Region "Acciones Generales"
    Private Sub frmValvulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarModulo()
        cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarTiposValvula()
        cargarTiposMedicion()
        cargarClases()
        cargarValvulas()
        cargarValvulasPadres()
        Limpiar()
    End Sub
#End Region

#Region "Acciones de Botones"
#End Region
    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        Try
            If chkEstado.CheckState = CheckState.Checked Then
                chkEstado.Text = "Activo"
            Else
                chkEstado.Text = "Inactivo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboClaseValvula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClaseValvula.SelectedIndexChanged
        If cboClaseValvula.SelectedIndex > -1 And flag = True Then
            txtConceptoClase.Text = cboClaseValvula.SelectedValue.ToString
            consultarDetalleClase(cboClaseValvula.Text.ToString, cboClaseValvula.SelectedValue.ToString)
            Centrar(GroupBoxEspera)
            GroupBoxEspera.Visible = True
            Application.DoEvents()
            'Thread.Sleep(3000)
            cargarListaValvulas(txtCharIni.Text.ToString, txtCaracExtr.Text.ToString, "%" & cboClaseValvula.Text.ToString & "%", "%" & cboClaseValvula.SelectedValue.ToString & "%", txtAjuste.Text.ToString)
            cboValvula.Enabled = True
        Else
            txtConceptoClase.Text = ""
            cboValvula.Enabled = False
        End If
        GroupBoxEspera.Visible = False
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNuevo.ItemClick
        If GlobalesConexiones.estadoExterno.Equals("SI") Then
            cargarClases()
            Nuevo()
            cargarTiposValvula()
            cargarTiposMedicion()
            cargarValvulas()
            cargarValvulasPadres()
        Else
            MessageBox.Show("La conexión a la base de datos externa está deshabilitada," &
                            "contacte con el administrador de sistema, para modificar el archivo de conexión (confi.ini)", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gestor.NBuscar(txtID.Text.ToString) 'BUSCA POR ID
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.Id = txtID.Text.ToString
            clase.IdClase = txtIdClase.Text.ToString
            clase.IdTipoVal = cboTipoValvula.SelectedValue.ToString
            clase.IdTipoMed = cboTipoMedicion.SelectedValue.ToString
            clase.Alias = txtAlias.Text.ToString
            clase.Estado = CChar(IIf(chkEstado.CheckState = CheckState.Checked, "S", "N"))
            clase.Concepto = txtConceptoClase.Text.ToString
            clase.Valvula = cboValvula.Text.ToString
            clase.ValvulaPadre = cboValvulaPadre.Text.ToString
            clase.CreadoPor = ModuleGlobales.usuario
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                Dim tabla2 As DataTable = gestor.NBuscar2(cboValvula.Text.Trim.ToString) 'BUSCA POR CODIGO
                If tabla2.Rows.Count = 0 Then
                    If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "NOMBRE: " & clase.Valvula & vbCrLf &
                        "ALIAS: " & clase.Alias, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                        Dim resp As String = gestor.NInsertar(clase)
                        If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                            MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarValvulas()
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cargarValvulas()
                        End If
                    End If
                Else
                    MessageBox.Show("Válvula ya existe, busque el registro para modificarlo", "Registro ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "NOMBRE: " & GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "VALVULA").ToString & vbCrLf &
                        "ALIAS: " & GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ALIAS").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "NOMBRE: " & clase.Valvula & vbCrLf &
                        "ALIAS: " & clase.Alias, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarValvulas()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarValvulas()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarValvulas()
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarValvulas()
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnModificar.ItemClick
        If GlobalesConexiones.estadoExterno.Equals("SI") Then
            Modificar()
        Else
            MessageBox.Show("La conexión a la base de datos externa está deshabilitada," &
                            "contacte con el administrador de sistema, para modificar el archivo de conexión (confi.ini)", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEliminar.ItemClick
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbCrLf + vbCrLf +
            "ID = " + txtID.Text.ToString + "" + vbCrLf +
            "VÁLVULA = " + cboValvula.Text.ToString + "", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim valor As String = txtID.Text.ToString
                Dim resp As String = gestor.NEliminar(valor)
                If resp = "" Then
                    MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Guardar_Cancelar_Eliminar_Refrescar()
                    cargarValvulas()
                ElseIf resp.Contains("0x80131904") Then
                    MessageBox.Show("Existen registros ligados a esta Válvula, no se puede eliminar", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                mensajeError(ex)
            End Try
        End If
    End Sub

    Private Sub GridViewValvulas_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewValvulas.RowClick
        Try
            If GridViewValvulas.GetSelectedRows.Count = 1 And GridViewValvulas.IsFilterRow(e.RowHandle) = False And GridViewValvulas.IsGroupRow(e.RowHandle) = False Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ID_VALVULA").ToString
                Dim clase As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "CLASE").ToString
                Dim idTV As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ID_TIPO_VALVULA").ToString
                Dim idTM As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ID_TIPO_MEDICION").ToString
                Dim valvula As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "VALVULA").ToString
                Dim valvulaP As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "VALVULA_PADRE").ToString
                Dim aliasV As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ALIAS").ToString
                Dim estado As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "ACTIVO").ToString
                Dim creadoPor As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewValvulas.GetRowCellValue(GridViewValvulas.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                cboClaseValvula.Text = clase
                cboTipoValvula.SelectedValue = idTV
                cboTipoMedicion.SelectedValue = idTM
                cboValvula.Text = valvula
                cboValvulaPadre.Text = valvulaP
                txtAlias.Text = aliasV
                chkEstado.Checked = CBool(IIf(estado.Equals("S"), True, False))
                txtCreadoPor.Text = creadoPor.ToString
                txtCreadoEl.Text = creadoEl.ToString
                txtModificadoPor.Text = modificadoPor.ToString
                txtModificadoEl.Text = modificadoEl.ToString
                ClicGrid()
            Else
                Guardar_Cancelar_Eliminar_Refrescar()
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub cboValvula_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboValvula.SelectedValueChanged
        Try
            If cboValvula.SelectedIndex > -1 And cboValvula.Text.Length > 0 Then
                cboValvulaPadre.Text = cboValvula.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
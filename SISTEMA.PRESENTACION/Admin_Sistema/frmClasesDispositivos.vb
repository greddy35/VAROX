Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmClasesDispositivos

#Region "Globales"
    'Clases
    Dim clases As New Clases
    Dim gsClases As New NClases
    Dim gsHistorico As New NHistorico
    'Variables

#End Region


#Region "Metodos"

    Private Sub Nuevo()
        Limpiar()
        'habilitarEditables()
        inhabilitarTodo()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        chkEstado.CheckState = CheckState.Checked
    End Sub
    Private Sub Modificar()
        inhabilitarTodo()
        'habilitarEditables()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
    End Sub
    Private Sub Guardar_Cancelar_Eliminar_Refrescar()
        Limpiar()
        'inhabilitarEditables()
        inhabilitarTodo()
        btnNuevo.Enabled = True
        btnRefrescar.Enabled = True
    End Sub
    Private Sub ClicGrid()
        inhabilitarTodo()
        'inhabilitarEditables()
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub inhabilitarTodo()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        chkEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        txtClase.Text = ""
        txtConcepto.Text = ""
        txtPalabraClave.Text = ""
        txtAjuste.Text = ""
        txtCaractExtr.Text = ""
        chkEstado.Checked = False
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    'Private Sub inhabilitarEditables()
    '    txtNombre.Enabled = False
    '    txtAlias.Enabled = False
    '    cboTipoNIT.Enabled = False
    '    txtCorreo.Enabled = False
    '    txtNIT.Enabled = False
    '    txtCorreo.Enabled = False
    '    chkEstado.Enabled = False
    '    nudIVA.Enabled = False
    'End Sub
    'Private Sub habilitarEditables()
    '    txtNombre.Enabled = True
    '    txtAlias.Enabled = True
    '    cboTipoNIT.Enabled = True
    '    txtCorreo.Enabled = True
    '    chkEstado.Enabled = True
    '    txtCorreo.Enabled = True
    '    txtNIT.Enabled = True
    '    nudIVA.Enabled = True
    'End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If txtClase.Text.Trim.Length = 0 Then
                mensaje += "Clase" + vbCrLf
            End If
            If txtConcepto.Text.Trim.Length = 0 Then
                mensaje += "Concepto" + vbCrLf
            End If
            If txtPalabraClave.Text.Trim.Length = 0 Then
                mensaje += "Palabra Clave" + vbCrLf
            End If
            If txtAjuste.Text.Trim.Length = 0 Then
                mensaje += "Ajuste" + vbCrLf
            End If
            If txtCaractExtr.Text.Trim.Length = 0 Then
                mensaje += "Carácteres de Extracción" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function


    Private Sub inicializarModulo()
        btnNuevo.Visibility = BarItemVisibility.Never
        btnGuardar.Visibility = BarItemVisibility.Never
        btnEliminar.Visibility = BarItemVisibility.Never
        btnRefrescar.Visibility = BarItemVisibility.Never
    End Sub

    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1).ToString = "3" And accion(4).ToString = "1" Then 'Refrescar
                    btnRefrescar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "3" And accion(4).ToString = "2" Then 'Nuevo / Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "3" And accion(4).ToString = "4" Then 'Eliminar
                    btnEliminar.Visibility = BarItemVisibility.Always
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub limpiarGroup()
        numClaseIni.Value = 1
        numClaseFin.Value = 1
        numConcIni.Value = 1
        numConcFin.Value = 1
        txtPalabraC.Text = ""
        numAjuste.Value = 0
        numCaract.Value = 5
        txtClaseExt.Text = ""
        txtConceptoExt.Text = ""
        GridControlExtraccion.DataSource = Nothing
        btnAceptar.Enabled = False
        btnExtraerMuestra.Enabled = False
        btnExtraerParametros.Enabled = False
    End Sub


    Private Sub cargarClases()
        Try
            GridControlClases.DataSource = gsClases.NConsultarClases()    'Llenado del grid
            GridViewClases.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub cargarListado()
        Try
            If Not listado Is Nothing Then
                GridControlListado.DataSource = listado
                limpiarGroup()
                ModuleGlobales.Centrar(GroupBoxExtraer)
                btnExtraerMuestra.Enabled = False
                GroupBoxExtraer.Visible = True
            Else
                'Llamar al BackgroundWorker
                MessageBox.Show("Se preparará la información, este proceso podría tardar varios minutos, se ejecutará en segundo plano, se notificará una vez completa la preparación", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BackgroundWorkerListado.RunWorkerAsync()
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region
    Private Sub btnNuevaClase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        'Preparar el listado - Barra de progreso
        Nuevo()

        If GlobalesConexiones.estadoExterno.Equals("SI") Then
            btnAceptar.Enabled = False
            limpiarGroup()
            txtCadena.Text = ""
            cargarListado()
        Else
            MessageBox.Show("La conexión a la base de datos externa está deshabilitada," &
                            "contacte con el administrador de sistema, para modificar el archivo de conexión (confi.ini)", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frmClasesDispositivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarClases()
    End Sub

    Private Sub btnCerrarExtraer_Click(sender As Object, e As EventArgs) Handles btnCerrarExtraer.Click
        GroupBoxExtraer.Visible = False
    End Sub

    Private Sub BackgroundWorkerListado_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerListado.DoWork
        Try
            listado = CType(gsHistorico.NCargarListado(), DataTable)    'Llenado del grid
            Console.WriteLine("Se completó la carga")
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub BackgroundWorkerListado_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerListado.RunWorkerCompleted
        Try
            If e.Error IsNot Nothing Then
                MessageBox.Show("Ocurrio un error", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled Then
                MessageBox.Show("Carga cancelada", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Carga completada, abriendo la ventana de extración...", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GridControlListado.DataSource = listado
                limpiarGroup()
                ModuleGlobales.Centrar(GroupBoxExtraer)
                GroupBoxExtraer.Visible = True
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub


    Private Sub GridViewClases_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewClases.RowClick
        If GridViewClases.GetSelectedRows.Count = 1 And GridViewClases.IsFilterRow(e.RowHandle) = False And GridViewClases.IsGroupRow(e.RowHandle) = False Then
            txtID.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "ID_CLASE").ToString
            txtClase.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "CLASE").ToString
            txtConcepto.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "CONCEPTO").ToString
            txtPalabraClave.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "CHAR_DISPOSITIVO_INICIO").ToString
            txtAjuste.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "AJUSTE_CHAR_DISP_INICIO").ToString
            txtCaractExtr.Text = GridViewClases.GetRowCellValue(GridViewClases.FocusedRowHandle, "CARACTERES_EXTRACCION").ToString
        End If
    End Sub
    Private Sub GridViewListado_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewListado.RowClick
        If GridViewListado.GetSelectedRows.Count = 1 And GridViewListado.IsFilterRow(e.RowHandle) = False And GridViewListado.IsGroupRow(e.RowHandle) = False Then
            txtCadena.Text = GridViewListado.GetRowCellValue(GridViewListado.FocusedRowHandle, "HISTORY_ID").ToString
            limpiarGroup()
            btnExtraerParametros.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick

    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gsClases.NBuscar(txtClase.Text.ToString, txtConcepto.Text.ToString, txtPalabraClave.Text.ToString)
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clases.Concepto = txtConcepto.Text.ToString
            clases.Clase = txtClase.Text.ToString
            clases.CharInicioD = txtPalabraClave.Text.ToString
            clases.Ajuste = txtAjuste.Text.ToString
            clases.NumCaractExt = txtCaractExtr.Text.ToString
            clases.CreadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "CLASE: " & clases.Clase & vbCrLf &
                        "CONCEPTO: " & clases.Concepto & vbCrLf &
                        "PALABRA CLAVE: " & clases.CharInicioD, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gsClases.NInsertar(clases)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarClases()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarClases()
                    End If
                End If
            Else
                MessageBox.Show("Ya existe un registro con los parámetros ingresados", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub btnExtraerMuestra_Click(sender As Object, e As EventArgs) Handles btnExtraerMuestra.Click
        Try
            Dim datos As DataTable
            Dim clave As String = txtPalabraC.Text.ToString, caracExtr As Integer = CInt(numCaract.Value), ajuste As Integer = CInt(numAjuste.Value), clase As String = txtClaseExt.Text, concepto As String = txtConceptoExt.Text
            If clave <> "" And caracExtr > 0 And clase <> "" And concepto <> "" Then
                datos = gsHistorico.NCargarListaValvulas(clave, caracExtr.ToString, "%" + clase + "%", "%" + concepto + "%", ajuste.ToString)    'Llenado del grid
                GridControlExtraccion.DataSource = datos
                GridViewExtracion.BestFitColumns()
                If Not datos Is Nothing Then
                    btnAceptar.Enabled = True
                Else
                    btnAceptar.Enabled = False
                End If
            Else
                MessageBox.Show("No se proporcionaron parámetros validos", "Extracción cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnExtraerParametros_Click(sender As Object, e As EventArgs) Handles btnExtraerParametros.Click
        Try
            Dim cadena As String = txtCadena.Text.ToString
            Dim clase As String = "", concepto As String = ""
            clase = Mid(cadena, CInt(numClaseIni.Value), CInt(numClaseFin.Value) - CInt(numClaseIni.Value))
            concepto = Mid(cadena, CInt(numConcIni.Value), CInt(numConcFin.Value) - CInt(numConcIni.Value))
            If clase <> "" And concepto <> "" Then
                txtClaseExt.Text = clase
                txtConceptoExt.Text = concepto
                btnExtraerMuestra.Enabled = True
            Else
                MessageBox.Show("No se proporcionaron parámetros validos" &
                    "Es requerida la clase y concepto para el siguiente proceso", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            txtClase.Text = txtClaseExt.Text
            txtConcepto.Text = txtConceptoExt.Text
            txtPalabraClave.Text = txtPalabraC.Text
            txtAjuste.Text = CInt(numAjuste.Value).ToString
            txtCaractExtr.Text = CInt(numCaract.Value).ToString
            GroupBoxExtraer.Visible = False
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub btnEliminar_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles btnEliminar.ItemClick
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbCrLf + vbCrLf +
            "CLASE = " + txtClase.Text.ToString + "" + vbCrLf +
            "CONCEPTO = " + txtConcepto.Text.ToString + "", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim valor As String = txtID.Text.ToString
                Dim conteo As Integer = 0
                Dim tabla As DataSet = gsClases.NBuscarRegistrosClase(valor) 'BUSCA POR ID
                If Not tabla Is Nothing Then
                    For Each fila As DataRow In tabla.Tables(0).Rows
                        conteo = CInt(fila(0))
                    Next
                End If
                If conteo = 0 Then
                    Dim resp As String = gsClases.NEliminar(valor)
                    If resp = "" Then
                        MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarClases()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Existen registros ligados a esta clase, no se puede eliminar", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                mensajeError(ex)
            End Try
        End If
    End Sub
End Class
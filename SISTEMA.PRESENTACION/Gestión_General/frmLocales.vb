Imports System.Globalization
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmLocales
#Region "Variables Globales"
    Dim gestor As New NLocales
    Dim clase As New Locales
#End Region

#Region "Funciones y Metodos"
    Private Sub Nuevo()
        Limpiar()
        habilitarEditables()
        inhabilitarTodo()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        chkEstado.CheckState = CheckState.Checked
    End Sub
    Private Sub Modificar()
        habilitarEditables()
        inhabilitarTodo()
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
        txtID.Text = ""
        txtNombre.Text = ""
        txtAlias.Text = ""
        cboUbicacion.SelectedIndex = -1
        txtCodigo.Text = ""
        txtDireccion.Text = ""
        chkEstado.Checked = False
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    Private Sub inhabilitarEditables()
        txtNombre.Enabled = False
        txtAlias.Enabled = False
        cboUbicacion.Enabled = False
        txtCodigo.Enabled = False
        txtDireccion.Enabled = False
        chkEstado.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombre.Enabled = True
        txtAlias.Enabled = True
        cboUbicacion.Enabled = True
        txtCodigo.Enabled = True
        chkEstado.Enabled = True
        txtDireccion.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If txtCodigo.Text.Trim.Length = 0 Then
                mensaje += "Código del Local" + vbCrLf
            End If
            If txtNombre.Text.Trim.Length = 0 Then
                mensaje += "Nombre del Local" + vbCrLf
            End If
            If txtAlias.Text.Trim.Length = 0 Then
                mensaje += "Alias del Local" + vbCrLf
            End If
            If cboUbicacion.Text.Length = 0 Then
                mensaje += "Ubicación del Local" + vbCrLf
            End If
            If txtDireccion.Text.Trim.Length = 0 Then
                mensaje += "Dirección del Local" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function

    Private Sub cargarLocales()
        Try
            GridControlLocales.DataSource = gestor.NConsultar()   'Llenado del grid
            GridViewLocales.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Public Sub cargarUbicaciones()
        Try
            Dim datos As DataSet = gestor.NCargarUbicaciones()    'Llenado del combo
            If Not datos Is Nothing Then
                With cboUbicacion
                    .DisplayMember = "UBICACION" 'VALORES A MOSTRAR
                    .ValueMember = "UBICACION"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = datos.Tables(0)
                End With
                cboUbicacion.SelectedIndex = -1
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
                If accion(1).ToString = "3" And accion(4).ToString = "1" Then 'Refrescar
                    btnRefrescar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "3" And accion(4).ToString = "2" Then 'Nuevo / Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "3" And accion(4).ToString = "3" Then 'Modificar
                    btnModificar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "3" And accion(4).ToString = "4" Then 'Eliminar
                    btnEliminar.Visibility = BarItemVisibility.Always
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region

#Region "Acciones Generales"
    Private Sub frmLocales_Load(sender As Object, e As EventArgs) Handles Me.Load
        'inicializarModulo()
        'cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarUbicaciones()
        cargarLocales()
    End Sub

#End Region

#Region "Acciones de Botones"
    Private Sub GridViewLocales_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewLocales.RowClick
        Try
            If GridViewLocales.GetSelectedRows.Count = 1 And GridViewLocales.IsFilterRow(e.RowHandle) = False And GridViewLocales.IsGroupRow(e.RowHandle) = False Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "ID_LOCAL").ToString
                Dim nombre As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "NOMBRE_LOCAL").ToString
                Dim aliasL As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "ALIAS").ToString
                Dim codigo As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "CODIGO_LOCAL").ToString
                Dim ubicacion As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "UBICACION").ToString
                Dim direccion As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "DIRECCION").ToString
                Dim estado As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "ACTIVO").ToString
                Dim creadoPor As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                txtCodigo.Text = codigo.ToString
                txtNombre.Text = nombre.ToString
                txtAlias.Text = aliasL.ToString
                cboUbicacion.Text = ubicacion.ToString
                txtDireccion.Text = direccion.ToString
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
    Private Sub btnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Nuevo()
        cargarUbicaciones()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gestor.NBuscar(txtID.Text.ToString) 'BUSCA POR ID
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.Id = txtID.Text.ToString
            clase.Codigo = txtCodigo.Text.ToUpper.ToString
            clase.Nombre = txtNombre.Text.ToUpper.ToString
            clase.Alias = txtAlias.Text.ToString
            clase.Estado = CChar(IIf(chkEstado.CheckState = CheckState.Checked, "S", "N"))
            clase.Ubicacion = cboUbicacion.Text.ToString
            clase.Direccion = txtDireccion.Text.ToString
            clase.CreadoPor = ModuleGlobales.usuario
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                Dim tabla2 As DataTable = gestor.NBuscar2(txtCodigo.Text.Trim.ToString) 'BUSCA POR CODIGO
                If tabla2.Rows.Count = 0 Then
                    If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "CÓDIGO: " & clase.Codigo, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                        Dim resp As String = gestor.NInsertar(clase)
                        If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                            MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Guardar_Cancelar_Eliminar_Refrescar()
                            cargarLocales()
                        Else
                            MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cargarLocales()
                        End If
                    End If
                Else
                    MessageBox.Show("Código de Local ya existe, busque el registro para modificarlo", "Registro ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "NOMBRE: " & GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "NOMBRE_LOCAL").ToString & vbCrLf &
                        "CÓDIGO: " & GridViewLocales.GetRowCellValue(GridViewLocales.FocusedRowHandle, "CODIGO_LOCAL").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "CÓDIGO: " & clase.Codigo, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarLocales()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarLocales()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick
        Modificar()
        txtCodigo.Enabled = False
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbCrLf + vbCrLf +
            "ID = " + txtID.Text.ToString + "" + vbCrLf +
            "NOMBRE = " + txtNombre.Text.ToString + "", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim valor As String = txtID.Text.ToString
                Dim resp As String = gestor.NEliminar(valor)
                If resp = "" Then
                    MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Guardar_Cancelar_Eliminar_Refrescar()
                    cargarLocales()
                Else
                    MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                mensajeError(ex)
            End Try
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
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


#End Region
End Class
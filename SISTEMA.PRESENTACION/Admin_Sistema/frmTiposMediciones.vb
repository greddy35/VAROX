Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmTiposMediciones
#Region "Variables Globales"
    Dim gestor As New NTipoMed
    Dim clase As New TipoMed_TiposValv
#End Region

#Region "Funciones y Metodos"
    Private Sub Nuevo()
        Limpiar()
        habilitarEditables()
        inhabilitarTodo()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
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
        btnCancelar.Enabled = True
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
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        txtNombreTipo.Text = ""
        txtDescripcion.Text = ""
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
        txtMedida.Text = ""
        spValor.Text = "$1.0"
        cboUnidadMedida.SelectedIndex = -1
    End Sub

    Private Sub inhabilitarEditables()
        txtNombreTipo.Enabled = False
        txtDescripcion.Enabled = False
        cboUnidadMedida.Enabled = False
        spValor.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombreTipo.Enabled = True
        txtDescripcion.Enabled = True
        cboUnidadMedida.Enabled = True
        spValor.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If txtNombreTipo.Text.Trim.Length = 0 Then
                mensaje += "Nombre del Tipo de Medición" + vbCrLf
            End If
            If txtDescripcion.Text.Trim.Length = 0 Then
                mensaje += "Descripción del Tipo de Medición" + vbCrLf
            End If
            If cboUnidadMedida.SelectedIndex = -1 Then
                mensaje += "Unidad de medida" + vbCrLf
            End If
            If spValor.Text.ToString = "0" Or spValor.Text.ToString = "" Then
                mensaje += "Valor de Unidad de Medida" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function

    Private Sub cargarTiposMediciones()
        Try
            GridControlTiposMediciones.DataSource = gestor.NConsultar()   'Llenado del grid
            GridViewTiposMediciones.BestFitColumns()
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
                If accion(1).ToString = "91" And accion(4).ToString = "1" Then 'Nuevo / Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "91" And accion(4).ToString = "2" Then 'Modificar
                    btnModificar.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "91" And accion(4).ToString = "3" Then 'Eliminar
                    btnEliminar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString = "91" And accion(4).ToString = "14" Then 'Refrescar
                    btnRefrescar.Visibility = BarItemVisibility.Always
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region

#Region "Acciones Generales"
    Private Sub frmTiposMediciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicializarModulo()
        cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarTiposMediciones()
    End Sub
#End Region

#Region "Acciones de Botones"

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Nuevo()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarTiposMediciones()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gestor.NBuscar(txtID.Text.ToString)
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.Id = txtID.Text.ToString
            clase.Nombre = txtNombreTipo.Text.ToUpper.ToString
            clase.Descripcion = txtDescripcion.Text.ToString
            clase.Unidad = cboUnidadMedida.SelectedItem.ToString
            clase.Valor = CDec(spValor.Text)
            clase.CreadoPor = ModuleGlobales.usuario
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "UNIDAD: " & clase.Unidad & vbCrLf &
                        "VALOR UNIDAD: $" & clase.Valor & vbCrLf &
                        "DESCRIPCIÓN: " & clase.Descripcion, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NInsertar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarTiposMediciones()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarTiposMediciones()
                    End If
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "NOMBRE: " & GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "TIPO_MEDICION").ToString & vbCrLf &
                        "UNIDAD: " & GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "UNIDAD").ToString & vbCrLf &
                        "VALOR UNIDAD: $" & GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "VALOR_UNIDAD").ToString & vbCrLf &
                        "DESCRIPCIÓN: " & GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "DESCRIPCION").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "UNIDAD: " & clase.Unidad & vbCrLf &
                        "VALOR UNIDAD: $" & clase.Valor & vbCrLf &
                        "DESCRIPCIÓN: " & clase.Descripcion, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarTiposMediciones()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarTiposMediciones()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEliminar.ItemClick
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbCrLf + vbCrLf +
            "ID = " + txtID.Text.ToString + "" + vbCrLf +
            "NOMBRE = " + txtNombreTipo.Text.ToString + vbCrLf +
            "UNIDAD = " + cboUnidadMedida.SelectedItem.ToString + vbCrLf +
            "VALOR UNIDAD = " + spValor.Text.ToString +
            "", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim valor As String = txtID.Text.ToString
                Dim resp As String = gestor.NEliminar(valor)
                If resp = "" Then
                    MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Guardar_Cancelar_Eliminar_Refrescar()
                    cargarTiposMediciones()
                ElseIf resp.Contains("0x80131904") Then
                    MessageBox.Show("Existen registros ligados a este Tipo de Medición, no se puede eliminar", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                mensajeError(ex)
            End Try
        End If
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnModificar.ItemClick
        Modificar()
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub GridViewTiposMediciones_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewTiposMediciones.RowClick
        Try
            If GridViewTiposMediciones.GetSelectedRows.Count = 1 And GridViewTiposMediciones.IsFilterRow(e.RowHandle) = False And GridViewTiposMediciones.IsGroupRow(e.RowHandle) = False Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "ID_TIPO_MEDICION").ToString
                Dim nombre As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "TIPO_MEDICION").ToString
                Dim unidad As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "UNIDAD").ToString
                Dim valor As Decimal = CDec(GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "VALOR_UNIDAD").ToString)
                Dim descripcion As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "DESCRIPCION").ToString
                Dim creadoPor As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewTiposMediciones.GetRowCellValue(GridViewTiposMediciones.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                txtNombreTipo.Text = nombre.ToString
                cboUnidadMedida.SelectedItem = unidad
                spValor.Text = valor.ToString
                txtDescripcion.Text = descripcion.ToString
                txtCreadoPor.Text = creadoPor.ToString
                txtCreadoEl.Text = creadoEl.ToString
                txtModificadoPor.Text = modificadoPor.ToString
                txtModificadoEl.Text = modificadoEl.ToString
                ClicGrid()
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub cboUnidadMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadMedida.SelectedIndexChanged
        If cboUnidadMedida.SelectedIndex = -1 Then
            txtMedida.Text = ""
        Else
            Select Case cboUnidadMedida.SelectedItem.ToString
                Case "m3"
                    txtMedida.Text = "Metros cúbicos"
                Case "und"
                    txtMedida.Text = "Unidad"
            End Select
        End If
    End Sub


#End Region
End Class
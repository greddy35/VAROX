Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmTiposMediciones
#Region "Variables Globales"
    Dim gestor As New NTipoMed
    Dim clase As New TipoMed
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
    End Sub
    Private Sub ClicGrid()
        inhabilitarTodo()
        btnModificar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
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
    End Sub

    Private Sub inhabilitarEditables()
        txtNombreTipo.Enabled = False
        txtDescripcion.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombreTipo.Enabled = True
        txtDescripcion.Enabled = True
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
    Private Sub frmTiposMediciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        'inicializarModulo()
        'cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarTiposMediciones()
    End Sub
    Private Sub GridControlTiposMediciones_Click(sender As Object, e As EventArgs) Handles GridControlTiposMediciones.Click
        'Try
        '    If GridViewTiposMediciones.GetSelectedRows.Count = 1 Then
        '        'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
        '        Dim id As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("ID_TIPO_MEDICION").ToString
        '        Dim nombre As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("TIPO_MEDICION").ToString
        '        Dim descripcion As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("DESCRIPCION").ToString
        '        Dim creadoPor As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("CREADO_POR").ToString
        '        Dim creadoEl As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("CREADO_EL").ToString
        '        Dim modificadoPor As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("MODIFICADO_POR").ToString
        '        Dim modificadoEl As String = GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("MODIFICADO_EL").ToString
        '        txtID.Text = id.ToString
        '        txtNombreTipo.Text = nombre.ToString
        '        txtDescripcion.Text = descripcion.ToString
        '        txtCreadoPor.Text = creadoPor.ToString
        '        txtCreadoEl.Text = creadoEl.ToString
        '        txtModificadoPor.Text = modificadoPor.ToString
        '        txtModificadoEl.Text = modificadoEl.ToString
        '        ClicGrid()
        '    End If
        'Catch ex As Exception
        '    mensajeError(ex)
        'End Try
    End Sub

    Private Sub GridViewTiposMediciones_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridViewTiposMediciones.FocusedRowChanged
        Try
            If GridViewTiposMediciones.GetSelectedRows.Count = 1 Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "ID_TIPO_MEDICION").ToString
                Dim nombre As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "TIPO_MEDICION").ToString
                Dim descripcion As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "DESCRIPCION").ToString
                Dim creadoPor As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewTiposMediciones.GetRowCellValue(e.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                txtNombreTipo.Text = nombre.ToString
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
            clase.Nombre = txtNombreTipo.Text.ToUpper.ToString
            clase.Descripcion = txtDescripcion.Text.ToString
            clase.CreadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
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
                        "NOMBRE: " & GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("TIPO_MEDICION").ToString & vbCrLf &
                        "DESCRIPCIÓN: " & GridViewTiposMediciones.GetRow(GridViewTiposMediciones.FocusedRowHandle)("DESCRIPCION").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
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
            "NOMBRE = " + txtNombreTipo.Text.ToString + "", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim valor As String = txtID.Text.ToString
                Dim resp As String = gestor.NEliminar(valor)
                If resp = "" Then
                    MessageBox.Show("El registro de eliminó con éxito", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Guardar_Cancelar_Eliminar_Refrescar()
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


#End Region
End Class
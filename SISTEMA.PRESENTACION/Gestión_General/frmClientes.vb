Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmClientes
#Region "Variables Globales"
    Dim gestor As New NClientes
    Dim clase As New Clientes
    Dim tiposNit As New DataSet
#End Region

#Region "Funciones y Metodos"
    Private Sub Nuevo()
        Limpiar()
        habilitarEditables()
        inhabilitarTodo()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        txtNIT.Enabled = True
        chkEstado.CheckState = CheckState.Checked
    End Sub
    Private Sub Modificar()
        inhabilitarTodo()
        habilitarEditables()
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
        cboTipoNIT.SelectedIndex = -1
        txtNIT.Text = ""
        nudIVA.Value = 0
        txtIdNIT.Text = ""
        txtCodNIT.Text = ""
        txtCorreo.Text = ""
        chkEstado.Checked = False
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    Private Sub inhabilitarEditables()
        txtNombre.Enabled = False
        txtAlias.Enabled = False
        cboTipoNIT.Enabled = False
        txtCorreo.Enabled = False
        txtNIT.Enabled = False
        txtCorreo.Enabled = False
        chkEstado.Enabled = False
        nudIVA.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombre.Enabled = True
        txtAlias.Enabled = True
        cboTipoNIT.Enabled = True
        txtCorreo.Enabled = True
        chkEstado.Enabled = True
        txtCorreo.Enabled = True
        txtNIT.Enabled = True
        nudIVA.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If txtNombre.Text.Trim.Length = 0 Then
                mensaje += "Nombre del Cliente" + vbCrLf
            End If
            If txtAlias.Text.Trim.Length = 0 Then
                mensaje += "Alias del Ciente" + vbCrLf
            End If
            If cboTipoNIT.SelectedIndex = -1 Then
                mensaje += "Tipo NIT del Cliente" + vbCrLf
            Else
                If cboTipoNIT.SelectedIndex = 2 Then
                    If txtNIT.TextLength < 13 Then 'EXTRANJERO 42 DIGITOS
                        mensaje += "El NIT del Cliente" + vbCrLf
                    End If
                Else
                    If txtNIT.TextLength < 12 Then 'FORMATOS DE 12 DIGITOS
                        mensaje += "El NIT del Cliente" + vbCrLf
                    End If
                End If
            End If
            If txtCorreo.Text.Trim.Length = 0 Then
                mensaje += "Correo del Ciente" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function

    Private Sub cargarClientes()
        Try
            GridControlClientes.DataSource = gestor.NConsultar()   'Llenado del grid
            GridViewClientes.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Public Sub cargarTiposNIT()
        Try
            tiposNit = gestor.NCargarTiposNIT("%%")    'Llenado del combo
            If Not tiposNit Is Nothing Then
                With cboTipoNIT
                    .DisplayMember = "TIPO_NIT" 'VALORES A MOSTRAR
                    .ValueMember = "ID"       'VALORES DE ITEM SELECCIONADO 
                    .DataSource = tiposNit.Tables(0)
                End With
                cboTipoNIT.SelectedIndex = -1
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
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        'inicializarModulo()
        'cargarMenu()
        Guardar_Cancelar_Eliminar_Refrescar()
        cargarTiposNIT()
        cargarClientes()
    End Sub

#End Region

#Region "Acciones de Botones"

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Nuevo()
    End Sub
    Private Sub GridViewClientes_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewClientes.RowClick
        Try
            If GridViewClientes.GetSelectedRows.Count = 1 And GridViewClientes.IsFilterRow(e.RowHandle) = False And GridViewClientes.IsGroupRow(e.RowHandle) = False Then
                'EXTRAE Y MUESTRA LA INFORMACION DE LA FILA SELECCIONADO DEL GRID FRANJAS
                Dim id As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "ID_CLIENTE").ToString
                Dim nombre As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "NOMBRE_CLIENTE").ToString
                Dim aliasC As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "ALIAS_CLIENTE").ToString
                Dim idNIT As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "ID_NIT").ToString
                Dim codigoNIT As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "CODIGO_NIT").ToString
                Dim NIT As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "NIT").ToString
                Dim IVA As Integer = CInt(GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "IVA").ToString)
                Dim correo As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "CORREO").ToString
                Dim estado As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "ACTIVO").ToString
                Dim creadoPor As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "CREADO_POR").ToString
                Dim creadoEl As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "CREADO_EL").ToString
                Dim modificadoPor As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "MODIFICADO_POR").ToString
                Dim modificadoEl As String = GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "MODIFICADO_EL").ToString
                txtID.Text = id.ToString
                txtNombre.Text = nombre.ToString
                txtAlias.Text = aliasC.ToString
                txtIdNIT.Text = idNIT.ToString
                cboTipoNIT.SelectedValue = idNIT
                txtCodNIT.Text = codigoNIT.ToString
                txtNIT.Text = NIT.ToString
                nudIVA.Value = IVA
                txtCorreo.Text = correo.ToString
                chkEstado.Checked = CBool(IIf(estado.Equals("S"), True, False))
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

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gestor.NBuscar(txtID.Text.ToString)
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.Id = txtID.Text.ToString
            clase.Nombre = txtNombre.Text.ToUpper.ToString
            clase.Alias = txtAlias.Text.ToString
            clase.Estado = CChar(IIf(chkEstado.CheckState = CheckState.Checked, "S", "N"))
            clase.IdNit = CInt(txtIdNIT.Text.ToString)
            clase.Nit = txtNIT.Text.ToString
            clase.IVA = CInt(nudIVA.Value)
            clase.Correo = txtCorreo.Text.ToString
            clase.CreadoPor = ModuleGlobales.usuario
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "NIT: " & clase.Nit, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NInsertar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro almacenado con éxito", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarClientes()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarClientes()
                    End If
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "NOMBRE: " & GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "NOMBRE_CLIENTE").ToString & vbCrLf &
                        "NIT: " & GridViewClientes.GetRowCellValue(GridViewClientes.FocusedRowHandle, "NIT").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "NOMBRE: " & clase.Nombre & vbCrLf &
                        "NIT: " & clase.Nit, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gestor.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        cargarClientes()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cargarClientes()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick
        Modificar()
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
                    cargarClientes()
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
        cargarClientes()
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub cboTipoNIT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoNIT.SelectedIndexChanged
        Try 'AASIGNACION MANUAL DE CÓDIGO Y MASCARA SEGUN EL TIPO DE NIT
            If cboTipoNIT.SelectedIndex > -1 Then
                Dim id As Integer = CInt(cboTipoNIT.SelectedValue.ToString)

                For Each fila As DataRow In tiposNit.Tables(0).Rows
                    If CInt(fila(0)) = id Then
                        txtCodNIT.Text = fila(1).ToString
                        txtNIT.Mask = fila(3).ToString
                    End If
                Next
                txtIdNIT.Text = cboTipoNIT.SelectedValue.ToString
                txtNIT.Focus()
            Else
                txtIdNIT.Text = ""
                txtCodNIT.Text = ""
                txtNIT.Mask = ""
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
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
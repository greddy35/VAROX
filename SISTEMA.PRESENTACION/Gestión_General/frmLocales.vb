Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
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
        txtCodigo.Enabled = True
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
        chkEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtID.Text = ""
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtAlias.Text = ""
        chkEstado.Checked = False
        cboUbicacion.SelectedIndex = -1
        txtDireccion.Text = ""
        txtCreadoPor.Text = ""
        txtCreadoEl.Text = ""
        txtModificadoPor.Text = ""
        txtModificadoEl.Text = ""
    End Sub

    Private Sub inhabilitarEditables()
        txtNombre.Enabled = False
        txtCodigo.Enabled = False
        txtAlias.Enabled = False
        cboUbicacion.Enabled = False
        txtDireccion.Enabled = False
        chkEstado.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombre.Enabled = True
        txtAlias.Enabled = True
        cboUbicacion.Enabled = True
        txtDireccion.Enabled = True
        chkEstado.Enabled = True
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
            If cboUbicacion.SelectedIndex = -1 Then
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
            'GridControlLocales.DataSource = gestor.NConsultar()   'Llenado del grid
            GridViewLocales.BestFitColumns()
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
        cargarLocales()
    End Sub

    Private Sub GridViewLocales_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridViewLocales.FocusedRowChanged

    End Sub
#End Region

#Region "Acciones de Botones"

    Private Sub btnCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick

    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick

    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick

    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick

    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick

    End Sub

#End Region


End Class
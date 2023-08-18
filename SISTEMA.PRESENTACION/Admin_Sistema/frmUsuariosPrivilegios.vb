Imports System.Threading
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.DATOS
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmUsuariosPrivilegios

#Region "Variables Globles"
    'DECLARACIONES GENERALES
    Dim gsUsuarios As New NUsuarios
    Dim gsLogin As New NLogin
    Dim usuarios As New Usuarios
    'TABLAS DE PRIVILEGIOS
    Dim todos As DataSet
    Dim privi As DataSet
    'CLASES
    Dim clase As New Usuarios

    'VARIABLES PARA CONTROL DE LOS PROGRESBAR
    Dim ProgresoH As Integer = 0
    Dim ContadorH As Integer = 0
    Dim ProgresoC As Integer = 0
    Dim ContadorC As Integer = 0
    Dim totalH As Integer = 100
    Dim totalC As Integer = 100
#End Region

#Region "Funciones y Metodos"

    Private Sub Nuevo()
        Limpiar()
        inhabilitarTodo()
        habilitarEditables()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRefrescar.Enabled = True
        cboModulo.Enabled = False
        chkEstado.CheckState = CheckState.Checked
        txtUsuario.Enabled = True
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
        cboModulo.Enabled = False
    End Sub

    Private Sub inhabilitarTodo()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = False
        btnGuardarPrivilegios.Enabled = False
        chkEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtNombre.Text = ""
        chkEstado.Checked = False
        cboModulo.SelectedIndex = -1
    End Sub

    Private Sub inhabilitarEditables()
        txtNombre.Enabled = False
        txtUsuario.Enabled = False
        chkEstado.Enabled = False
        cboModulo.Enabled = False
    End Sub
    Private Sub habilitarEditables()
        txtNombre.Enabled = True
        chkEstado.Enabled = True
        cboModulo.Enabled = True
    End Sub

    Function ValidarCampos() As String
        Try
            Dim mensaje As String = "INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf
            If txtNombre.Text.Trim.Length = 0 Then
                mensaje += "Nombre del Usuario" + vbCrLf
            End If
            If txtUsuario.Text.Trim.Length = 0 Then
                mensaje += "Usuario" + vbCrLf
            End If
            Return mensaje
        Catch ex As Exception
            mensajeError(ex)
            Return Nothing
        End Try
    End Function
    Private Sub mostrarUsuarios()                   'METODO PARA CARGAR LOS USUARIOS
        Try
            GridControlUsuarios.DataSource = gsUsuarios.NConsultarUsuarios()    'Llenado del grid
            'GridColumn1.Visible = True
            'GridColumn2.Visible = True
            GridViewUsuarios.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Sub LimpiarRefrescar()
        txtUsuario.Text = ""
        txtUsuarioRol.Text = ""
        txtNombre.Text = ""
        txtIdUsuario.Text = ""
        txtSiglasModulo.Text = ""
        cboModulo.SelectedIndex() = 0
        cboRol.SelectedIndex() = 0
    End Sub
    Private Sub cargarcombos()                   'METODO PARA CARGAR COMBOBOX
        Try
            Dim modulos As DataSet = gsUsuarios.NCargarModulos()    'Llenado del combo

            With cboModulo
                .DataSource = modulos.Tables(0)
                .DisplayMember = "nombre_modulo" 'VALORES A MOSTRAR
                .ValueMember = "id_modulo"       'VALORES DE ITEM SELECCIONADO
            End With

            Dim roles As DataSet = gsUsuarios.NCargarRoles()    'Llenado del combo
            With cboRol
                .DataSource = roles.Tables(0)
                .DisplayMember = "nombre_rol" 'VALORES A MOSTRAR
                .ValueMember = "id_rol"       'VALORES DE ITEM SELECCIONADO
            End With
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Public Sub cargarOpciones(ByVal id_rol As String, ByVal id_usuario As String) 'CARGA LAS OPCIONES DE CADA MODULO SEGUN EL ELEGIDO
        Try
            todos = gsUsuarios.NCargarPrivilegiosTodos(txtidModulo.Text)
            privi = gsUsuarios.NCargarPrivilegios(id_rol, id_usuario)
            chkLstPrivilegios.Items.Clear()
            Dim filaTemp As DataRow
            'SE RECORREN TODOS LOS PRIVILEGIOS POSIBLES DEL SISTEMA POR MODULO SELECCIONADO
            For Each fila As DataRow In todos.Tables(0).Select("id_modulo='" & cboModulo.SelectedValue().ToString & "'") 'Rows()
                filaTemp = Nothing
                For Each filaP As DataRow In privi.Tables(0).Select("id_modulo='" + CStr(cboModulo.SelectedValue().ToString) + "' AND id_accion='" + CStr(fila("id_accion")) + "'") 'Rows()
                    'CUANDO EL PRIVILEGIO YA HA SIDO ASIGNADO AL USUARIO, RETORNA EL VALOR DE LA FILA A LA VARIABLE filaTemp
                    filaTemp = filaP
                Next
                If filaTemp IsNot Nothing Then 'SI SE RETORNA QUE LA ACCION YA ESTA ASIGNADA, ENCIENDE EL CHECK
                    chkLstPrivilegios.Items.Add(filaTemp("id_accion"), CStr(filaTemp("accion")) & " - (" & CStr(filaTemp("descripcion")) & ")", CheckState.Checked, True)
                Else 'SI RETORNA NOTHING DESHABILITA EL CHECK
                    chkLstPrivilegios.Items.Add(fila("id_accion"), CStr(fila("accion")) & " - (" & CStr(fila("descripcion")) & ")", CheckState.Unchecked, True)
                End If
            Next
            chkLstPrivilegios.Refresh()
        Catch ex As Exception
            mensajeError(ex)
        End Try
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

    Private Function cargarSiglasModulo() As String
        Dim id As String = "ND"
        Try
            Dim resultado As New DataTable
            resultado = gsUsuarios.NBuscarSiglasModulo(txtidModulo.Text)
            If (resultado.Rows.Count > 0) Then
                For Each row As DataRow In resultado.Rows
                    id = CStr(row("siglas_modulo"))
                    Return id
                Next
            Else
                Return id
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
        Return id
    End Function

    Public Sub cargarCheckListBox()
        Dim id_R, id_U As String
        txtidModulo.Text = cboModulo.SelectedValue().ToString
        id_R = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "id_rol").ToString
        id_U = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "id_usuario").ToString
        cargarOpciones(id_R, id_U)
    End Sub

    Private Sub inicializarModulo()
        btnNuevo.Visibility = BarItemVisibility.Never
        btnGuardar.Visibility = BarItemVisibility.Never
        btnModificar.Visibility = BarItemVisibility.Never
        btnRefrescar.Visibility = BarItemVisibility.Never
        btnGuardarPrivilegios.Visible = False
        GridViewUsuarios.Columns(0).Visible = False 'ASIGNAR ROL
        GridViewUsuarios.Columns(1).Visible = False 'CAMBIAR CONTRASEÑA
    End Sub

    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1).ToString.Equals("90") And accion(4).ToString.Equals("1") Then 'Nuevo/Guardar
                    btnNuevo.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString.Equals("90") And accion(4).ToString.Equals("2") Then 'Modificar
                    btnModificar.Visibility = BarItemVisibility.Always
                    btnGuardar.Visibility = BarItemVisibility.Always
                    GridViewUsuarios.Columns(1).Visible = True
                    GridViewUsuarios.Columns(1).VisibleIndex = 1
                End If
                If accion(1).ToString.Equals("90") And accion(4).ToString.Equals("10") Then 'Asignar Rol
                    GridViewUsuarios.Columns(0).Visible = True
                    GridViewUsuarios.Columns(0).VisibleIndex = 0
                End If
                If accion(1).ToString.Equals("90") And accion(4).ToString.Equals("11") Then 'Asignar Privilegios
                    btnGuardarPrivilegios.Visible = True
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

#End Region

#Region "Acciones Generales"
    Private Sub GridViewUsuarios_RowClick(sender As Object, e As RowClickEventArgs) Handles GridViewUsuarios.RowClick
        Try
            If GridViewUsuarios.GetSelectedRows.Count = 1 And GridViewUsuarios.IsFilterRow(e.RowHandle) = False Then
                txtUsuario.Text = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "usuario").ToString
                txtNombre.Text = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "nombre").ToString
                txtIdUsuario.Text = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "id_usuario").ToString
                Dim estado As String = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "activo").ToString
                chkEstado.Checked = CBool(IIf(estado.Equals("S"), True, False))
                cboModulo.SelectedIndex = 0
                ClicGrid()
            End If
        Catch ex As Exception
            mensajeError(ex)
            'Encapsula cualquier error
            cboModulo.Enabled = False
        End Try
    End Sub
#End Region

#Region "Acciones de Botones"

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmUsuariosPrivilegios_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicializarModulo()
        cargarMenu()
        mostrarUsuarios()   'CARGAMOS EL GRID DE USUARIOS
        cargarcombos()      'CARGAMOS LOS COMBO BOX
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub
    Private Sub btnAsignarRol_Click(sender As Object, e As EventArgs) Handles btnAsignarRol.Click
        If txtUsuarioRol.Text.Trim.Length > 0 And cboRol.SelectedIndex() > 0 Then
            usuarios.IdUsuario = txtIdUsuarioRol.Text
            usuarios.IdRol = cboRol.SelectedValue.ToString
            If gsUsuarios.NActualizarRolDeUsuario(usuarios) = True Then
                GroupBox2.Visible = False
                MessageBox.Show("Rol asignado correctamente", "Asignar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarRefrescar()
                mostrarUsuarios()
            Else
                GroupBox2.Visible = False
                MessageBox.Show("No se logró asignar el rol", "Asignación fállida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debes seleccionar un Rol a asignar", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCancelarAsignarRol_Click(sender As Object, e As EventArgs) Handles btnCancelarAsignarRol.Click
        LimpiarRefrescar()
        GroupBox2.Visible = False
    End Sub

    Private Sub btnGuardarPrivilegios_Click(sender As Object, e As EventArgs) Handles btnGuardarPrivilegios.Click
        Try
            If cboModulo.SelectedIndex > 0 Then
                If MessageBox.Show("¿Actualizar los privilegios seleccionados?", "Guardar Privilegios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim obj As New Usuarios
                    For indice = 0 To chkLstPrivilegios.Items.Count - 1
                        obj.IdUsuario = txtIdUsuario.Text.Trim
                        obj.IdModulo = txtidModulo.Text.Trim
                        obj.IdAccion = chkLstPrivilegios.GetItemValue(indice).ToString
                        'ACCION A REALIZAR SEGUN ESTADO DE CHECK
                        If chkLstPrivilegios.GetItemChecked(indice) Then 'Si la accion esta marcada = Insertar
                            'MsgBox("MARCADO: " & indice & " - " & chkLstPrivilegios.GetDisplayItemValue(indice).ToString & " - " & chkLstPrivilegios.GetItemValue(indice).ToString)
                            If gsUsuarios.NGuardarPrivilegios(obj, "INSERTAR") = False Then
                                MessageBox.Show("No se logró guardar el privilegio = " & obj.IdAccion & ", vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        Else 'Si la accion esta desmarcada = Eliminar
                            'MsgBox("DESMARCADO: " & indice & " - " & chkLstPrivilegios.GetDisplayItemValue(indice).ToString & " - " & chkLstPrivilegios.GetItemValue(indice).ToString & " - " & id_accion)
                            If gsUsuarios.NGuardarPrivilegios(obj, "ELIMINAR") = False Then
                                MessageBox.Show("No se logró eliminar el privilegio = " & obj.IdAccion & ", vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Next
                    cargarCheckListBox()
                    MessageBox.Show("Privilegios guardados correctamente" & vbLf &
                                vbLf & "Nota: Los privilegios de Rol no pueden ser sobreescritos," &
                                vbLf & "debe asignar el Rol DEFAULT si desea dejar la asignación" &
                                vbLf & "de Privilegios solo de manera personalizada", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Seleccione un Módulo para cargar las Acciones", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnCancelarRestablecerPass_Click(sender As Object, e As EventArgs)
        GroupBoxRestabPass.Visible = False
        txtPass.Text = ""
        txtPassConfirma.Text = ""
    End Sub

    Private Sub RepositoryItemButtonEditAsigRol_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditAsigRol.Click
        Try
            'txtUsuarioRol.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("usuario").ToString
            'txtIdUsuarioRol.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
            txtUsuarioRol.Text = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "usuario").ToString
            txtIdUsuarioRol.Text = GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "id_usuario").ToString

            If Not txtUsuarioRol.Text.Equals("ADMINISTRADOR") Then
                cboRol.SelectedIndex = 0
                Centrar(GroupBox2)
                GroupBox2.Visible = True
            Else
                MessageBox.Show("No se permite cambiar el Rol al usuario ADMINISTRADOR", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub RepositoryItemButtonEditCambPass_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditCambPass.Click
        Centrar(GroupBoxRestabPass)
        txtPass.PasswordChar = CChar("*")
        txtPassConfirma.PasswordChar = CChar("*")
        'txtPassActual.Text = ""
        txtPass.Text = ""
        txtPassConfirma.Text = ""
        GroupBoxRestabPass.Visible = True
    End Sub

    Private Sub btnCancelarRestablecerPass_Click_1(sender As Object, e As EventArgs) Handles btnCancelarRestablecerPass.Click
        GroupBoxRestabPass.Visible = False
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNuevo.ItemClick
        Nuevo()
    End Sub

    Private Sub btnCancelar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCancelar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Guardar_Cancelar_Eliminar_Refrescar()
        mostrarUsuarios()
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnModificar.ItemClick
        Modificar()
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

    Private Sub cboModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModulo.SelectedIndexChanged
        Try
            If cboModulo.SelectedIndex > 0 And GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "id_usuario").ToString.Length > 0 Then
                btnGuardarPrivilegios.Enabled = True
                cargarCheckListBox()
                Dim tabla As DataTable = gsUsuarios.NBuscarSiglasModulo(txtidModulo.Text)
                txtSiglasModulo.Text = cargarSiglasModulo()
            Else
                btnGuardarPrivilegios.Enabled = False
                txtSiglasModulo.Text = ""
                chkLstPrivilegios.Items.Clear()
                txtidModulo.Text = ""
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Try
            If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                'If GlobalesConexiones.contraseña_actual.ToString = txtPassActual.Text.Trim Then
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                Dim id As String = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                Dim usuario As String = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("usuario").ToString
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                'If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                If ValidarPassword(txtPass.Text.Trim) = True Then
                    If MessageBox.Show("¿Seguro desea restablecer la contraseña de:" & vbCrLf & vbCrLf &
                        "USUARIO: " & txtUsuario.Text.ToString & vbCrLf &
                        "NOMBRE: " & txtNombre.Text.ToString & vbCrLf &
                        "?", "Restablecer Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If gsUsuarios.NRestablecerPass(id.ToString, txtPass.Text) = True Then
                            MessageBox.Show("Contraseña restablecida correctamente", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'contraseña_actual = txtPassActual.Text.ToString
                            GroupBoxRestabPass.Visible = False
                        Else
                            MessageBox.Show("La contraseña no se logró cambiar", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("La contraseña no cumple con los requisitos mínimos de complejidad:" & vbLf &
                                        vbLf & "Mínimo: 8 caracteres" &
                                        vbLf & "Contener: 1 Mayúscula" &
                                        vbLf & "Contener: 2 Minúsculas" &
                                        vbLf & "Contener: 2 Números" &
                                        vbLf & "Contener: 2 caracteres especiales", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                'Else
                '    MessageBox.Show("La contraseña actual no es correcta, intente de nuevo", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
                'Else
                '    MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Else
                MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

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

    Private Sub btnGuardar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim msj As String = ValidarCampos() 'Se validan los campos obligatorios para llamar al guardado

        If msj <> ("INFORMACIÓN INCOMPLETA:" + vbCrLf + vbCrLf) Then
            MessageBox.Show(msj, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else                                'Si los datos estan completos, se llena la clase constructora con la informacion
            Dim tabla As DataTable = gsUsuarios.NBuscar(txtUsuario.Text.ToString)
            'CONSTRUIMOS LA CLASE CON LA INFORMACION A PROCESAR
            clase.IdUsuario = txtIdUsuario.Text.ToString
            clase.NombreUsuario = txtNombre.Text.ToString
            clase.Usuario = txtUsuario.Text.ToString
            clase.Estado = CChar(IIf(chkEstado.CheckState = CheckState.Checked, "S", "N"))
            clase.ModificadoPor = ModuleGlobales.usuario
            If tabla.Rows.Count = 0 Then
                If MessageBox.Show("¿Desea guardar el registro nuevo?" & vbCrLf & vbCrLf &
                        "USUARIO: " & clase.Usuario & vbCrLf &
                        "NOMBRE: " & clase.NombreUsuario, "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO INSERTAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gsUsuarios.NInsertar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro almacenado con éxito" & vbCrLf & vbCrLf &
                                        "Credenciales: " & vbCrLf &
                                        "Rol: DEFAULT" & vbCrLf &
                                        "Usuario: " & txtUsuario.Text & vbCrLf &
                                        "Contraseña: ex" & txtUsuario.Text.ToLower, "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        mostrarUsuarios()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrarUsuarios()
                    End If
                End If
            ElseIf tabla.Rows.Count > 0 Then
                If MessageBox.Show("¿Desea modificar el registro?" & vbCrLf & vbCrLf &
                        "---Actual---" & vbCrLf &
                        "USUARIO: " & GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "usuario").ToString & vbCrLf &
                        "NOMBRE: " & GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "nombre").ToString & vbCrLf &
                        "ACTIVO: " & GridViewUsuarios.GetRowCellValue(GridViewUsuarios.FocusedRowHandle, "activo").ToString & vbCrLf & vbCrLf &
                        "---Cambia á---" & vbCrLf &
                        "USUARIO: " & clase.Usuario & vbCrLf &
                        "NOMBRE: " & clase.NombreUsuario & vbCrLf &
                        "ACTIVO: " & clase.Estado, "Modificar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'LLAMAMOS AL METODO MODIFICAR ,ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
                    Dim resp As String = gsUsuarios.NModificar(clase)
                    If resp = "" Then       'Si se realiza la inserción nos retorna TRUE, e informamos al usuario
                        MessageBox.Show("Registro modificado con éxito", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Guardar_Cancelar_Eliminar_Refrescar()
                        mostrarUsuarios()
                    Else
                        MessageBox.Show("Ocurrió un error inesperado, intente de nuevo:" & vbCrLf & resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrarUsuarios()
                    End If
                End If
            End If

        End If
    End Sub


#End Region
End Class
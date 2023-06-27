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
    'Dim gsLogin As New NLogin
    Dim usuarios As New Usuarios
    'TABLAS DE PRIVILEGIOS
    Dim todos As DataSet
    Dim privi As DataSet

    'VARIABLES PARA CONTROL DE LOS PROGRESBAR
    Dim ProgresoH As Integer = 0
    Dim ContadorH As Integer = 0
    Dim ProgresoC As Integer = 0
    Dim ContadorC As Integer = 0
    Dim totalH As Integer = 100
    Dim totalC As Integer = 100
#End Region

#Region "Funciones y Metodos"
    Private Sub mostrarUsuarios()                   'METODO PARA CARGAR LOS USUARIOS
        Try
            GridControlUsuarios.DataSource = gsUsuarios.NConsultarUsuarios()    'Llenado del grid
            GridColumn1.Visible = True
            GridColumn2.Visible = True
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
        'Try
        '    Dim modulos As DataSet = gsUsuarios.NCargarModulos()    'Llenado del combo

        '    With cboModulo
        '        .DataSource = modulos.Tables(0)
        '        .DisplayMember = "nombre_modulo" 'VALORES A MOSTRAR
        '        .ValueMember = "id_modulo"       'VALORES DE ITEM SELECCIONADO
        '    End With

        '    Dim roles As DataSet = gsUsuarios.NCargarRoles()    'Llenado del combo
        '    With cboRol
        '        .DataSource = roles.Tables(0)
        '        .DisplayMember = "nombre_rol" 'VALORES A MOSTRAR
        '        .ValueMember = "id_rol"       'VALORES DE ITEM SELECCIONADO
        '    End With
        'Catch ex As Exception
        '    mensajeError(ex)
        'End Try
    End Sub

    'Public Sub cargarOpciones(ByVal id_rol As String, ByVal id_usuario As String) 'CARGA LAS OPCIONES DE CADA MODULO SEGUN EL ELEGIDO
    'Try
    '    todos = gsLogin.NCargarPrivilegiosTodos(txtidModulo.Text)
    '    privi = gsLogin.NCargarPrivilegios(id_rol, id_usuario)
    '    chkLstPrivilegios.Items.Clear()
    '    Dim filaTemp As DataRow
    '    'SE RECORREN TODOS LOS PRIVILEGIOS POSIBLES DEL SISTEMA POR MODULO SELECCIONADO
    '    For Each fila As DataRow In todos.Tables(0).Select("id_modulo='" & cboModulo.SelectedValue().ToString & "'") 'Rows()
    '        filaTemp = Nothing
    '        For Each filaP As DataRow In privi.Tables(0).Select("id_modulo='" & cboModulo.SelectedValue().ToString & "' AND id_accion='" & fila("id_accion") & "'") 'Rows()
    '            'CUANDO EL PRIVILEGIO YA HA SIDO ASIGNADO AL USUARIO, RETORNA EL VALOR DE LA FILA A LA VARIABLE filaTemp
    '            filaTemp = filaP
    '        Next
    '        If filaTemp IsNot Nothing Then 'SI SE RETORNA QUE LA ACCION YA ESTA ASIGNADA, ENCIENDE EL CHECK
    '            chkLstPrivilegios.Items.Add(filaTemp("id_accion"), filaTemp("accion") & " - (" & filaTemp("descripcion") & ")", 1, True)
    '        Else 'SI RETORNA NOTHING DESHABILITA EL CHECK
    '            chkLstPrivilegios.Items.Add(fila("id_accion"), fila("accion") & " - (" & fila("descripcion") & ")", 0, True)
    '        End If
    '    Next
    '    chkLstPrivilegios.Refresh()
    'Catch ex As Exception
    '    mensajeError(ex)
    'End Try
    'End Sub

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

    'Private Function cargarSiglasModulo() As String
    'Dim id As String = "ND"
    'Try
    '    Dim resultado As New DataTable
    '    resultado = gsUsuarios.NBuscarSiglasModulo(txtidModulo.Text)
    '    If (resultado.Rows.Count > 0) Then
    '        For Each row As DataRow In resultado.Rows
    '            id = CStr(row("siglas_modulo"))
    '            Return id
    '        Next
    '    Else
    '        Return id
    '    End If
    'Catch ex As Exception
    '    mensajeError(ex)
    'End Try
    'Return id
    'End Function

    Public Sub cargarCheckListBox()
        Dim id_R, id_U As String
        txtidModulo.Text = cboModulo.SelectedValue().ToString
        id_R = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_rol").ToString
        id_U = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
        'cargarOpciones(id_R, id_U)
    End Sub

    Private Sub inicializarModulo()
        'btnSincronizar.Visibility = False
        btnGuardarPrivilegios.Visible = False
        GridViewUsuarios.Columns(0).Visible = False 'ASIGNAR ROL
        GridViewUsuarios.Columns(1).Visible = False 'CAMBIAR CONTRASEÑA
    End Sub

    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1) = "9" And accion(4) = "10" Then 'Sincronizar
                    'btnSincronizar.Visibility = True
                End If
                If accion(1) = "9" And accion(4) = "13" Then 'Asignar Rol
                    GridViewUsuarios.Columns(0).Visible = True
                End If
                If accion(1) = "9" And accion(4) = "14" Then 'Cambiar Contraseña
                    GridViewUsuarios.Columns(1).Visible = True
                End If
                If accion(1) = "9" And accion(4) = "15" Then 'Asignar Privilegios
                    btnGuardarPrivilegios.Visible = True
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

#End Region

#Region "Acciones Generales"
    Private Sub GridViewUsuarios_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        Try
            txtUsuario.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("usuario").ToString
            txtNombre.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("nombre").ToString
            txtIdUsuario.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
            cboModulo.SelectedIndex = 0
            cboModulo.Enabled = True
        Catch ex As Exception
            mensajeError(ex)
            'Encapsula cualquier error
            cboModulo.Enabled = False
        End Try
    End Sub
#End Region

#Region "Acciones de Botones"
    'Private Sub btnSincronizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    'If MessageBox.Show("¿Desea sincronizar todos los usuarios de BioTimePro hacia Biosoft?", "Sincronizar Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '    'Mostramos un mensaje de espera
    '    Centrar(GroupBox1)
    '    GroupBox1.Visible = True
    '    Application.DoEvents()
    '    Thread.Sleep(2000)
    '    'LLAMAMOS AL METODO INSERTAR FRANJA, ENVIANDOLE LA CLASE CONSTRUIDA CON LA INFO
    '    If gsUsuarios.NSincronizarUsuarios() = True Then       'Si se realiza la sincronizacion nos retorna TRUE, e informamos al usuario
    '        'Thread.Sleep(5000)
    '        GroupBox1.Visible = False
    '        MessageBox.Show("Sincronización de Usuarios éxitosa", "Sincronizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        LimpiarRefrescar()
    '        mostrarUsuarios()
    '    Else
    '        GroupBox1.Visible = False
    '        MessageBox.Show("Ha ocurrido un error en el proceso de sincronización", "Proceso Fállido", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'mostrarFranjas()
    '    End If
    'End If
    'End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmUsuariosPrivilegios_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicializarModulo()
        cargarMenu()
        mostrarUsuarios()   'CARGAMOS EL GRID DE USUARIOS
        cargarcombos()      'CARGAMOS LOS COMBO BOX
        LimpiarRefrescar()
    End Sub
    'Private Sub btnAsignarRol_Click(sender As Object, e As EventArgs) Handles btnAsignarRol.Click
    'If txtUsuarioRol.Text.Trim.Length > 0 And cboRol.SelectedIndex() > 0 Then
    '    usuarios.IdUsuario = txtIdUsuarioRol.Text
    '    usuarios.IdRol = cboRol.SelectedValue.ToString
    '    If gsUsuarios.NActualizarRolDeUsuario(usuarios) = True Then
    '        GroupBox2.Visible = False
    '        MessageBox.Show("Rol asignado correctamente", "Asignar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        LimpiarRefrescar()
    '        mostrarUsuarios()
    '    Else
    '        GroupBox2.Visible = False
    '        MessageBox.Show("No se logró asignar el rol", "Asignación fállida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'Else
    '    MessageBox.Show("Debes seleccionar un Rol a asignar", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If

    'End Sub

    Private Sub btnCancelarAsignarRol_Click(sender As Object, e As EventArgs) Handles btnCancelarAsignarRol.Click
        LimpiarRefrescar()
        GroupBox2.Visible = False
    End Sub

    'Private Sub cboModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModulo.SelectedIndexChanged
    'Try
    '    If cboModulo.SelectedIndex > 0 And GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString.Length > 0 Then
    '        cargarCheckListBox()
    '        Dim tabla As DataTable = gsUsuarios.NBuscarSiglasModulo(txtidModulo.Text)
    '        txtSiglasModulo.Text = cargarSiglasModulo()
    '    Else
    '        txtSiglasModulo.Text = ""
    '        chkLstPrivilegios.Items.Clear()
    '        txtidModulo.Text = ""
    '    End If
    'Catch ex As Exception
    '    mensajeError(ex)
    'End Try
    'End Sub

    'Private Sub btnGuardarPrivilegios_Click(sender As Object, e As EventArgs) Handles btnGuardarPrivilegios.Click
    '    Try
    'If cboModulo.SelectedIndex > 0 Then
    '    Dim obj As New Usuarios
    '    For indice = 0 To chkLstPrivilegios.Items.Count - 1
    '        obj.IdUsuario = txtIdUsuario.Text.Trim
    '        obj.IdModulo = txtidModulo.Text.Trim
    '        obj.IdAccion = chkLstPrivilegios.GetItemValue(indice).ToString
    '        'ACCION A REALIZAR SEGUN ESTADO DE CHECK
    '        If chkLstPrivilegios.GetItemChecked(indice) Then 'Si la accion esta marcada = Insertar
    '            'MsgBox("MARCADO: " & indice & " - " & chkLstPrivilegios.GetDisplayItemValue(indice).ToString & " - " & chkLstPrivilegios.GetItemValue(indice).ToString)
    '            If gsUsuarios.NGuardarPrivilegios(obj, "INSERTAR") = False Then
    '                MessageBox.Show("No se logró guardar el privilegio = " & obj.IdAccion & ", vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If

    '        Else 'Si la accion esta desmarcada = Eliminar
    '            'MsgBox("DESMARCADO: " & indice & " - " & chkLstPrivilegios.GetDisplayItemValue(indice).ToString & " - " & chkLstPrivilegios.GetItemValue(indice).ToString & " - " & id_accion)
    '            If gsUsuarios.NGuardarPrivilegios(obj, "ELIMINAR") = False Then
    '                MessageBox.Show("No se logró eliminar el privilegio = " & obj.IdAccion & ", vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    Next
    '    cargarCheckListBox()
    '    MessageBox.Show("Privilegios guardados correctamente" & vbLf &
    '                    vbLf & "Nota: Los privilegios de Rol no pueden ser sobreescritos," &
    '                    vbLf & "para eliminar ese tipo de privilegios, se debe realizar" &
    '                    vbLf & "en las configuraciones de Rol", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'Else
    '    MessageBox.Show("Seleccione un Módulo para cargar las Acciones", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'End If
    'Catch ex As Exception
    '        mensajeError(ex)
    '    End Try
    'End Sub

    Private Sub btnCancelarRestablecerPass_Click(sender As Object, e As EventArgs)
        GroupBoxRestabPass.Visible = False
        txtPass.Text = ""
        txtPassConfirma.Text = ""
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs)
        Try
            If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                If GlobalesConexiones.contraseña_actual.ToString = txtPassActual.Text.Trim Then
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                    Dim id As String = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                    Dim usuario As String = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("usuario").ToString
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
                    If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                        If ValidarPassword(txtPass.Text.Trim) = True Then
                            If gsUsuarios.NRestablecerPass(id.ToString, txtPass.Text) = True Then
                                MessageBox.Show("Contraseña restablecida correctamente", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                contraseña_actual = txtPassActual.Text.ToString
                                GroupBoxRestabPass.Visible = False
                            Else
                                MessageBox.Show("La contraseña no se logró cambiar", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("La contraseña no cumple con los requisitos mínimos de complejidad:" & vbLf &
                                        vbLf & "Mínimo: 8 caracteres" &
                                        vbLf & "Contener: 1 Mayúscula" &
                                        vbLf & "Contener: 2 Minúsculas" &
                                        vbLf & "Contener: 2 Números" &
                                        vbLf & "Contener: 2 caracteres especiales", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        txtPassActual.Text = ""
                        MessageBox.Show("La contraseña actual no es correcta, intente de nuevo", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnVerPass_Click(sender As Object, e As EventArgs)
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

    Private Sub RepositoryItemButtonEditAsigRol_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditAsigRol.Click
        txtUsuarioRol.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("usuario").ToString
        txtIdUsuarioRol.Text = GridViewUsuarios.GetRow(GridViewUsuarios.FocusedRowHandle)("id_usuario").ToString
        cboRol.SelectedIndex = -1
        Centrar(GroupBox2)
        GroupBox2.Visible = True
    End Sub

    Private Sub RepositoryItemButtonEditCambPass_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditCambPass.Click
        Centrar(GroupBoxRestabPass)
        txtPass.PasswordChar = CChar("*")
        txtPassConfirma.PasswordChar = CChar("*")
        txtPassActual.Text = ""
        txtPass.Text = ""
        txtPassConfirma.Text = ""
        GroupBoxRestabPass.Visible = True
    End Sub

#End Region
End Class
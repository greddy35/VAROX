Imports SISTEMA.DATOS
Imports SISTEMA.NEGOCIO

Public Class frmCambioContraseña

    Dim gsUser As New NUsuarios
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

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click
        Try
            'AGREGAR VALIDACION DE CONTRASEÑA ACTUAL
            If txtPass.Text.Trim.Equals(txtPassConfirma.Text.Trim) Then
                If contraseña_actual.ToString = txtPassActual.Text.Trim Then
                    If ValidarPassword(txtPass.Text.Trim) = True Then
                        If gsUser.NRestablecerPass(idUsuario.ToString, txtPass.Text) = True Then
                            MessageBox.Show("Contraseña restablecida correctamente", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            contraseña_actual = txtPassActual.Text.ToString
                            Me.Close()
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

        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnCancelarRestablecerPass_Click(sender As Object, e As EventArgs) Handles btnCancelarRestablecerPass.Click
        txtPassActual.Text = ""
        txtPass.Text = ""
        txtPassConfirma.Text = ""
        Me.Close()
    End Sub
End Class
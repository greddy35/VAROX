Imports SISTEMA.DATOS

Public Module ModuleGlobales
    Public pbRegistros As String
    Public pbContador As String

#Region "Usuario y Roles"
    Public usuario As String, correo As String = GlobalesConexiones.correo
    Public nombreUsuario As String
    Public rol As String
    Public idRol As Integer
    Public idUsuario As Integer
    Public Privilegios As DataSet           'Almacena la informacion de privilegios del rol y de usuario
#End Region


    'Public Sub MostrarRibbonPrintPreview(ByVal grid As GridControl)
    '    ' Check whether the GridControl can be printed.
    '    If Not grid.IsPrintingAvailable Then
    '        MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
    '        Return
    '    End If

    '    'Print.
    '    grid.ShowRibbonPrintPreview()
    'End Sub

    'Public Sub ShowGridPreview(ByVal grid As GridControl)
    '    ' Check whether or not the Grid Control can be printed.
    '    If Not grid.IsPrintingAvailable Then
    '        MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
    '        Return
    '    End If
    '    ' Opens the Preview window.
    '    grid.ShowPrintPreview()
    'End Sub

    'Public Sub PrintGrid(ByVal grid As GridControl)
    '    ' Check whether the GridControl can be printed.
    '    If Not grid.IsPrintingAvailable Then
    '        MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
    '        Return
    '    End If

    '    ' Print.
    '    grid.Print()
    'End Sub

    Public Sub Centrar(ByVal Objeto As Object)
        ' Centrar un Formulario ...   
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar   
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With
            ' Centrar un control dentro del contenedor   
        Else
            ' referencia al control   
            Dim c As Control = CType(Objeto, Control)
            'le  establece el top y el Left dentro del Parent   
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Public Sub mensajeError(ex As Exception)
        MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo " + correo + vbLf & vbLf & "" +
                    "-> Metodo:" & vbLf & ex.TargetSite.ToString & vbLf & vbLf & "-> Ubicacion y linea de código: " & vbLf & ex.StackTrace.ToString & vbLf & vbLf & "-> Información adicional: " & vbLf & ex.Message, MsgBoxStyle.Critical)
    End Sub
End Module

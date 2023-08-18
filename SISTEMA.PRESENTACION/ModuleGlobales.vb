Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.Native
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
Imports SISTEMA.DATOS

Public Module ModuleGlobales
    Public pbRegistros As String
    Public pbContador As String
    Public listado As DataTable = Nothing

    Dim SaveFiledialog As New SaveFileDialog
    Dim OpenFiledialog As New OpenFileDialog
    Dim filename As String

#Region "Usuario y Roles"
    Public usuario As String, correo As String = GlobalesConexiones.correo
    Public nombreUsuario As String
    Public rol As String
    Public idRol As Integer
    Public idUsuario As Integer
    Public Privilegios As DataSet           'Almacena la informacion de privilegios del rol y de usuario

    'Contenerdores
    Public sql_DataSource As SqlDataSource = Nothing
    Public sql_spQuery As StoredProcQuery = Nothing
    Public fechI As String = ""
    Public fechF As String = ""
#End Region
    Public Sub AbrirReporte()
        filename = String.Empty
        With OpenFiledialog
            .Filter = "Archivo Reporte (*.repx)|*.repx"
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    filename = OpenFiledialog.FileName.ToString
                    ' A path to a report's definition file.
                    'Dim reportFilePath As String = "C:\FUENTES\ESS\Desarrollos\VAROX\SISTEMA.PRESENTACION\Reportería\Report2.repx"
                    ' Create a report instance.
                    Dim report As New XtraReport()
                    ' Load a report's layout from XML.
                    If System.IO.File.Exists(filename) Then
                        report.LoadLayoutFromXml(filename)
                        report.ShowRibbonPreview()
                    Else
                        MsgBox("El archivo no se puede abrir", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Ha cancelado la carga de reporte", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo informatica@tilapia.com" & vbNewLine & vbNewLine & String.Empty +
                    "-> Metodo:" & vbNewLine & ex.TargetSite.ToString & vbNewLine & vbNewLine & "-> Ubicacion y linea de código: " & vbNewLine & ex.StackTrace.ToString & vbNewLine & vbNewLine & "-> Información adicional: " & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            End Try
        End With
    End Sub

    Public Sub AbrirPlantilla(ByVal pivotGrid As PivotGridControl)
        filename = String.Empty
        With OpenFiledialog
            .Filter = "Archivo Plantilla VAROX (*.varox)|*.varox"
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    filename = OpenFiledialog.FileName.ToString
                    pivotGrid.RestoreLayoutFromXml(filename)
                Else
                    MsgBox("Ha Cancelado la Importacion de la Plantilla", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo informatica@tilapia.com" & vbNewLine & vbNewLine & String.Empty +
                    "-> Metodo:" & vbNewLine & ex.TargetSite.ToString & vbNewLine & vbNewLine & "-> Ubicacion y linea de código: " & vbNewLine & ex.StackTrace.ToString & vbNewLine & vbNewLine & "-> Información adicional: " & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            End Try
        End With
    End Sub
    Public Sub GuardarPlantilla(ByVal pivotGrid As PivotGridControl)
        filename = String.Empty
        With SaveFiledialog
            .Filter = "Archivo Plantilla VAROX (*.varox)|*.varox"
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    filename = SaveFiledialog.FileName.ToString
                    pivotGrid.SaveLayoutToXml(filename)

                Else
                    MsgBox("Ha Cancelado la Exportación de la Plantilla", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo informatica@tilapia.com" & vbNewLine & vbNewLine & String.Empty +
                     "-> Metodo:" & vbNewLine & ex.TargetSite.ToString & vbNewLine & vbNewLine & "-> Ubicacion y linea de código: " & vbNewLine & ex.StackTrace.ToString & vbNewLine & vbNewLine & "-> Información adicional: " & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            End Try
        End With
    End Sub

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
End Module

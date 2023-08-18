Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraBars
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
Imports SISTEMA.NEGOCIO
Imports System.ComponentModel
Imports System.Threading

Public Class frmReporteria

#Region "Variables Globales"
    Dim gestor As New NReportes
    'Dim UnidDisco As String = Mid(Environment.SystemDirectory.ToString, 1, 3)
    'VARIABLES PARA CONTROL DE LOS PROGRESBAR
    Dim Progreso As Integer = 0
    Dim Contador As Integer = 0
    Dim total As Integer = 100

    Dim fechIni As String = String.Empty
    Dim fechFin As String = String.Empty

    Private LayoutStream1 As System.IO.Stream = New System.IO.MemoryStream()
#End Region
#Region "Funciones y Metodos"
    Private Sub inicializarModulo()
        'Ribbone
        RibbonPageDatos.Visible = False
        RibbonPagePersonalizacion.Visible = False
        'Botones
        btnConstruir.Visibility = BarItemVisibility.Never
        btnRefrescar.Visibility = BarItemVisibility.Never
        btnImprimir.Visibility = BarItemVisibility.Never
        btnExportar.Visibility = BarItemVisibility.Never
        deDesde.Enabled = False
        deHasta.Enabled = False
        btnCorteGeneral.Visibility = BarItemVisibility.Never
        btnCorteCliente.Visibility = BarItemVisibility.Never
    End Sub
    Private Sub cargarMenu()
        Try
            For Each accion As DataRow In Privilegios.Tables(0).Rows()
                If accion(1).ToString.Equals("1") And accion(4).ToString.Equals("7") Then 'Construir/Procesar
                    btnConstruir.Visibility = BarItemVisibility.Always
                    deDesde.Enabled = True
                    deHasta.Enabled = True
                End If
                If accion(1).ToString.Equals("1") And accion(4).ToString.Equals("8") Then 'Imprimir
                    RibbonPageDatos.Visible = True
                    RibbonPagePersonalizacion.Visible = True
                    btnImprimir.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString.Equals("1") And accion(4).ToString.Equals("9") Then 'Exportar
                    RibbonPageDatos.Visible = True
                    RibbonPagePersonalizacion.Visible = True
                    btnExportar.Visibility = BarItemVisibility.Always
                End If
                If accion(1).ToString.Equals("1") And accion(4).ToString.Equals("14") Then 'Consultar
                    RibbonPageDatos.Visible = True
                    btnRefrescar.Visibility = BarItemVisibility.Always
                    btnCorteCliente.Visibility = BarItemVisibility.Always
                    btnCorteGeneral.Visibility = BarItemVisibility.Always
                    deDesde.Enabled = True
                    deHasta.Enabled = True
                End If
            Next
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
    Private Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function
    Private Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    Private Function obtenerFechas() As Boolean
        If deDesde.EditValue IsNot String.Empty And deHasta.EditValue IsNot String.Empty Then
            fechIni = CDate(deDesde.EditValue).ToString("yyyy-MM-dd 00:00:00.000")
            fechFin = CDate(deHasta.EditValue).ToString("yyyy-MM-dd 23:59:59.000")
            Return True
        Else
            Return False
        End If
    End Function
    Private Function consultarHistorico() As SqlDataSource
        Dim dsc As New SqlDataSource
        dsc = gestor.NConsultarHistorico_sqlds(fechIni, fechFin)
        ModuleGlobales.fechI = fechIni
        ModuleGlobales.fechF = fechFin
        PivotGridControl1.DataSource = dsc
        PivotGridControl1.DataMember = "R_consultarHistorico"

        SqlDataSource1 = dsc
        Return dsc
    End Function

    Public Sub ShowPivotGridPreview(ByVal pivotGrid As PivotGridControl)
        ' Verify that the Pivot Grid Control can be printed.
        If Not pivotGrid.IsPrintingAvailable Then
            MessageBox.Show("Missing DevExpress.XtraPrinting library", "Error")
            Return
        End If
        pivotGrid.ShowRibbonPrintPreview()
    End Sub

    Private Sub ImprimirPivot(ByVal pivotGrid As PivotGridControl, ByVal titulo As String)
        Try
            Centrar(GroupBox2)
            GroupBox2.Visible = True
            Dim export As String = System.IO.Path.GetTempPath() + titulo + "_ " + CDate(deDesde.EditValue).ToString("dd-MM-yyyy") + "_a_" + CDate(deHasta.EditValue).ToString("dd-MM-yyyy") + ".xlsx"
            If chkCombinar.Checked = True Then
                PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
            Else
                PivotGridControl1.OptionsPrint.MergeRowFieldValues = True
            End If
            If chkCombinar.Checked = True Then
                PivotGridControl1.OptionsView.ShowRowTotals = False
            Else
                PivotGridControl1.OptionsView.ShowRowTotals = True
            End If
            PivotGridControl1.Refresh()
            PivotGridControl1.ExportToXlsx(export)
            Application.DoEvents()
            Thread.Sleep(2000) 'Pausa para mostrar el mensaje de carga
            System.Diagnostics.Process.Start(export)
            GroupBox2.Visible = False
        Catch ex As Exception
            MsgBox("Error al generar", MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

#Region "Acciones Generales"
    Private Sub frmCorteGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarModulo()
        cargarMenu()

        deDesde.EditValue = PrimerDiaDelMes(Today)
        rideHasta.MinValue = PrimerDiaDelMes(Today)
        deHasta.EditValue = UltimoDiaDelMes(Today)
        rideHasta.MaxValue = CDate(deDesde.EditValue).AddMonths(2)
        PivotGridControl1.SaveLayoutToStream(LayoutStream1)
    End Sub

#End Region

#Region "Acciones de Botones"
    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAbrirPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAbrirPlantilla.ItemClick
        AbrirPlantilla(PivotGridControl1)
    End Sub

    Private Sub btnGuardarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarPlantilla.ItemClick
        GuardarPlantilla(PivotGridControl1)
    End Sub

    Private Sub btnRestaurarTabla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRestaurarTabla.ItemClick
        LayoutStream1.Position = 0
        PivotGridControl1.RestoreLayoutFromStream(LayoutStream1)
        chkCombinar.Checked = False
        chkMostrarTotales.Checked = True
    End Sub

    Private Sub deDesde_EditValueChanged(sender As Object, e As EventArgs) Handles deDesde.EditValueChanged
        rideHasta.MinValue = CDate(deDesde.EditValue)
        rideHasta.MaxValue = CDate(deDesde.EditValue).AddMonths(2)
        deHasta.EditValue = UltimoDiaDelMes(CDate(deDesde.EditValue).AddMonths(1))
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        If obtenerFechas() = True Then
            If consultarHistorico() Is Nothing Then
                MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione el rango de fechas a consultar", "Solicitud Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            'gsConceptoHorario.NInsertarDefault()
            Dim fechIni As String = CDate(deDesde.EditValue).ToString("yyyy-MM-dd 00:00:00.000")
            Dim fechFin As String = CDate(deHasta.EditValue).ToString("yyyy-MM-dd 23:59:59.999")
            Dim base As DataSet = Nothing
            Dim contenedor As DataSet = Nothing
            Dim listado As DataSet = Nothing
            Dim ins As Integer = 0
            Dim actu As Integer = 0
            listado = gestor.NCrearListadoValvulas(fechIni, fechFin)       'Obtenemos las vinculaciones a construir

            Dim flag As Boolean = False
            For Each fila As DataRow In listado.Tables(0).Rows()
                contenedor = gestor.NCargarValoresValvula(fila(4).ToString, fila(6).ToString, "%" + fila(2).ToString + "%", "%" + fila(3).ToString + "%", fila(5).ToString, "%" + fila(1).ToString + "%", fechIni, fechFin, CDate(fila(7)).ToString("yyyy-MM-dd 00:00:00.000"), CDate(fila(8)).ToString("yyyy-MM-dd 00:00:00.000"), fila(1).ToString)

                If contenedor.Tables(0).Rows.Count > 0 Then
                    Dim ultLect As Decimal = 0
                    Dim flag2 As Boolean = False
                    For Each consumo As DataRow In contenedor.Tables(0).Rows()
                        If flag2 = False Then
                            ultLect = CDec(consumo(2))
                            consumo.Item(3) = 0
                            flag2 = True
                        Else
                            consumo.Item(3) = CDec(consumo(2)) - ultLect
                            consumo.Item(5) = ultLect
                            If CDec(consumo.Item(3)) = 0 Then
                                consumo.Item(4) = "IGUAL"
                            ElseIf CDec(consumo.Item(3)) < 0 Then
                                consumo.Item(4) = "MENOR"
                            ElseIf CDec(consumo.Item(3)) > 0 Then
                                consumo.Item(4) = "MAYOR"
                            End If
                            ultLect = CDec(consumo(2))
                        End If
                    Next
                    contenedor.Tables(0).Rows(0).Delete()
                    contenedor.Tables(0).Rows(0).AcceptChanges()
                    If flag = True Then
                        base.Merge(contenedor)
                    Else
                        base = contenedor
                        flag = True
                    End If
                End If

            Next
            If Not base Is Nothing Then
                total = base.Tables(0).Rows().Count

                Dim resultado As New DataSet
                For Each fila As DataRow In base.Tables(0).Rows()      'Recorremos los Horarios para actualizar o insertar en la BD.BIOSOFT
                    Try
                        resultado = gestor.NBuscarHistorico(fila(0).ToString, CDate(fila(1).ToString).ToString("yyyy-MM-dd HH:mm:ss.fff"))
                        Dim id As Integer = 0
                        If resultado IsNot Nothing Then
                            If resultado.Tables(0).Rows.Count > 0 Then
                                For Each result As DataRow In resultado.Tables(0).Rows()
                                    id = CInt(result(0))
                                Next
                            End If
                        End If
                        If (id <> 0) Then
                            gestor.NModificar(id.ToString, fila(0).ToString, fila(1).ToString, fila(2).ToString, fila(3).ToString, fila(4).ToString, fila(5).ToString)
                            actu = actu + 1
                            'Console.WriteLine("Actualizado: " & fila(0).ToString)
                        Else
                            gestor.NInsertar(fila(0).ToString, fila(1).ToString, fila(2).ToString, fila(3).ToString, fila(4).ToString, fila(5).ToString)
                            ins = ins + 1
                            'Console.WriteLine("Insertado: " & fila(0).ToString)
                        End If
                        'Actualizamos el progreso
                        Contador = Contador + 1
                        BackgroundWorker1.ReportProgress(1)
                    Catch ex As Exception
                        Console.WriteLine("Error: " & ex.ToString)
                    End Try
                Next
                'Console.WriteLine("Registros Insertados: " & ins.ToString)
                'Console.WriteLine("Registros Actualizados: " & actu.ToString)
            Else
                MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            mensajeError(ex)
            e.Cancel = True
        End Try
        '---------------------------------------------------

        'Se ejecuta cuando cancelamos la operación
        '------------------------------------------------
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
            'Rollback'
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'CALCULAMOS EL PORCENTAJE DE PROGRESO SEGUN LOS REGISTROS A ACTUALIZAR
        Progreso = CInt((Contador / total) * 100)
        'Validamos si se pasa de 100%
        If Progreso >= 100 Then
            ProgressBar1.Value = 100
        Else
            ProgressBar1.Value = Progreso
        End If
        txtRegistros.Text = total.ToString
        txtProgreso.Text = String.Empty + Progreso.ToString + "%"
        txtProcesados.Text = Contador.ToString
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show("Ocurrio un error inesperado" + e.Error.ToString, "Construcción de vista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Cancelled Then
            MessageBox.Show("Construcción Cancelada", "Construcción de vista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Construcción de vista completada", "Construcción de vista", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Reiniciamos los componentes
        ProgressBar1.Value = 0
        txtRegistros.Text = "0"
        txtProgreso.Text = "0%"
        txtProcesados.Text = "0"
        Contador = 0
        GroupBox1.Visible = False
        'llenarPivot()         
    End Sub

    Private Sub btnConstruir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConstruir.ItemClick
        If deDesde.EditValue IsNot String.Empty Or deHasta.EditValue IsNot String.Empty Then
            If MessageBox.Show("El proceso podría tardar unos minutos" & vbCrLf &
                        "en preparar la información." & vbCrLf & vbCrLf &
                        "Evite exeder la carga de 30 días de rango", "Cargar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ModuleGlobales.Centrar(GroupBox1)
                GroupBox1.Visible = True
                BackgroundWorker1.RunWorkerAsync()
            End If

        Else
            MessageBox.Show("Seleccione el rango de fechas antes de refrescar", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub chkCombinar_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkCombinar.CheckedChanged
        Try
            If chkCombinar.Checked = True Then
                PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
            Else
                PivotGridControl1.OptionsPrint.MergeRowFieldValues = True
            End If
        Catch ex As Exception
            MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo informatica@tilapia.com" & vbNewLine & vbNewLine & String.Empty +
                    "-> Metodo:" & vbNewLine & ex.TargetSite.ToString & vbNewLine & vbNewLine & "-> Ubicacion y linea de código: " & vbNewLine & ex.StackTrace.ToString & vbNewLine & vbNewLine & "-> Información adicional: " & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkMostrarTotales_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkMostrarTotales.CheckedChanged
        Try
            If chkMostrarTotales.Checked = True Then
                PivotGridControl1.OptionsView.ShowRowTotals = True
            Else
                PivotGridControl1.OptionsView.ShowRowTotals = False
            End If
        Catch ex As Exception
            MsgBox("El sistema detecto un error y no puede proceder... Comuniquese con el administrador del sistema y muestrele este mensaje, puede enviarlo mediante el correo informatica@tilapia.com" & vbNewLine & vbNewLine & String.Empty +
                    "-> Metodo:" & vbNewLine & ex.TargetSite.ToString & vbNewLine & vbNewLine & "-> Ubicacion y linea de código: " & vbNewLine & ex.StackTrace.ToString & vbNewLine & vbNewLine & "-> Información adicional: " & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        Try
            ShowPivotGridPreview(PivotGridControl1)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        Try
            ImprimirPivot(PivotGridControl1, "CorteGeneral")
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCorteGeneral_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorteGeneral.ItemClick
        ModuleGlobales.sql_DataSource = SqlDataSource1
        Dim report = New rptCorteGeneral()
        report.Parameters("fechaIni").Value = fechIni
        report.Parameters("fechaIni").Description = "Fecha Desde:"
        'report.Parameters("fechaIni").Enabled = False
        report.Parameters("fechaFin").Value = fechFin
        report.Parameters("fechaFin").Description = "Fecha Hasta:"
        'report.Parameters("fechaFin").Enabled = False

        report.ShowRibbonPreview()
    End Sub

    Private Sub btnCorteCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorteCliente.ItemClick
        ModuleGlobales.sql_DataSource = SqlDataSource1
        Dim report = New rptCortePorCliente()
        report.Parameters("fechaIni").Value = fechIni
        report.Parameters("fechaIni").Description = "Fecha Desde:"
        'report.Parameters("fechaIni").Enabled = False
        report.Parameters("fechaFin").Value = fechFin
        report.Parameters("fechaFin").Description = "Fecha Hasta:"
        'report.Parameters("fechaFin").Enabled = False
        'report.Parameters("cliente").Value = {"3-928-937367", "02-0710-0193"}
        report.ShowRibbonPreview()
    End Sub


#End Region

End Class
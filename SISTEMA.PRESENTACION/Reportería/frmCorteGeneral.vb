Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraBars
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.Design.XtraTabControl
Imports DevExpress.XtraReports.UI
Imports SISTEMA.DATOS
Imports SISTEMA.NEGOCIO
Imports System.Collections
Imports System.ComponentModel
Imports System.Threading

Public Class frmReporteria

#Region "Variables Globales"
    Dim gestor As New NReportes
    Dim gestorH As New NHistorico
    Dim gestorC As New NClases
    'Dim UnidDisco As String = Mid(Environment.SystemDirectory.ToString, 1, 3)
    'VARIABLES PARA CONTROL DE LOS PROGRESBAR
    Dim Progreso As Integer = 0
    Dim Contador As Integer = 0
    Dim total As Integer = 1
    Dim notificacion As String = ""

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
        Try
            Dim dsc As New SqlDataSource
            dsc = gestor.NConsultarHistorico_sqlds(fechIni, fechFin)
            ModuleGlobales.fechI = fechIni
            ModuleGlobales.fechF = fechFin
            PivotGridControl1.DataSource = dsc
            PivotGridControl1.DataMember = "R_consultarHistorico"
            SqlDataSource1 = dsc
            Return dsc
        Catch ex As Exception
            Return Nothing
        End Try

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

    Private Sub cargarConstruccion()
        If obtenerFechas() = True Then
            If consultarHistorico() Is Nothing Then
                MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione el rango de fechas a consultar", "Solicitud Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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
        cargarConstruccion()

    End Sub

    Private Sub btnDetenerCalculo_Click(sender As Object, e As EventArgs) Handles btnDetenerCalculo.Click
        If MessageBox.Show("El proceso se detendrá," & vbCrLf &
                        "y los registros no guardados se perderán." & vbCrLf & vbCrLf &
                        "¿Seguro que desea detener el proceso?", "Detener Cálculo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
            If BackgroundWorker1.IsBusy Then

                If BackgroundWorker1.WorkerSupportsCancellation Then
                    GroupBox1.Visible = False
                    BackgroundWorker1.CancelAsync()
                    BackgroundWorker1.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim fechIni As String = CDate(deDesde.EditValue).ToString("yyyy-MM-dd 00:00:00.000")
            Dim fechFin As String = CDate(deHasta.EditValue).ToString("yyyy-MM-dd 23:59:59.999")
            total = 1
            Dim base As DataSet = Nothing
            Dim contenedor As DataSet = Nothing
            Dim listado As DataSet = Nothing
            Dim ins As Integer = 0
            Dim actu As Integer = 0
            notificacion = "Preparando información a calcular..."
            BackgroundWorker1.ReportProgress(1)
            listado = gestor.NCrearListadoValvulas(fechIni, fechFin)       'Obtenemos las vinculaciones a construir
            notificacion = "Cálculando lecturas de: " + listado.Tables(0).Rows().Count.ToString + " dispositivos..."
            BackgroundWorker1.ReportProgress(1)
            'Thread.Sleep(500)
            If Not listado Is Nothing Then
                Dim flag As Boolean = False
                For Each fila As DataRow In listado.Tables(0).Rows()
                    contenedor = gestorH.NCargarValoresValvula(fila(4).ToString, fila(6).ToString, "%" + fila(2).ToString + "%", "%" + fila(3).ToString + "%", fila(5).ToString, "%" + fila(1).ToString + "%", fechIni, fechFin, CDate(fila(7)).ToString("yyyy-MM-dd 00:00:00.000"), CDate(fila(8)).ToString("yyyy-MM-dd 00:00:00.000"), fila(1).ToString)
                    If contenedor.Tables(0).Rows.Count > 1 Then 'La consulta siempre genera un registro por defecto, por eso se busca si es mayor a 1
                        'Se ejecuta cuando cancelamos la operación
                        '------------------------------------------------
                        notificacion = "Procesando (" + contenedor.Tables(0).Rows().Count.ToString + ") lecturas del dispositivo: (" + fila(1).ToString + ")..."
                        BackgroundWorker1.ReportProgress(1)
                        If BackgroundWorker1.CancellationPending Then
                            e.Cancel = True
                            Return
                        End If
                        Dim ultLect As Decimal = 0
                        Dim flag2 As Boolean = False
                        Dim flag3 As Boolean = False
                        'notificacion = "Preparando: " + contenedor.Tables(0).Rows().Count.ToString + " registros "
                        'BackgroundWorker1.ReportProgress(1)
                        'Thread.Sleep(500)
                        Dim cont As Integer = 1
                        For Each consumo As DataRow In contenedor.Tables(0).Rows()
                            If BackgroundWorker1.CancellationPending Then
                                e.Cancel = True
                                Return
                            End If
                            If flag2 = False Then
                                consumo.Item(3) = 0
                                flag2 = True
                            Else
                                Dim flag4 As Boolean = False
                                If fila(9).ToString.Equals("und") And Not consumo(2).ToString.Equals("0") Then 'Si es tipo BTU y hay valor de medida
                                    If flag3 = False Then
                                        ultLect = ((CDec(consumo(2)) / 1000000) * 1000) 'Conversion a BTU
                                        flag3 = True
                                    End If
                                    'ultLect = ((CDec(consumo(2)) / 1000000) * 1000) 'Conversion a BTU
                                    consumo.Item(3) = ((CDec(consumo(2)) / 1000000) * 1000) - ultLect
                                    consumo.Item(2) = ((CDec(consumo(2)) / 1000000) * 1000)
                                    If CDec(consumo.Item(3)) = 0 Then
                                        consumo.Item(3) = 0
                                    End If
                                    'ultLect = CDec(consumo.Item(2)) 'Conversion a BTU
                                ElseIf Not fila(9).ToString.Equals("und") Then ' Cuando no es tipo BTU
                                    If flag3 = False Then
                                        ultLect = CDec(consumo(2))
                                        flag3 = True
                                    End If
                                    consumo.Item(3) = CDec(consumo(2)) - ultLect
                                    'ultLect = CDec(consumo(2))
                                Else
                                    'ultLect = CDec(consumo(2))
                                    consumo.Item(3) = 0
                                End If
                                'consumo.Item(3) = CDec(consumo(2)) - ultLect
                                consumo.Item(5) = ultLect
                                '-----------------CRITERIO PARA CADA TIPO DE RESULTADO DE CONSUMO-------------------
                                If ultLect > 0 And CDec(consumo(2)) = 0 Then
                                    consumo.Item(3) = 0
                                    consumo.Item(4) = "ERROR"
                                    flag4 = True
                                ElseIf CDec(consumo.Item(3)) = 0 Then
                                    consumo.Item(4) = "IGUAL"
                                ElseIf CDec(consumo.Item(3)) < 0 Then
                                    consumo.Item(4) = "MENOR"
                                ElseIf CDec(consumo.Item(3)) > 0 Then
                                    consumo.Item(4) = "MAYOR"
                                End If
                                If flag4 = True Then 'Si es un registro erroneo por valores de medicion, mantiene la lectura
                                    flag4 = False
                                Else
                                    ultLect = CDec(consumo(2)) 'Actualiza la lectura actual para el siguiente registro
                                End If

                            End If
                            cont = cont + 1
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
                    If total > 0 Then
                        notificacion = "Se registrarán: " + total.ToString + " registros"
                        BackgroundWorker1.ReportProgress(1)
                        'Thread.Sleep(500)
                        Dim resultado As New DataSet
                        Dim transacciones As New ArrayList 'Almacena las transacciones a ejecutar
                        For Each fila As DataRow In base.Tables(0).Rows()      'Recorremos los Horarios para actualizar o insertar en la BD.BIOSOFT
                            Try
                                resultado = gestor.NBuscarHistorico(fila(0).ToString, CDate(fila(1).ToString).ToString("yyyy-MM-dd HH:mm:ss.fff"))
                                Dim id As Integer = 0
                                If resultado IsNot Nothing Then
                                    If resultado.Tables(0).Rows.Count > 0 Then
                                        For Each result As DataRow In resultado.Tables(0).Rows()
                                            id = CInt(result(0))
                                            'Existe y hay que actualizarlo
                                            transacciones.Add("UPDATE  [dbo].[R_HISTORICO_REAL] SET [TIMESTAMP] = '" + fila(1).ToString + "',[DISPOSITIVO] = '" + fila(0).ToString + "',[LECT_ANT] = '" + fila(5).ToString + "',[VALUE] = '" + fila(2).ToString + "',[CONSUMO] = '" + fila(3).ToString + "',[REVISION] = '" + fila(4).ToString + "' WHERE ID = " + id.ToString + "")
                                            actu = actu + 1
                                            Console.WriteLine("Actualizado: " & fila(0).ToString)
                                        Next
                                    End If
                                Else 'No existe y hay que insertarlo
                                    'REVISAR ORDEN DE CAMPOS
                                    transacciones.Add("INSERT INTO [dbo].[R_HISTORICO_REAL] ([TIMESTAMP],[DISPOSITIVO],[LECT_ANT],[VALUE],[CONSUMO],[REVISION]) VALUES ('" + fila(1).ToString + "','" + fila(0).ToString + "','" + fila(5).ToString + "','" + fila(2).ToString + "','" + fila(3).ToString + "','" + fila(4).ToString + "')")
                                    ins = ins + 1
                                    Console.WriteLine("Insertado: " & fila(0).ToString)
                                End If
                                'Metodo viejo
                                'If (id <> 0) Then
                                '    gestor.NModificar(id.ToString, fila(0).ToString, fila(1).ToString, fila(2).ToString, fila(3).ToString, fila(4).ToString, fila(5).ToString)
                                '    actu = actu + 1
                                '    Console.WriteLine("Actualizado: " & fila(0).ToString)
                                'Else
                                '    gestor.NInsertar(fila(0).ToString, fila(1).ToString, fila(2).ToString, fila(3).ToString, fila(4).ToString, fila(5).ToString)
                                '    ins = ins + 1
                                '    Console.WriteLine("Insertado: " & fila(0).ToString)
                                'End If
                                'Actualizamos el progreso
                                Contador = Contador + 1
                                notificacion = "Registrando: " + Contador.ToString + " registros de: " + total.ToString
                                BackgroundWorker1.ReportProgress(1)
                                'Thread.Sleep(500)
                            Catch ex As Exception
                                Console.WriteLine("Error: " & ex.ToString)
                            End Try
                        Next

                        'PREGUNTA DE CONFIRMACION PARA EJECUTAR LAS TRANSACCIONES GENERADAS
                        If MessageBox.Show("Se generaron:" & vbCrLf & vbCrLf &
                            "Registros a Insertar: " & vbCrLf &
                            "Registros a Actualizar: " & vbCrLf & vbCrLf &
                            "¿Seguro de guardar en Sistema todos los registros calculados en el proceso de construcción?" & vbCrLf &
                            "(SI) Aceptar, (NO) Cancelar", "Guardar Construcción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            If gestorC.NEjecutarTransacciones(transacciones) = 1 Then
                                MsgBox("Se registraron todos los registros", MsgBoxStyle.Information)
                            Else
                                MsgBox("Ocurrio un error al registrar en la base de datos", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("Se canceló el guardado de la construcción de datos", MsgBoxStyle.Exclamation)
                            Return
                        End If

                        'Console.WriteLine("Registros Insertados: " & ins.ToString)
                        'Console.WriteLine("Registros Actualizados: " & actu.ToString)Else 
                    Else
                        MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If BackgroundWorker1.CancellationPending Then
                    e.Cancel = True
                    Return
                End If
                MessageBox.Show("No se encontraron datos en el rango seleccionado", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            mensajeError(ex)
            e.Cancel = True
        End Try
        '---------------------------------------------------

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'CALCULAMOS EL PORCENTAJE DE PROGRESO SEGUN LOS REGISTROS A ACTUALIZAR
        Try
            Progreso = CInt((Contador / total) * 100)
        Catch ex As Exception
            Progreso = 0
        End Try
        'Progreso = CInt((Contador / total) * 100)
        'Validamos si se pasa de 100%
        If Progreso >= 100 Then
            ProgressBar1.Value = 100
        Else
            ProgressBar1.Value = Progreso
        End If
        txtRegistros.Text = total.ToString
        txtProgreso.Text = String.Empty + Progreso.ToString + "%"
        txtProcesados.Text = Contador.ToString
        lblNotificacion.Text = notificacion
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            Me.BringToFront()
            MessageBox.Show("Ocurrio un error inesperado" + e.Error.ToString, "Construcción de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.Cancelled Then
            Me.BringToFront()
            MessageBox.Show("Construcción Cancelada", "Construcción de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.BringToFront()
            MessageBox.Show("Proceso de Construcción de datos terminado", "Construcción de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarConstruccion()
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
        If Not BackgroundWorker1.IsBusy Then
            If deDesde.EditValue IsNot String.Empty Or deHasta.EditValue IsNot String.Empty Then
                If MessageBox.Show("El proceso podría tardar unos minutos" & vbCrLf &
                            "en preparar la información." & vbCrLf & vbCrLf &
                            "Evite exceder la carga de 30 días de rango", "Cargar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ModuleGlobales.Centrar(GroupBox1)
                    GroupBox1.Visible = True
                    BackgroundWorker1.RunWorkerAsync()
                End If

            Else

                MessageBox.Show("Seleccione el rango de fechas antes de refrescar", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Ya existe un proceso de cálculo en progreso, espere que finalice para iniciar otro", "Procesos en progreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupBox1.Visible = True
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
        report.RequestParameters = False

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
        report.ShowRibbonPreview()
    End Sub

    Private Sub btnCorteEjecutivo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCorteEjecutivo.ItemClick
        ModuleGlobales.sql_DataSource = SqlDataSource1
        Dim report = New rptCorteEjecutivo()
        report.Parameters("fechaIni").Value = fechIni
        report.Parameters("fechaIni").Description = "Fecha Desde:"
        report.Parameters("fechaFin").Value = fechFin
        report.Parameters("fechaFin").Description = "Fecha Hasta:"
        report.Parameters("fechaFin").Value = fechFin
        report.ShowRibbonPreview()
    End Sub

    Private Sub btnOcultarVentana_Click(sender As Object, e As EventArgs) Handles btnOcultarVentana.Click
        If MessageBox.Show("Se ocultará la ventana de progeso," & vbCrLf &
                        "podrá trabajar otras tareas mientras se completa el proceso en segundo plano." & vbCrLf & vbCrLf &
                        "Se notificará una vez haya terminado el proceso." & vbCrLf & vbCrLf &
                        "¿Seguro que desea ocultar la ventana de progreso?", "Ocultar Progreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GroupBox1.Visible = False
        End If
    End Sub

#End Region

End Class
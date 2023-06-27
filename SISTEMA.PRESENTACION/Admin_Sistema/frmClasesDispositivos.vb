Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports DevExpress.XtraGrid.Views.Grid
Imports SISTEMA.ENTIDADES
Imports SISTEMA.NEGOCIO

Public Class frmClasesDispositivos

#Region "Globales"
    'Clases
    Dim clases As New Clases
    Dim gsClases As New NClases
    'Variables

#End Region

#Region "Funciones"

#End Region

#Region "Metodos"
    Private Sub limpiar()
        txtID.Text = ""
        txtClase.Text = ""
        numCharInicioDisp.Text = ""
        numCharFinDisp.Text = ""
        txtCreadoEl.Text = ""
        txtCreadoPor.Text = ""
        txtModificadoEl.Text = ""
        txtModificadoPor.Text = ""
    End Sub

    Private Sub limpiarGroup()

    End Sub


    Private Sub cargarClases()
        Try
            GridControlClases.DataSource = gsClases.NConsultarClases()    'Llenado del grid
            GridViewClases.BestFitColumns()
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub cargarListado()
        Try
            If Not listado Is Nothing Then
                GridControlListado.DataSource = listado
                limpiarGroup()
                'ModuleGlobales.Centrar(GroupBoxExtraer)
                GroupBoxExtraer.Visible = True
            Else
                'Llamar al BackgroundWorker
                MessageBox.Show("Se preparará la información, este proceso podría tardar varios minutos, se ejecutará en segundo plano, se notificará una vez completa la preparación", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BackgroundWorkerListado.RunWorkerAsync()
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub
#End Region
    Private Sub btnNuevaClase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevaClase.ItemClick
        'Preparar el listado - Barra de progreso
        cargarListado()
    End Sub

    Private Sub frmClasesDispositivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarClases()
    End Sub

    Private Sub btnCerrarExtraer_Click(sender As Object, e As EventArgs) Handles btnCerrarExtraer.Click
        GroupBoxExtraer.Visible = False
    End Sub

    Private Sub BackgroundWorkerListado_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerListado.DoWork
        Try
            listado = CType(gsClases.NCargarListado(), DataTable)    'Llenado del grid
            Console.WriteLine("Se completó la carga")
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub BackgroundWorkerListado_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerListado.RunWorkerCompleted
        Try
            If e.Error IsNot Nothing Then
                MessageBox.Show("Ocurrio un error", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled Then
                MessageBox.Show("Carga cancelada", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Carga completada, abriendo la ventana de extración...", "Carga de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GridControlListado.DataSource = listado
                limpiarGroup()
                'ModuleGlobales.Centrar(GroupBoxExtraer)
                GroupBoxExtraer.Visible = True
            End If
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub GridViewClases_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridViewClases.RowCellClick
        Try
#Disable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
            txtID.Text = GridViewClases.GetRow(GridViewClases.FocusedRowHandle)("ID").ToString
#Enable Warning BC42017 ' Resolución enlazada en tiempo de ejecución
        Catch ex As Exception
            mensajeError(ex)
        End Try
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Me.Close()
    End Sub
End Class
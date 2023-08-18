Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports SISTEMA.DATOS

Public Class DashboardP
    Private Property DataSource() As SqlDataSource
    Dim currentDashboard As New Dashboard
    Public Sub New()
        InitializeComponent()
        'currentDashboard = CreateDashboard()
        BindDataSource(currentDashboard, CreateDataSource())
        DashboardViewer1.Dashboard = currentDashboard
        Try
            DashboardViewer1.LoadDashboard(My.Application.Info.DirectoryPath & "\Dashboard.xml")
        Catch ex As Exception
            Debug.Print("Error de carga")
        End Try
        AddHandler DashboardViewer1.CustomizeDashboardTitle, AddressOf DashboardViewer1_CustomizeDashboardTitle
    End Sub

    Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
        Dim titleButton As DashboardToolbarItem = New DashboardToolbarItem("Cargar Data", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
                                                                                                                                                DashboardViewer1.ReloadData()
                                                                                                                                            End Sub))
        titleButton.Caption = "Refrescar Datos"
        e.Items.Add(titleButton)
    End Sub
    Private Sub frmDashboardViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub BindDataSource(ByVal dashboard As Dashboard, ByVal dashboardSqlDataSource As DashboardSqlDataSource)
        dashboard.DataSources.Add(dashboardSqlDataSource)
        For Each item In dashboard.Items
            Dim dataItem As DataDashboardItem = TryCast(item, DataDashboardItem)
            If dataItem IsNot Nothing Then
                dataItem.DataSource = dashboardSqlDataSource
                dataItem.DataMember = dashboardSqlDataSource.Queries(0).Name
            End If
        Next item
    End Sub
    Private Function CreateDataSource() As DashboardSqlDataSource
        Dim connectionParameters As New MsSqlConnectionParameters() With
        {
        .ServerName = GlobalesConexiones.servLocal,
        .DatabaseName = GlobalesConexiones.bdLocal,
        .UserName = GlobalesConexiones.usuarioLocal,
        .Password = GlobalesConexiones.claveLocal,
        .AuthorizationType = MsSqlAuthorizationType.SqlServer}
        DataSource = New SqlDataSource(connectionParameters)
        Dim sqlDataSource As New DashboardSqlDataSource("Conexión Predeterminada", connectionParameters)
        ' Comment out two lines to use CustomSqlQuery and SQL string expression.
        Dim selectQuery As SqlQuery = CreateSqlQuery()
        sqlDataSource.Queries.Add(selectQuery)
        sqlDataSource.Fill()
        Return sqlDataSource
    End Function
    Private Shared Function CreateSqlQuery() As SqlQuery
        Dim spQuery As New StoredProcQuery("R_cargarVista", "R_cargarVista")
        Return spQuery
    End Function
    'Private Function CreateDashboard() As DashboardP
    '    Dim dBoard As New DashboardP()
    '    Return dBoard
    'End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            DashboardViewer1.ReloadData()
        Catch ex As Exception
            Debug.Print("Error de actualización")
        End Try
    End Sub
End Class
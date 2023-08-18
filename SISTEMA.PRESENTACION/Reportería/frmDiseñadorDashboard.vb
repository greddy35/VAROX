Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports SISTEMA.DATOS

Public Class frmDiseñadorDashboard
	Private Property DataSource() As SqlDataSource
	Dim currentDashboard As Dashboard

	Public Sub New()
		InitializeComponent()
		DashboardDesigner1.CreateRibbon()
		currentDashboard = CreateDashboard()
		BindDataSource(currentDashboard, CreateDataSource())
		DashboardDesigner1.Dashboard = currentDashboard
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
		Dim sqlDataSource As New DashboardSqlDataSource("Predeterminada", connectionParameters)
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

	Private Function CreateDashboard() As Dashboard
		Dim dBoard As New Dashboard()
		Return dBoard
	End Function
End Class
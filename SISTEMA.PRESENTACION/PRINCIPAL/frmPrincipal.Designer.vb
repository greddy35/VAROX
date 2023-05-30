Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.contenedor = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBoxRestabPass = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassConfirma = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnVerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCambiarPass = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarRestablecerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem8 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblRol = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUser = New DevExpress.XtraBars.BarStaticItem()
        Me.lblNombre = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAcerca = New DevExpress.XtraBars.BarButtonItem()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlDashboard = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator14 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlDashboardRapido = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator13 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator16 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator15 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlAdminSistema = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeguridad = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator4 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlUsuariosPrivilegios = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator10 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlRoles = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator11 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlConfigClavBloq = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator12 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlMantenimientos = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator9 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator5 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator6 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator7 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElementSesion = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator3 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btnCambiarContraseña = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator1 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btnCerrarSesion = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator2 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btnSalir = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator8 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.TimerConexión = New System.Windows.Forms.Timer(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiServidores = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiConexión = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiFecha = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblCompañia = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.contenedor.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBoxRestabPass.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contenedor
        '
        Me.contenedor.Controls.Add(Me.PanelControl1)
        Me.contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contenedor.Location = New System.Drawing.Point(292, 37)
        Me.contenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(980, 638)
        Me.contenedor.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupBoxRestabPass)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(980, 638)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupBoxRestabPass
        '
        Me.GroupBoxRestabPass.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBoxRestabPass.Controls.Add(Me.Panel1)
        Me.GroupBoxRestabPass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRestabPass.Location = New System.Drawing.Point(321, 306)
        Me.GroupBoxRestabPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxRestabPass.Name = "GroupBoxRestabPass"
        Me.GroupBoxRestabPass.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxRestabPass.Size = New System.Drawing.Size(485, 244)
        Me.GroupBoxRestabPass.TabIndex = 0
        Me.GroupBoxRestabPass.TabStop = False
        Me.GroupBoxRestabPass.Text = "Cambio de Contraseña"
        Me.GroupBoxRestabPass.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPassActual)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPassConfirma)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.btnVerPass)
        Me.Panel1.Controls.Add(Me.btnCambiarPass)
        Me.Panel1.Controls.Add(Me.btnCancelarRestablecerPass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 221)
        Me.Panel1.TabIndex = 1
        '
        'txtPassActual
        '
        Me.txtPassActual.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassActual.Location = New System.Drawing.Point(201, 14)
        Me.txtPassActual.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassActual.Size = New System.Drawing.Size(205, 32)
        Me.txtPassActual.TabIndex = 10
        Me.txtPassActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassActual.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Contraseña Actual:"
        '
        'txtPassConfirma
        '
        Me.txtPassConfirma.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassConfirma.Location = New System.Drawing.Point(201, 94)
        Me.txtPassConfirma.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtPassConfirma.Name = "txtPassConfirma"
        Me.txtPassConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassConfirma.Size = New System.Drawing.Size(205, 32)
        Me.txtPassConfirma.TabIndex = 8
        Me.txtPassConfirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassConfirma.UseSystemPasswordChar = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(201, 54)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(205, 32)
        Me.txtPass.TabIndex = 7
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnVerPass
        '
        Me.btnVerPass.AllowFocus = False
        Me.btnVerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPass.Appearance.Options.UseFont = True
        Me.btnVerPass.ImageOptions.Image = CType(resources.GetObject("btnVerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVerPass.Location = New System.Drawing.Point(412, 94)
        Me.btnVerPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.Size = New System.Drawing.Size(42, 32)
        ToolTipTitleItem5.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem5.Text = "<b>Ver</b>"
        ToolTipItem5.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem5.Text = "Mostrar contraseñas ingresadas"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btnVerPass.SuperTip = SuperToolTip5
        Me.btnVerPass.TabIndex = 6
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.AllowFocus = False
        Me.btnCambiarPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPass.Appearance.Options.UseFont = True
        Me.btnCambiarPass.ImageOptions.Image = CType(resources.GetObject("btnCambiarPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCambiarPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCambiarPass.Location = New System.Drawing.Point(201, 146)
        Me.btnCambiarPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.Size = New System.Drawing.Size(112, 50)
        Me.btnCambiarPass.TabIndex = 5
        Me.btnCambiarPass.Text = "Cambiar"
        '
        'btnCancelarRestablecerPass
        '
        Me.btnCancelarRestablecerPass.AllowFocus = False
        Me.btnCancelarRestablecerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRestablecerPass.Appearance.Options.UseFont = True
        Me.btnCancelarRestablecerPass.ImageOptions.Image = CType(resources.GetObject("btnCancelarRestablecerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelarRestablecerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCancelarRestablecerPass.Location = New System.Drawing.Point(342, 146)
        Me.btnCancelarRestablecerPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCancelarRestablecerPass.Name = "btnCancelarRestablecerPass"
        Me.btnCancelarRestablecerPass.Size = New System.Drawing.Size(112, 50)
        Me.btnCancelarRestablecerPass.TabIndex = 4
        Me.btnCancelarRestablecerPass.Text = "Cancelar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirmar Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Nueva:"
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.Form = Me
        Me.FluentFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem6, Me.BarStaticItem7, Me.BarStaticItem8, Me.lblRol, Me.lblUser, Me.lblNombre, Me.btnAcerca})
        Me.FluentFormDefaultManager1.MaxItemId = 10
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem6.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarStaticItem6.AllowRightClickInMenu = False
        Me.BarStaticItem6.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.BarStaticItem6.Caption = "Usuario:"
        Me.BarStaticItem6.Id = 3
        Me.BarStaticItem6.ImageOptions.Image = CType(resources.GetObject("BarStaticItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem6.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem6.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem6.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem6.Name = "BarStaticItem6"
        Me.BarStaticItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarStaticItem6.Size = New System.Drawing.Size(90, 0)
        Me.BarStaticItem6.Width = 90
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem7.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarStaticItem7.AllowRightClickInMenu = False
        Me.BarStaticItem7.Caption = "Rol:"
        Me.BarStaticItem7.Id = 4
        Me.BarStaticItem7.ImageOptions.Image = CType(resources.GetObject("BarStaticItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem7.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem7.Name = "BarStaticItem7"
        Me.BarStaticItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarStaticItem8
        '
        Me.BarStaticItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem8.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarStaticItem8.AllowRightClickInMenu = False
        Me.BarStaticItem8.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.BarStaticItem8.Caption = "Nombre:"
        Me.BarStaticItem8.Id = 5
        Me.BarStaticItem8.ImageOptions.Image = CType(resources.GetObject("BarStaticItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem8.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem8.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem8.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem8.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem8.Name = "BarStaticItem8"
        Me.BarStaticItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarStaticItem8.Size = New System.Drawing.Size(90, 0)
        Me.BarStaticItem8.Width = 90
        '
        'lblRol
        '
        Me.lblRol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblRol.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.lblRol.AllowRightClickInMenu = False
        Me.lblRol.Caption = "---"
        Me.lblRol.Id = 6
        Me.lblRol.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblRol.ItemAppearance.Normal.Options.UseFont = True
        Me.lblRol.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(150, 30)
        Me.lblRol.Width = 150
        '
        'lblUser
        '
        Me.lblUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblUser.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.lblUser.AllowRightClickInMenu = False
        Me.lblUser.Caption = "---"
        Me.lblUser.Id = 7
        Me.lblUser.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblUser.ItemAppearance.Normal.Options.UseFont = True
        Me.lblUser.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(150, 30)
        Me.lblUser.Width = 150
        '
        'lblNombre
        '
        Me.lblNombre.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblNombre.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.lblNombre.AllowRightClickInMenu = False
        Me.lblNombre.Caption = "---"
        Me.lblNombre.Id = 8
        Me.lblNombre.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblNombre.ItemAppearance.Normal.Options.UseFont = True
        Me.lblNombre.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblNombre.Name = "lblNombre"
        '
        'btnAcerca
        '
        Me.btnAcerca.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAcerca.Caption = "Acerca"
        Me.btnAcerca.Id = 9
        Me.btnAcerca.ImageOptions.Image = CType(resources.GetObject("btnAcerca.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAcerca.ImageOptions.LargeImage = CType(resources.GetObject("btnAcerca.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAcerca.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcerca.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.btnAcerca.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAcerca.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btnAcerca.Name = "btnAcerca"
        Me.btnAcerca.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnAcerca.Size = New System.Drawing.Size(100, 0)
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.AccordionControlSeparator13, Me.AccordionControlElement2, Me.AccordionControlSeparator15, Me.AccordionControlAdminSistema, Me.AccordionControlElementSesion})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 37)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(292, 638)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlDashboard, Me.AccordionControlSeparator14, Me.AccordionControlDashboardRapido})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement1.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Dashboard"
        '
        'AccordionControlDashboard
        '
        Me.AccordionControlDashboard.ImageOptions.Image = CType(resources.GetObject("AccordionControlDashboard.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlDashboard.Name = "AccordionControlDashboard"
        Me.AccordionControlDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlDashboard.Text = "General"
        '
        'AccordionControlSeparator14
        '
        Me.AccordionControlSeparator14.Name = "AccordionControlSeparator14"
        '
        'AccordionControlDashboardRapido
        '
        Me.AccordionControlDashboardRapido.ImageOptions.Image = CType(resources.GetObject("AccordionControlDashboardRapido.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlDashboardRapido.Name = "AccordionControlDashboardRapido"
        Me.AccordionControlDashboardRapido.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlDashboardRapido.Text = "Dashboard Rápido"
        '
        'AccordionControlSeparator13
        '
        Me.AccordionControlSeparator13.Name = "AccordionControlSeparator13"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement4, Me.AccordionControlSeparator16, Me.AccordionControlElement6})
        Me.AccordionControlElement2.Expanded = True
        Me.AccordionControlElement2.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement2.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Text = "Reportería"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement4.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Corte General"
        '
        'AccordionControlSeparator16
        '
        Me.AccordionControlSeparator16.Name = "AccordionControlSeparator16"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement6.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Corte por Local"
        '
        'AccordionControlSeparator15
        '
        Me.AccordionControlSeparator15.Name = "AccordionControlSeparator15"
        '
        'AccordionControlAdminSistema
        '
        Me.AccordionControlAdminSistema.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlSeguridad, Me.AccordionControlMantenimientos, Me.AccordionControlElement3})
        Me.AccordionControlAdminSistema.Expanded = True
        Me.AccordionControlAdminSistema.ImageOptions.Image = CType(resources.GetObject("AccordionControlAdminSistema.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlAdminSistema.Name = "AccordionControlAdminSistema"
        Me.AccordionControlAdminSistema.Text = "Administración de Sistema"
        '
        'AccordionControlSeguridad
        '
        Me.AccordionControlSeguridad.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlSeparator4, Me.AccordionControlUsuariosPrivilegios, Me.AccordionControlSeparator10, Me.AccordionControlRoles, Me.AccordionControlSeparator11, Me.AccordionControlConfigClavBloq, Me.AccordionControlSeparator12})
        Me.AccordionControlSeguridad.Expanded = True
        Me.AccordionControlSeguridad.Name = "AccordionControlSeguridad"
        Me.AccordionControlSeguridad.Text = "Seguridad"
        '
        'AccordionControlSeparator4
        '
        Me.AccordionControlSeparator4.Name = "AccordionControlSeparator4"
        '
        'AccordionControlUsuariosPrivilegios
        '
        Me.AccordionControlUsuariosPrivilegios.ImageOptions.Image = CType(resources.GetObject("AccordionControlUsuariosPrivilegios.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlUsuariosPrivilegios.Name = "AccordionControlUsuariosPrivilegios"
        Me.AccordionControlUsuariosPrivilegios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlUsuariosPrivilegios.Text = "Usuarios y Privilegios"
        '
        'AccordionControlSeparator10
        '
        Me.AccordionControlSeparator10.Name = "AccordionControlSeparator10"
        '
        'AccordionControlRoles
        '
        Me.AccordionControlRoles.ImageOptions.Image = CType(resources.GetObject("AccordionControlRoles.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlRoles.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.AccordionControlRoles.Name = "AccordionControlRoles"
        Me.AccordionControlRoles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlRoles.Text = "Roles"
        '
        'AccordionControlSeparator11
        '
        Me.AccordionControlSeparator11.Name = "AccordionControlSeparator11"
        '
        'AccordionControlConfigClavBloq
        '
        Me.AccordionControlConfigClavBloq.ImageOptions.Image = CType(resources.GetObject("AccordionControlConfigClavBloq.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlConfigClavBloq.Name = "AccordionControlConfigClavBloq"
        Me.AccordionControlConfigClavBloq.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlConfigClavBloq.Text = "Config. de Clave y Bloqueo"
        '
        'AccordionControlSeparator12
        '
        Me.AccordionControlSeparator12.Name = "AccordionControlSeparator12"
        '
        'AccordionControlMantenimientos
        '
        Me.AccordionControlMantenimientos.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlSeparator9, Me.AccordionControlElement5, Me.AccordionControlSeparator5})
        Me.AccordionControlMantenimientos.Expanded = True
        Me.AccordionControlMantenimientos.Name = "AccordionControlMantenimientos"
        Me.AccordionControlMantenimientos.Text = "Mantenimientos"
        '
        'AccordionControlSeparator9
        '
        Me.AccordionControlSeparator9.Name = "AccordionControlSeparator9"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement5.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement5.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "Mantenimiento 1"
        '
        'AccordionControlSeparator5
        '
        Me.AccordionControlSeparator5.Name = "AccordionControlSeparator5"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement8, Me.AccordionControlSeparator6, Me.AccordionControlElement9, Me.AccordionControlSeparator7})
        Me.AccordionControlElement3.Expanded = True
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Text = "Parámetros del Sistema"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement8.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement8.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "Tipos de Mediciones"
        '
        'AccordionControlSeparator6
        '
        Me.AccordionControlSeparator6.Name = "AccordionControlSeparator6"
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement9.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement9.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement9.Text = "Tipos de Válvulas"
        '
        'AccordionControlSeparator7
        '
        Me.AccordionControlSeparator7.Name = "AccordionControlSeparator7"
        '
        'AccordionControlElementSesion
        '
        Me.AccordionControlElementSesion.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlSeparator3, Me.btnCambiarContraseña, Me.AccordionControlSeparator1, Me.btnCerrarSesion, Me.AccordionControlSeparator2, Me.btnSalir, Me.AccordionControlSeparator8})
        Me.AccordionControlElementSesion.Expanded = True
        Me.AccordionControlElementSesion.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElementSesion.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElementSesion.Name = "AccordionControlElementSesion"
        Me.AccordionControlElementSesion.Text = "Sesión"
        '
        'AccordionControlSeparator3
        '
        Me.AccordionControlSeparator3.Name = "AccordionControlSeparator3"
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.ImageOptions.Image = CType(resources.GetObject("btnCambiarContraseña.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCambiarContraseña.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        '
        'AccordionControlSeparator1
        '
        Me.AccordionControlSeparator1.Name = "AccordionControlSeparator1"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.ImageOptions.Image = CType(resources.GetObject("btnCerrarSesion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btnCerrarSesion.Text = "Cambiar de Usuario"
        '
        'AccordionControlSeparator2
        '
        Me.AccordionControlSeparator2.Name = "AccordionControlSeparator2"
        '
        'btnSalir
        '
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btnSalir.Text = "Salir"
        '
        'AccordionControlSeparator8
        '
        Me.AccordionControlSeparator8.Name = "AccordionControlSeparator8"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem6, Me.BarStaticItem7, Me.BarStaticItem8, Me.lblRol, Me.lblUser, Me.lblNombre, Me.btnAcerca})
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1272, 37)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.lblNombre)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarStaticItem8)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.lblUser)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarStaticItem6)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.lblRol)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarStaticItem7)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.btnAcerca)
        '
        'TimerConexión
        '
        Me.TimerConexión.Enabled = True
        Me.TimerConexión.Interval = 1000
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.bsiServidores, Me.BarStaticItem2, Me.bsiConexión, Me.BarStaticItem5, Me.bsiFecha, Me.BarStaticItem3, Me.lblCompañia})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiServidores), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiConexión), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiFecha), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.lblCompañia)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "SERVIDORES: "
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.ImageOptions.Image = CType(resources.GetObject("BarStaticItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarStaticItem1.Size = New System.Drawing.Size(0, 30)
        '
        'bsiServidores
        '
        Me.bsiServidores.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.bsiServidores.Caption = "---"
        Me.bsiServidores.Id = 1
        Me.bsiServidores.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsiServidores.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bsiServidores.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiServidores.ItemAppearance.Normal.Options.UseForeColor = True
        Me.bsiServidores.Name = "bsiServidores"
        Me.bsiServidores.Size = New System.Drawing.Size(0, 30)
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "CONEXIÓN: "
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.ImageOptions.Image = CType(resources.GetObject("BarStaticItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarStaticItem2.Size = New System.Drawing.Size(0, 30)
        '
        'bsiConexión
        '
        Me.bsiConexión.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.bsiConexión.Caption = "---"
        Me.bsiConexión.Id = 3
        Me.bsiConexión.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsiConexión.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bsiConexión.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiConexión.ItemAppearance.Normal.Options.UseForeColor = True
        Me.bsiConexión.Name = "bsiConexión"
        Me.bsiConexión.Size = New System.Drawing.Size(0, 30)
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem5.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.BarStaticItem5.Caption = "FECHA:"
        Me.BarStaticItem5.Id = 8
        Me.BarStaticItem5.ImageOptions.Image = CType(resources.GetObject("BarStaticItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem5.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem5.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem5.Name = "BarStaticItem5"
        Me.BarStaticItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarStaticItem5.Size = New System.Drawing.Size(0, 30)
        '
        'bsiFecha
        '
        Me.bsiFecha.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiFecha.AllowFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.bsiFecha.Caption = "---"
        Me.bsiFecha.Id = 9
        Me.bsiFecha.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.bsiFecha.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Firebrick
        Me.bsiFecha.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiFecha.ItemAppearance.Normal.Options.UseForeColor = True
        Me.bsiFecha.Name = "bsiFecha"
        Me.bsiFecha.Size = New System.Drawing.Size(0, 30)
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "COMPAÑIA:"
        Me.BarStaticItem3.Id = 10
        Me.BarStaticItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'lblCompañia
        '
        Me.lblCompañia.Caption = "---"
        Me.lblCompañia.Id = 11
        Me.lblCompañia.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompañia.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCompañia.ItemAppearance.Normal.Options.UseFont = True
        Me.lblCompañia.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblCompañia.Name = "lblCompañia"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.barDockControlTop.Size = New System.Drawing.Size(1272, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 675)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1272, 41)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 638)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1272, 37)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 638)
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "COMPAÑIA:"
        Me.BarStaticItem4.Id = 0
        Me.BarStaticItem4.ImageOptions.Image = CType(resources.GetObject("BarStaticItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem4.Name = "BarStaticItem4"
        Me.BarStaticItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 3"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 716)
        Me.ControlContainer = Me.contenedor
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmPrincipal.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPrincipal"
        Me.NavigationControl = Me.AccordionControl1
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contenedor.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBoxRestabPass.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contenedor As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents TimerConexión As Timer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiServidores As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiConexión As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBoxRestabPass As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerPass As SimpleButton
    Friend WithEvents btnCambiarPass As SimpleButton
    Friend WithEvents btnCancelarRestablecerPass As SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassConfirma As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem8 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblRol As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblNombre As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlAdminSistema As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeguridad As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator4 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlUsuariosPrivilegios As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator10 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlRoles As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator11 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlMantenimientos As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator9 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator5 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator6 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator7 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElementSesion As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator3 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btnCambiarContraseña As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator1 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btnCerrarSesion As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator2 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btnSalir As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator8 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiFecha As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents txtPassActual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblCompañia As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnAcerca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AccordionControlConfigClavBloq As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator12 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlDashboard As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator14 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlDashboardRapido As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator13 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator16 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator15 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModificar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLocalesVinculados = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nudIVA = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIdNIT = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNIT = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodNIT = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoNIT = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModificadoEl = New System.Windows.Forms.TextBox()
        Me.txtModificadoPor = New System.Windows.Forms.TextBox()
        Me.txtCreadoEl = New System.Windows.Forms.TextBox()
        Me.txtCreadoPor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridControlClientes = New DevExpress.XtraGrid.GridControl()
        Me.GridViewClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.nudIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridControlClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnSalir, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnEliminar, Me.btnRefrescar, Me.btnCancelar, Me.btnLocalesVinculados})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 11
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1073, 178)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir"
        Me.btnSalir.Id = 1
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.ImageOptions.LargeImage = CType(resources.GetObject("btnSalir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSalir.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSalir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.btnSalir.LargeWidth = 65
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.ShortcutKeyDisplayString = "Ctrl+Supr"
        Me.btnSalir.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nuevo"
        Me.btnNuevo.Id = 4
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageOptions.LargeImage = CType(resources.GetObject("btnNuevo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNuevo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNuevo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.btnNuevo.LargeWidth = 65
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.ShortcutKeyDisplayString = "Ctrl+N"
        Me.btnNuevo.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Id = 5
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageOptions.LargeImage = CType(resources.GetObject("btnGuardar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnGuardar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGuardar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.btnGuardar.LargeWidth = 65
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.ShortcutKeyDisplayString = "Ctrl+G"
        Me.btnGuardar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnModificar
        '
        Me.btnModificar.Caption = "Modificar"
        Me.btnModificar.Id = 6
        Me.btnModificar.ImageOptions.Image = CType(resources.GetObject("btnModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificar.ImageOptions.LargeImage = CType(resources.GetObject("btnModificar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnModificar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ItemAppearance.Normal.Options.UseFont = True
        Me.btnModificar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M))
        Me.btnModificar.LargeWidth = 65
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.ShortcutKeyDisplayString = "Ctrl+M"
        Me.btnModificar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnEliminar
        '
        Me.btnEliminar.Caption = "Eliminar"
        Me.btnEliminar.Id = 7
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("btnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEliminar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEliminar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnEliminar.LargeWidth = 65
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.ShortcutKeyDisplayString = "Supr"
        Me.btnEliminar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Id = 8
        Me.btnRefrescar.ImageOptions.Image = CType(resources.GetObject("btnRefrescar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageOptions.LargeImage = CType(resources.GetObject("btnRefrescar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefrescar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.ItemAppearance.Normal.Options.UseFont = True
        Me.btnRefrescar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnRefrescar.LargeWidth = 65
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.ShortcutKeyDisplayString = "Ctrl+R"
        Me.btnRefrescar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnCancelar
        '
        Me.btnCancelar.Caption = "Cancelar"
        Me.btnCancelar.Id = 9
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageOptions.LargeImage = CType(resources.GetObject("btnCancelar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCancelar.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCancelar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.btnCancelar.LargeWidth = 65
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.ShortcutKeyDisplayString = "Ctrl+Z"
        Me.btnCancelar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnLocalesVinculados
        '
        Me.btnLocalesVinculados.Caption = "Locales Vinculados"
        Me.btnLocalesVinculados.Id = 10
        Me.btnLocalesVinculados.ImageOptions.Image = CType(resources.GetObject("btnLocalesVinculados.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLocalesVinculados.ImageOptions.LargeImage = CType(resources.GetObject("btnLocalesVinculados.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLocalesVinculados.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalesVinculados.ItemAppearance.Normal.Options.UseFont = True
        Me.btnLocalesVinculados.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
        Me.btnLocalesVinculados.LargeWidth = 65
        Me.btnLocalesVinculados.Name = "btnLocalesVinculados"
        Me.btnLocalesVinculados.ShortcutKeyDisplayString = "Ctrl+L"
        Me.btnLocalesVinculados.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.[True]
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Inicio"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNuevo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancelar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnModificar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEliminar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Acciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSalir)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "General"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 641)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1073, 35)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 178)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1073, 463)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 149)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.nudIVA)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtIdNIT)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.chkEstado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtNIT)
        Me.Panel2.Controls.Add(Me.txtCodNIT)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cboTipoNIT)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtModificadoEl)
        Me.Panel2.Controls.Add(Me.txtModificadoPor)
        Me.Panel2.Controls.Add(Me.txtCreadoEl)
        Me.Panel2.Controls.Add(Me.txtCreadoPor)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtAlias)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 149)
        Me.Panel2.TabIndex = 6
        '
        'nudIVA
        '
        Me.nudIVA.Enabled = False
        Me.nudIVA.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIVA.Location = New System.Drawing.Point(644, 45)
        Me.nudIVA.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudIVA.Name = "nudIVA"
        Me.nudIVA.Size = New System.Drawing.Size(56, 28)
        Me.nudIVA.TabIndex = 44
        Me.nudIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(571, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 21)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "%IVA:"
        '
        'txtIdNIT
        '
        Me.txtIdNIT.BackColor = System.Drawing.SystemColors.Info
        Me.txtIdNIT.Enabled = False
        Me.txtIdNIT.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtIdNIT.Location = New System.Drawing.Point(644, 11)
        Me.txtIdNIT.Name = "txtIdNIT"
        Me.txtIdNIT.Size = New System.Drawing.Size(56, 28)
        Me.txtIdNIT.TabIndex = 42
        Me.txtIdNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtCorreo.Location = New System.Drawing.Point(459, 117)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(276, 28)
        Me.txtCorreo.TabIndex = 7
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(380, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 21)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Correo:"
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(95, 118)
        Me.chkEstado.MenuManager = Me.RibbonControl
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.Properties.Appearance.Options.UseFont = True
        Me.chkEstado.Properties.Caption = "Inactivo"
        Me.chkEstado.Size = New System.Drawing.Size(99, 25)
        Me.chkEstado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Activo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "NIT:"
        '
        'txtNIT
        '
        Me.txtNIT.Enabled = False
        Me.txtNIT.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtNIT.Location = New System.Drawing.Point(459, 80)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(276, 28)
        Me.txtNIT.TabIndex = 45
        Me.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodNIT
        '
        Me.txtCodNIT.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodNIT.Enabled = False
        Me.txtCodNIT.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodNIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtCodNIT.Location = New System.Drawing.Point(459, 45)
        Me.txtCodNIT.Name = "txtCodNIT"
        Me.txtCodNIT.Size = New System.Drawing.Size(65, 28)
        Me.txtCodNIT.TabIndex = 34
        Me.txtCodNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(95, 45)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 28)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 21)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Alias:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Codigo NIT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tipo NIT:"
        '
        'cboTipoNIT
        '
        Me.cboTipoNIT.DropDownHeight = 120
        Me.cboTipoNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoNIT.Enabled = False
        Me.cboTipoNIT.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoNIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.cboTipoNIT.FormattingEnabled = True
        Me.cboTipoNIT.IntegralHeight = False
        Me.cboTipoNIT.Items.AddRange(New Object() {"Persona Física", "Persona Jurídica", "Persona Extranjera", "DIMEX", "DIDI"})
        Me.cboTipoNIT.Location = New System.Drawing.Point(459, 10)
        Me.cboTipoNIT.Name = "cboTipoNIT"
        Me.cboTipoNIT.Size = New System.Drawing.Size(179, 29)
        Me.cboTipoNIT.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(95, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(88, 28)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID:"
        '
        'txtModificadoEl
        '
        Me.txtModificadoEl.BackColor = System.Drawing.SystemColors.Info
        Me.txtModificadoEl.Enabled = False
        Me.txtModificadoEl.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificadoEl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtModificadoEl.Location = New System.Drawing.Point(885, 116)
        Me.txtModificadoEl.Name = "txtModificadoEl"
        Me.txtModificadoEl.Size = New System.Drawing.Size(175, 28)
        Me.txtModificadoEl.TabIndex = 18
        Me.txtModificadoEl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtModificadoPor
        '
        Me.txtModificadoPor.BackColor = System.Drawing.SystemColors.Info
        Me.txtModificadoPor.Enabled = False
        Me.txtModificadoPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificadoPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtModificadoPor.Location = New System.Drawing.Point(885, 81)
        Me.txtModificadoPor.Name = "txtModificadoPor"
        Me.txtModificadoPor.Size = New System.Drawing.Size(175, 28)
        Me.txtModificadoPor.TabIndex = 17
        Me.txtModificadoPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCreadoEl
        '
        Me.txtCreadoEl.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreadoEl.Enabled = False
        Me.txtCreadoEl.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreadoEl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtCreadoEl.Location = New System.Drawing.Point(885, 46)
        Me.txtCreadoEl.Name = "txtCreadoEl"
        Me.txtCreadoEl.Size = New System.Drawing.Size(175, 28)
        Me.txtCreadoEl.TabIndex = 16
        Me.txtCreadoEl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCreadoPor
        '
        Me.txtCreadoPor.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreadoPor.Enabled = False
        Me.txtCreadoPor.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreadoPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtCreadoPor.Location = New System.Drawing.Point(885, 11)
        Me.txtCreadoPor.Name = "txtCreadoPor"
        Me.txtCreadoPor.Size = New System.Drawing.Size(175, 28)
        Me.txtCreadoPor.TabIndex = 15
        Me.txtCreadoPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(755, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Modificado el:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(741, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Modificado por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(790, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Creado el:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(776, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Creado por:"
        '
        'txtAlias
        '
        Me.txtAlias.Enabled = False
        Me.txtAlias.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtAlias.Location = New System.Drawing.Point(95, 81)
        Me.txtAlias.MaxLength = 100
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(225, 28)
        Me.txtAlias.TabIndex = 3
        Me.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GridControlClientes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 158)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1067, 307)
        Me.Panel4.TabIndex = 1
        '
        'GridControlClientes
        '
        Me.GridControlClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlClientes.Location = New System.Drawing.Point(0, 0)
        Me.GridControlClientes.MainView = Me.GridViewClientes
        Me.GridControlClientes.MenuManager = Me.RibbonControl
        Me.GridControlClientes.Name = "GridControlClientes"
        Me.GridControlClientes.Size = New System.Drawing.Size(1067, 307)
        Me.GridControlClientes.TabIndex = 1
        Me.GridControlClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewClientes})
        '
        'GridViewClientes
        '
        Me.GridViewClientes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewClientes.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewClientes.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewClientes.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewClientes.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewClientes.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridViewClientes.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewClientes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewClientes.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewClientes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridViewClientes.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewClientes.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewClientes.Appearance.Row.Options.UseFont = True
        Me.GridViewClientes.Appearance.Row.Options.UseForeColor = True
        Me.GridViewClientes.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewClientes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewClientes.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewClientes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridViewClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn4, Me.GridColumn13, Me.GridColumn7, Me.GridColumn8, Me.GridColumn6, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridViewClientes.GridControl = Me.GridControlClientes
        Me.GridViewClientes.Name = "GridViewClientes"
        Me.GridViewClientes.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID CLIENTE"
        Me.GridColumn1.FieldName = "ID_CLIENTE"
        Me.GridColumn1.MinWidth = 25
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 94
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "NOMBRE CLIENTE"
        Me.GridColumn2.FieldName = "NOMBRE_CLIENTE"
        Me.GridColumn2.MinWidth = 25
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 94
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ALIAS"
        Me.GridColumn3.FieldName = "ALIAS_CLIENTE"
        Me.GridColumn3.MinWidth = 25
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 94
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ID NIT"
        Me.GridColumn5.FieldName = "ID_NIT"
        Me.GridColumn5.MinWidth = 25
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Width = 94
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CÓDIGO NIT"
        Me.GridColumn4.FieldName = "CODIGO_NIT"
        Me.GridColumn4.MinWidth = 25
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 94
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "IVA"
        Me.GridColumn13.DisplayFormat.FormatString = "{P0}%"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn13.FieldName = "IVA"
        Me.GridColumn13.MinWidth = 25
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 94
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "NIT"
        Me.GridColumn7.FieldName = "NIT"
        Me.GridColumn7.MinWidth = 25
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 94
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "CORREO"
        Me.GridColumn8.FieldName = "CORREO"
        Me.GridColumn8.MinWidth = 25
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 94
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ESTADO"
        Me.GridColumn6.FieldName = "ACTIVO"
        Me.GridColumn6.MinWidth = 25
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        Me.GridColumn6.Width = 94
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.Caption = "CREADO POR"
        Me.GridColumn9.FieldName = "CREADO_POR"
        Me.GridColumn9.MinWidth = 25
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 94
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.Caption = "CREADO EL"
        Me.GridColumn10.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn10.FieldName = "CREADO_EL"
        Me.GridColumn10.MinWidth = 25
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 94
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.Caption = "MODIFICADO POR"
        Me.GridColumn11.FieldName = "MODIFICADO_POR"
        Me.GridColumn11.MinWidth = 25
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        Me.GridColumn11.Width = 94
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.Caption = "MODIFICADO EL"
        Me.GridColumn12.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn12.FieldName = "MODIFICADO_EL"
        Me.GridColumn12.MinWidth = 25
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 94
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 676)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmClientes.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "frmClientes"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Clientes"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nudIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridControlClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTipoNIT As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModificadoEl As TextBox
    Friend WithEvents txtModificadoPor As TextBox
    Friend WithEvents txtCreadoEl As TextBox
    Friend WithEvents txtCreadoPor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GridControlClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodNIT As TextBox
    Friend WithEvents txtNIT As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLocalesVinculados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtIdNIT As TextBox
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nudIVA As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class

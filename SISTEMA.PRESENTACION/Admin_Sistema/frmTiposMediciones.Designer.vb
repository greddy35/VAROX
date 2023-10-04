<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTiposMediciones
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiposMediciones))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModificar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreTipo = New System.Windows.Forms.TextBox()
        Me.spValor = New DevExpress.XtraEditors.TextEdit()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GridControlTiposMediciones = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTiposMediciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.spValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridControlTiposMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTiposMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnEliminar, Me.btnRefrescar, Me.btnSalir, Me.btnCancelar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1114, 178)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nuevo"
        Me.btnNuevo.Id = 1
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
        Me.btnGuardar.Id = 2
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
        Me.btnModificar.Id = 3
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
        Me.btnEliminar.Id = 4
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
        Me.btnRefrescar.Id = 5
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
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir"
        Me.btnSalir.Id = 6
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
        'btnCancelar
        '
        Me.btnCancelar.Caption = "Cancelar"
        Me.btnCancelar.Id = 7
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 582)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1114, 35)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1114, 404)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 144)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboMoneda)
        Me.Panel2.Controls.Add(Me.cboUnidadMedida)
        Me.Panel2.Controls.Add(Me.txtMedida)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
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
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNombreTipo)
        Me.Panel2.Controls.Add(Me.spValor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1108, 144)
        Me.Panel2.TabIndex = 6
        '
        'cboMoneda
        '
        Me.cboMoneda.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMoneda.DropDownHeight = 150
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.IntegralHeight = False
        Me.cboMoneda.Items.AddRange(New Object() {"Colón", "Dólar"})
        Me.cboMoneda.Location = New System.Drawing.Point(155, 110)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(132, 29)
        Me.cboMoneda.TabIndex = 36
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboUnidadMedida.DropDownHeight = 150
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.Enabled = False
        Me.cboUnidadMedida.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.IntegralHeight = False
        Me.cboUnidadMedida.Items.AddRange(New Object() {"m3", "und"})
        Me.cboUnidadMedida.Location = New System.Drawing.Point(155, 76)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(61, 29)
        Me.cboUnidadMedida.TabIndex = 34
        '
        'txtMedida
        '
        Me.txtMedida.BackColor = System.Drawing.SystemColors.Info
        Me.txtMedida.Enabled = False
        Me.txtMedida.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtMedida.Location = New System.Drawing.Point(222, 76)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(207, 28)
        Me.txtMedida.TabIndex = 33
        Me.txtMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Unidad Medida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Valor Unidad:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(575, 74)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(330, 62)
        Me.txtDescripcion.TabIndex = 24
        Me.txtDescripcion.Text = ""
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(155, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(88, 28)
        Me.txtID.TabIndex = 23
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 11)
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
        Me.txtModificadoEl.Location = New System.Drawing.Point(911, 39)
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
        Me.txtModificadoPor.Location = New System.Drawing.Point(911, 8)
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
        Me.txtCreadoEl.Location = New System.Drawing.Point(575, 40)
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
        Me.txtCreadoPor.Location = New System.Drawing.Point(575, 8)
        Me.txtCreadoPor.Name = "txtCreadoPor"
        Me.txtCreadoPor.Size = New System.Drawing.Size(175, 28)
        Me.txtCreadoPor.TabIndex = 15
        Me.txtCreadoPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(774, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Modificado el:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(760, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Modificado por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(473, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Creado el:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(459, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Creado por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'txtNombreTipo
        '
        Me.txtNombreTipo.Enabled = False
        Me.txtNombreTipo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtNombreTipo.Location = New System.Drawing.Point(155, 41)
        Me.txtNombreTipo.MaxLength = 50
        Me.txtNombreTipo.Name = "txtNombreTipo"
        Me.txtNombreTipo.Size = New System.Drawing.Size(274, 28)
        Me.txtNombreTipo.TabIndex = 3
        Me.txtNombreTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'spValor
        '
        Me.spValor.EditValue = "1.00"
        Me.spValor.Enabled = False
        Me.spValor.Location = New System.Drawing.Point(293, 110)
        Me.spValor.MenuManager = Me.RibbonControl
        Me.spValor.Name = "spValor"
        Me.spValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spValor.Properties.Appearance.Options.UseFont = True
        Me.spValor.Properties.Appearance.Options.UseTextOptions = True
        Me.spValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.spValor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.spValor.Properties.HideSelection = False
        Me.spValor.Properties.MaskSettings.Set("mask", "f")
        Me.spValor.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.spValor.Properties.MaxLength = 8
        Me.spValor.Properties.UseMaskAsDisplayFormat = True
        Me.spValor.Size = New System.Drawing.Size(136, 28)
        Me.spValor.TabIndex = 35
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GridControlTiposMediciones)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 153)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1108, 288)
        Me.Panel4.TabIndex = 1
        '
        'GridControlTiposMediciones
        '
        Me.GridControlTiposMediciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlTiposMediciones.Location = New System.Drawing.Point(0, 0)
        Me.GridControlTiposMediciones.MainView = Me.GridViewTiposMediciones
        Me.GridControlTiposMediciones.MenuManager = Me.RibbonControl
        Me.GridControlTiposMediciones.Name = "GridControlTiposMediciones"
        Me.GridControlTiposMediciones.Size = New System.Drawing.Size(1108, 288)
        Me.GridControlTiposMediciones.TabIndex = 1
        Me.GridControlTiposMediciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTiposMediciones})
        '
        'GridViewTiposMediciones
        '
        Me.GridViewTiposMediciones.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridViewTiposMediciones.Appearance.Empty.Options.UseBackColor = True
        Me.GridViewTiposMediciones.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTiposMediciones.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewTiposMediciones.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewTiposMediciones.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridViewTiposMediciones.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTiposMediciones.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewTiposMediciones.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewTiposMediciones.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridViewTiposMediciones.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTiposMediciones.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewTiposMediciones.Appearance.Row.Options.UseFont = True
        Me.GridViewTiposMediciones.Appearance.Row.Options.UseForeColor = True
        Me.GridViewTiposMediciones.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTiposMediciones.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GridViewTiposMediciones.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewTiposMediciones.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridViewTiposMediciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.GridColumn3, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridViewTiposMediciones.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridViewTiposMediciones.GridControl = Me.GridControlTiposMediciones
        Me.GridViewTiposMediciones.Name = "GridViewTiposMediciones"
        Me.GridViewTiposMediciones.OptionsView.ColumnAutoWidth = False
        Me.GridViewTiposMediciones.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID_TIPO_MEDICION"
        Me.GridColumn1.MinWidth = 100
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "TIPO"
        Me.GridColumn2.FieldName = "TIPO_MEDICION"
        Me.GridColumn2.MinWidth = 150
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "UNIDAD MEDIDA"
        Me.GridColumn4.FieldName = "UNIDAD"
        Me.GridColumn4.MinWidth = 150
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 150
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "VALOR UNIDAD"
        Me.GridColumn5.FieldName = "VALOR_UNIDAD"
        Me.GridColumn5.MinWidth = 150
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "DESCRIPCIÓN"
        Me.GridColumn3.FieldName = "DESCRIPCION"
        Me.GridColumn3.MinWidth = 190
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 190
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "CREADO POR"
        Me.GridColumn9.FieldName = "CREADO_POR"
        Me.GridColumn9.MinWidth = 110
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 110
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "CREADO EL"
        Me.GridColumn10.FieldName = "CREADO_EL"
        Me.GridColumn10.MinWidth = 180
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 180
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "MODIFICADO POR"
        Me.GridColumn11.FieldName = "MODIFICADO_POR"
        Me.GridColumn11.MinWidth = 110
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 7
        Me.GridColumn11.Width = 110
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "MODIFICADO EL"
        Me.GridColumn12.FieldName = "MODIFICADO_EL"
        Me.GridColumn12.MinWidth = 180
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 180
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "MONEDA"
        Me.GridColumn6.FieldName = "MONEDA"
        Me.GridColumn6.MinWidth = 25
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 94
        '
        'frmTiposMediciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 617)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmTiposMediciones.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "frmTiposMediciones"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Tipos de Mediciones"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.spValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridControlTiposMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTiposMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreTipo As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GridControlTiposMediciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTiposMediciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents cboUnidadMedida As ComboBox
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboMoneda As ComboBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class

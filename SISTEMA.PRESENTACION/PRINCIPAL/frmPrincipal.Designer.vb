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
        Me.contenedor = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBoxRestabPass = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassConfirma = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnVerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCambiarPass = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarRestablecerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.TimerConexión = New System.Windows.Forms.Timer(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiServidores = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiConexión = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblCompañia = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAcerca = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem8 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblRol = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUser = New DevExpress.XtraBars.BarStaticItem()
        Me.lblNombre = New DevExpress.XtraBars.BarStaticItem()
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
        Me.contenedor.Location = New System.Drawing.Point(202, 37)
        Me.contenedor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(835, 563)
        Me.contenedor.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupBoxRestabPass)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(835, 563)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupBoxRestabPass
        '
        Me.GroupBoxRestabPass.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBoxRestabPass.Controls.Add(Me.Panel1)
        Me.GroupBoxRestabPass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRestabPass.Location = New System.Drawing.Point(421, 386)
        Me.GroupBoxRestabPass.Name = "GroupBoxRestabPass"
        Me.GroupBoxRestabPass.Size = New System.Drawing.Size(414, 177)
        Me.GroupBoxRestabPass.TabIndex = 0
        Me.GroupBoxRestabPass.TabStop = False
        Me.GroupBoxRestabPass.Text = "Cambio de Contraseña"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPassConfirma)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.btnVerPass)
        Me.Panel1.Controls.Add(Me.btnCambiarPass)
        Me.Panel1.Controls.Add(Me.btnCancelarRestablecerPass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 146)
        Me.Panel1.TabIndex = 1
        '
        'txtPassConfirma
        '
        Me.txtPassConfirma.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassConfirma.Location = New System.Drawing.Point(145, 55)
        Me.txtPassConfirma.Name = "txtPassConfirma"
        Me.txtPassConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassConfirma.Size = New System.Drawing.Size(205, 28)
        Me.txtPassConfirma.TabIndex = 8
        Me.txtPassConfirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassConfirma.UseSystemPasswordChar = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(145, 16)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(205, 28)
        Me.txtPass.TabIndex = 7
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnVerPass
        '
        Me.btnVerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPass.Appearance.Options.UseFont = True
        Me.btnVerPass.ImageOptions.Image = CType(resources.GetObject("btnVerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnVerPass.Location = New System.Drawing.Point(357, 55)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.Size = New System.Drawing.Size(39, 28)
        Me.btnVerPass.TabIndex = 6
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPass.Appearance.Options.UseFont = True
        Me.btnCambiarPass.ImageOptions.Image = CType(resources.GetObject("btnCambiarPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCambiarPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCambiarPass.Location = New System.Drawing.Point(145, 100)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.Size = New System.Drawing.Size(112, 40)
        Me.btnCambiarPass.TabIndex = 5
        Me.btnCambiarPass.Text = "Cambiar"
        '
        'btnCancelarRestablecerPass
        '
        Me.btnCancelarRestablecerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRestablecerPass.Appearance.Options.UseFont = True
        Me.btnCancelarRestablecerPass.ImageOptions.Image = CType(resources.GetObject("btnCancelarRestablecerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelarRestablecerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnCancelarRestablecerPass.Location = New System.Drawing.Point(284, 100)
        Me.btnCancelarRestablecerPass.Name = "btnCancelarRestablecerPass"
        Me.btnCancelarRestablecerPass.Size = New System.Drawing.Size(112, 40)
        Me.btnCancelarRestablecerPass.TabIndex = 4
        Me.btnCancelarRestablecerPass.Text = "Cancelar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirmación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña:"
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.Form = Me
        Me.FluentFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem3, Me.lblCompañia, Me.btnAcerca, Me.BarStaticItem6, Me.BarStaticItem7, Me.BarStaticItem8, Me.lblRol, Me.lblUser, Me.lblNombre})
        Me.FluentFormDefaultManager1.MaxItemId = 9
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 37)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(202, 563)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Element1"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem3, Me.lblCompañia, Me.btnAcerca, Me.BarStaticItem6, Me.BarStaticItem7, Me.BarStaticItem8, Me.lblRol, Me.lblUser, Me.lblNombre})
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1037, 37)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarStaticItem3)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.lblCompañia)
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.bsiServidores, Me.BarStaticItem2, Me.bsiConexión})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiServidores), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiConexión)})
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
        Me.BarStaticItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bsiServidores
        '
        Me.bsiServidores.Caption = "---"
        Me.bsiServidores.Id = 1
        Me.bsiServidores.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsiServidores.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bsiServidores.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiServidores.ItemAppearance.Normal.Options.UseForeColor = True
        Me.bsiServidores.Name = "bsiServidores"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "CONEXIÓN: "
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.ImageOptions.Image = CType(resources.GetObject("BarStaticItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bsiConexión
        '
        Me.bsiConexión.Caption = "---"
        Me.bsiConexión.Id = 3
        Me.bsiConexión.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsiConexión.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.bsiConexión.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiConexión.ItemAppearance.Normal.Options.UseForeColor = True
        Me.bsiConexión.Name = "bsiConexión"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1037, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 600)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1037, 34)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 563)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1037, 37)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 563)
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Compañia:"
        Me.BarStaticItem3.Id = 0
        Me.BarStaticItem3.ImageOptions.Image = CType(resources.GetObject("BarStaticItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarStaticItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarStaticItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lblCompañia
        '
        Me.lblCompañia.Caption = "---"
        Me.lblCompañia.Id = 1
        Me.lblCompañia.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompañia.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCompañia.ItemAppearance.Normal.Options.UseFont = True
        Me.lblCompañia.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblCompañia.Name = "lblCompañia"
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
        'btnAcerca
        '
        Me.btnAcerca.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAcerca.Caption = "Acerca"
        Me.btnAcerca.Id = 2
        Me.btnAcerca.ImageOptions.Image = CType(resources.GetObject("btnAcerca.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAcerca.ImageOptions.LargeImage = CType(resources.GetObject("btnAcerca.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAcerca.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcerca.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.btnAcerca.ItemAppearance.Normal.Options.UseFont = True
        Me.btnAcerca.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btnAcerca.Name = "btnAcerca"
        Me.btnAcerca.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem6.Caption = "Usuario:"
        Me.BarStaticItem6.Id = 3
        Me.BarStaticItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem6.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem6.Name = "BarStaticItem6"
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem7.Caption = "Privilegios:"
        Me.BarStaticItem7.Id = 4
        Me.BarStaticItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem7.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem7.Name = "BarStaticItem7"
        '
        'BarStaticItem8
        '
        Me.BarStaticItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem8.Caption = "Nombre:"
        Me.BarStaticItem8.Id = 5
        Me.BarStaticItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem8.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem8.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem8.Name = "BarStaticItem8"
        '
        'lblRol
        '
        Me.lblRol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblRol.Caption = "---"
        Me.lblRol.Id = 6
        Me.lblRol.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblRol.ItemAppearance.Normal.Options.UseFont = True
        Me.lblRol.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblRol.Name = "lblRol"
        '
        'lblUser
        '
        Me.lblUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblUser.Caption = "---"
        Me.lblUser.Id = 7
        Me.lblUser.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblUser.ItemAppearance.Normal.Options.UseFont = True
        Me.lblUser.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblUser.Name = "lblUser"
        '
        'lblNombre
        '
        Me.lblNombre.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblNombre.Caption = "---"
        Me.lblNombre.Id = 8
        Me.lblNombre.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblNombre.ItemAppearance.Normal.Options.UseFont = True
        Me.lblNombre.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblNombre.Name = "lblNombre"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 634)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmPrincipal"
        Me.NavigationControl = Me.AccordionControl1
        Me.Text = "Menú Principal"
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
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblCompañia As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnAcerca As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem8 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblRol As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblNombre As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
End Class

Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCompañia = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 211)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 251)
        Me.Label2.MinimumSize = New System.Drawing.Size(0, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(142, 208)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(180, 29)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(142, 248)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(180, 29)
        Me.txtContraseña.TabIndex = 3
        Me.txtContraseña.Text = "Aqua2023**"
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btnIngresar
        '
        Me.btnIngresar.AllowFocus = False
        Me.btnIngresar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnIngresar.Appearance.Options.UseBackColor = True
        Me.btnIngresar.Appearance.Options.UseFont = True
        Me.btnIngresar.Appearance.Options.UseForeColor = True
        Me.btnIngresar.AppearanceHovered.BackColor = System.Drawing.Color.White
        Me.btnIngresar.AppearanceHovered.Options.UseBackColor = True
        Me.btnIngresar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnIngresar.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresar.AppearancePressed.Options.UseBackColor = True
        Me.btnIngresar.AppearancePressed.Options.UseForeColor = True
        Me.btnIngresar.ImageOptions.Image = CType(resources.GetObject("btnIngresar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnIngresar.Location = New System.Drawing.Point(237, 288)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnIngresar.Size = New System.Drawing.Size(145, 45)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "INGRESAR"
        '
        'btnSalir
        '
        Me.btnSalir.AllowFocus = False
        Me.btnSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSalir.Appearance.Options.UseBackColor = True
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseForeColor = True
        Me.btnSalir.AppearanceHovered.BackColor = System.Drawing.Color.White
        Me.btnSalir.AppearanceHovered.Options.UseBackColor = True
        Me.btnSalir.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSalir.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.AppearancePressed.Options.UseBackColor = True
        Me.btnSalir.AppearancePressed.Options.UseForeColor = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(388, 288)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSalir.Size = New System.Drawing.Size(145, 45)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "SALIR"
        '
        'btnVerPass
        '
        Me.btnVerPass.AllowFocus = False
        Me.btnVerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPass.Appearance.Options.UseFont = True
        Me.btnVerPass.ImageOptions.Image = CType(resources.GetObject("btnVerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVerPass.Location = New System.Drawing.Point(328, 248)
        Me.btnVerPass.MaximumSize = New System.Drawing.Size(43, 29)
        Me.btnVerPass.MinimumSize = New System.Drawing.Size(35, 25)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnVerPass.Size = New System.Drawing.Size(40, 29)
        Me.btnVerPass.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboCompañia)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnVerPass)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 345)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(545, 345)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(324, 211)
        Me.Label3.MinimumSize = New System.Drawing.Size(0, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Compañia:"
        '
        'cboCompañia
        '
        Me.cboCompañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompañia.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompañia.FormattingEnabled = True
        Me.cboCompañia.Location = New System.Drawing.Point(438, 208)
        Me.cboCompañia.Name = "cboCompañia"
        Me.cboCompañia.Size = New System.Drawing.Size(95, 30)
        Me.cboCompañia.TabIndex = 9
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.Image = CType(resources.GetObject("Login.IconOptions.Image"), System.Drawing.Image)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As SimpleButton
    Friend WithEvents btnSalir As SimpleButton
    Friend WithEvents btnVerPass As SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboCompañia As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Label
End Class

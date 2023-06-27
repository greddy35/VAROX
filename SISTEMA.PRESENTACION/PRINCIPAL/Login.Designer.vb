Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVerPass = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnVerPass)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 345)
        Me.Panel1.TabIndex = 0
        '
        'btnVerPass
        '
        Me.btnVerPass.AllowFocus = False
        Me.btnVerPass.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPass.Appearance.Options.UseFont = True
        Me.btnVerPass.ImageOptions.Image = CType(resources.GetObject("btnVerPass.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVerPass.Location = New System.Drawing.Point(339, 248)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnVerPass.Size = New System.Drawing.Size(43, 27)
        Me.btnVerPass.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.AllowFocus = False
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(388, 288)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSalir.Size = New System.Drawing.Size(145, 45)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "SALIR"
        '
        'btnIngresar
        '
        Me.btnIngresar.AllowFocus = False
        Me.btnIngresar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Appearance.Options.UseFont = True
        Me.btnIngresar.ImageOptions.Image = CType(resources.GetObject("btnIngresar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnIngresar.Location = New System.Drawing.Point(237, 288)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnIngresar.Size = New System.Drawing.Size(145, 45)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "INGRESAR"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(153, 248)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(180, 29)
        Me.txtContraseña.TabIndex = 3
        Me.txtContraseña.Text = "1234"
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(153, 208)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(180, 29)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresar As SimpleButton
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As SimpleButton
    Friend WithEvents btnVerPass As SimpleButton
    Friend WithEvents Timer1 As Timer
End Class

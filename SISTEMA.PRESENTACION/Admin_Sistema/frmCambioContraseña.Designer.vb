<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioContraseña))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 210)
        Me.Panel1.TabIndex = 2
        '
        'txtPassActual
        '
        Me.txtPassActual.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassActual.Location = New System.Drawing.Point(201, 14)
        Me.txtPassActual.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassActual.Size = New System.Drawing.Size(205, 32)
        Me.txtPassActual.TabIndex = 6
        Me.txtPassActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassActual.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
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
        Me.btnVerPass.Location = New System.Drawing.Point(412, 98)
        Me.btnVerPass.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.Size = New System.Drawing.Size(42, 26)
        ToolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem1.Text = "<b>Ver</b>"
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem1.Text = "Mostrar contraseñas ingresadas"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnVerPass.SuperTip = SuperToolTip1
        Me.btnVerPass.TabIndex = 9
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
        Me.btnCambiarPass.TabIndex = 10
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
        Me.btnCancelarRestablecerPass.TabIndex = 11
        Me.btnCancelarRestablecerPass.Text = "Cancelar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirmar Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Nueva:"
        '
        'frmCambioContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 210)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmCambioContraseña.IconOptions.LargeImage"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPassActual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassConfirma As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnVerPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCambiarPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelarRestablecerPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

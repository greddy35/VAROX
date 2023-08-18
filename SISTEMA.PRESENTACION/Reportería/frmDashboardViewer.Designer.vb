<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboardViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboardViewer))
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DashboardViewer1.Appearance.Options.UseBackColor = True
        Me.DashboardViewer1.AsyncMode = True
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(2, 2)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.Size = New System.Drawing.Size(936, 533)
        Me.DashboardViewer1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DashboardViewer1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(940, 537)
        Me.PanelControl1.TabIndex = 1
        '
        'frmDashboardViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 537)
        Me.Controls.Add(Me.PanelControl1)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmDashboardViewer.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "frmDashboardViewer"
        Me.Text = "Visualizador de Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class

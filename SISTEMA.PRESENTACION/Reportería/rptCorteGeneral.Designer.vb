<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCorteGeneral
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCorteGeneral))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.panel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.label37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Total = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Impuesto = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Cantidad = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Subtotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.fechaInicio = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fechaFin = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
        Me.Detail.HeightF = 217.5!
        Me.Detail.Name = "Detail"
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel2, Me.label21, Me.label20, Me.label19, Me.label18, Me.label17, Me.label16, Me.label15, Me.label14, Me.label13, Me.label12, Me.label11, Me.label10, Me.label9, Me.label8, Me.label7, Me.label6})
        Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.panel1.Name = "panel1"
        Me.panel1.SizeF = New System.Drawing.SizeF(650.0!, 199.1667!)
        '
        'panel2
        '
        Me.panel2.BorderColor = System.Drawing.Color.DarkGray
        Me.panel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.panel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label37, Me.label36, Me.label35, Me.label34, Me.label33, Me.label32, Me.label31, Me.label30, Me.label29, Me.label28, Me.label27, Me.label25, Me.label23, Me.label26, Me.label24, Me.label22})
        Me.panel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.00002!)
        Me.panel2.Name = "panel2"
        Me.panel2.SizeF = New System.Drawing.SizeF(650.0!, 107.1666!)
        Me.panel2.StylePriority.UseBorderColor = False
        Me.panel2.StylePriority.UseBorders = False
        '
        'label37
        '
        Me.label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.label37.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
        Me.label37.Font = New DevExpress.Drawing.DXFont("Arial", 12.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label37.LocationFloat = New DevExpress.Utils.PointFloat(429.1667!, 66.50001!)
        Me.label37.Multiline = True
        Me.label37.Name = "label37"
        Me.label37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label37.SizeF = New System.Drawing.SizeF(180.0!, 35.5!)
        Me.label37.StylePriority.UseBackColor = False
        Me.label37.StylePriority.UseBorders = False
        Me.label37.StylePriority.UseFont = False
        Me.label37.StylePriority.UseForeColor = False
        Me.label37.StylePriority.UseTextAlignment = False
        Me.label37.Text = "label37"
        Me.label37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label36
        '
        Me.label36.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SUBTOTAL]")})
        Me.label36.LocationFloat = New DevExpress.Utils.PointFloat(391.6667!, 10.0!)
        Me.label36.Multiline = True
        Me.label36.Name = "label36"
        Me.label36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label36.SizeF = New System.Drawing.SizeF(143.3333!, 23.0!)
        Me.label36.StylePriority.UseBorders = False
        Me.label36.StylePriority.UseTextAlignment = False
        Me.label36.Text = "label36"
        Me.label36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label35
        '
        Me.label35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IVA]")})
        Me.label35.LocationFloat = New DevExpress.Utils.PointFloat(592.5!, 33.0!)
        Me.label35.Multiline = True
        Me.label35.Name = "label35"
        Me.label35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label35.SizeF = New System.Drawing.SizeF(47.5!, 23.00001!)
        Me.label35.StylePriority.UseBorders = False
        Me.label35.StylePriority.UseTextAlignment = False
        Me.label35.Text = "label35"
        Me.label35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label34
        '
        Me.label34.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IMPUESTO]")})
        Me.label34.LocationFloat = New DevExpress.Utils.PointFloat(391.6667!, 33.0!)
        Me.label34.Multiline = True
        Me.label34.Name = "label34"
        Me.label34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label34.SizeF = New System.Drawing.SizeF(143.3333!, 23.00001!)
        Me.label34.StylePriority.UseBorders = False
        Me.label34.StylePriority.UseTextAlignment = False
        Me.label34.Text = "label34"
        Me.label34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label33
        '
        Me.label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.label33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label33.Font = New DevExpress.Drawing.DXFont("Arial", 12.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label33.LocationFloat = New DevExpress.Utils.PointFloat(298.3333!, 66.50001!)
        Me.label33.Multiline = True
        Me.label33.Name = "label33"
        Me.label33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label33.SizeF = New System.Drawing.SizeF(130.8333!, 35.5!)
        Me.label33.StylePriority.UseBackColor = False
        Me.label33.StylePriority.UseBorders = False
        Me.label33.StylePriority.UseFont = False
        Me.label33.StylePriority.UseTextAlignment = False
        Me.label33.Text = "Total $:"
        Me.label33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label32
        '
        Me.label32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LECT_ANTERIOR]")})
        Me.label32.LocationFloat = New DevExpress.Utils.PointFloat(140.8333!, 10.0!)
        Me.label32.Multiline = True
        Me.label32.Name = "label32"
        Me.label32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label32.SizeF = New System.Drawing.SizeF(144.1667!, 23.0!)
        Me.label32.StylePriority.UseBorders = False
        Me.label32.StylePriority.UseTextAlignment = False
        Me.label32.Text = "label32"
        Me.label32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label31
        '
        Me.label31.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LECT_ACTUAL]")})
        Me.label31.LocationFloat = New DevExpress.Utils.PointFloat(140.8333!, 33.0!)
        Me.label31.Multiline = True
        Me.label31.Name = "label31"
        Me.label31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label31.SizeF = New System.Drawing.SizeF(144.1667!, 23.00001!)
        Me.label31.StylePriority.UseBorders = False
        Me.label31.StylePriority.UseTextAlignment = False
        Me.label31.Text = "label31"
        Me.label31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label30
        '
        Me.label30.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CANTIDAD]")})
        Me.label30.LocationFloat = New DevExpress.Utils.PointFloat(140.8333!, 56.00001!)
        Me.label30.Multiline = True
        Me.label30.Name = "label30"
        Me.label30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label30.SizeF = New System.Drawing.SizeF(144.1667!, 23.0!)
        Me.label30.StylePriority.UseBorders = False
        Me.label30.StylePriority.UseTextAlignment = False
        Me.label30.Text = "label30"
        Me.label30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label29
        '
        Me.label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label29.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label29.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 79.00001!)
        Me.label29.Multiline = True
        Me.label29.Name = "label29"
        Me.label29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label29.SizeF = New System.Drawing.SizeF(130.8333!, 23.00001!)
        Me.label29.StylePriority.UseBackColor = False
        Me.label29.StylePriority.UseFont = False
        Me.label29.StylePriority.UseTextAlignment = False
        Me.label29.Text = "Unidad Medida:"
        Me.label29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label28
        '
        Me.label28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UNIDAD]")})
        Me.label28.LocationFloat = New DevExpress.Utils.PointFloat(140.8333!, 79.00001!)
        Me.label28.Multiline = True
        Me.label28.Name = "label28"
        Me.label28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label28.SizeF = New System.Drawing.SizeF(144.1667!, 23.0!)
        Me.label28.StylePriority.UseBorders = False
        Me.label28.StylePriority.UseTextAlignment = False
        Me.label28.Text = "label28"
        Me.label28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label27
        '
        Me.label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label27.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label27.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 56.00001!)
        Me.label27.Multiline = True
        Me.label27.Name = "label27"
        Me.label27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label27.SizeF = New System.Drawing.SizeF(130.8333!, 23.00001!)
        Me.label27.StylePriority.UseBackColor = False
        Me.label27.StylePriority.UseFont = False
        Me.label27.StylePriority.UseTextAlignment = False
        Me.label27.Text = "Consumo:"
        Me.label27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label25
        '
        Me.label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label25.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label25.LocationFloat = New DevExpress.Utils.PointFloat(298.3333!, 10.0!)
        Me.label25.Multiline = True
        Me.label25.Name = "label25"
        Me.label25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label25.SizeF = New System.Drawing.SizeF(93.33331!, 23.0!)
        Me.label25.StylePriority.UseBackColor = False
        Me.label25.StylePriority.UseFont = False
        Me.label25.StylePriority.UseTextAlignment = False
        Me.label25.Text = "SubTotal $:"
        Me.label25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label23
        '
        Me.label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label23.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label23.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 33.0!)
        Me.label23.Multiline = True
        Me.label23.Name = "label23"
        Me.label23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label23.SizeF = New System.Drawing.SizeF(130.8333!, 23.00001!)
        Me.label23.StylePriority.UseBackColor = False
        Me.label23.StylePriority.UseFont = False
        Me.label23.StylePriority.UseTextAlignment = False
        Me.label23.Text = "Lectura Actual:"
        Me.label23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label26
        '
        Me.label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label26.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label26.LocationFloat = New DevExpress.Utils.PointFloat(298.3333!, 33.0!)
        Me.label26.Multiline = True
        Me.label26.Name = "label26"
        Me.label26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label26.SizeF = New System.Drawing.SizeF(93.33331!, 23.00001!)
        Me.label26.StylePriority.UseBackColor = False
        Me.label26.StylePriority.UseFont = False
        Me.label26.StylePriority.UseTextAlignment = False
        Me.label26.Text = "Monto IVA $:"
        Me.label26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label24
        '
        Me.label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label24.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label24.LocationFloat = New DevExpress.Utils.PointFloat(535.0!, 33.0!)
        Me.label24.Multiline = True
        Me.label24.Name = "label24"
        Me.label24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label24.SizeF = New System.Drawing.SizeF(57.5!, 23.00001!)
        Me.label24.StylePriority.UseBackColor = False
        Me.label24.StylePriority.UseFont = False
        Me.label24.StylePriority.UseTextAlignment = False
        Me.label24.Text = "IVA(%):"
        Me.label24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label22
        '
        Me.label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label22.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 9.999992!)
        Me.label22.Multiline = True
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label22.SizeF = New System.Drawing.SizeF(130.8333!, 23.00001!)
        Me.label22.StylePriority.UseBackColor = False
        Me.label22.StylePriority.UseFont = False
        Me.label22.StylePriority.UseTextAlignment = False
        Me.label22.Text = "Lectura Anterior:"
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label21
        '
        Me.label21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VALVULA]")})
        Me.label21.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(471.6667!, 69.00002!)
        Me.label21.Multiline = True
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label21.SizeF = New System.Drawing.SizeF(178.3333!, 23.0!)
        Me.label21.StylePriority.UseBorders = False
        Me.label21.StylePriority.UseFont = False
        Me.label21.StylePriority.UseTextAlignment = False
        Me.label21.Text = "label21"
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label20
        '
        Me.label20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VALVULA_PADRE]")})
        Me.label20.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(471.6667!, 46.00001!)
        Me.label20.Multiline = True
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label20.SizeF = New System.Drawing.SizeF(178.3333!, 23.0!)
        Me.label20.StylePriority.UseBorders = False
        Me.label20.StylePriority.UseFont = False
        Me.label20.StylePriority.UseTextAlignment = False
        Me.label20.Text = "label20"
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label19
        '
        Me.label19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TIPO_VALVULA]")})
        Me.label19.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(455.8333!, 23.00001!)
        Me.label19.Multiline = True
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label19.SizeF = New System.Drawing.SizeF(194.1667!, 23.0!)
        Me.label19.StylePriority.UseBorders = False
        Me.label19.StylePriority.UseFont = False
        Me.label19.StylePriority.UseTextAlignment = False
        Me.label19.Text = "label19"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label18
        '
        Me.label18.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TIPO_MEDICION]")})
        Me.label18.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(455.8333!, 0!)
        Me.label18.Multiline = True
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label18.SizeF = New System.Drawing.SizeF(194.1667!, 23.0!)
        Me.label18.StylePriority.UseBorders = False
        Me.label18.StylePriority.UseFont = False
        Me.label18.StylePriority.UseTextAlignment = False
        Me.label18.Text = "label18"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label17
        '
        Me.label17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CODIGO_LOCAL]")})
        Me.label17.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!)
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 69.00002!)
        Me.label17.Multiline = True
        Me.label17.Name = "label17"
        Me.label17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label17.SizeF = New System.Drawing.SizeF(235.8333!, 23.0!)
        Me.label17.StylePriority.UseBorders = False
        Me.label17.StylePriority.UseFont = False
        Me.label17.StylePriority.UseTextAlignment = False
        Me.label17.Text = "label17"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label16
        '
        Me.label16.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NIT]")})
        Me.label16.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!)
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 23.00001!)
        Me.label16.Multiline = True
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label16.SizeF = New System.Drawing.SizeF(235.8333!, 23.0!)
        Me.label16.StylePriority.UseBorders = False
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "label16"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NOMBRE_LOCAL]")})
        Me.label15.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 46.00001!)
        Me.label15.Multiline = True
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label15.SizeF = New System.Drawing.SizeF(235.8333!, 23.0!)
        Me.label15.StylePriority.UseBorders = False
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "label15"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NOMBRE_CLIENTE]")})
        Me.label14.Font = New DevExpress.Drawing.DXFont("Arial", 8.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 0.000005066395!)
        Me.label14.Multiline = True
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label14.SizeF = New System.Drawing.SizeF(235.8333!, 23.0!)
        Me.label14.StylePriority.UseBorders = False
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "label14"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label13
        '
        Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label13.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label13.ForeColor = System.Drawing.Color.Black
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(345.8333!, 69.00002!)
        Me.label13.Multiline = True
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label13.SizeF = New System.Drawing.SizeF(125.8333!, 23.0!)
        Me.label13.StylePriority.UseBackColor = False
        Me.label13.StylePriority.UseBorders = False
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseForeColor = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "VÁLVULA HIJA:"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label12.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(345.8333!, 46.00001!)
        Me.label12.Multiline = True
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label12.SizeF = New System.Drawing.SizeF(125.8333!, 23.0!)
        Me.label12.StylePriority.UseBackColor = False
        Me.label12.StylePriority.UseBorders = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseForeColor = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "VÁLVULA PADRE:"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label11.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label11.ForeColor = System.Drawing.Color.Black
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(345.8333!, 23.00001!)
        Me.label11.Multiline = True
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label11.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label11.StylePriority.UseBackColor = False
        Me.label11.StylePriority.UseBorders = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseForeColor = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "TIPO VÁLVULA:"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label10.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label10.ForeColor = System.Drawing.Color.Black
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(345.8333!, 0!)
        Me.label10.Multiline = True
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label10.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label10.StylePriority.UseBackColor = False
        Me.label10.StylePriority.UseBorders = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseForeColor = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "TIPO MEDICIÓN:"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label9.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.00003!)
        Me.label9.Multiline = True
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label9.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label9.StylePriority.UseBackColor = False
        Me.label9.StylePriority.UseBorders = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseForeColor = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "CÓDIGO LOCAL:"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label8.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label8.ForeColor = System.Drawing.Color.Black
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23.00001!)
        Me.label8.Multiline = True
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label8.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label8.StylePriority.UseBackColor = False
        Me.label8.StylePriority.UseBorders = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseForeColor = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "NIT CLIENTE:"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label7.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.00002!)
        Me.label7.Multiline = True
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label7.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label7.StylePriority.UseBackColor = False
        Me.label7.StylePriority.UseBorders = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseForeColor = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "LOCAL:"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.label6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label6.Font = New DevExpress.Drawing.DXFont("Arial", 7.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label6.Multiline = True
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label6.SizeF = New System.Drawing.SizeF(110.0!, 23.0!)
        Me.label6.StylePriority.UseBackColor = False
        Me.label6.StylePriority.UseBorders = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseForeColor = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "CLIENTE:"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 110.8333!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label5, Me.label4, Me.label3, Me.label2, Me.label1})
        Me.PageHeader.HeightF = 82.5!
        Me.PageHeader.Name = "PageHeader"
        '
        'label5
        '
        Me.label5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fechaInicio")})
        Me.label5.Font = New DevExpress.Drawing.DXFont("Arial", 11.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(130.0!, 29.66667!)
        Me.label5.Multiline = True
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label5.SizeF = New System.Drawing.SizeF(138.3333!, 23.0!)
        Me.label5.StylePriority.UseBorders = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "label5"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label5.TextFormatString = "{0:d}"
        '
        'label4
        '
        Me.label4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fechaFin")})
        Me.label4.Font = New DevExpress.Drawing.DXFont("Arial", 11.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(130.0!, 52.66668!)
        Me.label4.Multiline = True
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label4.SizeF = New System.Drawing.SizeF(138.3333!, 23.0!)
        Me.label4.StylePriority.UseBorders = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "label4"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label4.TextFormatString = "{0:d}"
        '
        'label3
        '
        Me.label3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label3.Font = New DevExpress.Drawing.DXFont("Arial", 10.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 52.66669!)
        Me.label3.Multiline = True
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label3.SizeF = New System.Drawing.SizeF(120.0!, 23.0!)
        Me.label3.StylePriority.UseBorders = False
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseTextAlignment = False
        Me.label3.Text = "Fecha Hasta:"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label2.Font = New DevExpress.Drawing.DXFont("Arial", 10.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 29.66669!)
        Me.label2.Multiline = True
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label2.SizeF = New System.Drawing.SizeF(120.0!, 23.0!)
        Me.label2.StylePriority.UseBorders = False
        Me.label2.StylePriority.UseFont = False
        Me.label2.StylePriority.UseTextAlignment = False
        Me.label2.Text = "Fecha Desde:"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.label1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.label1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label1.BorderWidth = 1.0!
        Me.label1.Font = New DevExpress.Drawing.DXFont("Arial", 13.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0.000006357829!)
        Me.label1.Multiline = True
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.SizeF = New System.Drawing.SizeF(650.0!, 29.66667!)
        Me.label1.StylePriority.UseBackColor = False
        Me.label1.StylePriority.UseBorderColor = False
        Me.label1.StylePriority.UseBorders = False
        Me.label1.StylePriority.UseBorderWidth = False
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "Corte General de Consumos"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionName = "VAROXConnectionString"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        StoredProcQuery1.Name = "R_consultarHistorico"
        QueryParameter1.Name = "@fechaIni"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?fechaInicio", GetType(Date))
        QueryParameter2.Name = "@fechaFin"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?fechaFin", GetType(Date))
        StoredProcQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2})
        StoredProcQuery1.StoredProcName = "R_consultarHistoricoConsol"
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'Total
        '
        Me.Total.DataMember = "R_consultarHistorico"
        Me.Total.Expression = "Round([SUBTOTAL] + [IMPUESTO],2)"
        Me.Total.FieldType = DevExpress.XtraReports.UI.FieldType.Float
        Me.Total.Name = "Total"
        '
        'Impuesto
        '
        Me.Impuesto.DataMember = "R_consultarHistorico"
        Me.Impuesto.Expression = "Round([Subtotal]*[IVA],2)"
        Me.Impuesto.Name = "Impuesto"
        '
        'Cantidad
        '
        Me.Cantidad.DataMember = "R_consultarHistorico"
        Me.Cantidad.Expression = "Round([LECT_ACTUAL]-[LECT_ANTERIOR],2)"
        Me.Cantidad.Name = "Cantidad"
        '
        'Subtotal
        '
        Me.Subtotal.DataMember = "R_consultarHistorico"
        Me.Subtotal.Expression = "Round([Cantidad]*[VALOR_UNIDAD],2)"
        Me.Subtotal.Name = "Subtotal"
        '
        'fechaInicio
        '
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.Type = GetType(Date)
        Me.fechaInicio.ValueInfo = "2023-01-01"
        '
        'fechaFin
        '
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.Type = GetType(Date)
        Me.fechaFin.ValueInfo = "2023-12-31"
        '
        'rptCorteGeneral
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Total, Me.Impuesto, Me.Cantidad, Me.Subtotal})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "R_consultarHistorico"
        Me.DataSource = Me.sqlDataSource1
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(100.0!, 100.0!, 100.0!, 110.8333!)
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.fechaInicio, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.fechaFin, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.fechaInicio, Me.fechaFin})
        Me.RequestParameters = False
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents panel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents panel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents label37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Impuesto As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Cantidad As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Subtotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents fechaInicio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fechaFin As DevExpress.XtraReports.Parameters.Parameter
End Class

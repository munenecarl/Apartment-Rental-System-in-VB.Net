<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(49, 649)
        Me.Panel1.TabIndex = 0
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = ""
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Empty
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.Empty
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeft = CType(resources.GetObject("BunifuButton1.IconLeft"), System.Drawing.Image)
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 0
        Me.BunifuButton1.IconRight = Nothing
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton1.IdleBorderRadius = 0
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.Empty
        Me.BunifuButton1.IdleIconLeftImage = CType(resources.GetObject("BunifuButton1.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(109, 535)
        Me.BunifuButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 35
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 35
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BunifuButton1.OnIdleState.BorderRadius = 35
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton1.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 35
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(95, 50)
        Me.BunifuButton1.TabIndex = 1
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(109, 157)
        Me.BunifuDataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowHeadersWidth = 62
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(1129, 189)
        Me.BunifuDataGridView1.TabIndex = 2
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BunifuLabel1.Location = New System.Drawing.Point(508, 88)
        Me.BunifuLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(249, 28)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "House Vacation Form"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = "Delete tenant details"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges2
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.Empty
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.Empty
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeft = Nothing
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRight = Nothing
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton2.IdleBorderRadius = 0
        Me.BunifuButton2.IdleBorderThickness = 0
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.Empty
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(1017, 530)
        Me.BunifuButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 30
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 1
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.BorderRadius = 30
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 1
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.OnIdleState.BorderRadius = 30
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 1
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton2.OnPressedState.BorderRadius = 30
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 1
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(221, 61)
        Me.BunifuButton2.TabIndex = 4
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BunifuButton1
        Me.ClientSize = New System.Drawing.Size(1317, 649)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class

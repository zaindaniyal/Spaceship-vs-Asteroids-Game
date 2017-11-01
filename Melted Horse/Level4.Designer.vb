<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrPlane = New System.Windows.Forms.Timer(Me.components)
        Me.imgPlane = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrAsteroid = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroidSlow = New System.Windows.Forms.Timer(Me.components)
        Me.imgPlaneVertical = New System.Windows.Forms.ImageList(Me.components)
        Me.pctXXtraBottomBoundry = New System.Windows.Forms.PictureBox()
        Me.pctAsteroid4 = New System.Windows.Forms.PictureBox()
        Me.pctFinishLine = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctDiomondFinal = New System.Windows.Forms.PictureBox()
        Me.pctDiomond = New System.Windows.Forms.PictureBox()
        Me.pctAsteroid3 = New System.Windows.Forms.PictureBox()
        Me.pctAsteroid2 = New System.Windows.Forms.PictureBox()
        Me.pctAsteroidSlow = New System.Windows.Forms.PictureBox()
        Me.pctAsteroid = New System.Windows.Forms.PictureBox()
        Me.pctGreenEnergy = New System.Windows.Forms.PictureBox()
        Me.pctConstantBlackEnergy = New System.Windows.Forms.PictureBox()
        Me.pctClose = New System.Windows.Forms.PictureBox()
        Me.pctStartLine = New System.Windows.Forms.PictureBox()
        Me.pctCloseSelected = New System.Windows.Forms.PictureBox()
        Me.pctTopBoundry = New System.Windows.Forms.PictureBox()
        Me.pctLeftPlaneBoundry = New System.Windows.Forms.PictureBox()
        Me.pctRightPlaneBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraTopBoundry = New System.Windows.Forms.PictureBox()
        Me.pctPlane = New System.Windows.Forms.PictureBox()
        Me.pctPlaneBottomBoundryLeft = New System.Windows.Forms.PictureBox()
        Me.pctXtraRightBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraLeftBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraBottomBoundry = New System.Windows.Forms.PictureBox()
        Me.pctPlaneBottomBoundryRight = New System.Windows.Forms.PictureBox()
        Me.pctAsteroid5 = New System.Windows.Forms.PictureBox()
        CType(Me.pctXXtraBottomBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDiomondFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDiomond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroidSlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGreenEnergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctConstantBlackEnergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctStartLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCloseSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTopBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLeftPlaneBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRightPlaneBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraTopBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlaneBottomBoundryLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraRightBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraLeftBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraBottomBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlaneBottomBoundryRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAsteroid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(650, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Level 4"
        '
        'tmrPlane
        '
        Me.tmrPlane.Enabled = True
        Me.tmrPlane.Interval = 20
        '
        'imgPlane
        '
        Me.imgPlane.ImageStream = CType(resources.GetObject("imgPlane.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgPlane.TransparentColor = System.Drawing.Color.Transparent
        Me.imgPlane.Images.SetKeyName(0, "Rocket West.png")
        Me.imgPlane.Images.SetKeyName(1, "Rocket.png")
        '
        'tmrAsteroid
        '
        Me.tmrAsteroid.Enabled = True
        Me.tmrAsteroid.Interval = 20
        '
        'tmrAsteroidSlow
        '
        Me.tmrAsteroidSlow.Enabled = True
        Me.tmrAsteroidSlow.Interval = 50
        '
        'imgPlaneVertical
        '
        Me.imgPlaneVertical.ImageStream = CType(resources.GetObject("imgPlaneVertical.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgPlaneVertical.TransparentColor = System.Drawing.Color.Transparent
        Me.imgPlaneVertical.Images.SetKeyName(0, "Rocket South.png")
        Me.imgPlaneVertical.Images.SetKeyName(1, "Rocket North.png")
        '
        'pctXXtraBottomBoundry
        '
        Me.pctXXtraBottomBoundry.Location = New System.Drawing.Point(91, 601)
        Me.pctXXtraBottomBoundry.Name = "pctXXtraBottomBoundry"
        Me.pctXXtraBottomBoundry.Size = New System.Drawing.Size(708, 5)
        Me.pctXXtraBottomBoundry.TabIndex = 78
        Me.pctXXtraBottomBoundry.TabStop = False
        '
        'pctAsteroid4
        '
        Me.pctAsteroid4.Image = CType(resources.GetObject("pctAsteroid4.Image"), System.Drawing.Image)
        Me.pctAsteroid4.Location = New System.Drawing.Point(406, 465)
        Me.pctAsteroid4.Name = "pctAsteroid4"
        Me.pctAsteroid4.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid4.TabIndex = 76
        Me.pctAsteroid4.TabStop = False
        '
        'pctFinishLine
        '
        Me.pctFinishLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctFinishLine.Location = New System.Drawing.Point(764, 40)
        Me.pctFinishLine.Name = "pctFinishLine"
        Me.pctFinishLine.Size = New System.Drawing.Size(15, 514)
        Me.pctFinishLine.TabIndex = 55
        Me.pctFinishLine.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(71, 543)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(708, 11)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'pctDiomondFinal
        '
        Me.pctDiomondFinal.BackColor = System.Drawing.Color.Transparent
        Me.pctDiomondFinal.BackgroundImage = CType(resources.GetObject("pctDiomondFinal.BackgroundImage"), System.Drawing.Image)
        Me.pctDiomondFinal.Image = CType(resources.GetObject("pctDiomondFinal.Image"), System.Drawing.Image)
        Me.pctDiomondFinal.Location = New System.Drawing.Point(614, 275)
        Me.pctDiomondFinal.Name = "pctDiomondFinal"
        Me.pctDiomondFinal.Size = New System.Drawing.Size(10, 10)
        Me.pctDiomondFinal.TabIndex = 71
        Me.pctDiomondFinal.TabStop = False
        '
        'pctDiomond
        '
        Me.pctDiomond.BackColor = System.Drawing.Color.Transparent
        Me.pctDiomond.BackgroundImage = CType(resources.GetObject("pctDiomond.BackgroundImage"), System.Drawing.Image)
        Me.pctDiomond.Image = CType(resources.GetObject("pctDiomond.Image"), System.Drawing.Image)
        Me.pctDiomond.Location = New System.Drawing.Point(614, 334)
        Me.pctDiomond.Name = "pctDiomond"
        Me.pctDiomond.Size = New System.Drawing.Size(10, 10)
        Me.pctDiomond.TabIndex = 70
        Me.pctDiomond.TabStop = False
        '
        'pctAsteroid3
        '
        Me.pctAsteroid3.Image = CType(resources.GetObject("pctAsteroid3.Image"), System.Drawing.Image)
        Me.pctAsteroid3.Location = New System.Drawing.Point(654, 63)
        Me.pctAsteroid3.Name = "pctAsteroid3"
        Me.pctAsteroid3.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid3.TabIndex = 69
        Me.pctAsteroid3.TabStop = False
        '
        'pctAsteroid2
        '
        Me.pctAsteroid2.Image = CType(resources.GetObject("pctAsteroid2.Image"), System.Drawing.Image)
        Me.pctAsteroid2.Location = New System.Drawing.Point(406, 235)
        Me.pctAsteroid2.Name = "pctAsteroid2"
        Me.pctAsteroid2.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid2.TabIndex = 68
        Me.pctAsteroid2.TabStop = False
        '
        'pctAsteroidSlow
        '
        Me.pctAsteroidSlow.Image = CType(resources.GetObject("pctAsteroidSlow.Image"), System.Drawing.Image)
        Me.pctAsteroidSlow.Location = New System.Drawing.Point(415, 323)
        Me.pctAsteroidSlow.Name = "pctAsteroidSlow"
        Me.pctAsteroidSlow.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroidSlow.TabIndex = 65
        Me.pctAsteroidSlow.TabStop = False
        '
        'pctAsteroid
        '
        Me.pctAsteroid.Image = CType(resources.GetObject("pctAsteroid.Image"), System.Drawing.Image)
        Me.pctAsteroid.Location = New System.Drawing.Point(399, 114)
        Me.pctAsteroid.Name = "pctAsteroid"
        Me.pctAsteroid.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid.TabIndex = 61
        Me.pctAsteroid.TabStop = False
        '
        'pctGreenEnergy
        '
        Me.pctGreenEnergy.BackColor = System.Drawing.Color.Lime
        Me.pctGreenEnergy.Location = New System.Drawing.Point(70, 10)
        Me.pctGreenEnergy.Name = "pctGreenEnergy"
        Me.pctGreenEnergy.Size = New System.Drawing.Size(567, 20)
        Me.pctGreenEnergy.TabIndex = 60
        Me.pctGreenEnergy.TabStop = False
        '
        'pctConstantBlackEnergy
        '
        Me.pctConstantBlackEnergy.BackColor = System.Drawing.Color.Black
        Me.pctConstantBlackEnergy.Location = New System.Drawing.Point(70, 10)
        Me.pctConstantBlackEnergy.Name = "pctConstantBlackEnergy"
        Me.pctConstantBlackEnergy.Size = New System.Drawing.Size(567, 20)
        Me.pctConstantBlackEnergy.TabIndex = 59
        Me.pctConstantBlackEnergy.TabStop = False
        '
        'pctClose
        '
        Me.pctClose.Image = CType(resources.GetObject("pctClose.Image"), System.Drawing.Image)
        Me.pctClose.Location = New System.Drawing.Point(12, 10)
        Me.pctClose.Name = "pctClose"
        Me.pctClose.Size = New System.Drawing.Size(32, 32)
        Me.pctClose.TabIndex = 56
        Me.pctClose.TabStop = False
        '
        'pctStartLine
        '
        Me.pctStartLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctStartLine.Location = New System.Drawing.Point(70, 39)
        Me.pctStartLine.Name = "pctStartLine"
        Me.pctStartLine.Size = New System.Drawing.Size(15, 514)
        Me.pctStartLine.TabIndex = 53
        Me.pctStartLine.TabStop = False
        '
        'pctCloseSelected
        '
        Me.pctCloseSelected.Image = CType(resources.GetObject("pctCloseSelected.Image"), System.Drawing.Image)
        Me.pctCloseSelected.Location = New System.Drawing.Point(5, 2)
        Me.pctCloseSelected.Name = "pctCloseSelected"
        Me.pctCloseSelected.Size = New System.Drawing.Size(47, 47)
        Me.pctCloseSelected.TabIndex = 57
        Me.pctCloseSelected.TabStop = False
        '
        'pctTopBoundry
        '
        Me.pctTopBoundry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctTopBoundry.Location = New System.Drawing.Point(70, 39)
        Me.pctTopBoundry.Name = "pctTopBoundry"
        Me.pctTopBoundry.Size = New System.Drawing.Size(709, 11)
        Me.pctTopBoundry.TabIndex = 58
        Me.pctTopBoundry.TabStop = False
        '
        'pctLeftPlaneBoundry
        '
        Me.pctLeftPlaneBoundry.Location = New System.Drawing.Point(-1, 44)
        Me.pctLeftPlaneBoundry.Name = "pctLeftPlaneBoundry"
        Me.pctLeftPlaneBoundry.Size = New System.Drawing.Size(5, 560)
        Me.pctLeftPlaneBoundry.TabIndex = 66
        Me.pctLeftPlaneBoundry.TabStop = False
        '
        'pctRightPlaneBoundry
        '
        Me.pctRightPlaneBoundry.Location = New System.Drawing.Point(870, 44)
        Me.pctRightPlaneBoundry.Name = "pctRightPlaneBoundry"
        Me.pctRightPlaneBoundry.Size = New System.Drawing.Size(5, 560)
        Me.pctRightPlaneBoundry.TabIndex = 67
        Me.pctRightPlaneBoundry.TabStop = False
        '
        'pctXtraTopBoundry
        '
        Me.pctXtraTopBoundry.Location = New System.Drawing.Point(-17, 63)
        Me.pctXtraTopBoundry.Name = "pctXtraTopBoundry"
        Me.pctXtraTopBoundry.Size = New System.Drawing.Size(894, 5)
        Me.pctXtraTopBoundry.TabIndex = 63
        Me.pctXtraTopBoundry.TabStop = False
        '
        'pctPlane
        '
        Me.pctPlane.Image = CType(resources.GetObject("pctPlane.Image"), System.Drawing.Image)
        Me.pctPlane.Location = New System.Drawing.Point(10, 304)
        Me.pctPlane.Name = "pctPlane"
        Me.pctPlane.Size = New System.Drawing.Size(60, 60)
        Me.pctPlane.TabIndex = 54
        Me.pctPlane.TabStop = False
        '
        'pctPlaneBottomBoundryLeft
        '
        Me.pctPlaneBottomBoundryLeft.Location = New System.Drawing.Point(75, 522)
        Me.pctPlaneBottomBoundryLeft.Name = "pctPlaneBottomBoundryLeft"
        Me.pctPlaneBottomBoundryLeft.Size = New System.Drawing.Size(5, 109)
        Me.pctPlaneBottomBoundryLeft.TabIndex = 75
        Me.pctPlaneBottomBoundryLeft.TabStop = False
        '
        'pctXtraRightBoundry
        '
        Me.pctXtraRightBoundry.Location = New System.Drawing.Point(744, 42)
        Me.pctXtraRightBoundry.Name = "pctXtraRightBoundry"
        Me.pctXtraRightBoundry.Size = New System.Drawing.Size(5, 508)
        Me.pctXtraRightBoundry.TabIndex = 64
        Me.pctXtraRightBoundry.TabStop = False
        '
        'pctXtraLeftBoundry
        '
        Me.pctXtraLeftBoundry.Location = New System.Drawing.Point(104, 48)
        Me.pctXtraLeftBoundry.Name = "pctXtraLeftBoundry"
        Me.pctXtraLeftBoundry.Size = New System.Drawing.Size(5, 508)
        Me.pctXtraLeftBoundry.TabIndex = 62
        Me.pctXtraLeftBoundry.TabStop = False
        '
        'pctXtraBottomBoundry
        '
        Me.pctXtraBottomBoundry.Location = New System.Drawing.Point(114, 512)
        Me.pctXtraBottomBoundry.Name = "pctXtraBottomBoundry"
        Me.pctXtraBottomBoundry.Size = New System.Drawing.Size(662, 10)
        Me.pctXtraBottomBoundry.TabIndex = 73
        Me.pctXtraBottomBoundry.TabStop = False
        '
        'pctPlaneBottomBoundryRight
        '
        Me.pctPlaneBottomBoundryRight.Location = New System.Drawing.Point(91, 522)
        Me.pctPlaneBottomBoundryRight.Name = "pctPlaneBottomBoundryRight"
        Me.pctPlaneBottomBoundryRight.Size = New System.Drawing.Size(5, 109)
        Me.pctPlaneBottomBoundryRight.TabIndex = 77
        Me.pctPlaneBottomBoundryRight.TabStop = False
        '
        'pctAsteroid5
        '
        Me.pctAsteroid5.Image = CType(resources.GetObject("pctAsteroid5.Image"), System.Drawing.Image)
        Me.pctAsteroid5.Location = New System.Drawing.Point(104, 63)
        Me.pctAsteroid5.Name = "pctAsteroid5"
        Me.pctAsteroid5.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid5.TabIndex = 79
        Me.pctAsteroid5.TabStop = False
        '
        'Level4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(874, 606)
        Me.Controls.Add(Me.pctAsteroid5)
        Me.Controls.Add(Me.pctXXtraBottomBoundry)
        Me.Controls.Add(Me.pctFinishLine)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctDiomondFinal)
        Me.Controls.Add(Me.pctDiomond)
        Me.Controls.Add(Me.pctAsteroid2)
        Me.Controls.Add(Me.pctAsteroidSlow)
        Me.Controls.Add(Me.pctAsteroid)
        Me.Controls.Add(Me.pctGreenEnergy)
        Me.Controls.Add(Me.pctConstantBlackEnergy)
        Me.Controls.Add(Me.pctClose)
        Me.Controls.Add(Me.pctStartLine)
        Me.Controls.Add(Me.pctCloseSelected)
        Me.Controls.Add(Me.pctTopBoundry)
        Me.Controls.Add(Me.pctLeftPlaneBoundry)
        Me.Controls.Add(Me.pctRightPlaneBoundry)
        Me.Controls.Add(Me.pctPlane)
        Me.Controls.Add(Me.pctPlaneBottomBoundryLeft)
        Me.Controls.Add(Me.pctPlaneBottomBoundryRight)
        Me.Controls.Add(Me.pctAsteroid3)
        Me.Controls.Add(Me.pctAsteroid4)
        Me.Controls.Add(Me.pctXtraBottomBoundry)
        Me.Controls.Add(Me.pctXtraRightBoundry)
        Me.Controls.Add(Me.pctXtraLeftBoundry)
        Me.Controls.Add(Me.pctXtraTopBoundry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Level4"
        Me.Text = "The Real World's Hardest Game"
        CType(Me.pctXXtraBottomBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDiomondFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDiomond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroidSlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGreenEnergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctConstantBlackEnergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctStartLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCloseSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTopBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLeftPlaneBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRightPlaneBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraTopBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlaneBottomBoundryLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraRightBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraLeftBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraBottomBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlaneBottomBoundryRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAsteroid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctXXtraBottomBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid4 As System.Windows.Forms.PictureBox
    Friend WithEvents pctFinishLine As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pctDiomondFinal As System.Windows.Forms.PictureBox
    Friend WithEvents pctDiomond As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroidSlow As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid As System.Windows.Forms.PictureBox
    Friend WithEvents pctGreenEnergy As System.Windows.Forms.PictureBox
    Friend WithEvents pctConstantBlackEnergy As System.Windows.Forms.PictureBox
    Friend WithEvents pctClose As System.Windows.Forms.PictureBox
    Friend WithEvents pctStartLine As System.Windows.Forms.PictureBox
    Friend WithEvents pctCloseSelected As System.Windows.Forms.PictureBox
    Friend WithEvents pctTopBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctLeftPlaneBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctRightPlaneBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraTopBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlane As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlaneBottomBoundryLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraRightBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlane As System.Windows.Forms.Timer
    Friend WithEvents pctXtraLeftBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraBottomBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlane As System.Windows.Forms.ImageList
    Friend WithEvents pctPlaneBottomBoundryRight As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAsteroid As System.Windows.Forms.Timer
    Friend WithEvents tmrAsteroidSlow As System.Windows.Forms.Timer
    Friend WithEvents imgPlaneVertical As System.Windows.Forms.ImageList
    Friend WithEvents pctAsteroid5 As System.Windows.Forms.PictureBox
End Class

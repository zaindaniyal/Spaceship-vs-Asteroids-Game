<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class theGame1stLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(theGame1stLevel))
        Me.tmrPlane = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroid = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAsteroidSlow = New System.Windows.Forms.Timer(Me.components)
        Me.imgPlane = New System.Windows.Forms.ImageList(Me.components)
        Me.imgPlaneVertical = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctAbout = New System.Windows.Forms.PictureBox()
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
        Me.pctFinishLine = New System.Windows.Forms.PictureBox()
        Me.pctStartLine = New System.Windows.Forms.PictureBox()
        Me.pctCloseSelected = New System.Windows.Forms.PictureBox()
        Me.pctTopBoundry = New System.Windows.Forms.PictureBox()
        Me.pctLeftPlaneBoundry = New System.Windows.Forms.PictureBox()
        Me.pctRightPlaneBoundry = New System.Windows.Forms.PictureBox()
        Me.pctPlane = New System.Windows.Forms.PictureBox()
        Me.pctXtraLeftBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraTopBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraRightBoundry = New System.Windows.Forms.PictureBox()
        Me.pctXtraBottomBoundry = New System.Windows.Forms.PictureBox()
        Me.pctSelectedAbout = New System.Windows.Forms.PictureBox()
        CType(Me.pctAbout, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.pctFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctStartLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCloseSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTopBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLeftPlaneBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRightPlaneBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraLeftBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraTopBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraRightBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctXtraBottomBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSelectedAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlane
        '
        Me.tmrPlane.Enabled = True
        Me.tmrPlane.Interval = 20
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
        'imgPlane
        '
        Me.imgPlane.ImageStream = CType(resources.GetObject("imgPlane.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgPlane.TransparentColor = System.Drawing.Color.Transparent
        Me.imgPlane.Images.SetKeyName(0, "Rocket West.png")
        Me.imgPlane.Images.SetKeyName(1, "Rocket.png")
        '
        'imgPlaneVertical
        '
        Me.imgPlaneVertical.ImageStream = CType(resources.GetObject("imgPlaneVertical.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgPlaneVertical.TransparentColor = System.Drawing.Color.Transparent
        Me.imgPlaneVertical.Images.SetKeyName(0, "Rocket South.png")
        Me.imgPlaneVertical.Images.SetKeyName(1, "Rocket North.png")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(649, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Level 1"
        '
        'pctAbout
        '
        Me.pctAbout.Image = CType(resources.GetObject("pctAbout.Image"), System.Drawing.Image)
        Me.pctAbout.Location = New System.Drawing.Point(760, 9)
        Me.pctAbout.Name = "pctAbout"
        Me.pctAbout.Size = New System.Drawing.Size(100, 28)
        Me.pctAbout.TabIndex = 23
        Me.pctAbout.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(71, 545)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(708, 11)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'pctDiomondFinal
        '
        Me.pctDiomondFinal.BackColor = System.Drawing.Color.Transparent
        Me.pctDiomondFinal.BackgroundImage = CType(resources.GetObject("pctDiomondFinal.BackgroundImage"), System.Drawing.Image)
        Me.pctDiomondFinal.Image = CType(resources.GetObject("pctDiomondFinal.Image"), System.Drawing.Image)
        Me.pctDiomondFinal.Location = New System.Drawing.Point(276, 136)
        Me.pctDiomondFinal.Name = "pctDiomondFinal"
        Me.pctDiomondFinal.Size = New System.Drawing.Size(10, 10)
        Me.pctDiomondFinal.TabIndex = 20
        Me.pctDiomondFinal.TabStop = False
        '
        'pctDiomond
        '
        Me.pctDiomond.BackColor = System.Drawing.Color.Transparent
        Me.pctDiomond.BackgroundImage = CType(resources.GetObject("pctDiomond.BackgroundImage"), System.Drawing.Image)
        Me.pctDiomond.Image = CType(resources.GetObject("pctDiomond.Image"), System.Drawing.Image)
        Me.pctDiomond.Location = New System.Drawing.Point(665, 336)
        Me.pctDiomond.Name = "pctDiomond"
        Me.pctDiomond.Size = New System.Drawing.Size(10, 10)
        Me.pctDiomond.TabIndex = 18
        Me.pctDiomond.TabStop = False
        '
        'pctAsteroid3
        '
        Me.pctAsteroid3.Image = CType(resources.GetObject("pctAsteroid3.Image"), System.Drawing.Image)
        Me.pctAsteroid3.Location = New System.Drawing.Point(635, 98)
        Me.pctAsteroid3.Name = "pctAsteroid3"
        Me.pctAsteroid3.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid3.TabIndex = 16
        Me.pctAsteroid3.TabStop = False
        '
        'pctAsteroid2
        '
        Me.pctAsteroid2.Image = CType(resources.GetObject("pctAsteroid2.Image"), System.Drawing.Image)
        Me.pctAsteroid2.Location = New System.Drawing.Point(406, 237)
        Me.pctAsteroid2.Name = "pctAsteroid2"
        Me.pctAsteroid2.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid2.TabIndex = 15
        Me.pctAsteroid2.TabStop = False
        '
        'pctAsteroidSlow
        '
        Me.pctAsteroidSlow.Image = CType(resources.GetObject("pctAsteroidSlow.Image"), System.Drawing.Image)
        Me.pctAsteroidSlow.Location = New System.Drawing.Point(415, 325)
        Me.pctAsteroidSlow.Name = "pctAsteroidSlow"
        Me.pctAsteroidSlow.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroidSlow.TabIndex = 12
        Me.pctAsteroidSlow.TabStop = False
        '
        'pctAsteroid
        '
        Me.pctAsteroid.Image = CType(resources.GetObject("pctAsteroid.Image"), System.Drawing.Image)
        Me.pctAsteroid.Location = New System.Drawing.Point(399, 116)
        Me.pctAsteroid.Name = "pctAsteroid"
        Me.pctAsteroid.Size = New System.Drawing.Size(62, 62)
        Me.pctAsteroid.TabIndex = 8
        Me.pctAsteroid.TabStop = False
        '
        'pctGreenEnergy
        '
        Me.pctGreenEnergy.BackColor = System.Drawing.Color.Lime
        Me.pctGreenEnergy.Location = New System.Drawing.Point(70, 12)
        Me.pctGreenEnergy.Name = "pctGreenEnergy"
        Me.pctGreenEnergy.Size = New System.Drawing.Size(567, 20)
        Me.pctGreenEnergy.TabIndex = 7
        Me.pctGreenEnergy.TabStop = False
        '
        'pctConstantBlackEnergy
        '
        Me.pctConstantBlackEnergy.BackColor = System.Drawing.Color.Black
        Me.pctConstantBlackEnergy.Location = New System.Drawing.Point(70, 12)
        Me.pctConstantBlackEnergy.Name = "pctConstantBlackEnergy"
        Me.pctConstantBlackEnergy.Size = New System.Drawing.Size(567, 20)
        Me.pctConstantBlackEnergy.TabIndex = 6
        Me.pctConstantBlackEnergy.TabStop = False
        '
        'pctClose
        '
        Me.pctClose.Image = CType(resources.GetObject("pctClose.Image"), System.Drawing.Image)
        Me.pctClose.Location = New System.Drawing.Point(12, 12)
        Me.pctClose.Name = "pctClose"
        Me.pctClose.Size = New System.Drawing.Size(32, 32)
        Me.pctClose.TabIndex = 3
        Me.pctClose.TabStop = False
        '
        'pctFinishLine
        '
        Me.pctFinishLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctFinishLine.Location = New System.Drawing.Point(764, 42)
        Me.pctFinishLine.Name = "pctFinishLine"
        Me.pctFinishLine.Size = New System.Drawing.Size(15, 514)
        Me.pctFinishLine.TabIndex = 2
        Me.pctFinishLine.TabStop = False
        '
        'pctStartLine
        '
        Me.pctStartLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctStartLine.Location = New System.Drawing.Point(70, 41)
        Me.pctStartLine.Name = "pctStartLine"
        Me.pctStartLine.Size = New System.Drawing.Size(15, 514)
        Me.pctStartLine.TabIndex = 0
        Me.pctStartLine.TabStop = False
        '
        'pctCloseSelected
        '
        Me.pctCloseSelected.Image = CType(resources.GetObject("pctCloseSelected.Image"), System.Drawing.Image)
        Me.pctCloseSelected.Location = New System.Drawing.Point(5, 4)
        Me.pctCloseSelected.Name = "pctCloseSelected"
        Me.pctCloseSelected.Size = New System.Drawing.Size(47, 47)
        Me.pctCloseSelected.TabIndex = 4
        Me.pctCloseSelected.TabStop = False
        '
        'pctTopBoundry
        '
        Me.pctTopBoundry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pctTopBoundry.Location = New System.Drawing.Point(70, 41)
        Me.pctTopBoundry.Name = "pctTopBoundry"
        Me.pctTopBoundry.Size = New System.Drawing.Size(709, 11)
        Me.pctTopBoundry.TabIndex = 5
        Me.pctTopBoundry.TabStop = False
        '
        'pctLeftPlaneBoundry
        '
        Me.pctLeftPlaneBoundry.Location = New System.Drawing.Point(-1, 46)
        Me.pctLeftPlaneBoundry.Name = "pctLeftPlaneBoundry"
        Me.pctLeftPlaneBoundry.Size = New System.Drawing.Size(5, 560)
        Me.pctLeftPlaneBoundry.TabIndex = 13
        Me.pctLeftPlaneBoundry.TabStop = False
        '
        'pctRightPlaneBoundry
        '
        Me.pctRightPlaneBoundry.Location = New System.Drawing.Point(870, 46)
        Me.pctRightPlaneBoundry.Name = "pctRightPlaneBoundry"
        Me.pctRightPlaneBoundry.Size = New System.Drawing.Size(5, 560)
        Me.pctRightPlaneBoundry.TabIndex = 14
        Me.pctRightPlaneBoundry.TabStop = False
        '
        'pctPlane
        '
        Me.pctPlane.Image = CType(resources.GetObject("pctPlane.Image"), System.Drawing.Image)
        Me.pctPlane.Location = New System.Drawing.Point(9, 274)
        Me.pctPlane.Name = "pctPlane"
        Me.pctPlane.Size = New System.Drawing.Size(60, 60)
        Me.pctPlane.TabIndex = 1
        Me.pctPlane.TabStop = False
        '
        'pctXtraLeftBoundry
        '
        Me.pctXtraLeftBoundry.Location = New System.Drawing.Point(104, 50)
        Me.pctXtraLeftBoundry.Name = "pctXtraLeftBoundry"
        Me.pctXtraLeftBoundry.Size = New System.Drawing.Size(5, 508)
        Me.pctXtraLeftBoundry.TabIndex = 9
        Me.pctXtraLeftBoundry.TabStop = False
        '
        'pctXtraTopBoundry
        '
        Me.pctXtraTopBoundry.Location = New System.Drawing.Point(-17, 65)
        Me.pctXtraTopBoundry.Name = "pctXtraTopBoundry"
        Me.pctXtraTopBoundry.Size = New System.Drawing.Size(894, 5)
        Me.pctXtraTopBoundry.TabIndex = 10
        Me.pctXtraTopBoundry.TabStop = False
        '
        'pctXtraRightBoundry
        '
        Me.pctXtraRightBoundry.Location = New System.Drawing.Point(744, 44)
        Me.pctXtraRightBoundry.Name = "pctXtraRightBoundry"
        Me.pctXtraRightBoundry.Size = New System.Drawing.Size(5, 508)
        Me.pctXtraRightBoundry.TabIndex = 11
        Me.pctXtraRightBoundry.TabStop = False
        '
        'pctXtraBottomBoundry
        '
        Me.pctXtraBottomBoundry.Location = New System.Drawing.Point(68, 509)
        Me.pctXtraBottomBoundry.Name = "pctXtraBottomBoundry"
        Me.pctXtraBottomBoundry.Size = New System.Drawing.Size(708, 5)
        Me.pctXtraBottomBoundry.TabIndex = 22
        Me.pctXtraBottomBoundry.TabStop = False
        '
        'pctSelectedAbout
        '
        Me.pctSelectedAbout.Image = CType(resources.GetObject("pctSelectedAbout.Image"), System.Drawing.Image)
        Me.pctSelectedAbout.Location = New System.Drawing.Point(760, 8)
        Me.pctSelectedAbout.Name = "pctSelectedAbout"
        Me.pctSelectedAbout.Size = New System.Drawing.Size(100, 28)
        Me.pctSelectedAbout.TabIndex = 24
        Me.pctSelectedAbout.TabStop = False
        '
        'theGame1stLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(874, 606)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctDiomondFinal)
        Me.Controls.Add(Me.pctDiomond)
        Me.Controls.Add(Me.pctAsteroid2)
        Me.Controls.Add(Me.pctAsteroidSlow)
        Me.Controls.Add(Me.pctAsteroid)
        Me.Controls.Add(Me.pctGreenEnergy)
        Me.Controls.Add(Me.pctConstantBlackEnergy)
        Me.Controls.Add(Me.pctClose)
        Me.Controls.Add(Me.pctFinishLine)
        Me.Controls.Add(Me.pctStartLine)
        Me.Controls.Add(Me.pctCloseSelected)
        Me.Controls.Add(Me.pctTopBoundry)
        Me.Controls.Add(Me.pctLeftPlaneBoundry)
        Me.Controls.Add(Me.pctRightPlaneBoundry)
        Me.Controls.Add(Me.pctPlane)
        Me.Controls.Add(Me.pctXtraLeftBoundry)
        Me.Controls.Add(Me.pctXtraRightBoundry)
        Me.Controls.Add(Me.pctSelectedAbout)
        Me.Controls.Add(Me.pctAsteroid3)
        Me.Controls.Add(Me.pctXtraTopBoundry)
        Me.Controls.Add(Me.pctXtraBottomBoundry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "theGame1stLevel"
        Me.Text = "The Real World's Hardest Game"
        CType(Me.pctAbout, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.pctFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctStartLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCloseSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTopBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLeftPlaneBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRightPlaneBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraLeftBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraTopBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraRightBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctXtraBottomBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSelectedAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctStartLine As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlane As System.Windows.Forms.PictureBox
    Friend WithEvents pctFinishLine As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlane As System.Windows.Forms.Timer
    Friend WithEvents pctClose As System.Windows.Forms.PictureBox
    Friend WithEvents pctCloseSelected As System.Windows.Forms.PictureBox
    Friend WithEvents pctTopBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctConstantBlackEnergy As System.Windows.Forms.PictureBox
    Friend WithEvents pctGreenEnergy As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAsteroid As System.Windows.Forms.Timer
    Friend WithEvents pctXtraLeftBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraTopBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraRightBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroidSlow As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAsteroidSlow As System.Windows.Forms.Timer
    Friend WithEvents pctLeftPlaneBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctRightPlaneBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlane As System.Windows.Forms.ImageList
    Friend WithEvents imgPlaneVertical As System.Windows.Forms.ImageList
    Friend WithEvents pctAsteroid2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctAsteroid3 As System.Windows.Forms.PictureBox
    Friend WithEvents pctDiomond As System.Windows.Forms.PictureBox
    Friend WithEvents pctDiomondFinal As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctXtraBottomBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents pctAbout As System.Windows.Forms.PictureBox
    Friend WithEvents pctSelectedAbout As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

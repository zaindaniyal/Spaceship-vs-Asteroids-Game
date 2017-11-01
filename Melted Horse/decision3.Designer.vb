<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class decision3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(decision3))
        Me.cmdYes = New System.Windows.Forms.Button()
        Me.CmdNo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdYes
        '
        Me.cmdYes.Location = New System.Drawing.Point(72, 97)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(99, 33)
        Me.cmdYes.TabIndex = 5
        Me.cmdYes.Text = "Oryt den"
        Me.cmdYes.UseVisualStyleBackColor = True
        '
        'CmdNo
        '
        Me.CmdNo.Location = New System.Drawing.Point(313, 97)
        Me.CmdNo.Name = "CmdNo"
        Me.CmdNo.Size = New System.Drawing.Size(99, 33)
        Me.CmdNo.TabIndex = 4
        Me.CmdNo.Text = "Nah frgt it"
        Me.CmdNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Matura MT Script Capitals", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Plane has just been Destroyed. Carry on playing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'decision3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(476, 162)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.CmdNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "decision3"
        Me.Text = "Decision"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdYes As System.Windows.Forms.Button
    Friend WithEvents CmdNo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

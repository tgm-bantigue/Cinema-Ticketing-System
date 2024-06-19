<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimerr = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pboxBackground = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pboxBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblTimerr
        '
        Me.lblTimerr.AutoSize = True
        Me.lblTimerr.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimerr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerr.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTimerr.Location = New System.Drawing.Point(465, 9)
        Me.lblTimerr.Name = "lblTimerr"
        Me.lblTimerr.Size = New System.Drawing.Size(0, 20)
        Me.lblTimerr.TabIndex = 23
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTimer.Location = New System.Drawing.Point(420, 9)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 20)
        Me.lblTimer.TabIndex = 22
        '
        'pboxBackground
        '
        Me.pboxBackground.BackgroundImage = CType(resources.GetObject("pboxBackground.BackgroundImage"), System.Drawing.Image)
        Me.pboxBackground.InitialImage = CType(resources.GetObject("pboxBackground.InitialImage"), System.Drawing.Image)
        Me.pboxBackground.Location = New System.Drawing.Point(1, -1)
        Me.pboxBackground.Name = "pboxBackground"
        Me.pboxBackground.Size = New System.Drawing.Size(882, 461)
        Me.pboxBackground.TabIndex = 25
        Me.pboxBackground.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(378, 286)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(129, 31)
        Me.btnStart.TabIndex = 30
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'pbLoading
        '
        Me.pbLoading.BackColor = System.Drawing.SystemColors.Control
        Me.pbLoading.Location = New System.Drawing.Point(242, 341)
        Me.pbLoading.MarqueeAnimationSpeed = 5
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(400, 25)
        Me.pbLoading.Step = 0
        Me.pbLoading.TabIndex = 29
        Me.pbLoading.Tag = ""
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProject.Location = New System.Drawing.Point(494, 169)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(163, 16)
        Me.lblProject.TabIndex = 27
        Me.lblProject.Text = "Project in Visual Basic.Net"
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSystem.Location = New System.Drawing.Point(226, 138)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(432, 31)
        Me.lblSystem.TabIndex = 26
        Me.lblSystem.Text = "iMax Ticket Reservation System"
        '
        'pboxLogo
        '
        Me.pboxLogo.BackgroundImage = CType(resources.GetObject("pboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pboxLogo.Location = New System.Drawing.Point(354, 19)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(177, 86)
        Me.pboxLogo.TabIndex = 32
        Me.pboxLogo.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.pboxBackground)
        Me.Controls.Add(Me.lblTimerr)
        Me.Controls.Add(Me.lblTimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen : iMax Ticket Reservation System"
        CType(Me.pboxBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimerr As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents pboxBackground As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents lblProject As Label
    Friend WithEvents lblSystem As Label
    Friend WithEvents pboxLogo As PictureBox
End Class

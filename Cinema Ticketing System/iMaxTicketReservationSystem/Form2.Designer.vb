<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pboxBackground = New System.Windows.Forms.PictureBox()
        Me.pnlMessage = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltimerr = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxShow = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        CType(Me.pboxBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMessage.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboxBackground
        '
        Me.pboxBackground.BackgroundImage = CType(resources.GetObject("pboxBackground.BackgroundImage"), System.Drawing.Image)
        Me.pboxBackground.InitialImage = CType(resources.GetObject("pboxBackground.InitialImage"), System.Drawing.Image)
        Me.pboxBackground.Location = New System.Drawing.Point(1, -1)
        Me.pboxBackground.Name = "pboxBackground"
        Me.pboxBackground.Size = New System.Drawing.Size(882, 461)
        Me.pboxBackground.TabIndex = 26
        Me.pboxBackground.TabStop = False
        '
        'pnlMessage
        '
        Me.pnlMessage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlMessage.Controls.Add(Me.lblMessage)
        Me.pnlMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMessage.Location = New System.Drawing.Point(1, 154)
        Me.pnlMessage.Name = "pnlMessage"
        Me.pnlMessage.Size = New System.Drawing.Size(882, 30)
        Me.pnlMessage.TabIndex = 32
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(17, 7)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 16)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimer.Location = New System.Drawing.Point(716, 13)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 13)
        Me.lblTimer.TabIndex = 40
        '
        'Timer1
        '
        '
        'lbltimerr
        '
        Me.lbltimerr.AutoSize = True
        Me.lbltimerr.Location = New System.Drawing.Point(732, 13)
        Me.lbltimerr.Name = "lbltimerr"
        Me.lbltimerr.Size = New System.Drawing.Size(0, 13)
        Me.lbltimerr.TabIndex = 45
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.LightBlue
        Me.pnlContainer.Controls.Add(Me.btnRegister)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtPassword)
        Me.pnlContainer.Controls.Add(Me.txtUserID)
        Me.pnlContainer.Controls.Add(Me.btnLogin)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.cboxShow)
        Me.pnlContainer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlContainer.Location = New System.Drawing.Point(231, 184)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(422, 249)
        Me.pnlContainer.TabIndex = 56
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegister.Location = New System.Drawing.Point(109, 205)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(205, 30)
        Me.btnRegister.TabIndex = 53
        Me.btnRegister.Text = "Create New Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(229, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "______________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(54, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "______________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(201, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "or"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(29, 102)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(364, 29)
        Me.txtPassword.TabIndex = 45
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Control
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(29, 39)
        Me.txtUserID.MaxLength = 30
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(364, 29)
        Me.txtUserID.TabIndex = 44
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogin.Location = New System.Drawing.Point(29, 140)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(364, 30)
        Me.btnLogin.TabIndex = 43
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Enter Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Enter Username or ID"
        '
        'cboxShow
        '
        Me.cboxShow.AutoSize = True
        Me.cboxShow.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxShow.ForeColor = System.Drawing.Color.Black
        Me.cboxShow.Location = New System.Drawing.Point(293, 83)
        Me.cboxShow.Name = "cboxShow"
        Me.cboxShow.Size = New System.Drawing.Size(103, 17)
        Me.cboxShow.TabIndex = 34
        Me.cboxShow.Text = "Show Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cboxShow.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 86)
        Me.Panel1.TabIndex = 57
        '
        'pboxLogo
        '
        Me.pboxLogo.BackgroundImage = CType(resources.GetObject("pboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pboxLogo.Location = New System.Drawing.Point(354, 68)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(177, 86)
        Me.pboxLogo.TabIndex = 58
        Me.pboxLogo.TabStop = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTo.Location = New System.Drawing.Point(422, 43)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(34, 23)
        Me.lblTo.TabIndex = 60
        Me.lblTo.Text = "To"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWelcome.Location = New System.Drawing.Point(391, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(102, 23)
        Me.lblWelcome.TabIndex = 59
        Me.lblWelcome.Text = "Welcome"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.lbltimerr)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.pnlMessage)
        Me.Controls.Add(Me.pboxBackground)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login : iMax Ticket Reservation System"
        CType(Me.pboxBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMessage.ResumeLayout(False)
        Me.pnlMessage.PerformLayout()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pboxBackground As PictureBox
    Friend WithEvents pnlMessage As Panel
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbltimerr As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxShow As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pboxLogo As PictureBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblWelcome As Label
End Class

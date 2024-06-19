<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receiptfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(receiptfrm))
        Me.proceed = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ticketout = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.timelbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cusname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.outselected = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        Me.receipt = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'proceed
        '
        Me.proceed.BackColor = System.Drawing.Color.LawnGreen
        Me.proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceed.Location = New System.Drawing.Point(118, 432)
        Me.proceed.Name = "proceed"
        Me.proceed.Size = New System.Drawing.Size(103, 41)
        Me.proceed.TabIndex = 74
        Me.proceed.Text = "PRINT"
        Me.proceed.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.Red
        Me.cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.Location = New System.Drawing.Point(227, 432)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(103, 41)
        Me.cancelbtn.TabIndex = 73
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ListBox9)
        Me.Panel1.Controls.Add(Me.ticketout)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel15)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(89, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 302)
        Me.Panel1.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "₱"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Total Ticket Price"
        '
        'ListBox9
        '
        Me.ListBox9.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox9.Enabled = False
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.Location = New System.Drawing.Point(52, 249)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(176, 4)
        Me.ListBox9.TabIndex = 76
        '
        'ticketout
        '
        Me.ticketout.AutoSize = True
        Me.ticketout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ticketout.Location = New System.Drawing.Point(149, 263)
        Me.ticketout.Name = "ticketout"
        Me.ticketout.Size = New System.Drawing.Size(0, 13)
        Me.ticketout.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.timelbl)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.PictureBox8)
        Me.Panel4.Location = New System.Drawing.Point(0, 194)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(268, 47)
        Me.Panel4.TabIndex = 73
        '
        'timelbl
        '
        Me.timelbl.AutoSize = True
        Me.timelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelbl.Location = New System.Drawing.Point(95, 9)
        Me.timelbl.Name = "timelbl"
        Me.timelbl.Size = New System.Drawing.Size(0, 13)
        Me.timelbl.TabIndex = 75
        Me.timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Movie Time Selected"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.iMaxTicketReservationSystem.My.Resources.Resources.time
        Me.PictureBox8.Location = New System.Drawing.Point(24, 7)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox8.TabIndex = 74
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.iMaxTicketReservationSystem.My.Resources.Resources.sold
        Me.PictureBox1.Location = New System.Drawing.Point(90, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.cusname)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Location = New System.Drawing.Point(0, 77)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(268, 40)
        Me.Panel6.TabIndex = 70
        '
        'cusname
        '
        Me.cusname.Enabled = False
        Me.cusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusname.Location = New System.Drawing.Point(102, 4)
        Me.cusname.Name = "cusname"
        Me.cusname.Size = New System.Drawing.Size(100, 20)
        Me.cusname.TabIndex = 76
        Me.cusname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Customer Name"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.iMaxTicketReservationSystem.My.Resources.Resources.cust2
        Me.PictureBox6.Location = New System.Drawing.Point(24, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox6.TabIndex = 63
        Me.PictureBox6.TabStop = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel15.Controls.Add(Me.Label14)
        Me.Panel15.Controls.Add(Me.outselected)
        Me.Panel15.Controls.Add(Me.PictureBox9)
        Me.Panel15.Location = New System.Drawing.Point(0, 132)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(268, 47)
        Me.Panel15.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(113, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Selected Seats"
        '
        'outselected
        '
        Me.outselected.BackColor = System.Drawing.SystemColors.Info
        Me.outselected.Enabled = False
        Me.outselected.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outselected.Location = New System.Drawing.Point(138, 3)
        Me.outselected.Multiline = True
        Me.outselected.Name = "outselected"
        Me.outselected.Size = New System.Drawing.Size(29, 30)
        Me.outselected.TabIndex = 64
        Me.outselected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.iMaxTicketReservationSystem.My.Resources.Resources.check
        Me.PictureBox9.Location = New System.Drawing.Point(24, 8)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 67)
        Me.Panel2.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "RECEIPT"
        '
        'pboxLogo
        '
        Me.pboxLogo.BackgroundImage = CType(resources.GetObject("pboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pboxLogo.Location = New System.Drawing.Point(135, 12)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(177, 86)
        Me.pboxLogo.TabIndex = 62
        Me.pboxLogo.TabStop = False
        '
        'receipt
        '
        Me.receipt.BackgroundImage = CType(resources.GetObject("receipt.BackgroundImage"), System.Drawing.Image)
        Me.receipt.InitialImage = CType(resources.GetObject("receipt.InitialImage"), System.Drawing.Image)
        Me.receipt.Location = New System.Drawing.Point(1, -2)
        Me.receipt.Name = "receipt"
        Me.receipt.Size = New System.Drawing.Size(423, 508)
        Me.receipt.TabIndex = 45
        Me.receipt.TabStop = False
        '
        'receiptfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.proceed)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.receipt)
        Me.Name = "receiptfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIPT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents receipt As PictureBox
    Friend WithEvents pboxLogo As PictureBox
    Friend WithEvents proceed As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents outselected As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents timelbl As Label
    Friend WithEvents cusname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ticketout As Label
End Class

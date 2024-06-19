Public Class frmLogin
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Parent = pboxBackground
        lblWelcome.BackColor = Color.Transparent
        lblTo.Parent = pboxBackground
        lblTo.BackColor = Color.Transparent
        pnlMessage.Hide()
        lblMessage.Hide()
        lblTimer.Hide()
        lbltimerr.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = Val(lblTimer.Text) + 1
        lbltimerr.Text = Val(lbltimerr.Text) + 1
        If lblTimer.Text = 1 Then
            Cursor = Cursors.WaitCursor
        End If
        If lbltimerr.Text = 14 Then
            Timer1.Enabled = False
            Me.Dispose()
            Cinema1.Show()
        End If
    End Sub

    Private Sub cboxShow_CheckedChanged(sender As Object, e As EventArgs) Handles cboxShow.CheckedChanged
        Dim v As String
        v = txtPassword.Text.ToString
        If cboxShow.Checked = True Then
            txtPassword.PasswordChar = ""
            txtPassword.Text = v
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Id, Pw, dId, dPw As String
        Id = txtUserID.Text
        Pw = txtPassword.Text
        dId = "user1"
        dPw = "secret"
        If (Id = dId) Then
            If (Pw = dPw) Then
                Timer1.Enabled = True
                pnlMessage.Show()
                lblMessage.Show()
                pnlMessage.BackColor = Color.LimeGreen
                lblMessage.Text = " Loading account..."
            Else
                pnlMessage.Show()
                lblMessage.Show()
                pnlMessage.BackColor = Color.Red
                lblMessage.Text = " Username or Password is Incorrect!"
                txtUserID.Focus()
            End If
        Else
            pnlMessage.Show()
            lblMessage.Show()
            pnlMessage.BackColor = Color.Red
            lblMessage.Text = " Username or Password is Incorrect!"
            txtUserID.Focus()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.AllowTransparency = True
        Me.Hide()
        frmRegister.Show()
    End Sub
End Class
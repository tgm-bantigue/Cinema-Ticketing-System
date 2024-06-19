Public Class frmStart
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbLoading.Value < pbLoading.Maximum Then
            pbLoading.Value = pbLoading.Value + 2
        End If
        lblTimer.Text = Val(lblTimer.Text) + 1
        lblTimerr.Text = Val(lblTimerr.Text) + 1
        If lblTimer.Text = 50 Then
            Cursor = Cursors.WaitCursor
        End If
        If lblTimerr.Text = 60 Then
            Timer1.Enabled = False
            Me.Hide()
            pbLoading.Value = pbLoading.Minimum
            lblTimer.Text = ""
            lblTimerr.Text = ""
            pbLoading.Hide()
            Cursor = Cursors.Default
            btnStart.Show()
            frmLogin.Show()
        End If
    End Sub
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLoading.Hide()
        lblProject.Parent = pboxBackground
        lblProject.BackColor = Color.Transparent
        lblSystem.Parent = pboxBackground
        lblSystem.BackColor = Color.Transparent
        lblGroup.Parent = pboxBackground
        lblGroup.BackColor = Color.Transparent
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        pbLoading.Show()

        Timer1.Enabled = True
        pbLoading.Minimum = 0
        pbLoading.Maximum = 30
        pbLoading.Value = 0
        btnStart.Hide()
        'Me.Hide()
        'frmLogin.Show()
    End Sub

    Private Sub pboxBackground_Click(sender As Object, e As EventArgs) Handles pboxBackground.Click

    End Sub
End Class

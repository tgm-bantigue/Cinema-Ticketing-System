Imports Msql.Date.MysqlClient

Public Class frmRegister
    Dim query As String = "server=localhost; uid=root; pwd=; database=cinemadb;"
    'Dim con As New MySqlConnection(query)
    Private Sub frmSuper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMessage1.Hide()
        pnlMessage2.Hide()
        pnlMessage3.Hide()
        pnlMessage4.Hide()
        pnlMessage5.Hide()

        pnlPage1.BackColor = Color.Blue
        pnlPage2.BackColor = Color.LightSteelBlue
        pnlPage3.BackColor = Color.LightSteelBlue
        pnlPage4.BackColor = Color.LightSteelBlue
        pnlPage5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        tcRegister.SelectedTab = TabPage2
        pnlPage1.BackColor = Color.Blue
        pnlPage2.BackColor = Color.Blue
        pnlPage3.BackColor = Color.LightSteelBlue
        pnlPage4.BackColor = Color.LightSteelBlue
        pnlPage5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        tcRegister.SelectedTab = TabPage3
        pnlPage1.BackColor = Color.Blue
        pnlPage2.BackColor = Color.Blue
        pnlPage3.BackColor = Color.Blue
        pnlPage4.BackColor = Color.LightSteelBlue
        pnlPage5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        tcRegister.SelectedTab = TabPage4
        pnlPage1.BackColor = Color.Blue
        pnlPage2.BackColor = Color.Blue
        pnlPage3.BackColor = Color.Blue
        pnlPage4.BackColor = Color.Blue
        pnlPage5.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        tcRegister.SelectedTab = TabPage5
        pnlPage1.BackColor = Color.Blue
        pnlPage2.BackColor = Color.Blue
        pnlPage3.BackColor = Color.Blue
        pnlPage4.BackColor = Color.Blue
        pnlPage5.BackColor = Color.Blue
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        MessageBox.Show("Registration Complete", "Succeed!!!", MessageBoxButtons.OK)
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class
Public Class Cinema1
    Private Sub Cinema1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        today.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Public countsel As Integer = 0
    Public price As Integer = 0

    Public Sub MyButtons_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click,
    Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click,
    Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click,
    Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click,
    Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button49.Click, Button50.Click,
    Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click

        Dim active = DirectCast(sender, Button)

        If active.BackColor = Color.DodgerBlue Then
            active.BackColor = Color.LawnGreen

            countsel += 1
            price += 250

            If countsel <= 9 Then
                selected.Text = "0" & countsel
                presyo.Text = price
            Else
                selected.Text = countsel.ToString
                presyo.Text = price
            End If

        ElseIf active.BackColor = Color.LawnGreen Then
            active.BackColor = Color.DodgerBlue

            countsel -= 1
            price -= 250

            If countsel <= 9 Then
                selected.Text = "0" & countsel
                presyo.Text = price
            Else
                selected.Text = countsel.ToString
                presyo.Text = price
            End If
        End If



    End Sub
    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        custb.Clear()

        For i As Integer = 1 To 60
            If CType(Me.Controls.Find(String.Format("Button{0}", i), True)(0), Button).BackColor = Color.Red Then
                Continue For
            Else
                CType(Me.Controls.Find(String.Format("Button{0}", i), True)(0), Button).BackColor = Color.DodgerBlue
            End If
        Next

        moviesched.Text = " "

        While countsel >= 1
            countsel -= 1
        End While
        selected.Text = "00"

        While price >= 1
            price -= 250
        End While
        presyo.Text = 0

    End Sub

    Private Sub moviesched_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        moviesched.Items.Add("2:00 pm - 3:30pm")
        moviesched.Items.Add("4:00 pm - 5:30pm")
        moviesched.Items.Add("6:00 pm - 7:30pm")
    End Sub

    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click
        If String.IsNullOrEmpty(custb.Text) OrElse String.IsNullOrEmpty(moviesched.Text) Then
            MessageBox.Show("Please Complete the Form!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            receiptfrm.cusname.Text = custb.Text
            receiptfrm.outselected.Text = selected.Text
            receiptfrm.timelbl.Text = "@ " & moviesched.Text
            receiptfrm.ticketout.Text = presyo.Text
            MessageBox.Show("Reservation Complete", "Succeed!!!", MessageBoxButtons.OK)
            Me.Hide()
            receiptfrm.Show()
        End If

    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Hide()
            frmStart.Show()
        End If
    End Sub

    Private Sub balik_Click(sender As Object, e As EventArgs) Handles balik.Click
        Me.Dispose()
        frmStart.Show()
    End Sub

    Private Sub accessadmin_Click(sender As Object, e As EventArgs) Handles accessadmin.Click
        Dim pass As String = adminpasstb.Text
        Dim pa = "123"

        If (pass = pa) Then
            MessageBox.Show("ACCESS GRANTED!", "Succeed!!!", MessageBoxButtons.OK)
            Me.Hide()
            Admin.Show()
        Else
            MessageBox.Show("ACCESS DENIED!", "Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            adminpasstb.Clear()
        End If

    End Sub
End Class
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As New Main


        If TxtUser.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Empty field detecteted, please enter all the required details.")

        ElseIf TxtUser.Text = "911" And TxtPass.Text = "admin" Then
            frm.Show()
            frm.BtnUserList.Visible = True
            frm.BtnCirculation.Visible = True
            frm.usid = "admin"
            frm.Welcome.Text = "Welcome Back, Admin!"
            frm.ShowHome()
            Me.Hide()
        ElseIf TxtPass.Text = GetValue("userlist", "PASS", TxtUser.Text) Then
            frm.BtnUserList.Visible = False
            frm.BtnCirculation.Visible = False
            frm.usid = TxtUser.Text
            frm.Welcome.Text = "Welcome Back, " & GetValue("userlist", "NAME", TxtUser.Text) & "!"
            frm.ShowUser(TxtUser.Text)
            frm.Show()
            Me.Hide()

        Else
            MsgBox("Wrong User ID or Password.")
        End If

    End Sub

    Private Sub Ten_Digit(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUser.KeyPress
        If Asc(e.KeyChar) = 8 Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If

    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPass.CheckedChanged
        If cbxPass.Checked = True Then
            TxtPass.UseSystemPasswordChar = False
        Else
            TxtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim forget As New ForgotPass()
        forget.ShowDialog()
    End Sub


End Class

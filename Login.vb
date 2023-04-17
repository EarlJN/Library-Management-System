Imports Org.BouncyCastle.Bcpg

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As New Main
        Dim usid As Integer = GetValueID(TxtUser.Text)

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
        ElseIf TxtPass.Text = GetValue("userlist", "PASS", usid) And TxtUser.Text = GetValue("userlist", "USERNAME", usid) Then
            frm.BtnCirculation.Visible = False
            frm.BtnReports.Visible = False
            frm.usid = usid
            MsgBox(usid)
            frm.Welcome.Text = "Welcome Back, " & GetValue("userlist", "NAME", usid) & "!"
            'frm.ShowUser(usid)
            frm.ShowHomeUser()
            frm.Show()
            Me.Hide()

        Else
            MsgBox("Wrong User ID or Password.")
        End If

    End Sub

    Private Sub Ten_Digit(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUser.KeyPress


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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        ' Check if the input is a digit or letter
        If Char.IsLetterOrDigit(e.KeyChar) Then
            ' Check if the total length of the text is already 10 or more
            If TxtUser.Text.Length >= 10 Then
                ' Prevent the input from being added to the text box
                e.Handled = True
            End If
        ElseIf Not Char.IsControl(e.KeyChar) Then
            ' Prevent non-digit and non-letter characters from being typed
            e.Handled = True
        End If
    End Sub


End Class

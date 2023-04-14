Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports Org.BouncyCastle.Asn1.X509

Public Class UserAccount

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        If Len(TxtPass.Text) < 8 Then
            lblLength.ForeColor = Color.Crimson
            lblLength.Text = "✖️ Length must be at least 8 characters."
        Else
            lblLength.ForeColor = Color.Green
            lblLength.Text = "✓ Length must be at least 8 characters."
        End If

        If upper.Matches(TxtPass.Text).Count < 1 Then
            lblUpper.ForeColor = Color.Crimson
            lblUpper.Text = "✖️ Must contain a upper case letter."
        Else
            lblUpper.ForeColor = Color.Green
            lblUpper.Text = "✓ Must contain a upper case letter."
        End If

        If lower.Matches(TxtPass.Text).Count < 1 Then
            lblLower.ForeColor = Color.Crimson
            lblLower.Text = "✖️ Must contain an lower case letter."
        Else
            lblLower.ForeColor = Color.Green
            lblLower.Text = "✓ Must contain an lower case letter."
        End If

        If number.Matches(TxtPass.Text).Count < 1 Then
            lblNum.ForeColor = Color.Crimson
            lblNum.Text = "✖️ Must contain numeric character."
        Else
            lblNum.ForeColor = Color.Green
            lblNum.Text = "✓ Must contain numeric character."
        End If

        If special.Matches(TxtPass.Text).Count < 1 Then
            lblSpecial.ForeColor = Color.Crimson
            lblSpecial.Text = "✖️ Must contain a special charater."
        Else
            lblSpecial.ForeColor = Color.Green
            lblSpecial.Text = "✓ Must contain a special charater."
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        If TxtPass.Text <> TxtConPass.Text Then
            MsgBox("Password does not match. Please try again.")
            Return
        End If

        If Len(TxtPass.Text) < 8 Or upper.Matches(TxtPass.Text).Count < 1 Or lower.Matches(TxtPass.Text).Count < 1 Or number.Matches(TxtPass.Text).Count < 1 Or special.Matches(TxtPass.Text).Count < 1 Then
            MsgBox("Password requirements not met. Please try again.")
            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`userlist` SET `PASS` = '" & TxtPass.Text & "', `USERNAME` = '" & TxtUsername.Text & "'  WHERE (`ID` = '" & TxtAccID.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox("An account for " & "USER ID: " & TxtAccID.Text & " has been created.")
        con.Close()

        TxtPass.Clear()
        TxtConPass.Clear()
        TxtAccID.Clear()
        BtnAccCancel.Enabled = False
        TxtPass.Enabled = False
        TxtConPass.Enabled = False
        cbxPass.Enabled = False
        cbxPass.Checked = False
        BtnCreate.Enabled = False
        BtnAccSrc.Enabled = True

        lblLength.ForeColor = Color.Crimson
        lblLength.Text = "✖️ Length must be at least 8 characters."
        lblUpper.ForeColor = Color.Crimson
        lblUpper.Text = "✖️ Must contain a upper case letter."
        lblLower.ForeColor = Color.Crimson
        lblLower.Text = "✖️ Must contain an lower case letter."
        lblNum.ForeColor = Color.Crimson
        lblNum.Text = "✖️ Must contain numeric character."
        lblSpecial.ForeColor = Color.Crimson
        lblSpecial.Text = "✖️ Must contain a special charater."

    End Sub

    Private Sub BtnAccSrc_Click(sender As Object, e As EventArgs) Handles BtnAccSrc.Click

        If TxtAccID.Text = "" Then
            MsgBox("Account ID field is empty please insert a value.")
            Return
        End If
        BtnAccCancel.Enabled = True
        TxtPass.Enabled = True
        TxtConPass.Enabled = True
        cbxPass.Enabled = True
        BtnCreate.Enabled = True
        BtnAccSrc.Enabled = False
    End Sub

    Private Sub BtnAccCancel_Click(sender As Object, e As EventArgs) Handles BtnAccCancel.Click
        BtnAccSrc.Enabled = True
        TxtPass.Enabled = False
        TxtConPass.Enabled = False
        BtnCreate.Enabled = False
        BtnAccCancel.Enabled = False
        cbxPass.Enabled = False
        cbxPass.Checked = False

        TxtAccID.Clear()
        TxtPass.Clear()
        TxtConPass.Clear()


        lblLength.ForeColor = Color.Crimson
        lblLength.Text = "✖️ Length must be at least 8 characters."
        lblUpper.ForeColor = Color.Crimson
        lblUpper.Text = "✖️ Must contain a upper case letter."
        lblLower.ForeColor = Color.Crimson
        lblLower.Text = "✖️ Must contain an lower case letter."
        lblNum.ForeColor = Color.Crimson
        lblNum.Text = "✖️ Must contain numeric character."
        lblSpecial.ForeColor = Color.Crimson
        lblSpecial.Text = "✖️ Must contain a special charater."

    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPass.CheckedChanged
        If cbxPass.Checked = True Then
            TxtPass.UseSystemPasswordChar = False
            TxtConPass.UseSystemPasswordChar = False
        Else
            TxtPass.UseSystemPasswordChar = True
            TxtConPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        ' Check if the input is a digit or letter
        If Char.IsLetterOrDigit(e.KeyChar) Then
            ' Check if the total length of the text is already 10 or more
            If TxtUsername.Text.Length >= 10 Then
                ' Prevent the input from being added to the text box
                e.Handled = True
            End If
        ElseIf Not Char.IsControl(e.KeyChar) Then
            ' Prevent non-digit and non-letter characters from being typed
            e.Handled = True
        End If
    End Sub

End Class
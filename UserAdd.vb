Public Class UserAdd
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnAddPic.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicAddUser.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub BtnAddMem_Click(sender As Object, e As EventArgs) Handles BtnAddMem.Click
        Dim emptyTextBoxes = From txt In PnlAddUser.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))
            Return
        End If

        If TxtPhone.TextLength < 10 Then
            MsgBox("Phone number must consists of 10 digits.")
            Return
        End If

        Dim result = MsgBox("Are you sure you want to add this book?", MsgBoxStyle.OkCancel, "LMS - Confirmation")

        If result = MsgBoxResult.Cancel Then
            MsgBox("okay cancel")
            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO userlist (`NAME`, `GENDER`, `PHONENO`, `EMAIL`, `BIRTHDATE`, `PATH`) VALUES ( '" & TxtName.Text & "', '" & CbxGen.SelectedItem & "', '" & TxtPhone.Text & "', '" & TxtEmail.Text & "', '" & DtpBod.Text & "', '" & TxtPath.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox(TxtName.Text & " is successfully added.")
        con.Close()
        ClearUser(PnlAddUser, PicAddUser, DtpBod)
        UpdateTableUser("userlist")

    End Sub

    Private Sub Ten_Digit(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPhone.KeyPress
        If Asc(e.KeyChar) = 8 Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        ElseIf TxtPhone.TextLength + 1 = 11 Then
            e.Handled = True
            MsgBox("Phone Numbers Only consists of 10 digits.", , "Phone Number Length Violation")
        End If

    End Sub
End Class
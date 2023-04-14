Public Class FeatureAddBook

    ' Button Functions
    Private Sub BtnAddMem_Click(sender As Object, e As EventArgs) Handles BtnAddMem.Click
        Dim emptyTextBoxes = From txt In PnlAddBook.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))

            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this book?", "LMS - Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO booklist (`ISBN`,`TITLE`, `GENRE`, `AUTHOR`, `PUBLISHER`, `DATE-PBL`, `QTY`, `PATH`) VALUES ('" & TxtIsbn.Text & "', '" & TxtTitle.Text & "', '" & CbxGenre.SelectedItem & "', '" & TxtAuthor.Text & "', '" & TxtPublisher.Text & "', '" & DtpRecieved.Text & "', '" & TxtQuantity.Text & "', '" & TxtPath.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox(TxtTitle.Text & "is successfully added.")
            con.Close()
        ElseIf result = DialogResult.Cancel Then
            Return
        End If


        For Each ctrl As Control In PnlAddBook.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        PicAddBook.Image = Nothing
        DtpRecieved.Value = DateTime.Now
        UpdateTableCatalog("booklist")
    End Sub

    Private Sub BtnAddPic_Click(sender As Object, e As EventArgs) Handles BtnAddPic.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicAddBook.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    ' Textfield Handles
    Private Sub Only_Numbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        If Asc(e.KeyChar) = 8 Then

        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Ten_Digit(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIsbn.KeyPress
        If Asc(e.KeyChar) = 8 Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        ElseIf TxtIsbn.TextLength + 1 = 11 Then
            e.Handled = True
            MsgBox("ISBN Only consists of 10 digits.", , "ISBN Length Violation")
        End If

    End Sub

End Class
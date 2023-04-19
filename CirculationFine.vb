Public Class CirculationFine
    Private Sub btnSrcIssue_Click(sender As Object, e As EventArgs) Handles btnSrcIssue.Click
        ShowFines(IsUserID.Text)
        btnPayment.Enabled = True
        btnCnlIssue.Enabled = True
        btnSrcIssue.Enabled = False
        TextBox2.Enabled = True
        IsUserID.Enabled = False


        Dim sum As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            sum += Convert.ToInt32(row.Cells("Fine").Value)
        Next

        TextBox1.Text = sum

    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If TextBox2.Text = "" Then
            MsgBox("Payment amount is empty. Please input the paid amount.")
        End If
        If CDec(TextBox1.Text) > CDec(TextBox2.Text) Then
            MsgBox("The fund is insufficient.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Return
        End If

        btnPayment.Enabled = False
        btnCnlIssue.Enabled = False
        btnSrcIssue.Enabled = True
        TextBox2.Enabled = False
        IsUserID.Enabled = True

        TextBox3.Text = TextBox2.Text - TextBox1.Text
        RemoveFines(IsUserID.Text)
        IsUserID.Clear()
    End Sub

    Private Sub btnCnlIssue_Click(sender As Object, e As EventArgs) Handles btnCnlIssue.Click
        TextBox1.Clear()
        TextBox2.Clear()
        btnPayment.Enabled = False
        btnCnlIssue.Enabled = False
        btnSrcIssue.Enabled = True
        TextBox2.Enabled = False
        IsUserID.Enabled = True
        IsUserID.Clear()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub IsUserID_TextChanged(sender As Object, e As EventArgs) Handles IsUserID.TextChanged

        If GetValue("userlist", "INACTIVE", IsUserID.Text) = 0 Then
            lblIsName.Text = GetValue("userlist", "NAME", IsUserID.Text)
        Else
            lblIsName.Text = ""
        End If

    End Sub

End Class
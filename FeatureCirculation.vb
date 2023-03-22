
Public Class FeatureCirculation

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        e.Handled = True
    End Sub

    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        If TxtFilter.Text = "" Or CbxFilter.Text = "" Then
            MsgBox("Empty field detected, Please complete all the fields.")
            Return
        End If

        If ChkSpecific.Checked = True Then
            SpecificFilterCirc("issuedbooks", DataGridView1, CbxFilter, TxtFilter)
        ElseIf ChkSpecific.Checked = False Then
            FilterTableCirc(DataGridView1, CbxFilter, TxtFilter, "issuedbooks")
        End If

        TxtFilter.Clear()
        CbxFilter.Text = ""

    End Sub

    Private Sub BtnResetFilter_Click(sender As Object, e As EventArgs) Handles BtnResetFilter.Click
        UpdateTableCirculation()
    End Sub

    Private Sub ChkSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSpecific.CheckedChanged
        If ChkSpecific.Checked = True Then

            CbxFilter.Items.Clear()
            CbxFilter.Items.Add("STATUS")
            CbxFilter.Items.Add("`BORROWER ID`")
            CbxFilter.Items.Add("`BOOK ID`")
            CbxFilter.Text = ""
            TxtFilter.Clear()

        ElseIf ChkSpecific.Checked = False Then

            CbxFilter.Items.Clear()
            CbxFilter.Items.Add("BORROWER")
            CbxFilter.Items.Add("BOOK")
            CbxFilter.Text = ""
            TxtFilter.Clear()

        End If
    End Sub


    Private Sub BtnIssueBook_Click(sender As Object, e As EventArgs) Handles BtnIssueBook.Click
        Dim issue As New CirculationIssue
        issue.ShowDialog()
    End Sub

    Private Sub BtnReturnBook_Click(sender As Object, e As EventArgs) Handles BtnReturnBook.Click
        CirculationReturn.Show()
    End Sub
End Class
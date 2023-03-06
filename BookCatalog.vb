Public Class BookCatalog
    Private Sub DataGridView1_SelectColum(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        TxtId.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        TxtIsbn.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        TxtTitle.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
        TxtGenre.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
        TxtAuthor.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
        TxtDate.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value
        TxtPublisher.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(6).Value
        TxtQty.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(7).Value
        BLPic.Image = Image.FromFile(GetValue("booklist", "PATH", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value))

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        e.Handled = True
    End Sub

    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        If TxtFilter.Text = "" Or CbxFilter.Text = "" Then
            MsgBox("Empty field detected, Please complete all the fields.")
            Return
        End If

        If ChkSpecific.Checked = True Then
            SpecificFilterTable("booklist", DataGridView1, CbxFilter, TxtFilter)
        ElseIf ChkSpecific.Checked = False Then
            FilterTable(DataGridView1, CbxFilter, TxtFilter, "booklist")
        End If

    End Sub

    Private Sub BtnResetFilter_Click(sender As Object, e As EventArgs) Handles BtnResetFilter.Click
        UpdateTableCatalog("booklist")
        'ClearUser(BookCatalog, BLPic)
        TxtFilter.Clear()
        CbxFilter.Text = ""

    End Sub

    Private Sub ChkSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSpecific.CheckedChanged
        If ChkSpecific.Checked = True Then

            CbxFilter.Items.Clear()
            CbxFilter.Items.Add("ID")
            CbxFilter.Items.Add("ISBN")
            CbxFilter.Items.Add("Title")
            CbxFilter.Items.Add("Genre")
            CbxFilter.Items.Add("Author")
            CbxFilter.Items.Add("Publisher")
            CbxFilter.Text = ""
            TxtFilter.Clear()

        ElseIf ChkSpecific.Checked = False Then

            CbxFilter.Items.Clear()
            CbxFilter.Items.Add("Title")
            CbxFilter.Items.Add("Author")
            CbxFilter.Items.Add("Genre")
            CbxFilter.Items.Add("Publisher")
            CbxFilter.Text = ""
            TxtFilter.Clear()

        End If
    End Sub
End Class
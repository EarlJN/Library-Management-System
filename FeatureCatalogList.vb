
Imports System.Diagnostics.Eventing.Reader
Imports Mysqlx.XDevAPI.Relational

Public Class FeatureCatalogList
    Private Sub DataGridView1_SelectColum(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        TxtId.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        TxtIsbn.Text = GetValue("booklist", "ISBN", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value)
        TxtTitle.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        TxtGenre.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
        TxtAuthor.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
        TxtDate.Text = GetValue("booklist", "`DATE-PBL`", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value)
        TxtPublisher.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
        TxtQty.Text = GetValue("booklist", "QTY", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value)
        BLPic.Image = Image.FromFile(GetValue("booklist", "PATH", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value))

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
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
        ClearUser(PnlBookList, BLPic)
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

    Private Sub BtnAddBook_Click(sender As Object, e As EventArgs) Handles BtnAddBook.Click
        Dim add As New FeatureAddBook
        add.ShowDialog()
    End Sub

    Private Sub BtnEditBook_Click(sender As Object, e As EventArgs) Handles BtnEditBook.Click
        Dim edit As New FeatureEditBook
        edit.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        BookCatalog.Show()
        UpdateTableCatalog("booklist")

        For i = 0 To 10

        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private mRow As Integer = 0
    Private newPage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("Booklist", New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = (e.PageBounds.Width - DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)) \ 2
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        ' Print header
        For Each column As DataGridViewColumn In DataGridView1.Columns
            If column.Visible Then
                rc = New Rectangle(x, y, column.Width, DataGridView1.ColumnHeadersHeight)
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(column.HeaderText, DataGridView1.Font, Brushes.Black, rc, fmt)

                x += rc.Width
                h = Math.Max(h, rc.Height)
            End If
        Next
        y += h

        ' Print rows
        For displaynow As Integer = mRow To DataGridView1.RowCount - 1
            row = DataGridView1.Rows(displaynow)
            x = (e.PageBounds.Width - DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)) \ 2 ' Calculate starting X position
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)

                End If
            Next
            y += h

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                mRow = displaynow
                newPage = True
                Return
            End If
        Next

        ' Reset mRow when starting to print a new page
        If newPage Then
            mRow = 0
            newPage = False
        Else
            e.HasMorePages = False
        End If
    End Sub

End Class
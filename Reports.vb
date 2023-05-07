Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class Reports
    Private Sub btnSrcIssue_Click(sender As Object, e As EventArgs) Handles btnSrcIssue.Click
        ReportReturned()
        lblSelected.Text = "RETURNED"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReportShowOverdue()
        lblSelected.Text = "OVERDUE"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CbxDate.Text = Nothing Then
            Return
        End If

        If lblSelected.Text = "RETURNED" Then
            ReportBetweenDatesReturned(CbxDate.Text)
        ElseIf lblSelected.Text = "ISSUED" Then
            ReportBetweenDatesIssued(CbxDate.Text)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ReportIssued()
        lblSelected.Text = "ISSUED"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReportShowLost()
        lblSelected.Text = "LOST"
    End Sub
    'Private mRow As Integer = 0
    'Private newPage As Boolean = True
    'Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    '    Dim format As New StringFormat
    '    format.Alignment = StringAlignment.Center
    '    e.Graphics.DrawString("helo", New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

    '    Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
    '    fmt.LineAlignment = StringAlignment.Center
    '    fmt.Trimming = StringTrimming.EllipsisCharacter
    '    fmt.Alignment = StringAlignment.Center

    '    Dim y As Integer = 100
    '    Dim x As Integer = 150
    '    Dim h As Integer = 0
    '    Dim rc As Rectangle
    '    Dim row As DataGridViewRow

    '    If newPage Then
    '        row = DataGridView1.Rows(mRow)
    '        x = (e.PageBounds.Width - DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)) \ 2 ' Calculate starting X position
    '        For Each Cell As DataGridViewCell In row.Cells
    '            If Cell.Visible Then
    '                rc = New Rectangle(x, y, Cell.Size.Width, Cell.Size.Height)
    '                e.Graphics.FillRectangle(Brushes.LightGray, rc)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)
    '                e.Graphics.DrawString(DataGridView1.Columns(Cell.ColumnIndex).HeaderText, DataGridView1.Font, Brushes.Black, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)
    '            End If
    '        Next

    '        y += h
    '    End If
    '    newPage = False
    '    Dim displaynow As Integer
    '    For displaynow = mRow To DataGridView1.RowCount - 1
    '        row = DataGridView1.Rows(displaynow)
    '        x = (e.PageBounds.Width - DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)) \ 2 ' Calculate starting X position
    '        h = 0

    '        For Each cell As DataGridViewCell In row.Cells
    '            If cell.Visible Then
    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                fmt.Alignment = StringAlignment.Near
    '                rc.Offset(10, 0)
    '                e.Graphics.DrawString(cell.FormattedValue.ToString(), DataGridView1.Font, Brushes.Black, rc, fmt)
    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)

    '            End If
    '        Next
    '        y += h
    '    Next

    'End Sub

    Private mRow As Integer = 0
    Private newPage As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString(lblSelected.Text, New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReportShowAll()
    End Sub


End Class
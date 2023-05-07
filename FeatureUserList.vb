﻿Public Class FeatureUserList
    Private Sub DataGridView1_SelectColum(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        TxtId.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        TxtName.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        TxtGender.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
        TxtPhone.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
        TxtEmail.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
        TxtBod.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value
        PicUser.Image = Image.FromFile(GetValue("userlist", "PATH", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value))
        'ShowIssuedBooks(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value)

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        e.Handled = True
    End Sub

    Private Sub BtnEditSrc_Click(sender As Object, e As EventArgs) Handles BtnEditSrc.Click
        'SpecificFilterTable("userlist", DataGridView1, TxtEditSrc)
        If TxtEditSrc.Text = "" Then
            MsgBox("The ID field is empty, please insert the desired BOOK ID")
            Return
        End If

        For index As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(index).Cells(0).Value = TxtEditSrc.Text Then
                DataGridView1.CurrentCell = DataGridView1.Rows(index).Cells(0)
                DataGridView1_SelectColum(Me.DataGridView1, New DataGridViewCellEventArgs(index, 0))
            End If
        Next
    End Sub

    Private Sub FeatureUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.CurrentCell = Nothing
    End Sub

    Public Sub UserListClear()
        ClearUser(PnlUserShow, PicUser)
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        Dim add As New UserAdd
        add.ShowDialog()
    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnEditUser.Click
        Dim edit As New UserEdit
        edit.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim create As New UserAccount
        create.ShowDialog()
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
        e.Graphics.DrawString("USERLIST", New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(400, 20), format)

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
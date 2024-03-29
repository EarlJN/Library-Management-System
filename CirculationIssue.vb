﻿Imports System.Drawing.Printing

Public Class CirculationIssue

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Sub Issue(usid As String, bookid As String)
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)

        If DtpDue.Text = DtpIs.Text Then
            DtpDue.Text = DtpIs.Value.AddDays(14)
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO issuedbooks (`BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS`) VALUES ( '" & usid & "', '" & name & "', '" & bookid & "', '" & title & "', '" & DtpIs.Text & "', '" & DtpDue.Text & "', 'BORROWED' )"
            cmd.ExecuteNonQuery()
            con.Close()
        Else
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO issuedbooks (`BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS`) VALUES ( '" & usid & "', '" & name & "', '" & bookid & "', '" & title & "', '" & DtpIs.Text & "', '" & DtpDue.Text & "', 'BORROWED' )"
            cmd.ExecuteNonQuery()
            con.Close()
        End If

        SubtractQty(bookid)
        UpdateTableCirculation()


    End Sub
    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        If DtpIs.Value.ToString("yyyy/MM/dd") > DtpDue.Value.ToString("yyyy/MM/dd") Then
            MsgBox("Due date is less than the issue date. Please pick a valid date.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("The list is empty. Please add the books to borrow.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Return
        End If

        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            Issue(IsUserID.Text, DataGridView1.Rows(index).Cells(0).Value)
        Next

        PPD.Document = PD
        PPD.ShowDialog()
        DataGridView1.Rows.Clear()
        btnSrcIssue.Enabled = True
        IsUserID.Enabled = True
        btnCnlIssue.Enabled = False
        btnAddIssue.Enabled = False
        btnDelIssue.Enabled = False
        IsBookID.Enabled = False
        DtpDue.Enabled = False
        btnIssue.Enabled = False
        IsBookID.Clear()
        IsUserID.Clear()
    End Sub

    Private Sub IsUserID_TextChanged(sender As Object, e As EventArgs) Handles IsUserID.TextChanged

        If GetValue("userlist", "INACTIVE", IsUserID.Text) = 0 Then
            lblIsName.Text = GetValue("userlist", "NAME", IsUserID.Text)
        Else
            lblIsName.Text = ""
        End If

    End Sub

    Private Sub IsBookID_TextChanged(sender As Object, e As EventArgs) Handles IsBookID.TextChanged


        If GetValue("booklist", "INACTIVE", IsBookID.Text) = 0 Then
            lblIsTitle.Text = GetValue("booklist", "TITLE", IsBookID.Text)
        Else
            lblIsTitle.Text = ""
        End If

    End Sub

    Private Sub AddIssue_Click(sender As Object, e As EventArgs) Handles btnAddIssue.Click

        Dim title = GetValue("booklist", "TITLE", IsBookID.Text)
        Dim name = GetValue("userlist", "NAME", IsUserID.Text)

        If IsBookID.Text = "" Then
            MsgBox("Book ID field is empty, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If IsDBNull(GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text))) Then
            Return
        End If

        If GetValueActive("booklist", "ID", IsBookID.Text) = Nothing Then
            MsgBox("The BOOK doesn't exist", 0, "LMS - Book ID")
            Return
        End If
        If CountOverdue(IsUserID.Text) > 0 Then
            MsgBox("The user has an overdue. It must be settled before the user can borrow another book.", 0, "LMS - Issuance")
            Return
        End If
        If HasFine(IsUserID.Text) Then
            MsgBox("The user has outstanding fines that should be paid.", 0, "LMS - Issuance")
            Return
        End If


        If (CountBooksBorrowed(IsUserID.Text) + DataGridView1.Rows.Count + 1) > 5 Then
            MsgBox("A user can only borrow 5 books at a time.", 0, "LMS - Issuance")
            Return
        End If

        If GetQty(IsBookID.Text) < 1 Then
            MsgBox("The selected BOOK is currently OUT of STOCK.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        For index = 0 To DataGridView1.Rows.Count - 1
            If IsBookID.Text = DataGridView1.Rows(index).Cells(0).Value Then
                MsgBox(title & " is already on the list.", MsgBoxStyle.OkOnly, "Library Management System")
                Return
            End If
        Next

        If CheckDuplicate(IsUserID.Text, IsBookID.Text) <> Nothing Then

            If GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text)) = "LOST" Then
                MsgBox(name & " has lost " & title & " in the past and therefore can't borrow it again.", MsgBoxStyle.OkOnly, "Library Management System")
            Else
                MsgBox(name & " has already borrowed " & title & " and is yet to return it.", MsgBoxStyle.OkOnly, "Library Management System")
            End If
            Return
        End If


        DataGridView1.Rows.Add(New String() {IsBookID.Text, GetValue("booklist", "TITLE", IsBookID.Text)})
        IsBookID.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelIssue.Click
        If (DataGridView1.Rows.Count = 0) Then
            Return
        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub

    Private Sub btnSrcIssue_Click(sender As Object, e As EventArgs) Handles btnSrcIssue.Click
        If IsUserID.Text = Nothing Then
            MsgBox("The User ID field is empty. Please insert the user's ID.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If GetValueActive("userlist", "ID", IsUserID.Text) = Nothing Then
            MsgBox("The USER doesn't exist", 0, "LMS - User ID")
            Return
        End If

        btnSrcIssue.Enabled = False
        IsUserID.Enabled = False
        btnCnlIssue.Enabled = True
        btnAddIssue.Enabled = True
        btnDelIssue.Enabled = True
        IsBookID.Enabled = True
        DtpDue.Enabled = True
        btnIssue.Enabled = True

    End Sub

    Private Sub CnlIssue_Click(sender As Object, e As EventArgs) Handles btnCnlIssue.Click
        btnSrcIssue.Enabled = True
        IsUserID.Enabled = True
        btnCnlIssue.Enabled = False
        btnAddIssue.Enabled = False
        btnDelIssue.Enabled = False
        IsBookID.Enabled = False
        DtpDue.Enabled = False
        btnIssue.Enabled = False
        DataGridView1.Rows.Clear()
        IsBookID.Clear()
        IsUserID.Clear()
    End Sub

    ' Print Functions
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"
        e.Graphics.DrawString("ISSUANCE RECEIPT", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("LIBRARY MANAGEMENT SYSTEM", f10, Brushes.Black, centermargin, 55, center)
        e.Graphics.DrawString("User's Name : ", f8, Brushes.Black, 5, 75)
        e.Graphics.DrawString(GetValue("userlist", "NAME", IsUserID.Text), f8, Brushes.Black, 70, 75) ' Customer name placeholder
        e.Graphics.DrawString("Issue Date: ", f8, Brushes.Black, 5, 85)
        e.Graphics.DrawString(DtpIs.Text, f8, Brushes.Black, 60, 85) ' Customer add placeholder
        e.Graphics.DrawString("Item", f8, Brushes.Black, 5, 110)
        e.Graphics.DrawString("Due-Date", f8, Brushes.Black, rightmargin - 5, 110, right)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 5, 115 + height)
            e.Graphics.DrawString(DtpDue.Text, f8, Brushes.Black, rightmargin - 5, 115 + height, right)
        Next

        Dim height2 As Integer
        height2 = 145 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total Books: " & DataGridView1.RowCount, f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("THANK YOU FOR BORROWING!", f10, Brushes.Black, centermargin, 70 + height2, center)

    End Sub

End Class
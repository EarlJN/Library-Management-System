Public Class CirculationIssue

    Sub Issue(usid As String, bookid As String)
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)

        If GetValueActive("userlist", "ID", IsUserID.Text) = Nothing Then
            MsgBox("The USER doesn't exist")
            Return
        End If

        If DtpDue.Value = DtpIs.Value Then
            DtpDue.Value = DtpIs.Value.AddDays(14)
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
        MsgBox(title & " has been issued to " & name & " in " & DtpIs.Text, MsgBoxStyle.OkOnly, "Library Management System")

    End Sub
    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click

        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("The list is empty. Please add the books to borrow.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            Issue(IsUserID.Text, DataGridView1.Rows(index).Cells(0).Value)
        Next

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
        'Dim name = GetValue("userlist", "NAME", IsUserID.Text)
        'Dim title = GetValue("booklist", "TITLE", IsBookID.Text)


        ''If GetValueActive("userlist", "ID", IsUserID.Text) = Nothing Then
        ''    MsgBox("The USER doesn't exist")
        ''    Return
        ''End If

        ''If GetValueActive("booklist", "ID", IsBookID.Text) = Nothing Then
        ''    MsgBox("The BOOK doesn't exist")
        ''    Return
        ''End If

        ''If IsUserID.Text = "" Or IsBookID.Text = "" Then
        ''    MsgBox("Empty field detected, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
        ''End If

        ''If GetQty(IsBookID.Text) < 1 Then
        ''    MsgBox("The selected BOOK is currently OUT of STOCK.", MsgBoxStyle.OkOnly, "Library Management System")
        ''    Return
        ''End If

        ''If CheckDuplicate(IsUserID.Text, IsBookID.Text) <> Nothing Then

        ''    If GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text)) = "LOST" Then
        ''        MsgBox(name & " has lost " & title & " in the past and therefore can't borrow it again.", MsgBoxStyle.OkOnly, "Library Management System")
        ''    Else
        ''        MsgBox(name & " has already borrowed " & title & " and is yet to return it.", MsgBoxStyle.OkOnly, "Library Management System")
        ''    End If
        ''    Return
        ''End If

        ''If IsDBNull(GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text))) Then
        ''    Return
        ''End If

        'If DtpDue.Value = DtpIs.Value Then
        '    DtpDue.Value = DtpIs.Value.AddDays(14)
        '    OpenCon()
        '    cmd.Connection = con
        '    cmd.CommandText = "INSERT INTO issuedbooks (`BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS`) VALUES ( '" & IsUserID.Text & "', '" & name & "', '" & IsBookID.Text & "', '" & title & "', '" & DtpIs.Text & "', '" & DtpDue.Text & "', 'BORROWED' )"
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'Else
        '    OpenCon()
        '    cmd.Connection = con
        '    cmd.CommandText = "INSERT INTO issuedbooks (`BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS`) VALUES ( '" & IsUserID.Text & "', '" & name & "', '" & IsBookID.Text & "', '" & title & "', '" & DtpIs.Text & "', '" & DtpDue.Text & "', 'BORROWED' )"
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'End If

        'SubtractQty(IsBookID.Text)
        'UpdateTableCirculation()
        'MsgBox(title & " has been issued to " & name & " in " & DtpIs.Text, MsgBoxStyle.OkOnly, "Library Management System")

        'btnSrcIssue.Enabled = True
        'IsUserID.Enabled = True
        'btnCnlIssue.Enabled = False
        'btnAddIssue.Enabled = False
        'btnDelIssue.Enabled = False
        'IsBookID.Enabled = False
        'DtpDue.Enabled = False
        'btnIssue.Enabled = False
        'IsBookID.Clear()
        'IsUserID.Clear()

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
            MsgBox("The BOOK doesn't exist")
            Return
        End If

        If CountOverdue(IsUserID.Text) > 0 Then
            MsgBox("The user has an overdue. It must be settled before the user can borrow another book.")
            Return
        End If

        If (CountBooksBorrowed(IsUserID.Text) + DataGridView1.Rows.Count + 1) > 5 Then
            MsgBox("A user can only borrow 5 books at a time.")
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
            MsgBox("The USER doesn't exist")
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
End Class
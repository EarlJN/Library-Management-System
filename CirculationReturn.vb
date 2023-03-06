Public Class CirculationReturn
    Sub ReturnBook(usid As String, bookid As String)
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)

        AddQty(ReBookID.Text)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("The list is empty. Please add the books to borrow.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            ReturnBook(ReUserID.Text, DataGridView1.Rows(index).Cells(0).Value)
        Next

        DataGridView1.Rows.Clear()
        btnSrcIssue.Enabled = True
        ReUserID.Enabled = True
        btnCnlIssue.Enabled = False
        btnAddIssue.Enabled = False
        btnDelIssue.Enabled = False
        ReBookID.Enabled = False
        btnReturn.Enabled = False
        ReBookID.Clear()
        ReUserID.Clear()
        cbxLost.Checked = False
        cbxLost.Enabled = True

        'Dim name = GetValue("userlist", "NAME", ReUserID.Text)
        'Dim title = GetValue("booklist", "TITLE", ReBookID.Text)

        'If GetValueActive("userlist", "ID", ReUserID.Text) = Nothing Then
        '    MsgBox("The USER doesn't exist")
        '    Return
        'End If

        'If GetValueActive("booklist", "ID", ReBookID.Text) = Nothing Then
        '    MsgBox("The BOOK doesn't exist")
        '    Return
        'End If

        'If GetTransacID(ReBookID.Text, ReUserID.Text) = Nothing Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "LOST" Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "RETURNED" Then
        '    MsgBox("This transaction doesn't exist.")
        '    Return
        'End If

        'If ReUserID.Text = "" Or ReBookID.Text = "" Then
        '    MsgBox("Empty field detected, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
        '    Return
        'End If

        'If CheckDuplicate(ReUserID.Text, ReBookID.Text) = Nothing & GetValue("booklist", "QTY", ReBookID.Text) > 0 Then
        '    MsgBox(title & " is not currently issued to " & name & ", Please check the entered details.", MsgBoxStyle.OkOnly, "Library Management System")
        '    Return
        'End If

        'If cbxLost.Checked = True Then
        '    SetStatus("LOST", GetTransacID(ReBookID.Text, ReUserID.Text))
        '    MsgBox(title & " has been lost by " & name & ".", MsgBoxStyle.OkOnly, "Library Management System")
        '    UpdateTableCirculation()
        '    Return
        'End If

        'MsgBox(title & " has been returned by " & name & ".", MsgBoxStyle.OkOnly, "Library Management System")
        'AddQty(ReBookID.Text)
        'SetStatus("RETURNED", GetTransacID(ReBookID.Text, ReUserID.Text))
        'UpdateTableCirculation()
    End Sub

    Private Sub UserID_TextChanged(sender As Object, e As EventArgs) Handles ReUserID.TextChanged

        If GetValue("userlist", "INACTIVE", ReUserID.Text) = 0 Then
            lblReName.Text = GetValue("userlist", "NAME", ReUserID.Text)
        Else
            lblReName.Text = ""
        End If

    End Sub

    Private Sub BookID_TextChanged(sender As Object, e As EventArgs) Handles ReBookID.TextChanged

        If GetValue("booklist", "INACTIVE", ReBookID.Text) = 0 Then
            lblReTitle.Text = GetValue("booklist", "TITLE", ReBookID.Text)
        Else
            lblReTitle.Text = ""
        End If

    End Sub

    Private Sub btnSrcIssue_Click(sender As Object, e As EventArgs) Handles btnSrcIssue.Click
        ReBookID.Enabled = True
        btnSrcIssue.Enabled = False
        btnCnlIssue.Enabled = True
        btnAddIssue.Enabled = True
        btnDelIssue.Enabled = True
        btnReturn.Enabled = True
        cbxLost.Enabled = True
    End Sub

    Private Sub btnCnlIssue_Click(sender As Object, e As EventArgs) Handles btnCnlIssue.Click
        btnSrcIssue.Enabled = True
        btnCnlIssue.Enabled = False
        btnAddIssue.Enabled = False
        btnDelIssue.Enabled = False
        btnReturn.Enabled = False
        cbxLost.Enabled = False
        cbxLost.Checked = False
        DataGridView1.Rows.Clear()
        ReBookID.Clear()
        ReUserID.Clear()
    End Sub

    Private Sub btnAddIssue_Click(sender As Object, e As EventArgs) Handles btnAddIssue.Click
        Dim title = GetValue("booklist", "TITLE", ReBookID.Text)
        Dim name = GetValue("userlist", "NAME", ReUserID.Text)

        If ReBookID.Text = "" Then
            MsgBox("Book ID field is empty, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If IsDBNull(GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text))) Then
            Return
        End If

        If GetValueActive("booklist", "ID", ReBookID.Text) = Nothing Then
            MsgBox("The BOOK doesn't exist")
            Return
        End If
        If GetValueActive("userlist", "ID", ReUserID.Text) = Nothing Then
            MsgBox("The USER doesn't exist")
            Return
        End If

        If GetTransacID(ReBookID.Text, ReUserID.Text) = Nothing Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "LOST" Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "RETURNED" Then
            MsgBox("This transaction doesn't exist.")
            Return
        End If

        If CheckDuplicate(ReUserID.Text, ReBookID.Text) = Nothing & GetValue("booklist", "QTY", ReBookID.Text) > 0 Then
            MsgBox(title & " is not currently issued to " & name & ", Please check the entered details.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        For index = 0 To DataGridView1.Rows.Count - 1
            If ReBookID.Text = DataGridView1.Rows(index).Cells(0).Value Then
                MsgBox(title & " is already on the list.", MsgBoxStyle.OkOnly, "Library Management System")
                Return
            End If
        Next

        If cbxLost.Checked = True Then
            DataGridView1.Rows.Add(New String() {ReBookID.Text, GetValue("booklist", "TITLE", ReBookID.Text), "LOST"})
            cbxLost.Checked = False
        Else
            DataGridView1.Rows.Add(New String() {ReBookID.Text, GetValue("booklist", "TITLE", ReBookID.Text)})
        End If

        ReBookID.Clear()

    End Sub

    Private Sub btnDelIssue_Click(sender As Object, e As EventArgs) Handles btnDelIssue.Click
        If (DataGridView1.Rows.Count = 0) Then
            Return
        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub
End Class
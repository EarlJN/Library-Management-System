Imports System.Net
Imports Org.BouncyCastle.Crypto

Public Class CirculationReturn
    Dim btncount As Integer
    Dim btns As Button()
    Private Sub CirculationReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btns = {btnReturn1, btnReturn2, btnReturn3, btnReturn4, btnReturn5}
    End Sub
    Sub ReturnBook(usid As String, bookid As String)
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)

        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If DataGridView1.Rows.Count = Nothing Then
            MsgBox("The list is empty. Please add the books to borrow.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        For index As Integer = 0 To DataGridView1.Rows.Count - 1
            ReturnBook(ReUserID.Text, DataGridView1.Rows(index).Cells(0).Value)
            'SetFine(0, GetTransacID(ReUserID.Text, DataGridView1.Rows(index).Cells(0).Value))
        Next

        DataGridView1.Rows.Clear()
        btnSrcIssue.Enabled = True
        ReUserID.Enabled = True
        btnCnlIssue.Enabled = False
        ReUserID.Clear()

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

    Private Sub btnSrcIssue_Click(sender As Object, e As EventArgs) Handles btnSrcIssue.Click

        ReUserID.Enabled = False
        btncount = CountToReturn(ReUserID.Text)
        btnSrcIssue.Enabled = False
        btnCnlIssue.Enabled = True
        ShowToReturn(ReUserID.Text)

        For index As Integer = 0 To CountToReturn(ReUserID.Text) - 1
            btns(index).Visible = True
        Next


    End Sub

    Private Sub btnCnlIssue_Click(sender As Object, e As EventArgs) Handles btnCnlIssue.Click
        ReUserID.Clear()
        ReUserID.Enabled = True
        btnSrcIssue.Enabled = True
        btnCnlIssue.Enabled = False
        DataGridView1.DataSource = Nothing
        ReUserID.Clear()
        For i As Integer = 0 To 4
            btns(i).Visible = False
        Next
    End Sub

    Private Sub btnDelIssue_Click(sender As Object, e As EventArgs)
        If (DataGridView1.Rows.Count = 0) Then
            Return
        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub

    Private Sub btnReturn1_Click(sender As Object, e As EventArgs) Handles btnReturn1.Click
        Dim usid As String = ReUserID.Text
        Dim bookid As String = DataGridView1.Rows(0).Cells(0).Value
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)
        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)

    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click
        Dim usid As String = ReUserID.Text
        Dim bookid As String = DataGridView1.Rows(1).Cells(0).Value
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)
        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)
    End Sub

    Private Sub btnReturn3_Click(sender As Object, e As EventArgs) Handles btnReturn3.Click
        Dim usid As String = ReUserID.Text
        Dim bookid As String = DataGridView1.Rows(2).Cells(0).Value
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)
        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)
    End Sub

    Private Sub btnReturn4_Click(sender As Object, e As EventArgs) Handles btnReturn4.Click
        Dim usid As String = ReUserID.Text
        Dim bookid As String = DataGridView1.Rows(3).Cells(0).Value
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)
        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)
    End Sub

    Private Sub btnReturn5_Click(sender As Object, e As EventArgs) Handles btnReturn5.Click
        Dim usid As String = ReUserID.Text
        Dim bookid As String = DataGridView1.Rows(4).Cells(0).Value
        Dim name = GetValue("userlist", "NAME", usid)
        Dim title = GetValue("booklist", "TITLE", bookid)
        AddQty(bookid)
        SetStatus("RETURNED", GetTransacID(bookid, usid))
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer = CountToReturn(ReUserID.Text) - 1
        Dim ids As New ArrayList
        Dim books As New ArrayList
        Dim msg As String = "The book/s "

        For i As Integer = 0 To length
            ids.Add(DataGridView1.Rows(i).Cells(0).Value)
        Next

        For index As Integer = 0 To length
            Dim usid As String = ReUserID.Text
            Dim bookid As String = ids(index)
            Dim name = GetValue("userlist", "NAME", usid)
            Dim title = GetValue("booklist", "TITLE", bookid)
            msg += title + ", "
            AddQty(bookid)
            SetStatus("RETURNED", GetTransacID(bookid, usid))
            SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
            UpdateTableCirculation()
            btns(btncount).Visible = False
            ShowToReturn(usid)
        Next
        msg += "has been returned in " & DateTime.Now
        MsgBox(msg, MsgBoxStyle.OkOnly, "Library Management System")
        btncount = 0

        For i As Integer = 0 To 4
            btns(i).Visible = False
        Next
    End Sub
End Class
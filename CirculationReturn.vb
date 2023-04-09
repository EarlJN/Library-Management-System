Imports System.Net
Imports Org.BouncyCastle.Crypto

Public Class CirculationReturn
    Dim btncount As Integer
    Dim btns As Button()
    Dim btnslost As Button()
    Private Sub CirculationReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btns = {btnReturn1, btnReturn2, btnReturn3, btnReturn4, btnReturn5}
        btnslost = {}
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

        For index As Integer = 0 To btncount - 1
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
        Dim transacid = GetTransacID(bookid, usid)
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), transacid)

        If CboxLost.Checked = True Then
            SetStatus("LOST", transacid)
        Else
            SetStatus("RETURNED", transacid)
            AddQty(bookid)
        End If

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
        Dim transacid = GetTransacID(bookid, usid)

        If CboxLost.Checked = True Then
            SetStatus("LOST", transacid)
        Else
            SetStatus("RETURNED", transacid)
            AddQty(bookid)
        End If
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
        Dim transacid = GetTransacID(bookid, usid)

        If CboxLost.Checked = True Then
            SetStatus("LOST", transacid)
        Else
            SetStatus("RETURNED", transacid)
            AddQty(bookid)
        End If
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
        Dim transacid = GetTransacID(bookid, usid)

        If CboxLost.Checked = True Then
            SetStatus("LOST", transacid)
        Else
            SetStatus("RETURNED", transacid)
            AddQty(bookid)
        End If
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
        Dim transacid = GetTransacID(bookid, usid)

        If CboxLost.Checked = True Then
            SetStatus("LOST", transacid)
        Else
            SetStatus("RETURNED", transacid)
            AddQty(bookid)
        End If
        SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), GetTransacID(bookid, usid))
        UpdateTableCirculation()
        MsgBox(title & " has been returned by " & name & " in " & DateTime.Now, MsgBoxStyle.OkOnly, "Library Management System")

        btncount -= 1
        btns(btncount).Visible = False
        ShowToReturn(usid)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer = CountToReturn(ReUserID.Text)
        Dim ids As New ArrayList
        Dim books As New ArrayList
        Dim msg As String = "The book/s "

        For i As Integer = 0 To length - 1
            ids.Add(DataGridView1.Rows(i).Cells(0).Value)
        Next

        For i As Integer = 0 To 4
            btns(i).Visible = False
        Next

        For index As Integer = 0 To length - 1
            Dim usid As String = ReUserID.Text
            Dim bookid As String = ids(index)
            Dim transacid = GetTransacID(bookid, usid)

            If CboxLost.Checked = True Then
                SetStatus("LOST", transacid)
            Else
                SetStatus("RETURNED", transacid)
                AddQty(bookid)
            End If

            SetReturnDate(DateTime.Now.ToString("yyyy-MM-dd"), transacid)
            UpdateTableCirculation()
            ShowToReturn(usid)
        Next
        msg += "has been returned in " & DateTime.Now
        MsgBox(msg, MsgBoxStyle.OkOnly, "Library Management System")
        btncount = 0
    End Sub
End Class
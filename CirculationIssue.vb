Imports System.Globalization

Public Class CirculationIssue
    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        Dim name = GetValue("userlist", "NAME", IsUserID.Text)
        Dim title = GetValue("booklist", "TITLE", IsBookID.Text)


        If GetValueActive("userlist", "ID", IsUserID.Text) = Nothing Then
            MsgBox("The USER doesn't exist")
            Return
        End If

        If GetValueActive("booklist", "ID", IsBookID.Text) = Nothing Then
            MsgBox("The BOOK doesn't exist")
            Return
        End If

        If IsUserID.Text = "" Or IsBookID.Text = "" Then
            MsgBox("Empty field detected, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
        End If

        If GetQty(IsBookID.Text) < 1 Then
            MsgBox("The selected BOOK is currently OUT of STOCK.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If CheckDuplicate(IsUserID.Text, IsBookID.Text) <> Nothing Then

            If GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text)) = "LOST" Then
                MsgBox(name & " has lost " & title & " in the past and therefore can't borrow it again.", MsgBoxStyle.OkOnly, "Library Management System")
            Else
                MsgBox(name & " has already borrowed " & title & " and is yet to return it.", MsgBoxStyle.OkOnly, "Library Management System")
            End If
            Return
        End If

        If IsDBNull(GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(IsBookID.Text, IsUserID.Text))) Then
            Return
        End If


        DtpDue.Value = DtpIs.Value.AddDays(14)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO issuedbooks (`BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS`) VALUES ( '" & IsUserID.Text & "', '" & name & "', '" & IsBookID.Text & "', '" & title & "', '" & DtpIs.Text & "', '" & DtpDue.Text & "', 'PENDING' )"
        cmd.ExecuteNonQuery()
        con.Close()
        SubtractQty(IsBookID.Text)
        UpdateTableCirculation()
        MsgBox(title & " has been issued to " & name & " in " & DtpIs.Text, MsgBoxStyle.OkOnly, "Library Management System")
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
End Class
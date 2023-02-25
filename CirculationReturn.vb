Public Class CirculationReturn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim name = GetValue("userlist", "NAME", ReUserID.Text)
        Dim title = GetValue("booklist", "TITLE", ReBookID.Text)

        If GetValueActive("userlist", "ID", ReUserID.Text) = Nothing Then
            MsgBox("The USER doesn't exist")
            Return
        End If

        If GetValueActive("booklist", "ID", ReBookID.Text) = Nothing Then
            MsgBox("The BOOK doesn't exist")
            Return
        End If

        If GetTransacID(ReBookID.Text, ReUserID.Text) = Nothing Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "LOST" Or GetValueIssued("issuedbooks", "`STATUS`", GetTransacID(ReBookID.Text, ReUserID.Text)) = "RETURNED" Then
            MsgBox("This transaction doesn't exist.")
            Return
        End If

        If ReUserID.Text = "" Or ReBookID.Text = "" Then
            MsgBox("Empty field detected, please insert all the necessary details.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If CheckDuplicate(ReUserID.Text, ReBookID.Text) = Nothing & GetValue("booklist", "QTY", ReBookID.Text) > 0 Then
            MsgBox(title & " is not currently issued to " & name & ", Please check the entered details.", MsgBoxStyle.OkOnly, "Library Management System")
            Return
        End If

        If cbxLost.Checked = True Then
            SetStatus("LOST", GetTransacID(ReBookID.Text, ReUserID.Text))
            MsgBox(title & " has been lost by " & name & ".", MsgBoxStyle.OkOnly, "Library Management System")
            UpdateTableCirculation()
            Return
        End If

        MsgBox(title & " has been returned by " & name & ".", MsgBoxStyle.OkOnly, "Library Management System")
        AddQty(ReBookID.Text)
        SetStatus("RETURNED", GetTransacID(ReBookID.Text, ReUserID.Text))
        SetStatus("RETURNED", GetTransacID(ReBookID.Text, ReUserID.Text))
        UpdateTableCirculation()
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
End Class
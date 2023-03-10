Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Net
Imports MySql.Data.MySqlClient


Module Database
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Sub OpenCon()
        con.ConnectionString = ConPath
        con.Open()
    End Sub

    Sub UpdateTableCatalog(name As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `ID`, `ISBN`, `TITLE`, `GENRE`, `AUTHOR`, `PUBLISHER`, `DATE-RCV`, `QTY` From lms." & name & " WHERE INACTIVE NOT in (1)", con)
        adapter.Fill(table)
        FeatureCatalogList.DataGridView1.DataSource = table
        BookCatalog.DataGridView1.DataSource = table

        For Each DataGridColumns In FeatureCatalogList.DataGridView1.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        FeatureCatalogList.DataGridView1.CurrentCell = Nothing
        BookCatalog.DataGridView1.CurrentCell = Nothing

    End Sub
    Sub UpdateTableCatalogUser(name As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `ID`, `ISBN`, `TITLE`, `GENRE`, `AUTHOR`, `PUBLISHER`, `DATE-RCV`, `QTY` From lms." & name & " WHERE INACTIVE NOT in (1)", con)
        adapter.Fill(table)
        BookUser.DataGridView1.DataSource = table

        For Each DataGridColumns In BookUser.DataGridView1.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        BookUser.DataGridView1.CurrentCell = Nothing

    End Sub

    Sub UpdateTableUser(name As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `ID`, `NAME`, `GENDER`, `PHONENO`, `EMAIL`, `BIRTHDATE` From lms." & name & " WHERE INACTIVE NOT in (1)", con)
        adapter.Fill(table)
        FeatureUserList.DataGridView1.DataSource = table

        For Each DataGridColumns In FeatureUserList.DataGridView1.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        FeatureUserList.DataGridView1.CurrentCell = Nothing

    End Sub
    Sub ShowIssuedBooks(id As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `BOOK`, `STATUS`, `FINE` From lms.issuedbooks WHERE `BORROWER ID` = " & id & " AND `STATUS` != 'LOST'", con)
        adapter.Fill(table)
        FeatureUserList.DataGridView2.DataSource = table

        For Each DataGridColumns In FeatureUserList.DataGridView2.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        FeatureUserList.DataGridView2.CurrentCell = Nothing
    End Sub
    Sub ShowIssuedBooksUser(id As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS` From lms.issuedbooks WHERE `BORROWER ID` = " & id & " AND `STATUS` != 'LOST'", con)
        adapter.Fill(table)
        HomeUser.DataGridView2.DataSource = table

        For Each DataGridColumns In FeatureUserList.DataGridView2.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        FeatureUserList.DataGridView2.CurrentCell = Nothing
    End Sub
    Sub UpdateTableCirculation()
        UpdateStatus()
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS` From lms.issuedbooks WHERE `STATUS` != 'RETURNED' AND `STATUS` != 'LOST'", con)
        adapter.Fill(table)

        For Each DataGridColumns In FeatureCatalogList.DataGridView1.Columns
            DataGridColumns.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        FeatureCirculation.DataGridView1.DataSource = table
        FeatureCirculation.DataGridView1.CurrentCell = Nothing
    End Sub


    Sub FilterTable(dgv As DataGridView, cbx As ComboBox, txt As TextBox, name As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT * From lms." & name & " WHERE INACTIVE NOT in (1)", con)
        adapter.Fill(table)

        Dim DV As New DataView(table)
        Dim var As String

        var = UCase(cbx.SelectedItem).ToString & " " & "Like '%{0}%'"
        DV.RowFilter = String.Format(var, txt.Text)
        dgv.DataSource = DV

    End Sub

    Sub SpecificFilterTable(database As String, dgv As DataGridView, cbx As ComboBox, txt As TextBox)
        Dim table As New DataTable()
        Dim var = "SELECT * FROM lms." & database & " WHERE " & cbx.SelectedItem & " = " & "'" & txt.Text & "'" & "AND INACTIVE not in (1)"
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter(var, con)
        adapter.Fill(table)
        dgv.DataSource = table

    End Sub

    Sub FilterTableCirc(dgv As DataGridView, cbx As ComboBox, txt As TextBox, name As String)
        Dim table As New DataTable()
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter("SELECT `BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS` From lms." & name & " WHERE STATUS != 'LOST'", con)
        adapter.Fill(table)

        Dim DV As New DataView(table)
        Dim var As String

        var = UCase(cbx.SelectedItem).ToString & " " & "Like '%{0}%'"
        DV.RowFilter = String.Format(var, txt.Text)
        dgv.DataSource = DV

    End Sub

    Sub SpecificFilterCirc(database As String, dgv As DataGridView, cbx As ComboBox, txt As TextBox)
        Dim table As New DataTable()
        Dim var = "SELECT `BORROWER ID`, `BORROWER`, `BOOK ID`, `BOOK`, `DATE-ISSUED`, `DUE-DATE`, `STATUS` FROM lms." & database & " WHERE " & cbx.SelectedItem & " = " & "'" & txt.Text & "'"
        con.ConnectionString = SourcePath
        Dim adapter As New MySqlDataAdapter(var, con)
        adapter.Fill(table)
        dgv.DataSource = table

    End Sub

    Public Function GetQty(id As String) As Integer
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT QTY FROM lms.booklist WHERE ID=" & "'" & id & "'" & " LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()
        Return result

    End Function

    Sub SubtractQty(id As String)
        Dim qty = GetQty(id)

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`booklist` SET `QTY` = '" & qty - 1 & "' WHERE (`ID` = '" & id & "');"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub SetStatus(status As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`issuedbooks` SET `STATUS` = '" & status & "' WHERE (`TRANSAC_ID` = '" & id & "');"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub SetFine(fine As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`issuedbooks` SET `FINE` = '" & fine & "' WHERE (`TRANSAC_ID` = '" & id & "');"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub SetReturnDate(returndate As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`issuedbooks` SET `DATE-RETURNED` = '" & returndate & "' WHERE (`TRANSAC_ID` = '" & id & "');"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub AddQty(id As String)
        Dim qty = GetQty(id)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`booklist` SET `QTY` = '" & qty + 1 & "' WHERE (`ID` = '" & id & "');"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Function GetValue(table As String, col As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT " & col & " FROM lms." & table & " WHERE ID=" & "'" & id & "'" & " LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()
        Return result
    End Function
    Public Function GetValueActive(table As String, col As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT " & col & " FROM lms." & table & " WHERE ID=" & "'" & id & "' AND INACTIVE != 1" & " LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()
        Return result
    End Function
    Public Function GetValueIssued(table As String, col As String, id As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT " & col & " FROM lms." & table & " WHERE TRANSAC_ID=" & "'" & id & "'" & " LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()
        Return result
    End Function
    Public Function GetTransacID(bookid As String, usid As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM lms.issuedbooks WHERE `BOOK ID`=" & "'" & bookid & "'" & "AND `BORROWER ID`=" & "'" & usid & "' AND `STATUS` != 'RETURNED' " & " LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()
        Return result
    End Function

    Public Function CheckDuplicate(userid As String, bookid As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM issuedbooks WHERE `BORROWER ID` = " & "'" & userid & "'" & " AND `BOOK ID` = " & "'" & bookid & "' AND `STATUS` != 'RETURNED'"
        Dim result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function
    Public Function CountOverdue(usid As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM issuedbooks WHERE `BORROWER ID` = " & "'" & usid & "'" & " AND `STATUS` = 'OVERDUE'"
        Dim result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function
    Sub DeleteIssued(userid As String, bookid As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM issuedbooks WHERE `BORROWER ID` = " & "'" & userid & "'" & " AND `BOOK ID` = " & "'" & bookid & "'"
        Dim result = cmd.ExecuteScalar
        con.Close()
    End Sub

    Public Function GetTotalUser()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM userlist WHERE INACTIVE NOT in (1)"
        Dim result = cmd.ExecuteScalar
        con.Close()

        Return result
    End Function

    Public Function GetTotalBooks()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM booklist WHERE INACTIVE NOT in (1)"
        Dim result = cmd.ExecuteScalar
        con.Close()

        Return result
    End Function
    Public Function GetTotalIssuedBooks()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM issuedbooks WHERE `STATUS` != 'LOST'"
        Dim result = cmd.ExecuteScalar
        con.Close()

        Return result
    End Function
    Public Function GetBooksReturn()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM issuedbooks WHERE `STATUS` = 'BORROWED'"
        Dim result = cmd.ExecuteScalar
        con.Close()

        Return result
    End Function
    Public Function GetTotalIssuedBooksLost()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM issuedbooks WHERE `STATUS` != 'LOST'"
        Dim result = cmd.ExecuteScalar
        con.Close()

        Return result
    End Function
    Public Function CountBooksBorrowed(usid As String)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM issuedbooks WHERE `STATUS` = 'BORROWED' AND `BORROWER ID` = '" & usid & "' "
        Dim result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function
    Public Function GetLastRow(table As String, decrement As Integer)
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select PATH from booklist WHERE INACTIVE != 1 order by ID DESC LIMIT " & decrement & ",1 ;"
        Dim result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function
    Public Function GetLastRowIssued(table As String, decrement As Integer)

        If GetTotalIssuedBooks() < 1 Then
            Return False
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "select `TRANSAC_ID` from issuedbooks order by `TRANSAC_ID` DESC LIMIT " & decrement & ",1 ;"
        Dim result = cmd.ExecuteScalar
        con.Close()
        Return result
    End Function
    Public Function GetListOfIssuedID()

        Dim ids As New ArrayList

        For index As Integer = 0 To GetTotalIssuedBooks() - 1
            ids.Add(GetLastRowIssued("issuedbooks", index))
        Next


        Return ids

    End Function
    Sub UpdateStatus()
        Dim dueDate As DateTime
        Dim idList As ArrayList
        idList = GetListOfIssuedID()

        For index As Integer = 0 To idList.Count - 1

            dueDate = GetValueIssued("issuedbooks", "`DUE-DATE`", idList(index))

            If GetValueIssued("issuedbooks", "STATUS", idList(index)) = "LOST" Or GetValueIssued("issuedbooks", "STATUS", idList(index)) = "RETURNED" Then

            ElseIf DateTime.Compare(DateTime.Now, dueDate) >= 0 Then
                SetStatus("OVERDUE", idList(index))
            Else
                SetStatus("BORROWED", idList(index))
            End If

            If GetValueIssued("issuedbooks", "STATUS", idList(index)) = "OVERDUE" Then
                SetFine(50 * DateDiff("d", dueDate, Now), idList(index))
            End If

        Next

    End Sub

    Public Function Exists(tbl As String, id As String, val As String)

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT ID FROM lms." & tbl & " WHERE ID=" & "'" & id & "'" & "AND INACTIVE != 1 " & "LIMIT 1"
        Dim result = cmd.ExecuteScalar()
        con.Close()

        If result = Nothing Then
            Return False
        End If

        Return True

    End Function


End Module

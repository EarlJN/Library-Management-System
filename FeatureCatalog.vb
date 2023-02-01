Imports MySql.Data.MySqlClient

Public Class FeatureCatalog
    Private Sub BtnAddMem_Click(sender As Object, e As EventArgs) Handles BtnAddMem.Click
        Dim emptyTextBoxes = From txt In PnlAddBook.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))

            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO booklist (`ISBN`,`TITLE`, `GENRE`, `AUTHOR`, `PUBLISHER`, `DATE-RCV`, `QTY`, `PATH`) VALUES ('" & TxtIsbn.Text & "', '" & TxtTitle.Text & "', '" & CbxGenre.SelectedItem & "', '" & TxtAuthor.Text & "', '" & TxtPublisher.Text & "', '" & DtpRecieved.Text & "', '" & TxtQuantity.Text & "', '" & TxtPath.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox(TxtTitle.Text & "is successfully added.")
        con.Close()

        For Each ctrl As Control In PnlAddBook.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        PicAddBook.Image = Nothing
        DtpRecieved.Value = DateTime.Now
    End Sub

    Private Sub BtnAddPic_Click(sender As Object, e As EventArgs) Handles BtnAddPic.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicAddBook.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtDelId.Text = "" Then
            MsgBox("The ID field is empty, please insert the desired BOOK ID")
            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM booklist"

        If TxtDelId.Text > cmd.ExecuteScalar() Then
            MsgBox("The Selected ID does not exist.")
            con.Close()
            ClearUser(PnlDelBook, PicDelBook, DtpDelRecieved)
            Return
        End If

        Dim command As New MySqlCommand("SELECT * FROM `booklist` WHERE `ID` = @id", con)
        command.Parameters.Add("@id", MySqlDbType.Int64).Value = TxtDelId.Text

        Dim reader As MySqlDataReader

        reader = command.ExecuteReader()
        If reader.Read() Then

            If reader(9) = 1 Or reader(9) Is Nothing Then
                MsgBox("The Selected ID does not exist.")
                con.Close()
                Return
            End If

            TxtDelIsbn.Text = reader(1)
            TxtDelTitle.Text = reader(2)
            CbxDelGenre.SelectedItem = reader(3)
            TxtDelAuthor.Text = reader(4)
            TxtDelPublisher.Text = reader(5)
            DtpDelRecieved.Text = reader(6)
            TxtDelQty.Text = reader(7)
            TxtDelPath.Text = reader(8)
            PicDelBook.Image = Image.FromFile(reader(8))

        End If

        con.Close()

        Button1.Enabled = False
        BtnDelBook.Enabled = True
        BtnEditBook.Enabled = True
        BtnCancel.Enabled = True

    End Sub

    Private Sub BtnDelBook_Click(sender As Object, e As EventArgs) Handles BtnDelBook.Click

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`booklist` SET `INACTIVE` = '1' WHERE (`ID` = '" & TxtDelId.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox(TxtDelId.Text & " is successfully added.")
        con.Close()
        ClearUser(PnlDelBook, PicDelBook, DtpDelRecieved)

        Button1.Enabled = True

    End Sub

    Private Sub BtnEditBook_Click(sender As Object, e As EventArgs) Handles BtnEditBook.Click
        Dim emptyTextBoxes = From txt In PnlDelBook.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))

            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`booklist` SET `ISBN` = '" & TxtDelIsbn.Text & "', `PATH` = '" & TxtDelPath.Text & "', `TITLE` = '" & TxtDelTitle.Text & "', `GENRE` = '" & CbxDelGenre.SelectedItem & "', `AUTHOR` = '" & TxtDelAuthor.Text & "', `PUBLISHER` = '" & TxtDelPublisher.Text & "', `PATH` = '" & TxtDelPath.Text & "', `DATE-RCV` = '" & DtpDelRecieved.Text & "', `QTY` = '" & TxtDelQty.Text & "'  WHERE (`ID` = '" & TxtDelId.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox("BOOK ID: " & TxtDelId.Text & " is successfully added.")
        con.Close()

        For Each ctrl As Control In PnlDelBook.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        PicDelBook.Image = Nothing
        DtpDelRecieved.Value = DateTime.Now
        BtnDelBook.Enabled = False
        BtnEditBook.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicDelBook.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtDelPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Button1.Enabled = True
        ClearUser(PnlDelBook, PicDelBook, DtpDelRecieved)
        BtnDelBook.Enabled = False
        BtnEditBook.Enabled = False
    End Sub
End Class
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FeatureUser
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicAddUser.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnAddPic.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicAddUser.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BtnAddMem_Click(sender As Object, e As EventArgs) Handles BtnAddMem.Click
        Dim emptyTextBoxes = From txt In PnlAddUser.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))
            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO userlist (`NAME`, `GENDER`, `PHONENO`, `EMAIL`, `BIRTHDATE`, `PATH`) VALUES ( '" & TxtName.Text & "', '" & CbxGen.SelectedItem & "', '" & TxtPhone.Text & "', '" & TxtEmail.Text & "', '" & DtpBod.Text & "', '" & TxtPath.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox(TxtName.Text & " is successfully added.")
        con.Close()

        ClearUser(PnlAddUser, PicAddUser, DtpBod)
        'For Each ctrl As Control In PnlAddUser.Controls
        '    If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
        '        ctrl.Text = ""
        '    End If
        'Next
        'PicAddUser.Image = Nothing
        'DtpBod.Value = DateTime.Now
    End Sub

    Private Sub BtnEditSrc_Click(sender As Object, e As EventArgs) Handles BtnEditSrc.Click
        If TxtDelSrc.Text = "" Then
            MsgBox("The ID field is empty, please insert the desired BOOK ID")
            Return
        End If

        OpenCon()

        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM userlist"

        If TxtDelSrc.Text > cmd.ExecuteScalar() Then
            MsgBox("The Selected ID does not exist.")
            cmd.Connection = Nothing
            con.Close()

            For Each ctrl As Control In PnlDelUser.Controls
                If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                    ctrl.Text = ""
                End If
            Next
            PicEditUser.Image = Nothing
            DtpDelBod.Value = DateTime.Now

            Return
        End If

        Dim command As New MySqlCommand("SELECT * FROM `userlist` WHERE `ID` = @id", con)
        command.Parameters.Add("@id", MySqlDbType.Int64).Value = TxtDelSrc.Text

        Dim reader As MySqlDataReader

        reader = command.ExecuteReader()
        If reader.Read() Then

            If reader(7) = 1 Or reader(7) Is Nothing Then
                MsgBox("The Selected ID does not exist.")
                con.Close()
                Return
            End If

            TxtDelName.Text = reader(1)
            TxtDelPhone.Text = reader(3)
            TxtDelEmail.Text = reader(4)
            CbxDelGen.Text = reader(2)
            DtpDelBod.Text = reader(5)
            TxtDelPath.Text = reader(6)
            PicEditUser.ImageLocation = "C:\Users\Earl\Desktop\AP-LibraryManagementSystem\bin\Release\net6.0-windows\" & TxtDelPath.Text

        End If

        con.Close()
        BtnDelUser.Enabled = True
        BtnEditUser.Enabled = True
        BtnEditSrc.Enabled = False
        BtnCancel.Enabled = True

    End Sub

    Private Sub BtnDelUser_Click(sender As Object, e As EventArgs) Handles BtnDelUser.Click
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`userlist` SET `INACTIVE` = '1' WHERE (`ID` = '" & TxtDelSrc.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox(TxtDelName.Text & " is successfully deleted.")
        con.Close()

        For Each ctrl As Control In PnlDelUser.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        PicEditUser.Image = Nothing
        DtpDelBod.Value = DateTime.Now
        BtnDelUser.Enabled = False
        BtnEditUser.Enabled = False
        BtnEditSrc.Enabled = True


    End Sub

    Private Sub Only_Numbers(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDelPhone.KeyPress, TxtPhone.KeyPress, TxtDelSrc.KeyPress
        If Asc(e.KeyChar) = 8 Then
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnEditUser.Click
        Dim emptyTextBoxes = From txt In PnlDelUser.Controls.OfType(Of TextBox)() Where txt.Text.Length = 0 Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(", ", emptyTextBoxes)))

            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`userlist` SET `NAME` = '" & TxtDelName.Text & "', `GENDER` = '" & CbxDelGen.Text & "', `PHONENO` = '" & TxtDelPhone.Text & "', `EMAIL` = '" & TxtDelEmail.Text & "', `BIRTHDATE` = '" & DtpDelBod.Text & "', `PATH` = '" & TxtDelPath.Text & "' WHERE (`ID` = '" & TxtDelSrc.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox("BOOK ID: " & TxtDelSrc.Text & " is successfully deleted.")
        con.Close()


        ClearUser(PnlDelUser, PicEditUser, DtpDelBod)
        BtnDelUser.Enabled = False
        BtnEditUser.Enabled = False
        BtnEditSrc.Enabled = True


    End Sub

    Private Sub BtnEditPic_Click(sender As Object, e As EventArgs) Handles BtnEditPic.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicEditUser.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtDelPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        If Not PassValidate(TxtPass.Text) Then
            Return
        End If

        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "UPDATE `lms`.`userlist` SET `PASS` = '" & TxtPass.Text & "'  WHERE (`ID` = '" & TxtAccID.Text & "');"
        cmd.ExecuteNonQuery()
        MsgBox("An account for " & "USER ID: " & TxtAccID.Text & " has been created.")
        con.Close()


        BtnAccSrc.Enabled = True
        BtnAccCancel.Enabled = False
        TxtAccID.Clear()
        TxtPass.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearUser(PnlDelUser, PicEditUser, DtpDelBod)
        BtnEditSrc.Enabled = True
        BtnEditUser.Enabled = False
        BtnDelUser.Enabled = False

        TxtAccID.Clear()
        TxtPass.Clear()
    End Sub

    Private Sub BtnAccSrc_Click(sender As Object, e As EventArgs) Handles BtnAccSrc.Click
        BtnCreate.Enabled = True
        BtnAccSrc.Enabled = False
        BtnAccCancel.Enabled = True
    End Sub

    Private Sub BtnAccCancel_Click(sender As Object, e As EventArgs) Handles BtnAccCancel.Click
        BtnCreate.Enabled = False
        BtnAccSrc.Enabled = True
        BtnAccCancel.Enabled = False

        TxtAccID.Clear()
        TxtPass.Clear()
    End Sub

End Class
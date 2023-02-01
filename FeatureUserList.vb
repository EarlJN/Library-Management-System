Public Class FeatureUserList
    Private Sub DataGridView1_SelectColum(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        TxtId.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        TxtName.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        TxtGender.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
        TxtPhone.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
        TxtEmail.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
        TxtBod.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value
        PicUser.Image = Image.FromFile(GetValue("userlist", "PATH", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value))
        ShowIssuedBooks(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value)

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        e.Handled = True
    End Sub

    Private Sub BtnEditSrc_Click(sender As Object, e As EventArgs) Handles BtnEditSrc.Click
        'SpecificFilterTable("userlist", DataGridView1, TxtEditSrc)
        If TxtEditSrc.Text = "" Then
            MsgBox("The ID field is empty, please insert the desired BOOK ID")
            Return
        End If

        For index As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(index).Cells(0).Value = TxtEditSrc.Text Then
                DataGridView1.CurrentCell = DataGridView1.Rows(index).Cells(0)
                DataGridView1_SelectColum(Me.DataGridView1, New DataGridViewCellEventArgs(index, 0))
            End If
        Next
    End Sub

    Private Sub FeatureUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.CurrentCell = Nothing
    End Sub

    Public Sub UserListClear()
        ClearUser(PnlUserShow, PicUser)
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        Dim add As New UserAdd
        add.ShowDialog()
    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnEditUser.Click
        Dim edit As New UserEdit
        edit.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim create As New UserAccount
        create.ShowDialog()
    End Sub
End Class
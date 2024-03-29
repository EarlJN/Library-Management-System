﻿Imports System.IO
Imports System.Net
Imports System.Windows
Public Class Main
    Private CurBtn As Button
    Friend BtnFEATURE() As Form
    Public usid As String

    Friend Sub Change_Frame(frm As Form, choice As String)

        Select Case choice
            Case "PanelMain"
                PanelMain.Controls.Clear()
                frm.TopLevel = False
                frm.TopMost = True
                frm.Dock = DockStyle.Fill
                PanelMain.Controls.Add(frm)
                frm.Show()
        End Select
    End Sub


    Private Sub ActiveBtn(btn As Button)

        If CurBtn IsNot Nothing Then
            CurBtn.BackColor = Color.FromArgb(0, 20, 39)
        End If
        btn.BackColor = Color.FromArgb(70, 90, 114)
        CurBtn = btn

    End Sub

    Private Sub BtnBookList_Click(sender As Object, e As EventArgs) Handles BtnBookList.Click

        If usid <> "admin" Then
            ActiveBtn(CType(sender, Button))
            Change_Frame(BookUser, "PanelMain")
            UpdateTableCatalogUser("booklist")

        Else
            ActiveBtn(CType(sender, Button))
            Change_Frame(FeatureCatalogList, "PanelMain")
            UpdateTableCatalog("booklist")
        End If
        'ActiveBtn(CType(sender, Button))
        'Change_Frame(FeatureCatalogList, "PanelMain")
        'UpdateTableCatalog("booklist")
    End Sub

    Private Sub BtnUserList_Click(sender As Object, e As EventArgs) Handles BtnUserList.Click

        ActiveBtn(CType(sender, Button))
        If usid = "admin" Then
            ActiveBtn(CType(sender, Button))
            Change_Frame(FeatureUserList, "PanelMain")
            UpdateTableUser("userlist")
        Else
            ShowAccUser(usid)
        End If

    End Sub

    Private Sub BtnCirculation_Click(sender As Object, e As EventArgs) Handles BtnCirculation.Click

        ActiveBtn(CType(sender, Button))
        Change_Frame(FeatureCirculation, "PanelMain")
        UpdateTableCirculation()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs)

        ActiveBtn(CType(sender, Button))

    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        ActiveBtn(CType(sender, Button))
        If usid = "admin" Then
            ShowHome()
        Else
            ShowHomeUser()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
        Login.TxtPass.Clear()
        Login.TxtUser.Clear()
    End Sub

    'Sub ShowUser(usid As String)
    '    ActiveBtn(BtnDashboard)

    '    PanelMain.Controls.Clear()
    '    Change_Frame(HomeUser, "PanelMain")
    '    HomeUser.TxtId.Text = usid
    '    HomeUser.TxtName.Text = GetValue("userlist", "NAME", usid)
    '    HomeUser.TxtGender.Text = GetValue("userlist", "GENDER", usid)
    '    HomeUser.TxtPhone.Text = GetValue("userlist", "PHONENO", usid)
    '    HomeUser.TxtEmail.Text = GetValue("userlist", "EMAIL", usid)
    '    HomeUser.TxtBod.Text = GetValue("userlist", "BIRTHDATE", usid)
    '    HomeUser.PicUser.ImageLocation = BinPath & GetValue("userlist", "PATH", usid)
    '    ShowIssuedBooksUser(usid)

    'End Sub

    Sub ShowAccUser(usid As String)
        ActiveBtn(BtnUserList)

        PanelMain.Controls.Clear()
        Change_Frame(AccUser, "PanelMain")
        AccUser.TxtId.Text = usid
        AccUser.TxtName.Text = GetValue("userlist", "NAME", usid)
        AccUser.TxtGender.Text = GetValue("userlist", "GENDER", usid)
        AccUser.TxtPhone.Text = GetValue("userlist", "PHONENO", usid)
        AccUser.TxtEmail.Text = GetValue("userlist", "EMAIL", usid)
        AccUser.TxtBod.Text = GetValue("userlist", "BIRTHDATE", usid)
        AccUser.PicUser.ImageLocation = BinPath & GetValue("userlist", "PATH", usid)
        ShowIssuedBooksUser(usid)

    End Sub

    Sub ShowHome()
        ActiveBtn(BtnDashboard)
        PanelMain.Controls.Clear()
        HomeAdmin.TotBooks.Text = GetTotalBooks()
        HomeAdmin.TotUser.Text = GetTotalUser()
        HomeAdmin.ToReturn.Text = GetBooksReturn()
        HomeAdmin.PictureBox1.ImageLocation = BinPath & GetLastRow("booklist", 0)
        HomeAdmin.PictureBox2.ImageLocation = BinPath & GetLastRow("booklist", 1)
        HomeAdmin.PictureBox3.ImageLocation = BinPath & GetLastRow("booklist", 2)
        HomeAdmin.PictureBox4.ImageLocation = BinPath & GetLastRow("booklist", 3)
        HomeAdmin.PictureBox5.ImageLocation = BinPath & GetLastRow("booklist", 4)
        Change_Frame(HomeAdmin, "PanelMain")
    End Sub

    Sub ShowHomeUser()
        ActiveBtn(BtnDashboard)
        Dim idArray As String() = GetTop5Ids()
        PanelMain.Controls.Clear()
        HomeUser.BooksReturn.Text = GetTotalBooksToReturn(usid)
        HomeUser.TotOverdue.Text = GetOverdueUser(usid)
        HomeUser.TotBorrowed.Text = GetTotalBorrowed(usid)
        HomeUser.PictureBox1.ImageLocation = BinPath & GetValue("booklist", "path", idArray(0))
        HomeUser.PictureBox2.ImageLocation = BinPath & GetValue("booklist", "path", idArray(1))
        HomeUser.PictureBox3.ImageLocation = BinPath & GetValue("booklist", "path", idArray(2))
        HomeUser.PictureBox4.ImageLocation = BinPath & GetValue("booklist", "path", idArray(3))
        HomeUser.PictureBox5.ImageLocation = BinPath & GetValue("booklist", "path", idArray(4))
        Change_Frame(HomeUser, "PanelMain")
    End Sub


    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Login.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        CountToReturn(1)
        ActiveBtn(CType(sender, Button))
        Change_Frame(Reports, "PanelMain")
        ReportReturned()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ActiveBtn(CType(sender, Button))
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
            Login.TxtPass.Clear()
            Login.TxtUser.Clear()
        End If
    End Sub

End Class
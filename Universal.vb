Imports System.Text.RegularExpressions

Module Universal
    Public SourcePath As String = "datasource=localhost;username=root;password=earl;database=lms;Convert Zero Datetime=True"
    Public ConPath As String = "server=localhost;username=root;password=earl;database=lms"
    Public BinPath As String = "C:\Users\Earl\Desktop\Library-Management-System\bin\Release\net6.0-windows\"


    Sub ClearUser(pnl As Panel, pic As PictureBox, dtp As DateTimePicker)
        For Each ctrl As Control In pnl.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        pic.Image = Nothing
        dtp.Value = DateTime.Now
    End Sub

    Sub ClearUser(pnl As Panel, pic As PictureBox)
        For Each ctrl As Control In pnl.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        pic.Image = Nothing
    End Sub
    Sub ClearTxt(pnl As Panel)
        For Each ctrl As Control In pnl.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Sub DisableFields(pnl As Panel, txt As TextBox)
        For Each ctrl As Control In pnl.Controls
            If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is ComboBox Then
                ctrl.Enabled = False
            End If
        Next

        txt.Enabled = True
    End Sub

    Public Function PassValidate(password As String)
        'Check if password is at least 8 characters long
        If Len(password) < 8 Then
            MsgBox("Password must be at least 8 characters long")
            Return False
        End If

        'Check if password contains at least 1 uppercase and 1 lowercase character
        If Not (Regex.IsMatch(password, "[A-Z]") And Regex.IsMatch(password, "[a-z]")) Then
            MsgBox("Password must contain at least 1 uppercase and 1 lowercase character")
            Return False
        End If

        'Check if password contains at least 1 special character
        If Not Regex.IsMatch(password, "[^a-zA-Z0-9]") Then
            MsgBox("Password must contain at least 1 special character")
            Return False
        End If

        'If all checks pass, password is valid
        Return True
    End Function
End Module

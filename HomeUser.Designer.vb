<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlUserShow = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicUser = New System.Windows.Forms.PictureBox()
        Me.PnlTool = New System.Windows.Forms.Panel()
        Me.PnlUserShow.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(761, 37)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "USER DETAILS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlUserShow
        '
        Me.PnlUserShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlUserShow.Controls.Add(Me.DataGridView2)
        Me.PnlUserShow.Controls.Add(Me.TxtPhone)
        Me.PnlUserShow.Controls.Add(Me.Label7)
        Me.PnlUserShow.Controls.Add(Me.Label8)
        Me.PnlUserShow.Controls.Add(Me.TxtEmail)
        Me.PnlUserShow.Controls.Add(Me.Label1)
        Me.PnlUserShow.Controls.Add(Me.Label6)
        Me.PnlUserShow.Controls.Add(Me.TxtGender)
        Me.PnlUserShow.Controls.Add(Me.Label5)
        Me.PnlUserShow.Controls.Add(Me.TxtBod)
        Me.PnlUserShow.Controls.Add(Me.Label4)
        Me.PnlUserShow.Controls.Add(Me.TxtName)
        Me.PnlUserShow.Controls.Add(Me.Label2)
        Me.PnlUserShow.Controls.Add(Me.TxtId)
        Me.PnlUserShow.Controls.Add(Me.Label3)
        Me.PnlUserShow.Controls.Add(Me.PicUser)
        Me.PnlUserShow.Location = New System.Drawing.Point(12, 59)
        Me.PnlUserShow.Name = "PnlUserShow"
        Me.PnlUserShow.Size = New System.Drawing.Size(761, 491)
        Me.PnlUserShow.TabIndex = 120
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(16, 257)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(731, 219)
        Me.DataGridView2.TabIndex = 122
        Me.DataGridView2.TabStop = False
        '
        'TxtPhone
        '
        Me.TxtPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPhone.Location = New System.Drawing.Point(270, 192)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.ReadOnly = True
        Me.TxtPhone.Size = New System.Drawing.Size(177, 21)
        Me.TxtPhone.TabIndex = 115
        Me.TxtPhone.Tag = """Title Field"""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label7.Location = New System.Drawing.Point(16, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(731, 29)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "ISSUED BOOKS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(195, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Phone No"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtEmail.Location = New System.Drawing.Point(270, 165)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(177, 21)
        Me.TxtEmail.TabIndex = 113
        Me.TxtEmail.Tag = """Title Field"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(195, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "E - Mail"
        '
        'TxtGender
        '
        Me.TxtGender.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtGender.Location = New System.Drawing.Point(270, 138)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.ReadOnly = True
        Me.TxtGender.Size = New System.Drawing.Size(177, 21)
        Me.TxtGender.TabIndex = 111
        Me.TxtGender.Tag = """Title Field"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(195, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Gender"
        '
        'TxtBod
        '
        Me.TxtBod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtBod.Location = New System.Drawing.Point(270, 111)
        Me.TxtBod.Name = "TxtBod"
        Me.TxtBod.ReadOnly = True
        Me.TxtBod.Size = New System.Drawing.Size(177, 21)
        Me.TxtBod.TabIndex = 109
        Me.TxtBod.Tag = """Title Field"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(195, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Birthdate"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtName.Location = New System.Drawing.Point(270, 84)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(177, 21)
        Me.TxtName.TabIndex = 107
        Me.TxtName.Tag = """Title Field"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(195, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Name"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtId.Location = New System.Drawing.Point(270, 57)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(177, 21)
        Me.TxtId.TabIndex = 105
        Me.TxtId.Tag = """Title Field"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(195, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 20)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "ID"
        '
        'PicUser
        '
        Me.PicUser.Location = New System.Drawing.Point(10, 58)
        Me.PicUser.Name = "PicUser"
        Me.PicUser.Size = New System.Drawing.Size(166, 156)
        Me.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUser.TabIndex = 96
        Me.PicUser.TabStop = False
        '
        'PnlTool
        '
        Me.PnlTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTool.Location = New System.Drawing.Point(0, 0)
        Me.PnlTool.Name = "PnlTool"
        Me.PnlTool.Size = New System.Drawing.Size(785, 45)
        Me.PnlTool.TabIndex = 121
        '
        'HomeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 565)
        Me.Controls.Add(Me.PnlTool)
        Me.Controls.Add(Me.PnlUserShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeUser"
        Me.Text = "HomeUser"
        Me.PnlUserShow.ResumeLayout(False)
        Me.PnlUserShow.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlUserShow As Panel
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtGender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PicUser As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlTool As Panel
End Class

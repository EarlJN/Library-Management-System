<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlAddUser = New System.Windows.Forms.Panel()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.DtpBod = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnAddPic = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicAddUser = New System.Windows.Forms.PictureBox()
        Me.BtnAddMem = New System.Windows.Forms.Button()
        Me.CbxGen = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlAddUser.SuspendLayout()
        CType(Me.PicAddUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 41)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "ADD USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlAddUser
        '
        Me.PnlAddUser.Controls.Add(Me.TxtPath)
        Me.PnlAddUser.Controls.Add(Me.DtpBod)
        Me.PnlAddUser.Controls.Add(Me.Label16)
        Me.PnlAddUser.Controls.Add(Me.BtnAddPic)
        Me.PnlAddUser.Controls.Add(Me.Label9)
        Me.PnlAddUser.Controls.Add(Me.PicAddUser)
        Me.PnlAddUser.Controls.Add(Me.BtnAddMem)
        Me.PnlAddUser.Controls.Add(Me.CbxGen)
        Me.PnlAddUser.Controls.Add(Me.Label7)
        Me.PnlAddUser.Controls.Add(Me.TxtEmail)
        Me.PnlAddUser.Controls.Add(Me.Label6)
        Me.PnlAddUser.Controls.Add(Me.TxtPhone)
        Me.PnlAddUser.Controls.Add(Me.Label5)
        Me.PnlAddUser.Controls.Add(Me.TxtName)
        Me.PnlAddUser.Controls.Add(Me.Label4)
        Me.PnlAddUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAddUser.Location = New System.Drawing.Point(0, 41)
        Me.PnlAddUser.Name = "PnlAddUser"
        Me.PnlAddUser.Size = New System.Drawing.Size(284, 520)
        Me.PnlAddUser.TabIndex = 126
        '
        'TxtPath
        '
        Me.TxtPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPath.Location = New System.Drawing.Point(124, 437)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(10, 26)
        Me.TxtPath.TabIndex = 122
        Me.TxtPath.Visible = False
        '
        'DtpBod
        '
        Me.DtpBod.CustomFormat = "yyyy-MM-dd"
        Me.DtpBod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpBod.Location = New System.Drawing.Point(13, 258)
        Me.DtpBod.Name = "DtpBod"
        Me.DtpBod.Size = New System.Drawing.Size(259, 23)
        Me.DtpBod.TabIndex = 121
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(13, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 20)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Birthdate"
        '
        'BtnAddPic
        '
        Me.BtnAddPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddPic.FlatAppearance.BorderSize = 0
        Me.BtnAddPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAddPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddPic.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddPic.Location = New System.Drawing.Point(12, 441)
        Me.BtnAddPic.Name = "BtnAddPic"
        Me.BtnAddPic.Size = New System.Drawing.Size(106, 22)
        Me.BtnAddPic.TabIndex = 43
        Me.BtnAddPic.Text = "Select Picture"
        Me.BtnAddPic.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Profile Picture"
        '
        'PicAddUser
        '
        Me.PicAddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicAddUser.Location = New System.Drawing.Point(12, 338)
        Me.PicAddUser.Name = "PicAddUser"
        Me.PicAddUser.Size = New System.Drawing.Size(105, 97)
        Me.PicAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAddUser.TabIndex = 12
        Me.PicAddUser.TabStop = False
        '
        'BtnAddMem
        '
        Me.BtnAddMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddMem.FlatAppearance.BorderSize = 0
        Me.BtnAddMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAddMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddMem.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddMem.Location = New System.Drawing.Point(12, 469)
        Me.BtnAddMem.Name = "BtnAddMem"
        Me.BtnAddMem.Size = New System.Drawing.Size(260, 39)
        Me.BtnAddMem.TabIndex = 11
        Me.BtnAddMem.Text = "Add User"
        Me.BtnAddMem.UseVisualStyleBackColor = False
        '
        'CbxGen
        '
        Me.CbxGen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxGen.FormattingEnabled = True
        Me.CbxGen.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.CbxGen.Location = New System.Drawing.Point(12, 199)
        Me.CbxGen.Name = "CbxGen"
        Me.CbxGen.Size = New System.Drawing.Size(260, 26)
        Me.CbxGen.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gender"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtEmail.Location = New System.Drawing.Point(12, 147)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(260, 26)
        Me.TxtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email Address"
        '
        'TxtPhone
        '
        Me.TxtPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPhone.Location = New System.Drawing.Point(12, 95)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(260, 26)
        Me.TxtPhone.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Phone Number"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtName.Location = New System.Drawing.Point(12, 43)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(260, 26)
        Me.TxtName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Name"
        '
        'UserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.PnlAddUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserAdd"
        Me.Text = "LMS - Add User"
        Me.PnlAddUser.ResumeLayout(False)
        Me.PnlAddUser.PerformLayout()
        CType(Me.PicAddUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PnlAddUser As Panel
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents DtpBod As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnAddPic As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PicAddUser As PictureBox
    Friend WithEvents BtnAddMem As Button
    Friend WithEvents CbxGen As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
End Class

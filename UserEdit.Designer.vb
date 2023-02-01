<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEdit
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
        Me.PnlDelUser = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtDelPath = New System.Windows.Forms.TextBox()
        Me.BtnDelUser = New System.Windows.Forms.Button()
        Me.DtpDelBod = New System.Windows.Forms.DateTimePicker()
        Me.CbxDelGen = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDelEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDelPhone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtDelName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnEditUser = New System.Windows.Forms.Button()
        Me.BtnEditPic = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PicEditUser = New System.Windows.Forms.PictureBox()
        Me.BtnEditSrc = New System.Windows.Forms.Button()
        Me.TxtDelSrc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PnlDelUser.SuspendLayout()
        CType(Me.PicEditUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "EDIT / DELETE USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlDelUser
        '
        Me.PnlDelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlDelUser.Controls.Add(Me.BtnCancel)
        Me.PnlDelUser.Controls.Add(Me.Label18)
        Me.PnlDelUser.Controls.Add(Me.TxtDelPath)
        Me.PnlDelUser.Controls.Add(Me.BtnDelUser)
        Me.PnlDelUser.Controls.Add(Me.DtpDelBod)
        Me.PnlDelUser.Controls.Add(Me.CbxDelGen)
        Me.PnlDelUser.Controls.Add(Me.Label8)
        Me.PnlDelUser.Controls.Add(Me.TxtDelEmail)
        Me.PnlDelUser.Controls.Add(Me.Label12)
        Me.PnlDelUser.Controls.Add(Me.TxtDelPhone)
        Me.PnlDelUser.Controls.Add(Me.Label13)
        Me.PnlDelUser.Controls.Add(Me.TxtDelName)
        Me.PnlDelUser.Controls.Add(Me.Label14)
        Me.PnlDelUser.Controls.Add(Me.BtnEditUser)
        Me.PnlDelUser.Controls.Add(Me.BtnEditPic)
        Me.PnlDelUser.Controls.Add(Me.Label11)
        Me.PnlDelUser.Controls.Add(Me.PicEditUser)
        Me.PnlDelUser.Controls.Add(Me.BtnEditSrc)
        Me.PnlDelUser.Controls.Add(Me.TxtDelSrc)
        Me.PnlDelUser.Controls.Add(Me.Label10)
        Me.PnlDelUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDelUser.Location = New System.Drawing.Point(0, 41)
        Me.PnlDelUser.Name = "PnlDelUser"
        Me.PnlDelUser.Size = New System.Drawing.Size(284, 520)
        Me.PnlDelUser.TabIndex = 127
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancel.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnCancel.Location = New System.Drawing.Point(212, 34)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 22)
        Me.BtnCancel.TabIndex = 125
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(12, 270)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 20)
        Me.Label18.TabIndex = 123
        Me.Label18.Text = "Birthdate"
        '
        'TxtDelPath
        '
        Me.TxtDelPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelPath.Location = New System.Drawing.Point(123, 445)
        Me.TxtDelPath.Name = "TxtDelPath"
        Me.TxtDelPath.Size = New System.Drawing.Size(10, 26)
        Me.TxtDelPath.TabIndex = 123
        Me.TxtDelPath.Visible = False
        '
        'BtnDelUser
        '
        Me.BtnDelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnDelUser.Enabled = False
        Me.BtnDelUser.FlatAppearance.BorderSize = 0
        Me.BtnDelUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnDelUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelUser.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelUser.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnDelUser.Location = New System.Drawing.Point(167, 469)
        Me.BtnDelUser.Name = "BtnDelUser"
        Me.BtnDelUser.Size = New System.Drawing.Size(105, 39)
        Me.BtnDelUser.TabIndex = 124
        Me.BtnDelUser.Text = "Delete User"
        Me.BtnDelUser.UseVisualStyleBackColor = False
        '
        'DtpDelBod
        '
        Me.DtpDelBod.CustomFormat = "yyyy-MM-dd"
        Me.DtpDelBod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDelBod.Location = New System.Drawing.Point(12, 293)
        Me.DtpDelBod.Name = "DtpDelBod"
        Me.DtpDelBod.Size = New System.Drawing.Size(260, 23)
        Me.DtpDelBod.TabIndex = 123
        '
        'CbxDelGen
        '
        Me.CbxDelGen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxDelGen.FormattingEnabled = True
        Me.CbxDelGen.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.CbxDelGen.Location = New System.Drawing.Point(12, 236)
        Me.CbxDelGen.Name = "CbxDelGen"
        Me.CbxDelGen.Size = New System.Drawing.Size(260, 26)
        Me.CbxDelGen.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(7, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Gender"
        '
        'TxtDelEmail
        '
        Me.TxtDelEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelEmail.Location = New System.Drawing.Point(12, 184)
        Me.TxtDelEmail.Name = "TxtDelEmail"
        Me.TxtDelEmail.Size = New System.Drawing.Size(260, 26)
        Me.TxtDelEmail.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(12, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Email Address"
        '
        'TxtDelPhone
        '
        Me.TxtDelPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelPhone.Location = New System.Drawing.Point(12, 132)
        Me.TxtDelPhone.Name = "TxtDelPhone"
        Me.TxtDelPhone.Size = New System.Drawing.Size(260, 26)
        Me.TxtDelPhone.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(12, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Phone Number"
        '
        'TxtDelName
        '
        Me.TxtDelName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelName.Location = New System.Drawing.Point(12, 80)
        Me.TxtDelName.Name = "TxtDelName"
        Me.TxtDelName.Size = New System.Drawing.Size(260, 26)
        Me.TxtDelName.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(12, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Name"
        '
        'BtnEditUser
        '
        Me.BtnEditUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEditUser.Enabled = False
        Me.BtnEditUser.FlatAppearance.BorderSize = 0
        Me.BtnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditUser.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditUser.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnEditUser.Location = New System.Drawing.Point(12, 469)
        Me.BtnEditUser.Name = "BtnEditUser"
        Me.BtnEditUser.Size = New System.Drawing.Size(105, 39)
        Me.BtnEditUser.TabIndex = 44
        Me.BtnEditUser.Text = "Edit User"
        Me.BtnEditUser.UseVisualStyleBackColor = False
        '
        'BtnEditPic
        '
        Me.BtnEditPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEditPic.FlatAppearance.BorderSize = 0
        Me.BtnEditPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnEditPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnEditPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditPic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditPic.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnEditPic.Location = New System.Drawing.Point(11, 445)
        Me.BtnEditPic.Name = "BtnEditPic"
        Me.BtnEditPic.Size = New System.Drawing.Size(106, 22)
        Me.BtnEditPic.TabIndex = 42
        Me.BtnEditPic.Text = "Select Picture"
        Me.BtnEditPic.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(12, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Profile Picture"
        '
        'PicEditUser
        '
        Me.PicEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicEditUser.Location = New System.Drawing.Point(12, 342)
        Me.PicEditUser.Name = "PicEditUser"
        Me.PicEditUser.Size = New System.Drawing.Size(105, 97)
        Me.PicEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicEditUser.TabIndex = 29
        Me.PicEditUser.TabStop = False
        '
        'BtnEditSrc
        '
        Me.BtnEditSrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEditSrc.FlatAppearance.BorderSize = 0
        Me.BtnEditSrc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnEditSrc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnEditSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditSrc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditSrc.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnEditSrc.Location = New System.Drawing.Point(212, 6)
        Me.BtnEditSrc.Name = "BtnEditSrc"
        Me.BtnEditSrc.Size = New System.Drawing.Size(60, 22)
        Me.BtnEditSrc.TabIndex = 17
        Me.BtnEditSrc.Text = "Search"
        Me.BtnEditSrc.UseVisualStyleBackColor = False
        '
        'TxtDelSrc
        '
        Me.TxtDelSrc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelSrc.Location = New System.Drawing.Point(12, 32)
        Me.TxtDelSrc.Name = "TxtDelSrc"
        Me.TxtDelSrc.Size = New System.Drawing.Size(71, 22)
        Me.TxtDelSrc.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(12, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "User ID"
        '
        'UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.PnlDelUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserEdit"
        Me.Text = "LMS - Edit User"
        Me.PnlDelUser.ResumeLayout(False)
        Me.PnlDelUser.PerformLayout()
        CType(Me.PicEditUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PnlDelUser As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtDelPath As TextBox
    Friend WithEvents BtnDelUser As Button
    Friend WithEvents DtpDelBod As DateTimePicker
    Friend WithEvents CbxDelGen As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDelEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtDelPhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtDelName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnEditUser As Button
    Friend WithEvents BtnEditPic As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PicEditUser As PictureBox
    Friend WithEvents BtnEditSrc As Button
    Friend WithEvents TxtDelSrc As TextBox
    Friend WithEvents Label10 As Label
End Class

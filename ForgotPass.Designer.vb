<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPass
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
        Me.lblLower = New System.Windows.Forms.Label()
        Me.cbxPass = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblUpper = New System.Windows.Forms.Label()
        Me.lblSpecial = New System.Windows.Forms.Label()
        Me.TxtConPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.TxtAccID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOtp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLower
        '
        Me.lblLower.AutoSize = True
        Me.lblLower.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLower.Location = New System.Drawing.Point(12, 391)
        Me.lblLower.Name = "lblLower"
        Me.lblLower.Size = New System.Drawing.Size(220, 20)
        Me.lblLower.TabIndex = 160
        Me.lblLower.Text = "✖️ Must contain a lower case letter."
        '
        'cbxPass
        '
        Me.cbxPass.AutoSize = True
        Me.cbxPass.Location = New System.Drawing.Point(12, 259)
        Me.cbxPass.Name = "cbxPass"
        Me.cbxPass.Size = New System.Drawing.Size(108, 19)
        Me.cbxPass.TabIndex = 159
        Me.cbxPass.Text = "Show Password"
        Me.cbxPass.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Password Requirements"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNum.Location = New System.Drawing.Point(12, 441)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(216, 20)
        Me.lblNum.TabIndex = 157
        Me.lblNum.Text = "✖️ Must contain numeric character."
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLength.Location = New System.Drawing.Point(12, 416)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(240, 20)
        Me.lblLength.TabIndex = 156
        Me.lblLength.Text = "✖️ Length must be at least 8 character."
        '
        'lblUpper
        '
        Me.lblUpper.AutoSize = True
        Me.lblUpper.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUpper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUpper.Location = New System.Drawing.Point(12, 366)
        Me.lblUpper.Name = "lblUpper"
        Me.lblUpper.Size = New System.Drawing.Size(230, 20)
        Me.lblUpper.TabIndex = 155
        Me.lblUpper.Text = "✖️ Must contain an upper case letter."
        '
        'lblSpecial
        '
        Me.lblSpecial.AutoSize = True
        Me.lblSpecial.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSpecial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpecial.Location = New System.Drawing.Point(12, 341)
        Me.lblSpecial.Name = "lblSpecial"
        Me.lblSpecial.Size = New System.Drawing.Size(216, 20)
        Me.lblSpecial.TabIndex = 154
        Me.lblSpecial.Text = "✖️ Must contain a special charater."
        '
        'TxtConPass
        '
        Me.TxtConPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtConPass.Location = New System.Drawing.Point(12, 227)
        Me.TxtConPass.Name = "TxtConPass"
        Me.TxtConPass.Size = New System.Drawing.Size(260, 26)
        Me.TxtConPass.TabIndex = 153
        Me.TxtConPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Confirm Password"
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
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "FORGOT PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPass.Location = New System.Drawing.Point(12, 175)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(260, 26)
        Me.TxtPass.TabIndex = 150
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(12, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "Password"
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCreate.FlatAppearance.BorderSize = 0
        Me.BtnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnCreate.Location = New System.Drawing.Point(12, 516)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(260, 39)
        Me.BtnCreate.TabIndex = 148
        Me.BtnCreate.Text = "Change Password"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'TxtAccID
        '
        Me.TxtAccID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAccID.Location = New System.Drawing.Point(12, 76)
        Me.TxtAccID.Name = "TxtAccID"
        Me.TxtAccID.Size = New System.Drawing.Size(260, 22)
        Me.TxtAccID.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "OTP"
        '
        'txtOtp
        '
        Me.txtOtp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOtp.Location = New System.Drawing.Point(12, 125)
        Me.txtOtp.Name = "txtOtp"
        Me.txtOtp.Size = New System.Drawing.Size(260, 26)
        Me.txtOtp.TabIndex = 163
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "USER ID"
        '
        'ForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOtp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAccID)
        Me.Controls.Add(Me.lblLower)
        Me.Controls.Add(Me.cbxPass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblUpper)
        Me.Controls.Add(Me.lblSpecial)
        Me.Controls.Add(Me.TxtConPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ForgotPass"
        Me.Text = "ForgotPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLower As Label
    Friend WithEvents cbxPass As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblUpper As Label
    Friend WithEvents lblSpecial As Label
    Friend WithEvents TxtConPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents TxtAccID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOtp As TextBox
    Friend WithEvents Label4 As Label
End Class

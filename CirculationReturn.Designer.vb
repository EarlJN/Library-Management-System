<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CirculationReturn
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
        Me.lblReTitle = New System.Windows.Forms.Label()
        Me.lblReName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReBookID = New System.Windows.Forms.TextBox()
        Me.Labelxd = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReUserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxLost = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblReTitle
        '
        Me.lblReTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblReTitle.Location = New System.Drawing.Point(127, 122)
        Me.lblReTitle.Name = "lblReTitle"
        Me.lblReTitle.Size = New System.Drawing.Size(145, 18)
        Me.lblReTitle.TabIndex = 172
        '
        'lblReName
        '
        Me.lblReName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReName.ForeColor = System.Drawing.Color.Blue
        Me.lblReName.Location = New System.Drawing.Point(127, 72)
        Me.lblReName.Name = "lblReName"
        Me.lblReName.Size = New System.Drawing.Size(145, 18)
        Me.lblReName.TabIndex = 171
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
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "RETURN BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReBookID
        '
        Me.ReBookID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReBookID.Location = New System.Drawing.Point(12, 118)
        Me.ReBookID.Name = "ReBookID"
        Me.ReBookID.Size = New System.Drawing.Size(109, 22)
        Me.ReBookID.TabIndex = 168
        '
        'Labelxd
        '
        Me.Labelxd.AutoSize = True
        Me.Labelxd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Labelxd.Location = New System.Drawing.Point(12, 97)
        Me.Labelxd.Name = "Labelxd"
        Me.Labelxd.Size = New System.Drawing.Size(64, 18)
        Me.Labelxd.TabIndex = 166
        Me.Labelxd.Text = "Book ID"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn.Location = New System.Drawing.Point(12, 206)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(260, 43)
        Me.btnReturn.TabIndex = 165
        Me.btnReturn.Text = "Submit"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "User ID"
        '
        'ReUserID
        '
        Me.ReUserID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReUserID.Location = New System.Drawing.Point(12, 72)
        Me.ReUserID.Name = "ReUserID"
        Me.ReUserID.Size = New System.Drawing.Size(109, 22)
        Me.ReUserID.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Return Status"
        '
        'cbxLost
        '
        Me.cbxLost.AutoSize = True
        Me.cbxLost.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxLost.Location = New System.Drawing.Point(12, 172)
        Me.cbxLost.Name = "cbxLost"
        Me.cbxLost.Size = New System.Drawing.Size(57, 24)
        Me.cbxLost.TabIndex = 174
        Me.cbxLost.Text = " Lost"
        Me.cbxLost.UseVisualStyleBackColor = True
        '
        'CirculationReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbxLost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReTitle)
        Me.Controls.Add(Me.lblReName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReBookID)
        Me.Controls.Add(Me.Labelxd)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ReUserID)
        Me.Name = "CirculationReturn"
        Me.Text = "CirculationReturn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReTitle As Label
    Friend WithEvents lblReName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReBookID As TextBox
    Friend WithEvents Labelxd As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ReUserID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxLost As CheckBox
End Class

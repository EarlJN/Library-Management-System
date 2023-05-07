<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CirculationReturn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblReTitle = New System.Windows.Forms.Label()
        Me.lblReName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReUserID = New System.Windows.Forms.TextBox()
        Me.btnSrcIssue = New System.Windows.Forms.Button()
        Me.btnCnlIssue = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnReturn1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.btnReturn3 = New System.Windows.Forms.Button()
        Me.btnReturn4 = New System.Windows.Forms.Button()
        Me.btnReturn5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboxLost = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReTitle
        '
        Me.lblReTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblReTitle.Location = New System.Drawing.Point(144, 158)
        Me.lblReTitle.Name = "lblReTitle"
        Me.lblReTitle.Size = New System.Drawing.Size(128, 18)
        Me.lblReTitle.TabIndex = 172
        '
        'lblReName
        '
        Me.lblReName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReName.ForeColor = System.Drawing.Color.Blue
        Me.lblReName.Location = New System.Drawing.Point(76, 49)
        Me.lblReName.Name = "lblReName"
        Me.lblReName.Size = New System.Drawing.Size(194, 18)
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
        Me.Label1.Size = New System.Drawing.Size(745, 41)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "RETURN BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "User ID"
        '
        'ReUserID
        '
        Me.ReUserID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReUserID.Location = New System.Drawing.Point(12, 71)
        Me.ReUserID.Name = "ReUserID"
        Me.ReUserID.Size = New System.Drawing.Size(126, 22)
        Me.ReUserID.TabIndex = 163
        '
        'btnSrcIssue
        '
        Me.btnSrcIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSrcIssue.FlatAppearance.BorderSize = 0
        Me.btnSrcIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSrcIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnSrcIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrcIssue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSrcIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnSrcIssue.Location = New System.Drawing.Point(144, 70)
        Me.btnSrcIssue.Name = "btnSrcIssue"
        Me.btnSrcIssue.Size = New System.Drawing.Size(60, 23)
        Me.btnSrcIssue.TabIndex = 175
        Me.btnSrcIssue.Text = "Search"
        Me.btnSrcIssue.UseVisualStyleBackColor = False
        '
        'btnCnlIssue
        '
        Me.btnCnlIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCnlIssue.Enabled = False
        Me.btnCnlIssue.FlatAppearance.BorderSize = 0
        Me.btnCnlIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCnlIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCnlIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCnlIssue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCnlIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnCnlIssue.Location = New System.Drawing.Point(210, 70)
        Me.btnCnlIssue.Name = "btnCnlIssue"
        Me.btnCnlIssue.Size = New System.Drawing.Size(60, 23)
        Me.btnCnlIssue.TabIndex = 176
        Me.btnCnlIssue.Text = "Cancel"
        Me.btnCnlIssue.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label10.Location = New System.Drawing.Point(12, 101)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(656, 34)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "BOOKS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturn1
        '
        Me.btnReturn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn1.FlatAppearance.BorderSize = 0
        Me.btnReturn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReturn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnReturn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn1.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn1.Location = New System.Drawing.Point(677, 157)
        Me.btnReturn1.Name = "btnReturn1"
        Me.btnReturn1.Size = New System.Drawing.Size(52, 20)
        Me.btnReturn1.TabIndex = 181
        Me.btnReturn1.Tag = "0"
        Me.btnReturn1.Text = "Return"
        Me.btnReturn1.UseVisualStyleBackColor = False
        Me.btnReturn1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(656, 140)
        Me.DataGridView1.TabIndex = 182
        Me.DataGridView1.TabStop = False
        '
        'btnReturn2
        '
        Me.btnReturn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn2.FlatAppearance.BorderSize = 0
        Me.btnReturn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReturn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnReturn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn2.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn2.Location = New System.Drawing.Point(677, 181)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(52, 20)
        Me.btnReturn2.TabIndex = 183
        Me.btnReturn2.Tag = "1"
        Me.btnReturn2.Text = "Return"
        Me.btnReturn2.UseVisualStyleBackColor = False
        Me.btnReturn2.Visible = False
        '
        'btnReturn3
        '
        Me.btnReturn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn3.FlatAppearance.BorderSize = 0
        Me.btnReturn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReturn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnReturn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn3.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn3.Location = New System.Drawing.Point(677, 205)
        Me.btnReturn3.Name = "btnReturn3"
        Me.btnReturn3.Size = New System.Drawing.Size(52, 20)
        Me.btnReturn3.TabIndex = 184
        Me.btnReturn3.Tag = "2"
        Me.btnReturn3.Text = "Return"
        Me.btnReturn3.UseVisualStyleBackColor = False
        Me.btnReturn3.Visible = False
        '
        'btnReturn4
        '
        Me.btnReturn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn4.FlatAppearance.BorderSize = 0
        Me.btnReturn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReturn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnReturn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn4.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn4.Location = New System.Drawing.Point(677, 229)
        Me.btnReturn4.Name = "btnReturn4"
        Me.btnReturn4.Size = New System.Drawing.Size(52, 20)
        Me.btnReturn4.TabIndex = 185
        Me.btnReturn4.Tag = "3"
        Me.btnReturn4.Text = "Return"
        Me.btnReturn4.UseVisualStyleBackColor = False
        Me.btnReturn4.Visible = False
        '
        'btnReturn5
        '
        Me.btnReturn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnReturn5.FlatAppearance.BorderSize = 0
        Me.btnReturn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnReturn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnReturn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn5.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnReturn5.Location = New System.Drawing.Point(677, 253)
        Me.btnReturn5.Name = "btnReturn5"
        Me.btnReturn5.Size = New System.Drawing.Size(52, 20)
        Me.btnReturn5.TabIndex = 186
        Me.btnReturn5.Tag = "4"
        Me.btnReturn5.Text = "Return"
        Me.btnReturn5.UseVisualStyleBackColor = False
        Me.btnReturn5.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button1.Location = New System.Drawing.Point(12, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(656, 30)
        Me.Button1.TabIndex = 187
        Me.Button1.Tag = "4"
        Me.Button1.Text = "Return All"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CboxLost
        '
        Me.CboxLost.AutoSize = True
        Me.CboxLost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CboxLost.Location = New System.Drawing.Point(276, 73)
        Me.CboxLost.Name = "CboxLost"
        Me.CboxLost.Size = New System.Drawing.Size(51, 20)
        Me.CboxLost.TabIndex = 188
        Me.CboxLost.Text = "Lost"
        Me.CboxLost.UseVisualStyleBackColor = True
        '
        'CirculationReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 324)
        Me.Controls.Add(Me.CboxLost)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReturn5)
        Me.Controls.Add(Me.btnReturn4)
        Me.Controls.Add(Me.btnReturn3)
        Me.Controls.Add(Me.btnReturn2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnReturn1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCnlIssue)
        Me.Controls.Add(Me.btnSrcIssue)
        Me.Controls.Add(Me.lblReTitle)
        Me.Controls.Add(Me.lblReName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ReUserID)
        Me.Name = "CirculationReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CirculationReturn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReTitle As Label
    Friend WithEvents lblReName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ReUserID As TextBox
    Friend WithEvents btnSrcIssue As Button
    Friend WithEvents btnCnlIssue As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReturn1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents btnReturn3 As Button
    Friend WithEvents btnReturn4 As Button
    Friend WithEvents btnReturn5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CboxLost As CheckBox
End Class

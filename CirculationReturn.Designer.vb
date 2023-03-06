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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnSrcIssue = New System.Windows.Forms.Button()
        Me.btnCnlIssue = New System.Windows.Forms.Button()
        Me.btnAddIssue = New System.Windows.Forms.Button()
        Me.btnDelIssue = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblReName.Location = New System.Drawing.Point(144, 75)
        Me.lblReName.Name = "lblReName"
        Me.lblReName.Size = New System.Drawing.Size(128, 18)
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
        Me.ReBookID.Location = New System.Drawing.Point(12, 155)
        Me.ReBookID.Name = "ReBookID"
        Me.ReBookID.Size = New System.Drawing.Size(126, 22)
        Me.ReBookID.TabIndex = 168
        '
        'Labelxd
        '
        Me.Labelxd.AutoSize = True
        Me.Labelxd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Labelxd.Location = New System.Drawing.Point(12, 134)
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
        Me.btnReturn.Location = New System.Drawing.Point(12, 506)
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
        Me.ReUserID.Size = New System.Drawing.Size(126, 22)
        Me.ReUserID.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Return Status"
        '
        'cbxLost
        '
        Me.cbxLost.AutoSize = True
        Me.cbxLost.Enabled = False
        Me.cbxLost.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxLost.Location = New System.Drawing.Point(12, 238)
        Me.cbxLost.Name = "cbxLost"
        Me.cbxLost.Size = New System.Drawing.Size(57, 24)
        Me.cbxLost.TabIndex = 174
        Me.cbxLost.Text = " Lost"
        Me.cbxLost.UseVisualStyleBackColor = True
        '
        'btnSrcIssue
        '
        Me.btnSrcIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSrcIssue.FlatAppearance.BorderSize = 0
        Me.btnSrcIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrcIssue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSrcIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnSrcIssue.Location = New System.Drawing.Point(12, 100)
        Me.btnSrcIssue.Name = "btnSrcIssue"
        Me.btnSrcIssue.Size = New System.Drawing.Size(60, 26)
        Me.btnSrcIssue.TabIndex = 175
        Me.btnSrcIssue.Text = "Search"
        Me.btnSrcIssue.UseVisualStyleBackColor = False
        '
        'btnCnlIssue
        '
        Me.btnCnlIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCnlIssue.Enabled = False
        Me.btnCnlIssue.FlatAppearance.BorderSize = 0
        Me.btnCnlIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCnlIssue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCnlIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnCnlIssue.Location = New System.Drawing.Point(78, 100)
        Me.btnCnlIssue.Name = "btnCnlIssue"
        Me.btnCnlIssue.Size = New System.Drawing.Size(60, 26)
        Me.btnCnlIssue.TabIndex = 176
        Me.btnCnlIssue.Text = "Cancel"
        Me.btnCnlIssue.UseVisualStyleBackColor = False
        '
        'btnAddIssue
        '
        Me.btnAddIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAddIssue.Enabled = False
        Me.btnAddIssue.FlatAppearance.BorderSize = 0
        Me.btnAddIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddIssue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnAddIssue.Location = New System.Drawing.Point(12, 183)
        Me.btnAddIssue.Name = "btnAddIssue"
        Me.btnAddIssue.Size = New System.Drawing.Size(60, 26)
        Me.btnAddIssue.TabIndex = 177
        Me.btnAddIssue.Text = "Add"
        Me.btnAddIssue.UseVisualStyleBackColor = False
        '
        'btnDelIssue
        '
        Me.btnDelIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnDelIssue.Enabled = False
        Me.btnDelIssue.FlatAppearance.BorderSize = 0
        Me.btnDelIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelIssue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnDelIssue.Location = New System.Drawing.Point(78, 183)
        Me.btnDelIssue.Name = "btnDelIssue"
        Me.btnDelIssue.Size = New System.Drawing.Size(60, 26)
        Me.btnDelIssue.TabIndex = 178
        Me.btnDelIssue.Text = "Delete"
        Me.btnDelIssue.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label10.Location = New System.Drawing.Point(9, 275)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 25)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "BOOKS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.book, Me.STATUS})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(260, 191)
        Me.DataGridView1.TabIndex = 179
        '
        'BookID
        '
        Me.BookID.HeaderText = "BOOK ID"
        Me.BookID.Name = "BookID"
        Me.BookID.ReadOnly = True
        '
        'book
        '
        Me.book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book.HeaderText = "BOOK TITLE"
        Me.book.Name = "book"
        Me.book.ReadOnly = True
        Me.book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'CirculationReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelIssue)
        Me.Controls.Add(Me.btnAddIssue)
        Me.Controls.Add(Me.btnCnlIssue)
        Me.Controls.Add(Me.btnSrcIssue)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSrcIssue As Button
    Friend WithEvents btnCnlIssue As Button
    Friend WithEvents btnAddIssue As Button
    Friend WithEvents btnDelIssue As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents book As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
End Class

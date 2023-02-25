<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CirculationIssue
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
        Me.DtpIs = New System.Windows.Forms.DateTimePicker()
        Me.IsBookID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Labelxd = New System.Windows.Forms.Label()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IsUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIsName = New System.Windows.Forms.Label()
        Me.lblIsTitle = New System.Windows.Forms.Label()
        Me.DtpDue = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddIssue = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDelIssue = New System.Windows.Forms.Button()
        Me.btnSrcIssue = New System.Windows.Forms.Button()
        Me.btnCnlIssue = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpIs
        '
        Me.DtpIs.CustomFormat = "yyyy-MM-dd"
        Me.DtpIs.Enabled = False
        Me.DtpIs.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpIs.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpIs.Location = New System.Drawing.Point(12, 254)
        Me.DtpIs.Name = "DtpIs"
        Me.DtpIs.Size = New System.Drawing.Size(109, 22)
        Me.DtpIs.TabIndex = 159
        '
        'IsBookID
        '
        Me.IsBookID.Enabled = False
        Me.IsBookID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IsBookID.Location = New System.Drawing.Point(12, 155)
        Me.IsBookID.Name = "IsBookID"
        Me.IsBookID.Size = New System.Drawing.Size(126, 22)
        Me.IsBookID.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Issue Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelxd
        '
        Me.Labelxd.AutoSize = True
        Me.Labelxd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Labelxd.Location = New System.Drawing.Point(12, 134)
        Me.Labelxd.Name = "Labelxd"
        Me.Labelxd.Size = New System.Drawing.Size(64, 18)
        Me.Labelxd.TabIndex = 156
        Me.Labelxd.Text = "Book ID"
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnIssue.Enabled = False
        Me.btnIssue.FlatAppearance.BorderSize = 0
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnIssue.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnIssue.Location = New System.Drawing.Point(12, 506)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(260, 43)
        Me.btnIssue.TabIndex = 155
        Me.btnIssue.Text = "Submit"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "User ID"
        '
        'IsUserID
        '
        Me.IsUserID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IsUserID.Location = New System.Drawing.Point(12, 72)
        Me.IsUserID.Name = "IsUserID"
        Me.IsUserID.Size = New System.Drawing.Size(126, 22)
        Me.IsUserID.TabIndex = 153
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
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "ISSUE BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIsName
        '
        Me.lblIsName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIsName.ForeColor = System.Drawing.Color.Blue
        Me.lblIsName.Location = New System.Drawing.Point(144, 75)
        Me.lblIsName.Name = "lblIsName"
        Me.lblIsName.Size = New System.Drawing.Size(128, 18)
        Me.lblIsName.TabIndex = 161
        '
        'lblIsTitle
        '
        Me.lblIsTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIsTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblIsTitle.Location = New System.Drawing.Point(144, 158)
        Me.lblIsTitle.Name = "lblIsTitle"
        Me.lblIsTitle.Size = New System.Drawing.Size(128, 18)
        Me.lblIsTitle.TabIndex = 162
        '
        'DtpDue
        '
        Me.DtpDue.CustomFormat = "yyyy-MM-dd"
        Me.DtpDue.Enabled = False
        Me.DtpDue.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDue.Location = New System.Drawing.Point(163, 254)
        Me.DtpDue.Name = "DtpDue"
        Me.DtpDue.Size = New System.Drawing.Size(109, 22)
        Me.DtpDue.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(163, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Due Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnAddIssue.TabIndex = 165
        Me.btnAddIssue.Text = "Add"
        Me.btnAddIssue.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.book})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(260, 175)
        Me.DataGridView1.TabIndex = 166
        Me.DataGridView1.Columns(0).Visible = False
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label10.Location = New System.Drawing.Point(15, 289)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 25)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "BOOKS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnDelIssue.TabIndex = 168
        Me.btnDelIssue.Text = "Delete"
        Me.btnDelIssue.UseVisualStyleBackColor = False
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
        Me.btnSrcIssue.TabIndex = 169
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
        Me.btnCnlIssue.TabIndex = 170
        Me.btnCnlIssue.Text = "Cancel"
        Me.btnCnlIssue.UseVisualStyleBackColor = False
        '
        'CirculationIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.btnCnlIssue)
        Me.Controls.Add(Me.btnSrcIssue)
        Me.Controls.Add(Me.btnDelIssue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAddIssue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpDue)
        Me.Controls.Add(Me.lblIsTitle)
        Me.Controls.Add(Me.lblIsName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpIs)
        Me.Controls.Add(Me.IsBookID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Labelxd)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IsUserID)
        Me.Name = "CirculationIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CirculationIssue"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpIs As DateTimePicker
    Friend WithEvents IsBookID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Labelxd As Label
    Friend WithEvents btnIssue As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents IsUserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIsName As Label
    Friend WithEvents lblIsTitle As Label
    Friend WithEvents DtpDue As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddIssue As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDelIssue As Button
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents book As DataGridViewTextBoxColumn
    Friend WithEvents btnSrcIssue As Button
    Friend WithEvents btnCnlIssue As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeatureCirculation
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ChkSpecific = New System.Windows.Forms.CheckBox()
        Me.BtnResetFilter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbxFilter = New System.Windows.Forms.ComboBox()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PnlTool = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnReturnBook = New System.Windows.Forms.Button()
        Me.BtnIssueBook = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlTool.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(14, 121)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(731, 348)
        Me.DataGridView1.TabIndex = 165
        Me.DataGridView1.TabStop = False
        '
        'ChkSpecific
        '
        Me.ChkSpecific.AutoSize = True
        Me.ChkSpecific.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkSpecific.Location = New System.Drawing.Point(458, 51)
        Me.ChkSpecific.Name = "ChkSpecific"
        Me.ChkSpecific.Size = New System.Drawing.Size(82, 20)
        Me.ChkSpecific.TabIndex = 172
        Me.ChkSpecific.Text = "Specific Filter"
        Me.ChkSpecific.UseVisualStyleBackColor = True
        '
        'BtnResetFilter
        '
        Me.BtnResetFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnResetFilter.FlatAppearance.BorderSize = 0
        Me.BtnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetFilter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnResetFilter.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnResetFilter.Location = New System.Drawing.Point(603, 52)
        Me.BtnResetFilter.Name = "BtnResetFilter"
        Me.BtnResetFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnResetFilter.TabIndex = 171
        Me.BtnResetFilter.Text = "Reset"
        Me.BtnResetFilter.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(236, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Keyword"
        '
        'TxtFilter
        '
        Me.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFilter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilter.Location = New System.Drawing.Point(304, 48)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(148, 26)
        Me.TxtFilter.TabIndex = 169
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(14, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 20)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "Filter By"
        '
        'CbxFilter
        '
        Me.CbxFilter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxFilter.FormattingEnabled = True
        Me.CbxFilter.Items.AddRange(New Object() {"BORROWER", "BOOK"})
        Me.CbxFilter.Location = New System.Drawing.Point(82, 48)
        Me.CbxFilter.Name = "CbxFilter"
        Me.CbxFilter.Size = New System.Drawing.Size(148, 25)
        Me.CbxFilter.TabIndex = 167
        Me.CbxFilter.Tag = "Genre Field"
        '
        'BtnFilter
        '
        Me.BtnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnFilter.FlatAppearance.BorderSize = 0
        Me.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnFilter.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnFilter.Location = New System.Drawing.Point(546, 51)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnFilter.TabIndex = 166
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ChkSpecific)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.BtnResetFilter)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtFilter)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CbxFilter)
        Me.Panel1.Controls.Add(Me.BtnFilter)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 491)
        Me.Panel1.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label4.Location = New System.Drawing.Point(-2, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(763, 37)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "CIRCULATION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label10.Location = New System.Drawing.Point(14, 85)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(731, 37)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "BOOKS TO BE RETURNED"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTool
        '
        Me.PnlTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlTool.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTool.Location = New System.Drawing.Point(0, 0)
        Me.PnlTool.Name = "PnlTool"
        Me.PnlTool.Size = New System.Drawing.Size(785, 45)
        Me.PnlTool.TabIndex = 174
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReturnBook, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnIssueBook, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(308, 45)
        Me.TableLayoutPanel1.TabIndex = 138
        '
        'BtnReturnBook
        '
        Me.BtnReturnBook.BackColor = System.Drawing.Color.Transparent
        Me.BtnReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReturnBook.FlatAppearance.BorderSize = 0
        Me.BtnReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturnBook.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnReturnBook.ForeColor = System.Drawing.Color.Black
        Me.BtnReturnBook.Location = New System.Drawing.Point(154, 0)
        Me.BtnReturnBook.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnReturnBook.Name = "BtnReturnBook"
        Me.BtnReturnBook.Size = New System.Drawing.Size(154, 45)
        Me.BtnReturnBook.TabIndex = 4
        Me.BtnReturnBook.Tag = "3"
        Me.BtnReturnBook.Text = "Return Book"
        Me.BtnReturnBook.UseVisualStyleBackColor = False
        '
        'BtnIssueBook
        '
        Me.BtnIssueBook.BackColor = System.Drawing.Color.Transparent
        Me.BtnIssueBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIssueBook.FlatAppearance.BorderSize = 0
        Me.BtnIssueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIssueBook.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnIssueBook.ForeColor = System.Drawing.Color.Black
        Me.BtnIssueBook.Location = New System.Drawing.Point(0, 0)
        Me.BtnIssueBook.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnIssueBook.Name = "BtnIssueBook"
        Me.BtnIssueBook.Size = New System.Drawing.Size(154, 45)
        Me.BtnIssueBook.TabIndex = 3
        Me.BtnIssueBook.Tag = "3"
        Me.BtnIssueBook.Text = "Issue Book"
        Me.BtnIssueBook.UseVisualStyleBackColor = False
        '
        'FeatureCirculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 565)
        Me.Controls.Add(Me.PnlTool)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeatureCirculation"
        Me.Text = "FeatureCirculationReturn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlTool.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ChkSpecific As CheckBox
    Friend WithEvents BtnResetFilter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtFilter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CbxFilter As ComboBox
    Friend WithEvents BtnFilter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlTool As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnReturnBook As Button
    Friend WithEvents BtnIssueBook As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
End Class

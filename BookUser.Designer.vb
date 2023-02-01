<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookUser
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
        Me.PnlBookList = New System.Windows.Forms.Panel()
        Me.ChkSpecific = New System.Windows.Forms.CheckBox()
        Me.BtnResetFilter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxFilter = New System.Windows.Forms.ComboBox()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtIsbn = New System.Windows.Forms.TextBox()
        Me.TxtGenre = New System.Windows.Forms.TextBox()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblIsbn = New System.Windows.Forms.Label()
        Me.LblGenre = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BLPic = New System.Windows.Forms.PictureBox()
        Me.PnlTool = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlBookList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BLPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBookList
        '
        Me.PnlBookList.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlBookList.Controls.Add(Me.ChkSpecific)
        Me.PnlBookList.Controls.Add(Me.BtnResetFilter)
        Me.PnlBookList.Controls.Add(Me.DataGridView1)
        Me.PnlBookList.Controls.Add(Me.Label4)
        Me.PnlBookList.Controls.Add(Me.Label1)
        Me.PnlBookList.Controls.Add(Me.TxtFilter)
        Me.PnlBookList.Controls.Add(Me.Label3)
        Me.PnlBookList.Controls.Add(Me.CbxFilter)
        Me.PnlBookList.Controls.Add(Me.TxtPublisher)
        Me.PnlBookList.Controls.Add(Me.Label2)
        Me.PnlBookList.Controls.Add(Me.TxtQty)
        Me.PnlBookList.Controls.Add(Me.TxtDate)
        Me.PnlBookList.Controls.Add(Me.TxtId)
        Me.PnlBookList.Controls.Add(Me.TxtIsbn)
        Me.PnlBookList.Controls.Add(Me.TxtGenre)
        Me.PnlBookList.Controls.Add(Me.TxtAuthor)
        Me.PnlBookList.Controls.Add(Me.TxtTitle)
        Me.PnlBookList.Controls.Add(Me.BtnFilter)
        Me.PnlBookList.Controls.Add(Me.LblQty)
        Me.PnlBookList.Controls.Add(Me.LblPublisher)
        Me.PnlBookList.Controls.Add(Me.LblID)
        Me.PnlBookList.Controls.Add(Me.LblIsbn)
        Me.PnlBookList.Controls.Add(Me.LblGenre)
        Me.PnlBookList.Controls.Add(Me.LblAuthor)
        Me.PnlBookList.Controls.Add(Me.LblTitle)
        Me.PnlBookList.Controls.Add(Me.BLPic)
        Me.PnlBookList.Location = New System.Drawing.Point(12, 59)
        Me.PnlBookList.Name = "PnlBookList"
        Me.PnlBookList.Size = New System.Drawing.Size(761, 491)
        Me.PnlBookList.TabIndex = 141
        '
        'ChkSpecific
        '
        Me.ChkSpecific.AutoSize = True
        Me.ChkSpecific.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkSpecific.Location = New System.Drawing.Point(595, 164)
        Me.ChkSpecific.Name = "ChkSpecific"
        Me.ChkSpecific.Size = New System.Drawing.Size(82, 20)
        Me.ChkSpecific.TabIndex = 137
        Me.ChkSpecific.Text = "Specific Filter"
        Me.ChkSpecific.UseVisualStyleBackColor = True
        '
        'BtnResetFilter
        '
        Me.BtnResetFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnResetFilter.FlatAppearance.BorderSize = 0
        Me.BtnResetFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetFilter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnResetFilter.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnResetFilter.Location = New System.Drawing.Point(692, 193)
        Me.BtnResetFilter.Name = "BtnResetFilter"
        Me.BtnResetFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnResetFilter.TabIndex = 131
        Me.BtnResetFilter.Text = "Reset"
        Me.BtnResetFilter.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(18, 256)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(725, 219)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(527, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Keyword"
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
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "BOOK LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtFilter
        '
        Me.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFilter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilter.Location = New System.Drawing.Point(595, 132)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(148, 26)
        Me.TxtFilter.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(527, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Filter By"
        '
        'CbxFilter
        '
        Me.CbxFilter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxFilter.FormattingEnabled = True
        Me.CbxFilter.Items.AddRange(New Object() {"Title", "Author", "Publisher"})
        Me.CbxFilter.Location = New System.Drawing.Point(595, 101)
        Me.CbxFilter.Name = "CbxFilter"
        Me.CbxFilter.Size = New System.Drawing.Size(148, 25)
        Me.CbxFilter.TabIndex = 127
        Me.CbxFilter.Tag = "Genre Field"
        '
        'TxtPublisher
        '
        Me.TxtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPublisher.Enabled = False
        Me.TxtPublisher.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPublisher.Location = New System.Drawing.Point(206, 168)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.ReadOnly = True
        Me.TxtPublisher.Size = New System.Drawing.Size(148, 21)
        Me.TxtPublisher.TabIndex = 126
        Me.TxtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(135, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Date-RCV"
        '
        'TxtQty
        '
        Me.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQty.Enabled = False
        Me.TxtQty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtQty.Location = New System.Drawing.Point(395, 85)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.ReadOnly = True
        Me.TxtQty.Size = New System.Drawing.Size(56, 21)
        Me.TxtQty.TabIndex = 124
        Me.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDate
        '
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Enabled = False
        Me.TxtDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDate.Location = New System.Drawing.Point(206, 195)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(148, 21)
        Me.TxtDate.TabIndex = 123
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtId.Location = New System.Drawing.Point(395, 58)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(56, 21)
        Me.TxtId.TabIndex = 122
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIsbn
        '
        Me.TxtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIsbn.Enabled = False
        Me.TxtIsbn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIsbn.Location = New System.Drawing.Point(206, 141)
        Me.TxtIsbn.MaxLength = 10
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.ReadOnly = True
        Me.TxtIsbn.Size = New System.Drawing.Size(148, 21)
        Me.TxtIsbn.TabIndex = 121
        Me.TxtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGenre
        '
        Me.TxtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGenre.Enabled = False
        Me.TxtGenre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtGenre.Location = New System.Drawing.Point(206, 114)
        Me.TxtGenre.Name = "TxtGenre"
        Me.TxtGenre.ReadOnly = True
        Me.TxtGenre.Size = New System.Drawing.Size(148, 21)
        Me.TxtGenre.TabIndex = 120
        Me.TxtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAuthor
        '
        Me.TxtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAuthor.Enabled = False
        Me.TxtAuthor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAuthor.Location = New System.Drawing.Point(206, 87)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.ReadOnly = True
        Me.TxtAuthor.Size = New System.Drawing.Size(148, 21)
        Me.TxtAuthor.TabIndex = 119
        Me.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Enabled = False
        Me.TxtTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.Location = New System.Drawing.Point(206, 60)
        Me.TxtTitle.MaxLength = 150
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.Size = New System.Drawing.Size(148, 21)
        Me.TxtTitle.TabIndex = 118
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnFilter
        '
        Me.BtnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnFilter.FlatAppearance.BorderSize = 0
        Me.BtnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnFilter.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnFilter.Location = New System.Drawing.Point(635, 193)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnFilter.TabIndex = 114
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = False
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblQty.Location = New System.Drawing.Point(360, 83)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(29, 20)
        Me.LblQty.TabIndex = 74
        Me.LblQty.Text = "Qty"
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPublisher.Location = New System.Drawing.Point(135, 169)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(65, 20)
        Me.LblPublisher.TabIndex = 73
        Me.LblPublisher.Text = "Publisher"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblID.Location = New System.Drawing.Point(360, 58)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(21, 20)
        Me.LblID.TabIndex = 72
        Me.LblID.Text = "ID"
        '
        'LblIsbn
        '
        Me.LblIsbn.AutoSize = True
        Me.LblIsbn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblIsbn.Location = New System.Drawing.Point(135, 141)
        Me.LblIsbn.Name = "LblIsbn"
        Me.LblIsbn.Size = New System.Drawing.Size(39, 20)
        Me.LblIsbn.TabIndex = 71
        Me.LblIsbn.Text = "ISBN"
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblGenre.Location = New System.Drawing.Point(135, 115)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(46, 20)
        Me.LblGenre.TabIndex = 70
        Me.LblGenre.Text = "Genre"
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAuthor.Location = New System.Drawing.Point(135, 88)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(47, 20)
        Me.LblAuthor.TabIndex = 69
        Me.LblAuthor.Text = "Author"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.Location = New System.Drawing.Point(135, 61)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(33, 20)
        Me.LblTitle.TabIndex = 68
        Me.LblTitle.Text = "Title"
        '
        'BLPic
        '
        Me.BLPic.Location = New System.Drawing.Point(21, 63)
        Me.BLPic.Name = "BLPic"
        Me.BLPic.Size = New System.Drawing.Size(108, 153)
        Me.BLPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BLPic.TabIndex = 67
        Me.BLPic.TabStop = False
        '
        'PnlTool
        '
        Me.PnlTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlTool.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTool.Location = New System.Drawing.Point(0, 0)
        Me.PnlTool.Name = "PnlTool"
        Me.PnlTool.Size = New System.Drawing.Size(785, 45)
        Me.PnlTool.TabIndex = 140
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(308, 45)
        Me.TableLayoutPanel1.TabIndex = 138
        '
        'BookUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 565)
        Me.Controls.Add(Me.PnlBookList)
        Me.Controls.Add(Me.PnlTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookUser"
        Me.Text = "BookUser"
        Me.PnlBookList.ResumeLayout(False)
        Me.PnlBookList.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BLPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTool.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBookList As Panel
    Friend WithEvents ChkSpecific As CheckBox
    Friend WithEvents BtnResetFilter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFilter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxFilter As ComboBox
    Friend WithEvents TxtPublisher As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtIsbn As TextBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents BtnFilter As Button
    Friend WithEvents LblQty As Label
    Friend WithEvents LblPublisher As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblIsbn As Label
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents BLPic As PictureBox
    Friend WithEvents PnlTool As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

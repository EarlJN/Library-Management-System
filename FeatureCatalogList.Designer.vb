<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeatureCatalogList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeatureCatalogList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblIsbn = New System.Windows.Forms.Label()
        Me.LblGenre = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BLPic = New System.Windows.Forms.PictureBox()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.TxtGenre = New System.Windows.Forms.TextBox()
        Me.TxtIsbn = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnResetFilter = New System.Windows.Forms.Button()
        Me.ChkSpecific = New System.Windows.Forms.CheckBox()
        Me.PnlTool = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAddBook = New System.Windows.Forms.Button()
        Me.BtnEditBook = New System.Windows.Forms.Button()
        Me.PnlBookList = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BLPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTool.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PnlBookList.SuspendLayout()
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
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "BOOK LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(21, 258)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(722, 217)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblQty.Location = New System.Drawing.Point(404, 59)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(29, 20)
        Me.LblQty.TabIndex = 74
        Me.LblQty.Text = "Qty"
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPublisher.Location = New System.Drawing.Point(179, 194)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(65, 20)
        Me.LblPublisher.TabIndex = 73
        Me.LblPublisher.Text = "Publisher"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblID.Location = New System.Drawing.Point(179, 60)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(21, 20)
        Me.LblID.TabIndex = 72
        Me.LblID.Text = "ID"
        '
        'LblIsbn
        '
        Me.LblIsbn.AutoSize = True
        Me.LblIsbn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblIsbn.Location = New System.Drawing.Point(179, 166)
        Me.LblIsbn.Name = "LblIsbn"
        Me.LblIsbn.Size = New System.Drawing.Size(39, 20)
        Me.LblIsbn.TabIndex = 71
        Me.LblIsbn.Text = "ISBN"
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblGenre.Location = New System.Drawing.Point(179, 140)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(46, 20)
        Me.LblGenre.TabIndex = 70
        Me.LblGenre.Text = "Genre"
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAuthor.Location = New System.Drawing.Point(179, 113)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(47, 20)
        Me.LblAuthor.TabIndex = 69
        Me.LblAuthor.Text = "Author"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.Location = New System.Drawing.Point(179, 86)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(33, 20)
        Me.LblTitle.TabIndex = 68
        Me.LblTitle.Text = "Title"
        '
        'BLPic
        '
        Me.BLPic.Location = New System.Drawing.Point(21, 60)
        Me.BLPic.Name = "BLPic"
        Me.BLPic.Size = New System.Drawing.Size(152, 181)
        Me.BLPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BLPic.TabIndex = 67
        Me.BLPic.TabStop = False
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
        Me.BtnFilter.Location = New System.Drawing.Point(627, 143)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnFilter.TabIndex = 114
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = False
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.Location = New System.Drawing.Point(250, 85)
        Me.TxtTitle.MaxLength = 150
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.Size = New System.Drawing.Size(148, 21)
        Me.TxtTitle.TabIndex = 118
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAuthor
        '
        Me.TxtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAuthor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAuthor.Location = New System.Drawing.Point(250, 112)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.ReadOnly = True
        Me.TxtAuthor.Size = New System.Drawing.Size(148, 21)
        Me.TxtAuthor.TabIndex = 119
        Me.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGenre
        '
        Me.TxtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGenre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtGenre.Location = New System.Drawing.Point(250, 139)
        Me.TxtGenre.Name = "TxtGenre"
        Me.TxtGenre.ReadOnly = True
        Me.TxtGenre.Size = New System.Drawing.Size(148, 21)
        Me.TxtGenre.TabIndex = 120
        Me.TxtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIsbn
        '
        Me.TxtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIsbn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIsbn.Location = New System.Drawing.Point(250, 166)
        Me.TxtIsbn.MaxLength = 10
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.ReadOnly = True
        Me.TxtIsbn.Size = New System.Drawing.Size(148, 21)
        Me.TxtIsbn.TabIndex = 121
        Me.TxtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtId.Location = New System.Drawing.Point(250, 58)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(148, 21)
        Me.TxtId.TabIndex = 122
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDate
        '
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDate.Location = New System.Drawing.Point(250, 220)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(148, 21)
        Me.TxtDate.TabIndex = 123
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtQty
        '
        Me.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtQty.Location = New System.Drawing.Point(439, 58)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.ReadOnly = True
        Me.TxtQty.Size = New System.Drawing.Size(56, 21)
        Me.TxtQty.TabIndex = 124
        Me.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPublisher
        '
        Me.TxtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPublisher.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPublisher.Location = New System.Drawing.Point(250, 193)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.ReadOnly = True
        Me.TxtPublisher.Size = New System.Drawing.Size(148, 21)
        Me.TxtPublisher.TabIndex = 126
        Me.TxtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(179, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Date Published"
        '
        'CbxFilter
        '
        Me.CbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxFilter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxFilter.FormattingEnabled = True
        Me.CbxFilter.Items.AddRange(New Object() {"Title", "Author", "Publisher"})
        Me.CbxFilter.Location = New System.Drawing.Point(587, 51)
        Me.CbxFilter.Name = "CbxFilter"
        Me.CbxFilter.Size = New System.Drawing.Size(148, 25)
        Me.CbxFilter.TabIndex = 127
        Me.CbxFilter.Tag = "Genre Field"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(519, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Filter By"
        '
        'TxtFilter
        '
        Me.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFilter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilter.Location = New System.Drawing.Point(587, 82)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(148, 26)
        Me.TxtFilter.TabIndex = 129
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(519, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Keyword"
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
        Me.BtnResetFilter.Location = New System.Drawing.Point(684, 143)
        Me.BtnResetFilter.Name = "BtnResetFilter"
        Me.BtnResetFilter.Size = New System.Drawing.Size(51, 22)
        Me.BtnResetFilter.TabIndex = 131
        Me.BtnResetFilter.Text = "Reset"
        Me.BtnResetFilter.UseVisualStyleBackColor = False
        '
        'ChkSpecific
        '
        Me.ChkSpecific.AutoSize = True
        Me.ChkSpecific.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkSpecific.Location = New System.Drawing.Point(587, 114)
        Me.ChkSpecific.Name = "ChkSpecific"
        Me.ChkSpecific.Size = New System.Drawing.Size(82, 20)
        Me.ChkSpecific.TabIndex = 137
        Me.ChkSpecific.Text = "Specific Filter"
        Me.ChkSpecific.UseVisualStyleBackColor = True
        '
        'PnlTool
        '
        Me.PnlTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlTool.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTool.Location = New System.Drawing.Point(0, 0)
        Me.PnlTool.Name = "PnlTool"
        Me.PnlTool.Size = New System.Drawing.Size(785, 45)
        Me.PnlTool.TabIndex = 138
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33411!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33411!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33178!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAddBook, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEditBook, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(462, 45)
        Me.TableLayoutPanel1.TabIndex = 138
        '
        'BtnAddBook
        '
        Me.BtnAddBook.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddBook.FlatAppearance.BorderSize = 0
        Me.BtnAddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddBook.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddBook.ForeColor = System.Drawing.Color.Black
        Me.BtnAddBook.Location = New System.Drawing.Point(0, 0)
        Me.BtnAddBook.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(154, 45)
        Me.BtnAddBook.TabIndex = 3
        Me.BtnAddBook.Tag = "3"
        Me.BtnAddBook.Text = "Add Book"
        Me.BtnAddBook.UseVisualStyleBackColor = False
        '
        'BtnEditBook
        '
        Me.BtnEditBook.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEditBook.FlatAppearance.BorderSize = 0
        Me.BtnEditBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnEditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditBook.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditBook.ForeColor = System.Drawing.Color.Black
        Me.BtnEditBook.Location = New System.Drawing.Point(154, 0)
        Me.BtnEditBook.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnEditBook.Name = "BtnEditBook"
        Me.BtnEditBook.Size = New System.Drawing.Size(154, 45)
        Me.BtnEditBook.TabIndex = 4
        Me.BtnEditBook.Tag = "3"
        Me.BtnEditBook.Text = "Edit Book"
        Me.BtnEditBook.UseVisualStyleBackColor = False
        '
        'PnlBookList
        '
        Me.PnlBookList.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PnlBookList.Controls.Add(Me.btnPrint)
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
        Me.PnlBookList.TabIndex = 139
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPrint.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnPrint.Location = New System.Drawing.Point(672, 222)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(71, 24)
        Me.btnPrint.TabIndex = 177
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FeatureCatalogList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 565)
        Me.Controls.Add(Me.PnlBookList)
        Me.Controls.Add(Me.PnlTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeatureCatalogList"
        Me.Text = "FeatureCatalogList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BLPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTool.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PnlBookList.ResumeLayout(False)
        Me.PnlBookList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblQty As Label
    Friend WithEvents LblPublisher As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblIsbn As Label
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents BLPic As PictureBox
    Friend WithEvents BtnFilter As Button
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents TxtIsbn As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents TxtPublisher As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbxFilter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFilter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnResetFilter As Button
    Friend WithEvents ChkSpecific As CheckBox
    Friend WithEvents PnlTool As Panel
    Friend WithEvents PnlBookList As Panel
    Friend WithEvents BtnEditBook As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnAddBook As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeatureCatalog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddPic = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicAddBook = New System.Windows.Forms.PictureBox()
        Me.BtnAddMem = New System.Windows.Forms.Button()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIsbn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxGenre = New System.Windows.Forms.ComboBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDelId = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtDelQty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDelAuthor = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CbxDelGenre = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PicDelBook = New System.Windows.Forms.PictureBox()
        Me.BtnEditBook = New System.Windows.Forms.Button()
        Me.TxtDelPublisher = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtDelTitle = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtDelIsbn = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BtnDelBook = New System.Windows.Forms.Button()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.DtpRecieved = New System.Windows.Forms.DateTimePicker()
        Me.DtpDelRecieved = New System.Windows.Forms.DateTimePicker()
        Me.TxtDelPath = New System.Windows.Forms.TextBox()
        Me.PnlDelBook = New System.Windows.Forms.Panel()
        Me.PnlAddBook = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PicAddBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDelBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDelBook.SuspendLayout()
        Me.PnlAddBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54806!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.9039!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54804!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 41)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(396, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 41)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "EDIT / DELETE BOOK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 41)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ADD BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddPic
        '
        Me.BtnAddPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddPic.FlatAppearance.BorderSize = 0
        Me.BtnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddPic.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddPic.Location = New System.Drawing.Point(103, 262)
        Me.BtnAddPic.Name = "BtnAddPic"
        Me.BtnAddPic.Size = New System.Drawing.Size(106, 22)
        Me.BtnAddPic.TabIndex = 78
        Me.BtnAddPic.Text = "Select Picture"
        Me.BtnAddPic.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(16, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Book Cover"
        '
        'PicAddBook
        '
        Me.PicAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicAddBook.Location = New System.Drawing.Point(26, 290)
        Me.PicAddBook.Name = "PicAddBook"
        Me.PicAddBook.Size = New System.Drawing.Size(117, 97)
        Me.PicAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAddBook.TabIndex = 55
        Me.PicAddBook.TabStop = False
        '
        'BtnAddMem
        '
        Me.BtnAddMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddMem.FlatAppearance.BorderSize = 0
        Me.BtnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddMem.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddMem.Location = New System.Drawing.Point(9, 398)
        Me.BtnAddMem.Name = "BtnAddMem"
        Me.BtnAddMem.Size = New System.Drawing.Size(350, 39)
        Me.BtnAddMem.TabIndex = 54
        Me.BtnAddMem.Text = "Add Book"
        Me.BtnAddMem.UseVisualStyleBackColor = False
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPublisher.Location = New System.Drawing.Point(82, 134)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(177, 26)
        Me.TxtPublisher.TabIndex = 53
        Me.TxtPublisher.Tag = "Publisher Field"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(9, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Publisher"
        '
        'TxtIsbn
        '
        Me.TxtIsbn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIsbn.Location = New System.Drawing.Point(82, 39)
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.Size = New System.Drawing.Size(177, 26)
        Me.TxtIsbn.TabIndex = 47
        Me.TxtIsbn.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(9, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "ISBN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(9, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Genre"
        '
        'CbxGenre
        '
        Me.CbxGenre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxGenre.FormattingEnabled = True
        Me.CbxGenre.Items.AddRange(New Object() {"Fiction", "Non-Fiction", "Drama", "Poetry", "Folktale"})
        Me.CbxGenre.Location = New System.Drawing.Point(82, 71)
        Me.CbxGenre.Name = "CbxGenre"
        Me.CbxGenre.Size = New System.Drawing.Size(177, 25)
        Me.CbxGenre.TabIndex = 81
        Me.CbxGenre.Tag = "Genre Field"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.Location = New System.Drawing.Point(82, 7)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(177, 26)
        Me.TxtTitle.TabIndex = 49
        Me.TxtTitle.Tag = """Title Field"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(9, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Title"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAuthor.Location = New System.Drawing.Point(82, 102)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(177, 26)
        Me.TxtAuthor.TabIndex = 84
        Me.TxtAuthor.Tag = "Author Field"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(9, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(11, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Date Recieved"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtQuantity.Location = New System.Drawing.Point(82, 166)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(177, 26)
        Me.TxtQuantity.TabIndex = 90
        Me.TxtQuantity.Tag = "Quantity Field"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(9, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Quantity"
        '
        'TxtDelId
        '
        Me.TxtDelId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelId.Location = New System.Drawing.Point(81, 9)
        Me.TxtDelId.Name = "TxtDelId"
        Me.TxtDelId.Size = New System.Drawing.Size(93, 26)
        Me.TxtDelId.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(10, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 20)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "ID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button1.Location = New System.Drawing.Point(180, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 27)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Search By ID"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtDelQty
        '
        Me.TxtDelQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelQty.Location = New System.Drawing.Point(81, 173)
        Me.TxtDelQty.Name = "TxtDelQty"
        Me.TxtDelQty.Size = New System.Drawing.Size(112, 26)
        Me.TxtDelQty.TabIndex = 115
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(10, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(10, 207)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 20)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Date Recieved"
        '
        'TxtDelAuthor
        '
        Me.TxtDelAuthor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelAuthor.Location = New System.Drawing.Point(81, 110)
        Me.TxtDelAuthor.Name = "TxtDelAuthor"
        Me.TxtDelAuthor.Size = New System.Drawing.Size(276, 26)
        Me.TxtDelAuthor.TabIndex = 109
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(10, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 20)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "Author"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(199, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 20)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "Genre"
        '
        'CbxDelGenre
        '
        Me.CbxDelGenre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxDelGenre.FormattingEnabled = True
        Me.CbxDelGenre.Items.AddRange(New Object() {"Fiction", "Non-Fiction", "Drama", "Poetry", "Folktale"})
        Me.CbxDelGenre.Location = New System.Drawing.Point(248, 77)
        Me.CbxDelGenre.Name = "CbxDelGenre"
        Me.CbxDelGenre.Size = New System.Drawing.Size(109, 25)
        Me.CbxDelGenre.TabIndex = 106
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button2.Location = New System.Drawing.Point(97, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 22)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Select Picture"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(10, 267)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 20)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Book Cover"
        '
        'PicDelBook
        '
        Me.PicDelBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicDelBook.Location = New System.Drawing.Point(19, 295)
        Me.PicDelBook.Name = "PicDelBook"
        Me.PicDelBook.Size = New System.Drawing.Size(117, 97)
        Me.PicDelBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDelBook.TabIndex = 103
        Me.PicDelBook.TabStop = False
        '
        'BtnEditBook
        '
        Me.BtnEditBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnEditBook.Enabled = False
        Me.BtnEditBook.FlatAppearance.BorderSize = 0
        Me.BtnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditBook.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditBook.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnEditBook.Location = New System.Drawing.Point(10, 401)
        Me.BtnEditBook.Name = "BtnEditBook"
        Me.BtnEditBook.Size = New System.Drawing.Size(167, 39)
        Me.BtnEditBook.TabIndex = 102
        Me.BtnEditBook.Text = "Edit Book"
        Me.BtnEditBook.UseVisualStyleBackColor = False
        '
        'TxtDelPublisher
        '
        Me.TxtDelPublisher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelPublisher.Location = New System.Drawing.Point(81, 142)
        Me.TxtDelPublisher.Name = "TxtDelPublisher"
        Me.TxtDelPublisher.Size = New System.Drawing.Size(276, 26)
        Me.TxtDelPublisher.TabIndex = 101
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(10, 144)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 20)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "Publisher"
        '
        'TxtDelTitle
        '
        Me.TxtDelTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelTitle.Location = New System.Drawing.Point(81, 45)
        Me.TxtDelTitle.Name = "TxtDelTitle"
        Me.TxtDelTitle.Size = New System.Drawing.Size(276, 26)
        Me.TxtDelTitle.TabIndex = 99
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(10, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 20)
        Me.Label21.TabIndex = 98
        Me.Label21.Text = "Title"
        '
        'TxtDelIsbn
        '
        Me.TxtDelIsbn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelIsbn.Location = New System.Drawing.Point(81, 77)
        Me.TxtDelIsbn.Name = "TxtDelIsbn"
        Me.TxtDelIsbn.Size = New System.Drawing.Size(112, 26)
        Me.TxtDelIsbn.TabIndex = 97
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(10, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 20)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "ISBN"
        '
        'BtnDelBook
        '
        Me.BtnDelBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnDelBook.Enabled = False
        Me.BtnDelBook.FlatAppearance.BorderSize = 0
        Me.BtnDelBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelBook.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelBook.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnDelBook.Location = New System.Drawing.Point(199, 401)
        Me.BtnDelBook.Name = "BtnDelBook"
        Me.BtnDelBook.Size = New System.Drawing.Size(158, 39)
        Me.BtnDelBook.TabIndex = 116
        Me.BtnDelBook.Text = "Delete Book"
        Me.BtnDelBook.UseVisualStyleBackColor = False
        '
        'TxtPath
        '
        Me.TxtPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPath.Location = New System.Drawing.Point(215, 259)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(10, 26)
        Me.TxtPath.TabIndex = 117
        Me.TxtPath.Visible = False
        '
        'DtpRecieved
        '
        Me.DtpRecieved.CustomFormat = "yyyy-MM-dd"
        Me.DtpRecieved.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpRecieved.Location = New System.Drawing.Point(115, 199)
        Me.DtpRecieved.Name = "DtpRecieved"
        Me.DtpRecieved.Size = New System.Drawing.Size(144, 23)
        Me.DtpRecieved.TabIndex = 118
        '
        'DtpDelRecieved
        '
        Me.DtpDelRecieved.CustomFormat = "yyyy-MM-dd"
        Me.DtpDelRecieved.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDelRecieved.Location = New System.Drawing.Point(114, 205)
        Me.DtpDelRecieved.Name = "DtpDelRecieved"
        Me.DtpDelRecieved.Size = New System.Drawing.Size(131, 23)
        Me.DtpDelRecieved.TabIndex = 119
        '
        'TxtDelPath
        '
        Me.TxtDelPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDelPath.Location = New System.Drawing.Point(209, 265)
        Me.TxtDelPath.Name = "TxtDelPath"
        Me.TxtDelPath.Size = New System.Drawing.Size(10, 26)
        Me.TxtDelPath.TabIndex = 120
        Me.TxtDelPath.Visible = False
        '
        'PnlDelBook
        '
        Me.PnlDelBook.Controls.Add(Me.BtnCancel)
        Me.PnlDelBook.Controls.Add(Me.TxtDelPath)
        Me.PnlDelBook.Controls.Add(Me.DtpDelRecieved)
        Me.PnlDelBook.Controls.Add(Me.BtnDelBook)
        Me.PnlDelBook.Controls.Add(Me.TxtDelQty)
        Me.PnlDelBook.Controls.Add(Me.Label15)
        Me.PnlDelBook.Controls.Add(Me.Label16)
        Me.PnlDelBook.Controls.Add(Me.TxtDelAuthor)
        Me.PnlDelBook.Controls.Add(Me.Label17)
        Me.PnlDelBook.Controls.Add(Me.Label18)
        Me.PnlDelBook.Controls.Add(Me.CbxDelGenre)
        Me.PnlDelBook.Controls.Add(Me.Button2)
        Me.PnlDelBook.Controls.Add(Me.Label19)
        Me.PnlDelBook.Controls.Add(Me.PicDelBook)
        Me.PnlDelBook.Controls.Add(Me.BtnEditBook)
        Me.PnlDelBook.Controls.Add(Me.TxtDelPublisher)
        Me.PnlDelBook.Controls.Add(Me.Label20)
        Me.PnlDelBook.Controls.Add(Me.TxtDelTitle)
        Me.PnlDelBook.Controls.Add(Me.Label21)
        Me.PnlDelBook.Controls.Add(Me.TxtDelIsbn)
        Me.PnlDelBook.Controls.Add(Me.Label22)
        Me.PnlDelBook.Controls.Add(Me.Button1)
        Me.PnlDelBook.Controls.Add(Me.TxtDelId)
        Me.PnlDelBook.Controls.Add(Me.Label13)
        Me.PnlDelBook.Location = New System.Drawing.Point(386, 44)
        Me.PnlDelBook.Name = "PnlDelBook"
        Me.PnlDelBook.Size = New System.Drawing.Size(370, 446)
        Me.PnlDelBook.TabIndex = 121
        '
        'PnlAddBook
        '
        Me.PnlAddBook.Controls.Add(Me.DtpRecieved)
        Me.PnlAddBook.Controls.Add(Me.TxtPath)
        Me.PnlAddBook.Controls.Add(Me.TxtQuantity)
        Me.PnlAddBook.Controls.Add(Me.Label11)
        Me.PnlAddBook.Controls.Add(Me.Label6)
        Me.PnlAddBook.Controls.Add(Me.TxtAuthor)
        Me.PnlAddBook.Controls.Add(Me.Label3)
        Me.PnlAddBook.Controls.Add(Me.Label8)
        Me.PnlAddBook.Controls.Add(Me.CbxGenre)
        Me.PnlAddBook.Controls.Add(Me.BtnAddPic)
        Me.PnlAddBook.Controls.Add(Me.Label9)
        Me.PnlAddBook.Controls.Add(Me.PicAddBook)
        Me.PnlAddBook.Controls.Add(Me.BtnAddMem)
        Me.PnlAddBook.Controls.Add(Me.TxtPublisher)
        Me.PnlAddBook.Controls.Add(Me.Label7)
        Me.PnlAddBook.Controls.Add(Me.TxtTitle)
        Me.PnlAddBook.Controls.Add(Me.Label5)
        Me.PnlAddBook.Controls.Add(Me.TxtIsbn)
        Me.PnlAddBook.Controls.Add(Me.Label4)
        Me.PnlAddBook.Location = New System.Drawing.Point(3, 46)
        Me.PnlAddBook.Name = "PnlAddBook"
        Me.PnlAddBook.Size = New System.Drawing.Size(380, 438)
        Me.PnlAddBook.TabIndex = 122
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancel.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnCancel.Location = New System.Drawing.Point(280, 9)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(55, 27)
        Me.BtnCancel.TabIndex = 121
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FeatureCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 490)
        Me.Controls.Add(Me.PnlAddBook)
        Me.Controls.Add(Me.PnlDelBook)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeatureCatalog"
        Me.Text = "FeatureCatalog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PicAddBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDelBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDelBook.ResumeLayout(False)
        Me.PnlDelBook.PerformLayout()
        Me.PnlAddBook.ResumeLayout(False)
        Me.PnlAddBook.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddPic As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PicAddBook As PictureBox
    Friend WithEvents BtnAddMem As Button
    Friend WithEvents TxtPublisher As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIsbn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbxGenre As ComboBox
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtDelId As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtDelQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtDelAuthor As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CbxDelGenre As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents PicDelBook As PictureBox
    Friend WithEvents BtnEditBook As Button
    Friend WithEvents TxtDelPublisher As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtDelTitle As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtDelIsbn As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents BtnDelBook As Button
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents DtpRecieved As DateTimePicker
    Friend WithEvents DtpDelRecieved As DateTimePicker
    Friend WithEvents TxtDelPath As TextBox
    Friend WithEvents PnlDelBook As Panel
    Friend WithEvents PnlAddBook As Panel
    Friend WithEvents BtnCancel As Button
End Class

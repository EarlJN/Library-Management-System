<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeatureAddBook
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
        Me.PnlAddBook = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpRecieved = New System.Windows.Forms.DateTimePicker()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxGenre = New System.Windows.Forms.ComboBox()
        Me.BtnAddPic = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicAddBook = New System.Windows.Forms.PictureBox()
        Me.BtnAddMem = New System.Windows.Forms.Button()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIsbn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlAddBook.SuspendLayout()
        CType(Me.PicAddBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlAddBook
        '
        Me.PnlAddBook.Controls.Add(Me.Label1)
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
        Me.PnlAddBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAddBook.Location = New System.Drawing.Point(0, 0)
        Me.PnlAddBook.Name = "PnlAddBook"
        Me.PnlAddBook.Size = New System.Drawing.Size(284, 561)
        Me.PnlAddBook.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 41)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "ADD BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtpRecieved
        '
        Me.DtpRecieved.CustomFormat = "yyyy-MM-dd"
        Me.DtpRecieved.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpRecieved.Location = New System.Drawing.Point(12, 394)
        Me.DtpRecieved.Name = "DtpRecieved"
        Me.DtpRecieved.Size = New System.Drawing.Size(144, 23)
        Me.DtpRecieved.TabIndex = 118
        '
        'TxtPath
        '
        Me.TxtPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPath.Location = New System.Drawing.Point(123, 478)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(10, 26)
        Me.TxtPath.TabIndex = 117
        Me.TxtPath.Visible = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtQuantity.Location = New System.Drawing.Point(12, 342)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(260, 26)
        Me.TxtQuantity.TabIndex = 90
        Me.TxtQuantity.Tag = "Quantity Field"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(11, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(11, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Date Recieved"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAuthor.Location = New System.Drawing.Point(12, 238)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(260, 26)
        Me.TxtAuthor.TabIndex = 84
        Me.TxtAuthor.Tag = "Author Field"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(11, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Author"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 164)
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
        Me.CbxGenre.Location = New System.Drawing.Point(12, 187)
        Me.CbxGenre.Name = "CbxGenre"
        Me.CbxGenre.Size = New System.Drawing.Size(260, 25)
        Me.CbxGenre.TabIndex = 81
        Me.CbxGenre.Tag = "Genre Field"
        '
        'BtnAddPic
        '
        Me.BtnAddPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddPic.FlatAppearance.BorderSize = 0
        Me.BtnAddPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAddPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddPic.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddPic.Location = New System.Drawing.Point(11, 482)
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
        Me.Label9.Location = New System.Drawing.Point(11, 424)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Book Cover"
        '
        'PicAddBook
        '
        Me.PicAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicAddBook.Location = New System.Drawing.Point(192, 424)
        Me.PicAddBook.Name = "PicAddBook"
        Me.PicAddBook.Size = New System.Drawing.Size(80, 80)
        Me.PicAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAddBook.TabIndex = 55
        Me.PicAddBook.TabStop = False
        '
        'BtnAddMem
        '
        Me.BtnAddMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BtnAddMem.FlatAppearance.BorderSize = 0
        Me.BtnAddMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnAddMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddMem.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnAddMem.Location = New System.Drawing.Point(12, 510)
        Me.BtnAddMem.Name = "BtnAddMem"
        Me.BtnAddMem.Size = New System.Drawing.Size(260, 39)
        Me.BtnAddMem.TabIndex = 54
        Me.BtnAddMem.Text = "Add Book"
        Me.BtnAddMem.UseVisualStyleBackColor = False
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPublisher.Location = New System.Drawing.Point(12, 290)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(260, 26)
        Me.TxtPublisher.TabIndex = 53
        Me.TxtPublisher.Tag = "Publisher Field"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Publisher"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.Location = New System.Drawing.Point(12, 83)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(260, 26)
        Me.TxtTitle.TabIndex = 49
        Me.TxtTitle.Tag = """Title Field"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Title"
        '
        'TxtIsbn
        '
        Me.TxtIsbn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIsbn.Location = New System.Drawing.Point(12, 135)
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.Size = New System.Drawing.Size(260, 26)
        Me.TxtIsbn.TabIndex = 47
        Me.TxtIsbn.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "ISBN"
        '
        'FeatureAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.PnlAddBook)
        Me.Name = "FeatureAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LMS - Add Book"
        Me.PnlAddBook.ResumeLayout(False)
        Me.PnlAddBook.PerformLayout()
        CType(Me.PicAddBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlAddBook As Panel
    Friend WithEvents DtpRecieved As DateTimePicker
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbxGenre As ComboBox
    Friend WithEvents BtnAddPic As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PicAddBook As PictureBox
    Friend WithEvents BtnAddMem As Button
    Friend WithEvents TxtPublisher As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIsbn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelFeature = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBookList = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnUserList = New System.Windows.Forms.Button()
        Me.BtnCirculation = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelFeature.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFeature
        '
        Me.PanelFeature.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelFeature.Controls.Add(Me.Button4)
        Me.PanelFeature.Controls.Add(Me.Panel1)
        Me.PanelFeature.Controls.Add(Me.Button1)
        Me.PanelFeature.Controls.Add(Me.Welcome)
        Me.PanelFeature.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelFeature.Location = New System.Drawing.Point(-8, -1)
        Me.PanelFeature.Name = "PanelFeature"
        Me.PanelFeature.Size = New System.Drawing.Size(211, 564)
        Me.PanelFeature.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(2, 492)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(206, 57)
        Me.Button4.TabIndex = 4
        Me.Button4.Tag = "0"
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(209, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 563)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(77, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Welcome.Location = New System.Drawing.Point(20, 100)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(132, 15)
        Me.Welcome.TabIndex = 1
        Me.Welcome.Text = "Welcome Back, Admin!"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnBookList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDashboard, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnUserList, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCirculation, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReports, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 130)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(206, 344)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'BtnBookList
        '
        Me.BtnBookList.BackColor = System.Drawing.Color.Transparent
        Me.BtnBookList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBookList.FlatAppearance.BorderSize = 0
        Me.BtnBookList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnBookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBookList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBookList.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnBookList.Image = CType(resources.GetObject("BtnBookList.Image"), System.Drawing.Image)
        Me.BtnBookList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBookList.Location = New System.Drawing.Point(0, 57)
        Me.BtnBookList.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnBookList.Name = "BtnBookList"
        Me.BtnBookList.Size = New System.Drawing.Size(206, 57)
        Me.BtnBookList.TabIndex = 0
        Me.BtnBookList.Tag = "0"
        Me.BtnBookList.Text = "Books"
        Me.BtnBookList.UseVisualStyleBackColor = False
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDashboard.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(206, 57)
        Me.BtnDashboard.TabIndex = 2
        Me.BtnDashboard.Tag = "3"
        Me.BtnDashboard.Text = "Home"
        Me.BtnDashboard.UseVisualStyleBackColor = False
        '
        'BtnUserList
        '
        Me.BtnUserList.AutoSize = True
        Me.BtnUserList.BackColor = System.Drawing.Color.Transparent
        Me.BtnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUserList.FlatAppearance.BorderSize = 0
        Me.BtnUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUserList.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnUserList.Image = CType(resources.GetObject("BtnUserList.Image"), System.Drawing.Image)
        Me.BtnUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUserList.Location = New System.Drawing.Point(0, 114)
        Me.BtnUserList.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnUserList.Name = "BtnUserList"
        Me.BtnUserList.Size = New System.Drawing.Size(206, 57)
        Me.BtnUserList.TabIndex = 3
        Me.BtnUserList.Tag = "1"
        Me.BtnUserList.Text = "Users"
        Me.BtnUserList.UseVisualStyleBackColor = False
        '
        'BtnCirculation
        '
        Me.BtnCirculation.BackColor = System.Drawing.Color.Transparent
        Me.BtnCirculation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCirculation.FlatAppearance.BorderSize = 0
        Me.BtnCirculation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnCirculation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCirculation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCirculation.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnCirculation.Image = CType(resources.GetObject("BtnCirculation.Image"), System.Drawing.Image)
        Me.BtnCirculation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCirculation.Location = New System.Drawing.Point(0, 171)
        Me.BtnCirculation.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCirculation.Name = "BtnCirculation"
        Me.BtnCirculation.Size = New System.Drawing.Size(206, 57)
        Me.BtnCirculation.TabIndex = 6
        Me.BtnCirculation.Tag = "1"
        Me.BtnCirculation.Text = "Circulation"
        Me.BtnCirculation.UseVisualStyleBackColor = False
        '
        'BtnReports
        '
        Me.BtnReports.BackColor = System.Drawing.Color.Transparent
        Me.BtnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReports.FlatAppearance.BorderSize = 0
        Me.BtnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnReports.ForeColor = System.Drawing.Color.FloralWhite
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReports.Location = New System.Drawing.Point(0, 228)
        Me.BtnReports.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(206, 57)
        Me.BtnReports.TabIndex = 7
        Me.BtnReports.Tag = "1"
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PanelMain.Location = New System.Drawing.Point(201, -1)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(785, 565)
        Me.PanelMain.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 57)
        Me.Button2.TabIndex = 0
        Me.Button2.Tag = "0"
        Me.Button2.Text = "Books"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.Tag = "3"
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelFeature)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Library Management System"
        Me.PanelFeature.ResumeLayout(False)
        Me.PanelFeature.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFeature As Panel
    Friend WithEvents BtnBookList As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnUserList As Button
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents BtnCirculation As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Welcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnReports As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

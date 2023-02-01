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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBookList = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnUserList = New System.Windows.Forms.Button()
        Me.BtnCirculation = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelFeature.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFeature
        '
        Me.PanelFeature.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelFeature.Controls.Add(Me.Panel1)
        Me.PanelFeature.Controls.Add(Me.Button1)
        Me.PanelFeature.Controls.Add(Me.Welcome)
        Me.PanelFeature.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelFeature.Location = New System.Drawing.Point(-8, -1)
        Me.PanelFeature.Name = "PanelFeature"
        Me.PanelFeature.Size = New System.Drawing.Size(211, 564)
        Me.PanelFeature.TabIndex = 0
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
        Me.Button1.Location = New System.Drawing.Point(20, 28)
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
        Me.Welcome.Location = New System.Drawing.Point(20, 10)
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
End Class

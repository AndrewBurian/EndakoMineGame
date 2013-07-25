<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Enemy5NameLbl = New System.Windows.Forms.Label()
        Me.Enemy4NameLbl = New System.Windows.Forms.Label()
        Me.Enemy3NameLbl = New System.Windows.Forms.Label()
        Me.Enemy2NameLbl = New System.Windows.Forms.Label()
        Me.Enemy1NameLbl = New System.Windows.Forms.Label()
        Me.Enemy5HPLbl = New System.Windows.Forms.Label()
        Me.Enemy4HPLbl = New System.Windows.Forms.Label()
        Me.Enemy3HPLbl = New System.Windows.Forms.Label()
        Me.Enemy2HPLbl = New System.Windows.Forms.Label()
        Me.Enemy1HPLbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Enemy5PicBox = New System.Windows.Forms.PictureBox()
        Me.Enemy4PicBox = New System.Windows.Forms.PictureBox()
        Me.Enemy3PicBox = New System.Windows.Forms.PictureBox()
        Me.Enemy2PicBox = New System.Windows.Forms.PictureBox()
        Me.Enemy1PicBox = New System.Windows.Forms.PictureBox()
        Me.CombatTxtBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TravelTxtBox = New System.Windows.Forms.RichTextBox()
        Me.TravelBar = New System.Windows.Forms.ProgressBar()
        Me.DestLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Party1HPBar = New System.Windows.Forms.ProgressBar()
        Me.Party1LevelLbl = New System.Windows.Forms.Label()
        Me.Party1NameLbl = New System.Windows.Forms.Label()
        Me.Party5PicBox = New System.Windows.Forms.PictureBox()
        Me.Party4PicBox = New System.Windows.Forms.PictureBox()
        Me.Party3PicBox = New System.Windows.Forms.PictureBox()
        Me.Party2PicBox = New System.Windows.Forms.PictureBox()
        Me.Party1PicBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.IntelligenceLbl = New System.Windows.Forms.Label()
        Me.SpeedLbl = New System.Windows.Forms.Label()
        Me.StrengthLbl = New System.Windows.Forms.Label()
        Me.DexterityLbl = New System.Windows.Forms.Label()
        Me.EnduranceLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XPbar = New System.Windows.Forms.ProgressBar()
        Me.HPbar = New System.Windows.Forms.ProgressBar()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Party2HPBar = New System.Windows.Forms.ProgressBar()
        Me.Party2LevelLbl = New System.Windows.Forms.Label()
        Me.Party2NameLbl = New System.Windows.Forms.Label()
        Me.Party3HPBar = New System.Windows.Forms.ProgressBar()
        Me.Party3LevelLbl = New System.Windows.Forms.Label()
        Me.Party3NameLbl = New System.Windows.Forms.Label()
        Me.Party4HPBar = New System.Windows.Forms.ProgressBar()
        Me.Party4LevelLbl = New System.Windows.Forms.Label()
        Me.Party4NameLbl = New System.Windows.Forms.Label()
        Me.Party5HPBar = New System.Windows.Forms.ProgressBar()
        Me.Party5LevelLbl = New System.Windows.Forms.Label()
        Me.Party5NameLbl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PowerBar = New System.Windows.Forms.ProgressBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Enemy5PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy4PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Party5PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Party4PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Party3PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Party2PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Party1PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(577, 574)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Enemy5NameLbl)
        Me.TabPage1.Controls.Add(Me.Enemy4NameLbl)
        Me.TabPage1.Controls.Add(Me.Enemy3NameLbl)
        Me.TabPage1.Controls.Add(Me.Enemy2NameLbl)
        Me.TabPage1.Controls.Add(Me.Enemy1NameLbl)
        Me.TabPage1.Controls.Add(Me.Enemy5HPLbl)
        Me.TabPage1.Controls.Add(Me.Enemy4HPLbl)
        Me.TabPage1.Controls.Add(Me.Enemy3HPLbl)
        Me.TabPage1.Controls.Add(Me.Enemy2HPLbl)
        Me.TabPage1.Controls.Add(Me.Enemy1HPLbl)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Enemy5PicBox)
        Me.TabPage1.Controls.Add(Me.Enemy4PicBox)
        Me.TabPage1.Controls.Add(Me.Enemy3PicBox)
        Me.TabPage1.Controls.Add(Me.Enemy2PicBox)
        Me.TabPage1.Controls.Add(Me.Enemy1PicBox)
        Me.TabPage1.Controls.Add(Me.CombatTxtBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(569, 548)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Combat"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Enemy5NameLbl
        '
        Me.Enemy5NameLbl.AutoSize = True
        Me.Enemy5NameLbl.Location = New System.Drawing.Point(460, 34)
        Me.Enemy5NameLbl.Name = "Enemy5NameLbl"
        Me.Enemy5NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy5NameLbl.TabIndex = 24
        '
        'Enemy4NameLbl
        '
        Me.Enemy4NameLbl.AutoSize = True
        Me.Enemy4NameLbl.Location = New System.Drawing.Point(347, 34)
        Me.Enemy4NameLbl.Name = "Enemy4NameLbl"
        Me.Enemy4NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy4NameLbl.TabIndex = 23
        '
        'Enemy3NameLbl
        '
        Me.Enemy3NameLbl.AutoSize = True
        Me.Enemy3NameLbl.Location = New System.Drawing.Point(239, 34)
        Me.Enemy3NameLbl.Name = "Enemy3NameLbl"
        Me.Enemy3NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy3NameLbl.TabIndex = 22
        '
        'Enemy2NameLbl
        '
        Me.Enemy2NameLbl.AutoSize = True
        Me.Enemy2NameLbl.Location = New System.Drawing.Point(130, 34)
        Me.Enemy2NameLbl.Name = "Enemy2NameLbl"
        Me.Enemy2NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy2NameLbl.TabIndex = 21
        '
        'Enemy1NameLbl
        '
        Me.Enemy1NameLbl.AutoSize = True
        Me.Enemy1NameLbl.Location = New System.Drawing.Point(24, 34)
        Me.Enemy1NameLbl.Name = "Enemy1NameLbl"
        Me.Enemy1NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy1NameLbl.TabIndex = 20
        '
        'Enemy5HPLbl
        '
        Me.Enemy5HPLbl.AutoSize = True
        Me.Enemy5HPLbl.Location = New System.Drawing.Point(505, 153)
        Me.Enemy5HPLbl.Name = "Enemy5HPLbl"
        Me.Enemy5HPLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy5HPLbl.TabIndex = 19
        '
        'Enemy4HPLbl
        '
        Me.Enemy4HPLbl.AutoSize = True
        Me.Enemy4HPLbl.Location = New System.Drawing.Point(392, 153)
        Me.Enemy4HPLbl.Name = "Enemy4HPLbl"
        Me.Enemy4HPLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy4HPLbl.TabIndex = 18
        '
        'Enemy3HPLbl
        '
        Me.Enemy3HPLbl.AutoSize = True
        Me.Enemy3HPLbl.Location = New System.Drawing.Point(284, 153)
        Me.Enemy3HPLbl.Name = "Enemy3HPLbl"
        Me.Enemy3HPLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy3HPLbl.TabIndex = 17
        '
        'Enemy2HPLbl
        '
        Me.Enemy2HPLbl.AutoSize = True
        Me.Enemy2HPLbl.Location = New System.Drawing.Point(175, 153)
        Me.Enemy2HPLbl.Name = "Enemy2HPLbl"
        Me.Enemy2HPLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy2HPLbl.TabIndex = 16
        '
        'Enemy1HPLbl
        '
        Me.Enemy1HPLbl.AutoSize = True
        Me.Enemy1HPLbl.Location = New System.Drawing.Point(69, 153)
        Me.Enemy1HPLbl.Name = "Enemy1HPLbl"
        Me.Enemy1HPLbl.Size = New System.Drawing.Size(0, 13)
        Me.Enemy1HPLbl.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(457, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Health:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(344, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Health:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(236, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Health:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(127, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Health:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Health:"
        '
        'Enemy5PicBox
        '
        Me.Enemy5PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Enemy5PicBox.Location = New System.Drawing.Point(460, 53)
        Me.Enemy5PicBox.Name = "Enemy5PicBox"
        Me.Enemy5PicBox.Size = New System.Drawing.Size(80, 93)
        Me.Enemy5PicBox.TabIndex = 9
        Me.Enemy5PicBox.TabStop = False
        '
        'Enemy4PicBox
        '
        Me.Enemy4PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Enemy4PicBox.Location = New System.Drawing.Point(347, 53)
        Me.Enemy4PicBox.Name = "Enemy4PicBox"
        Me.Enemy4PicBox.Size = New System.Drawing.Size(80, 93)
        Me.Enemy4PicBox.TabIndex = 8
        Me.Enemy4PicBox.TabStop = False
        '
        'Enemy3PicBox
        '
        Me.Enemy3PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Enemy3PicBox.Location = New System.Drawing.Point(239, 53)
        Me.Enemy3PicBox.Name = "Enemy3PicBox"
        Me.Enemy3PicBox.Size = New System.Drawing.Size(80, 93)
        Me.Enemy3PicBox.TabIndex = 7
        Me.Enemy3PicBox.TabStop = False
        '
        'Enemy2PicBox
        '
        Me.Enemy2PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Enemy2PicBox.Location = New System.Drawing.Point(130, 53)
        Me.Enemy2PicBox.Name = "Enemy2PicBox"
        Me.Enemy2PicBox.Size = New System.Drawing.Size(80, 93)
        Me.Enemy2PicBox.TabIndex = 6
        Me.Enemy2PicBox.TabStop = False
        '
        'Enemy1PicBox
        '
        Me.Enemy1PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Enemy1PicBox.Location = New System.Drawing.Point(21, 53)
        Me.Enemy1PicBox.Name = "Enemy1PicBox"
        Me.Enemy1PicBox.Size = New System.Drawing.Size(80, 93)
        Me.Enemy1PicBox.TabIndex = 5
        Me.Enemy1PicBox.TabStop = False
        '
        'CombatTxtBox
        '
        Me.CombatTxtBox.Location = New System.Drawing.Point(23, 418)
        Me.CombatTxtBox.Name = "CombatTxtBox"
        Me.CombatTxtBox.ReadOnly = True
        Me.CombatTxtBox.Size = New System.Drawing.Size(519, 124)
        Me.CombatTxtBox.TabIndex = 4
        Me.CombatTxtBox.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TravelTxtBox)
        Me.TabPage2.Controls.Add(Me.TravelBar)
        Me.TabPage2.Controls.Add(Me.DestLbl)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(569, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Travel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TravelTxtBox
        '
        Me.TravelTxtBox.Location = New System.Drawing.Point(23, 418)
        Me.TravelTxtBox.Name = "TravelTxtBox"
        Me.TravelTxtBox.ReadOnly = True
        Me.TravelTxtBox.Size = New System.Drawing.Size(519, 124)
        Me.TravelTxtBox.TabIndex = 3
        Me.TravelTxtBox.Text = ""
        '
        'TravelBar
        '
        Me.TravelBar.Location = New System.Drawing.Point(23, 55)
        Me.TravelBar.Name = "TravelBar"
        Me.TravelBar.Size = New System.Drawing.Size(519, 23)
        Me.TravelBar.TabIndex = 2
        '
        'DestLbl
        '
        Me.DestLbl.AutoSize = True
        Me.DestLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestLbl.Location = New System.Drawing.Point(138, 17)
        Me.DestLbl.Name = "DestLbl"
        Me.DestLbl.Size = New System.Drawing.Size(0, 25)
        Me.DestLbl.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Traveling to"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Party5HPBar)
        Me.TabPage3.Controls.Add(Me.Party5LevelLbl)
        Me.TabPage3.Controls.Add(Me.Party5NameLbl)
        Me.TabPage3.Controls.Add(Me.Party4HPBar)
        Me.TabPage3.Controls.Add(Me.Party4LevelLbl)
        Me.TabPage3.Controls.Add(Me.Party4NameLbl)
        Me.TabPage3.Controls.Add(Me.Party3HPBar)
        Me.TabPage3.Controls.Add(Me.Party3LevelLbl)
        Me.TabPage3.Controls.Add(Me.Party3NameLbl)
        Me.TabPage3.Controls.Add(Me.Party2HPBar)
        Me.TabPage3.Controls.Add(Me.Party2LevelLbl)
        Me.TabPage3.Controls.Add(Me.Party2NameLbl)
        Me.TabPage3.Controls.Add(Me.Party1HPBar)
        Me.TabPage3.Controls.Add(Me.Party1LevelLbl)
        Me.TabPage3.Controls.Add(Me.Party1NameLbl)
        Me.TabPage3.Controls.Add(Me.Party5PicBox)
        Me.TabPage3.Controls.Add(Me.Party4PicBox)
        Me.TabPage3.Controls.Add(Me.Party3PicBox)
        Me.TabPage3.Controls.Add(Me.Party2PicBox)
        Me.TabPage3.Controls.Add(Me.Party1PicBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(569, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Party"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Party1HPBar
        '
        Me.Party1HPBar.Location = New System.Drawing.Point(77, 62)
        Me.Party1HPBar.Name = "Party1HPBar"
        Me.Party1HPBar.Size = New System.Drawing.Size(118, 20)
        Me.Party1HPBar.TabIndex = 7
        '
        'Party1LevelLbl
        '
        Me.Party1LevelLbl.AutoSize = True
        Me.Party1LevelLbl.Location = New System.Drawing.Point(74, 34)
        Me.Party1LevelLbl.Name = "Party1LevelLbl"
        Me.Party1LevelLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party1LevelLbl.TabIndex = 6
        '
        'Party1NameLbl
        '
        Me.Party1NameLbl.AutoSize = True
        Me.Party1NameLbl.Location = New System.Drawing.Point(74, 12)
        Me.Party1NameLbl.Name = "Party1NameLbl"
        Me.Party1NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party1NameLbl.TabIndex = 5
        '
        'Party5PicBox
        '
        Me.Party5PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Party5PicBox.Location = New System.Drawing.Point(7, 386)
        Me.Party5PicBox.Name = "Party5PicBox"
        Me.Party5PicBox.Size = New System.Drawing.Size(64, 89)
        Me.Party5PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Party5PicBox.TabIndex = 4
        Me.Party5PicBox.TabStop = False
        '
        'Party4PicBox
        '
        Me.Party4PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Party4PicBox.Location = New System.Drawing.Point(7, 291)
        Me.Party4PicBox.Name = "Party4PicBox"
        Me.Party4PicBox.Size = New System.Drawing.Size(64, 89)
        Me.Party4PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Party4PicBox.TabIndex = 3
        Me.Party4PicBox.TabStop = False
        '
        'Party3PicBox
        '
        Me.Party3PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Party3PicBox.Location = New System.Drawing.Point(7, 196)
        Me.Party3PicBox.Name = "Party3PicBox"
        Me.Party3PicBox.Size = New System.Drawing.Size(64, 89)
        Me.Party3PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Party3PicBox.TabIndex = 2
        Me.Party3PicBox.TabStop = False
        '
        'Party2PicBox
        '
        Me.Party2PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Party2PicBox.Location = New System.Drawing.Point(7, 101)
        Me.Party2PicBox.Name = "Party2PicBox"
        Me.Party2PicBox.Size = New System.Drawing.Size(64, 89)
        Me.Party2PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Party2PicBox.TabIndex = 1
        Me.Party2PicBox.TabStop = False
        '
        'Party1PicBox
        '
        Me.Party1PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Party1PicBox.Location = New System.Drawing.Point(7, 6)
        Me.Party1PicBox.Name = "Party1PicBox"
        Me.Party1PicBox.Size = New System.Drawing.Size(64, 89)
        Me.Party1PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Party1PicBox.TabIndex = 0
        Me.Party1PicBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PowerBar)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.StatusLbl)
        Me.GroupBox1.Controls.Add(Me.IntelligenceLbl)
        Me.GroupBox1.Controls.Add(Me.SpeedLbl)
        Me.GroupBox1.Controls.Add(Me.StrengthLbl)
        Me.GroupBox1.Controls.Add(Me.DexterityLbl)
        Me.GroupBox1.Controls.Add(Me.EnduranceLbl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.XPbar)
        Me.GroupBox1.Controls.Add(Me.HPbar)
        Me.GroupBox1.Controls.Add(Me.NameLbl)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(608, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 574)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Character"
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.Location = New System.Drawing.Point(237, 535)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(0, 13)
        Me.StatusLbl.TabIndex = 17
        '
        'IntelligenceLbl
        '
        Me.IntelligenceLbl.AutoSize = True
        Me.IntelligenceLbl.Location = New System.Drawing.Point(262, 504)
        Me.IntelligenceLbl.Name = "IntelligenceLbl"
        Me.IntelligenceLbl.Size = New System.Drawing.Size(0, 13)
        Me.IntelligenceLbl.TabIndex = 16
        '
        'SpeedLbl
        '
        Me.SpeedLbl.AutoSize = True
        Me.SpeedLbl.Location = New System.Drawing.Point(239, 475)
        Me.SpeedLbl.Name = "SpeedLbl"
        Me.SpeedLbl.Size = New System.Drawing.Size(0, 13)
        Me.SpeedLbl.TabIndex = 15
        '
        'StrengthLbl
        '
        Me.StrengthLbl.AutoSize = True
        Me.StrengthLbl.Location = New System.Drawing.Point(87, 535)
        Me.StrengthLbl.Name = "StrengthLbl"
        Me.StrengthLbl.Size = New System.Drawing.Size(0, 13)
        Me.StrengthLbl.TabIndex = 14
        '
        'DexterityLbl
        '
        Me.DexterityLbl.AutoSize = True
        Me.DexterityLbl.Location = New System.Drawing.Point(88, 505)
        Me.DexterityLbl.Name = "DexterityLbl"
        Me.DexterityLbl.Size = New System.Drawing.Size(0, 13)
        Me.DexterityLbl.TabIndex = 13
        '
        'EnduranceLbl
        '
        Me.EnduranceLbl.AutoSize = True
        Me.EnduranceLbl.Location = New System.Drawing.Point(98, 475)
        Me.EnduranceLbl.Name = "EnduranceLbl"
        Me.EnduranceLbl.Size = New System.Drawing.Size(0, 13)
        Me.EnduranceLbl.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 535)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 505)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Intelligence:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Speed:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 535)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Strength:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dexterity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Endurance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "XP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "HP"
        '
        'XPbar
        '
        Me.XPbar.Location = New System.Drawing.Point(64, 392)
        Me.XPbar.MarqueeAnimationSpeed = 1
        Me.XPbar.Name = "XPbar"
        Me.XPbar.Size = New System.Drawing.Size(296, 23)
        Me.XPbar.TabIndex = 3
        '
        'HPbar
        '
        Me.HPbar.Location = New System.Drawing.Point(64, 362)
        Me.HPbar.Name = "HPbar"
        Me.HPbar.Size = New System.Drawing.Size(296, 23)
        Me.HPbar.TabIndex = 2
        '
        'NameLbl
        '
        Me.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(6, 16)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(150, 31)
        Me.NameLbl.TabIndex = 1
        Me.NameLbl.Text = "Your Name"
        Me.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(81, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 276)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadBtn
        '
        Me.LoadBtn.Location = New System.Drawing.Point(13, 593)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoadBtn.TabIndex = 2
        Me.LoadBtn.Text = "Load Game"
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'Party2HPBar
        '
        Me.Party2HPBar.Location = New System.Drawing.Point(77, 159)
        Me.Party2HPBar.Name = "Party2HPBar"
        Me.Party2HPBar.Size = New System.Drawing.Size(118, 20)
        Me.Party2HPBar.TabIndex = 10
        '
        'Party2LevelLbl
        '
        Me.Party2LevelLbl.AutoSize = True
        Me.Party2LevelLbl.Location = New System.Drawing.Point(74, 131)
        Me.Party2LevelLbl.Name = "Party2LevelLbl"
        Me.Party2LevelLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party2LevelLbl.TabIndex = 9
        '
        'Party2NameLbl
        '
        Me.Party2NameLbl.AutoSize = True
        Me.Party2NameLbl.Location = New System.Drawing.Point(74, 109)
        Me.Party2NameLbl.Name = "Party2NameLbl"
        Me.Party2NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party2NameLbl.TabIndex = 8
        '
        'Party3HPBar
        '
        Me.Party3HPBar.Location = New System.Drawing.Point(77, 255)
        Me.Party3HPBar.Name = "Party3HPBar"
        Me.Party3HPBar.Size = New System.Drawing.Size(118, 20)
        Me.Party3HPBar.TabIndex = 13
        '
        'Party3LevelLbl
        '
        Me.Party3LevelLbl.AutoSize = True
        Me.Party3LevelLbl.Location = New System.Drawing.Point(74, 227)
        Me.Party3LevelLbl.Name = "Party3LevelLbl"
        Me.Party3LevelLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party3LevelLbl.TabIndex = 12
        '
        'Party3NameLbl
        '
        Me.Party3NameLbl.AutoSize = True
        Me.Party3NameLbl.Location = New System.Drawing.Point(74, 205)
        Me.Party3NameLbl.Name = "Party3NameLbl"
        Me.Party3NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party3NameLbl.TabIndex = 11
        '
        'Party4HPBar
        '
        Me.Party4HPBar.Location = New System.Drawing.Point(77, 345)
        Me.Party4HPBar.Name = "Party4HPBar"
        Me.Party4HPBar.Size = New System.Drawing.Size(118, 20)
        Me.Party4HPBar.TabIndex = 16
        '
        'Party4LevelLbl
        '
        Me.Party4LevelLbl.AutoSize = True
        Me.Party4LevelLbl.Location = New System.Drawing.Point(74, 317)
        Me.Party4LevelLbl.Name = "Party4LevelLbl"
        Me.Party4LevelLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party4LevelLbl.TabIndex = 15
        '
        'Party4NameLbl
        '
        Me.Party4NameLbl.AutoSize = True
        Me.Party4NameLbl.Location = New System.Drawing.Point(74, 295)
        Me.Party4NameLbl.Name = "Party4NameLbl"
        Me.Party4NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party4NameLbl.TabIndex = 14
        '
        'Party5HPBar
        '
        Me.Party5HPBar.Location = New System.Drawing.Point(77, 440)
        Me.Party5HPBar.Name = "Party5HPBar"
        Me.Party5HPBar.Size = New System.Drawing.Size(118, 20)
        Me.Party5HPBar.TabIndex = 19
        '
        'Party5LevelLbl
        '
        Me.Party5LevelLbl.AutoSize = True
        Me.Party5LevelLbl.Location = New System.Drawing.Point(74, 412)
        Me.Party5LevelLbl.Name = "Party5LevelLbl"
        Me.Party5LevelLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party5LevelLbl.TabIndex = 18
        '
        'Party5NameLbl
        '
        Me.Party5NameLbl.AutoSize = True
        Me.Party5NameLbl.Location = New System.Drawing.Point(74, 390)
        Me.Party5NameLbl.Name = "Party5NameLbl"
        Me.Party5NameLbl.Size = New System.Drawing.Size(0, 13)
        Me.Party5NameLbl.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 20)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "PWR"
        '
        'PowerBar
        '
        Me.PowerBar.Location = New System.Drawing.Point(64, 421)
        Me.PowerBar.MarqueeAnimationSpeed = 1
        Me.PowerBar.Name = "PowerBar"
        Me.PowerBar.Size = New System.Drawing.Size(296, 23)
        Me.PowerBar.TabIndex = 19
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 676)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameForm"
        Me.Text = "Andrew's most excellent game client"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Enemy5PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy4PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Party5PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Party4PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Party3PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Party2PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Party1PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HPbar As System.Windows.Forms.ProgressBar
    Friend WithEvents XPbar As System.Windows.Forms.ProgressBar
    Friend WithEvents TravelBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DestLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoadBtn As System.Windows.Forms.Button
    Friend WithEvents StatusLbl As System.Windows.Forms.Label
    Friend WithEvents IntelligenceLbl As System.Windows.Forms.Label
    Friend WithEvents SpeedLbl As System.Windows.Forms.Label
    Friend WithEvents StrengthLbl As System.Windows.Forms.Label
    Friend WithEvents DexterityLbl As System.Windows.Forms.Label
    Friend WithEvents EnduranceLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CombatTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TravelTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Enemy5NameLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy4NameLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy3NameLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy2NameLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy1NameLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy5HPLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy4HPLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy3HPLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy2HPLbl As System.Windows.Forms.Label
    Friend WithEvents Enemy1HPLbl As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Enemy5PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy4PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy3PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy2PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy1PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party1HPBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Party1LevelLbl As System.Windows.Forms.Label
    Friend WithEvents Party1NameLbl As System.Windows.Forms.Label
    Friend WithEvents Party5PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party4PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party3PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party2PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party1PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Party5HPBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Party5LevelLbl As System.Windows.Forms.Label
    Friend WithEvents Party5NameLbl As System.Windows.Forms.Label
    Friend WithEvents Party4HPBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Party4LevelLbl As System.Windows.Forms.Label
    Friend WithEvents Party4NameLbl As System.Windows.Forms.Label
    Friend WithEvents Party3HPBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Party3LevelLbl As System.Windows.Forms.Label
    Friend WithEvents Party3NameLbl As System.Windows.Forms.Label
    Friend WithEvents Party2HPBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Party2LevelLbl As System.Windows.Forms.Label
    Friend WithEvents Party2NameLbl As System.Windows.Forms.Label
    Friend WithEvents PowerBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class

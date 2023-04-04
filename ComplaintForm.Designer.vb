<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplaintForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComplaintForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AssetStatusGroupBox = New System.Windows.Forms.GroupBox()
        Me.DamagedCHB = New System.Windows.Forms.CheckBox()
        Me.ResolvedCHB = New System.Windows.Forms.CheckBox()
        Me.PendingCHB = New System.Windows.Forms.CheckBox()
        Me.PLevelCbx = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssignTotxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RIssuetxt = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CDepartmentCbx = New System.Windows.Forms.ComboBox()
        Me.ATagtxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CRNtxt = New System.Windows.Forms.TextBox()
        Me.ANametxt = New System.Windows.Forms.TextBox()
        Me.CContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CNametxt = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.AssetStatusGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 720)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(394, 831)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 51)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 905)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(892, 26)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AssetStatusGroupBox)
        Me.GroupBox2.Controls.Add(Me.PLevelCbx)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AssignTotxt)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 549)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(838, 255)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "For MIS Unity/Dept. Only"
        '
        'AssetStatusGroupBox
        '
        Me.AssetStatusGroupBox.Controls.Add(Me.DamagedCHB)
        Me.AssetStatusGroupBox.Controls.Add(Me.ResolvedCHB)
        Me.AssetStatusGroupBox.Controls.Add(Me.PendingCHB)
        Me.AssetStatusGroupBox.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetStatusGroupBox.Location = New System.Drawing.Point(21, 122)
        Me.AssetStatusGroupBox.Name = "AssetStatusGroupBox"
        Me.AssetStatusGroupBox.Size = New System.Drawing.Size(513, 100)
        Me.AssetStatusGroupBox.TabIndex = 34
        Me.AssetStatusGroupBox.TabStop = False
        Me.AssetStatusGroupBox.Text = "Asset Status"
        '
        'DamagedCHB
        '
        Me.DamagedCHB.AutoSize = True
        Me.DamagedCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamagedCHB.Location = New System.Drawing.Point(325, 47)
        Me.DamagedCHB.Name = "DamagedCHB"
        Me.DamagedCHB.Size = New System.Drawing.Size(128, 28)
        Me.DamagedCHB.TabIndex = 24
        Me.DamagedCHB.Text = "Damaged"
        Me.DamagedCHB.UseVisualStyleBackColor = True
        '
        'ResolvedCHB
        '
        Me.ResolvedCHB.AutoSize = True
        Me.ResolvedCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResolvedCHB.Location = New System.Drawing.Point(29, 47)
        Me.ResolvedCHB.Name = "ResolvedCHB"
        Me.ResolvedCHB.Size = New System.Drawing.Size(124, 28)
        Me.ResolvedCHB.TabIndex = 22
        Me.ResolvedCHB.Text = "Resolved"
        Me.ResolvedCHB.UseVisualStyleBackColor = True
        '
        'PendingCHB
        '
        Me.PendingCHB.AutoSize = True
        Me.PendingCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingCHB.Location = New System.Drawing.Point(174, 47)
        Me.PendingCHB.Name = "PendingCHB"
        Me.PendingCHB.Size = New System.Drawing.Size(115, 28)
        Me.PendingCHB.TabIndex = 23
        Me.PendingCHB.Text = "Pending"
        Me.PendingCHB.UseVisualStyleBackColor = True
        '
        'PLevelCbx
        '
        Me.PLevelCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PLevelCbx.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PLevelCbx.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLevelCbx.FormattingEnabled = True
        Me.PLevelCbx.Items.AddRange(New Object() {"Low", "Normal", "High"})
        Me.PLevelCbx.Location = New System.Drawing.Point(621, 55)
        Me.PLevelCbx.Name = "PLevelCbx"
        Me.PLevelCbx.Size = New System.Drawing.Size(157, 32)
        Me.PLevelCbx.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(467, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Priority level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Assign to"
        '
        'AssignTotxt
        '
        Me.AssignTotxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignTotxt.Location = New System.Drawing.Point(131, 55)
        Me.AssignTotxt.Name = "AssignTotxt"
        Me.AssignTotxt.Size = New System.Drawing.Size(290, 32)
        Me.AssignTotxt.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RIssuetxt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CDepartmentCbx)
        Me.GroupBox1.Controls.Add(Me.ATagtxt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CRNtxt)
        Me.GroupBox1.Controls.Add(Me.ANametxt)
        Me.GroupBox1.Controls.Add(Me.CContact)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CNametxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 494)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complainant Information"
        '
        'RIssuetxt
        '
        Me.RIssuetxt.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIssuetxt.Location = New System.Drawing.Point(21, 253)
        Me.RIssuetxt.Name = "RIssuetxt"
        Me.RIssuetxt.Size = New System.Drawing.Size(500, 136)
        Me.RIssuetxt.TabIndex = 21
        Me.RIssuetxt.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Reported issue"
        '
        'CDepartmentCbx
        '
        Me.CDepartmentCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CDepartmentCbx.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CDepartmentCbx.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDepartmentCbx.FormattingEnabled = True
        Me.CDepartmentCbx.Items.AddRange(New Object() {"Planning", "Works", "MIS", "Accounting"})
        Me.CDepartmentCbx.Location = New System.Drawing.Point(564, 56)
        Me.CDepartmentCbx.Name = "CDepartmentCbx"
        Me.CDepartmentCbx.Size = New System.Drawing.Size(157, 32)
        Me.CDepartmentCbx.TabIndex = 19
        '
        'ATagtxt
        '
        Me.ATagtxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATagtxt.Location = New System.Drawing.Point(535, 164)
        Me.ATagtxt.Name = "ATagtxt"
        Me.ATagtxt.Size = New System.Drawing.Size(260, 32)
        Me.ATagtxt.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(421, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Asset tag"
        '
        'CRNtxt
        '
        Me.CRNtxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNtxt.Location = New System.Drawing.Point(190, 105)
        Me.CRNtxt.Name = "CRNtxt"
        Me.CRNtxt.Size = New System.Drawing.Size(201, 32)
        Me.CRNtxt.TabIndex = 16
        '
        'ANametxt
        '
        Me.ANametxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANametxt.Location = New System.Drawing.Point(162, 164)
        Me.ANametxt.Name = "ANametxt"
        Me.ANametxt.Size = New System.Drawing.Size(201, 32)
        Me.ANametxt.TabIndex = 14
        '
        'CContact
        '
        Me.CContact.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CContact.Location = New System.Drawing.Point(554, 105)
        Me.CContact.Name = "CContact"
        Me.CContact.Size = New System.Drawing.Size(201, 32)
        Me.CContact.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Room number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Asset name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'CNametxt
        '
        Me.CNametxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNametxt.Location = New System.Drawing.Point(101, 48)
        Me.CNametxt.Name = "CNametxt"
        Me.CNametxt.Size = New System.Drawing.Size(290, 32)
        Me.CNametxt.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(851, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(884, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(339, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 29)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "FAULT COMPLAINT FORM"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(42, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'ComplaintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 820)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ComplaintForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FaultForm"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.AssetStatusGroupBox.ResumeLayout(False)
        Me.AssetStatusGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CNametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CDepartmentCbx As ComboBox
    Friend WithEvents ATagtxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CRNtxt As TextBox
    Friend WithEvents ANametxt As TextBox
    Friend WithEvents CContact As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RIssuetxt As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PLevelCbx As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AssignTotxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DamagedCHB As CheckBox
    Friend WithEvents PendingCHB As CheckBox
    Friend WithEvents ResolvedCHB As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents AssetStatusGroupBox As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

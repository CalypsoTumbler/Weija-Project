<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repairs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Repairs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AssetStatusGroupBox = New System.Windows.Forms.GroupBox()
        Me.PendingCHB = New System.Windows.Forms.CheckBox()
        Me.ResolvedCHB = New System.Windows.Forms.CheckBox()
        Me.DamagedCHB = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RepairDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RRemarksTxt = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FaultsDGV = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.AssetStatusGroupBox.SuspendLayout()
        CType(Me.FaultsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AssetStatusGroupBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.RepairDateDTP)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.RRemarksTxt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.FaultsDGV)
        Me.Panel1.Location = New System.Drawing.Point(12, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1118, 793)
        Me.Panel1.TabIndex = 0
        '
        'AssetStatusGroupBox
        '
        Me.AssetStatusGroupBox.Controls.Add(Me.PendingCHB)
        Me.AssetStatusGroupBox.Controls.Add(Me.ResolvedCHB)
        Me.AssetStatusGroupBox.Controls.Add(Me.DamagedCHB)
        Me.AssetStatusGroupBox.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetStatusGroupBox.Location = New System.Drawing.Point(13, 480)
        Me.AssetStatusGroupBox.Name = "AssetStatusGroupBox"
        Me.AssetStatusGroupBox.Size = New System.Drawing.Size(513, 100)
        Me.AssetStatusGroupBox.TabIndex = 33
        Me.AssetStatusGroupBox.TabStop = False
        Me.AssetStatusGroupBox.Text = "Asset Status"
        '
        'PendingCHB
        '
        Me.PendingCHB.AutoSize = True
        Me.PendingCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingCHB.Location = New System.Drawing.Point(195, 40)
        Me.PendingCHB.Name = "PendingCHB"
        Me.PendingCHB.Size = New System.Drawing.Size(115, 28)
        Me.PendingCHB.TabIndex = 30
        Me.PendingCHB.Text = "Pending"
        Me.PendingCHB.UseVisualStyleBackColor = True
        '
        'ResolvedCHB
        '
        Me.ResolvedCHB.AutoSize = True
        Me.ResolvedCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResolvedCHB.Location = New System.Drawing.Point(50, 40)
        Me.ResolvedCHB.Name = "ResolvedCHB"
        Me.ResolvedCHB.Size = New System.Drawing.Size(124, 28)
        Me.ResolvedCHB.TabIndex = 29
        Me.ResolvedCHB.Text = "Resolved"
        Me.ResolvedCHB.UseVisualStyleBackColor = True
        '
        'DamagedCHB
        '
        Me.DamagedCHB.AutoSize = True
        Me.DamagedCHB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamagedCHB.Location = New System.Drawing.Point(346, 40)
        Me.DamagedCHB.Name = "DamagedCHB"
        Me.DamagedCHB.Size = New System.Drawing.Size(128, 28)
        Me.DamagedCHB.TabIndex = 31
        Me.DamagedCHB.Text = "Damaged"
        Me.DamagedCHB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(769, 637)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 51)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(260, 637)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 51)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RepairDateDTP
        '
        Me.RepairDateDTP.CalendarFont = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepairDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RepairDateDTP.Location = New System.Drawing.Point(49, 429)
        Me.RepairDateDTP.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.RepairDateDTP.Name = "RepairDateDTP"
        Me.RepairDateDTP.Size = New System.Drawing.Size(200, 22)
        Me.RepairDateDTP.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 24)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Date Repaired"
        '
        'RRemarksTxt
        '
        Me.RRemarksTxt.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRemarksTxt.Location = New System.Drawing.Point(563, 426)
        Me.RRemarksTxt.MaxLength = 50
        Me.RRemarksTxt.Name = "RRemarksTxt"
        Me.RRemarksTxt.Size = New System.Drawing.Size(500, 136)
        Me.RRemarksTxt.TabIndex = 25
        Me.RRemarksTxt.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(559, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Repair remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(470, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Pending Asset Faults"
        '
        'FaultsDGV
        '
        Me.FaultsDGV.AllowUserToAddRows = False
        Me.FaultsDGV.AllowUserToDeleteRows = False
        Me.FaultsDGV.AllowUserToResizeColumns = False
        Me.FaultsDGV.AllowUserToResizeRows = False
        Me.FaultsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FaultsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.FaultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FaultsDGV.Location = New System.Drawing.Point(35, 66)
        Me.FaultsDGV.Name = "FaultsDGV"
        Me.FaultsDGV.RowHeadersVisible = False
        Me.FaultsDGV.RowHeadersWidth = 51
        Me.FaultsDGV.RowTemplate.Height = 24
        Me.FaultsDGV.Size = New System.Drawing.Size(1028, 286)
        Me.FaultsDGV.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1031, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1064, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(468, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 29)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "REPAIRS FORM"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Repairs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 936)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Repairs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repairs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AssetStatusGroupBox.ResumeLayout(False)
        Me.AssetStatusGroupBox.PerformLayout()
        CType(Me.FaultsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents FaultsDGV As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RRemarksTxt As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RepairDateDTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DamagedCHB As CheckBox
    Friend WithEvents PendingCHB As CheckBox
    Friend WithEvents ResolvedCHB As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents AssetStatusGroupBox As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

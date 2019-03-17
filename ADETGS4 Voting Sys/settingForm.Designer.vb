<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clrBtn = New System.Windows.Forms.Button()
        Me.updtBtn = New System.Windows.Forms.Button()
        Me.dirBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rclrBtn = New System.Windows.Forms.Button()
        Me.rupdtBtn = New System.Windows.Forms.Button()
        Me.repoBox = New System.Windows.Forms.TextBox()
        Me.rrClrBtn = New System.Windows.Forms.Button()
        Me.opnBtn = New System.Windows.Forms.Button()
        Me.extAppBtn = New System.Windows.Forms.Button()
        Me.extBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.portBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ipBox = New System.Windows.Forms.TextBox()
        Me.ipBtn = New System.Windows.Forms.Button()
        Me.brwsBtn = New System.Windows.Forms.Button()
        Me.folderDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.brwsBtn)
        Me.GroupBox1.Controls.Add(Me.clrBtn)
        Me.GroupBox1.Controls.Add(Me.updtBtn)
        Me.GroupBox1.Controls.Add(Me.dirBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lokasi Penyimpanan"
        '
        'clrBtn
        '
        Me.clrBtn.Location = New System.Drawing.Point(609, 17)
        Me.clrBtn.Name = "clrBtn"
        Me.clrBtn.Size = New System.Drawing.Size(75, 23)
        Me.clrBtn.TabIndex = 2
        Me.clrBtn.Text = "Clear"
        Me.clrBtn.UseVisualStyleBackColor = True
        '
        'updtBtn
        '
        Me.updtBtn.Location = New System.Drawing.Point(690, 17)
        Me.updtBtn.Name = "updtBtn"
        Me.updtBtn.Size = New System.Drawing.Size(75, 23)
        Me.updtBtn.TabIndex = 1
        Me.updtBtn.Text = "Update"
        Me.updtBtn.UseVisualStyleBackColor = True
        '
        'dirBox
        '
        Me.dirBox.Location = New System.Drawing.Point(8, 19)
        Me.dirBox.Name = "dirBox"
        Me.dirBox.Size = New System.Drawing.Size(514, 20)
        Me.dirBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pengaturan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rclrBtn)
        Me.GroupBox2.Controls.Add(Me.rupdtBtn)
        Me.GroupBox2.Controls.Add(Me.repoBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nama Report"
        '
        'rclrBtn
        '
        Me.rclrBtn.Location = New System.Drawing.Point(609, 17)
        Me.rclrBtn.Name = "rclrBtn"
        Me.rclrBtn.Size = New System.Drawing.Size(75, 23)
        Me.rclrBtn.TabIndex = 2
        Me.rclrBtn.Text = "Clear"
        Me.rclrBtn.UseVisualStyleBackColor = True
        '
        'rupdtBtn
        '
        Me.rupdtBtn.Location = New System.Drawing.Point(690, 17)
        Me.rupdtBtn.Name = "rupdtBtn"
        Me.rupdtBtn.Size = New System.Drawing.Size(75, 23)
        Me.rupdtBtn.TabIndex = 1
        Me.rupdtBtn.Text = "Update"
        Me.rupdtBtn.UseVisualStyleBackColor = True
        '
        'repoBox
        '
        Me.repoBox.Location = New System.Drawing.Point(8, 19)
        Me.repoBox.Name = "repoBox"
        Me.repoBox.Size = New System.Drawing.Size(595, 20)
        Me.repoBox.TabIndex = 0
        '
        'rrClrBtn
        '
        Me.rrClrBtn.Location = New System.Drawing.Point(20, 226)
        Me.rrClrBtn.Name = "rrClrBtn"
        Me.rrClrBtn.Size = New System.Drawing.Size(75, 23)
        Me.rrClrBtn.TabIndex = 4
        Me.rrClrBtn.Text = "Clear"
        Me.rrClrBtn.UseVisualStyleBackColor = True
        '
        'opnBtn
        '
        Me.opnBtn.Location = New System.Drawing.Point(105, 226)
        Me.opnBtn.Name = "opnBtn"
        Me.opnBtn.Size = New System.Drawing.Size(75, 23)
        Me.opnBtn.TabIndex = 5
        Me.opnBtn.Text = "Open"
        Me.opnBtn.UseVisualStyleBackColor = True
        '
        'extAppBtn
        '
        Me.extAppBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.extAppBtn.FlatAppearance.BorderSize = 0
        Me.extAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.extAppBtn.Location = New System.Drawing.Point(702, 226)
        Me.extAppBtn.Name = "extAppBtn"
        Me.extAppBtn.Size = New System.Drawing.Size(75, 23)
        Me.extAppBtn.TabIndex = 6
        Me.extAppBtn.Text = "Exit App"
        Me.extAppBtn.UseVisualStyleBackColor = False
        '
        'extBtn
        '
        Me.extBtn.Location = New System.Drawing.Point(190, 226)
        Me.extBtn.Name = "extBtn"
        Me.extBtn.Size = New System.Drawing.Size(75, 23)
        Me.extBtn.TabIndex = 7
        Me.extBtn.Text = "Exit Form"
        Me.extBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.portBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ipBox)
        Me.GroupBox3.Controls.Add(Me.ipBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 50)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TCP Configuration"
        '
        'portBox
        '
        Me.portBox.Location = New System.Drawing.Point(505, 19)
        Me.portBox.Name = "portBox"
        Me.portBox.Size = New System.Drawing.Size(98, 20)
        Me.portBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IP Adress"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(473, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'ipBox
        '
        Me.ipBox.Location = New System.Drawing.Point(65, 19)
        Me.ipBox.Name = "ipBox"
        Me.ipBox.Size = New System.Drawing.Size(402, 20)
        Me.ipBox.TabIndex = 1
        '
        'ipBtn
        '
        Me.ipBtn.Location = New System.Drawing.Point(609, 19)
        Me.ipBtn.Name = "ipBtn"
        Me.ipBtn.Size = New System.Drawing.Size(156, 23)
        Me.ipBtn.TabIndex = 0
        Me.ipBtn.Text = "Update"
        Me.ipBtn.UseVisualStyleBackColor = True
        '
        'brwsBtn
        '
        Me.brwsBtn.Location = New System.Drawing.Point(528, 17)
        Me.brwsBtn.Name = "brwsBtn"
        Me.brwsBtn.Size = New System.Drawing.Size(75, 23)
        Me.brwsBtn.TabIndex = 3
        Me.brwsBtn.Text = "Browse"
        Me.brwsBtn.UseVisualStyleBackColor = True
        '
        'folderDlg
        '
        '
        'settingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 261)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.extBtn)
        Me.Controls.Add(Me.extAppBtn)
        Me.Controls.Add(Me.opnBtn)
        Me.Controls.Add(Me.rrClrBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "settingForm"
        Me.Text = "settingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dirBox As TextBox
    Friend WithEvents clrBtn As Button
    Friend WithEvents updtBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rclrBtn As Button
    Friend WithEvents rupdtBtn As Button
    Friend WithEvents repoBox As TextBox
    Friend WithEvents rrClrBtn As Button
    Friend WithEvents opnBtn As Button
    Friend WithEvents extAppBtn As Button
    Friend WithEvents extBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ipBox As TextBox
    Friend WithEvents ipBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents portBox As TextBox
    Friend WithEvents brwsBtn As Button
    Friend WithEvents folderDlg As FolderBrowserDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.strtBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.voteBtn = New System.Windows.Forms.Button()
        Me.pictureVote = New System.Windows.Forms.PictureBox()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.prevBtn = New System.Windows.Forms.Button()
        CType(Me.pictureVote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strtBtn
        '
        Me.strtBtn.FlatAppearance.BorderSize = 0
        Me.strtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strtBtn.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.strt_btn
        Me.strtBtn.Location = New System.Drawing.Point(965, 993)
        Me.strtBtn.Name = "strtBtn"
        Me.strtBtn.Size = New System.Drawing.Size(835, 50)
        Me.strtBtn.TabIndex = 6
        Me.strtBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.set_btn
        Me.Button2.Location = New System.Drawing.Point(119, 993)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(835, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'voteBtn
        '
        Me.voteBtn.FlatAppearance.BorderSize = 0
        Me.voteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voteBtn.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.vote_btn
        Me.voteBtn.Location = New System.Drawing.Point(965, 993)
        Me.voteBtn.Name = "voteBtn"
        Me.voteBtn.Size = New System.Drawing.Size(835, 50)
        Me.voteBtn.TabIndex = 4
        Me.voteBtn.UseVisualStyleBackColor = True
        '
        'pictureVote
        '
        Me.pictureVote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureVote.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.bg_img_res
        Me.pictureVote.Location = New System.Drawing.Point(112, 17)
        Me.pictureVote.Margin = New System.Windows.Forms.Padding(10)
        Me.pictureVote.Name = "pictureVote"
        Me.pictureVote.Size = New System.Drawing.Size(1680, 945)
        Me.pictureVote.TabIndex = 3
        Me.pictureVote.TabStop = False
        '
        'nextBtn
        '
        Me.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nextBtn.FlatAppearance.BorderSize = 0
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.next_btn
        Me.nextBtn.Location = New System.Drawing.Point(1815, 480)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(85, 85)
        Me.nextBtn.TabIndex = 1
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'prevBtn
        '
        Me.prevBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.prevBtn.FlatAppearance.BorderSize = 0
        Me.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevBtn.Image = Global.ADETGS4_Voting_Sys.My.Resources.Resources.prev_btn
        Me.prevBtn.Location = New System.Drawing.Point(20, 480)
        Me.prevBtn.Name = "prevBtn"
        Me.prevBtn.Size = New System.Drawing.Size(85, 85)
        Me.prevBtn.TabIndex = 0
        Me.prevBtn.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.strtBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.voteBtn)
        Me.Controls.Add(Me.pictureVote)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.prevBtn)
        Me.Name = "mainForm"
        Me.Text = "Form1"
        CType(Me.pictureVote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prevBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents pictureVote As PictureBox
    Friend WithEvents voteBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents strtBtn As Button
End Class

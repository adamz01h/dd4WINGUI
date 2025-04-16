<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.browse_btn = New System.Windows.Forms.Button
        Me.refresh_btn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.browse_fld = New System.Windows.Forms.TextBox
        Me.start = New System.Windows.Forms.Button
        Me.HDList = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.read = New System.Windows.Forms.RadioButton
        Me.write = New System.Windows.Forms.RadioButton
        Me.HDParts = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.exit_btn = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bsother_box = New System.Windows.Forms.TextBox
        Me.bsother = New System.Windows.Forms.RadioButton
        Me.bstwo = New System.Windows.Forms.RadioButton
        Me.bsone = New System.Windows.Forms.RadioButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'browse_btn
        '
        Me.browse_btn.Enabled = False
        Me.browse_btn.Location = New System.Drawing.Point(263, 196)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(75, 23)
        Me.browse_btn.TabIndex = 5
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(263, 101)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 6
        Me.refresh_btn.Text = "Refresh Disk List"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Disk:"
        '
        'browse_fld
        '
        Me.browse_fld.Location = New System.Drawing.Point(12, 198)
        Me.browse_fld.Name = "browse_fld"
        Me.browse_fld.ReadOnly = True
        Me.browse_fld.Size = New System.Drawing.Size(242, 20)
        Me.browse_fld.TabIndex = 11
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(12, 307)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(118, 27)
        Me.start.TabIndex = 12
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'HDList
        '
        Me.HDList.FormattingEnabled = True
        Me.HDList.Location = New System.Drawing.Point(12, 34)
        Me.HDList.Name = "HDList"
        Me.HDList.Size = New System.Drawing.Size(326, 21)
        Me.HDList.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.read)
        Me.GroupBox2.Controls.Add(Me.write)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 60)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'read
        '
        Me.read.AutoSize = True
        Me.read.Location = New System.Drawing.Point(201, 28)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(119, 17)
        Me.read.TabIndex = 1
        Me.read.TabStop = True
        Me.read.Text = "Read Disk to Image"
        Me.read.UseVisualStyleBackColor = True
        '
        'write
        '
        Me.write.AutoSize = True
        Me.write.Location = New System.Drawing.Point(6, 28)
        Me.write.Name = "write"
        Me.write.Size = New System.Drawing.Size(118, 17)
        Me.write.TabIndex = 0
        Me.write.TabStop = True
        Me.write.Text = "Write Image to Disk"
        Me.write.UseVisualStyleBackColor = True
        '
        'HDParts
        '
        Me.HDParts.FormattingEnabled = True
        Me.HDParts.Location = New System.Drawing.Point(12, 74)
        Me.HDParts.Name = "HDParts"
        Me.HDParts.Size = New System.Drawing.Size(326, 21)
        Me.HDParts.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Selected Partition"
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(213, 307)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(118, 27)
        Me.exit_btn.TabIndex = 22
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bsother_box)
        Me.GroupBox1.Controls.Add(Me.bsother)
        Me.GroupBox1.Controls.Add(Me.bstwo)
        Me.GroupBox1.Controls.Add(Me.bsone)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 62)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Block Size"
        '
        'bsother_box
        '
        Me.bsother_box.Location = New System.Drawing.Point(219, 27)
        Me.bsother_box.Name = "bsother_box"
        Me.bsother_box.Size = New System.Drawing.Size(100, 20)
        Me.bsother_box.TabIndex = 3
        '
        'bsother
        '
        Me.bsother.AutoSize = True
        Me.bsother.Location = New System.Drawing.Point(171, 28)
        Me.bsother.Name = "bsother"
        Me.bsother.Size = New System.Drawing.Size(51, 17)
        Me.bsother.TabIndex = 2
        Me.bsother.TabStop = True
        Me.bsother.Text = "Other"
        Me.bsother.UseVisualStyleBackColor = True
        '
        'bstwo
        '
        Me.bstwo.AutoSize = True
        Me.bstwo.Location = New System.Drawing.Point(94, 28)
        Me.bstwo.Name = "bstwo"
        Me.bstwo.Size = New System.Drawing.Size(71, 17)
        Me.bstwo.TabIndex = 1
        Me.bstwo.TabStop = True
        Me.bstwo.Text = "512 bytes"
        Me.bstwo.UseVisualStyleBackColor = True
        '
        'bsone
        '
        Me.bsone.AutoSize = True
        Me.bsone.Location = New System.Drawing.Point(6, 28)
        Me.bsone.Name = "bsone"
        Me.bsone.Size = New System.Drawing.Size(83, 17)
        Me.bsone.TabIndex = 0
        Me.bsone.TabStop = True
        Me.bsone.Text = "1Megabytes"
        Me.bsone.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.HDParts)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.HDList)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.browse_fld)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.browse_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Simple Disk Dump for Windows Systems"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents browse_btn As System.Windows.Forms.Button
    Friend WithEvents refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents browse_fld As System.Windows.Forms.TextBox
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents HDList As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents read As System.Windows.Forms.RadioButton
    Friend WithEvents write As System.Windows.Forms.RadioButton
    Friend WithEvents HDParts As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bstwo As System.Windows.Forms.RadioButton
    Friend WithEvents bsone As System.Windows.Forms.RadioButton
    Friend WithEvents bsother_box As System.Windows.Forms.TextBox
    Friend WithEvents bsother As System.Windows.Forms.RadioButton

End Class

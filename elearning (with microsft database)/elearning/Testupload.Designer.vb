<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Testupload
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.gvfile = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CourseMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScienceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathmaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtfileM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ts = New System.Windows.Forms.TextBox()
        CType(Me.gvfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 557)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Topic "
        '
        'txtTopic
        '
        Me.txtTopic.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.Location = New System.Drawing.Point(517, 554)
        Me.txtTopic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(190, 23)
        Me.txtTopic.TabIndex = 27
        '
        'gvfile
        '
        Me.gvfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.gvfile.Location = New System.Drawing.Point(500, 225)
        Me.gvfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gvfile.Name = "gvfile"
        Me.gvfile.RowHeadersWidth = 62
        Me.gvfile.RowTemplate.Height = 28
        Me.gvfile.Size = New System.Drawing.Size(613, 292)
        Me.gvfile.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Topic"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Subject name"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = " File Name"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 400
        '
        'Column5
        '
        Me.Column5.HeaderText = "File data"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Teacher name"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Teacher ID"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        Me.Column7.Width = 150
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseMaterialsToolStripMenuItem, Me.TestToolStripMenuItem, Me.StudentPerformanceReportToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 35)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CourseMaterialsToolStripMenuItem
        '
        Me.CourseMaterialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScienceToolStripMenuItem, Me.MathmaticsToolStripMenuItem})
        Me.CourseMaterialsToolStripMenuItem.Name = "CourseMaterialsToolStripMenuItem"
        Me.CourseMaterialsToolStripMenuItem.Size = New System.Drawing.Size(188, 29)
        Me.CourseMaterialsToolStripMenuItem.Text = "Learning Materials"
        '
        'ScienceToolStripMenuItem
        '
        Me.ScienceToolStripMenuItem.Name = "ScienceToolStripMenuItem"
        Me.ScienceToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
        Me.ScienceToolStripMenuItem.Text = "Exercise"
        '
        'MathmaticsToolStripMenuItem
        '
        Me.MathmaticsToolStripMenuItem.Name = "MathmaticsToolStripMenuItem"
        Me.MathmaticsToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
        Me.MathmaticsToolStripMenuItem.Text = "Course Materials"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'StudentPerformanceReportToolStripMenuItem
        '
        Me.StudentPerformanceReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertPerformanceReportToolStripMenuItem})
        Me.StudentPerformanceReportToolStripMenuItem.Name = "StudentPerformanceReportToolStripMenuItem"
        Me.StudentPerformanceReportToolStripMenuItem.Size = New System.Drawing.Size(271, 29)
        Me.StudentPerformanceReportToolStripMenuItem.Text = "Student Performance Report"
        '
        'InsertPerformanceReportToolStripMenuItem
        '
        Me.InsertPerformanceReportToolStripMenuItem.Name = "InsertPerformanceReportToolStripMenuItem"
        Me.InsertPerformanceReportToolStripMenuItem.Size = New System.Drawing.Size(313, 30)
        Me.InsertPerformanceReportToolStripMenuItem.Text = "Insert Performance Report"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1072, 613)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Upload File"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtfileM
        '
        Me.txtfileM.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfileM.Location = New System.Drawing.Point(404, 623)
        Me.txtfileM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfileM.Name = "txtfileM"
        Me.txtfileM.Size = New System.Drawing.Size(531, 23)
        Me.txtfileM.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 557)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Topic "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(862, 557)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Subject Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Algerian", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(647, 65)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Upload Test File Here..."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Location = New System.Drawing.Point(1206, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 43)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ts
        '
        Me.ts.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ts.Enabled = False
        Me.ts.Location = New System.Drawing.Point(1072, 552)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(156, 23)
        Me.ts.TabIndex = 38
        '
        'Testupload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTopic)
        Me.Controls.Add(Me.txtfileM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gvfile)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Testupload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testupload"
        CType(Me.gvfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtTopic As TextBox
	Friend WithEvents gvfile As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CourseMaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScienceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MathmaticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentPerformanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertPerformanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents txtfileM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ts As TextBox
End Class

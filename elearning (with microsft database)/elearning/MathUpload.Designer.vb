<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathUpload
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
        Me.gvfile = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnmathup = New System.Windows.Forms.Button()
        Me.txtfileM = New System.Windows.Forms.TextBox()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CourseMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScienceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathmaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ms = New System.Windows.Forms.TextBox()
        CType(Me.gvfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvfile
        '
        Me.gvfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.gvfile.Location = New System.Drawing.Point(498, 221)
        Me.gvfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gvfile.Name = "gvfile"
        Me.gvfile.RowHeadersWidth = 62
        Me.gvfile.RowTemplate.Height = 28
        Me.gvfile.Size = New System.Drawing.Size(615, 266)
        Me.gvfile.TabIndex = 0
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
        Me.Column3.HeaderText = "Subject"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "File Name"
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
        'btnmathup
        '
        Me.btnmathup.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnmathup.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmathup.Location = New System.Drawing.Point(1019, 584)
        Me.btnmathup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnmathup.Name = "btnmathup"
        Me.btnmathup.Size = New System.Drawing.Size(156, 40)
        Me.btnmathup.TabIndex = 1
        Me.btnmathup.Text = "Upload File"
        Me.btnmathup.UseVisualStyleBackColor = False
        '
        'txtfileM
        '
        Me.txtfileM.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfileM.Location = New System.Drawing.Point(419, 594)
        Me.txtfileM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfileM.Name = "txtfileM"
        Me.txtfileM.Size = New System.Drawing.Size(531, 23)
        Me.txtfileM.TabIndex = 2
        '
        'txtTopic
        '
        Me.txtTopic.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.Location = New System.Drawing.Point(561, 527)
        Me.txtTopic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(190, 23)
        Me.txtTopic.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 534)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Topic "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(830, 534)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "User Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseMaterialsToolStripMenuItem, Me.MathmaticsToolStripMenuItem, Me.StudentPerformanceReportToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 35)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CourseMaterialsToolStripMenuItem
        '
        Me.CourseMaterialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScienceToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.CourseMaterialsToolStripMenuItem.Name = "CourseMaterialsToolStripMenuItem"
        Me.CourseMaterialsToolStripMenuItem.Size = New System.Drawing.Size(188, 29)
        Me.CourseMaterialsToolStripMenuItem.Text = "Learning Materials"
        '
        'ScienceToolStripMenuItem
        '
        Me.ScienceToolStripMenuItem.Name = "ScienceToolStripMenuItem"
        Me.ScienceToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
        Me.ScienceToolStripMenuItem.Text = "Exercise"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'MathmaticsToolStripMenuItem
        '
        Me.MathmaticsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MathmaticsToolStripMenuItem.Name = "MathmaticsToolStripMenuItem"
        Me.MathmaticsToolStripMenuItem.Size = New System.Drawing.Size(176, 29)
        Me.MathmaticsToolStripMenuItem.Text = "Course Materials"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Algerian", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(438, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(737, 65)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Upload Lecture Slide/File Here..."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Location = New System.Drawing.Point(1193, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 43)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ms
        '
        Me.ms.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ms.Enabled = False
        Me.ms.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms.Location = New System.Drawing.Point(1019, 527)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(156, 24)
        Me.ms.TabIndex = 30
        '
        'MathUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 704)
        Me.Controls.Add(Me.ms)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTopic)
        Me.Controls.Add(Me.txtfileM)
        Me.Controls.Add(Me.btnmathup)
        Me.Controls.Add(Me.gvfile)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MathUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Materials"
        CType(Me.gvfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvfile As DataGridView
    Friend WithEvents btnmathup As Button
    Friend WithEvents txtfileM As TextBox
    Friend WithEvents txtTopic As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CourseMaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScienceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentPerformanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertPerformanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents MathmaticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ms As TextBox
End Class

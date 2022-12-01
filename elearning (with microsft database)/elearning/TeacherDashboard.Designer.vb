<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.CourseMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ScienceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MathmaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StudentPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InsertPerformanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseMaterialsToolStripMenuItem, Me.StudentPerformanceReportToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogoutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(1530, 44)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'CourseMaterialsToolStripMenuItem
		'
		Me.CourseMaterialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScienceToolStripMenuItem, Me.MathmaticsToolStripMenuItem, Me.TestToolStripMenuItem})
		Me.CourseMaterialsToolStripMenuItem.Name = "CourseMaterialsToolStripMenuItem"
		Me.CourseMaterialsToolStripMenuItem.Size = New System.Drawing.Size(270, 40)
		Me.CourseMaterialsToolStripMenuItem.Text = "Learning Materials"
		'
		'ScienceToolStripMenuItem
		'
		Me.ScienceToolStripMenuItem.Name = "ScienceToolStripMenuItem"
		Me.ScienceToolStripMenuItem.Size = New System.Drawing.Size(335, 44)
		Me.ScienceToolStripMenuItem.Text = "Exercise"
		'
		'MathmaticsToolStripMenuItem
		'
		Me.MathmaticsToolStripMenuItem.Name = "MathmaticsToolStripMenuItem"
		Me.MathmaticsToolStripMenuItem.Size = New System.Drawing.Size(335, 44)
		Me.MathmaticsToolStripMenuItem.Text = "Course Materials"
		'
		'TestToolStripMenuItem
		'
		Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
		Me.TestToolStripMenuItem.Size = New System.Drawing.Size(335, 44)
		Me.TestToolStripMenuItem.Text = "Test"
		'
		'StudentPerformanceReportToolStripMenuItem
		'
		Me.StudentPerformanceReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertPerformanceReportToolStripMenuItem})
		Me.StudentPerformanceReportToolStripMenuItem.Name = "StudentPerformanceReportToolStripMenuItem"
		Me.StudentPerformanceReportToolStripMenuItem.Size = New System.Drawing.Size(390, 40)
		Me.StudentPerformanceReportToolStripMenuItem.Text = "Student Performance Report"
		'
		'InsertPerformanceReportToolStripMenuItem
		'
		Me.InsertPerformanceReportToolStripMenuItem.Name = "InsertPerformanceReportToolStripMenuItem"
		Me.InsertPerformanceReportToolStripMenuItem.Size = New System.Drawing.Size(454, 44)
		Me.InsertPerformanceReportToolStripMenuItem.Text = "Insert Performance Report"
		'
		'FeedbackToolStripMenuItem
		'
		Me.FeedbackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
		Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(153, 40)
		Me.FeedbackToolStripMenuItem.Text = "Feedback"
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(121, 40)
		Me.LogoutToolStripMenuItem.Text = "Logout"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Algerian", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(412, 228)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(250, 72)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Hello, "
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(14, 49)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 20)
		Me.Label3.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Algerian", 26.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(740, 231)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(387, 100)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Label4"
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(56, 49)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 20)
		Me.Label5.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(56, 69)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(131, 31)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Teacher ID :"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(250, 69)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(78, 31)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Label6"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(1130, 88)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(280, 43)
		Me.Button1.TabIndex = 9
		Me.Button1.Text = "Take attendence maths"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(1130, 152)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(280, 43)
		Me.Button3.TabIndex = 11
		Me.Button3.Text = "Take attendence science"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(54, 131)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(190, 31)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Teaching subject :"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(298, 131)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(79, 31)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "Label8"
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(1130, 205)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(354, 38)
		Me.Button2.TabIndex = 15
		Me.Button2.Text = "View Present students for science"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.elearning.My.Resources.Resources._4c1c5e30_7ec6_466e_90e7_482f78f91e42
		Me.PictureBox1.Location = New System.Drawing.Point(12, 325)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1497, 511)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(1130, 263)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(354, 35)
		Me.Button4.TabIndex = 16
		Me.Button4.Text = "View Present students for maths"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 40)
		Me.ToolStripMenuItem1.Text = "Student List"
		'
		'TeacherDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(1530, 749)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "TeacherDashboard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "TeacherDashboard"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents CourseMaterialsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ScienceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MathmaticsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StudentPerformanceReportToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InsertPerformanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
	Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherChecklist
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(1062, 540)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(142, 44)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Refresh"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 20)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "User Name "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(164, 48)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 20)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Label2"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 119)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 20)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Teacher_ID"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(141, 119)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(57, 20)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Label4"
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(308, 48)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(1043, 68)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Below Here is the Data of Registered Students..."
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(442, 540)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(162, 44)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Back"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
		Me.DataGridView1.Location = New System.Drawing.Point(283, 157)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.Size = New System.Drawing.Size(1082, 324)
		Me.DataGridView1.TabIndex = 7
		'
		'Column1
		'
		Me.Column1.HeaderText = "Student ID"
		Me.Column1.MinimumWidth = 8
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 150
		'
		'Column2
		'
		Me.Column2.HeaderText = "Firstname"
		Me.Column2.MinimumWidth = 8
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 150
		'
		'Column3
		'
		Me.Column3.HeaderText = "Lastname"
		Me.Column3.MinimumWidth = 8
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 150
		'
		'Column4
		'
		Me.Column4.HeaderText = "Date of birth"
		Me.Column4.MinimumWidth = 8
		Me.Column4.Name = "Column4"
		Me.Column4.Visible = False
		Me.Column4.Width = 150
		'
		'Column5
		'
		Me.Column5.HeaderText = "Gender"
		Me.Column5.MinimumWidth = 8
		Me.Column5.Name = "Column5"
		Me.Column5.Visible = False
		Me.Column5.Width = 150
		'
		'Column6
		'
		Me.Column6.HeaderText = "Address"
		Me.Column6.MinimumWidth = 8
		Me.Column6.Name = "Column6"
		Me.Column6.Visible = False
		Me.Column6.Width = 150
		'
		'Column7
		'
		Me.Column7.HeaderText = "Email"
		Me.Column7.MinimumWidth = 8
		Me.Column7.Name = "Column7"
		Me.Column7.Width = 150
		'
		'Column8
		'
		Me.Column8.HeaderText = "Username"
		Me.Column8.MinimumWidth = 8
		Me.Column8.Name = "Column8"
		Me.Column8.Visible = False
		Me.Column8.Width = 150
		'
		'Column9
		'
		Me.Column9.HeaderText = "Password"
		Me.Column9.MinimumWidth = 8
		Me.Column9.Name = "Column9"
		Me.Column9.Visible = False
		Me.Column9.Width = 150
		'
		'Column10
		'
		Me.Column10.HeaderText = "Phone No."
		Me.Column10.MinimumWidth = 8
		Me.Column10.Name = "Column10"
		Me.Column10.Width = 150
		'
		'TeacherChecklist
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(1615, 631)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Name = "TeacherChecklist"
		Me.Text = "Students Data"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Column5 As DataGridViewTextBoxColumn
	Friend WithEvents Column6 As DataGridViewTextBoxColumn
	Friend WithEvents Column7 As DataGridViewTextBoxColumn
	Friend WithEvents Column8 As DataGridViewTextBoxColumn
	Friend WithEvents Column9 As DataGridViewTextBoxColumn
	Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class

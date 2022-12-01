<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Learning_Materials_Maths
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ButtonLMDLoad = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(354, 115)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(490, 29)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Please Download the Required Materials"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(352, 14)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(510, 37)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Mathematics Learning Materials "
		'
		'ButtonLMDLoad
		'
		Me.ButtonLMDLoad.Location = New System.Drawing.Point(302, 675)
		Me.ButtonLMDLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ButtonLMDLoad.Name = "ButtonLMDLoad"
		Me.ButtonLMDLoad.Size = New System.Drawing.Size(213, 103)
		Me.ButtonLMDLoad.TabIndex = 16
		Me.ButtonLMDLoad.Text = "Download"
		Me.ButtonLMDLoad.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(347, 596)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(515, 26)
		Me.TextBox1.TabIndex = 15
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
		Me.DataGridView1.Location = New System.Drawing.Point(347, 165)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.Size = New System.Drawing.Size(515, 394)
		Me.DataGridView1.TabIndex = 14
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
		Me.Column3.HeaderText = "Subject "
		Me.Column3.MinimumWidth = 8
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 150
		'
		'Column4
		'
		Me.Column4.HeaderText = "File Name"
		Me.Column4.MinimumWidth = 8
		Me.Column4.Name = "Column4"
		Me.Column4.Width = 150
		'
		'Column5
		'
		Me.Column5.HeaderText = "File Data"
		Me.Column5.MinimumWidth = 8
		Me.Column5.Name = "Column5"
		Me.Column5.Visible = False
		Me.Column5.Width = 150
		'
		'Column6
		'
		Me.Column6.HeaderText = "Teacher Name"
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
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(690, 675)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(204, 103)
		Me.Button3.TabIndex = 13
		Me.Button3.Text = "Back to Main Menu"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Form_Learning_Materials_Maths
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1203, 809)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ButtonLMDLoad)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button3)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "Form_Learning_Materials_Maths"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Learning Materials Maths"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLMDLoad As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class

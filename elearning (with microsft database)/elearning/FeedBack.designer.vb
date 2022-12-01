<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFeedBack
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
        Me.ButtonFBSub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton00 = New System.Windows.Forms.RadioButton()
        Me.RadioButton01 = New System.Windows.Forms.RadioButton()
        Me.RadioButton02 = New System.Windows.Forms.RadioButton()
        Me.RadioButton03 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFBSub
        '
        Me.ButtonFBSub.Location = New System.Drawing.Point(155, 475)
        Me.ButtonFBSub.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFBSub.Name = "ButtonFBSub"
        Me.ButtonFBSub.Size = New System.Drawing.Size(112, 66)
        Me.ButtonFBSub.TabIndex = 0
        Me.ButtonFBSub.Text = "Submit"
        Me.ButtonFBSub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Feedback ID"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(101, 314)
        Me.txtdes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(472, 134)
        Me.txtdes.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(409, 475)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 66)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Back to Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Feedback Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "How Satisfied are you?"
        '
        'RadioButton00
        '
        Me.RadioButton00.AutoSize = True
        Me.RadioButton00.Location = New System.Drawing.Point(292, 19)
        Me.RadioButton00.Name = "RadioButton00"
        Me.RadioButton00.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton00.TabIndex = 12
        Me.RadioButton00.TabStop = True
        Me.RadioButton00.Text = "Very Unsatisfied"
        Me.RadioButton00.UseVisualStyleBackColor = True
        '
        'RadioButton01
        '
        Me.RadioButton01.AutoSize = True
        Me.RadioButton01.Location = New System.Drawing.Point(209, 19)
        Me.RadioButton01.Name = "RadioButton01"
        Me.RadioButton01.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton01.TabIndex = 11
        Me.RadioButton01.TabStop = True
        Me.RadioButton01.Text = "Unsatisfied"
        Me.RadioButton01.UseVisualStyleBackColor = True
        '
        'RadioButton02
        '
        Me.RadioButton02.AutoSize = True
        Me.RadioButton02.Location = New System.Drawing.Point(119, 19)
        Me.RadioButton02.Name = "RadioButton02"
        Me.RadioButton02.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton02.TabIndex = 13
        Me.RadioButton02.TabStop = True
        Me.RadioButton02.Text = "Satisfied"
        Me.RadioButton02.UseVisualStyleBackColor = True
        '
        'RadioButton03
        '
        Me.RadioButton03.AutoSize = True
        Me.RadioButton03.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton03.Name = "RadioButton03"
        Me.RadioButton03.Size = New System.Drawing.Size(89, 17)
        Me.RadioButton03.TabIndex = 14
        Me.RadioButton03.TabStop = True
        Me.RadioButton03.Text = "Very Satisfied"
        Me.RadioButton03.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "How can we Improve?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 58)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Label6"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(241, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Comment"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Report Issue"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 41)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton03)
        Me.GroupBox2.Controls.Add(Me.RadioButton02)
        Me.GroupBox2.Controls.Add(Me.RadioButton01)
        Me.GroupBox2.Controls.Add(Me.RadioButton00)
        Me.GroupBox2.Location = New System.Drawing.Point(211, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 52)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'FormFeedBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 583)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFBSub)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormFeedBack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeedBack"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonFBSub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdes As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton00 As RadioButton
    Friend WithEvents RadioButton01 As RadioButton
    Friend WithEvents RadioButton02 As RadioButton
    Friend WithEvents RadioButton03 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

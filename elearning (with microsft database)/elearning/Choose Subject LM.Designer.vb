<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose_Subject_LM
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLMS = New System.Windows.Forms.Button()
        Me.ButtonLMM = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(227, 265)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 67)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Back to Main Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Subject"
        '
        'ButtonLMS
        '
        Me.ButtonLMS.Location = New System.Drawing.Point(339, 155)
        Me.ButtonLMS.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLMS.Name = "ButtonLMS"
        Me.ButtonLMS.Size = New System.Drawing.Size(130, 67)
        Me.ButtonLMS.TabIndex = 5
        Me.ButtonLMS.Text = "Science"
        Me.ButtonLMS.UseVisualStyleBackColor = True
        '
        'ButtonLMM
        '
        Me.ButtonLMM.Location = New System.Drawing.Point(133, 155)
        Me.ButtonLMM.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLMM.Name = "ButtonLMM"
        Me.ButtonLMM.Size = New System.Drawing.Size(136, 67)
        Me.ButtonLMM.TabIndex = 4
        Me.ButtonLMM.Text = "Math"
        Me.ButtonLMM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Science"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Maths"
        Me.Label2.Visible = False
        '
        'Choose_Subject_LM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLMS)
        Me.Controls.Add(Me.ButtonLMM)
        Me.Name = "Choose_Subject_LM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Subject Learning Materials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLMS As Button
    Friend WithEvents ButtonLMM As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

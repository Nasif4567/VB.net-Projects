<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose_Subject_Test
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
        Me.ButtonTestS = New System.Windows.Forms.Button()
        Me.ButtonTestM = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 264)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 67)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Back to Main Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Choose Subject"
        '
        'ButtonTestS
        '
        Me.ButtonTestS.Location = New System.Drawing.Point(276, 154)
        Me.ButtonTestS.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTestS.Name = "ButtonTestS"
        Me.ButtonTestS.Size = New System.Drawing.Size(130, 67)
        Me.ButtonTestS.TabIndex = 9
        Me.ButtonTestS.Text = "Science"
        Me.ButtonTestS.UseVisualStyleBackColor = True
        '
        'ButtonTestM
        '
        Me.ButtonTestM.Location = New System.Drawing.Point(70, 154)
        Me.ButtonTestM.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTestM.Name = "ButtonTestM"
        Me.ButtonTestM.Size = New System.Drawing.Size(136, 67)
        Me.ButtonTestM.TabIndex = 8
        Me.ButtonTestM.Text = "Math"
        Me.ButtonTestM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Maths"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Science"
        Me.Label2.Visible = False
        '
        'Choose_Subject_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTestS)
        Me.Controls.Add(Me.ButtonTestM)
        Me.Name = "Choose_Subject_Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Subject Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTestS As Button
    Friend WithEvents ButtonTestM As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

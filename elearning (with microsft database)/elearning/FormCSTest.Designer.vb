<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCSTest
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
        Me.ButtonEXS = New System.Windows.Forms.Button()
        Me.ButtonEXM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(212, 274)
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
        Me.Label1.Location = New System.Drawing.Point(207, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Subject"
        '
        'ButtonEXS
        '
        Me.ButtonEXS.Location = New System.Drawing.Point(324, 164)
        Me.ButtonEXS.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEXS.Name = "ButtonEXS"
        Me.ButtonEXS.Size = New System.Drawing.Size(130, 67)
        Me.ButtonEXS.TabIndex = 5
        Me.ButtonEXS.Text = "Science"
        Me.ButtonEXS.UseVisualStyleBackColor = True
        '
        'ButtonEXM
        '
        Me.ButtonEXM.Location = New System.Drawing.Point(118, 164)
        Me.ButtonEXM.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEXM.Name = "ButtonEXM"
        Me.ButtonEXM.Size = New System.Drawing.Size(136, 67)
        Me.ButtonEXM.TabIndex = 4
        Me.ButtonEXM.Text = "Math"
        Me.ButtonEXM.UseVisualStyleBackColor = True
        '
        'FormCSTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 414)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEXS)
        Me.Controls.Add(Me.ButtonEXM)
        Me.Name = "FormCSTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Subject Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEXS As Button
    Friend WithEvents ButtonEXM As Button
End Class

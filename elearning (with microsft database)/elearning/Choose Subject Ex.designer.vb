<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCSEx
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
        Me.ButtonEXM = New System.Windows.Forms.Button()
        Me.ButtonEXS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEXM
        '
        Me.ButtonEXM.Location = New System.Drawing.Point(122, 113)
        Me.ButtonEXM.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEXM.Name = "ButtonEXM"
        Me.ButtonEXM.Size = New System.Drawing.Size(136, 67)
        Me.ButtonEXM.TabIndex = 0
        Me.ButtonEXM.Text = "Math"
        Me.ButtonEXM.UseVisualStyleBackColor = True
        '
        'ButtonEXS
        '
        Me.ButtonEXS.Location = New System.Drawing.Point(328, 113)
        Me.ButtonEXS.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEXS.Name = "ButtonEXS"
        Me.ButtonEXS.Size = New System.Drawing.Size(130, 67)
        Me.ButtonEXS.TabIndex = 1
        Me.ButtonEXS.Text = "Science"
        Me.ButtonEXS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose Subject"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 223)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 67)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Back to Main Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maths"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Science"
        Me.Label3.Visible = False
        '
        'FormCSEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 334)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEXS)
        Me.Controls.Add(Me.ButtonEXM)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCSEx"
        Me.Text = "Choose Subject Execise"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEXM As Button
    Friend WithEvents ButtonEXS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

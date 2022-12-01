Public Class HomePage
	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Hide()
		Teacherlogin.Show()
	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginAdmin.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormStuLogin.Show()
        Me.Hide()
    End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Application.Exit()
	End Sub
End Class

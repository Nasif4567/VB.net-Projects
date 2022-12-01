Public Class ListMenu
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        TeachersList.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentList.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ManageUsers.Show()
        Me.Hide()
    End Sub
End Class
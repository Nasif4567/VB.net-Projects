Public Class TeachersMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdateTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteTeachers.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        UserMenu.Show()
        Me.Hide()
    End Sub
End Class
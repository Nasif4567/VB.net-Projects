Public Class SCIMATHS_Attendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Amsign.Show()
        Dim name As String
        name = Label1.Text
        Amsign.Label1.Text = name



        Dim ID As String
        ID = Label2.Text
        Amsign.Label2.Text = ID

        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Assign.Show()
        Dim name As String
        name = Label1.Text
        Assign.Label1.Text = name



        Dim ID As String
        ID = Label2.Text
        Assign.Label2.Text = ID

        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormStudentMain.Show()
        Me.Hide()

    End Sub
End Class
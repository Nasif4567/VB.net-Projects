Imports System.Data.OleDb
Imports System.Data

Public Class FormStudentMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLM.Click

        Choose_Subject_LM.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonFb.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
        Dim name As String
        name = LabelMainName.Text
        FormFeedBack.Label6.Text = name
        FormFeedBack.Show()


        con.Open()
        Dim number As Integer

        Dim com As New OleDbCommand("select Max(Feedback_ID) From Feedback", con)

        If IsDBNull(com.ExecuteScalar) Then
            number = 1
            FormFeedBack.Label7.Text = number
            FormFeedBack.Show()

        Else
            number = com.ExecuteScalar + 1
            FormFeedBack.Label7.Text = number
            FormFeedBack.Show()
        End If

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEx.Click
        FormCSEx.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim ID As String
        ID = LabelStuID.Text
        Results.Label2.Text = ID

        Results.Show()
    End Sub

    Private Sub ButtonCheckInS_Click(sender As Object, e As EventArgs) Handles ButtonCheckInS.Click
        SCIMATHS_Attendance.Show()

        Dim name As String
        name = LabelMainName.Text
        SCIMATHS_Attendance.Label1.Text = name


        Dim ID As String
        ID = LabelStuID.Text
        SCIMATHS_Attendance.Label2.Text = ID
        Me.Hide()


    End Sub

    Private Sub ButtonET_Click(sender As Object, e As EventArgs) Handles ButtonET.Click
        Choose_Subject_Test.Show()
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        MsgBox("Logout Successfull")
        Me.Close()
        FormStuLogin.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Attendance_Percentage.Show()
        Dim ID As String
        ID = LabelStuID.Text
        Attendance_Percentage.Label6.Text = ID
        Me.Hide()

        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        con.Open()

        Dim cmd1 As New OleDbCommand("select count(*) from MathAttendence where StudentID=? ", con)
        cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Attendance_Percentage.Label6.Text

        Dim cmd2 As New OleDbCommand("select count(*) from SciAttendence where StudentID=? ", con)
        cmd2.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Attendance_Percentage.Label6.Text

        Dim count1 = Convert.ToInt32(cmd1.ExecuteScalar())

        Dim count2 = Convert.ToInt32(cmd2.ExecuteScalar())

        Attendance_Percentage.TextBox2.Text = count1 / 40 * 100
        Attendance_Percentage.TextBox1.Text = count2 / 40 * 100

        con.Close()
    End Sub
End Class

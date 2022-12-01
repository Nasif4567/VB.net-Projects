Imports System.Data.OleDb
Imports System.Data
Public Class TeacherDashboard
    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        Teacherfeedback.Label6.Text = name
        Dim ID As String
        ID = Label6.Text
        Teacherfeedback.Label8.Text = ID
        Dim Subjname As String
        Subjname = Label8.Text
        Teacherfeedback.fs.Text = Subjname


        Teacherfeedback.Show()


        con.Open()
        Dim number As Integer

        Dim com As New OleDbCommand("select Max(Feedback_ID) From Feedback", con)

        If IsDBNull(com.ExecuteScalar) Then
            number = 1
            Teacherfeedback.Label7.Text = number
            Teacherfeedback.Show()

        Else
            number = com.ExecuteScalar + 1
            Teacherfeedback.Label7.Text = number
            Teacherfeedback.Show()
        End If

        con.Close()
        Me.Hide()


    End Sub

    Private Sub ScienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScienceToolStripMenuItem.Click

        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        ExerciseUpload.Label6.Text = name
        ExerciseUpload.Show()

        Dim ID As String
        ID = Label6.Text
        ExerciseUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = Label8.Text
        ExerciseUpload.es.Text = Subjname
        ExerciseUpload.Show()
    End Sub

    Private Sub MathmaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathmaticsToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        MathUpload.Label3.Text = name
        MathUpload.Show()

        Dim ID As String
        ID = Label6.Text
        MathUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = Label8.Text
        MathUpload.ms.Text = Subjname
        MathUpload.Show()

    End Sub

    Private Sub InsertPerformanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertPerformanceReportToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        InsertReport.lname.Text = name
        Dim ID As String
        ID = Label6.Text
        InsertReport.Label10.Text = ID
        Dim Subjname As String
        Subjname = Label8.Text
        InsertReport.subj.Text = Subjname
        InsertReport.Show()

        con.Open()
        Dim number As Integer

        Dim com As New OleDbCommand("select Max(Report_ID) From StudentReport", con)

        If IsDBNull(com.ExecuteScalar) Then
            number = 1
            InsertReport.Label9.Text = number
            InsertReport.Show()

        Else
            number = com.ExecuteScalar + 1
            InsertReport.Label9.Text = number
            InsertReport.Show()
        End If

        con.Close()
        Me.Hide()

    End Sub

    Private Sub GenerateReportToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentPerformanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentPerformanceReportToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        MsgBox("Logout Successfull")
        Me.Close()
        Teacherlogin.Show()
    End Sub

    Private Sub CourseMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseMaterialsToolStripMenuItem.Click

    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click

        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        Testupload.Label6.Text = name
        Testupload.Show()

        Dim ID As String
        ID = Label6.Text
        Testupload.Label7.Text = ID
        Dim Subjname As String
        Subjname = Label8.Text
        Testupload.ts.Text = Subjname

        Testupload.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label8.Text = "Maths" Then
            AttendGenMaths.Show()
            Me.Hide()
        Else MsgBox("Sorry cant show , Your Teaching Subject is not Maths ")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label8.Text = "Science" Then
            AttendGenSci.Show()
            Me.Hide()
        Else MsgBox("Sorry cant show , Your Teaching Subject is not Science")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Label8.Text = "Science" Then
            Form1.Show()
            Me.Hide()
        Else MsgBox("Sorry cant show , Your Teaching Subject is not Science")
        End If



    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Label8.Text = "Maths" Then
            Form2.Show()
            Me.Hide()
        Else MsgBox("Sorry cant show , Your Teaching Subject is not Maths ")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        TeacherChecklist.Label2.Text = name


        Dim ID As String
        ID = Label6.Text
        TeacherChecklist.Label4.Text = ID
        TeacherChecklist.Show()
    End Sub
End Class
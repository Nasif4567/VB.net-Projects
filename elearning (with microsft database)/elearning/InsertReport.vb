Imports System.Data.OleDb
Imports System.String
Public Class InsertReport
	Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
	Public Dad As OleDbDataAdapter
	Public Drd As OleDbDataReader
	Public Cmd As OleDbCommand
	Public Dst = New DataSet
	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If subj.Text = Nothing Or sname.Text = Nothing Or txtmark.Text = Nothing Or remark.Text = Nothing Or topic.Text = Nothing Then
            MessageBox.Show("Please fill the boxes")
        ElseIf (txtmark.Text > 100) Then
            MessageBox.Show("Insert Marks between 0 To 100")
            txtmark.Clear()
            grade.Clear()
        ElseIf (txtmark.Text < 0) Then
            MessageBox.Show("Insert Marks between 0 To 100")
            txtmark.Clear()
            grade.Clear()
        End If
        Dim Marks As String
        Marks = txtmark.Text
        Select Case Marks

            Case 90 To 100
                grade.Text = "A"
            Case 80 To 89.99
                grade.Text = "B"

            Case 70 To 79.99
                grade.Text = "C"
            Case 60 To 69.99
                grade.Text = "D"
            Case 50 To 59.99
                grade.Text = "Pass"
            Case 0 To 49.99
                grade.Text = "Fail"

        End Select

        Dim Str As String



            Try

                Str = "Insert into StudentReport values("
                Str += """" & Label9.Text.Trim() & """"
                Str += ","
                Str += """" & subj.Text.Trim() & """"
                Str += ","
                Str += """" & sname.Text.Trim() & """"
                Str += ","
                Str += """" & txtmark.Text.Trim() & """"
                Str += ","
                Str += """" & grade.Text.Trim() & """"
                Str += ","
                Str += """" & remark.Text.Trim() & """"
                Str += ","
                Str += """" & lname.Text.Trim() & """"
                Str += ","
            Str += """" & topic.Text.Trim() & """"
            Str += ","
            Str += """" & Label10.Text.Trim() & """"
            Str += ")"
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                Dst.Clear()
                Dad = New OleDbDataAdapter("SELECT * FROM StudentReport ORDER BY Report_ID", Con)
                Dad.Fill(Dst, "StudentReport")
                MsgBox("Report Submitted successfully...")

                sname.Clear()
                txtmark.Clear()
                remark.Clear()
                grade.Clear()
                topic.Clear()
                Con.Close()
            Catch ex As Exception
                MessageBox.Show("Report send Failed!!!")

                Con.Close()
            End Try


    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HomePage.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        sname.Clear()
        txtmark.Clear()
        remark.Clear()
        topic.Clear()

    End Sub

    Private Sub FeedbackToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = lname.Text
        Teacherfeedback.Label6.Text = name
        Dim ID As String
        ID = Label10.Text
        Teacherfeedback.Label8.Text = ID
        Dim Subjname As String
        Subjname = subj.Text
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
        name = lname.Text
        ExerciseUpload.Label6.Text = name
        Dim ID As String
        ID = Label10.Text
        ExerciseUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = subj.Text
        ExerciseUpload.es.Text = Subjname
        ExerciseUpload.Show()
    End Sub

    Private Sub MathmaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathmaticsToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = lname.Text
        MathUpload.Label3.Text = name
        Dim ID As String
        ID = Label10.Text
        MathUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = subj.Text
        MathUpload.ms.Text = Subjname
        MathUpload.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = lname.Text
        Testupload.Label6.Text = name
        Dim ID As String
        ID = Label10.Text
        Testupload.Label7.Text = ID
        Dim Subjname As String
        Subjname = subj.Text
        Testupload.ts.Text = Subjname
        Testupload.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        MsgBox("Logout Successfull")
        Me.Close()
        Teacherlogin.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub grade_TextChanged(sender As Object, e As EventArgs) Handles grade.TextChanged

    End Sub





    Private Sub txtmark_TextChanged(sender As Object, e As EventArgs) Handles txtmark.TextChanged

    End Sub
End Class
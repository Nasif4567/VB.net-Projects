Imports System.Data.OleDb
Imports System.String
Public Class Teacherfeedback
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
    Public Dad As OleDbDataAdapter
	Public Drd As OleDbDataReader
	Public Cmd As OleDbCommand
	Public Dst = New DataSet
	Dim type1 As String
	Dim level1 As String
	Public CurrentRow As Integer
	Dim query As String
	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub txtsubmit_Click(sender As Object, e As EventArgs) Handles txtsubmit.Click
		If RadioButton1.Text = Nothing Or RadioButton2.Text = Nothing Or RadioButton3.Text = Nothing Or RadioButton4.Text = Nothing Or RadioButton5.Text = Nothing Or RadioButton6.Text = Nothing Or descrip.Text = Nothing Then
			MessageBox.Show("Please fill in the boxes")
		End If

		Dim Str As String


		Try

            Str = "insert into Feedback values("
            Str += """" & Label7.Text.Trim() & """"
            Str += ","
            Str += """" & Label6.Text.Trim() & """"
            Str += ","

            If RadioButton1.Checked = True Then
				Str += """" & RadioButton1.Text.Trim() & """"
				Str += ","
			ElseIf RadioButton2.Checked = True Then
				Str += """" & RadioButton2.Text.Trim() & """"
				Str += ","
			End If
			If RadioButton3.Checked = True Then
				Str += """" & RadioButton3.Text.Trim() & """"
				Str += ","
			ElseIf RadioButton4.Checked = True Then
				Str += """" & RadioButton4.Text.Trim() & """"
				Str += ","
			ElseIf RadioButton5.Checked = True Then
				Str += """" & RadioButton5.Text.Trim() & """"
				Str += ","
			ElseIf RadioButton6.Checked = True Then
				Str += """" & RadioButton6.Text.Trim() & """"
				Str += ","
			End If

			Str += """" & descrip.Text.Trim() & """"

			Str += ")"
			Con.Open()
			Cmd = New OleDbCommand(Str, Con)
			Cmd.ExecuteNonQuery()
			Dst.Clear()
			Dad = New OleDbDataAdapter("SELECT * FROM Feedback ORDER BY Feedback_ID", Con)
			Dad.Fill(Dst, "Feedback")
			MsgBox("Your Feedback has been submitted...")
			descrip.Clear()

			Con.Close()
		Catch ex As Exception
			MessageBox.Show("Feedback sent Failed")

			Con.Close()
        End Try




    End Sub

    Private Sub types(sender As Object, e As EventArgs) Handles RadioButton2.Click, RadioButton1.Click
		If RadioButton1.Checked = True Then
			type1 = RadioButton1.Text
		ElseIf RadioButton2.Checked = True Then
			type1 = RadioButton2.Text
		End If
	End Sub

	Private Sub level(sender As Object, e As EventArgs) Handles RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click
		If RadioButton3.Checked = True Then
			level1 = RadioButton3.Text
		ElseIf RadioButton4.Checked = True Then
			level1 = RadioButton4.Text
		ElseIf RadioButton5.Checked = True Then
			level1 = RadioButton5.Text
		ElseIf RadioButton6.Checked = True Then
			level1 = RadioButton6.Text
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		descrip.Clear()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Application.Exit()
	End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Me.Hide()
		HomePage.Show()
	End Sub

	Private Sub ScienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScienceToolStripMenuItem.Click
		Me.Hide()
		Me.Hide()
		Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
		Dim name As String
		name = Label6.Text
		ExerciseUpload.Label6.Text = name
		Dim ID As String
		ID = Label8.Text
		ExerciseUpload.Label7.Text = ID
		Dim Subjname As String
		Subjname = fs.Text
		ExerciseUpload.es.Text = Subjname

		ExerciseUpload.Show()
	End Sub

	Private Sub MathmaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathmaticsToolStripMenuItem.Click
		Me.Hide()
		Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
		Dim name As String
		name = Label6.Text
		MathUpload.Label3.Text = name
		Dim ID As String
		ID = Label8.Text
		MathUpload.Label7.Text = ID
		Dim Subjname As String
		Subjname = fs.Text
		MathUpload.ms.Text = Subjname
		MathUpload.Show()

	End Sub

	Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
		Me.Hide()
		Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
		Dim name As String
		name = Label6.Text
		Testupload.Label6.Text = name
		Dim ID As String
		ID = Label8.Text
		Testupload.Label7.Text = ID
		Dim Subjname As String
		Subjname = fs.Text
		Testupload.ts.Text = Subjname
		Testupload.Show()
	End Sub

	Private Sub InsertPerformanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertPerformanceReportToolStripMenuItem.Click
		Me.Hide()
		Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
		Dim name As String
		name = Label6.Text
		InsertReport.lname.Text = name
		Dim ID As String
		ID = Label8.Text
		InsertReport.Label10.Text = ID
		Dim Subjname As String
		Subjname = fs.Text
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

	Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click

	End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub

	Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
		MsgBox("Logout Successfull")
		Me.Close()
		Teacherlogin.Show()
	End Sub
End Class
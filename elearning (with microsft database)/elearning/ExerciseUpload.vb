Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq
Public Class ExerciseUpload
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String
    Dim FilePathName As String

    Dim fileName As String

    Private Sub SaveFileToDB(filePath As String)

        Dim file As Byte()
            Dim stream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim reader As New BinaryReader(stream)
            file = reader.ReadBytes(Convert.ToInt32(stream.Length))




            query = "Insert Into ExerciseMaterials(Topic,SubjectName,ExerciseFile,FileData,TeacherName,Teacher_ID) Values(@Topic,@SubjectName,@ExerciseFile,@FileData,@TeacherName,@Teacher_ID)"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.Add("@Topic", OleDbType.VarWChar).Value = txtTopic.Text
        cmd.Parameters.Add("@SubjectName", OleDbType.VarWChar).Value = es.Text
        cmd.Parameters.Add("@ExerciseFile", OleDbType.VarWChar).Value = fileName
            cmd.Parameters.Add("@FileData", OleDbType.VarBinary).Value = file.ToArray()
            cmd.Parameters.Add("@TeacherName", OleDbType.VarWChar).Value = Label6.Text
            cmd.Parameters.Add("@Teacher_ID", OleDbType.VarWChar).Value = Label7.Text

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            txtfileM.Clear()
        txtTopic.Clear()


        MessageBox.Show("File Saved Successfully To DataBase", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadData()
        gvfile.Rows.Clear()
        Dim command As New OleDbCommand("select * from ExerciseMaterials where Teacher_ID =@Teacher_ID", con)
        command.Parameters.Add("@Teacher_ID", OleDbType.VarChar).Value = Label7.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("ExerciseMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            gvfile.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub
    Private Sub btnmathup_Click(sender As Object, e As EventArgs) Handles btnmathup.Click
        Dim OFD As New OpenFileDialog

        If OFD.ShowDialog() = DialogResult.OK Then
            FilePathName = OFD.FileName
            fileName = Path.GetFileName(FilePathName)
            txtfileM.Text = FilePathName
        End If
        If es.Text = Nothing Or txtTopic.Text = Nothing Then
            MessageBox.Show("Please fill the Textbox")
        Else


            SaveFileToDB(FilePathName)
        End If
        LoadData()



    End Sub



    Private Sub MathmaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathmaticsToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label6.Text
        MathUpload.Label3.Text = name


        Dim ID As String
        ID = Label7.Text
        MathUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = es.Text
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
        ID = Label7.Text
        Testupload.Label7.Text = ID
        Dim Subjname As String
        Subjname = es.Text
        Testupload.ts.Text = Subjname
        Testupload.Show()
    End Sub

    Private Sub StudentPerformanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentPerformanceReportToolStripMenuItem.Click

    End Sub

    Private Sub InsertPerformanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertPerformanceReportToolStripMenuItem.Click
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label6.Text
        InsertReport.lname.Text = name
        Dim ID As String
        ID = Label7.Text
        InsertReport.Label10.Text = ID
        Dim Subjname As String
        Subjname = es.Text
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
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label4.Text
        Teacherfeedback.Label6.Text = name
        Dim ID As String
        ID = Label7.Text
        Teacherfeedback.Label8.Text = ID
        Dim Subjname As String
        Subjname = es.Text
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        MsgBox("Logout Successfull")
        Me.Close()
        Teacherlogin.Show()
    End Sub

    Private Sub ExerciseUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub
End Class
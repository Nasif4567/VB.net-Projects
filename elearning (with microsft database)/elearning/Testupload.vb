Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq
Public Class Testupload
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

        query = "Insert Into TestMaterials(Topic,SubjectName,TestFile,FileData,TeacherName,Teacher_ID) Values(@Topic,@SubjectName,@TestFile,@FileData,@TeacherName,Teacher_ID)"
        cmd = New OleDbCommand(query, con)
        cmd.Parameters.Add("@Topic", OleDbType.VarWChar).Value = txtTopic.Text
        cmd.Parameters.Add("@SubjectName", OleDbType.VarWChar).Value = ts.Text
        cmd.Parameters.Add("@TestFile", OleDbType.VarWChar).Value = fileName
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
        Dim command As New OleDbCommand("select * from TestMaterials where Teacher_ID =@ID", con)
        command.Parameters.Add("@ID", OleDbType.VarChar).Value = Label7.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("TestMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            gvfile.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo)
        MsgBox("Logout Successfull")
        Me.Close()
        Teacherlogin.Show()
    End Sub

    Private Sub btnmathup_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog

        If OFD.ShowDialog() = DialogResult.OK Then
            FilePathName = OFD.FileName
            fileName = Path.GetFileName(FilePathName)
            txtfileM.Text = FilePathName
        End If
        If ts.Text = Nothing Or txtTopic.Text = Nothing Then
            MessageBox.Show("Please fill the Textbox")
        Else
            SaveFileToDB(FilePathName)
        End If
        LoadData()
    End Sub

    Private Sub Testupload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub gvfile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvfile.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click

    End Sub

    Private Sub txtTopic_TextChanged(sender As Object, e As EventArgs) Handles txtTopic.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtSubjname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScienceToolStripMenuItem.Click
        Me.Hide()
        Me.Hide()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
        Dim name As String
        name = Label6.Text
        ExerciseUpload.Label6.Text = name

        Dim ID As String
        ID = Label7.Text
        ExerciseUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = ts.Text
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
        ID = Label7.Text
        MathUpload.Label7.Text = ID
        Dim Subjname As String
        Subjname = ts.Text
        MathUpload.ms.Text = Subjname
        MathUpload.Show()
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
        Subjname = ts.Text
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
        name = Label6.Text
        Teacherfeedback.Label6.Text = name
        Dim ID As String
        ID = Label7.Text
        Teacherfeedback.Label8.Text = ID
        Dim Subjname As String
        Subjname = ts.Text
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub
End Class
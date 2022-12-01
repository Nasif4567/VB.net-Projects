Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq
Public Class FormExamTestMaths
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String
    Dim FilePathName As String
    Dim DirPathName As String
    Dim fileName As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DownloadFile(NewFileLocation As String)
        Try
            NewFileLocation = DirPathName
            Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())
            query = "Select * From TestMaterials Where TestMaterials_ID=@Id"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.Add("@Id", OleDbType.Integer).Value = id
            da = New OleDbDataAdapter(cmd)
            dt = New DataTable("TestMaterials")
            dt.Clear()
            da.Fill(dt)

            For Each row As DataRow In dt.Rows

                Dim filebyte As Byte() = row(4)
                Dim fs As New FileStream(NewFileLocation & "\" & row(3), FileMode.Create, FileAccess.Write)
                fs.Write(filebyte, 0, filebyte.Length)
                fs.Close()
            Next
            TextBox1.Clear()
            MessageBox.Show("File Downloaded Successfully", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try


    End Sub
    Private Sub ButtonMathsTDL_Click(sender As Object, e As EventArgs) Handles ButtonMathsTDL.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog() = DialogResult.OK Then
            DirPathName = FBD.SelectedPath
            TextBox1.Text = DirPathName
        End If
        DownloadFile(DirPathName)
    End Sub
End Class
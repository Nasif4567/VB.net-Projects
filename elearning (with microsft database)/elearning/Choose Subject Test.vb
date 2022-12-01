Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq
Public Class Choose_Subject_Test
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String
    Dim FilePathName As String
    Private Sub ButtonLMM_Click(sender As Object, e As EventArgs) Handles ButtonTestM.Click
        FormExamTestMaths.Show()
        Me.Hide()
        LoadData3()

    End Sub

    Private Sub Load3()
        FormExamTestSci.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from TestMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label2.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("TestMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            FormExamTestSci.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub LoadData3()
        FormExamTestMaths.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from TestMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label3.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("TestMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            FormExamTestMaths.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub ButtonLMS_Click(sender As Object, e As EventArgs) Handles ButtonTestS.Click
        FormExamTestSci.Show()
        Me.Hide()
        Load3()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
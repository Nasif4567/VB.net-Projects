Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq
Public Class Choose_Subject_LM
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String
    Dim FilePathName As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Load2()
        FormLearnMSci.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from LearningMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label3.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("LearningMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            FormLearnMSci.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub LoadData2()
        Form_Learning_Materials_Maths.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from LearningMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label2.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("LearningMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Form_Learning_Materials_Maths.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub ButtonLMM_Click(sender As Object, e As EventArgs) Handles ButtonLMM.Click
        Form_Learning_Materials_Maths.Show()
        Me.Hide()
        LoadData2()
    End Sub

    Private Sub ButtonLMS_Click(sender As Object, e As EventArgs) Handles ButtonLMS.Click
        FormLearnMSci.Show()
        Me.Hide()
        Load2()
    End Sub


End Class
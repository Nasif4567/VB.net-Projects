Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Data.Linq


Public Class FormCSEx

    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String
    Dim FilePathName As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub Load1()
        Exercise_Sci.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from ExerciseMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label3.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("ExerciseMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Exercise_Sci.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub LoadData()
        Exercise_Maths.DataGridView1.Rows.Clear()
        Dim command As New OleDbCommand("select * from ExerciseMaterials where SubjectName =@Subject", con)
        command.Parameters.Add("@Subject", OleDbType.VarChar).Value = Label2.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("ExerciseMaterials")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Exercise_Maths.DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEXM.Click
        Exercise_Maths.Show()
        Me.Hide()
        LoadData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEXS.Click
        Exercise_Sci.Show()
        Load1()
        Me.Hide()
    End Sub

End Class
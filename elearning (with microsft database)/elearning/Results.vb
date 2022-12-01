Imports System.Data.OleDb
Imports System.Data
Public Class Results
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private Sub LoadData()
        dgv.Rows.Clear()
        Dim command As New OleDbCommand("select * from StudentReport where Student_ID =@ID", con)
        command.Parameters.Add("@ID", OleDbType.VarChar).Value = Label2.Text
        da = New OleDbDataAdapter(command)
        dt = New DataTable("StudentReport")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            dgv.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4), row(5), row(6))
        Next
    End Sub



    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormStudentMain.Show()
    End Sub
End Class
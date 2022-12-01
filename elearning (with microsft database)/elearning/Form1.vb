Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        Dim da As OleDbDataAdapter
        Dim dt As DataTable


        DataGridView1.Rows.Clear()
        Dim check As New OleDbCommand("select * from SciAttendence where Date =? ", con)
        check.Parameters.Add(New OleDbParameter("Date", CType(DateTimePicker1.Text, Date)))
        da = New OleDbDataAdapter(check)
        dt = New DataTable("SciAttendence")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            DataGridView1.Rows.Add(row(0).ToString(), row(1), row(2), row(3), row(4))
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub
End Class
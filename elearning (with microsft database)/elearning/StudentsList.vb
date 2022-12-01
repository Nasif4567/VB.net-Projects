
Imports System.Data.OleDb
Imports System.Data



Public Class StudentList


    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Private Sub LoadData()

        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        DataGridView1.Rows.Clear()
        query = "Select * From Students"
        da = New OleDbDataAdapter(query, con)
        dt = New DataTable("Students")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        ListMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub
End Class
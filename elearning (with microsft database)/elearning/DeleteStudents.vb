Imports System.Data.OleDb
Imports System.Data

Public Class DeleteStudents
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Please Insert ID !")
        Else
            If con.State = ConnectionState.Closed Then

                con.Open()

            End If

            Dim command As New OleDbCommand("Delete from [Students] where Student_ID =@ID", con)
            command.Parameters.Add("@ID", OleDbType.VarChar).Value = TextBox1.Text

            If command.ExecuteNonQuery() Then
                MsgBox("Successfully deleted")
                con.Close()
                LoadData()
                TextBox1.Clear()


            Else MsgBox("Delete unsuccessfull")
            End If
        End If

    End Sub

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

    Private Sub DeleteStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        StudentMenu.Show()
        Me.Hide()
    End Sub
End Class
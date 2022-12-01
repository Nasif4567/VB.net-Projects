Imports System.Data.OleDb
Imports System.Data


Public Class ViewFeedbacks
    Private Sub LoadData()

        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        DataGridView1.Rows.Clear()
        query = "Select * From Feedback"
        da = New OleDbDataAdapter(query, con)
        dt = New DataTable("Teachers")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4))
        Next
    End Sub
    Private Sub ViewFeedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        If idtxt.Text = Nothing Then

            MsgBox("Please insert ID !!")

        Else
            con.Open()
            Dim cmd As New OleDbCommand("select count(*) from Feedback where Feedback_ID=?", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = idtxt.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count = 0) Then
                MsgBox("No ID found")
                con.Close()
            ElseIf (count > 0) Then



                Dim command As New OleDbCommand("select * from Feedback where Feedback_ID =@ID", con)
                command.Parameters.Add("@ID", OleDbType.VarChar).Value = idtxt.Text
                Dim adapter2 As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter2.Fill(table)



                TextBox1.Text = table.Rows(0)(1)
                TextBox3.Text = table.Rows(0)(4)
                TextBox2.Text = table.Rows(0)(3)
                TextBox4.Text = table.Rows(0)(2)

                con.Close()

            End If

        End If

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        ManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
End Class
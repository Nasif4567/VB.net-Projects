
Imports System.Data.OleDb
Imports System.Data

Public Class UpdateStudents

    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If idtxt.Text = Nothing Then

            MsgBox("Please insert ID !!")

        Else
            con.Open()
            Dim cmd As New OleDbCommand("select count(*) from Students where Student_ID=?", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = idtxt.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count = 0) Then
                MsgBox("No ID found")
                con.Close()
            ElseIf (count > 0) Then





                Dim command As New OleDbCommand("select * from Students where Student_ID =@ID", con)
                command.Parameters.Add("@ID", OleDbType.VarChar).Value = idtxt.Text
                Dim adapter2 As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter2.Fill(table)



                fnametxt.Text = table.Rows(0)(1)
                lnametxt.Text = table.Rows(0)(2)
                DateTimePicker1.Text = table.Rows(0)(3)
                ComboBox1.Text = table.Rows(0)(4)
                addresstxt.Text = table.Rows(0)(5)
                emailtxt.Text = table.Rows(0)(6)
                usernametxt.Text = table.Rows(0)(7)
                passwordtxt.Text = table.Rows(0)(8)
                phonetxt.Text = table.Rows(0)(9)



            End If
            con.Close()
        End If

    End Sub

    Private Sub Addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If fnametxt.Text = Nothing Or lnametxt.Text = Nothing Or addresstxt.Text = Nothing Or ComboBox1.Text = Nothing Or idtxt.Text = Nothing Or emailtxt.Text = Nothing Or usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Or Me.phonetxt.Text = Nothing Then
            MsgBox("please fill up the form")
        Else
            If con.State = ConnectionState.Closed Then

                con.Open()

            End If


            Dim command As New OleDbCommand("UPDATE [Students] SET [Firstname] = '" & fnametxt.Text & "' ,[Lastname] = '" & lnametxt.Text & "', [DOB] = '" & DateTimePicker1.Text & "' ,[Gender] = '" & ComboBox1.Text & "' ,[Address] = '" & addresstxt.Text & "' ,[Email] = '" & emailtxt.Text & "',[Username] = '" & usernametxt.Text & "' ,[Password] = '" & passwordtxt.Text & "',[Phone] = '" & phonetxt.Text & "'  WHERE [Student_ID] ='" & idtxt.Text & "' ", con)




            If command.ExecuteNonQuery() Then

                MsgBox("Updated successfully")
                con.Close()
                idtxt.Clear()
                fnametxt.Clear()
                lnametxt.Clear()
                addresstxt.Clear()
                emailtxt.Clear()
                usernametxt.Clear()
                passwordtxt.Clear()
                phonetxt.Clear()
                LoadData()


            Else MsgBox("unsuccessfull")



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

    Private Sub UpdateStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        StudentMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
End Class
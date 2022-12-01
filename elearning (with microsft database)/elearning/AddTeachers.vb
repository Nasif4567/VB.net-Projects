


Imports System.Data.OleDb
Imports System.Data

Public Class AddTeachers

    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Private Sub LoadData()

        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        DataGridView1.Rows.Clear()
        query = "Select * From Teachers"
        da = New OleDbDataAdapter(query, con)
        dt = New DataTable("Teachers")
        dt.Clear()
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
        Next
    End Sub
    Private Sub AddTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()


    End Sub

    Private Sub Addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If fnametxt.Text = Nothing Or lnametxt.Text = Nothing Or addresstxt.Text = Nothing Or ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Or idtxt.Text = Nothing Or emailtxt.Text = Nothing Or usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Or Me.phonetxt.Text = Nothing Then
            MsgBox("please fill up the form")
        ElseIf Me.phonetxt.TextLength < 10 Or Me.phonetxt.TextLength > 10 Then
            MsgBox("Please entervalid phone number,Number must be 10 digits")
        Else
            If con.State = ConnectionState.Closed Then

                con.Open()

            End If

            Dim cmd As New OleDbCommand("Insert into Teachers ([Firstname],[Lastname],[DOB],[Address],[Gender],[Subject],[Teacher_ID],[Email],[Username],[Password],[Phone]) Values(?,?,?,?,?,?,?,?,?,?,?) ", con)
            Dim check As New OleDbCommand("SELECT * from [Teachers] where [Teacher_ID] =@ID ", con)

            check.Parameters.AddWithValue("@ID", idtxt.Text)




            cmd.Parameters.Add(New OleDbParameter("Firstname", CType(fnametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Lastname", CType(lnametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(DateTimePicker1.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(addresstxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(ComboBox1.SelectedItem, String)))
            cmd.Parameters.Add(New OleDbParameter("Subject", CType(ComboBox2.SelectedItem, String)))
            cmd.Parameters.Add(New OleDbParameter("ID", CType(idtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(emailtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Username", CType(usernametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(passwordtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Phone", CType(phonetxt.Text, Integer)))


            Dim dr As OleDbDataReader
                dr = check.ExecuteReader()


            If dr.HasRows Then
                MsgBox("User already Exist !")

            Else cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MsgBox("Successfully inserted")
                idtxt.Clear()
                fnametxt.Clear()
                lnametxt.Clear()
                addresstxt.Clear()

                emailtxt.Clear()
                usernametxt.Clear()
                passwordtxt.Clear()
                phonetxt.Clear()
                LoadData()

            End If
        End If














    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles idtxt.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        TeachersMenu.Show()
        Me.Hide()
    End Sub

    Private Sub AddedGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'Database_for_E_learning_systemDataSet16.Teachers' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
End Class
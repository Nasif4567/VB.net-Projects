

Imports System.Data.OleDb
Imports System.Data


Public Class AddStudents
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
    Private Sub AddStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()



    End Sub

    Private Sub Addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If fnametxt.Text = Nothing Or lnametxt.Text = Nothing Or addresstxt.Text = Nothing Or ComboBox1.Text = Nothing Or idtxt.Text = Nothing Or emailtxt.Text = Nothing Or usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Or Me.phonetxt.Text = Nothing Then
            MsgBox("please fill up the form")
        ElseIf Me.phonetxt.TextLength < 10 Or Me.phonetxt.TextLength > 10 Then
            MsgBox("Please entervalid phone number,Number must be 10 digits")
        Else
            If con.State = ConnectionState.Closed Then

                con.Open()

            End If





            Dim cmd As New OleDbCommand("Insert into Students ([Firstname],[Lastname],[DOB],[Gender],[Address],[Student_ID],[Email],[Username],[Password],[Phone]) Values(?,?,?,?,?,?,?,?,?,?) ", con)
            Dim check As New OleDbCommand("SELECT * from [Students] where [Student_ID] =@ID ", con)


            cmd.Parameters.Add(New OleDbParameter("Firstname", CType(fnametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("lastname", CType(fnametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(DateTimePicker1.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(addresstxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(ComboBox1.SelectedItem, String)))
            cmd.Parameters.Add(New OleDbParameter("ID", CType(idtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(emailtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Username", CType(usernametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(passwordtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Phone", CType(phonetxt.Text, Integer)))
            check.Parameters.AddWithValue("@ID", idtxt.Text)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Num_TextChanged(sender As Object, e As EventArgs) Handles phonetxt.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        StudentMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
End Class
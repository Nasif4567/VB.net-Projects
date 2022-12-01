Imports System.Data.OleDb
Imports System.Data
Public Class Assign
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormStudentMain.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        If TextBox1.Text = Nothing Then
            MsgBox("Please Enter Attendece number !!")

        Else
            If con.State = ConnectionState.Closed Then

                con.Open()

            End If


            Dim command As New OleDbCommand("select * from AttendenceDateScience where code =@code", con)

            Dim cmd As New OleDbCommand("Insert into SciAttendence([Code],[StudentID],[Student Name],[Date]) Values(?,?,?,?)", con)
            cmd.Parameters.Add(New OleDbParameter("code", CType(TextBox1.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("StudentID", CType(Label2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Student_Name", CType(Label1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date", CType(DateTimePicker1.Text, Date)))

            command.Parameters.Add("@code", OleDbType.Integer).Value = TextBox1.Text
            Dim adapter2 As New OleDbDataAdapter(command)
            Dim table As New DataTable()
            adapter2.Fill(table)

            Dim cmd1 As New OleDbCommand("select count(*) from SciAttendence where StudentID=? and Code=?", con)
            cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Label2.Text
            cmd1.Parameters.AddWithValue("@2", OleDbType.Integer).Value = TextBox1.Text

            Dim count = Convert.ToInt32(cmd1.ExecuteScalar())




            Try





                If (count > 0) Then
                    MsgBox("Already updated")


                ElseIf TextBox1.Text = table.Rows(0)(1) And DateTimePicker1.Text = table.Rows(0)(2) Then

                    cmd.ExecuteNonQuery()
                    MsgBox("Attendence successfully updated")
                    con.Close()

                Else
                    MsgBox("Please enter today's attendence code")


                End If


            Catch ex As Exception
                MsgBox("Failed to update attendece")
            End Try


        End If
    End Sub

    Private Sub Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            Me.ToolTip1.SetToolTip(TextBox1, "The Attendence code must be number")
            TextBox1.Text = Nothing

        End If
    End Sub
End Class
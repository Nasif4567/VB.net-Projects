Imports System.Data.OleDb
Imports System.Data

Public Class FormStuLogin
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles ButtonSignIn.Click
        If usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Then
            MsgBox("Please enter username and password")
        Else

            If con.State = ConnectionState.Closed Then

                con.Open()

            End If




            Dim cmd As New OleDbCommand("select count(*) from Students where Username=? and Password=?", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = usernametxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = passwordtxt.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())


            If (count = 0) Then
                MsgBox("Please enter valid username")

            ElseIf (count > 0) Then

                Dim command As New OleDbCommand("select * from Students where Username =@Username", con)
                command.Parameters.Add("@Username", OleDbType.VarChar).Value = usernametxt.Text
                Dim adapter2 As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter2.Fill(table)



                FormStudentMain.LabelMainName.Text = table.Rows(0)(1)
                FormStudentMain.LabelStuID.Text = table.Rows(0)(0)

                MsgBox("login successfull")
                con.Close()
                FormStudentMain.Show()
                FormStudentMain.LabelMainName.Text = table.Rows(0)(2)
                Me.Hide()



            End If
        End If

    End Sub

    Private Sub FormStuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomePage.Show()
        Me.Hide()
    End Sub
End Class

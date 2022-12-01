

Imports System.Data.OleDb
Imports System.Data

Public Class LoginAdmin

    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Then
            MsgBox("Please enter username and password")
        Else

            If con.State = ConnectionState.Closed Then

                con.Open()

            End If




            Dim cmd As New OleDbCommand("select count(*) from Admin where Username=? and Password=?", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = usernametxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = passwordtxt.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())


            If (count = 0) Then
                MsgBox("Please enter valid username")

            ElseIf (count > 0) Then

                MsgBox("login successfull")
                usernametxt.Clear()
                passwordtxt.Clear()
                con.Close()
                ManageUsers.Show()
                Me.Hide()



            End If
        End If
    End Sub

    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        HomePage.Show()
        Me.Hide()
    End Sub
End Class

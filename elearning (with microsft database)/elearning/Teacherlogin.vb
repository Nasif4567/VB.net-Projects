Option Explicit On
Imports System.Data.OleDb
Public Class Teacherlogin
    Dim objCon As New OleDbConnection
    Dim strSQL As String
    Dim strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim Attempt As Integer = 0
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim warning As String = "Warning!"
        If (username.Text = "") And (password.Text = "") Then
            Attempt = Attempt + 1
            MsgBox("please enter your username and password!")
        ElseIf (username.Text = "") Then
            Attempt = Attempt + 1
            MsgBox("please enter your username and password!")

        ElseIf (password.Text = "") Then
            MsgBox("please enter your username and password!")
        Else
            Dim strName = username.Text
            Dim strpass = password.Text

            With objCon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnection
                    .Open()


                End If
            End With

            ds.Clear()
            strSQL = "Select * From Teachers where Username ='" & username.Text & "'And password ='" & password.Text & "'"
            da = New OleDbDataAdapter(strSQL, objCon)
            da.Fill(ds, "Teachers")

            If ds.Tables("Teachers").Rows.Count <> 0 Then

                Dim command As New OleDbCommand("select * from Teachers where Username =@Username", objCon)
                command.Parameters.Add("@Username", OleDbType.VarChar).Value = username.Text
                Dim adapter2 As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter2.Fill(table)





                MsgBox("Hello! " + strName + vbNewLine +
                       "Log in successful", MsgBoxStyle.OkOnly,
                       "Welcome" + strName)
                password.Text = ""
                username.Text = ""
                TeacherDashboard.Show()
                TeacherDashboard.Label4.Text = table.Rows(0)(8)
                TeacherDashboard.Label6.Text = table.Rows(0)(0)
                TeacherDashboard.Label8.Text = table.Rows(0)(6)
                Me.Hide()

            Else
                MaximizeBox = False
                MinimizeBox = False
                Attempt = Attempt +
                    MsgBox(" Oops, The username or password you entered is invalid")
            End If



        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HomePage.Show()
    End Sub
End Class
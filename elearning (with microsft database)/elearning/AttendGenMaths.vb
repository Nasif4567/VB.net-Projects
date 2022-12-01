Imports System.Data.OleDb
Imports System.Data
Public Class AttendGenMaths
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        Dim check As New OleDbCommand("select * from AttendenceDateMaths where date1 =? ", con)
        check.Parameters.Add(New OleDbParameter("date1", CType(DateTimePicker1.Text, Date)))

        con.Open()
        Dim number As Integer
        Dim com As New OleDbCommand("select Max(code) From AttendenceDateMaths", con)

        Dim dr As OleDbDataReader
        dr = check.ExecuteReader()



        If dr.HasRows Then
            MsgBox("This date's Attendence code has already been registered !")

        ElseIf IsDBNull(com.ExecuteScalar) Then
            number = 1
            AttendMathreg.number.Text = number
            AttendMathreg.Label2.Text = DateTimePicker1.Text
            AttendMathreg.Show()
            Me.Hide()

        Else
            number = com.ExecuteScalar + 4
            AttendMathreg.number.Text = number
            AttendMathreg.Label2.Text = DateTimePicker1.Text
            AttendMathreg.Show()
            Me.Hide()
        End If

        con.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AttendGenMaths_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub
End Class
Imports System.Data.OleDb
Imports System.Data
Public Class AttendMathreg
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub AttendMathreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")
        con.Open()

        Dim cmd As New OleDbCommand("Insert into AttendenceDateMaths([code],[date1]) Values(?,?)", con)
        cmd.Parameters.Add(New OleDbParameter("code", CType(number.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("date1", CType(Label2.Text, Date)))

        If cmd.ExecuteNonQuery() Then
            MsgBox("Attedence code registered")
        End If
        cmd.Dispose()
        con.Close()
    End Sub
End Class
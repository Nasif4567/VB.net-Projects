Imports System.Data.OleDb
Imports System.Data
Public Class AttendGenSci
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\e-learning.accdb")

        Dim check As New OleDbCommand("select * from AttendenceDateScience where AttendenceDate =? ", con)
        check.Parameters.Add(New OleDbParameter("AttendenceDate", CType(DateTimePicker1.Text, Date)))

        con.Open()
        Dim number As Integer
        Dim com As New OleDbCommand("select Max(code) From AttendenceDateScience", con)

        Dim dr As OleDbDataReader
        dr = check.ExecuteReader()



        If dr.HasRows Then
            MsgBox("This date's Attendence code has already been registered !")


        ElseIf IsDBNull(com.ExecuteScalar) Then
            number = 1
                AttendsciReg.number.Text = number
                AttendsciReg.Label2.Text = DateTimePicker1.Text
            AttendsciReg.Show()
            Me.Hide()

        Else
                number = com.ExecuteScalar + 2
            AttendsciReg.number.Text = number
            AttendsciReg.Label2.Text = DateTimePicker1.Text
            AttendsciReg.Show()
            Me.Hide()
        End If

        con.Close()


    End Sub

    Private Sub AttendGenSci_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TeacherDashboard.Show()
        Me.Hide()
    End Sub
End Class
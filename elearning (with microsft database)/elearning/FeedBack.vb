Imports System.Data.OleDb
Imports System.String
Public Class FormFeedBack
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\\e-learning.accdb;Persist Security Info=False")
    Public Dad As OleDbDataAdapter
    Public Drd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public Dst = New DataSet
    Dim type1 As String
    Dim level1 As String
    Public CurrentRow As Integer
    Dim query As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonFBSub.Click

        Dim Str As String



        Try

            Str = "insert into Feedback values("
            Str += """" & Label7.Text.Trim() & """"
            Str += ","
            Str += """" & Label6.Text.Trim() & """"
            Str += ","

            If RadioButton1.Checked = True Then
                Str += """" & RadioButton1.Text.Trim() & """"
                Str += ","
            ElseIf RadioButton2.Checked = True Then
                Str += """" & RadioButton2.Text.Trim() & """"
                Str += ","
            End If
            If RadioButton03.Checked = True Then
                Str += """" & RadioButton03.Text.Trim() & """"
                Str += ","
            ElseIf RadioButton02.Checked = True Then
                Str += """" & RadioButton02.Text.Trim() & """"
                Str += ","
            ElseIf RadioButton01.Checked = True Then
                Str += """" & RadioButton01.Text.Trim() & """"
                Str += ","
            ElseIf RadioButton00.Checked = True Then
                Str += """" & RadioButton00.Text.Trim() & """"
                Str += ","
            End If

            Str += """" & txtdes.Text.Trim() & """"

            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Feedback ORDER BY Feedback_ID", Con)
            Dad.Fill(Dst, "Feedback")
            MsgBox("Your Feedback has been submitted...")
            txtdes.Clear()

            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Feedback sent Failed")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try

    End Sub
    Private Sub level(sender As Object, e As EventArgs) Handles RadioButton00.Click, RadioButton01.Click, RadioButton02.Click, RadioButton03.Click
        If RadioButton03.Checked = True Then
            level1 = RadioButton03.Text
        ElseIf RadioButton02.Checked = True Then
            level1 = RadioButton02.Text
        ElseIf RadioButton01.Checked = True Then
            level1 = RadioButton01.Text
        ElseIf RadioButton00.Checked = True Then
            level1 = RadioButton00.Text
        End If



    End Sub


    Private Sub types(sender As Object, e As EventArgs) Handles RadioButton2.Click, RadioButton1.Click
        If RadioButton1.Checked = True Then
            type1 = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            type1 = RadioButton2.Text
        End If
    End Sub


End Class



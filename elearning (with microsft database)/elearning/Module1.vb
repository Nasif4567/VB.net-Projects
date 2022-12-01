Imports System.Data.OleDb

Module Module1
    Public con As New System.Data.OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String

    Public Sub conn()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zeba anika\Desktop\SDM-assign\elearning\e-learning.accdb"


    End Sub




End Module


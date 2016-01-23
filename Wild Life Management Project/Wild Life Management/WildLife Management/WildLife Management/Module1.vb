Imports System.Data.OleDb

Module Module1
    Public DisplayTableName As String
    Public DeleteTableName As String
    Public member_name As String
    Public sighting_name As String
    Public modify_sighting_all As Integer
    Public animal_name As String
    Public con As OleDbConnection
    Public adapt As OleDbDataAdapter
    Public dt As DataTable
    Public com As OleDbCommand
    Public Function connect()
        Try
            con = New OleDbConnection("Provider=SQLOLEDB;Data Source=(local);Initial Catalog=wildlife_management;Integrated Security=SSPI;")
            con.Open()
            MsgBox("Connected to the database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function check(ByVal st As String) As Boolean
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        da = New OleDbDataAdapter(st, con)
        dt = New DataTable
        da.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            Return (True)
        Else
            Return False
        End If
    End Function
End Module

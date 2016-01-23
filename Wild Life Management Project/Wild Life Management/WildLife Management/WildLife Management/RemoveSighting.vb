Imports System.Data.OleDb

Public Class RemoveSighting

    Private Sub RemoveSighting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim mid As Integer
            adapt = New OleDbDataAdapter("select mid from member where mname='" & member_name & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            mid = dt.Rows(0)("mid")
            adapt = New OleDbDataAdapter("select sname from sighting where mid=" & mid, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "sname"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "delete from sighting where sname='" & ComboBox3.Text & "'"
            com.ExecuteNonQuery()
            MsgBox("Delete successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
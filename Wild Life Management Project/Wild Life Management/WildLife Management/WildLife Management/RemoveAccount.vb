Imports System.Data.OleDb

Public Class RemoveAccount

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Entrer the password!")
        End If
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "delete from member where mname='" & member_name & "'"
            com.ExecuteNonQuery()
            MsgBox("Delete successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Imports System.Data.OleDb

Public Class InsertHabitat

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Habitat name is compulsary!")
            TextBox1.Focus()
            Exit Sub
        End If
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "insert into habitat (hname,info) values ('" + Trim(TextBox1.Text) + "','" + Trim(TextBox2.Text) + "')"
            com.ExecuteNonQuery()
            MsgBox("Data inserted successfully")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
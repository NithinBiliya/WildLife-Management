Imports System.Data.OleDb

Public Class ChangePassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("You need to enter all the 3 fields before continuing!")
            Exit Sub
        End If
        If Trim(TextBox2.Text) <> Trim(TextBox3.Text) Then
            MsgBox("The passwords do not match!")
            Exit Sub
        End If
        Dim st As String
        st = "select * from log_in"
        If (check(st) = True) Then
            MsgBox("Wrong password entered!")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Focus()
            Exit Sub
        Else
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "update log_in set pword='" & Trim(TextBox2.Text) & "' where upper(uname)='" & Trim(member_name.ToUpper()) & "'"
            com.ExecuteNonQuery()
        End If
    End Sub
End Class
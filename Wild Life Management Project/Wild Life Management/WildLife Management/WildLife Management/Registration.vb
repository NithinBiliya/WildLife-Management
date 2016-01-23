Imports System.Data.OleDb

Public Class Registration

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide()
        TextBox1.Text = Login.TextBox1.Text
        TextBox2.Text = Login.TextBox2.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Or Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Then
            MsgBox("All the information is compulsary... So make sure you enter all the information...")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text <> TextBox3.Text Then
            MsgBox("The 2 passwords do not match! Please re-enter")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox2.Focus()
            Exit Sub
        End If
        Try
            If check("select * from register where uname='" & Trim(TextBox1.Text) & "'") = False Then
                MsgBox("That username already exists... Choose a different username...")
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Sub
            End If
            If check("select * from member where mname='" & Trim(TextBox1.Text) & "'") = False Then
                MsgBox("That username already exists... Choose a different username...")
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Sub
            End If
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "insert into register (uname,pword,contact) values ('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox4.Text) & "')"
            com.ExecuteNonQuery()
            MsgBox("Registration successful! Wait till the administrator approves your request...")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Registration_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub
End Class
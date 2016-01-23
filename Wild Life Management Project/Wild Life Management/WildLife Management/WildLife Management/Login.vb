Imports System.Data.OleDb

Public Class Login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please enter both username and password!")
            TextBox1.Focus()
            Exit Sub
        End If
        st = "select * from log_in where uname='" & TextBox1.Text & "' and pword='" & TextBox2.Text & "'"
        Dim s As String
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)

        If (dt.Rows.Count) = 0 Then
            MsgBox("Invalid Login... Re-enter the username and password...")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
            Exit Sub
        Else
            s = dt.Rows(0)("mtype").ToString()
            If (s = "A") Then
                AdminHomePage.Show()
            ElseIf (s = "M") Then
                member_name = Trim(TextBox1.Text)
                MemberHomePage.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Registration.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        animal_name = TextBox3.Text
        SearchAnimal.Show()
    End Sub
End Class

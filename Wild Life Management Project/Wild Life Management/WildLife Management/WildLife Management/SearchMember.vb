Imports System.Data.OleDb

Public Class SearchMember

    Private Sub SearchMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        PictureBox1.Visible = False
        Me.Size = New System.Drawing.Size(300, 125)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim st As String
        If TextBox3.Text = "" Then
            MsgBox("Please enter the member name!")
            TextBox3.Focus()
            Exit Sub
        End If
        st = "select * from member where upper(mname)='" & Trim(TextBox3.Text.ToUpper()) & "'"
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such a member does not exist!")
            TextBox3.Text = ""
            TextBox3.Focus()
            Exit Sub
        Else
            Try
                Me.Size = New System.Drawing.Size(300, 374)
                Me.Text = dt.Rows(0)("mname").ToString()
                Label7.Visible = False
                TextBox3.Visible = False
                Button2.Visible = False
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label8.Visible = True
                Label1.Text = dt.Rows(0)("mname").ToString()
                Label2.Text = Label2.Text + dt.Rows(0)("age").ToString()
                Label3.Text = Label3.Text + dt.Rows(0)("city").ToString()
                Label4.Text = Label4.Text + dt.Rows(0)("interest").ToString()
                Label6.Text = Label6.Text + dt.Rows(0)("contact").ToString()
                Dim aid As Integer = -1
                Dim mname As String = dt.Rows(0)("mname").ToString()
                Dim pid As Integer = -1
                If Not IsDBNull(dt.Rows(0)("aid")) Then
                    aid = Val(dt.Rows(0)("aid"))
                End If
                If Not IsDBNull(dt.Rows(0)("pid")) Then
                    pid = Val(dt.Rows(0)("pid"))
                End If
                If aid <> -1 Then
                    st = "select cname from animal where aid=" & aid
                    adapt = New OleDbDataAdapter(st, con)
                    dt = New DataTable
                    adapt.Fill(dt)
                    Label5.Text = Label5.Text + dt.Rows(0)("cname").ToString()
                End If
                st = "select pword from log_in where uname='" & mname & "'"
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                Label8.Text = Label8.Text + dt.Rows(0)("pword").ToString()
                If pid <> -1 Then
                    st = "select link from photo where pid=" & pid
                    adapt = New OleDbDataAdapter(st, con)
                    dt = New DataTable
                    adapt.Fill(dt)
                    PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
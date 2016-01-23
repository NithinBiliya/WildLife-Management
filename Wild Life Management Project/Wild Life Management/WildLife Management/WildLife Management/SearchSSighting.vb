Imports System.Data.OleDb

Public Class SearchSSighting

    Private Function show_sighting()
        Dim st As String
        If TextBox3.Text = "" Then
            MsgBox("Please enter the sighting name!")
            TextBox3.Focus()
            Return 0
        End If
        Try
            st = "select * from sighting where upper(sname)='" & Trim(TextBox3.Text.ToUpper()) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            If (dt.Rows.Count) = 0 Then
                MsgBox("Such a sighting does not exist!")
                TextBox3.Text = ""
                TextBox3.Focus()
                Return 0
            Else
                Me.Size = New System.Drawing.Size(396, 633)
                Me.Text = dt.Rows(0)("sname").ToString()
                Label3.Visible = False
                TextBox3.Visible = False
                Button2.Visible = False
                TextBox1.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                PictureBox1.Visible = True
                Label1.Text = dt.Rows(0)("sname").ToString()
                TextBox1.Text = dt.Rows(0)("info").ToString()
                Label2.Text = Label2.Text + dt.Rows(0)("place").ToString()
                Label4.Text = Label4.Text + dt.Rows(0)("date_time").ToString()
                Dim aid As Integer = dt.Rows(0)("aid")
                Dim hid As Integer = dt.Rows(0)("hid")
                Dim mid As Integer = dt.Rows(0)("mid")
                Dim pid As Integer = dt.Rows(0)("pid")
                st = "select cname from animal where aid=" & aid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                Label5.Text = Label5.Text + dt.Rows(0)("cname").ToString()
                st = "select hname from habitat where hid=" & hid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                Label6.Text = Label6.Text + dt.Rows(0)("hname").ToString()
                st = "select mname from member where mid=" & mid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                Label7.Text = Label7.Text + dt.Rows(0)("mname").ToString()
                st = "select link from photo where pid=" & pid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 1
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Me.show_sighting()
    End Sub

    Private Sub SearchSSighting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sighting_name <> "" Then
            TextBox3.Text = sighting_name
            Call Me.show_sighting()
            Exit Sub
        End If
        Label1.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        TextBox1.Visible = False
        PictureBox1.Visible = False
        Me.Size = New System.Drawing.Size(300, 131)
    End Sub
End Class
Imports System.Data.OleDb

Public Class ModifySighting

    Private Sub ModifySighting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        PictureBox1.Visible = False
        DateTimePicker1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Me.Size = New System.Drawing.Size(371, 115)
        Try
            adapt = New OleDbDataAdapter("select cname from animal", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "cname"
            adapt = New OleDbDataAdapter("select hname from habitat", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "hname"
            If modify_sighting_all = 1 Then
                adapt = New OleDbDataAdapter("select sname from sighting", con)
            Else
                Dim mid As Integer
                adapt = New OleDbDataAdapter("select mid from member where mname='" & member_name & "'", con)
                dt = New DataTable
                adapt.Fill(dt)
                mid = dt.Rows(0)("mid")
                adapt = New OleDbDataAdapter("select sname from sighting where mid=" & mid, con)
            End If
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "sname"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim st As String
        st = "select * from sighting where upper(sname)='" & Trim(ComboBox3.Text.ToUpper()) & "'"
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such a sighting does not exist!")
            Exit Sub
        Else
            Me.Size = New System.Drawing.Size(371, 391)
            Label8.Visible = False
            ComboBox3.Visible = False
            Button3.Visible = False
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            ComboBox1.Visible = True
            ComboBox2.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            PictureBox1.Visible = True
            DateTimePicker1.Visible = False
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            TextBox1.Text = dt.Rows(0)("sname").ToString()
            TextBox2.Text = dt.Rows(0)("place").ToString()
            TextBox3.Text = dt.Rows(0)("info").ToString()
            DateTimePicker1.Value = dt.Rows(0)("date_time").ToString()
            Dim pid As Integer
            Dim aid As Integer
            Dim hid As Integer
            pid = dt.Rows(0)("pid")
            aid = dt.Rows(0)("aid")
            hid = dt.Rows(0)("hid")

            st = "select cname from animal where aid=" & aid
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.Text = dt.Rows(0)("cname").ToString()
            st = "select hname from habitat where hid=" & hid
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox2.Text = dt.Rows(0)("hname").ToString()
            st = "select link from photo where pid=" & pid
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            TextBox4.Text = dt.Rows(0)("link").ToString()
            PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox4.Text) = "" Then
            MsgBox("Name and photo link of the sighting has to be given compulsarily!")
            TextBox1.Focus()
            Exit Sub
        End If
        com = New OleDbCommand
        Dim pid As Integer
        Dim aid As Integer
        Dim hid As Integer
        Dim mid As Integer
        Try
            Dim st As String
            st = "select pid from photo where link='" & Trim(TextBox4.Text) & "'"
            If (check(st) = True) Then
                com.Connection = con
                com.CommandText = "insert into photo (link) values ('" & Trim(TextBox4.Text) & "')"
                com.ExecuteNonQuery()
            End If
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            If Not IsDBNull(dt.Rows(0)("pid")) Then
                pid = Val(dt.Rows(0)("pid"))
            End If

            st = "select aid from animal where cname='" & Trim(ComboBox1.Text) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            If Not IsDBNull(dt.Rows(0)("aid")) Then
                aid = Val(dt.Rows(0)("aid"))
            End If
            st = "select hid from habitat where hname='" & Trim(ComboBox2.Text) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            If Not IsDBNull(dt.Rows(0)("hid")) Then
                hid = Val(dt.Rows(0)("hid"))
            End If
            st = "select mid from member where mname='" & Trim(member_name) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            If Not IsDBNull(dt.Rows(0)("mid")) Then
                mid = Val(dt.Rows(0)("mid"))
            End If


            com.Connection = con
            com.CommandText = "update sighting set sname='" & Trim(TextBox1.Text) & " ',place='" & Trim(TextBox2.Text) & "',info='" & Trim(TextBox3.Text) & "',date_time='" & Trim(DateTimePicker1.Value) & "',aid=" & aid & ",pid=" & pid & ",hid=" & hid & ",mid=" & mid & " where upper(sname)='" & Trim(ComboBox3.Text.ToUpper()) & "'"
            com.ExecuteNonQuery()
            MsgBox("Update successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox4.Text = dialog.FileName
            PictureBox1.ImageLocation = dialog.FileName
        End If
    End Sub
End Class
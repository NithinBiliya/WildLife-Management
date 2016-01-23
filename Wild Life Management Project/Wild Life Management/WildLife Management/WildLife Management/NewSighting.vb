Imports System.Data.OleDb

Public Class NewSighting

    Private Sub NewSighting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            pid = Val(dt.Rows(0)("pid"))

            st = "select aid from animal where cname='" & Trim(ComboBox1.Text) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            aid = Val(dt.Rows(0)("aid"))
            st = "select hid from habitat where hname='" & Trim(ComboBox2.Text) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            hid = Val(dt.Rows(0)("hid"))
            st = "select mid from member where mname='" & Trim(member_name) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            mid = Val(dt.Rows(0)("mid"))

            com.Connection = con
            com.CommandText = "insert into sighting (sname,place,info,date_time,aid,hid,mid,pid) values ('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & (DateTimePicker1.Value) & "'," & aid & "," & hid & "," & mid & "," & pid & ")"
            com.ExecuteNonQuery()
            MsgBox("Data inserted successfully")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
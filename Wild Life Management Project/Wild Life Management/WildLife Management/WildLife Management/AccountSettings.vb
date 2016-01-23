Imports System.Data.OleDb

Public Class AccountSettings

    Private Sub AccountSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            adapt = New OleDbDataAdapter("select cname from animal", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "cname"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim st As String
            st = "select * from member where upper(mname)='" & Trim(member_name.ToUpper()) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            TextBox1.Text = dt.Rows(0)("mname").ToString()
            TextBox2.Text = dt.Rows(0)("city").ToString()
            TextBox3.Text = dt.Rows(0)("contact").ToString()
            ComboBox2.Text = dt.Rows(0)("interest").ToString()
            If Not IsDBNull(dt.Rows(0)("dob")) Then
                DateTimePicker1.Value = CDate(dt.Rows(0)("dob"))
            End If
            Dim pid As Integer = -1
            Dim aid As Integer = -1
            If Not IsDBNull(dt.Rows(0)("pid")) Then
                pid = dt.Rows(0)("pid")
            End If
            If Not IsDBNull(dt.Rows(0)("aid")) Then
                aid = dt.Rows(0)("aid")
            End If
            If pid <> -1 Then
                'pid = dt.Rows(0)("pid")
                st = "select link from photo where pid=" & pid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                TextBox4.Text = dt.Rows(0)("link").ToString()
                PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
            End If
            If aid <> -1 Then
                'aid = dt.Rows(0)("aid")
                st = "select cname from animal where aid=" & aid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                ComboBox1.Text = dt.Rows(0)("cname").ToString()
            End If
            st = "select pword from log_in where upper(uname)='" & Trim(member_name.ToUpper()) & "'"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            TextBox5.Text = dt.Rows(0)("pword").ToString()
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
        If Trim(TextBox1.Text) = "" Or Trim(TextBox5.Text) = "" Then
            MsgBox("Member name are compulsary!")
            TextBox1.Focus()
            Exit Sub
        End If
        com = New OleDbCommand
        Dim pid As Integer
        Dim aid As Integer
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
            adapt = New OleDbDataAdapter("select aid from animal where cname='" & Trim(ComboBox1.Text) & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            aid = Val(dt.Rows(0)("aid"))
            Dim dob As Date = Me.DateTimePicker1.Value
            Dim age As Integer = Convert.ToInt32(DateDiff(DateInterval.Year, dob, Date.Today))
            com.Connection = con
            com.CommandText = "update member set mname='" & Trim(TextBox1.Text) & " ',city='" & Trim(TextBox2.Text) & "',contact='" & Trim(TextBox3.Text) & "',interest='" & Trim(ComboBox2.Text) & "',DOB='" & DateTimePicker1.Value & "',pid=" & pid & ",aid=" & aid & ",age=" & age & " where upper(mname)='" & Trim(member_name.ToUpper()) & "'"
            com.ExecuteNonQuery()
            com.Connection = con
            com.CommandText = "update log_in set pword='" & Trim(TextBox5.Text) & "' where upper(uname)='" & Trim(member_name.ToUpper()) & "'"
            com.ExecuteNonQuery()
            MsgBox("Update successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ChangePassword.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RemoveAccount.Show()
    End Sub
End Class
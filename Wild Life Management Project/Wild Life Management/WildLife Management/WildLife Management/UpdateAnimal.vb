Imports System.Data.OleDb

Public Class UpdateAnimal

    Private Sub UpdateAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        PictureBox1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Me.Size = New System.Drawing.Size(360, 128)
        Try
            adapt = New OleDbDataAdapter("select hname from habitat", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "hname"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim st As String
        If TextBox6.Text = "" Then
            MsgBox("Please enter the animal's common or scientific name!")
            TextBox6.Focus()
            Exit Sub
        End If
        st = "select * from animal where upper(sname)='" & Trim(TextBox6.Text.ToUpper()) & "' or upper(cname)='" & Trim(TextBox6.Text.ToUpper()) & "'"
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such an animal does not exist!")
            TextBox6.Text = ""
            TextBox6.Focus()
            Exit Sub
        Else
            Me.Size = New System.Drawing.Size(360, 434)
            Label8.Visible = False
            TextBox6.Visible = False
            Button3.Visible = False
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            ComboBox1.Visible = True
            ComboBox2.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            PictureBox1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            TextBox1.Text = dt.Rows(0)("cname").ToString()
            TextBox2.Text = dt.Rows(0)("sname").ToString()
            TextBox3.Text = dt.Rows(0)("tcount").ToString()
            ComboBox2.Text = dt.Rows(0)("status").ToString()
            TextBox5.Text = dt.Rows(0)("info").ToString()
            Dim pid As Integer
            Dim aid As Integer
            pid = dt.Rows(0)("pid")
            aid = dt.Rows(0)("aid")

            st = "select hname from habitat"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt

            st = "select hname from lives_in as L,habitat as H where aid=" & aid & " and H.hid=L.hid"
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.Text = dt.Rows(0)("hname").ToString()

            st = "select link from photo where pid=" & pid
            adapt = New OleDbDataAdapter(st, con)
            dt = New DataTable
            adapt.Fill(dt)
            TextBox4.Text = dt.Rows(0)("link").ToString()
            PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox4.Text = dialog.FileName
            PictureBox1.ImageLocation = dialog.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Common and scientific names of an animal is compulsary!")
            TextBox1.Focus()
            Exit Sub
        End If
        com = New OleDbCommand
        Dim pid As Integer
        Dim aid As Integer
        Dim hid As Integer
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
            com.Connection = con
            com.CommandText = "update animal set cname='" & Trim(TextBox1.Text) & " ',sname='" & Trim(TextBox2.Text) & "',tcount=" & Val(TextBox3.Text) & ",status='" & Trim(ComboBox2.Text) & "',info='" & Trim(TextBox5.Text) & "',pid=" & pid & " where upper(sname)='" & Trim(TextBox6.Text.ToUpper()) & "' or upper(cname)='" & Trim(TextBox6.Text.ToUpper()) & "'"
            com.ExecuteNonQuery()
            adapt = New OleDbDataAdapter("select * from animal where sname='" & Trim(TextBox2.Text) & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            aid = Val(dt.Rows(0)("aid"))
            adapt = New OleDbDataAdapter("select * from habitat where hname='" & Trim(ComboBox1.Text) & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            hid = Val(dt.Rows(0)("hid"))
            com.Connection = con
            com.CommandText = "update lives_in set hid=" & hid & " where aid=" & aid
            com.ExecuteNonQuery()
            MsgBox("Update successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
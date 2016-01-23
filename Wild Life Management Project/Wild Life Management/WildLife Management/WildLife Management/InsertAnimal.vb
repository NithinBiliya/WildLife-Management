Imports System.Data.OleDb

Public Class InsertAnimal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox4.Text = dialog.FileName
            PictureBox1.ImageLocation = dialog.FileName
        End If
    End Sub

    Private Sub InsertAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            com.CommandText = "insert into animal (cname,sname,tcount,status,info,pid) values ('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "'," & Val(TextBox3.Text) & ",'" & Trim(ComboBox2.Text) & "','" & Trim(TextBox5.Text) & "'," & pid & ")"
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
            com.CommandText = "insert into lives_in values (" & aid & "," & hid & ")"
            com.ExecuteNonQuery()
            MsgBox("Data inserted successfully")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
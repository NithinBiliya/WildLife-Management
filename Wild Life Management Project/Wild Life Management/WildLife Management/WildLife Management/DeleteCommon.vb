Imports System.Data.OleDb

Public Class DeleteCommon

    Private Sub DeleteCommon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = DeleteTableName + " Name : "
        Try
            adapt = New OleDbDataAdapter("select * from " & DeleteTableName.ToLower, con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            If DeleteTableName = "Animal" Then
                ComboBox1.DisplayMember = "cname"
            ElseIf DeleteTableName = "Habitat" Then
                ComboBox1.DisplayMember = "hname"
            ElseIf DeleteTableName = "Sighting" Then
                ComboBox1.DisplayMember = "sname"
            ElseIf DeleteTableName = "Member" Then
                ComboBox1.DisplayMember = "mname"
            ElseIf DeleteTableName = "Photo" Then
                ComboBox1.DisplayMember = "pid"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        com = New OleDbCommand
        Try
            If ComboBox1.Text = "admin" Then
                MsgBox("You cannot delete the admin!")
                Exit Sub
            End If
            com.Connection = con
            If DeleteTableName = "Animal" Then
                com.CommandText = "delete from " & DeleteTableName.ToLower() & " where cname='" & ComboBox1.Text.ToLower() & "'"
            ElseIf DeleteTableName = "Habitat" Then
                com.CommandText = "delete from " & DeleteTableName.ToLower() & " where hname='" & ComboBox1.Text.ToLower() & "'"
            ElseIf DeleteTableName = "Memeber" Then
                com.CommandText = "delete from " & DeleteTableName.ToLower() & " where mname='" & ComboBox1.Text.ToLower() & "'"
            ElseIf DeleteTableName = "Sighting" Then
                com.CommandText = "delete from " & DeleteTableName.ToLower() & " where sname='" & ComboBox1.Text.ToLower() & "'"
            ElseIf DeleteTableName = "Photo" Then
                com.CommandText = "delete from " & DeleteTableName.ToLower() & " where pid='" & ComboBox1.Text.ToLower() & "'"
            End If
            com.ExecuteNonQuery()
            MsgBox("Delete successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
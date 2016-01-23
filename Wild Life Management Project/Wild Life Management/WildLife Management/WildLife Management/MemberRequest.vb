Imports System.Data.OleDb

Public Class MemberRequest

    Private Sub MemberRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adapt = New OleDbDataAdapter("select * from register", con)
        dt = New DataTable
        adapt.Fill(dt)
        Dim n As Integer
        n = 0
        While dt.Rows(n)("uname").ToString() <> ""
            Dim checkBox = New CheckBox()
            Me.Controls.Add(checkBox)
            If n <= 6 Then
                checkBox.Location = New Point(50, 37 + n * 23)
            Else
                checkBox.Location = New Point(137, 37 + (n - 7) * 23)
            End If
            checkBox.Text = dt.Rows(n)("uname").ToString()
            checkBox.Name = dt.Rows(n)("uname").ToString()
            checkBox.Checked = False
            n = n + 1
        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ctrlName As String = String.Empty
            Dim flag As Integer = 0
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chk As CheckBox = CType(ctrl, CheckBox)
                    If chk.Checked Then
                        'MsgBox(chk.Name)
                        adapt = New OleDbDataAdapter("select * from register where uname = '" & chk.Name & "'", con)
                        dt = New DataTable
                        adapt.Fill(dt)
                        com = New OleDbCommand
                        com.Connection = con
                        com.CommandText = "insert into member (mname,contact) values ('" & Trim(dt.Rows(0)("uname").ToString()) & "','" & Trim(dt.Rows(0)("contact").ToString()) & "')"
                        com.ExecuteNonQuery()
                        flag = 1
                    End If
                End If
            Next
            If flag = 0 Then
                MsgBox("Select atleast one member to be accepted...")
                Exit Sub
            Else
                MsgBox("Selected requests have been given membership!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim ctrlName As String = String.Empty
            Dim flag As Integer = 0
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chk As CheckBox = CType(ctrl, CheckBox)
                    If chk.Checked Then
                        'MsgBox(chk.Name)
                        com = New OleDbCommand
                        com.Connection = con
                        com.CommandText = "delete from register where uname='" & Trim(chk.Name) & "'"
                        com.ExecuteNonQuery()
                        flag = 1
                    End If
                End If
            Next
            If flag = 0 Then
                MsgBox("Select atleast one member to be rejected...")
                Exit Sub
            Else
                MsgBox("Selected people were denied membership...")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Imports System.Data.OleDb

Public Class UpdateHabitat
    Dim hid As Integer
    Private Sub UpdateHabitat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Me.Size = New System.Drawing.Size(300, 116)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim st As String
        If TextBox3.Text = "" Then
            MsgBox("Please enter the habitat name!")
            TextBox3.Focus()
            Exit Sub
        End If
        st = "select * from habitat where upper(hname)='" & Trim(TextBox3.Text.ToUpper()) & "'"
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such a habitat does not exist!")
            TextBox3.Text = ""
            TextBox3.Focus()
            Exit Sub
        Else
            Me.Size = New System.Drawing.Size(300, 300)
            Label3.Visible = False
            TextBox3.Visible = False
            Button2.Visible = False
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            TextBox1.Text = dt.Rows(0)("hname").ToString()
            TextBox2.Text = dt.Rows(0)("info").ToString()
            hid = dt.Rows(0)("hid")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Name of the habitat is compulsary!")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "update habitat set hname='" & Trim(TextBox1.Text) & " ',info='" & Trim(TextBox2.Text) & "' where upper(hname)='" & Trim(TextBox3.Text.ToUpper()) & "'"
            com.ExecuteNonQuery()
            MsgBox("Update successful!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
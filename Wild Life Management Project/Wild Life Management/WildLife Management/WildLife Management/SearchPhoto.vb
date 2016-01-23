Imports System.Data.OleDb

Public Class SearchPhoto

    Private Sub SearchPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label3.Visible = False
        PictureBox1.Visible = False
        Me.Size = New System.Drawing.Size(300, 195)
        Try
            adapt = New OleDbDataAdapter("select pid from photo", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "pid"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        adapt = New OleDbDataAdapter("select * from photo where pid=" & Val(ComboBox1.Text), con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such a photo does not exist!")
            Exit Sub
        Else
            Label1.Visible = False
            ComboBox1.Visible = False
            Button1.Visible = False
            Label2.Visible = True
            Label3.Visible = True
            PictureBox1.Visible = True
            Me.Size = New System.Drawing.Size(300, 300)
            Label2.Text = Label2.Text + dt.Rows(0)("pid").ToString()
            Label3.Text = Label3.Text + dt.Rows(0)("link").ToString()
            PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
        End If
    End Sub
End Class
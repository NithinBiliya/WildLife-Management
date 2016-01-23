Imports System.Data.OleDb

Public Class SearchSighting

    Private Sub SearchHabitat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        Me.Size = New System.Drawing.Size(300, 135)
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
            Me.Text = dt.Rows(0)("hname").ToString()
            Label3.Visible = False
            TextBox3.Visible = False
            Button2.Visible = False
            TextBox1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label1.Text = dt.Rows(0)("hname").ToString()
            TextBox1.Text = dt.Rows(0)("info").ToString()
        End If
    End Sub
End Class
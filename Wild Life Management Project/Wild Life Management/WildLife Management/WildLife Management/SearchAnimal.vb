Imports System.Data.OleDb

Public Class SearchAnimal
    Private Function disp_animal()
        Dim st As String
        If TextBox6.Text = "" Then
            MsgBox("Please enter the animal's common or scientific name!")
            TextBox6.Focus()
            Return 0
        End If
        st = "select * from animal where upper(sname)='" & Trim(TextBox6.Text.ToUpper()) & "' or upper(cname)='" & Trim(TextBox6.Text.ToUpper()) & "'"
        adapt = New OleDbDataAdapter(st, con)
        dt = New DataTable
        adapt.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            MsgBox("Such an animal does not exist!")
            TextBox6.Text = ""
            TextBox6.Focus()
            Return 0
        Else
            Try
                Me.Size = New System.Drawing.Size(348, 392)
                Me.Text = dt.Rows(0)("cname").ToString()
                Label8.Visible = False
                TextBox6.Visible = False
                Button3.Visible = False
                TextBox1.Visible = True
                PictureBox1.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                ComboBox1.Visible = True
                Button1.Visible = True
                Label1.Text = dt.Rows(0)("cname").ToString()
                Label2.Text = Label2.Text + dt.Rows(0)("sname").ToString()
                Label3.Text = Label3.Text + dt.Rows(0)("tcount").ToString()
                Label4.Text = Label4.Text + dt.Rows(0)("status").ToString()
                TextBox1.Text = dt.Rows(0)("info").ToString()
                Dim pid As Integer
                Dim aid As Integer
                pid = dt.Rows(0)("pid")
                aid = dt.Rows(0)("aid")

                st = "select hname from lives_in as L,habitat as H where aid=" & aid & " and H.hid=L.hid"
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                Label6.Text = Label6.Text + dt.Rows(0)("hname").ToString()

                st = "select link from photo where pid=" & pid
                adapt = New OleDbDataAdapter(st, con)
                dt = New DataTable
                adapt.Fill(dt)
                PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()

                adapt = New OleDbDataAdapter("select sname from sighting where aid=" & aid, con)
                dt = New DataTable
                adapt.Fill(dt)
                ComboBox1.DataSource = dt
                ComboBox1.DisplayMember = "sname"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Return 1
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call disp_animal()
    End Sub

    Private Sub SearchAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        TextBox1.Visible = False
        PictureBox1.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = False
        Me.Size = New System.Drawing.Size(325, 141)
        If animal_name <> "" Then
            TextBox6.Text = animal_name
            Call disp_animal()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sighting_name = ComboBox1.Text
        SearchSSighting.Show()
    End Sub
End Class
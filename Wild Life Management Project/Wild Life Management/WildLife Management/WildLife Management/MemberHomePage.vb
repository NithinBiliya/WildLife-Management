Imports System.Data.OleDb

Public Class MemberHomePage

    Private Sub MemberHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide()
        Dim memname As String = Trim(Login.TextBox1.Text)
        Try
            adapt = New OleDbDataAdapter("select * from member where mname='" & memname & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label1.Text = Label1.Text + memname
            Label2.Text = Label2.Text + dt.Rows(0)("age").ToString()
            Label3.Text = Label3.Text + dt.Rows(0)("city").ToString()
            Label4.Text = Label4.Text + dt.Rows(0)("interest").ToString()
            Label6.Text = Label6.Text + dt.Rows(0)("contact").ToString()
            Dim pid As String = dt.Rows(0)("pid").ToString
            If dt.Rows(0)("aid").ToString <> "" Then
                adapt = New OleDbDataAdapter("select cname from animal where aid=" & Val(dt.Rows(0)("aid")), con)
                dt = New DataTable
                adapt.Fill(dt)
                Label5.Text = Label5.Text + dt.Rows(0)("cname").ToString()
            End If
            If pid <> "" Then
                adapt = New OleDbDataAdapter("select link from photo where pid=" & Val(pid), con)
                dt = New DataTable
                adapt.Fill(dt)
                PictureBox1.ImageLocation = dt.Rows(0)("link").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MemberHomePage_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""
        Login.Show()
    End Sub

    Private Sub NewSightingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSightingToolStripMenuItem.Click
        NewSighting.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        modify_sighting_all = 0
        ModifySighting.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveSighting.Show()
    End Sub

    Private Sub HabitatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatToolStripMenuItem.Click
        SearchSighting.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MySightingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MySightingToolStripMenuItem.Click
        sighting_name = ""
        SearchSSighting.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalToolStripMenuItem.Click
        animal_name = ""
        SearchAnimal.Show()
    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        AccountSettings.Show()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub
End Class
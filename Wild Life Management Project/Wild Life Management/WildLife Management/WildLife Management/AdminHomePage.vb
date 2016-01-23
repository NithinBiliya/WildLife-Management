Imports System.Data.OleDb

Public Class AdminHomePage

    Private Sub AdminHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        member_name = "admin"
        Login.Hide()
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select count(*) as count_num from animal", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label2.Text = Label2.Text + dt.Rows(0)("count_num").ToString()
            adapt = New OleDbDataAdapter("select count(*) as count_num from member", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label3.Text = Label3.Text + (dt.Rows(0)("count_num") - 1).ToString()
            adapt = New OleDbDataAdapter("select count(*) as count_num from habitat", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label4.Text = Label4.Text + dt.Rows(0)("count_num").ToString()
            adapt = New OleDbDataAdapter("select count(*) as count_num from sighting", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label5.Text = Label5.Text + dt.Rows(0)("count_num").ToString()
            adapt = New OleDbDataAdapter("select count(*) as count_num from photo", con)
            dt = New DataTable
            adapt.Fill(dt)
            Label6.Text = Label6.Text + dt.Rows(0)("count_num").ToString()
            adapt = New OleDbDataAdapter("select * from register", con)
            dt = New DataTable
            adapt.Fill(dt)
            If (dt.Rows.Count) = 0 Then
                Label7.Visible = False
                Button1.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AnimalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalsToolStripMenuItem.Click
        DisplayTableName = "Animal"
        CommonDisplay.Show()
    End Sub

    Private Sub MembersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersToolStripMenuItem.Click
        DisplayTableName = "Member"
        CommonDisplay.Show()
    End Sub

    Private Sub HabitatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatsToolStripMenuItem.Click
        DisplayTableName = "Habitat"
        CommonDisplay.Show()
    End Sub

    Private Sub SightingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SightingsToolStripMenuItem.Click
        DisplayTableName = "Sighting"
        CommonDisplay.Show()
    End Sub

    Private Sub PhotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotosToolStripMenuItem.Click
        DisplayTableName = "Photo"
        CommonDisplay.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalToolStripMenuItem.Click
        InsertAnimal.Show()
    End Sub

    Private Sub HabitatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatToolStripMenuItem.Click
        InsertHabitat.Show()
    End Sub

    Private Sub AdminHomePage_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""
        Login.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalToolStripMenuItem1.Click
        UpdateAnimal.Show()
    End Sub

    Private Sub HabitatToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatToolStripMenuItem1.Click
        UpdateHabitat.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalToolStripMenuItem2.Click
        DeleteTableName = "Animal"
        DeleteCommon.Show()
    End Sub

    Private Sub HabitatToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatToolStripMenuItem2.Click
        DeleteTableName = "Habitat"
        DeleteCommon.Show()
    End Sub

    Private Sub MemberToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem1.Click
        DeleteTableName = "Member"
        DeleteCommon.Show()
    End Sub

    Private Sub SightingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SightingToolStripMenuItem1.Click
        DeleteTableName = "Sighting"
        DeleteCommon.Show()
    End Sub

    Private Sub PhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoToolStripMenuItem.Click
        DeleteTableName = "Photo"
        DeleteCommon.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalToolStripMenuItem3.Click
        animal_name = ""
        SearchAnimal.Show()
    End Sub

    Private Sub HabitatToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitatToolStripMenuItem3.Click
        SearchSighting.Show()
    End Sub

    Private Sub PhotoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoToolStripMenuItem1.Click
        SearchPhoto.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MemberRequest.Show()
    End Sub

    Private Sub SightingToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SightingToolStripMenuItem2.Click
        sighting_name = ""
        SearchSSighting.Show()
    End Sub

    Private Sub MemberToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem2.Click
        SearchMember.Show()
    End Sub

    Private Sub SightingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SightingToolStripMenuItem.Click
        modify_sighting_all = 1
        ModifySighting.Show()
    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        UpdateMember.Show()
    End Sub

    Private Sub AdminInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminInfoToolStripMenuItem.Click
        member_name = "admin"
        AccountSettings.Show()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub
End Class
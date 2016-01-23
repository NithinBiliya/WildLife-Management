<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SightingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SightingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitatToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SightingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitatToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SightingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Admin!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total number of animals : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total number of Members : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total number of Habitats : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total number of Sightings : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total number of Photos : "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripMenuItem, Me.InsertToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalsToolStripMenuItem, Me.MembersToolStripMenuItem, Me.HabitatsToolStripMenuItem, Me.SightingsToolStripMenuItem, Me.PhotosToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'AnimalsToolStripMenuItem
        '
        Me.AnimalsToolStripMenuItem.Name = "AnimalsToolStripMenuItem"
        Me.AnimalsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AnimalsToolStripMenuItem.Text = "Animals"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'HabitatsToolStripMenuItem
        '
        Me.HabitatsToolStripMenuItem.Name = "HabitatsToolStripMenuItem"
        Me.HabitatsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HabitatsToolStripMenuItem.Text = "Habitats"
        '
        'SightingsToolStripMenuItem
        '
        Me.SightingsToolStripMenuItem.Name = "SightingsToolStripMenuItem"
        Me.SightingsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SightingsToolStripMenuItem.Text = "Sightings"
        '
        'PhotosToolStripMenuItem
        '
        Me.PhotosToolStripMenuItem.Name = "PhotosToolStripMenuItem"
        Me.PhotosToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PhotosToolStripMenuItem.Text = "Photos"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalToolStripMenuItem, Me.HabitatToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'AnimalToolStripMenuItem
        '
        Me.AnimalToolStripMenuItem.Name = "AnimalToolStripMenuItem"
        Me.AnimalToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AnimalToolStripMenuItem.Text = "Animal"
        '
        'HabitatToolStripMenuItem
        '
        Me.HabitatToolStripMenuItem.Name = "HabitatToolStripMenuItem"
        Me.HabitatToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.HabitatToolStripMenuItem.Text = "Habitat"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalToolStripMenuItem1, Me.HabitatToolStripMenuItem1, Me.MemberToolStripMenuItem, Me.SightingToolStripMenuItem, Me.AdminInfoToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'AnimalToolStripMenuItem1
        '
        Me.AnimalToolStripMenuItem1.Name = "AnimalToolStripMenuItem1"
        Me.AnimalToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.AnimalToolStripMenuItem1.Text = "Animal"
        '
        'HabitatToolStripMenuItem1
        '
        Me.HabitatToolStripMenuItem1.Name = "HabitatToolStripMenuItem1"
        Me.HabitatToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.HabitatToolStripMenuItem1.Text = "Habitat"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'SightingToolStripMenuItem
        '
        Me.SightingToolStripMenuItem.Name = "SightingToolStripMenuItem"
        Me.SightingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SightingToolStripMenuItem.Text = "Sighting"
        '
        'AdminInfoToolStripMenuItem
        '
        Me.AdminInfoToolStripMenuItem.Name = "AdminInfoToolStripMenuItem"
        Me.AdminInfoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AdminInfoToolStripMenuItem.Text = "Admin Info"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalToolStripMenuItem2, Me.HabitatToolStripMenuItem2, Me.MemberToolStripMenuItem1, Me.SightingToolStripMenuItem1, Me.PhotoToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AnimalToolStripMenuItem2
        '
        Me.AnimalToolStripMenuItem2.Name = "AnimalToolStripMenuItem2"
        Me.AnimalToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.AnimalToolStripMenuItem2.Text = "Animal"
        '
        'HabitatToolStripMenuItem2
        '
        Me.HabitatToolStripMenuItem2.Name = "HabitatToolStripMenuItem2"
        Me.HabitatToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.HabitatToolStripMenuItem2.Text = "Habitat"
        '
        'MemberToolStripMenuItem1
        '
        Me.MemberToolStripMenuItem1.Name = "MemberToolStripMenuItem1"
        Me.MemberToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.MemberToolStripMenuItem1.Text = "Member"
        '
        'SightingToolStripMenuItem1
        '
        Me.SightingToolStripMenuItem1.Name = "SightingToolStripMenuItem1"
        Me.SightingToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.SightingToolStripMenuItem1.Text = "Sighting"
        '
        'PhotoToolStripMenuItem
        '
        Me.PhotoToolStripMenuItem.Name = "PhotoToolStripMenuItem"
        Me.PhotoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PhotoToolStripMenuItem.Text = "Photo"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalToolStripMenuItem3, Me.HabitatToolStripMenuItem3, Me.MemberToolStripMenuItem2, Me.SightingToolStripMenuItem2, Me.PhotoToolStripMenuItem1})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AnimalToolStripMenuItem3
        '
        Me.AnimalToolStripMenuItem3.Name = "AnimalToolStripMenuItem3"
        Me.AnimalToolStripMenuItem3.Size = New System.Drawing.Size(119, 22)
        Me.AnimalToolStripMenuItem3.Text = "Animal"
        '
        'HabitatToolStripMenuItem3
        '
        Me.HabitatToolStripMenuItem3.Name = "HabitatToolStripMenuItem3"
        Me.HabitatToolStripMenuItem3.Size = New System.Drawing.Size(119, 22)
        Me.HabitatToolStripMenuItem3.Text = "Habitat"
        '
        'MemberToolStripMenuItem2
        '
        Me.MemberToolStripMenuItem2.Name = "MemberToolStripMenuItem2"
        Me.MemberToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.MemberToolStripMenuItem2.Text = "Member"
        '
        'SightingToolStripMenuItem2
        '
        Me.SightingToolStripMenuItem2.Name = "SightingToolStripMenuItem2"
        Me.SightingToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.SightingToolStripMenuItem2.Text = "Sighting"
        '
        'PhotoToolStripMenuItem1
        '
        Me.PhotoToolStripMenuItem1.Name = "PhotoToolStripMenuItem1"
        Me.PhotoToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.PhotoToolStripMenuItem1.Text = "Photo"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HowToUseToolStripMenuItem.Text = "How to use"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Registration Requests : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Available"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 275)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminHomePage"
        Me.Text = "ADMIN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SightingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SightingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitatToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SightingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabitatToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SightingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdminInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

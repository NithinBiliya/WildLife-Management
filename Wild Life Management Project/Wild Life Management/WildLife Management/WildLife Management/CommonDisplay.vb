Imports System.Data.OleDb

Public Class CommonDisplay

    Private Sub CommonDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Label1.Text + DisplayTableName + "s"
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from " + DisplayTableName.ToLower(), con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
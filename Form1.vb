Public Class Form1

    Dim LocationName As String

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub HomepageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomepageToolStripMenuItem.Click
        WebBrowser1.Navigate("http://frogfind.com")
    End Sub

    Private Sub GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToolStripMenuItem.Click
        WebBrowser1.Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form3.Visible = True
    End Sub

    Private Sub BookmarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Navigate(ToolStripComboBox2.SelectedItem)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        WebBrowser1.Navigate(ToolStripComboBox2.SelectedItem)
    End Sub

    Private Sub AddBookmarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBookmarkToolStripMenuItem.Click
        My.Settings.Bookmarks.Add(WebBrowser1.Url.ToString)
        ToolStripComboBox2.Items.Add(WebBrowser1.Url.ToString)
        Form2.ListBox1.Items.Add(WebBrowser1.Url.ToString)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item In My.Settings.Bookmarks
            ToolStripComboBox2.Items.Add(item)
            Me.ToolStripComboBox2.Items.Clear()
        Next
    End Sub

    Private Sub BookmarkManagerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookmarkManagerToolStripMenuItem.Click
        Form2.Visible = True
    End Sub
End Class

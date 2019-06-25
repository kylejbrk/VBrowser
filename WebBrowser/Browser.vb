Public Class Browser
    Dim WithEvents currentBrowser As WebBrowser

    Private Sub Browser_Load() Handles MyBase.Load
        Resize_ToolStripTextBox()
    End Sub

    Private Sub tsbGo_Click(sender As Object, e As EventArgs) Handles tsbGo.Click
        Dim link As String = tstbNavBar.Text
        Load_Page(link)
    End Sub

    Private Sub Load_Page(link As String)
        If Not UrlChecker.IsUrl(link) Then
            link = UrlChecker.GetSearchString + link
        End If

        currentBrowser.Navigate(link)
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        Go_Home()
    End Sub

    Private Sub Go_Home()
        Load_Page(My.Settings.HomePage)
    End Sub

    Private Sub Navigated() Handles currentBrowser.Navigated
        tstbNavBar.Text = currentBrowser.Url.ToString()
    End Sub

    Private Sub Resize_ToolStripTextBox() Handles ToolStrip1.Resize
        Dim width As Integer = ToolStrip1.DisplayRectangle.Width

        For Each item As ToolStripItem In ToolStrip1.Items
            If Not item Is tstbNavBar Then
                width -= item.Width
                width -= item.Margin.Horizontal
            End If
        Next

        tstbNavBar.Width = Math.Max(0, width - tstbNavBar.Margin.Horizontal)
        ToolStrip1.PerformLayout()
    End Sub

    Private Sub tsbBack_Click(sender As Object, e As EventArgs) Handles tsbBack.Click
        If currentBrowser.CanGoBack Then
            currentBrowser.GoBack()
        End If
    End Sub

    Private Sub tsbForward_Click(sender As Object, e As EventArgs) Handles tsbForward.Click
        If currentBrowser.CanGoForward Then
            currentBrowser.GoForward()
        End If
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        currentBrowser.Navigate(currentBrowser.Url.ToString())
    End Sub

    Private Sub tsmiPreferences_Click(sender As Object, e As EventArgs) Handles tsmiPreferences.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        currentBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub AddTab(Optional link As String = Nothing)
        Dim tabNum As Integer = TabControl1.TabCount()
        Dim newTab As New TabPage("TabPage" + Str(tabNum))

        TabControl1.TabPages.Insert(tabNum - 1, newTab)

        Dim newBrowser As New WebBrowser()
        newTab.Controls.Add(newBrowser)
        newTab.Tag = newBrowser

        With newBrowser
            .Dock = DockStyle.Fill
            .Parent = newTab
            .ScriptErrorsSuppressed = True
        End With

        TabControl1.SelectedTab = newTab
    End Sub

    'This fires when the form loads
    Private Sub NewTabClicked() Handles tpNewTab.Enter
        AddTab()
        Go_Home()
    End Sub

    Private Sub TabSelected() Handles TabControl1.Selected
        If TabControl1.SelectedTab IsNot tpNewTab Then
            currentBrowser = TabControl1.SelectedTab.Tag
        End If
    End Sub

    Private Sub GitHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitHubToolStripMenuItem.Click

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4)
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4)
        e.DrawFocusRectangle()
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        For i As Integer = 0 To TabControl1.TabPages.Count - 1
            Dim r As Rectangle = TabControl1.GetTabRect(i)
            Dim closeButton As Rectangle = New Rectangle(r.Right - 15, r.Top + 4, 9, 7)
            If closeButton.Contains(e.Location) Then
                If MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TabControl1.TabPages.RemoveAt(i)
                    Exit Sub
                End If
            End If
        Next
    End Sub
End Class
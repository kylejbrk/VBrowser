Public Class Browser
    Private Sub Browser_Load() Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
        Resize_ToolStripTextBox()
        Go_Home()
    End Sub

    Private Sub tsbGo_Click(sender As Object, e As EventArgs) Handles tsbGo.Click
        Dim link As String = tstbNavBar.Text
        Load_Page(link)
    End Sub

    Private Sub Load_Page(link As String)
        If Not UrlChecker.IsUrl(link) Then
            link = UrlChecker.GetSearchString + link
        End If

        WebBrowser1.Navigate(link)
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        Go_Home()
    End Sub

    Private Sub Go_Home()
        Load_Page(My.Settings.HomePage)
    End Sub

    Private Sub Navigated() Handles WebBrowser1.Navigated
        tstbNavBar.Text = WebBrowser1.Url.ToString()
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
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub tsbForward_Click(sender As Object, e As EventArgs) Handles tsbForward.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        WebBrowser1.Navigate(WebBrowser1.Url.ToString())
    End Sub

    Private Sub tsmiPreferences_Click(sender As Object, e As EventArgs) Handles tsmiPreferences.Click
        Preferences.ShowDialog()
    End Sub
End Class
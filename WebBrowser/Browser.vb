﻿Public Class Browser
    Dim WithEvents currentBrowser As WebBrowser
    Dim WithEvents currentLabel As Label

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
        Dim url = currentBrowser.Url.ToString()
        If url.Length() <= 30 Then
            currentBrowser.Parent.Text = url
        Else
            currentBrowser.Parent.Text = url.Substring(0, 30)
        End If
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

        Dim newStatus As New Label()
        newBrowser.Controls.Add(newStatus)

        With newStatus
            .Visible = False
            .Parent = newBrowser
            .Location = New Point(1, newBrowser.Height - 15)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
            .BackColor = Color.White
            .AutoSize = True
            .MaximumSize = New Point(300, 24)
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
            currentBrowser = TabControl1.SelectedTab.Controls.Item(0)
            currentLabel = currentBrowser.Controls.Item(0)
            If Not currentBrowser.Url Is Nothing Then
                tstbNavBar.Text = currentBrowser.Url.ToString()
            End If
        End If
    End Sub

    Private Sub GitHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GitHubToolStripMenuItem.Click
        Load_Page("https://github.com/kylejbrk/VBrowser")
    End Sub

    Private Sub CloseCurrentTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCurrentTabToolStripMenuItem.Click
        If TabControl1.TabCount() <= 2 Then
            Me.Close()
        Else
            Dim currentIndx As Integer = TabControl1.SelectedIndex
            TabControl1.SelectedTab.Dispose()
            If currentIndx > 0 Then
                TabControl1.SelectedIndex = (currentIndx - 1) Mod TabControl1.TabCount()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentLabel.Visible = True
        currentLabel.Text = currentBrowser.StatusText
        If currentLabel.Text = "Done" Then
            currentLabel.Visible = False
        End If
    End Sub

End Class
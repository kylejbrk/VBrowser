Public Class Preferences
    Private Sub Prefrences_Load() Handles MyBase.Load
        Select Case My.Settings.SearchEngine
            Case "Google"
                rbGoogle.Checked = True
            Case "Bing"
                rbBing.Checked = True
            Case "DuckDuckGo"
                rbDuckDuckGo.Checked = True
            Case Else
                MessageBox.Show("No search engine has been selected. Defaulting to Google.")
                rbGoogle.Checked = True
                My.Settings.SearchEngine = "Google"
        End Select

        If My.Settings.HomePage <> "" Then
            tbHomePage.Text = My.Settings.HomePage
        Else
            MessageBox.Show("No HomePage has been selected. Defaulting to Google.")
            My.Settings.SearchEngine = "https://www.google.com/"
            tbHomePage.Text = My.Settings.SearchEngine
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Saves Search Engine
        Dim selected As RadioButton = GetGroupBoxCheckedButton(GroupBox1)
        My.Settings.SearchEngine = selected.Text

        'Save HomePage
        If UrlChecker.IsUrl(tbHomePage.Text) Then
            My.Settings.HomePage = tbHomePage.Text
        Else
            MessageBox.Show("Please enter a valid URL for the HomePage")
            Return
        End If

        Me.Close()
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As GroupBox) As RadioButton
        For Each ctrl As RadioButton In grpb.Controls
            If ctrl.Checked Then Return ctrl
        Next
    End Function
End Class
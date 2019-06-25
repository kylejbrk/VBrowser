Imports System.Text.RegularExpressions

Public Module UrlChecker
    Public Function IsUrl(ByRef url As String)
        Return Regex.IsMatch(url, "[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&\/=]*)")
    End Function

    Public Function GetSearchString()
        Select Case My.Settings.SearchEngine
            Case "Google"
                Return "https://www.google.com/search?q="
            Case "Bing"
                Return "https://www.bing.com/search?q="
            Case "DuckDuckGo"
                Return "https://duckduckgo.com/?q="
            Case Else
                Return "https://www.google.com/search?q="
        End Select
    End Function
End Module

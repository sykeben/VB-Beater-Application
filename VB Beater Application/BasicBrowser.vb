Public Class BasicBrowser
    Public Property DoNotGo As Boolean

    Public Overrides Function ToString() As String
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Function TryToGo() As Object
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
        Try
            BrowserFrame.Navigate(New Uri(UrlBox.Text))
        Catch
            DoNotGo = True
            MsgBox("Invalid URL format.", MsgBoxStyle.Exclamation, Title:="URL Error")
        End Try
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Sub BrowserFrame_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles BrowserFrame.Navigated
        UrlBox.Text = BrowserFrame.Url.ToString()
        LoadingBar.Visible = False
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        TryToGo()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        BrowserFrame.GoBack()
    End Sub

    Private Sub ForewardButton_Click(sender As Object, e As EventArgs) Handles ForewardButton.Click
        BrowserFrame.GoForward()
    End Sub

    Private Sub BrowserFrame_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles BrowserFrame.Navigating
        LoadingBar.Visible = True
    End Sub

    Private Sub UrlBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UrlBox.KeyDown
        If e.KeyCode = Keys.Return And DoNotGo = False Then
            TryToGo()
        End If
        If DoNotGo = True Then
            DoNotGo = False
        End If
    End Sub
End Class
Public Class Main
    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        About.Show()
    End Sub

    Private Sub LaunchElementGallery_Click(sender As Object, e As EventArgs) Handles LaunchElementGallery.Click
        ElementGallery.Show()
    End Sub

    Private Sub LaunchBasicBrowser_Click(sender As Object, e As EventArgs) Handles LaunchBasicBrowser.Click
        BasicBrowser.Show()
    End Sub
End Class

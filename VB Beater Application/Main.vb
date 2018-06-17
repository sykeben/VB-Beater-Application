Public Class Main
    '// NavigateWebURL sub by STiTCHiCKED on stackoverflow
    '// https://stackoverflow.com/users/1825282/stitchicked
    Private Sub NavigateWebURL(ByVal URL As String, Optional browser As String = "default")
        If Not (browser = "default") Then
            Try
                '// try set browser if there was an error (browser not installed)
                Process.Start(browser, URL)
            Catch ex As Exception
                '// use default browser
                Process.Start(URL)
            End Try
        Else
            '// use default browser
            Process.Start(URL)
        End If
    End Sub

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        About.Show()
    End Sub

    Private Sub LaunchElementGallery_Click(sender As Object, e As EventArgs) Handles LaunchElementGallery.Click
        ElementGallery.Show()
    End Sub

    Private Sub LaunchBasicBrowser_Click(sender As Object, e As EventArgs) Handles LaunchBasicBrowser.Click
        BasicBrowser.Show()
    End Sub

    Private Sub GitHubPageLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHubPageLink.LinkClicked
        NavigateWebURL("https://sykeben.github.io/")
    End Sub

    Private Sub LaunchGraphThing_Click(sender As Object, e As EventArgs) Handles LaunchGraphThing.Click
        GraphThing.Show()
    End Sub
End Class

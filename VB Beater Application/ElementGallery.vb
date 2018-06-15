Public Class ElementGallery
    Private Sub ButtonElement_Click(sender As Object, e As EventArgs) Handles ButtonElement.Click
        MsgBox("You clicked the button.", MsgBoxStyle.Information, Title:="Notice")
    End Sub

    Private Sub CheckBoxElement_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxElement.CheckedChanged
        If CheckBoxElement.Checked Then
            CheckBoxChecked.Visible = True
            CheckBoxUnchecked.Visible = False
        Else
            CheckBoxChecked.Visible = False
            CheckBoxUnchecked.Visible = True
        End If
    End Sub
End Class
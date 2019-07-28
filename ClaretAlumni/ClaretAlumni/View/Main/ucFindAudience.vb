
Public Class ucFindAudience
    Private Sub PanelBody_ControlAdded(sender As Object, e As ControlEventArgs) Handles PanelBody.ControlAdded
        PanelBody.Controls.Item(0).Size = PanelBody.Size
    End Sub
End Class

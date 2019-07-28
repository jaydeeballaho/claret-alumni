Public Class ucContactUs

    Private Sub LinkFacebook_MouseHover(sender As Object, e As EventArgs) Handles LinkFacebook.MouseHover
        LinkFacebook.ForeColor = Color.FromArgb(30, 100, 174)
    End Sub

    Private Sub LinkFacebook_MouseLeave(sender As Object, e As EventArgs) Handles LinkFacebook.MouseLeave
        LinkFacebook.ForeColor = Color.Black
    End Sub

    Private Sub LinkFacebook_Click(sender As Object, e As EventArgs) Handles LinkFacebook.Click
        Process.Start("https://www.facebook.com/jaydie.ballaho/")
        Process.Start("https://www.facebook.com/bossjsolutions/")
    End Sub
End Class

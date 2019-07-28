Imports System

Public Class frmMain

    Private flag As Integer = 1

    Dim Is1Click As Boolean = False
    Dim Is2Click As Boolean = False
    Dim Is3Click As Boolean = False
    Dim Is7Click As Boolean = False

    Dim ForeColorHover As Color = Color.FromArgb(231, 76, 60)
    Dim ForeColorDefault As Color = Color.White


    Sub HideAllEffect(effect As Panel)
        Effect1.Hide()
        Effect3.Hide()
        Effect7.Hide()
        effect.Show()
    End Sub

    Sub MakeAllIsClickFalse()
        Is1Click = False
        Is2Click = False
        Is3Click = False
        Is7Click = False
    End Sub

    Sub SetButtonDefaults(btn As Button, img As Image)
        btnAlumni.ForeColor = ForeColorDefault
        btnConnection.ForeColor = ForeColorDefault
        btnContact.ForeColor = ForeColorDefault
        btnAlumni.Image = My.Resources.mortarboard
        btnConnection.Image = My.Resources.gears
        btnContact.Image = My.Resources.contact
        btn.ForeColor = ForeColorHover
        btn.Image = img
    End Sub

    Private Sub btnAlumni_MouseHover(sender As Object, e As EventArgs) Handles btnAlumni.MouseHover
        btnAlumni.ForeColor = ForeColorHover
        btnAlumni.Image = My.Resources.mortarboard_2_
    End Sub

    Private Sub btnAlumni_MouseLeave(sender As Object, e As EventArgs) Handles btnAlumni.MouseLeave
        If Is1Click = False Then
            btnAlumni.ForeColor = ForeColorDefault
            btnAlumni.Image = My.Resources.mortarboard
        End If
    End Sub

    Private Sub btnConnection_MouseHover(sender As Object, e As EventArgs) Handles btnConnection.MouseHover
        btnConnection.ForeColor = ForeColorHover
        btnConnection.Image = My.Resources.gears__2_
    End Sub
    Private Sub btnConnection_MouseLeave(sender As Object, e As EventArgs) Handles btnConnection.MouseLeave
        If Is3Click = False Then
            btnConnection.ForeColor = ForeColorDefault
            btnConnection.Image = My.Resources.gears
        End If
    End Sub

    Private Sub btnContact_MouseHover(sender As Object, e As EventArgs) Handles btnContact.MouseHover
        btnContact.ForeColor = ForeColorHover
        btnContact.Image = My.Resources.contact_2_
    End Sub

    Private Sub btnContact_MouseLeave(sender As Object, e As EventArgs) Handles btnContact.MouseLeave
        If Is7Click = False Then
            btnContact.ForeColor = ForeColorDefault
            btnContact.Image = My.Resources.contact
        End If
    End Sub

    'Private Sub PanelBody_ControlAdded(sender As Object, e As ControlEventArgs) Handles PanelBody.ControlAdded
    '    PanelBody.Controls.Item(0).Size = PanelBody.Size
    'End Sub

    'Private Sub PanelBody_SizeChanged(sender As Object, e As EventArgs) Handles PanelBody.SizeChanged
    '    PanelBody.Controls.Item(0).Size = PanelBody.Size
    'End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        If Is7Click = False Then
            HideAllEffect(Effect7)
            MakeAllIsClickFalse()
            Is7Click = True
            SetButtonDefaults(btnContact, My.Resources.contact_2_)
            Dim obj As New ucContactUs
            PanelMainBody.Controls.Clear()
            PanelMainBody.Controls.Add(obj)
            obj.Show()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If flag = 1 Then
            If MessageBox.Show("Are you sure you want exit from the application?", "",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                '  frmLogin.Close()
            End If
        End If
    End Sub

    Private Sub btnPage_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        If Is3Click = False Then
            HideAllEffect(Effect3)
            MakeAllIsClickFalse()
            Is3Click = True
            SetButtonDefaults(btnConnection, My.Resources.gears__2_)
            Dim obj As New ucConnection
            PanelMainBody.Controls.Clear()
            PanelMainBody.Controls.Add(obj)
            obj.Show()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

    End Sub

    Private Sub btnChange_MouseHover(sender As Object, e As EventArgs) Handles btnChange.MouseHover
        btnChange.ForeColor = ForeColorHover
    End Sub

    Private Sub btnChange_MouseLeave(sender As Object, e As EventArgs) Handles btnChange.MouseLeave
        btnChange.ForeColor = ForeColorDefault
    End Sub

    Private Sub btnAlumni_Click(sender As Object, e As EventArgs) Handles btnAlumni.Click
        If Is1Click = False Then
            HideAllEffect(Effect1)
            MakeAllIsClickFalse()
            Is1Click = True
            SetButtonDefaults(btnAlumni, My.Resources.mortarboard_2_)
            Dim obj As New ucAlumni
            PanelMainBody.Controls.Clear()
            PanelMainBody.Controls.Add(obj)
            obj.Show()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnContact.PerformClick()
        lblHost.Text = My.Computer.Name
    End Sub
End Class
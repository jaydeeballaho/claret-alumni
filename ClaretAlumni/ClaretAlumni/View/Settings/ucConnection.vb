﻿Public Class ucConnection

    Private Sub ucConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHost.Text = My.Settings.Host
        txtPort.Text = My.Settings.PortNo
        txtDb.Text = My.Settings.Database
        txtUserName.Text = My.Settings.Username
        txtPw.Text = My.Settings.Password
    End Sub

    Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
        AllowedOnly(AlphaChar, txtHost)
    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        AllowedOnly(NumberOnly, txtPort)
    End Sub

    Private Sub txtDb_TextChanged(sender As Object, e As EventArgs) Handles txtDb.TextChanged
        AllowedOnly(AlphaChar, txtDb)
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        AllowedOnly(CodeOnly, txtUserName)
    End Sub

    Private Sub txtPw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged
        AllowedOnly(CodeOnly, txtPw)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim str As String = "Server=" & txtHost.Text & ";Port=" & txtPort.Text _
                                              & ";Database=" & txtDb.Text & ";User=" & txtUserName.Text _
                                              & ";Password=" & txtPw.Text & ";"
        If TestConnection(str) = True Then
            If MessageBox.Show("A new connection has been successfully established. Do you want to save this connection?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.Database = txtDb.Text
                My.Settings.Host = txtHost.Text
                My.Settings.PortNo = txtPort.Text
                My.Settings.Username = txtUserName.Text
                My.Settings.Password = txtPw.Text
                My.Settings.Save()
            End If
        Else
            MessageBox.Show("Connection failed. Please review connection fields.",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

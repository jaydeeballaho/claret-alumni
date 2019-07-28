Public Class ucAlumni

    Private AlumniObj As New AlumniController
    Private AddressObj As New AlumniAddressController
    Private ContactObj As New ContactPointsController
    Private EmploymentObj As New EmploymentController

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim obj As New ucNewAlumni
        frmMain.PanelMainBody.Controls.Clear()
        frmMain.PanelMainBody.Controls.Add(obj)
        obj.Show()
    End Sub

    Private Sub ucAlumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlumniObj.LoadBatchNo(cboBatch)
        cboBatch.Items.Add("All")
        AlumniObj.LoadSectiono(cboSection)
        cboSection.Items.Add("All")

        cboGender.SelectedIndex = cboGender.FindString("All")
        cboProgram.SelectedIndex = cboProgram.FindString("All")
        cboBatch.SelectedIndex = cboBatch.FindString("All")
        cboSection.SelectedIndex = cboSection.FindString("All")

        AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim obj As New ucEditAlumni
            obj.AlumniObj = Me.AlumniObj
            obj.AddressObj = Me.AddressObj
            obj.ContactObj = Me.ContactObj
            obj.EmploymentObj = Me.EmploymentObj
            frmMain.PanelMainBody.Controls.Clear()
            frmMain.PanelMainBody.Controls.Add(obj)
            obj.Show()
        ElseIf e.ColumnIndex = 8 Then
            If MessageBox.Show("Are you sure you want delete this Alumni?", "", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes Then
                AlumniObj.DeleteAlumni()
                AddressObj.DeleteAddress()
                ContactObj.DeleteContact()
                EmploymentObj.DeleteEmployment()
                AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
            End If
        End If
    End Sub

    Private Sub gvView_MouseDown(sender As Object, e As MouseEventArgs) Handles gvView.MouseDown
        Dim _ht As DataGridView.HitTestInfo = Me.gvView.HitTest(e.X, e.Y)
        If _ht.Type = DataGridViewHitTestType.Cell Then
            AlumniObj.SetAlumniDetails(Me.gvView.Rows(_ht.RowIndex).Cells(0).Value)
            AddressObj.SetAddressDetails(AlumniObj.ID)
            ContactObj.SetContactDetails(AlumniObj.ID)
            EmploymentObj.SetEmploymentDetails(AlumniObj.ID)
        End If
    End Sub

    Private Sub gvView_SelectionChanged(sender As Object, e As EventArgs) Handles gvView.SelectionChanged
        gvView.ClearSelection()
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
    End Sub

    Private Sub cboProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProgram.SelectedIndexChanged
        AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
    End Sub

    Private Sub cboBatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBatch.SelectedIndexChanged
        AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        AlumniObj.ViewAlumni(gvView, cboGender.Text, cboProgram.Text, cboBatch.Text, cboSection.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaChar, txtSearch)
        ToUpperOnly(CodeOnly, txtSearch)
        If txtSearch.Text.ToLower() <> "search alumni" Then
            AlumniObj.SearchAlumni(gvView, txtSearch.Text)
        End If
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        txtSearch.Text = ""
        txtSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.DarkGray
        txtSearch.Text = "Search Alumni"
    End Sub

End Class

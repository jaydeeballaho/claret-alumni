Public Class ucNewAlumni

    Private AlumniObj As New AlumniController
    Private AddressObj As New AlumniAddressController
    Private ContactObj As New ContactPointsController
    Private EmploymentObj As New EmploymentController

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim obj As New ucAlumni
        frmMain.PanelMainBody.Controls.Clear()
        frmMain.PanelMainBody.Controls.Add(obj)
        obj.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtFirstName, txtLastName) = True Then
            MessageBox.Show("First Name and Last Name is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cboProgram.SelectedIndex < 0 Then
            MessageBox.Show("Please select program.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cboBatchNo.Text.Trim = "" Then
            MessageBox.Show("Please select batch no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtEmail) = True Then
            MessageBox.Show("Email Address is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Add Alumni Info
            AlumniObj.FirstName = txtFirstName.Text
            AlumniObj.MiddleName = txtMiddleName.Text
            AlumniObj.LastName = txtLastName.Text
            AlumniObj.ExtName = txtExtName.Text
            AlumniObj.Gender = cboGender.Text
            AlumniObj.Birthday = dtpBirthday.Value
            AlumniObj.CivilStatus = cboStatus.Text
            AlumniObj.Program = cboProgram.Text
            AlumniObj.Batch = cboBatchNo.Text
            AlumniObj.Section = cboSection.Text
            AlumniObj.Photo = AlumniObj.ConvertImageTo64(pbPhoto.BackgroundImage)
            AlumniObj.AddAlumni()
            'Set Alumni ID
            AlumniObj.SetAlumniID()
            AddressObj.AlumniID = AlumniObj.ID
            'Add Alumni Address
            AddressObj.LotNo = txtLotNo.Text
            AddressObj.Street = txtStreet.Text
            AddressObj.Barangay = cboBarangay.Text
            AddressObj.City = txtCity.Text
            AddressObj.Province = txtProvince.Text
            AddressObj.ZipCode = txtZipCode.Text
            AddressObj.AddAddress()
            'Add Contact Points
            ContactObj.AlumniID = AlumniObj.ID
            ContactObj.Email = txtEmail.Text
            ContactObj.Contact = txtContact.Text
            ContactObj.AddContact()
            'Add Employment
            EmploymentObj.AlumniID = AlumniObj.ID
            If rbYes.Checked = True Then
                EmploymentObj.IsEmployed = 1
            Else
                EmploymentObj.IsEmployed = 0
            End If
            EmploymentObj.Employer = txtEmployer.Text
            EmploymentObj.Address = txtEmployerAddress.Text
            EmploymentObj.Length = cboLength.Text
            EmploymentObj.Type = cboType.Text
            EmploymentObj.Position = txtPosition.Text
            EmploymentObj.AddEmployment()
            'Return to View
            Dim obj As New ucAlumni
            frmMain.PanelMainBody.Controls.Clear()
            frmMain.PanelMainBody.Controls.Add(obj)
            obj.Show()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    MessageBox.Show("File no longer exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then
                        Dim EmployeePhoto As New Bitmap(ofd.FileName)
                        pbPhoto.BackgroundImageLayout = ImageLayout.Stretch
                        pbPhoto.BackgroundImage = ResizeImage(EmployeePhoto)
                    Else
                        MessageBox.Show("File is too large.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(pbPhoto.Width, pbPhoto.Height))
    End Function

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        pbPhoto.BackgroundImage = My.Resources.claret_coat_of_arms
    End Sub

    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        If rbYes.Checked = True Then
            txtEmployer.Enabled = True
            txtEmployerAddress.Enabled = True
            cboLength.Enabled = True
            cboType.Enabled = True
            txtPosition.Enabled = True
        End If
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        If rbNo.Checked = True Then
            txtEmployer.Enabled = False
            txtEmployerAddress.Enabled = False
            cboLength.Enabled = False
            cboType.Enabled = False
            txtPosition.Enabled = False
        End If
    End Sub

    Private Sub ucNewAlumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlumniObj.LoadCivilStatus(cboStatus)
        AlumniObj.LoadBatchNo(cboBatchNo)
        AlumniObj.LoadSectiono(cboSection)
        AddressObj.LoadBarangay(cboBarangay)
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        AllowedOnly(LetterOnly, txtFirstName)
        ToUpperOnly(CodeOnly, txtFirstName)
    End Sub

    Private Sub txtMiddleName_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleName.TextChanged
        AllowedOnly(LetterOnly, txtMiddleName)
        ToUpperOnly(CodeOnly, txtMiddleName)
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        AllowedOnly(LetterOnly, txtLastName)
        ToUpperOnly(CodeOnly, txtLastName)
    End Sub

    Private Sub txtExtName_TextChanged(sender As Object, e As EventArgs) Handles txtExtName.TextChanged
        AllowedOnly(AlphaChar, txtExtName)
        ToUpperOnly(CodeOnly, txtExtName)
    End Sub

    Private Sub txtLotNo_TextChanged(sender As Object, e As EventArgs) Handles txtLotNo.TextChanged
        AllowedOnly(AlphaChar, txtLotNo)
        ToUpperOnly(CodeOnly, txtLotNo)
    End Sub

    Private Sub txtStreet_TextChanged(sender As Object, e As EventArgs) Handles txtStreet.TextChanged
        AllowedOnly(AlphaChar, txtStreet)
        ToUpperOnly(CodeOnly, txtStreet)
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        AllowedOnly(AlphaChar, txtCity)
        ToUpperOnly(CodeOnly, txtCity)
    End Sub

    Private Sub txtProvince_TextChanged(sender As Object, e As EventArgs) Handles txtProvince.TextChanged
        AllowedOnly(AlphaChar, txtProvince)
        ToUpperOnly(CodeOnly, txtProvince)
    End Sub

    Private Sub txtZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtZipCode.TextChanged
        AllowedOnly(AlphaChar, txtZipCode)
        ToUpperOnly(CodeOnly, txtZipCode)
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        AllowedOnly(AlphaChar, txtEmail)
        ToUpperOnly(CodeOnly, txtEmail)
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        AllowedOnly(NumberWDashOnly, txtContact)
        PhoneFormat(txtContact)
    End Sub

    Private Sub txtEmployer_TextChanged(sender As Object, e As EventArgs) Handles txtEmployer.TextChanged
        AllowedOnly(AlphaChar, txtEmployer)
        ToUpperOnly(CodeOnly, txtEmployer)
    End Sub

    Private Sub txtEmployerAddress_TextChanged(sender As Object, e As EventArgs) Handles txtEmployerAddress.TextChanged
        AllowedOnly(AlphaChar, txtEmployerAddress)
        ToUpperOnly(CodeOnly, txtEmployerAddress)
    End Sub

    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged
        AllowedOnly(AlphaChar, txtPosition)
        ToUpperOnly(CodeOnly, txtPosition)
    End Sub
End Class

Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging

Public Class AlumniController
    Inherits Alumni

    Public Sub LoadCivilStatus(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT civil_status FROM personal ORDER BY civil_status ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    With cbo
                        .Items.Add(reader(0))
                    End With
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadBatchNo(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT batch_no FROM personal ORDER BY batch_no ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    With cbo
                        .Items.Add(reader(0))
                    End With
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadSectiono(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT section_no FROM personal ORDER BY section_no ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    With cbo
                        .Items.Add(reader(0))
                    End With
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetAlumniID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                ID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConvertImageTo64(img As Image) As String
        Try
            Dim photo_img As Byte()
            Dim ms As New System.IO.MemoryStream()
            img.Save(ms, ImageFormat.Bmp)
            photo_img = ms.ToArray()
            ms.Dispose()
            Dim base64 As String = Convert.ToBase64String(photo_img)
            Return base64
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Base64ToImage(str As String) As Image
        Try
            Dim mybyte() As Byte = Convert.FromBase64String(str)
            Dim ms As New System.IO.MemoryStream(mybyte)
            Dim img As Image
            img = Image.FromStream(ms)
            Return img
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SetAlumniDetails(x As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM personal WHERE id = @0;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                ServerExecuteSQLReader(sql, x)
                While getReader.Read()
                    ID = getReader(0)
                    FirstName = getReader(1)
                    MiddleName = getReader(2)
                    LastName = getReader(3)
                    ExtName = getReader(4)
                    Gender = getReader(5)
                    Birthday = getReader(6)
                    CivilStatus = getReader(7)
                    Program = getReader(8)
                    Batch = getReader(9)
                    Section = getReader(10)
                    Photo = getReader(11)
                End While
                getReader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddAlumni() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO personal (first_name,middle_name,last_name,extension_name,gender,birthday,civil_status,program,batch_no,section_no,photo) VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FirstName, MiddleName, LastName, ExtName, Gender, Birthday, CivilStatus, Program, Batch, Section, Photo)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditAlumni() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE personal SET first_name=@0,middle_name=@1,last_name=@2,extension_name=@3,gender=@4,birthday=@5,civil_status=@6,program=@7,batch_no=@8,section_no=@9,photo=@10 WHERE id = @11"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FirstName, MiddleName, LastName, ExtName, Gender, Birthday, CivilStatus, Program, Batch, Section, Photo, ID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteAlumni() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM personal WHERE id = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, ID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub ViewAlumni(gv As DataGridView, gender As String, program As String, batch As String, section As String)
        Try
            If gender = "All" Then
                gender = ""
            End If
            If program = "All" Then
                program = ""
            End If
            If batch = "All" Then
                batch = ""
            End If
            If section = "All" Then
                section = ""
            End If
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM personal WHERE (gender LIKE @0 and program LIKE @1 and batch_no LIKE @2 and section_no LIKE @3) ORDER BY last_name ASC, first_name ASC, middle_name ASC;"
            If IsConnected() = True Then
                ServerExecuteSQLReader(sql, gender + "%", program + "%", batch + "%", section + "%")
                gv.Rows.Clear()
                While getReader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(getReader(0), i, getReader(3) + ", " + getReader(1) + " " + getReader(2) + " " + getReader(4),
                                   getReader(5), getReader(8), getReader(9), getReader(10), "Edit", "Delete")
                    End With
                End While
                CloseReader()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SearchAlumni(gv As DataGridView, kw As String)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM personal WHERE (gender LIKE @0 or program LIKE @0 or batch_no LIKE @0 or section_no LIKE @0 or last_name LIKE @0 or first_name LIKE @0 or CONCAT(last_name, ', ',first_name) LIKE @0) ORDER BY last_name ASC, first_name ASC, middle_name ASC;"
            If IsConnected() = True Then
                ServerExecuteSQLReader(sql, kw + "%")
                gv.Rows.Clear()
                While getReader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(getReader(0), i, getReader(3) + ", " + getReader(1) + " " + getReader(2) + " " + getReader(4),
                                   getReader(5), getReader(8), getReader(9), getReader(10), "Edit", "Delete")
                    End With
                End While
                CloseReader()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class

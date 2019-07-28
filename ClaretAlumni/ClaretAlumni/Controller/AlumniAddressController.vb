Imports MySql.Data.MySqlClient

Public Class AlumniAddressController

    Inherits AlumniAddress

    Public Sub LoadBarangay(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT barangay FROM address ORDER BY barangay ASC;"
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

    Public Sub SetAddressDetails(x As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM address WHERE personal_id = " & x & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ID = reader(0)
                    AlumniID = reader(1)
                    LotNo = reader(2)
                    Street = reader(3)
                    Barangay = reader(4)
                    City = reader(5)
                    Province = reader(6)
                    ZipCode = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddAddress() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO address (personal_id,lot_no,street,barangay,city,province,zip_code,type) VALUES (@0,@1,@2,@3,@4,@5,@6,@7);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, LotNo, Street, Barangay, City, Province, ZipCode, "Current")
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditAddress() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE address SET personal_id=@0,lot_no=@1,street=@2,barangay=@3,city=@4,province=@5,zip_code=@6 WHERE personal_id = @7"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, LotNo, Street, Barangay, City, Province, ZipCode, AlumniID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteAddress() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM address WHERE personal_id = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

End Class

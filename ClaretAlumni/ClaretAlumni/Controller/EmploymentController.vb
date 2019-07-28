Imports MySql.Data.MySqlClient

Public Class EmploymentController

    Inherits Employment

    Public Sub SetEmploymentDetails(x As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Employment WHERE personal_id = " & x & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ID = reader(0)
                    AlumniID = reader(1)
                    IsEmployed = reader(2)
                    Employer = reader(3)
                    Address = reader(4)
                    Length = reader(5)
                    Type = reader(6)
                    Position = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddEmployment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Employment (personal_id,is_employed,employer,address,length_of_stay,employment_type,position) VALUES (@0,@1,@2,@3,@4,@5,@6);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, IsEmployed, Employer, Address, Length, Type, Position)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditEmployment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Employment SET personal_id=@0,is_employed=@1,employer=@2,address=@3,length_of_stay=@4,employment_type=@5,position=@6 WHERE personal_id = @7"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, IsEmployed, Employer, Address, Length, Type, Position, AlumniID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteEmployment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Employment WHERE personal_id = @0;"
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

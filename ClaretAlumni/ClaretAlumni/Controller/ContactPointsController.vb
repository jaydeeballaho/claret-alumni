Imports MySql.Data.MySqlClient

Public Class ContactPointsController

    Inherits ContactPoints

    Public Sub SetContactDetails(x As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM contact_points WHERE personal_id = " & x & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ID = reader(0)
                    AlumniID = reader(1)
                    Email = reader(2)
                    Contact = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddContact() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO contact_points (personal_id,email,contact_no) VALUES (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, Email, Contact)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditContact() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE contact_points SET personal_id=@0,email=@1,contact_no=@2 WHERE personal_id = @3"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AlumniID, Email, Contact, AlumniID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteContact() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM contact_points WHERE personal_id = @0;"
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

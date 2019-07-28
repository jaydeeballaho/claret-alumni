Public Class Employment

    Private _id As Integer
    Public Property ID As Integer
        Set(value As Integer)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property

    Private _alumni_id As Integer
    Public Property AlumniID As Integer
        Set(value As Integer)
            _alumni_id = value
        End Set
        Get
            Return _alumni_id
        End Get
    End Property

    Private _is_employed As Integer
    Public Property IsEmployed As Integer
        Set(value As Integer)
            _is_employed = value
        End Set
        Get
            Return _is_employed
        End Get
    End Property

    Private _employer As String
    Public Property Employer As String
        Set(value As String)
            _employer = value
        End Set
        Get
            Return _employer
        End Get
    End Property

    Private _address As String
    Public Property Address As String
        Set(value As String)
            _address = value
        End Set
        Get
            Return _address
        End Get
    End Property

    Private _length As String
    Public Property Length As String
        Set(value As String)
            _length = value
        End Set
        Get
            Return _length
        End Get
    End Property

    Private _type As String
    Public Property Type As String
        Set(value As String)
            _type = value
        End Set
        Get
            Return _type
        End Get
    End Property

    Private _position As String
    Public Property Position As String
        Set(value As String)
            _position = value
        End Set
        Get
            Return _position
        End Get
    End Property

End Class

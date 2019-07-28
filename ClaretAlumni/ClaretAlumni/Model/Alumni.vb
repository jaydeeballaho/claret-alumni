Public Class Alumni

    Private _id As Integer
    Public Property ID As Integer
        Set(value As Integer)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property

    Private _fn As String
    Public Property FirstName As String
        Set(value As String)
            _fn = value
        End Set
        Get
            Return _fn
        End Get
    End Property

    Private _mn As String
    Public Property MiddleName As String
        Set(value As String)
            _mn = value
        End Set
        Get
            Return _mn
        End Get
    End Property

    Private _ln As String
    Public Property LastName As String
        Set(value As String)
            _ln = value
        End Set
        Get
            Return _ln
        End Get
    End Property

    Private _en As String
    Public Property ExtName As String
        Set(value As String)
            _en = value
        End Set
        Get
            Return _en
        End Get
    End Property

    Private _gender As String
    Public Property Gender As String
        Set(value As String)
            _gender = value
        End Set
        Get
            Return _gender
        End Get
    End Property

    Private _birthday As Date
    Public Property Birthday As Date
        Set(value As Date)
            _birthday = value
        End Set
        Get
            Return _birthday
        End Get
    End Property

    Private _civil_status As String
    Public Property CivilStatus As String
        Set(value As String)
            _civil_status = value
        End Set
        Get
            Return _civil_status
        End Get
    End Property

    Private _program As String
    Public Property Program As String
        Set(value As String)
            _program = value
        End Set
        Get
            Return _program
        End Get
    End Property

    Private _batch As String
    Public Property Batch As String
        Set(value As String)
            _batch = value
        End Set
        Get
            Return _batch
        End Get
    End Property

    Private _section As String
    Public Property Section As String
        Set(value As String)
            _section = value
        End Set
        Get
            Return _section
        End Get
    End Property

    Private _photo As String
    Public Property Photo As String
        Set(value As String)
            _photo = value
        End Set
        Get
            Return _photo
        End Get
    End Property

End Class

Public Class ContactPoints

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

    Private _email As String
    Public Property Email As String
        Set(value As String)
            _email = value
        End Set
        Get
            Return _email
        End Get
    End Property

    Private _contact As String
    Public Property Contact As String
        Set(value As String)
            _contact = value
        End Set
        Get
            Return _contact
        End Get
    End Property

End Class

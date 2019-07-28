Public Class AlumniAddress

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

    Private _lot_no As String
    Public Property LotNo As String
        Set(value As String)
            _lot_no = value
        End Set
        Get
            Return _lot_no
        End Get
    End Property

    Private _street As String
    Public Property Street As String
        Set(value As String)
            _street = value
        End Set
        Get
            Return _street
        End Get
    End Property

    Private _brgy As String
    Public Property Barangay As String
        Set(value As String)
            _brgy = value
        End Set
        Get
            Return _brgy
        End Get
    End Property

    Private _city As String
    Public Property City As String
        Set(value As String)
            _city = value
        End Set
        Get
            Return _city
        End Get
    End Property

    Private _province As String
    Public Property Province As String
        Set(value As String)
            _province = value
        End Set
        Get
            Return _province
        End Get
    End Property

    Private _zip_code As String
    Public Property ZipCode As String
        Set(value As String)
            _zip_code = value
        End Set
        Get
            Return _zip_code
        End Get
    End Property

End Class

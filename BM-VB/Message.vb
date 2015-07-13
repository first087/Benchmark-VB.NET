Friend Class Message
    Private _what As Integer
    Private _obj As Object

    Public Property what() As Integer
        Get
            Return _what
        End Get
        Set(ByVal value As Integer)
            _what = value
        End Set
    End Property

    Public Property obj() As Object
        Get
            Return _obj
        End Get
        Set(ByVal value As Object)
            _obj = value
        End Set
    End Property
End Class

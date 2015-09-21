Friend Class BM_Loop_Recursive
    Inherits BMBase

    Friend Sub New(ByVal randomItem As Integer)
        MyBase.New(randomItem)
    End Sub

    Protected Overrides Sub RunCase(ByVal bmCase As Byte, ByVal bmInput As Byte)
        Dim result As Integer = 0

        Select Case bmCase
            Case 1  ' For
                For i As Byte = 0 To bmInput - 1
                    result += i
                Next
            Case 2  ' Recursive
                result = RecursiveCase(0, bmInput)
        End Select
    End Sub

    Private Function RecursiveCase(ByVal i As Integer, ByVal bmInput As Byte) As Integer
        Dim sum As Integer = 0

        If i < bmInput Then
            sum = i + RecursiveCase(i + 1, bmInput)
        End If

        Return sum
    End Function
End Class

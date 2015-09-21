Friend Class BM_Loop
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
            Case 2  ' While
                Dim i As Byte = 0
                While i < bmInput
                    result += i
                    i += 1
                End While
            Case 3  ' Do-While
                Dim i As Byte = 0
                Do
                    result += i
                    i += 1
                Loop While i < bmInput
        End Select
    End Sub
End Class

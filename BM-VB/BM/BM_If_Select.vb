Friend Class BM_If_Select
    Inherits BMBase

    Friend Sub New(ByVal randomItem As Integer)
        MyBase.New(randomItem)
    End Sub

    Protected Overrides Sub RunCase(ByVal bmCase As Byte, ByVal bmInput As Byte)
        Dim result As String

        Select Case bmCase
            Case 1  ' If-Else
                If bmInput >= 80 Then
                    result = "A"
                ElseIf bmInput >= 70 Then
                    result = "B"
                ElseIf bmInput >= 60 Then
                    result = "C"
                ElseIf bmInput >= 50 Then
                    result = "D"
                Else
                    result = "F"
                End If
            Case 2  ' Select-Case
                Select Case bmInput
                    Case Is >= 80
                        result = "A"
                    Case Is >= 70
                        result = "B"
                    Case Is >= 60
                        result = "C"
                    Case Is >= 50
                        result = "D"
                    Case Else
                        result = "F"
                End Select
        End Select
    End Sub
End Class

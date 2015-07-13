Friend Class BM_If
    Inherits BMBase

    Friend Sub New(ByVal randomItem As Integer)
        MyBase.New(randomItem)
    End Sub

    Protected Overrides Sub RunCase(ByVal bmCase As Byte, ByVal bmInput As Byte)
        Dim result As Boolean

        Select Case bmCase
            Case 1  ' If-Else
                If bmInput >= 50 Then
                    result = True
                Else
                    result = False
                End If
            Case 2  ' Default-If
                result = False
                If bmInput >= 50 Then result = True
            Case 3  ' If Operator
                result = If(bmInput >= 50, True, False)
        End Select
    End Sub
End Class

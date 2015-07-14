Friend MustInherit Class BMBase
    Implements IDisposable

    Private RANDOM_MIN As Integer = 1
    Private RANDOM_MAX As Integer = 100

    Private randomList As List(Of Byte)

    Friend Sub New(ByVal randomItem As Integer)
        randomList = New List(Of Byte)

        Dim rnd As New Random()

        For i As Integer = 1 To randomItem
            Try
                randomList.Add(rnd.Next(RANDOM_MIN, RANDOM_MAX + 1))
            Catch ex As OutOfMemoryException
                Exit For
            End Try
        Next
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

    Protected MustOverride Sub RunCase(ByVal bmCase As Byte, ByVal bmInput As Byte)

    Friend Function Run(ByVal bmCase As Byte) As Double
        Dim startTime As Date = Now

        For Each Item As Byte In randomList
            RunCase(bmCase, Item)
        Next

        Dim endTime As Date = Now

        Return (endTime - startTime).TotalMilliseconds
    End Function

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            randomList.Clear()

            ' TODO: set large fields to null.
            randomList = Nothing
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class

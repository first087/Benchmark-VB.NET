Public Class FrmBM

    ' TODO: Set benchmark header
    'Private Const BM_HEADER As String = "If"
    'Private Const BM_HEADER As String = "If vs Select"
    Private Const BM_HEADER As String = "Loop"

    ' TODO: Set benchmark case
    'Private ReadOnly COLUMN_HEADERS As String() = {"If-Else", "Default-If", "If Operator"}
    'Private ReadOnly COLUMN_HEADERS As String() = {"If-ElseIf-Else", "Select-Case"}
    Private ReadOnly COLUMN_HEADERS As String() = {"For", "While", "Do-While"}

    Private Const MAX_ROUND As Byte = 10    ' DO NOT CHANGE
    Private Const MAX_LOOP_PER_ROUND As Integer = 10000000  ' Use Integer.MaxValue for Maximum your memory

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Text = String.Format(Text, BM_HEADER)

        Do
            LvResult.Columns.RemoveAt(1)
        Loop Until LvResult.Columns.Count = 1

        For Each column_header As String In COLUMN_HEADERS
            LvResult.Columns.Add(column_header, 120, HorizontalAlignment.Center)
        Next

        Reset()
    End Sub

    Private Sub Reset()
        LvResult.Items.Clear()
        Progress.Value = 0
    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        Reset()

        Num10M.Enabled = False
        BtnStart.Enabled = False
        Cursor = Cursors.WaitCursor

        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        Dim message As Message
        Dim messageResult As New Message()

        Dim sumResult(COLUMN_HEADERS.Length - 1) As Double

        For i As Byte = 0 To MAX_ROUND - 1
            ' TODO: Change to your benchmark class
            Using bm As New BM_Loop(MAX_LOOP_PER_ROUND * Num10M.Value)
                message = New Message()
                message.what = 1            ' Start loop
                message.obj = Nothing

                Dim progress As Integer = i * 10 + 1

                bwRun.ReportProgress(progress, message)

                message = New Message()
                message.what = 2            ' Send result
                message.obj = messageResult ' Result

                ' TODO: Benchmark "Choice A"
                Dim resultA As Double = bm.Run(1)

                messageResult.obj = resultA ' Data
                sumResult(0) += resultA

                bwRun.ReportProgress(progress + 3, message)

                If COLUMN_HEADERS.Length >= 2 Then
                    ' TODO: Benchmark "Choice B"
                    Dim resultB As Double = bm.Run(2)

                    messageResult.obj = resultB ' Data
                    sumResult(1) += resultB

                    bwRun.ReportProgress(progress + 6, message)
                End If

                If COLUMN_HEADERS.Length >= 3 Then
                    ' TODO: Benchmark "Choice C"
                    Dim resultC As Double = bm.Run(3)

                    messageResult.obj = resultC ' Data
                    sumResult(2) += resultC

                    bwRun.ReportProgress(progress + 9, message)
                End If
            End Using
        Next

        ' ----- Summary -----
        message = New Message()
        message.what = 3                ' Summary
        message.obj = sumResult         ' Data
        bwRun.ReportProgress(100, message)
    End Sub

    Private Sub bwRun_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwRun.ProgressChanged
        Progress.Value = e.ProgressPercentage

        Static subItem As ListViewItem.ListViewSubItemCollection = Nothing

        Dim message As Message = DirectCast(e.UserState, Message)

        Select Case message.what
            Case 1  ' Start loop
                Dim item As ListViewItem = LvResult.Items.Add((LvResult.Items.Count + 1).ToString())
                item.EnsureVisible()
                subItem = item.SubItems
            Case 2  ' Send result
                Dim messageResult As Message = DirectCast(message.obj, Message)
                subItem.Add(DirectCast(messageResult.obj, Double).ToString("#,##0.0000"))
            Case 3  ' Summary
                Dim sumResult() As Double = DirectCast(message.obj, Double())

                subItem = LvResult.Items.Add("---").SubItems
                For i As Integer = 0 To sumResult.Length - 1
                    subItem.Add("----------")
                Next

                subItem = LvResult.Items.Add("Sum").SubItems
                For i As Integer = 0 To sumResult.Length - 1
                    subItem.Add(sumResult(i).ToString("#,##0.0000"))
                Next

                LvResult.Items(LvResult.Items.Count - 1).ForeColor = Color.DarkGreen

                subItem = LvResult.Items.Add("Avg").SubItems
                For i As Integer = 0 To sumResult.Length - 1
                    subItem.Add((sumResult(i) / MAX_ROUND).ToString("#,##0.0000"))
                Next

                LvResult.Items(LvResult.Items.Count - 1).ForeColor = Color.DarkBlue
                LvResult.Items(LvResult.Items.Count - 1).EnsureVisible()
        End Select
    End Sub

    Private Sub bwRun_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        Progress.Value = 100

        Cursor = Cursors.Default
        Num10M.Enabled = True
        BtnStart.Enabled = True
    End Sub
End Class

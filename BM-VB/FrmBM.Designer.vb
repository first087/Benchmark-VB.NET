<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bwRun = New System.ComponentModel.BackgroundWorker
        Me.BtnStart = New System.Windows.Forms.Button
        Me.LvResult = New System.Windows.Forms.ListView
        Me.ColRound = New System.Windows.Forms.ColumnHeader
        Me.ColChoice1 = New System.Windows.Forms.ColumnHeader
        Me.ColChoice2 = New System.Windows.Forms.ColumnHeader
        Me.ColChoice3 = New System.Windows.Forms.ColumnHeader
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'bwRun
        '
        Me.bwRun.WorkerReportsProgress = True
        Me.bwRun.WorkerSupportsCancellation = True
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnStart.Location = New System.Drawing.Point(199, 281)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 4
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'LvResult
        '
        Me.LvResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColRound, Me.ColChoice1, Me.ColChoice2, Me.ColChoice3})
        Me.LvResult.Location = New System.Drawing.Point(12, 6)
        Me.LvResult.Name = "LvResult"
        Me.LvResult.Size = New System.Drawing.Size(448, 269)
        Me.LvResult.TabIndex = 3
        Me.LvResult.UseCompatibleStateImageBehavior = False
        Me.LvResult.View = System.Windows.Forms.View.Details
        '
        'ColRound
        '
        Me.ColRound.Text = "Round"
        '
        'ColChoice1
        '
        Me.ColChoice1.Text = "Choice1"
        Me.ColChoice1.Width = 120
        '
        'ColChoice2
        '
        Me.ColChoice2.Text = "Choice2"
        Me.ColChoice2.Width = 120
        '
        'ColChoice3
        '
        Me.ColChoice3.Text = "Choice3"
        Me.ColChoice3.Width = 120
        '
        'Progress
        '
        Me.Progress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Progress.Location = New System.Drawing.Point(0, 316)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(472, 10)
        Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progress.TabIndex = 5
        Me.Progress.Value = 30
        '
        'FrmBM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(472, 326)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LvResult)
        Me.Controls.Add(Me.Progress)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(480, 240)
        Me.Name = "FrmBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benchmark {0}"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents LvResult As System.Windows.Forms.ListView
    Friend WithEvents ColRound As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar

End Class

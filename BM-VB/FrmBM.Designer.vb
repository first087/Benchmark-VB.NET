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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Num10M = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Num10M, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwRun
        '
        Me.bwRun.WorkerReportsProgress = True
        Me.bwRun.WorkerSupportsCancellation = True
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.Location = New System.Drawing.Point(385, 287)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 1
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
        Me.LvResult.Size = New System.Drawing.Size(448, 275)
        Me.LvResult.TabIndex = 2
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Loop per round = "
        '
        'Num10M
        '
        Me.Num10M.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Num10M.Location = New System.Drawing.Point(127, 288)
        Me.Num10M.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Num10M.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num10M.Name = "Num10M"
        Me.Num10M.ReadOnly = True
        Me.Num10M.Size = New System.Drawing.Size(38, 23)
        Me.Num10M.TabIndex = 0
        Me.Num10M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Num10M.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "x 10,000,000"
        '
        'FrmBM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(472, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Num10M)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LvResult)
        Me.Controls.Add(Me.Progress)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(480, 240)
        Me.Name = "FrmBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benchmark {0}"
        CType(Me.Num10M, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents LvResult As System.Windows.Forms.ListView
    Friend WithEvents ColRound As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColChoice3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Num10M As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

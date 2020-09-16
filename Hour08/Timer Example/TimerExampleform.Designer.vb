<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerExampleform
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
        Me.tmrClock = New System.Windows.Forms.Timer()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'lblClock
        '
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClock.Location = New System.Drawing.Point(95, 120)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(100, 23)
        Me.lblClock.TabIndex = 0
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerExampleform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblClock)
        Me.Name = "TimerExampleform"
        Me.Text = "Timer Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoRemaindersForm
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
        Me.btnFindNumbers = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFindNumbers
        '
        Me.btnFindNumbers.Location = New System.Drawing.Point(82, 39)
        Me.btnFindNumbers.Name = "btnFindNumbers"
        Me.btnFindNumbers.Size = New System.Drawing.Size(120, 23)
        Me.btnFindNumbers.TabIndex = 0
        Me.btnFindNumbers.Text = "Find Numbers"
        Me.btnFindNumbers.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(82, 68)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 160)
        Me.lstResults.TabIndex = 1
        '
        'NoRemaindersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnFindNumbers)
        Me.Name = "NoRemaindersForm"
        Me.Text = "No Remainders"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFindNumbers As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox

End Class

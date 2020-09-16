<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Child1Form
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
        Me.btnShowChild2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowChild2
        '
        Me.btnShowChild2.Location = New System.Drawing.Point(105, 100)
        Me.btnShowChild2.Name = "btnShowChild2"
        Me.btnShowChild2.Size = New System.Drawing.Size(85, 23)
        Me.btnShowChild2.TabIndex = 0
        Me.btnShowChild2.Text = "Show Child 2"
        Me.btnShowChild2.UseVisualStyleBackColor = True
        '
        'Child1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnShowChild2)
        Me.Name = "Child1Form"
        Me.Text = "Child 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowChild2 As System.Windows.Forms.Button
End Class

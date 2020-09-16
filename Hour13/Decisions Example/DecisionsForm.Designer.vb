<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecisionsForm
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnIsNumeric = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(44, 44)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnIsNumeric
        '
        Me.btnIsNumeric.Location = New System.Drawing.Point(156, 42)
        Me.btnIsNumeric.Name = "btnIsNumeric"
        Me.btnIsNumeric.Size = New System.Drawing.Size(100, 23)
        Me.btnIsNumeric.TabIndex = 1
        Me.btnIsNumeric.Text = "Is text numeric?"
        Me.btnIsNumeric.UseVisualStyleBackColor = True
        '
        'DecisionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnIsNumeric)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "DecisionsForm"
        Me.Text = "Decisions Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnIsNumeric As System.Windows.Forms.Button

End Class

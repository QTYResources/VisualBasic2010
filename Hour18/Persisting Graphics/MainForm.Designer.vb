<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnDrawText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(56, 184)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnDrawText
        '
        Me.btnDrawText.Location = New System.Drawing.Point(162, 182)
        Me.btnDrawText.Name = "btnDrawText"
        Me.btnDrawText.Size = New System.Drawing.Size(75, 23)
        Me.btnDrawText.TabIndex = 1
        Me.btnDrawText.Text = "Draw Text"
        Me.btnDrawText.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDrawText)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "MainForm"
        Me.Text = "Persisting Graphics Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnDrawText As System.Windows.Forms.Button

End Class

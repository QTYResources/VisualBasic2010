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
        Me.btnShowCustomDialogBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowCustomDialogBox
        '
        Me.btnShowCustomDialogBox.Location = New System.Drawing.Point(67, 180)
        Me.btnShowCustomDialogBox.Name = "btnShowCustomDialogBox"
        Me.btnShowCustomDialogBox.Size = New System.Drawing.Size(152, 23)
        Me.btnShowCustomDialogBox.TabIndex = 0
        Me.btnShowCustomDialogBox.Text = "Show Custom Dialog Box"
        Me.btnShowCustomDialogBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnShowCustomDialogBox)
        Me.Name = "MainForm"
        Me.Text = "Custom Dialog Box Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowCustomDialogBox As System.Windows.Forms.Button

End Class

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
        Me.btnAutomateExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAutomateExcel
        '
        Me.btnAutomateExcel.Location = New System.Drawing.Point(90, 128)
        Me.btnAutomateExcel.Name = "btnAutomateExcel"
        Me.btnAutomateExcel.Size = New System.Drawing.Size(104, 23)
        Me.btnAutomateExcel.TabIndex = 0
        Me.btnAutomateExcel.Text = "Automate Excel"
        Me.btnAutomateExcel.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAutomateExcel)
        Me.Name = "MainForm"
        Me.Text = "Automate Excel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAutomateExcel As System.Windows.Forms.Button

End Class

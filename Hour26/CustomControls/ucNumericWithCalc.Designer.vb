<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNumericWithCalc
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNumericWithCalc))
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.numTextbox = New CustomControls.ctlNumericTextbox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.Location = New System.Drawing.Point(106, 0)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(25, 20)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'numTextbox
        '
        Me.numTextbox.Location = New System.Drawing.Point(0, 0)
        Me.numTextbox.Name = "numTextbox"
        Me.numTextbox.Size = New System.Drawing.Size(100, 20)
        Me.numTextbox.TabIndex = 0
        '
        'ucNumericWithCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.numTextbox)
        Me.Name = "ucNumericWithCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numTextbox As CustomControls.ctlNumericTextbox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class

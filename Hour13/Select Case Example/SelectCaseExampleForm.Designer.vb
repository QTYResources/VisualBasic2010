<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCaseExampleForm
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
        Me.cboAnimals = New System.Windows.Forms.ComboBox()
        Me.btnShowLegs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboAnimals
        '
        Me.cboAnimals.FormattingEnabled = True
        Me.cboAnimals.Items.AddRange(New Object() {"Horse", "Dog", "Bird", "Cat", "Snake", "Centipede"})
        Me.cboAnimals.Location = New System.Drawing.Point(80, 100)
        Me.cboAnimals.Name = "cboAnimals"
        Me.cboAnimals.Size = New System.Drawing.Size(121, 21)
        Me.cboAnimals.TabIndex = 0
        '
        'btnShowLegs
        '
        Me.btnShowLegs.Location = New System.Drawing.Point(102, 130)
        Me.btnShowLegs.Name = "btnShowLegs"
        Me.btnShowLegs.Size = New System.Drawing.Size(75, 23)
        Me.btnShowLegs.TabIndex = 1
        Me.btnShowLegs.Text = "Show Legs"
        Me.btnShowLegs.UseVisualStyleBackColor = True
        '
        'SelectCaseExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnShowLegs)
        Me.Controls.Add(Me.cboAnimals)
        Me.Name = "SelectCaseExampleForm"
        Me.Text = "Select Case Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboAnimals As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowLegs As System.Windows.Forms.Button

End Class

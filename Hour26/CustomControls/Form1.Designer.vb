﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CtlNumericTextbox1 = New CustomControls.ctlNumericTextbox()
        Me.numInput = New CustomControls.ucNumericWithCalc()
        Me.SuspendLayout()
        '
        'CtlNumericTextbox1
        '
        Me.CtlNumericTextbox1.Location = New System.Drawing.Point(91, 95)
        Me.CtlNumericTextbox1.Name = "CtlNumericTextbox1"
        Me.CtlNumericTextbox1.Size = New System.Drawing.Size(100, 20)
        Me.CtlNumericTextbox1.TabIndex = 0
        '
        'numInput
        '
        Me.numInput.CalcButtonVisible = True
        Me.numInput.Location = New System.Drawing.Point(58, 58)
        Me.numInput.Name = "numInput"
        Me.numInput.Size = New System.Drawing.Size(162, 20)
        Me.numInput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.numInput)
        Me.Controls.Add(Me.CtlNumericTextbox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtlNumericTextbox1 As CustomControls.ctlNumericTextbox
    Friend WithEvents numInput As CustomControls.ucNumericWithCalc

End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassExampleForm
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
        Me.btnCreateObject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateObject
        '
        Me.btnCreateObject.Location = New System.Drawing.Point(100, 120)
        Me.btnCreateObject.Name = "btnCreateObject"
        Me.btnCreateObject.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateObject.TabIndex = 0
        Me.btnCreateObject.Text = "Create Object"
        Me.btnCreateObject.UseVisualStyleBackColor = True
        '
        'ClassExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCreateObject)
        Me.Name = "ClassExampleForm"
        Me.Text = "Class Programming Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateObject As System.Windows.Forms.Button

End Class

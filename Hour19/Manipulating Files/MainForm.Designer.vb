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
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnCopyFile = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(95, 8)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(184, 20)
        Me.txtSource.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(9, 6)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(80, 23)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "Source:"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(95, 34)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(184, 20)
        Me.txtDestination.TabIndex = 2
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(9, 31)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveFile.TabIndex = 3
        Me.btnSaveFile.Text = "Destination:"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'btnCopyFile
        '
        Me.btnCopyFile.Location = New System.Drawing.Point(95, 71)
        Me.btnCopyFile.Name = "btnCopyFile"
        Me.btnCopyFile.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyFile.TabIndex = 4
        Me.btnCopyFile.Text = "Copy"
        Me.btnCopyFile.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(95, 100)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 5
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(95, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnCopyFile)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.txtSource)
        Me.Name = "MainForm"
        Me.Text = "Manipulating Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCopyFile As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class

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
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpNewRecord = New System.Windows.Forms.GroupBox()
        Me.txtNewContactName = New System.Windows.Forms.TextBox()
        Me.txtNewState = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpNewRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(48, 112)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(112, 20)
        Me.txtContactName.TabIndex = 0
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(168, 112)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(80, 20)
        Me.txtState.TabIndex = 1
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(12, 152)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(32, 23)
        Me.btnMoveFirst.TabIndex = 2
        Me.btnMoveFirst.Text = "<<"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Location = New System.Drawing.Point(48, 152)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(32, 23)
        Me.btnMovePrevious.TabIndex = 3
        Me.btnMovePrevious.Text = "<"
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(86, 152)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(32, 23)
        Me.btnMoveNext.TabIndex = 4
        Me.btnMoveNext.Text = ">"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(124, 152)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(32, 23)
        Me.btnMoveLast.TabIndex = 5
        Me.btnMoveLast.Text = ">>"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(162, 152)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpNewRecord
        '
        Me.grpNewRecord.Controls.Add(Me.btnAddNew)
        Me.grpNewRecord.Controls.Add(Me.txtNewState)
        Me.grpNewRecord.Controls.Add(Me.txtNewContactName)
        Me.grpNewRecord.Location = New System.Drawing.Point(16, 192)
        Me.grpNewRecord.Name = "grpNewRecord"
        Me.grpNewRecord.Size = New System.Drawing.Size(256, 58)
        Me.grpNewRecord.TabIndex = 7
        Me.grpNewRecord.TabStop = False
        Me.grpNewRecord.Text = "New Contact"
        '
        'txtNewContactName
        '
        Me.txtNewContactName.Location = New System.Drawing.Point(8, 24)
        Me.txtNewContactName.Name = "txtNewContactName"
        Me.txtNewContactName.Size = New System.Drawing.Size(112, 20)
        Me.txtNewContactName.TabIndex = 0
        '
        'txtNewState
        '
        Me.txtNewState.Location = New System.Drawing.Point(126, 24)
        Me.txtNewState.Name = "txtNewState"
        Me.txtNewState.Size = New System.Drawing.Size(80, 20)
        Me.txtNewState.TabIndex = 1
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(210, 22)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(40, 23)
        Me.btnAddNew.TabIndex = 2
        Me.btnAddNew.Text = "Add"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(208, 152)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.grpNewRecord)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtContactName)
        Me.Name = "MainForm"
        Me.Text = "Database Example"
        Me.grpNewRecord.ResumeLayout(False)
        Me.grpNewRecord.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpNewRecord As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents txtNewState As System.Windows.Forms.TextBox
    Friend WithEvents txtNewContactName As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class

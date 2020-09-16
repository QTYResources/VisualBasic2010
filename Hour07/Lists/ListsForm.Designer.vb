<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsForm
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
        Me.lstChemicalEchoSongs = New System.Windows.Forms.ListBox()
        Me.btnAddSong = New System.Windows.Forms.Button()
        Me.btnRemoveSong = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnShowItem = New System.Windows.Forms.Button()
        Me.cboColors = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstChemicalEchoSongs
        '
        Me.lstChemicalEchoSongs.FormattingEnabled = True
        Me.lstChemicalEchoSongs.Items.AddRange(New Object() {"Persian Wind", "Portal", "Dark and Stormy Night", "Cadence of Madness", "Lift Off", "Reentry"})
        Me.lstChemicalEchoSongs.Location = New System.Drawing.Point(64, 32)
        Me.lstChemicalEchoSongs.Name = "lstChemicalEchoSongs"
        Me.lstChemicalEchoSongs.Size = New System.Drawing.Size(160, 121)
        Me.lstChemicalEchoSongs.TabIndex = 0
        '
        'btnAddSong
        '
        Me.btnAddSong.Location = New System.Drawing.Point(96, 159)
        Me.btnAddSong.Name = "btnAddSong"
        Me.btnAddSong.Size = New System.Drawing.Size(100, 23)
        Me.btnAddSong.TabIndex = 1
        Me.btnAddSong.Text = "Add a Song"
        Me.btnAddSong.UseVisualStyleBackColor = True
        '
        'btnRemoveSong
        '
        Me.btnRemoveSong.Location = New System.Drawing.Point(96, 188)
        Me.btnRemoveSong.Name = "btnRemoveSong"
        Me.btnRemoveSong.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveSong.TabIndex = 2
        Me.btnRemoveSong.Text = "Remove Song"
        Me.btnRemoveSong.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(96, 217)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(100, 23)
        Me.btnClearList.TabIndex = 3
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'btnShowItem
        '
        Me.btnShowItem.Location = New System.Drawing.Point(96, 246)
        Me.btnShowItem.Name = "btnShowItem"
        Me.btnShowItem.Size = New System.Drawing.Size(100, 23)
        Me.btnShowItem.TabIndex = 4
        Me.btnShowItem.Text = "Show Selected"
        Me.btnShowItem.UseVisualStyleBackColor = True
        '
        'cboColors
        '
        Me.cboColors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboColors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColors.FormattingEnabled = True
        Me.cboColors.Items.AddRange(New Object() {"Black", "Blue", "Gold", "Green", "Red", "Yellow"})
        Me.cboColors.Location = New System.Drawing.Point(64, 5)
        Me.cboColors.Name = "cboColors"
        Me.cboColors.Size = New System.Drawing.Size(160, 21)
        Me.cboColors.TabIndex = 5
        '
        'ListsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 282)
        Me.Controls.Add(Me.cboColors)
        Me.Controls.Add(Me.btnShowItem)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnRemoveSong)
        Me.Controls.Add(Me.btnAddSong)
        Me.Controls.Add(Me.lstChemicalEchoSongs)
        Me.Name = "ListsForm"
        Me.Text = "Lists Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstChemicalEchoSongs As System.Windows.Forms.ListBox
    Friend WithEvents btnAddSong As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSong As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents btnShowItem As System.Windows.Forms.Button
    Friend WithEvents cboColors As System.Windows.Forms.ComboBox

End Class

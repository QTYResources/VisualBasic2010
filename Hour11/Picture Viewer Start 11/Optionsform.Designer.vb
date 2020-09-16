<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optionsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Optionsform))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabOptions = New System.Windows.Forms.TabControl()
        Me.pgeGeneral = New System.Windows.Forms.TabPage()
        Me.pgeAppearance = New System.Windows.Forms.TabPage()
        Me.grpDefaultBackColor = New System.Windows.Forms.GroupBox()
        Me.optBackgroundWhite = New System.Windows.Forms.RadioButton()
        Me.optBackgroundDefault = New System.Windows.Forms.RadioButton()
        Me.chkPromptOnExit = New System.Windows.Forms.CheckBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.tabOptions.SuspendLayout()
        Me.pgeGeneral.SuspendLayout()
        Me.pgeAppearance.SuspendLayout()
        Me.grpDefaultBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(305, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(305, 38)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.pgeGeneral)
        Me.tabOptions.Controls.Add(Me.pgeAppearance)
        Me.tabOptions.Location = New System.Drawing.Point(12, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(287, 145)
        Me.tabOptions.TabIndex = 6
        '
        'pgeGeneral
        '
        Me.pgeGeneral.Controls.Add(Me.chkPromptOnExit)
        Me.pgeGeneral.Controls.Add(Me.txtUserName)
        Me.pgeGeneral.Controls.Add(Me.lblUserName)
        Me.pgeGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pgeGeneral.Name = "pgeGeneral"
        Me.pgeGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeGeneral.Size = New System.Drawing.Size(279, 119)
        Me.pgeGeneral.TabIndex = 0
        Me.pgeGeneral.Text = "General"
        Me.pgeGeneral.UseVisualStyleBackColor = True
        '
        'pgeAppearance
        '
        Me.pgeAppearance.Controls.Add(Me.grpDefaultBackColor)
        Me.pgeAppearance.Location = New System.Drawing.Point(4, 22)
        Me.pgeAppearance.Name = "pgeAppearance"
        Me.pgeAppearance.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeAppearance.Size = New System.Drawing.Size(279, 119)
        Me.pgeAppearance.TabIndex = 1
        Me.pgeAppearance.Text = "Appearance"
        Me.pgeAppearance.UseVisualStyleBackColor = True
        '
        'grpDefaultBackColor
        '
        Me.grpDefaultBackColor.Controls.Add(Me.optBackgroundWhite)
        Me.grpDefaultBackColor.Controls.Add(Me.optBackgroundDefault)
        Me.grpDefaultBackColor.Location = New System.Drawing.Point(37, 25)
        Me.grpDefaultBackColor.Name = "grpDefaultBackColor"
        Me.grpDefaultBackColor.Size = New System.Drawing.Size(200, 72)
        Me.grpDefaultBackColor.TabIndex = 3
        Me.grpDefaultBackColor.TabStop = False
        Me.grpDefaultBackColor.Text = "Default Picture Background Color"
        '
        'optBackgroundWhite
        '
        Me.optBackgroundWhite.AutoSize = True
        Me.optBackgroundWhite.Location = New System.Drawing.Point(14, 42)
        Me.optBackgroundWhite.Name = "optBackgroundWhite"
        Me.optBackgroundWhite.Size = New System.Drawing.Size(53, 17)
        Me.optBackgroundWhite.TabIndex = 1
        Me.optBackgroundWhite.Text = "White"
        Me.optBackgroundWhite.UseVisualStyleBackColor = True
        '
        'optBackgroundDefault
        '
        Me.optBackgroundDefault.AutoSize = True
        Me.optBackgroundDefault.Checked = True
        Me.optBackgroundDefault.Location = New System.Drawing.Point(14, 19)
        Me.optBackgroundDefault.Name = "optBackgroundDefault"
        Me.optBackgroundDefault.Size = New System.Drawing.Size(84, 17)
        Me.optBackgroundDefault.TabIndex = 0
        Me.optBackgroundDefault.TabStop = True
        Me.optBackgroundDefault.Text = "Default Gray"
        Me.optBackgroundDefault.UseVisualStyleBackColor = True
        '
        'chkPromptOnExit
        '
        Me.chkPromptOnExit.AutoSize = True
        Me.chkPromptOnExit.Location = New System.Drawing.Point(98, 73)
        Me.chkPromptOnExit.Name = "chkPromptOnExit"
        Me.chkPromptOnExit.Size = New System.Drawing.Size(142, 17)
        Me.chkPromptOnExit.TabIndex = 7
        Me.chkPromptOnExit.Text = "Prompt to confirm on exit"
        Me.chkPromptOnExit.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(98, 32)
        Me.txtUserName.MaxLength = 0
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(139, 20)
        Me.txtUserName.TabIndex = 6
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(33, 35)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 13)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "User Name:"
        '
        'Optionsform
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Optionsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Picture Viewer Options"
        Me.tabOptions.ResumeLayout(False)
        Me.pgeGeneral.ResumeLayout(False)
        Me.pgeGeneral.PerformLayout()
        Me.pgeAppearance.ResumeLayout(False)
        Me.grpDefaultBackColor.ResumeLayout(False)
        Me.grpDefaultBackColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tabOptions As System.Windows.Forms.TabControl
    Friend WithEvents pgeGeneral As System.Windows.Forms.TabPage
    Friend WithEvents chkPromptOnExit As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents pgeAppearance As System.Windows.Forms.TabPage
    Friend WithEvents grpDefaultBackColor As System.Windows.Forms.GroupBox
    Friend WithEvents optBackgroundWhite As System.Windows.Forms.RadioButton
    Friend WithEvents optBackgroundDefault As System.Windows.Forms.RadioButton
End Class

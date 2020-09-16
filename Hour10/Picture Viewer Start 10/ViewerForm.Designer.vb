<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picShowPicture = New System.Windows.Forms.PictureBox()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.btnDrawBorder = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDrawBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmOnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureContext = New System.Windows.Forms.ContextMenuStrip()
        Me.DrawBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrMainToolbar = New System.Windows.Forms.ToolStrip()
        Me.tbbOpenPicture = New System.Windows.Forms.ToolStripButton()
        Me.tbbDrawBorder = New System.Windows.Forms.ToolStripButton()
        Me.tbbOptions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.sbrMyStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMainMenu.SuspendLayout()
        Me.mnuPictureContext.SuspendLayout()
        Me.tbrMainToolbar.SuspendLayout()
        Me.sbrMyStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectPicture.Location = New System.Drawing.Point(296, 52)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(85, 23)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(296, 82)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picShowPicture
        '
        Me.picShowPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShowPicture.ContextMenuStrip = Me.mnuPictureContext
        Me.picShowPicture.Location = New System.Drawing.Point(8, 52)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(282, 245)
        Me.picShowPicture.TabIndex = 2
        Me.picShowPicture.TabStop = False
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnlarge.Location = New System.Drawing.Point(339, 285)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(21, 23)
        Me.btnEnlarge.TabIndex = 6
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShrink.Location = New System.Drawing.Point(360, 285)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(21, 23)
        Me.btnShrink.TabIndex = 7
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'btnDrawBorder
        '
        Me.btnDrawBorder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrawBorder.Location = New System.Drawing.Point(296, 111)
        Me.btnDrawBorder.Name = "btnDrawBorder"
        Me.btnDrawBorder.Size = New System.Drawing.Size(85, 23)
        Me.btnDrawBorder.TabIndex = 2
        Me.btnDrawBorder.Text = "Draw Border"
        Me.btnDrawBorder.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(301, 152)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(301, 167)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y:"
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOptions.Location = New System.Drawing.Point(296, 197)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(85, 23)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(384, 24)
        Me.mnuMainMenu.TabIndex = 8
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenPicture, Me.mnuConfirmOnExit, Me.mnuQuit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuOpenPicture
        '
        Me.mnuOpenPicture.Name = "mnuOpenPicture"
        Me.mnuOpenPicture.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenPicture.Size = New System.Drawing.Size(195, 22)
        Me.mnuOpenPicture.Text = "&Open Picture..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDrawBorder, Me.ToolStripSeparator1, Me.mnuOptions})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(195, 22)
        Me.mnuQuit.Text = "&Quit"
        '
        'mnuDrawBorder
        '
        Me.mnuDrawBorder.Name = "mnuDrawBorder"
        Me.mnuDrawBorder.Size = New System.Drawing.Size(152, 22)
        Me.mnuDrawBorder.Text = "&Draw Border"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(152, 22)
        Me.mnuOptions.Text = "&Options..."
        '
        'mnuConfirmOnExit
        '
        Me.mnuConfirmOnExit.Checked = True
        Me.mnuConfirmOnExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuConfirmOnExit.Name = "mnuConfirmOnExit"
        Me.mnuConfirmOnExit.Size = New System.Drawing.Size(195, 22)
        Me.mnuConfirmOnExit.Text = "Confirm on Exit"
        '
        'mnuPictureContext
        '
        Me.mnuPictureContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawBorderToolStripMenuItem})
        Me.mnuPictureContext.Name = "mnuPictureContext"
        Me.mnuPictureContext.Size = New System.Drawing.Size(140, 26)
        '
        'DrawBorderToolStripMenuItem
        '
        Me.DrawBorderToolStripMenuItem.Name = "DrawBorderToolStripMenuItem"
        Me.DrawBorderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DrawBorderToolStripMenuItem.Text = "Draw Border"
        '
        'tbrMainToolbar
        '
        Me.tbrMainToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbOpenPicture, Me.ToolStripSeparator2, Me.tbbDrawBorder, Me.ToolStripSeparator3, Me.tbbOptions})
        Me.tbrMainToolbar.Location = New System.Drawing.Point(0, 24)
        Me.tbrMainToolbar.Name = "tbrMainToolbar"
        Me.tbrMainToolbar.Size = New System.Drawing.Size(384, 25)
        Me.tbrMainToolbar.TabIndex = 10
        Me.tbrMainToolbar.Text = "ToolStrip1"
        '
        'tbbOpenPicture
        '
        Me.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOpenPicture.Image = CType(resources.GetObject("tbbOpenPicture.Image"), System.Drawing.Image)
        Me.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOpenPicture.Name = "tbbOpenPicture"
        Me.tbbOpenPicture.Size = New System.Drawing.Size(23, 22)
        Me.tbbOpenPicture.Text = "Open Picture"
        '
        'tbbDrawBorder
        '
        Me.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDrawBorder.Image = CType(resources.GetObject("tbbDrawBorder.Image"), System.Drawing.Image)
        Me.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDrawBorder.Name = "tbbDrawBorder"
        Me.tbbDrawBorder.Size = New System.Drawing.Size(23, 22)
        Me.tbbDrawBorder.Text = "Draw Border"
        '
        'tbbOptions
        '
        Me.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOptions.Image = CType(resources.GetObject("tbbOptions.Image"), System.Drawing.Image)
        Me.tbbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOptions.Name = "tbbOptions"
        Me.tbbOptions.Size = New System.Drawing.Size(23, 22)
        Me.tbbOptions.Text = "Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'sbrMyStatusStrip
        '
        Me.sbrMyStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.sbrMyStatusStrip.Location = New System.Drawing.Point(0, 315)
        Me.sbrMyStatusStrip.Name = "sbrMyStatusStrip"
        Me.sbrMyStatusStrip.Size = New System.Drawing.Size(384, 22)
        Me.sbrMyStatusStrip.TabIndex = 11
        Me.sbrMyStatusStrip.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(98, 17)
        Me.lblStatus.Text = "No image loaded"
        '
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(384, 337)
        Me.Controls.Add(Me.sbrMyStatusStrip)
        Me.Controls.Add(Me.tbrMainToolbar)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnDrawBorder)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.mnuPictureContext.ResumeLayout(False)
        Me.tbrMainToolbar.ResumeLayout(False)
        Me.tbrMainToolbar.PerformLayout()
        Me.sbrMyStatusStrip.ResumeLayout(False)
        Me.sbrMyStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelectPicture As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents picShowPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnEnlarge As System.Windows.Forms.Button
    Friend WithEvents btnShrink As System.Windows.Forms.Button
    Friend WithEvents btnDrawBorder As System.Windows.Forms.Button
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfirmOnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDrawBorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DrawBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrMainToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tbbOpenPicture As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbDrawBorder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbrMyStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class

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
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectPicture.Location = New System.Drawing.Point(295, 10)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(85, 23)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(295, 40)
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
        Me.picShowPicture.Location = New System.Drawing.Point(8, 8)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(282, 275)
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
        Me.btnEnlarge.Location = New System.Drawing.Point(338, 261)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(21, 23)
        Me.btnEnlarge.TabIndex = 6
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShrink.Location = New System.Drawing.Point(359, 261)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(21, 23)
        Me.btnShrink.TabIndex = 7
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'btnDrawBorder
        '
        Me.btnDrawBorder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrawBorder.Location = New System.Drawing.Point(295, 69)
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
        Me.lblX.Location = New System.Drawing.Point(300, 110)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(300, 125)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y:"
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOptions.Location = New System.Drawing.Point(295, 155)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(85, 23)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(384, 287)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnDrawBorder)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
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

End Class

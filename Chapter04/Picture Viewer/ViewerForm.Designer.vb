<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picShowPicture = New System.Windows.Forms.PictureBox()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnDrawBorder = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Location = New System.Drawing.Point(275, 10)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(105, 23)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(275, 40)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(105, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picShowPicture
        '
        Me.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShowPicture.Location = New System.Drawing.Point(8, 8)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(248, 272)
        Me.picShowPicture.TabIndex = 2
        Me.picShowPicture.TabStop = False
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnShrink
        '
        Me.btnShrink.Location = New System.Drawing.Point(356, 257)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(24, 23)
        Me.btnShrink.TabIndex = 3
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Location = New System.Drawing.Point(326, 257)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(24, 23)
        Me.btnEnlarge.TabIndex = 3
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnDrawBorder
        '
        Me.btnDrawBorder.Location = New System.Drawing.Point(275, 69)
        Me.btnDrawBorder.Name = "btnDrawBorder"
        Me.btnDrawBorder.Size = New System.Drawing.Size(105, 23)
        Me.btnDrawBorder.TabIndex = 1
        Me.btnDrawBorder.Text = "Draw Border"
        Me.btnDrawBorder.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(275, 99)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 12)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(275, 121)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 12)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y:"
        '
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 286)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.btnDrawBorder)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
        Me.TopMost = True
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectPicture As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents picShowPicture As PictureBox
    Friend WithEvents ofdSelectPicture As OpenFileDialog
    Friend WithEvents btnShrink As Button
    Friend WithEvents btnEnlarge As Button
    Friend WithEvents btnDrawBorder As Button
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
End Class

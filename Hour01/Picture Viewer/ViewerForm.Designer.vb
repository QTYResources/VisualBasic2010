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
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Location = New System.Drawing.Point(295, 10)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(85, 23)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(295, 40)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picShowPicture
        '
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
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 287)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelectPicture As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents picShowPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog

End Class

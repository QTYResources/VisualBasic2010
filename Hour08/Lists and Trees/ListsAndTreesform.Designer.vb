<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsAndTreesform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListsAndTreesform))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"James Foxall", "Nebraska"}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dave Hynek", "Nebraska"}, 0)
        Me.imgMyImages = New System.Windows.Forms.ImageList()
        Me.lstMyListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tvwLanguages = New System.Windows.Forms.TreeView()
        Me.btnAddNode = New System.Windows.Forms.Button()
        Me.btnCreateChild = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'imgMyImages
        '
        Me.imgMyImages.ImageStream = CType(resources.GetObject("imgMyImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMyImages.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMyImages.Images.SetKeyName(0, "Person.ico")
        '
        'lstMyListView
        '
        Me.lstMyListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstMyListView.FullRowSelect = True
        Me.lstMyListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lstMyListView.Location = New System.Drawing.Point(8, 8)
        Me.lstMyListView.Name = "lstMyListView"
        Me.lstMyListView.Size = New System.Drawing.Size(266, 97)
        Me.lstMyListView.SmallImageList = Me.imgMyImages
        Me.lstMyListView.TabIndex = 0
        Me.lstMyListView.UseCompatibleStateImageBehavior = False
        Me.lstMyListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "State"
        '
        'tvwLanguages
        '
        Me.tvwLanguages.ImageIndex = 0
        Me.tvwLanguages.ImageList = Me.imgMyImages
        Me.tvwLanguages.Location = New System.Drawing.Point(8, 128)
        Me.tvwLanguages.Name = "tvwLanguages"
        Me.tvwLanguages.SelectedImageIndex = 0
        Me.tvwLanguages.Size = New System.Drawing.Size(266, 97)
        Me.tvwLanguages.TabIndex = 1
        '
        'btnAddNode
        '
        Me.btnAddNode.Location = New System.Drawing.Point(8, 231)
        Me.btnAddNode.Name = "btnAddNode"
        Me.btnAddNode.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNode.TabIndex = 2
        Me.btnAddNode.Text = "Add Node"
        Me.btnAddNode.UseVisualStyleBackColor = True
        '
        'btnCreateChild
        '
        Me.btnCreateChild.Location = New System.Drawing.Point(89, 231)
        Me.btnCreateChild.Name = "btnCreateChild"
        Me.btnCreateChild.Size = New System.Drawing.Size(80, 23)
        Me.btnCreateChild.TabIndex = 3
        Me.btnCreateChild.Text = "Create Child"
        Me.btnCreateChild.UseVisualStyleBackColor = True
        '
        'ListsAndTreesform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCreateChild)
        Me.Controls.Add(Me.btnAddNode)
        Me.Controls.Add(Me.tvwLanguages)
        Me.Controls.Add(Me.lstMyListView)
        Me.Name = "ListsAndTreesform"
        Me.Text = "Lists and Trees"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgMyImages As System.Windows.Forms.ImageList
    Friend WithEvents lstMyListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tvwLanguages As System.Windows.Forms.TreeView
    Friend WithEvents btnAddNode As System.Windows.Forms.Button
    Friend WithEvents btnCreateChild As System.Windows.Forms.Button

End Class

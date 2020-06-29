<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Home")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("January")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("February")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("March")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("April")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("May")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("June")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("July")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("August")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("September")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("October")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("November")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("December")
        Me.SplitterMainWindow = New System.Windows.Forms.SplitContainer()
        Me.MonthSelector = New System.Windows.Forms.TreeView()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitterMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitterMainWindow.Panel1.SuspendLayout()
        Me.SplitterMainWindow.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitterMainWindow
        '
        Me.SplitterMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitterMainWindow.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitterMainWindow.Location = New System.Drawing.Point(0, 28)
        Me.SplitterMainWindow.Name = "SplitterMainWindow"
        '
        'SplitterMainWindow.Panel1
        '
        Me.SplitterMainWindow.Panel1.Controls.Add(Me.MonthSelector)
        Me.SplitterMainWindow.Size = New System.Drawing.Size(800, 458)
        Me.SplitterMainWindow.SplitterDistance = 183
        Me.SplitterMainWindow.TabIndex = 0
        '
        'MonthSelector
        '
        Me.MonthSelector.BackColor = System.Drawing.SystemColors.Highlight
        Me.MonthSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthSelector.HideSelection = False
        Me.MonthSelector.Location = New System.Drawing.Point(0, 0)
        Me.MonthSelector.Name = "MonthSelector"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Home"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "January"
        TreeNode3.Name = "Node2"
        TreeNode3.Text = "February"
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "March"
        TreeNode5.Name = "Node4"
        TreeNode5.Text = "April"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "May"
        TreeNode7.Name = "Node6"
        TreeNode7.Text = "June"
        TreeNode8.Name = "Node7"
        TreeNode8.Text = "July"
        TreeNode9.Name = "Node8"
        TreeNode9.Text = "August"
        TreeNode10.Name = "Node9"
        TreeNode10.Text = "September"
        TreeNode11.Name = "Node10"
        TreeNode11.Text = "October"
        TreeNode12.Name = "Node11"
        TreeNode12.Text = "November"
        TreeNode13.Name = "Node12"
        TreeNode13.Text = "December"
        Me.MonthSelector.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Me.MonthSelector.Size = New System.Drawing.Size(183, 458)
        Me.MonthSelector.TabIndex = 0
        '
        'MainMenu
        '
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(800, 28)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 486)
        Me.Controls.Add(Me.SplitterMainWindow)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainWindow"
        Me.Text = "Main Window"
        Me.SplitterMainWindow.Panel1.ResumeLayout(False)
        CType(Me.SplitterMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitterMainWindow.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitterMainWindow As SplitContainer
    Friend WithEvents MonthSelector As TreeView
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class

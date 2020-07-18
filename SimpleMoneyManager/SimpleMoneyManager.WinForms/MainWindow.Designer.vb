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
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Home")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("January")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("February")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("March")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("April")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("May")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("June")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("July")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("August")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("September")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("October")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("November")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("December")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.SplitterMainWindow = New System.Windows.Forms.SplitContainer()
        Me.MonthSelector = New System.Windows.Forms.TreeView()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ButtonStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitterMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitterMainWindow.Panel1.SuspendLayout()
        Me.SplitterMainWindow.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ButtonStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitterMainWindow
        '
        Me.SplitterMainWindow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterMainWindow.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitterMainWindow.Location = New System.Drawing.Point(0, 68)
        Me.SplitterMainWindow.Name = "SplitterMainWindow"
        '
        'SplitterMainWindow.Panel1
        '
        Me.SplitterMainWindow.Panel1.Controls.Add(Me.MonthSelector)
        Me.SplitterMainWindow.Size = New System.Drawing.Size(1005, 295)
        Me.SplitterMainWindow.SplitterDistance = 183
        Me.SplitterMainWindow.TabIndex = 0
        '
        'MonthSelector
        '
        Me.MonthSelector.BackColor = System.Drawing.SystemColors.Highlight
        Me.MonthSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthSelector.HideSelection = False
        Me.MonthSelector.Location = New System.Drawing.Point(0, 0)
        Me.MonthSelector.Name = "MonthSelector"
        TreeNode14.Name = "NodeHome"
        TreeNode14.Text = "Home"
        TreeNode15.Name = "NodeJanuary"
        TreeNode15.Text = "January"
        TreeNode16.Name = "NodeFebruary"
        TreeNode16.Text = "February"
        TreeNode17.Name = "NodeMarch"
        TreeNode17.Text = "March"
        TreeNode18.Name = "NodeApril"
        TreeNode18.Text = "April"
        TreeNode19.Name = "NodeMay"
        TreeNode19.Text = "May"
        TreeNode20.Name = "NodeJune"
        TreeNode20.Text = "June"
        TreeNode21.Name = "NodeJuly"
        TreeNode21.Text = "July"
        TreeNode22.Name = "NodeAugust"
        TreeNode22.Text = "August"
        TreeNode23.Name = "NodeSeptember"
        TreeNode23.Text = "September"
        TreeNode24.Name = "NodeOctober"
        TreeNode24.Text = "October"
        TreeNode25.Name = "NodeNovember"
        TreeNode25.Text = "November"
        TreeNode26.Name = "NodeDecember"
        TreeNode26.Text = "December"
        Me.MonthSelector.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Me.MonthSelector.Size = New System.Drawing.Size(183, 295)
        Me.MonthSelector.TabIndex = 0
        '
        'MainMenu
        '
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1005, 28)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1005, 12)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1005, 67)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MainMenu)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ButtonStrip)
        '
        'ButtonStrip
        '
        Me.ButtonStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ButtonStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ButtonStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ButtonStrip.Location = New System.Drawing.Point(5, 28)
        Me.ButtonStrip.Name = "ButtonStrip"
        Me.ButtonStrip.Size = New System.Drawing.Size(42, 27)
        Me.ButtonStrip.TabIndex = 2
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 363)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.SplitterMainWindow)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainWindow"
        Me.Text = "Simple Money Manager"
        Me.SplitterMainWindow.Panel1.ResumeLayout(False)
        CType(Me.SplitterMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitterMainWindow.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ButtonStrip.ResumeLayout(False)
        Me.ButtonStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitterMainWindow As SplitContainer
    Friend WithEvents MonthSelector As TreeView
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ButtonStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
End Class

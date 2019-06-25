<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBack = New System.Windows.Forms.ToolStripButton()
        Me.tsbForward = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.tstbNavBar = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbGo = New System.Windows.Forms.ToolStripButton()
        Me.tsddbMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tpNewTab = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBack, Me.tsbForward, Me.tsbRefresh, Me.tsbHome, Me.tstbNavBar, Me.tsbGo, Me.tsddbMenu})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 47)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbBack
        '
        Me.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBack.Image = Global.VBrowser.My.Resources.Resources._001__arrow_left
        Me.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBack.Name = "tsbBack"
        Me.tsbBack.Size = New System.Drawing.Size(39, 44)
        Me.tsbBack.Text = "Go Back"
        '
        'tsbForward
        '
        Me.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbForward.Image = Global.VBrowser.My.Resources.Resources._002__arrow_right
        Me.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbForward.Name = "tsbForward"
        Me.tsbForward.Size = New System.Drawing.Size(39, 44)
        Me.tsbForward.Text = "Go Forward"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = Global.VBrowser.My.Resources.Resources._009__arrow_lockwise
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(39, 44)
        Me.tsbRefresh.Text = "Reload"
        '
        'tsbHome
        '
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.Image = Global.VBrowser.My.Resources.Resources._101__home
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(39, 44)
        Me.tsbHome.Text = "Go Home"
        '
        'tstbNavBar
        '
        Me.tstbNavBar.AutoSize = False
        Me.tstbNavBar.Name = "tstbNavBar"
        Me.tstbNavBar.Size = New System.Drawing.Size(400, 47)
        '
        'tsbGo
        '
        Me.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGo.Image = Global.VBrowser.My.Resources.Resources._075__navigation
        Me.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGo.Name = "tsbGo"
        Me.tsbGo.Size = New System.Drawing.Size(39, 44)
        Me.tsbGo.Text = "ToolStripButton1"
        '
        'tsddbMenu
        '
        Me.tsddbMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsddbMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPreferences, Me.PrintToolStripMenuItem, Me.GitHubToolStripMenuItem})
        Me.tsddbMenu.Image = Global.VBrowser.My.Resources.Resources._082__setting_cog
        Me.tsddbMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbMenu.Name = "tsddbMenu"
        Me.tsddbMenu.Size = New System.Drawing.Size(48, 44)
        Me.tsddbMenu.Text = "ToolStripDropDownButton1"
        '
        'tsmiPreferences
        '
        Me.tsmiPreferences.Name = "tsmiPreferences"
        Me.tsmiPreferences.Size = New System.Drawing.Size(135, 22)
        Me.tsmiPreferences.Text = "Preferences"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'GitHubToolStripMenuItem
        '
        Me.GitHubToolStripMenuItem.Name = "GitHubToolStripMenuItem"
        Me.GitHubToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.GitHubToolStripMenuItem.Text = "GitHub"
        '
        'tpNewTab
        '
        Me.tpNewTab.BackColor = System.Drawing.Color.Transparent
        Me.tpNewTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpNewTab.ImageKey = "(none)"
        Me.tpNewTab.Location = New System.Drawing.Point(4, 22)
        Me.tpNewTab.Name = "tpNewTab"
        Me.tpNewTab.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNewTab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tpNewTab.Size = New System.Drawing.Size(976, 488)
        Me.tpNewTab.TabIndex = 1
        Me.tpNewTab.Text = "    +"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpNewTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 514)
        Me.TabControl1.TabIndex = 2
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Browser"
        Me.Text = "VBrowser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbBack As ToolStripButton
    Friend WithEvents tsbForward As ToolStripButton
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents tstbNavBar As ToolStripTextBox
    Friend WithEvents tsbGo As ToolStripButton
    Friend WithEvents tsddbMenu As ToolStripDropDownButton
    Friend WithEvents tsmiPreferences As ToolStripMenuItem
    Friend WithEvents tsbRefresh As ToolStripButton
    Friend WithEvents GitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents tpNewTab As TabPage
    Friend WithEvents TabControl1 As TabControl
End Class

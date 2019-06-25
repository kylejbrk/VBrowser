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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstbNavBar = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBack = New System.Windows.Forms.ToolStripButton()
        Me.tsbForward = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.tsbGo = New System.Windows.Forms.ToolStripButton()
        Me.tsddbMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 47)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(984, 514)
        Me.WebBrowser1.TabIndex = 0
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
        'tstbNavBar
        '
        Me.tstbNavBar.AutoSize = False
        Me.tstbNavBar.Name = "tstbNavBar"
        Me.tstbNavBar.Size = New System.Drawing.Size(400, 47)
        '
        'tsbBack
        '
        Me.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBack.Image = Global.WebBrowser.My.Resources.Resources._001__arrow_left
        Me.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBack.Name = "tsbBack"
        Me.tsbBack.Size = New System.Drawing.Size(39, 44)
        Me.tsbBack.Text = "Go Back"
        '
        'tsbForward
        '
        Me.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbForward.Image = Global.WebBrowser.My.Resources.Resources._002__arrow_right
        Me.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbForward.Name = "tsbForward"
        Me.tsbForward.Size = New System.Drawing.Size(39, 44)
        Me.tsbForward.Text = "Go Forward"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = Global.WebBrowser.My.Resources.Resources._009__arrow_lockwise
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(39, 44)
        Me.tsbRefresh.Text = "Reload"
        '
        'tsbHome
        '
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.Image = Global.WebBrowser.My.Resources.Resources._101__home
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(39, 44)
        Me.tsbHome.Text = "Go Home"
        '
        'tsbGo
        '
        Me.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGo.Image = Global.WebBrowser.My.Resources.Resources._075__navigation
        Me.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGo.Name = "tsbGo"
        Me.tsbGo.Size = New System.Drawing.Size(39, 44)
        Me.tsbGo.Text = "ToolStripButton1"
        '
        'tsddbMenu
        '
        Me.tsddbMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsddbMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPreferences, Me.PrintToolStripMenuItem, Me.GitHubToolStripMenuItem})
        Me.tsddbMenu.Image = Global.WebBrowser.My.Resources.Resources._082__setting_cog
        Me.tsddbMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbMenu.Name = "tsddbMenu"
        Me.tsddbMenu.Size = New System.Drawing.Size(48, 44)
        Me.tsddbMenu.Text = "ToolStripDropDownButton1"
        '
        'tsmiPreferences
        '
        Me.tsmiPreferences.Name = "tsmiPreferences"
        Me.tsmiPreferences.Size = New System.Drawing.Size(152, 22)
        Me.tsmiPreferences.Text = "Preferences"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'GitHubToolStripMenuItem
        '
        Me.GitHubToolStripMenuItem.Name = "GitHubToolStripMenuItem"
        Me.GitHubToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GitHubToolStripMenuItem.Text = "GitHub"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Browser"
        Me.Text = "VBrowser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
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
End Class

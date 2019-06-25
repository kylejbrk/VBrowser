<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDuckDuckGo = New System.Windows.Forms.RadioButton()
        Me.rbBing = New System.Windows.Forms.RadioButton()
        Me.rbGoogle = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbHomePage = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDuckDuckGo)
        Me.GroupBox1.Controls.Add(Me.rbBing)
        Me.GroupBox1.Controls.Add(Me.rbGoogle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Engine"
        '
        'rbDuckDuckGo
        '
        Me.rbDuckDuckGo.AutoSize = True
        Me.rbDuckDuckGo.Location = New System.Drawing.Point(7, 68)
        Me.rbDuckDuckGo.Name = "rbDuckDuckGo"
        Me.rbDuckDuckGo.Size = New System.Drawing.Size(91, 17)
        Me.rbDuckDuckGo.TabIndex = 2
        Me.rbDuckDuckGo.TabStop = True
        Me.rbDuckDuckGo.Text = "DuckDuckGo"
        Me.rbDuckDuckGo.UseVisualStyleBackColor = True
        '
        'rbBing
        '
        Me.rbBing.AutoSize = True
        Me.rbBing.Location = New System.Drawing.Point(7, 44)
        Me.rbBing.Name = "rbBing"
        Me.rbBing.Size = New System.Drawing.Size(46, 17)
        Me.rbBing.TabIndex = 1
        Me.rbBing.TabStop = True
        Me.rbBing.Text = "Bing"
        Me.rbBing.UseVisualStyleBackColor = True
        '
        'rbGoogle
        '
        Me.rbGoogle.AutoSize = True
        Me.rbGoogle.Location = New System.Drawing.Point(7, 20)
        Me.rbGoogle.Name = "rbGoogle"
        Me.rbGoogle.Size = New System.Drawing.Size(59, 17)
        Me.rbGoogle.TabIndex = 0
        Me.rbGoogle.TabStop = True
        Me.rbGoogle.Text = "Google"
        Me.rbGoogle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbHomePage)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 51)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Home Page"
        '
        'tbHomePage
        '
        Me.tbHomePage.Location = New System.Drawing.Point(7, 20)
        Me.tbHomePage.Name = "tbHomePage"
        Me.tbHomePage.Size = New System.Drawing.Size(246, 20)
        Me.tbHomePage.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(196, 169)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 200)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDuckDuckGo As RadioButton
    Friend WithEvents rbBing As RadioButton
    Friend WithEvents rbGoogle As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbHomePage As TextBox
    Friend WithEvents btnSave As Button
End Class

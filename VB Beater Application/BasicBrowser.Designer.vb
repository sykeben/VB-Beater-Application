<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicBrowser
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.ForewardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.UrlBox = New System.Windows.Forms.TextBox()
        Me.BrowserFrame = New System.Windows.Forms.WebBrowser()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.AutoSize = True
        Me.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MenuPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuPanel.Controls.Add(Me.LoadingBar)
        Me.MenuPanel.Controls.Add(Me.ForewardButton)
        Me.MenuPanel.Controls.Add(Me.BackButton)
        Me.MenuPanel.Controls.Add(Me.GoButton)
        Me.MenuPanel.Controls.Add(Me.UrlBox)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(800, 28)
        Me.MenuPanel.TabIndex = 1
        '
        'LoadingBar
        '
        Me.LoadingBar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LoadingBar.Location = New System.Drawing.Point(678, 5)
        Me.LoadingBar.MarqueeAnimationSpeed = 10
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(119, 20)
        Me.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.LoadingBar.TabIndex = 1
        Me.LoadingBar.Visible = False
        '
        'ForewardButton
        '
        Me.ForewardButton.Location = New System.Drawing.Point(29, 5)
        Me.ForewardButton.Name = "ForewardButton"
        Me.ForewardButton.Size = New System.Drawing.Size(20, 20)
        Me.ForewardButton.TabIndex = 3
        Me.ForewardButton.Text = ">"
        Me.ForewardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(6, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(20, 20)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(434, 5)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(32, 20)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'UrlBox
        '
        Me.UrlBox.Location = New System.Drawing.Point(71, 5)
        Me.UrlBox.Name = "UrlBox"
        Me.UrlBox.Size = New System.Drawing.Size(357, 20)
        Me.UrlBox.TabIndex = 0
        Me.UrlBox.WordWrap = False
        '
        'BrowserFrame
        '
        Me.BrowserFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserFrame.Location = New System.Drawing.Point(0, 28)
        Me.BrowserFrame.MinimumSize = New System.Drawing.Size(20, 20)
        Me.BrowserFrame.Name = "BrowserFrame"
        Me.BrowserFrame.Size = New System.Drawing.Size(800, 422)
        Me.BrowserFrame.TabIndex = 2
        Me.BrowserFrame.Url = New System.Uri("https://www.duckduckgo.com/", System.UriKind.Absolute)
        '
        'BasicBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BrowserFrame)
        Me.Controls.Add(Me.MenuPanel)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "BasicBrowser"
        Me.Text = "VB Beater App - Basic Browser"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents UrlBox As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents ForewardButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents BrowserFrame As WebBrowser
End Class

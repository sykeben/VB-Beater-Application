<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.WelcomeTitle = New System.Windows.Forms.Label()
        Me.WelcomeSubtitle = New System.Windows.Forms.Label()
        Me.InfoButton = New System.Windows.Forms.Button()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.SectionsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LaunchElementGallery = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuPanel.SuspendLayout()
        Me.SectionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WelcomeTitle
        '
        Me.WelcomeTitle.AutoSize = True
        Me.WelcomeTitle.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeTitle.Location = New System.Drawing.Point(12, 9)
        Me.WelcomeTitle.Name = "WelcomeTitle"
        Me.WelcomeTitle.Size = New System.Drawing.Size(154, 45)
        Me.WelcomeTitle.TabIndex = 0
        Me.WelcomeTitle.Text = "Welcome"
        '
        'WelcomeSubtitle
        '
        Me.WelcomeSubtitle.AutoSize = True
        Me.WelcomeSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeSubtitle.Location = New System.Drawing.Point(16, 54)
        Me.WelcomeSubtitle.Name = "WelcomeSubtitle"
        Me.WelcomeSubtitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WelcomeSubtitle.Size = New System.Drawing.Size(414, 21)
        Me.WelcomeSubtitle.TabIndex = 1
        Me.WelcomeSubtitle.Text = "This is a ""beater"" application I use to test VB and .NET stuff."
        '
        'InfoButton
        '
        Me.InfoButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InfoButton.CausesValidation = False
        Me.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.InfoButton.FlatAppearance.BorderSize = 0
        Me.InfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.InfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoButton.Location = New System.Drawing.Point(0, 0)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(25, 25)
        Me.InfoButton.TabIndex = 4
        Me.InfoButton.Text = "i"
        Me.InfoButton.UseVisualStyleBackColor = False
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuPanel.Controls.Add(Me.InfoButton)
        Me.MenuPanel.Location = New System.Drawing.Point(-1, 405)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(758, 26)
        Me.MenuPanel.TabIndex = 5
        '
        'SectionsPanel
        '
        Me.SectionsPanel.ColumnCount = 5
        Me.SectionsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.Controls.Add(Me.LaunchElementGallery, 0, 0)
        Me.SectionsPanel.Location = New System.Drawing.Point(12, 109)
        Me.SectionsPanel.Name = "SectionsPanel"
        Me.SectionsPanel.RowCount = 5
        Me.SectionsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SectionsPanel.Size = New System.Drawing.Size(732, 290)
        Me.SectionsPanel.TabIndex = 6
        '
        'LaunchElementGallery
        '
        Me.LaunchElementGallery.Location = New System.Drawing.Point(3, 3)
        Me.LaunchElementGallery.Name = "LaunchElementGallery"
        Me.LaunchElementGallery.Size = New System.Drawing.Size(140, 52)
        Me.LaunchElementGallery.TabIndex = 0
        Me.LaunchElementGallery.Text = "Element" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gallery"
        Me.LaunchElementGallery.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Launchers:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 430)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SectionsPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.WelcomeSubtitle)
        Me.Controls.Add(Me.WelcomeTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "VB Beater App - Main Window"
        Me.MenuPanel.ResumeLayout(False)
        Me.SectionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomeTitle As Label
    Friend WithEvents WelcomeSubtitle As Label
    Friend WithEvents InfoButton As Button
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents SectionsPanel As TableLayoutPanel
    Friend WithEvents LaunchElementGallery As Button
    Friend WithEvents Label1 As Label
End Class

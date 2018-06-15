<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.UIKBox = New System.Windows.Forms.PictureBox()
        Me.AboutTitle = New System.Windows.Forms.Label()
        Me.AboutCopyright = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.UIKBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIKBox
        '
        Me.UIKBox.Image = Global.VB_Beater_Application.My.Resources.AboutRes.UIK
        Me.UIKBox.Location = New System.Drawing.Point(13, 13)
        Me.UIKBox.Name = "UIKBox"
        Me.UIKBox.Size = New System.Drawing.Size(20, 20)
        Me.UIKBox.TabIndex = 0
        Me.UIKBox.TabStop = False
        '
        'AboutTitle
        '
        Me.AboutTitle.AutoSize = True
        Me.AboutTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutTitle.Location = New System.Drawing.Point(40, 13)
        Me.AboutTitle.Name = "AboutTitle"
        Me.AboutTitle.Size = New System.Drawing.Size(192, 17)
        Me.AboutTitle.TabIndex = 1
        Me.AboutTitle.Text = "Visual Basic Beater Application"
        '
        'AboutCopyright
        '
        Me.AboutCopyright.AutoSize = True
        Me.AboutCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutCopyright.Location = New System.Drawing.Point(10, 42)
        Me.AboutCopyright.Name = "AboutCopyright"
        Me.AboutCopyright.Size = New System.Drawing.Size(140, 15)
        Me.AboutCopyright.TabIndex = 2
        Me.AboutCopyright.Text = "(C)2018 - Benjamin Sykes"
        Me.AboutCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(174, 37)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(68, 25)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(254, 66)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AboutCopyright)
        Me.Controls.Add(Me.AboutTitle)
        Me.Controls.Add(Me.UIKBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.UIKBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UIKBox As PictureBox
    Friend WithEvents AboutTitle As Label
    Friend WithEvents AboutCopyright As Label
    Friend WithEvents CloseButton As Button
End Class

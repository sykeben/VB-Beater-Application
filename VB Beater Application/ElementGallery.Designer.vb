<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElementGallery
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
        Me.ButtonElement = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonElement
        '
        Me.ButtonElement.Location = New System.Drawing.Point(12, 46)
        Me.ButtonElement.Name = "ButtonElement"
        Me.ButtonElement.Size = New System.Drawing.Size(75, 23)
        Me.ButtonElement.TabIndex = 0
        Me.ButtonElement.Text = "Button"
        Me.ButtonElement.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(7, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(271, 30)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Element Gallery + Demo(s)"
        '
        'ElementGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 411)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ButtonElement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ElementGallery"
        Me.Text = "Element Gallery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonElement As Button
    Friend WithEvents Title As Label
End Class

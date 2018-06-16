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
        Me.CheckBoxElement = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUnchecked = New System.Windows.Forms.Label()
        Me.CheckBoxChecked = New System.Windows.Forms.Label()
        Me.ComboBoxElement = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerElement = New System.Windows.Forms.DateTimePicker()
        Me.LabelElement = New System.Windows.Forms.Label()
        Me.LinkLabelElement = New System.Windows.Forms.LinkLabel()
        Me.MoreSoonLabel = New System.Windows.Forms.Label()
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
        'CheckBoxElement
        '
        Me.CheckBoxElement.AutoSize = True
        Me.CheckBoxElement.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxElement.Location = New System.Drawing.Point(93, 50)
        Me.CheckBoxElement.Name = "CheckBoxElement"
        Me.CheckBoxElement.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxElement.TabIndex = 2
        Me.CheckBoxElement.Text = "Check Box:"
        Me.CheckBoxElement.UseVisualStyleBackColor = False
        '
        'CheckBoxUnchecked
        '
        Me.CheckBoxUnchecked.AutoSize = True
        Me.CheckBoxUnchecked.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxUnchecked.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckBoxUnchecked.Location = New System.Drawing.Point(170, 51)
        Me.CheckBoxUnchecked.Name = "CheckBoxUnchecked"
        Me.CheckBoxUnchecked.Size = New System.Drawing.Size(63, 13)
        Me.CheckBoxUnchecked.TabIndex = 3
        Me.CheckBoxUnchecked.Text = "Unchecked"
        '
        'CheckBoxChecked
        '
        Me.CheckBoxChecked.AutoSize = True
        Me.CheckBoxChecked.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxChecked.ForeColor = System.Drawing.Color.DarkGreen
        Me.CheckBoxChecked.Location = New System.Drawing.Point(170, 51)
        Me.CheckBoxChecked.Name = "CheckBoxChecked"
        Me.CheckBoxChecked.Size = New System.Drawing.Size(50, 13)
        Me.CheckBoxChecked.TabIndex = 4
        Me.CheckBoxChecked.Text = "Checked"
        Me.CheckBoxChecked.Visible = False
        '
        'ComboBoxElement
        '
        Me.ComboBoxElement.FormattingEnabled = True
        Me.ComboBoxElement.Items.AddRange(New Object() {"Option 1", "Option 2", "Option 3"})
        Me.ComboBoxElement.Location = New System.Drawing.Point(239, 46)
        Me.ComboBoxElement.Name = "ComboBoxElement"
        Me.ComboBoxElement.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxElement.TabIndex = 5
        Me.ComboBoxElement.Text = "Combo Box"
        '
        'DateTimePickerElement
        '
        Me.DateTimePickerElement.Location = New System.Drawing.Point(366, 46)
        Me.DateTimePickerElement.Name = "DateTimePickerElement"
        Me.DateTimePickerElement.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerElement.TabIndex = 6
        '
        'LabelElement
        '
        Me.LabelElement.AutoSize = True
        Me.LabelElement.Location = New System.Drawing.Point(12, 76)
        Me.LabelElement.Name = "LabelElement"
        Me.LabelElement.Size = New System.Drawing.Size(33, 13)
        Me.LabelElement.TabIndex = 7
        Me.LabelElement.Text = "Label"
        '
        'LinkLabelElement
        '
        Me.LinkLabelElement.AutoSize = True
        Me.LinkLabelElement.Location = New System.Drawing.Point(52, 76)
        Me.LinkLabelElement.Name = "LinkLabelElement"
        Me.LinkLabelElement.Size = New System.Drawing.Size(56, 13)
        Me.LinkLabelElement.TabIndex = 8
        Me.LinkLabelElement.TabStop = True
        Me.LinkLabelElement.Text = "Link Label"
        '
        'MoreSoonLabel
        '
        Me.MoreSoonLabel.AutoSize = True
        Me.MoreSoonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoreSoonLabel.Location = New System.Drawing.Point(477, 92)
        Me.MoreSoonLabel.Name = "MoreSoonLabel"
        Me.MoreSoonLabel.Size = New System.Drawing.Size(103, 13)
        Me.MoreSoonLabel.TabIndex = 9
        Me.MoreSoonLabel.Text = "More coming soon..."
        Me.MoreSoonLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ElementGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 108)
        Me.Controls.Add(Me.MoreSoonLabel)
        Me.Controls.Add(Me.LinkLabelElement)
        Me.Controls.Add(Me.LabelElement)
        Me.Controls.Add(Me.DateTimePickerElement)
        Me.Controls.Add(Me.ComboBoxElement)
        Me.Controls.Add(Me.CheckBoxChecked)
        Me.Controls.Add(Me.CheckBoxUnchecked)
        Me.Controls.Add(Me.CheckBoxElement)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ButtonElement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ElementGallery"
        Me.Text = "VB Beater App - Element Gallery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonElement As Button
    Friend WithEvents Title As Label
    Friend WithEvents CheckBoxElement As CheckBox
    Friend WithEvents CheckBoxUnchecked As Label
    Friend WithEvents CheckBoxChecked As Label
    Friend WithEvents ComboBoxElement As ComboBox
    Friend WithEvents DateTimePickerElement As DateTimePicker
    Friend WithEvents LabelElement As Label
    Friend WithEvents LinkLabelElement As LinkLabel
    Friend WithEvents MoreSoonLabel As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatesForm))
        Me.ButtonBackFromViewUpdateForm = New System.Windows.Forms.Button()
        Me.LabelUpdates = New System.Windows.Forms.Label()
        Me.TextBoxViewUpdates = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBackFromViewUpdateForm
        '
        Me.ButtonBackFromViewUpdateForm.Location = New System.Drawing.Point(21, 426)
        Me.ButtonBackFromViewUpdateForm.Name = "ButtonBackFromViewUpdateForm"
        Me.ButtonBackFromViewUpdateForm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBackFromViewUpdateForm.TabIndex = 0
        Me.ButtonBackFromViewUpdateForm.Text = "Back"
        Me.ButtonBackFromViewUpdateForm.UseVisualStyleBackColor = True
        '
        'LabelUpdates
        '
        Me.LabelUpdates.AutoSize = True
        Me.LabelUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUpdates.Location = New System.Drawing.Point(292, 9)
        Me.LabelUpdates.Name = "LabelUpdates"
        Me.LabelUpdates.Size = New System.Drawing.Size(110, 29)
        Me.LabelUpdates.TabIndex = 1
        Me.LabelUpdates.Text = "Updates"
        '
        'TextBoxViewUpdates
        '
        Me.TextBoxViewUpdates.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxViewUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxViewUpdates.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxViewUpdates.Location = New System.Drawing.Point(51, 69)
        Me.TextBoxViewUpdates.Multiline = True
        Me.TextBoxViewUpdates.Name = "TextBoxViewUpdates"
        Me.TextBoxViewUpdates.ReadOnly = True
        Me.TextBoxViewUpdates.Size = New System.Drawing.Size(596, 330)
        Me.TextBoxViewUpdates.TabIndex = 2
        Me.TextBoxViewUpdates.Text = resources.GetString("TextBoxViewUpdates.Text")
        '
        'UpdatesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 461)
        Me.Controls.Add(Me.TextBoxViewUpdates)
        Me.Controls.Add(Me.LabelUpdates)
        Me.Controls.Add(Me.ButtonBackFromViewUpdateForm)
        Me.Name = "UpdatesForm"
        Me.Text = "UpdatesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBackFromViewUpdateForm As Button
    Friend WithEvents LabelUpdates As Label
    Friend WithEvents TextBoxViewUpdates As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.TextBoxChat = New System.Windows.Forms.TextBox()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.LabelNickName = New System.Windows.Forms.Label()
        Me.TextBoxClient = New System.Windows.Forms.TextBox()
        Me.ButtonViewUpdates = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(626, 17)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(626, 413)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSend.TabIndex = 1
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(12, 439)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(113, 20)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(440, 20)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(117, 20)
        Me.TextBoxPort.TabIndex = 4
        '
        'TextBoxChat
        '
        Me.TextBoxChat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxChat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxChat.Location = New System.Drawing.Point(43, 52)
        Me.TextBoxChat.Multiline = True
        Me.TextBoxChat.Name = "TextBoxChat"
        Me.TextBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxChat.Size = New System.Drawing.Size(658, 355)
        Me.TextBoxChat.TabIndex = 5
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(385, 23)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(26, 13)
        Me.LabelPort.TabIndex = 6
        Me.LabelPort.Text = "Port"
        '
        'LabelNickName
        '
        Me.LabelNickName.AutoSize = True
        Me.LabelNickName.Location = New System.Drawing.Point(40, 20)
        Me.LabelNickName.Name = "LabelNickName"
        Me.LabelNickName.Size = New System.Drawing.Size(55, 13)
        Me.LabelNickName.TabIndex = 7
        Me.LabelNickName.Text = "Nickname"
        '
        'TextBoxClient
        '
        Me.TextBoxClient.Location = New System.Drawing.Point(43, 413)
        Me.TextBoxClient.Name = "TextBoxClient"
        Me.TextBoxClient.Size = New System.Drawing.Size(577, 20)
        Me.TextBoxClient.TabIndex = 8
        '
        'ButtonViewUpdates
        '
        Me.ButtonViewUpdates.Location = New System.Drawing.Point(617, 442)
        Me.ButtonViewUpdates.Name = "ButtonViewUpdates"
        Me.ButtonViewUpdates.Size = New System.Drawing.Size(84, 23)
        Me.ButtonViewUpdates.TabIndex = 9
        Me.ButtonViewUpdates.Text = "View Updates"
        Me.ButtonViewUpdates.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(727, 474)
        Me.Controls.Add(Me.ButtonViewUpdates)
        Me.Controls.Add(Me.TextBoxClient)
        Me.Controls.Add(Me.LabelNickName)
        Me.Controls.Add(Me.LabelPort)
        Me.Controls.Add(Me.TextBoxChat)
        Me.Controls.Add(Me.TextBoxPort)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.ButtonConnect)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Name = "Client"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonSend As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPort As TextBox
    Friend WithEvents TextBoxChat As TextBox
    Friend WithEvents LabelPort As Label
    Friend WithEvents LabelNickName As Label
    Friend WithEvents TextBoxClient As TextBox
    Friend WithEvents ButtonViewUpdates As Button
End Class

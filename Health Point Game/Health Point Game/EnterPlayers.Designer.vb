<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterPlayers
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
        Me.StartGame = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Player1 = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Label()
        Me.Player3 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Name2 = New System.Windows.Forms.TextBox()
        Me.Name3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StartGame
        '
        Me.StartGame.Location = New System.Drawing.Point(432, 308)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(302, 111)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(30, 308)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(302, 111)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Player1
        '
        Me.Player1.AutoSize = True
        Me.Player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1.Location = New System.Drawing.Point(72, 63)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(77, 24)
        Me.Player1.TabIndex = 2
        Me.Player1.Text = "Player 1"
        '
        'Player2
        '
        Me.Player2.AutoSize = True
        Me.Player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2.Location = New System.Drawing.Point(72, 143)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(77, 24)
        Me.Player2.TabIndex = 3
        Me.Player2.Text = "Player 2"
        '
        'Player3
        '
        Me.Player3.AutoSize = True
        Me.Player3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3.Location = New System.Drawing.Point(72, 207)
        Me.Player3.Name = "Player3"
        Me.Player3.Size = New System.Drawing.Size(77, 24)
        Me.Player3.TabIndex = 4
        Me.Player3.Text = "Player 3"
        '
        'Name1
        '
        Me.Name1.Location = New System.Drawing.Point(189, 68)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(369, 20)
        Me.Name1.TabIndex = 5
        '
        'Name2
        '
        Me.Name2.Location = New System.Drawing.Point(189, 148)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(369, 20)
        Me.Name2.TabIndex = 6
        '
        'Name3
        '
        Me.Name3.Location = New System.Drawing.Point(189, 212)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(369, 20)
        Me.Name3.TabIndex = 7
        '
        'EnterPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Name3)
        Me.Controls.Add(Me.Name2)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Player3)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartGame)
        Me.Name = "EnterPlayers"
        Me.Text = "EnterPlayers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGame As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Player1 As Label
    Friend WithEvents Player2 As Label
    Friend WithEvents Player3 As Label
    Friend WithEvents Name1 As TextBox
    Friend WithEvents Name2 As TextBox
    Friend WithEvents Name3 As TextBox
End Class

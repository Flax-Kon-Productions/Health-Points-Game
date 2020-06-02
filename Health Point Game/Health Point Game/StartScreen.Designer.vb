<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadRound1 = New System.Windows.Forms.Button()
        Me.Player1 = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Label()
        Me.Player3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(148, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(809, 325)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadRound1
        '
        Me.LoadRound1.Location = New System.Drawing.Point(364, 597)
        Me.LoadRound1.Name = "LoadRound1"
        Me.LoadRound1.Size = New System.Drawing.Size(527, 62)
        Me.LoadRound1.TabIndex = 1
        Me.LoadRound1.Text = "Load Round 1"
        Me.LoadRound1.UseVisualStyleBackColor = True
        '
        'Player1
        '
        Me.Player1.AutoSize = True
        Me.Player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1.Location = New System.Drawing.Point(113, 452)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(122, 37)
        Me.Player1.TabIndex = 2
        Me.Player1.Text = "Player1"
        '
        'Player2
        '
        Me.Player2.AutoSize = True
        Me.Player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2.Location = New System.Drawing.Point(498, 452)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(124, 37)
        Me.Player2.TabIndex = 3
        Me.Player2.Text = "Player2"
        '
        'Player3
        '
        Me.Player3.AutoSize = True
        Me.Player3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3.Location = New System.Drawing.Point(902, 452)
        Me.Player3.Name = "Player3"
        Me.Player3.Size = New System.Drawing.Size(124, 37)
        Me.Player3.TabIndex = 4
        Me.Player3.Text = "Player3"
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Player3)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.LoadRound1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StartScreen"
        Me.Text = "Opening Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadRound1 As Button
    Friend WithEvents Player1 As Label
    Friend WithEvents Player2 As Label
    Friend WithEvents Player3 As Label
End Class

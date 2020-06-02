<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Round4
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
        Me.Player3 = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Label()
        Me.Player1 = New System.Windows.Forms.Label()
        Me.Cash1 = New System.Windows.Forms.Label()
        Me.Dollar2 = New System.Windows.Forms.Label()
        Me.Dollar3 = New System.Windows.Forms.Label()
        Me.Health3 = New System.Windows.Forms.Label()
        Me.Cash3 = New System.Windows.Forms.Label()
        Me.Health2 = New System.Windows.Forms.Label()
        Me.Cash2 = New System.Windows.Forms.Label()
        Me.Health1 = New System.Windows.Forms.Label()
        Me.Dollar1 = New System.Windows.Forms.Label()
        Me.LoseHealth3 = New System.Windows.Forms.Button()
        Me.LoseHealth2 = New System.Windows.Forms.Button()
        Me.LoseHealth1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrandPrizeDollar = New System.Windows.Forms.Label()
        Me.GrandPrize = New System.Windows.Forms.Label()
        Me.Buzzer1 = New System.Windows.Forms.TextBox()
        Me.NoOneBuzzes = New System.Windows.Forms.Button()
        Me.GoToEndgame = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player3
        '
        Me.Player3.AutoSize = True
        Me.Player3.BackColor = System.Drawing.Color.Blue
        Me.Player3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player3.ForeColor = System.Drawing.Color.White
        Me.Player3.Location = New System.Drawing.Point(959, 448)
        Me.Player3.Name = "Player3"
        Me.Player3.Size = New System.Drawing.Size(124, 37)
        Me.Player3.TabIndex = 189
        Me.Player3.Text = "Player3"
        Me.Player3.Visible = False
        '
        'Player2
        '
        Me.Player2.AutoSize = True
        Me.Player2.BackColor = System.Drawing.Color.Yellow
        Me.Player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2.Location = New System.Drawing.Point(555, 448)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(124, 37)
        Me.Player2.TabIndex = 188
        Me.Player2.Text = "Player2"
        Me.Player2.Visible = False
        '
        'Player1
        '
        Me.Player1.AutoSize = True
        Me.Player1.BackColor = System.Drawing.Color.Red
        Me.Player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1.ForeColor = System.Drawing.Color.White
        Me.Player1.Location = New System.Drawing.Point(170, 448)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(122, 37)
        Me.Player1.TabIndex = 187
        Me.Player1.Text = "Player1"
        Me.Player1.Visible = False
        '
        'Cash1
        '
        Me.Cash1.AutoSize = True
        Me.Cash1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash1.Location = New System.Drawing.Point(132, 509)
        Me.Cash1.Name = "Cash1"
        Me.Cash1.Size = New System.Drawing.Size(35, 37)
        Me.Cash1.TabIndex = 186
        Me.Cash1.Text = "0"
        Me.Cash1.Visible = False
        '
        'Dollar2
        '
        Me.Dollar2.AutoSize = True
        Me.Dollar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dollar2.Location = New System.Drawing.Point(473, 509)
        Me.Dollar2.Name = "Dollar2"
        Me.Dollar2.Size = New System.Drawing.Size(35, 37)
        Me.Dollar2.TabIndex = 185
        Me.Dollar2.Text = "$"
        Me.Dollar2.Visible = False
        '
        'Dollar3
        '
        Me.Dollar3.AutoSize = True
        Me.Dollar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dollar3.Location = New System.Drawing.Point(882, 509)
        Me.Dollar3.Name = "Dollar3"
        Me.Dollar3.Size = New System.Drawing.Size(35, 37)
        Me.Dollar3.TabIndex = 184
        Me.Dollar3.Text = "$"
        Me.Dollar3.Visible = False
        '
        'Health3
        '
        Me.Health3.AutoSize = True
        Me.Health3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health3.Location = New System.Drawing.Point(1082, 509)
        Me.Health3.Name = "Health3"
        Me.Health3.Size = New System.Drawing.Size(63, 37)
        Me.Health3.TabIndex = 183
        Me.Health3.Text = "0%"
        Me.Health3.Visible = False
        '
        'Cash3
        '
        Me.Cash3.AutoSize = True
        Me.Cash3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash3.Location = New System.Drawing.Point(923, 509)
        Me.Cash3.Name = "Cash3"
        Me.Cash3.Size = New System.Drawing.Size(35, 37)
        Me.Cash3.TabIndex = 182
        Me.Cash3.Text = "0"
        Me.Cash3.Visible = False
        '
        'Health2
        '
        Me.Health2.AutoSize = True
        Me.Health2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health2.Location = New System.Drawing.Point(704, 509)
        Me.Health2.Name = "Health2"
        Me.Health2.Size = New System.Drawing.Size(63, 37)
        Me.Health2.TabIndex = 181
        Me.Health2.Text = "0%"
        Me.Health2.Visible = False
        '
        'Cash2
        '
        Me.Cash2.AutoSize = True
        Me.Cash2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash2.Location = New System.Drawing.Point(514, 509)
        Me.Cash2.Name = "Cash2"
        Me.Cash2.Size = New System.Drawing.Size(35, 37)
        Me.Cash2.TabIndex = 180
        Me.Cash2.Text = "0"
        Me.Cash2.Visible = False
        '
        'Health1
        '
        Me.Health1.AutoSize = True
        Me.Health1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Health1.Location = New System.Drawing.Point(285, 509)
        Me.Health1.Name = "Health1"
        Me.Health1.Size = New System.Drawing.Size(63, 37)
        Me.Health1.TabIndex = 179
        Me.Health1.Text = "0%"
        Me.Health1.Visible = False
        '
        'Dollar1
        '
        Me.Dollar1.AutoSize = True
        Me.Dollar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dollar1.Location = New System.Drawing.Point(91, 509)
        Me.Dollar1.Name = "Dollar1"
        Me.Dollar1.Size = New System.Drawing.Size(35, 37)
        Me.Dollar1.TabIndex = 178
        Me.Dollar1.Text = "$"
        Me.Dollar1.Visible = False
        '
        'LoseHealth3
        '
        Me.LoseHealth3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoseHealth3.Location = New System.Drawing.Point(903, 580)
        Me.LoseHealth3.Name = "LoseHealth3"
        Me.LoseHealth3.Size = New System.Drawing.Size(229, 80)
        Me.LoseHealth3.TabIndex = 192
        Me.LoseHealth3.Text = "Lose Health 3"
        Me.LoseHealth3.UseVisualStyleBackColor = True
        '
        'LoseHealth2
        '
        Me.LoseHealth2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoseHealth2.Location = New System.Drawing.Point(507, 580)
        Me.LoseHealth2.Name = "LoseHealth2"
        Me.LoseHealth2.Size = New System.Drawing.Size(233, 80)
        Me.LoseHealth2.TabIndex = 191
        Me.LoseHealth2.Text = "Lose Health 2"
        Me.LoseHealth2.UseVisualStyleBackColor = True
        '
        'LoseHealth1
        '
        Me.LoseHealth1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoseHealth1.Location = New System.Drawing.Point(98, 580)
        Me.LoseHealth1.Name = "LoseHealth1"
        Me.LoseHealth1.Size = New System.Drawing.Size(246, 80)
        Me.LoseHealth1.TabIndex = 190
        Me.LoseHealth1.Text = "Lose Health 1"
        Me.LoseHealth1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(204, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(809, 325)
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'GrandPrizeDollar
        '
        Me.GrandPrizeDollar.AutoSize = True
        Me.GrandPrizeDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandPrizeDollar.Location = New System.Drawing.Point(1053, 149)
        Me.GrandPrizeDollar.Name = "GrandPrizeDollar"
        Me.GrandPrizeDollar.Size = New System.Drawing.Size(35, 37)
        Me.GrandPrizeDollar.TabIndex = 195
        Me.GrandPrizeDollar.Text = "$"
        '
        'GrandPrize
        '
        Me.GrandPrize.AutoSize = True
        Me.GrandPrize.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandPrize.Location = New System.Drawing.Point(1094, 149)
        Me.GrandPrize.Name = "GrandPrize"
        Me.GrandPrize.Size = New System.Drawing.Size(114, 37)
        Me.GrandPrize.TabIndex = 194
        Me.GrandPrize.Text = "100.00"
        '
        'Buzzer1
        '
        Me.Buzzer1.Location = New System.Drawing.Point(54, 123)
        Me.Buzzer1.Name = "Buzzer1"
        Me.Buzzer1.Size = New System.Drawing.Size(100, 20)
        Me.Buzzer1.TabIndex = 196
        '
        'NoOneBuzzes
        '
        Me.NoOneBuzzes.Location = New System.Drawing.Point(54, 178)
        Me.NoOneBuzzes.Name = "NoOneBuzzes"
        Me.NoOneBuzzes.Size = New System.Drawing.Size(100, 23)
        Me.NoOneBuzzes.TabIndex = 197
        Me.NoOneBuzzes.Text = "No one Buzzes"
        Me.NoOneBuzzes.UseVisualStyleBackColor = True
        '
        'GoToEndgame
        '
        Me.GoToEndgame.Location = New System.Drawing.Point(370, 595)
        Me.GoToEndgame.Name = "GoToEndgame"
        Me.GoToEndgame.Size = New System.Drawing.Size(527, 62)
        Me.GoToEndgame.TabIndex = 198
        Me.GoToEndgame.Text = "Go To Endgame"
        Me.GoToEndgame.UseVisualStyleBackColor = True
        Me.GoToEndgame.Visible = False
        '
        'Round4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GoToEndgame)
        Me.Controls.Add(Me.NoOneBuzzes)
        Me.Controls.Add(Me.Buzzer1)
        Me.Controls.Add(Me.GrandPrizeDollar)
        Me.Controls.Add(Me.GrandPrize)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoseHealth3)
        Me.Controls.Add(Me.LoseHealth2)
        Me.Controls.Add(Me.LoseHealth1)
        Me.Controls.Add(Me.Player3)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.Cash1)
        Me.Controls.Add(Me.Dollar2)
        Me.Controls.Add(Me.Dollar3)
        Me.Controls.Add(Me.Health3)
        Me.Controls.Add(Me.Cash3)
        Me.Controls.Add(Me.Health2)
        Me.Controls.Add(Me.Cash2)
        Me.Controls.Add(Me.Health1)
        Me.Controls.Add(Me.Dollar1)
        Me.Name = "Round4"
        Me.Text = "Round 4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player3 As Label
    Friend WithEvents Player2 As Label
    Friend WithEvents Player1 As Label
    Friend WithEvents Cash1 As Label
    Friend WithEvents Dollar2 As Label
    Friend WithEvents Dollar3 As Label
    Friend WithEvents Health3 As Label
    Friend WithEvents Cash3 As Label
    Friend WithEvents Health2 As Label
    Friend WithEvents Cash2 As Label
    Friend WithEvents Health1 As Label
    Friend WithEvents Dollar1 As Label
    Friend WithEvents LoseHealth3 As Button
    Friend WithEvents LoseHealth2 As Button
    Friend WithEvents LoseHealth1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GrandPrizeDollar As Label
    Friend WithEvents GrandPrize As Label
    Friend WithEvents Buzzer1 As TextBox
    Friend WithEvents NoOneBuzzes As Button
    Friend WithEvents GoToEndgame As Button
End Class

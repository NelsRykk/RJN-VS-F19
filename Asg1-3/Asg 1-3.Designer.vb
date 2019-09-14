<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.WisdomBox = New System.Windows.Forms.RichTextBox()
        Me.MLKJr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Faraday = New System.Windows.Forms.Button()
        Me.Newton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Wizzed = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WisdomBox
        '
        Me.WisdomBox.Location = New System.Drawing.Point(103, 321)
        Me.WisdomBox.Name = "WisdomBox"
        Me.WisdomBox.Size = New System.Drawing.Size(558, 54)
        Me.WisdomBox.TabIndex = 0
        Me.WisdomBox.Text = ""
        '
        'MLKJr
        '
        Me.MLKJr.Location = New System.Drawing.Point(103, 30)
        Me.MLKJr.Name = "MLKJr"
        Me.MLKJr.Size = New System.Drawing.Size(113, 37)
        Me.MLKJr.TabIndex = 1
        Me.MLKJr.Text = "Need_Wisdom?"
        Me.MLKJr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rykken Nelson"
        '
        'Faraday
        '
        Me.Faraday.Location = New System.Drawing.Point(103, 89)
        Me.Faraday.Name = "Faraday"
        Me.Faraday.Size = New System.Drawing.Size(113, 37)
        Me.Faraday.TabIndex = 3
        Me.Faraday.Text = "Need_Wisdom?"
        Me.Faraday.UseVisualStyleBackColor = True
        '
        'Newton
        '
        Me.Newton.Location = New System.Drawing.Point(103, 147)
        Me.Newton.Name = "Newton"
        Me.Newton.Size = New System.Drawing.Size(113, 37)
        Me.Newton.TabIndex = 4
        Me.Newton.Text = "Need_Wisdom?"
        Me.Newton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(103, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 37)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Random_Wisdom"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Wizzed
        '
        Me.Wizzed.Location = New System.Drawing.Point(667, 321)
        Me.Wizzed.Name = "Wizzed"
        Me.Wizzed.Size = New System.Drawing.Size(105, 54)
        Me.Wizzed.TabIndex = 8
        Me.Wizzed.Text = "Exit"
        Me.Wizzed.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Asg1_3.My.Resources.Resources.Faraday
        Me.PictureBox1.Location = New System.Drawing.Point(82, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(668, 475)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Asg1_3.My.Resources.Resources.cool_black_wallpapers_9
        Me.PictureBox2.Location = New System.Drawing.Point(3, -13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(798, 475)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Wizzed)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Newton)
        Me.Controls.Add(Me.Faraday)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MLKJr)
        Me.Controls.Add(Me.WisdomBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Asg 1-3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WisdomBox As RichTextBox
    Friend WithEvents MLKJr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Faraday As Button
    Friend WithEvents Newton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Wizzed As Button
End Class

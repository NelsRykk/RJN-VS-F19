<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DrawButton
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DrawingRadioButton = New System.Windows.Forms.RadioButton()
        Me.RectangleRadioButton = New System.Windows.Forms.RadioButton()
        Me.CircleRadioButton = New System.Windows.Forms.RadioButton()
        Me.EffectsRadioButton = New System.Windows.Forms.RadioButton()
        Me.BrushSizeTextbox = New System.Windows.Forms.TextBox()
        Me.BrushSizeLable = New System.Windows.Forms.Label()
        Me.SineWaveButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(126, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1170, 582)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ColorButton
        '
        Me.ColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ColorButton.Location = New System.Drawing.Point(12, 272)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(97, 39)
        Me.ColorButton.TabIndex = 4
        Me.ColorButton.Text = "&Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ClearButton.Location = New System.Drawing.Point(12, 329)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(97, 39)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ExitButton.Location = New System.Drawing.Point(12, 387)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(97, 39)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'DrawingRadioButton
        '
        Me.DrawingRadioButton.AutoSize = True
        Me.DrawingRadioButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrawingRadioButton.Location = New System.Drawing.Point(4, 49)
        Me.DrawingRadioButton.Name = "DrawingRadioButton"
        Me.DrawingRadioButton.Size = New System.Drawing.Size(116, 19)
        Me.DrawingRadioButton.TabIndex = 8
        Me.DrawingRadioButton.TabStop = True
        Me.DrawingRadioButton.Text = "Draw With Pen"
        Me.DrawingRadioButton.UseVisualStyleBackColor = True
        '
        'RectangleRadioButton
        '
        Me.RectangleRadioButton.AutoSize = True
        Me.RectangleRadioButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleRadioButton.Location = New System.Drawing.Point(4, 74)
        Me.RectangleRadioButton.Name = "RectangleRadioButton"
        Me.RectangleRadioButton.Size = New System.Drawing.Size(123, 19)
        Me.RectangleRadioButton.TabIndex = 9
        Me.RectangleRadioButton.TabStop = True
        Me.RectangleRadioButton.Text = "Draw Rectangle"
        Me.RectangleRadioButton.UseVisualStyleBackColor = True
        '
        'CircleRadioButton
        '
        Me.CircleRadioButton.AutoSize = True
        Me.CircleRadioButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircleRadioButton.Location = New System.Drawing.Point(4, 99)
        Me.CircleRadioButton.Name = "CircleRadioButton"
        Me.CircleRadioButton.Size = New System.Drawing.Size(102, 19)
        Me.CircleRadioButton.TabIndex = 10
        Me.CircleRadioButton.TabStop = True
        Me.CircleRadioButton.Text = "Draw Circle"
        Me.CircleRadioButton.UseVisualStyleBackColor = True
        '
        'EffectsRadioButton
        '
        Me.EffectsRadioButton.AutoSize = True
        Me.EffectsRadioButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EffectsRadioButton.Location = New System.Drawing.Point(4, 124)
        Me.EffectsRadioButton.Name = "EffectsRadioButton"
        Me.EffectsRadioButton.Size = New System.Drawing.Size(109, 19)
        Me.EffectsRadioButton.TabIndex = 12
        Me.EffectsRadioButton.TabStop = True
        Me.EffectsRadioButton.Text = "Draw Effects"
        Me.EffectsRadioButton.UseVisualStyleBackColor = True
        '
        'BrushSizeTextbox
        '
        Me.BrushSizeTextbox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushSizeTextbox.Location = New System.Drawing.Point(12, 171)
        Me.BrushSizeTextbox.Name = "BrushSizeTextbox"
        Me.BrushSizeTextbox.Size = New System.Drawing.Size(100, 21)
        Me.BrushSizeTextbox.TabIndex = 13
        '
        'BrushSizeLable
        '
        Me.BrushSizeLable.AutoSize = True
        Me.BrushSizeLable.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrushSizeLable.Location = New System.Drawing.Point(12, 153)
        Me.BrushSizeLable.Name = "BrushSizeLable"
        Me.BrushSizeLable.Size = New System.Drawing.Size(77, 15)
        Me.BrushSizeLable.TabIndex = 14
        Me.BrushSizeLable.Text = "Brush Size"
        '
        'SineWaveButton
        '
        Me.SineWaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SineWaveButton.Location = New System.Drawing.Point(12, 227)
        Me.SineWaveButton.Name = "SineWaveButton"
        Me.SineWaveButton.Size = New System.Drawing.Size(97, 39)
        Me.SineWaveButton.TabIndex = 15
        Me.SineWaveButton.Text = "&SineWave"
        Me.SineWaveButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DrawButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 652)
        Me.Controls.Add(Me.SineWaveButton)
        Me.Controls.Add(Me.BrushSizeLable)
        Me.Controls.Add(Me.BrushSizeTextbox)
        Me.Controls.Add(Me.EffectsRadioButton)
        Me.Controls.Add(Me.CircleRadioButton)
        Me.Controls.Add(Me.RectangleRadioButton)
        Me.Controls.Add(Me.DrawingRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DrawButton"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DrawingRadioButton As RadioButton
    Friend WithEvents RectangleRadioButton As RadioButton
    Friend WithEvents CircleRadioButton As RadioButton
    Friend WithEvents EffectsRadioButton As RadioButton
    Friend WithEvents BrushSizeTextbox As TextBox
    Friend WithEvents BrushSizeLable As Label
    Friend WithEvents SineWaveButton As Button
    Friend WithEvents Timer1 As Timer
End Class

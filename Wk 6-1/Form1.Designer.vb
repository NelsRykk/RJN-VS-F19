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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DrawingButton = New System.Windows.Forms.RadioButton()
        Me.RectangleButton = New System.Windows.Forms.RadioButton()
        Me.CircleButton = New System.Windows.Forms.RadioButton()
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
        Me.ColorButton.Location = New System.Drawing.Point(12, 212)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(97, 39)
        Me.ColorButton.TabIndex = 4
        Me.ColorButton.Text = "&Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ClearButton.Location = New System.Drawing.Point(12, 269)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(97, 39)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ExitButton.Location = New System.Drawing.Point(12, 327)
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
        'DrawingButton
        '
        Me.DrawingButton.AutoSize = True
        Me.DrawingButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrawingButton.Location = New System.Drawing.Point(4, 49)
        Me.DrawingButton.Name = "DrawingButton"
        Me.DrawingButton.Size = New System.Drawing.Size(116, 19)
        Me.DrawingButton.TabIndex = 8
        Me.DrawingButton.TabStop = True
        Me.DrawingButton.Text = "Draw With Pen"
        Me.DrawingButton.UseVisualStyleBackColor = True
        '
        'RectangleButton
        '
        Me.RectangleButton.AutoSize = True
        Me.RectangleButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleButton.Location = New System.Drawing.Point(4, 74)
        Me.RectangleButton.Name = "RectangleButton"
        Me.RectangleButton.Size = New System.Drawing.Size(123, 19)
        Me.RectangleButton.TabIndex = 9
        Me.RectangleButton.TabStop = True
        Me.RectangleButton.Text = "Draw Rectangle"
        Me.RectangleButton.UseVisualStyleBackColor = True
        '
        'CircleButton
        '
        Me.CircleButton.AutoSize = True
        Me.CircleButton.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircleButton.Location = New System.Drawing.Point(4, 99)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(102, 19)
        Me.CircleButton.TabIndex = 10
        Me.CircleButton.TabStop = True
        Me.CircleButton.Text = "Draw Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 652)
        Me.Controls.Add(Me.CircleButton)
        Me.Controls.Add(Me.RectangleButton)
        Me.Controls.Add(Me.DrawingButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DrawButton"
        Me.Text = "Form1"
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
    Friend WithEvents DrawingButton As RadioButton
    Friend WithEvents RectangleButton As RadioButton
    Friend WithEvents CircleButton As RadioButton
End Class

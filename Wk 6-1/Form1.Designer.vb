<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RectangleButton = New System.Windows.Forms.Button()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawButton
        '
        Me.DrawButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DrawButton.Location = New System.Drawing.Point(12, 27)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(97, 39)
        Me.DrawButton.TabIndex = 0
        Me.DrawButton.Text = "&Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(115, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1214, 628)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RectangleButton
        '
        Me.RectangleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RectangleButton.Location = New System.Drawing.Point(12, 90)
        Me.RectangleButton.Name = "RectangleButton"
        Me.RectangleButton.Size = New System.Drawing.Size(97, 39)
        Me.RectangleButton.TabIndex = 2
        Me.RectangleButton.Text = "Draw &Rectangle"
        Me.RectangleButton.UseVisualStyleBackColor = True
        '
        'CircleButton
        '
        Me.CircleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CircleButton.Location = New System.Drawing.Point(12, 152)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(97, 39)
        Me.CircleButton.TabIndex = 3
        Me.CircleButton.Text = "D&raw Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(12, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CircleButton)
        Me.Controls.Add(Me.RectangleButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DrawButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RectangleButton As Button
    Friend WithEvents CircleButton As Button
    Friend WithEvents Button1 As Button
End Class

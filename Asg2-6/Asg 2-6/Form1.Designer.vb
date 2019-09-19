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
        Me.Oregon = New System.Windows.Forms.Button()
        Me.Washington = New System.Windows.Forms.Button()
        Me.Utah = New System.Windows.Forms.Button()
        Me.Cali = New System.Windows.Forms.Button()
        Me.Idaho = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wyoming = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Oregon
        '
        Me.Oregon.BackColor = System.Drawing.SystemColors.Info
        Me.Oregon.Location = New System.Drawing.Point(32, 247)
        Me.Oregon.Name = "Oregon"
        Me.Oregon.Size = New System.Drawing.Size(98, 53)
        Me.Oregon.TabIndex = 0
        Me.Oregon.Text = "Oregon Flag"
        Me.Oregon.UseVisualStyleBackColor = False
        '
        'Washington
        '
        Me.Washington.BackColor = System.Drawing.SystemColors.Info
        Me.Washington.Location = New System.Drawing.Point(32, 364)
        Me.Washington.Name = "Washington"
        Me.Washington.Size = New System.Drawing.Size(98, 53)
        Me.Washington.TabIndex = 1
        Me.Washington.Text = "Washington Flag"
        Me.Washington.UseVisualStyleBackColor = False
        '
        'Utah
        '
        Me.Utah.BackColor = System.Drawing.SystemColors.Info
        Me.Utah.Location = New System.Drawing.Point(32, 305)
        Me.Utah.Name = "Utah"
        Me.Utah.Size = New System.Drawing.Size(98, 53)
        Me.Utah.TabIndex = 2
        Me.Utah.Text = "Utah Flag"
        Me.Utah.UseVisualStyleBackColor = False
        '
        'Cali
        '
        Me.Cali.BackColor = System.Drawing.SystemColors.Info
        Me.Cali.Location = New System.Drawing.Point(32, 188)
        Me.Cali.Name = "Cali"
        Me.Cali.Size = New System.Drawing.Size(98, 53)
        Me.Cali.TabIndex = 3
        Me.Cali.Text = "California Flag"
        Me.Cali.UseVisualStyleBackColor = False
        '
        'Idaho
        '
        Me.Idaho.BackColor = System.Drawing.SystemColors.Info
        Me.Idaho.Location = New System.Drawing.Point(32, 129)
        Me.Idaho.Name = "Idaho"
        Me.Idaho.Size = New System.Drawing.Size(98, 53)
        Me.Idaho.TabIndex = 4
        Me.Idaho.Text = "Idaho Flag"
        Me.Idaho.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Wyoming
        '
        Me.Wyoming.BackColor = System.Drawing.SystemColors.Info
        Me.Wyoming.ForeColor = System.Drawing.Color.Black
        Me.Wyoming.Location = New System.Drawing.Point(32, 70)
        Me.Wyoming.Name = "Wyoming"
        Me.Wyoming.Size = New System.Drawing.Size(98, 53)
        Me.Wyoming.TabIndex = 7
        Me.Wyoming.Text = "Wyoming Flag"
        Me.Wyoming.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Asg_2_6.My.Resources.Resources._41ANJDAT1DL__SX425_
        Me.PictureBox1.Location = New System.Drawing.Point(153, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 425)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Wyoming)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Utah)
        Me.Controls.Add(Me.Cali)
        Me.Controls.Add(Me.Idaho)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Washington)
        Me.Controls.Add(Me.Oregon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Oregon As Button
    Friend WithEvents Washington As Button
    Friend WithEvents Utah As Button
    Friend WithEvents Cali As Button
    Friend WithEvents Idaho As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Wyoming As Button
End Class

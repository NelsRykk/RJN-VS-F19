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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DiceRollListBox = New System.Windows.Forms.ListBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Roll Dice 10000 Times"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Display Dice Rolled"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DiceRollListBox
        '
        Me.DiceRollListBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceRollListBox.FormattingEnabled = True
        Me.DiceRollListBox.ItemHeight = 18
        Me.DiceRollListBox.Location = New System.Drawing.Point(200, 25)
        Me.DiceRollListBox.Name = "DiceRollListBox"
        Me.DiceRollListBox.Size = New System.Drawing.Size(873, 634)
        Me.DiceRollListBox.TabIndex = 2
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 192)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(142, 55)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'EndButton
        '
        Me.EndButton.Location = New System.Drawing.Point(12, 272)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(142, 55)
        Me.EndButton.TabIndex = 4
        Me.EndButton.Text = "Exit"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 679)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DiceRollListBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DiceRollListBox As ListBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents EndButton As Button
End Class

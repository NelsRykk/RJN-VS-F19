<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.devide = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.first = New System.Windows.Forms.RichTextBox()
        Me.second = New System.Windows.Forms.RichTextBox()
        Me.result = New System.Windows.Forms.RichTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(101, 93)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(75, 23)
        Me.plus.TabIndex = 0
        Me.plus.Text = "add"
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(101, 138)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(75, 23)
        Me.minus.TabIndex = 1
        Me.minus.Text = "subtract "
        Me.minus.UseVisualStyleBackColor = True
        '
        'devide
        '
        Me.devide.Location = New System.Drawing.Point(101, 227)
        Me.devide.Name = "devide"
        Me.devide.Size = New System.Drawing.Size(75, 23)
        Me.devide.TabIndex = 2
        Me.devide.Text = "Devide"
        Me.devide.UseVisualStyleBackColor = True
        '
        'multiply
        '
        Me.multiply.Location = New System.Drawing.Point(101, 184)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(75, 23)
        Me.multiply.TabIndex = 3
        Me.multiply.Text = "Multiply"
        Me.multiply.UseVisualStyleBackColor = True
        '
        'first
        '
        Me.first.Location = New System.Drawing.Point(310, 120)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(156, 23)
        Me.first.TabIndex = 4
        Me.first.Text = "44"
        '
        'second
        '
        Me.second.Location = New System.Drawing.Point(284, 165)
        Me.second.Name = "second"
        Me.second.Size = New System.Drawing.Size(156, 23)
        Me.second.TabIndex = 5
        Me.second.Text = "4"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(284, 229)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(156, 21)
        Me.result.TabIndex = 8
        Me.result.Text = ""
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(416, 120)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(8, 20)
        Me.MaskedTextBox1.TabIndex = 11
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.second)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.devide)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.plus)
        Me.Name = "Calculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plus As Button
    Friend WithEvents minus As Button
    Friend WithEvents devide As Button
    Friend WithEvents multiply As Button
    Friend WithEvents first As RichTextBox
    Friend WithEvents second As RichTextBox
    Friend WithEvents result As RichTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class

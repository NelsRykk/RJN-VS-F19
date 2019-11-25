<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Project1
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
        Me.nameBox = New System.Windows.Forms.RichTextBox()
        Me.firstNumberBox = New System.Windows.Forms.RichTextBox()
        Me.secondNumberBox = New System.Windows.Forms.RichTextBox()
        Me.answerBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ageBox = New System.Windows.Forms.RichTextBox()
        Me.gradeBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonAdd = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSubtract = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMultiply = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDivide = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(6, 60)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(321, 43)
        Me.nameBox.TabIndex = 0
        Me.nameBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.nameBox, "Type In your Name")
        '
        'firstNumberBox
        '
        Me.firstNumberBox.Location = New System.Drawing.Point(6, 80)
        Me.firstNumberBox.Name = "firstNumberBox"
        Me.firstNumberBox.Size = New System.Drawing.Size(321, 43)
        Me.firstNumberBox.TabIndex = 3
        Me.firstNumberBox.TabStop = False
        Me.firstNumberBox.Text = ""
        '
        'secondNumberBox
        '
        Me.secondNumberBox.Location = New System.Drawing.Point(6, 169)
        Me.secondNumberBox.Name = "secondNumberBox"
        Me.secondNumberBox.Size = New System.Drawing.Size(321, 43)
        Me.secondNumberBox.TabIndex = 4
        Me.secondNumberBox.TabStop = False
        Me.secondNumberBox.Text = ""
        '
        'answerBox
        '
        Me.answerBox.Location = New System.Drawing.Point(5, 257)
        Me.answerBox.Name = "answerBox"
        Me.answerBox.Size = New System.Drawing.Size(321, 43)
        Me.answerBox.TabIndex = 5
        Me.answerBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.answerBox, "Type in your answer")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.answerBox)
        Me.GroupBox1.Controls.Add(Me.secondNumberBox)
        Me.GroupBox1.Controls.Add(Me.firstNumberBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 292)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "         Current Math Problem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Student Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "2nd Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "1st Number "
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(351, 60)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(54, 43)
        Me.ageBox.TabIndex = 1
        Me.ageBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.ageBox, "Type in your age , must be between 7 and 11")
        '
        'gradeBox
        '
        Me.gradeBox.Location = New System.Drawing.Point(434, 60)
        Me.gradeBox.Name = "gradeBox"
        Me.gradeBox.Size = New System.Drawing.Size(54, 43)
        Me.gradeBox.TabIndex = 2
        Me.gradeBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.gradeBox, "Type in your grade, must be between 1st to 4th")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.NameLabel)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.gradeBox)
        Me.GroupBox2.Controls.Add(Me.ageBox)
        Me.GroupBox2.Controls.Add(Me.nameBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 118)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "          Student Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Grade"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(29, 32)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 25)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Age"
        '
        'RadioButtonAdd
        '
        Me.RadioButtonAdd.AutoSize = True
        Me.RadioButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAdd.Location = New System.Drawing.Point(43, 52)
        Me.RadioButtonAdd.Name = "RadioButtonAdd"
        Me.RadioButtonAdd.Size = New System.Drawing.Size(68, 29)
        Me.RadioButtonAdd.TabIndex = 3
        Me.RadioButtonAdd.TabStop = True
        Me.RadioButtonAdd.Text = "Add"
        Me.RadioButtonAdd.UseVisualStyleBackColor = True
        '
        'RadioButtonSubtract
        '
        Me.RadioButtonSubtract.AutoSize = True
        Me.RadioButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSubtract.Location = New System.Drawing.Point(43, 116)
        Me.RadioButtonSubtract.Name = "RadioButtonSubtract"
        Me.RadioButtonSubtract.Size = New System.Drawing.Size(110, 29)
        Me.RadioButtonSubtract.TabIndex = 4
        Me.RadioButtonSubtract.TabStop = True
        Me.RadioButtonSubtract.Text = "Subtract"
        Me.RadioButtonSubtract.UseVisualStyleBackColor = True
        '
        'RadioButtonMultiply
        '
        Me.RadioButtonMultiply.AutoSize = True
        Me.RadioButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMultiply.Location = New System.Drawing.Point(43, 171)
        Me.RadioButtonMultiply.Name = "RadioButtonMultiply"
        Me.RadioButtonMultiply.Size = New System.Drawing.Size(104, 29)
        Me.RadioButtonMultiply.TabIndex = 5
        Me.RadioButtonMultiply.TabStop = True
        Me.RadioButtonMultiply.Text = "Multiply"
        Me.RadioButtonMultiply.UseVisualStyleBackColor = True
        '
        'RadioButtonDivide
        '
        Me.RadioButtonDivide.AutoSize = True
        Me.RadioButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDivide.Location = New System.Drawing.Point(46, 227)
        Me.RadioButtonDivide.Name = "RadioButtonDivide"
        Me.RadioButtonDivide.Size = New System.Drawing.Size(90, 29)
        Me.RadioButtonDivide.TabIndex = 6
        Me.RadioButtonDivide.TabStop = True
        Me.RadioButtonDivide.Text = "Divide"
        Me.RadioButtonDivide.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonDivide)
        Me.GroupBox3.Controls.Add(Me.RadioButtonMultiply)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSubtract)
        Me.GroupBox3.Controls.Add(Me.RadioButtonAdd)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(376, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 292)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Math Problem "
        '
        'submitButton
        '
        Me.submitButton.AccessibleDescription = ""
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(28, 39)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(180, 60)
        Me.submitButton.TabIndex = 13
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(28, 136)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(180, 60)
        Me.clearButton.TabIndex = 14
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton.Location = New System.Drawing.Point(28, 231)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(180, 60)
        Me.summaryButton.TabIndex = 15
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(28, 326)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(180, 60)
        Me.exitButton.TabIndex = 16
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.exitButton)
        Me.GroupBox4.Controls.Add(Me.summaryButton)
        Me.GroupBox4.Controls.Add(Me.clearButton)
        Me.GroupBox4.Controls.Add(Me.submitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(557, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(228, 422)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'Project1
        '
        Me.AcceptButton = Me.submitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Project1"
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameBox As RichTextBox
    Friend WithEvents firstNumberBox As RichTextBox
    Friend WithEvents secondNumberBox As RichTextBox
    Friend WithEvents answerBox As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ageBox As RichTextBox
    Friend WithEvents gradeBox As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonAdd As RadioButton
    Friend WithEvents RadioButtonSubtract As RadioButton
    Friend WithEvents RadioButtonMultiply As RadioButton
    Friend WithEvents RadioButtonDivide As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents submitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents summaryButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class

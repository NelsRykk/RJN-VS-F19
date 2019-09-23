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
        Me.components = New System.ComponentModel.Container()
        Me.leave = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddDisplay = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'leave
        '
        Me.leave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.leave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leave.Location = New System.Drawing.Point(710, 381)
        Me.leave.Name = "leave"
        Me.leave.Size = New System.Drawing.Size(98, 52)
        Me.leave.TabIndex = 10
        Me.leave.TabStop = False
        Me.leave.Text = "&Exit"
        Me.leave.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(88, 40)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(274, 20)
        Me.MaskedTextBox1.SkipLiterals = False
        Me.MaskedTextBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox1, "Type in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first name")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(140, 134)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(274, 20)
        Me.MaskedTextBox2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox2, "Type in last name")
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(140, 190)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(274, 20)
        Me.MaskedTextBox3.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox3, "type in address ")
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(140, 248)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(274, 20)
        Me.MaskedTextBox4.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox4, "Type in City")
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(140, 328)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(85, 20)
        Me.MaskedTextBox5.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox5, "Type in  state")
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(140, 381)
        Me.MaskedTextBox6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(85, 20)
        Me.MaskedTextBox6.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox6, "Type in Zip code")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(585, 381)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(98, 52)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Display
        '
        Me.Display.AccessibleName = ""
        Me.Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Display.Location = New System.Drawing.Point(461, 381)
        Me.Display.Name = "Display"
        Me.Display.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Display.Size = New System.Drawing.Size(98, 52)
        Me.Display.TabIndex = 8
        Me.Display.Text = "Display"
        Me.Display.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(52, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 397)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddDisplay)
        Me.Panel2.Location = New System.Drawing.Point(461, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 325)
        Me.Panel2.TabIndex = 16
        '
        'AddDisplay
        '
        Me.AddDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AddDisplay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddDisplay.BackColor = System.Drawing.SystemColors.Info
        Me.AddDisplay.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AddDisplay.Location = New System.Drawing.Point(0, 3)
        Me.AddDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.AddDisplay.Name = "AddDisplay"
        Me.AddDisplay.ReadOnly = True
        Me.AddDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AddDisplay.Size = New System.Drawing.Size(350, 325)
        Me.AddDisplay.TabIndex = 100
        Me.AddDisplay.TabStop = False
        Me.AddDisplay.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(611, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Label8"
        '
        'Form1
        '
        Me.AcceptButton = Me.Display
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(844, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.leave)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leave As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents Display As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Public WithEvents AddDisplay As RichTextBox
End Class

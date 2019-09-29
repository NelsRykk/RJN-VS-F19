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
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.beginningIn = New System.Windows.Forms.RichTextBox()
        Me.endingIn = New System.Windows.Forms.RichTextBox()
        Me.costGoods = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.turnOver = New System.Windows.Forms.RichTextBox()
        Me.averageIn = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calculate
        '
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.Location = New System.Drawing.Point(141, 353)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(299, 85)
        Me.Calculate.TabIndex = 3
        Me.Calculate.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.Calculate, "Accept Button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(496, 353)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(96, 85)
        Me.Clear.TabIndex = 4
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(627, 353)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(96, 85)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Cancel Button")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'beginningIn
        '
        Me.beginningIn.Location = New System.Drawing.Point(15, 48)
        Me.beginningIn.Name = "beginningIn"
        Me.beginningIn.Size = New System.Drawing.Size(276, 39)
        Me.beginningIn.TabIndex = 0
        Me.beginningIn.Text = ""
        '
        'endingIn
        '
        Me.endingIn.Location = New System.Drawing.Point(15, 153)
        Me.endingIn.Name = "endingIn"
        Me.endingIn.Size = New System.Drawing.Size(276, 39)
        Me.endingIn.TabIndex = 1
        Me.endingIn.Text = ""
        '
        'costGoods
        '
        Me.costGoods.Location = New System.Drawing.Point(15, 267)
        Me.costGoods.Name = "costGoods"
        Me.costGoods.Size = New System.Drawing.Size(276, 39)
        Me.costGoods.TabIndex = 2
        Me.costGoods.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.beginningIn)
        Me.GroupBox1.Controls.Add(Me.endingIn)
        Me.GroupBox1.Controls.Add(Me.costGoods)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 326)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cost Of Goods Sold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ending Inventory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Beginning Inventory"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.turnOver)
        Me.GroupBox2.Controls.Add(Me.averageIn)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 326)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Turnover"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Average Inventory"
        '
        'turnOver
        '
        Me.turnOver.Location = New System.Drawing.Point(29, 153)
        Me.turnOver.Name = "turnOver"
        Me.turnOver.Size = New System.Drawing.Size(276, 39)
        Me.turnOver.TabIndex = 7
        Me.turnOver.TabStop = False
        Me.turnOver.Text = ""
        '
        'averageIn
        '
        Me.averageIn.Location = New System.Drawing.Point(29, 48)
        Me.averageIn.Name = "averageIn"
        Me.averageIn.Size = New System.Drawing.Size(276, 39)
        Me.averageIn.TabIndex = 6
        Me.averageIn.TabStop = False
        Me.averageIn.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Calculate As Button
    Friend WithEvents Clear As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents beginningIn As RichTextBox
    Friend WithEvents endingIn As RichTextBox
    Friend WithEvents costGoods As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents turnOver As RichTextBox
    Friend WithEvents averageIn As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class

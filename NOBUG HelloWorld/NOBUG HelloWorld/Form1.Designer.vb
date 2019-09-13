<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bot
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
        Me.english = New System.Windows.Forms.Button()
        Me.french = New System.Windows.Forms.Button()
        Me.Italian = New System.Windows.Forms.Button()
        Me.sayWhat = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'english
        '
        Me.english.Location = New System.Drawing.Point(101, 12)
        Me.english.Name = "english"
        Me.english.Size = New System.Drawing.Size(75, 23)
        Me.english.TabIndex = 0
        Me.english.Text = "English"
        Me.english.UseVisualStyleBackColor = True
        '
        'french
        '
        Me.french.Location = New System.Drawing.Point(101, 49)
        Me.french.Name = "french"
        Me.french.Size = New System.Drawing.Size(75, 23)
        Me.french.TabIndex = 2
        Me.french.Text = "French"
        Me.french.UseVisualStyleBackColor = True
        '
        'Italian
        '
        Me.Italian.Location = New System.Drawing.Point(101, 78)
        Me.Italian.Name = "Italian"
        Me.Italian.Size = New System.Drawing.Size(75, 23)
        Me.Italian.TabIndex = 3
        Me.Italian.Text = "Italian"
        Me.Italian.UseVisualStyleBackColor = True
        '
        'sayWhat
        '
        Me.sayWhat.Location = New System.Drawing.Point(201, 149)
        Me.sayWhat.Name = "sayWhat"
        Me.sayWhat.Size = New System.Drawing.Size(392, 53)
        Me.sayWhat.TabIndex = 4
        Me.sayWhat.Text = ""
        '
        'bot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sayWhat)
        Me.Controls.Add(Me.Italian)
        Me.Controls.Add(Me.french)
        Me.Controls.Add(Me.english)
        Me.Name = "bot"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents english As Button
    Friend WithEvents french As Button
    Friend WithEvents Italian As Button
    Friend WithEvents sayWhat As RichTextBox
End Class

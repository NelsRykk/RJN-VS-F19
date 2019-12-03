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
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.StringIntegerTextBox = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ConvertedTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ConvertButton
        '
        Me.ConvertButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertButton.Location = New System.Drawing.Point(59, 58)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(145, 79)
        Me.ConvertButton.TabIndex = 0
        Me.ConvertButton.Text = "Convert String To Integer"
        Me.ToolTip1.SetToolTip(Me.ConvertButton, "Enter To Convert To 32-bit Integer")
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'StringIntegerTextBox
        '
        Me.StringIntegerTextBox.Location = New System.Drawing.Point(59, 143)
        Me.StringIntegerTextBox.Name = "StringIntegerTextBox"
        Me.StringIntegerTextBox.Size = New System.Drawing.Size(185, 53)
        Me.StringIntegerTextBox.TabIndex = 1
        Me.StringIntegerTextBox.Text = ""
        '
        'ConvertedTextBox
        '
        Me.ConvertedTextBox.Location = New System.Drawing.Point(363, 143)
        Me.ConvertedTextBox.Name = "ConvertedTextBox"
        Me.ConvertedTextBox.Size = New System.Drawing.Size(185, 53)
        Me.ConvertedTextBox.TabIndex = 2
        Me.ConvertedTextBox.Text = ""
        '
        'Form1
        '
        Me.AcceptButton = Me.ConvertButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ConvertedTextBox)
        Me.Controls.Add(Me.StringIntegerTextBox)
        Me.Controls.Add(Me.ConvertButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConvertButton As Button
    Friend WithEvents StringIntegerTextBox As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ConvertedTextBox As RichTextBox
End Class

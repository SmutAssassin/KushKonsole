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
        TextBox1 = New TextBox()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Dock = DockStyle.Bottom
        TextBox1.ForeColor = Color.FromArgb(CByte(48), CByte(255), CByte(119))
        TextBox1.Location = New Point(0, 302)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(948, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(578, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.ForeColor = Color.FromArgb(CByte(48), CByte(255), CByte(119))
        RichTextBox1.Location = New Point(0, 0)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(948, 302)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 325)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Kush Konsole"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

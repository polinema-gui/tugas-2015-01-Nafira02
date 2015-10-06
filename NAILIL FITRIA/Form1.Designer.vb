<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Picture_Form1
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
        Me.Ubah_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ubah_Button
        '
        Me.Ubah_Button.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ubah_Button.ForeColor = System.Drawing.Color.Blue
        Me.Ubah_Button.Location = New System.Drawing.Point(238, 288)
        Me.Ubah_Button.Name = "Ubah_Button"
        Me.Ubah_Button.Size = New System.Drawing.Size(75, 27)
        Me.Ubah_Button.TabIndex = 0
        Me.Ubah_Button.Text = "Ubah"
        Me.Ubah_Button.UseVisualStyleBackColor = True
        '
        'Picture_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.ClientSize = New System.Drawing.Size(349, 340)
        Me.Controls.Add(Me.Ubah_Button)
        Me.Name = "Picture_Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ubah_Button As System.Windows.Forms.Button

End Class

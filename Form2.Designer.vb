<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RXonly = New System.Windows.Forms.RadioButton
        Me.TXonly = New System.Windows.Forms.RadioButton
        Me.Simplex = New System.Windows.Forms.RadioButton
        Me.RPT_U = New System.Windows.Forms.RadioButton
        Me.RPT_D = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 41)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter new frequency:"
        '
        'RXonly
        '
        Me.RXonly.AutoSize = True
        Me.RXonly.Location = New System.Drawing.Point(18, 85)
        Me.RXonly.Name = "RXonly"
        Me.RXonly.Size = New System.Drawing.Size(64, 17)
        Me.RXonly.TabIndex = 2
        Me.RXonly.TabStop = True
        Me.RXonly.Text = "RX Only"
        Me.RXonly.UseVisualStyleBackColor = True
        '
        'TXonly
        '
        Me.TXonly.AutoSize = True
        Me.TXonly.Location = New System.Drawing.Point(18, 108)
        Me.TXonly.Name = "TXonly"
        Me.TXonly.Size = New System.Drawing.Size(63, 17)
        Me.TXonly.TabIndex = 3
        Me.TXonly.TabStop = True
        Me.TXonly.Text = "TX Only"
        Me.TXonly.UseVisualStyleBackColor = True
        '
        'Simplex
        '
        Me.Simplex.AutoSize = True
        Me.Simplex.Checked = True
        Me.Simplex.Location = New System.Drawing.Point(92, 85)
        Me.Simplex.Name = "Simplex"
        Me.Simplex.Size = New System.Drawing.Size(61, 17)
        Me.Simplex.TabIndex = 4
        Me.Simplex.TabStop = True
        Me.Simplex.Text = "Simplex"
        Me.Simplex.UseVisualStyleBackColor = True
        '
        'RPT_U
        '
        Me.RPT_U.AutoSize = True
        Me.RPT_U.Location = New System.Drawing.Point(171, 85)
        Me.RPT_U.Name = "RPT_U"
        Me.RPT_U.Size = New System.Drawing.Size(56, 17)
        Me.RPT_U.TabIndex = 5
        Me.RPT_U.TabStop = True
        Me.RPT_U.Text = "RPT +"
        Me.RPT_U.UseVisualStyleBackColor = True
        '
        'RPT_D
        '
        Me.RPT_D.AutoSize = True
        Me.RPT_D.Location = New System.Drawing.Point(171, 108)
        Me.RPT_D.Name = "RPT_D"
        Me.RPT_D.Size = New System.Drawing.Size(53, 17)
        Me.RPT_D.TabIndex = 6
        Me.RPT_D.TabStop = True
        Me.RPT_D.Text = "RPT -"
        Me.RPT_D.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SET/EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(87, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "SET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 180)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RPT_D)
        Me.Controls.Add(Me.RPT_U)
        Me.Controls.Add(Me.Simplex)
        Me.Controls.Add(Me.TXonly)
        Me.Controls.Add(Me.RXonly)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "RS-UV3 RF Frequency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RXonly As System.Windows.Forms.RadioButton
    Friend WithEvents TXonly As System.Windows.Forms.RadioButton
    Friend WithEvents Simplex As System.Windows.Forms.RadioButton
    Friend WithEvents RPT_U As System.Windows.Forms.RadioButton
    Friend WithEvents RPT_D As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class

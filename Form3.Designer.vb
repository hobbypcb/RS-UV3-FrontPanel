<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label
        Me.T_freq = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.T_OFF = New System.Windows.Forms.RadioButton
        Me.T_TX = New System.Windows.Forms.RadioButton
        Me.T_TXRX = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TONE FREQ:"
        '
        'T_freq
        '
        Me.T_freq.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_freq.Location = New System.Drawing.Point(138, 20)
        Me.T_freq.Name = "T_freq"
        Me.T_freq.Size = New System.Drawing.Size(116, 32)
        Me.T_freq.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(107, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "SET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "SET/EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T_OFF
        '
        Me.T_OFF.AutoSize = True
        Me.T_OFF.Location = New System.Drawing.Point(43, 70)
        Me.T_OFF.Name = "T_OFF"
        Me.T_OFF.Size = New System.Drawing.Size(45, 17)
        Me.T_OFF.TabIndex = 13
        Me.T_OFF.TabStop = True
        Me.T_OFF.Text = "OFF"
        Me.T_OFF.UseVisualStyleBackColor = True
        '
        'T_TX
        '
        Me.T_TX.AutoSize = True
        Me.T_TX.Location = New System.Drawing.Point(114, 70)
        Me.T_TX.Name = "T_TX"
        Me.T_TX.Size = New System.Drawing.Size(39, 17)
        Me.T_TX.TabIndex = 14
        Me.T_TX.TabStop = True
        Me.T_TX.Text = "TX"
        Me.T_TX.UseVisualStyleBackColor = True
        '
        'T_TXRX
        '
        Me.T_TXRX.AutoSize = True
        Me.T_TXRX.Location = New System.Drawing.Point(182, 70)
        Me.T_TXRX.Name = "T_TXRX"
        Me.T_TXRX.Size = New System.Drawing.Size(78, 17)
        Me.T_TXRX.TabIndex = 15
        Me.T_TXRX.TabStop = True
        Me.T_TXRX.Text = "TX and RX"
        Me.T_TXRX.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 150)
        Me.Controls.Add(Me.T_TXRX)
        Me.Controls.Add(Me.T_TX)
        Me.Controls.Add(Me.T_OFF)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T_freq)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "RS-UV3 CTCSS Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T_freq As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T_OFF As System.Windows.Forms.RadioButton
    Friend WithEvents T_TX As System.Windows.Forms.RadioButton
    Friend WithEvents T_TXRX As System.Windows.Forms.RadioButton
End Class

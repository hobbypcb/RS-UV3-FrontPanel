<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CW_mess = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CW_int = New System.Windows.Forms.TextBox
        Me.CW_speed = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CW_freq = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CW ID Message"
        '
        'CW_mess
        '
        Me.CW_mess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_mess.Location = New System.Drawing.Point(15, 29)
        Me.CW_mess.Name = "CW_mess"
        Me.CW_mess.Size = New System.Drawing.Size(250, 26)
        Me.CW_mess.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CW ID Interval (secs) 0 = OFF"
        '
        'CW_int
        '
        Me.CW_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_int.Location = New System.Drawing.Point(15, 88)
        Me.CW_int.Name = "CW_int"
        Me.CW_int.Size = New System.Drawing.Size(80, 26)
        Me.CW_int.TabIndex = 3
        '
        'CW_speed
        '
        Me.CW_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_speed.Location = New System.Drawing.Point(15, 146)
        Me.CW_speed.Name = "CW_speed"
        Me.CW_speed.Size = New System.Drawing.Size(80, 26)
        Me.CW_speed.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CW ID Speed  5-25 WPM"
        '
        'CW_freq
        '
        Me.CW_freq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_freq.Location = New System.Drawing.Point(15, 205)
        Me.CW_freq.Name = "CW_freq"
        Me.CW_freq.Size = New System.Drawing.Size(80, 26)
        Me.CW_freq.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CW ID Tone Freq  500 - 1300 Hz"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(103, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "SET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "SET/EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 292)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CW_freq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CW_speed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CW_int)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CW_mess)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "RS-UV3 CW ID Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CW_mess As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CW_int As System.Windows.Forms.TextBox
    Friend WithEvents CW_speed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CW_freq As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

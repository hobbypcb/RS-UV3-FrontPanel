<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Timeout = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Hang = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TO_mess = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BCN_Mess = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BCN_Time = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Timeout
        '
        Me.Timeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timeout.Location = New System.Drawing.Point(24, 91)
        Me.Timeout.Name = "Timeout"
        Me.Timeout.Size = New System.Drawing.Size(80, 26)
        Me.Timeout.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "TX Timeout Timer (sec) 0 - 600"
        '
        'Hang
        '
        Me.Hang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hang.Location = New System.Drawing.Point(24, 33)
        Me.Hang.Name = "Hang"
        Me.Hang.Size = New System.Drawing.Size(80, 26)
        Me.Hang.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TX Hangtime (msec) 0 - 5000"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(111, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "SET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "SET/EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TO_mess
        '
        Me.TO_mess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TO_mess.Location = New System.Drawing.Point(24, 149)
        Me.TO_mess.Name = "TO_mess"
        Me.TO_mess.Size = New System.Drawing.Size(80, 26)
        Me.TO_mess.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "TX Timeout Message (7 Char Max)"
        '
        'BCN_Mess
        '
        Me.BCN_Mess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCN_Mess.Location = New System.Drawing.Point(24, 267)
        Me.BCN_Mess.Name = "BCN_Mess"
        Me.BCN_Mess.Size = New System.Drawing.Size(80, 26)
        Me.BCN_Mess.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CW Beacon Message (25 Char Max)"
        '
        'BCN_Time
        '
        Me.BCN_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCN_Time.Location = New System.Drawing.Point(24, 209)
        Me.BCN_Time.Name = "BCN_Time"
        Me.BCN_Time.Size = New System.Drawing.Size(80, 26)
        Me.BCN_Time.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "CW Beacon (sec) 0 - 600"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 357)
        Me.Controls.Add(Me.BCN_Mess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BCN_Time)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TO_mess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Timeout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Hang)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "RS-UV3 Timer Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timeout As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Hang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TO_mess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BCN_Mess As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BCN_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

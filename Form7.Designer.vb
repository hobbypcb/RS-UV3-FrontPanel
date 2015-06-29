<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.FRQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.FRQ_S = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.H_SCALE = New System.Windows.Forms.Label
        Me.C_LOC = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FRQ
        '
        Me.FRQ.Location = New System.Drawing.Point(29, 271)
        Me.FRQ.Name = "FRQ"
        Me.FRQ.Size = New System.Drawing.Size(77, 20)
        Me.FRQ.TabIndex = 3
        Me.FRQ.Text = "146.610"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CENTER - MHz"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(30, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 200)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(198, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CLICK TO TUNE"
        Me.Label2.Visible = False
        '
        'FRQ_S
        '
        Me.FRQ_S.FormattingEnabled = True
        Me.FRQ_S.Items.AddRange(New Object() {"0.5", "1.0", "2.0"})
        Me.FRQ_S.Location = New System.Drawing.Point(147, 271)
        Me.FRQ_S.Name = "FRQ_S"
        Me.FRQ_S.Size = New System.Drawing.Size(81, 21)
        Me.FRQ_S.TabIndex = 14
        Me.FRQ_S.Text = "0.5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "SPAN - MHz"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "SWEEP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'H_SCALE
        '
        Me.H_SCALE.AutoSize = True
        Me.H_SCALE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_SCALE.Location = New System.Drawing.Point(12, 223)
        Me.H_SCALE.Name = "H_SCALE"
        Me.H_SCALE.Size = New System.Drawing.Size(532, 15)
        Me.H_SCALE.TabIndex = 18
        Me.H_SCALE.Text = "-0.25        -0.20        -0.15        -0.10       -0.50         0.0       +0.05 " & _
            "     +0.10      +0.15      +0.20      +0.25"
        '
        'C_LOC
        '
        Me.C_LOC.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.C_LOC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C_LOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_LOC.ForeColor = System.Drawing.Color.Lime
        Me.C_LOC.Location = New System.Drawing.Point(264, 272)
        Me.C_LOC.Name = "C_LOC"
        Me.C_LOC.Size = New System.Drawing.Size(121, 19)
        Me.C_LOC.TabIndex = 19
        Me.C_LOC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "POINTER FREQUENCY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C_LOC)
        Me.Controls.Add(Me.H_SCALE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FRQ_S)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FRQ)
        Me.Name = "Form7"
        Me.Text = "RS-UV3 Band Sweep"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FRQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FRQ_S As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents H_SCALE As System.Windows.Forms.Label
    Friend WithEvents C_LOC As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

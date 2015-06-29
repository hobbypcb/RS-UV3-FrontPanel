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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button15 = New System.Windows.Forms.Button
        Me.MEM3 = New System.Windows.Forms.Button
        Me.ToneFD = New System.Windows.Forms.Label
        Me.ToneSD = New System.Windows.Forms.Label
        Me.Button14 = New System.Windows.Forms.Button
        Me.LowP = New System.Windows.Forms.CheckBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.SideT = New System.Windows.Forms.CheckBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.VOL_ctrl = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.SQ_ctrl = New System.Windows.Forms.NumericUpDown
        Me.SS_bar = New System.Windows.Forms.Panel
        Me.SS_IND = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.MEM5 = New System.Windows.Forms.Button
        Me.MEM4 = New System.Windows.Forms.Button
        Me.MEM2 = New System.Windows.Forms.Button
        Me.MEM1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.VOL_ctrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQ_ctrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.MEM3)
        Me.Panel1.Controls.Add(Me.ToneFD)
        Me.Panel1.Controls.Add(Me.ToneSD)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.LowP)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.SideT)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.VOL_ctrl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SQ_ctrl)
        Me.Panel1.Controls.Add(Me.SS_bar)
        Me.Panel1.Controls.Add(Me.SS_IND)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MEM5)
        Me.Panel1.Controls.Add(Me.MEM4)
        Me.Panel1.Controls.Add(Me.MEM2)
        Me.Panel1.Controls.Add(Me.MEM1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(8, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 238)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(395, 209)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(60, 26)
        Me.Button15.TabIndex = 40
        Me.Button15.Text = "SCAN"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'MEM3
        '
        Me.MEM3.Location = New System.Drawing.Point(395, 106)
        Me.MEM3.Name = "MEM3"
        Me.MEM3.Size = New System.Drawing.Size(60, 26)
        Me.MEM3.TabIndex = 39
        Me.MEM3.Text = "3"
        Me.MEM3.UseVisualStyleBackColor = True
        '
        'ToneFD
        '
        Me.ToneFD.AutoSize = True
        Me.ToneFD.BackColor = System.Drawing.Color.DimGray
        Me.ToneFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToneFD.ForeColor = System.Drawing.Color.Lime
        Me.ToneFD.Location = New System.Drawing.Point(298, 26)
        Me.ToneFD.Name = "ToneFD"
        Me.ToneFD.Size = New System.Drawing.Size(39, 13)
        Me.ToneFD.TabIndex = 38
        Me.ToneFD.Text = "131.8"
        '
        'ToneSD
        '
        Me.ToneSD.AutoSize = True
        Me.ToneSD.BackColor = System.Drawing.Color.DimGray
        Me.ToneSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToneSD.ForeColor = System.Drawing.Color.Lime
        Me.ToneSD.Location = New System.Drawing.Point(298, 12)
        Me.ToneSD.Name = "ToneSD"
        Me.ToneSD.Size = New System.Drawing.Size(38, 13)
        Me.ToneSD.TabIndex = 37
        Me.ToneSD.Text = "TONE"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(263, 209)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(60, 26)
        Me.Button14.TabIndex = 36
        Me.Button14.Text = "SWEEP"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'LowP
        '
        Me.LowP.AutoSize = True
        Me.LowP.Location = New System.Drawing.Point(85, 213)
        Me.LowP.Name = "LowP"
        Me.LowP.Size = New System.Drawing.Size(79, 17)
        Me.LowP.TabIndex = 35
        Me.LowP.Text = "Low Power"
        Me.LowP.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(4, 205)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 30)
        Me.Button13.TabIndex = 34
        Me.Button13.Text = "B. LDR."
        Me.Button13.UseVisualStyleBackColor = True
        '
        'SideT
        '
        Me.SideT.AutoSize = True
        Me.SideT.Location = New System.Drawing.Point(166, 213)
        Me.SideT.Name = "SideT"
        Me.SideT.Size = New System.Drawing.Size(68, 17)
        Me.SideT.TabIndex = 33
        Me.SideT.Text = "Sidetone"
        Me.SideT.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(166, 166)
        Me.Button12.Margin = New System.Windows.Forms.Padding(1)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 30)
        Me.Button12.TabIndex = 32
        Me.Button12.Text = "Vlt/Tmp/FW"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(166, 130)
        Me.Button11.Margin = New System.Windows.Forms.Padding(1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 30)
        Me.Button11.TabIndex = 31
        Me.Button11.Text = "Set Default"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(85, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 30)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "DTMF"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "<SHIFT> + Click to store"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Memory Channels"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(395, 170)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 26)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "9"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(329, 170)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 26)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(263, 170)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 26)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "7"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(395, 138)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(60, 26)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "6"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(4, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 30)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "TIMERS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(4, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "CW Setup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(85, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Send CW ID"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Tone SQ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "SIGNAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "VOLUME"
        '
        'VOL_ctrl
        '
        Me.VOL_ctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VOL_ctrl.Location = New System.Drawing.Point(172, 57)
        Me.VOL_ctrl.Maximum = New Decimal(New Integer() {39, 0, 0, 0})
        Me.VOL_ctrl.Name = "VOL_ctrl"
        Me.VOL_ctrl.Size = New System.Drawing.Size(55, 26)
        Me.VOL_ctrl.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "SQUELCH"
        '
        'SQ_ctrl
        '
        Me.SQ_ctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SQ_ctrl.Location = New System.Drawing.Point(100, 57)
        Me.SQ_ctrl.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.SQ_ctrl.Name = "SQ_ctrl"
        Me.SQ_ctrl.Size = New System.Drawing.Size(55, 26)
        Me.SQ_ctrl.TabIndex = 15
        '
        'SS_bar
        '
        Me.SS_bar.BackColor = System.Drawing.Color.LimeGreen
        Me.SS_bar.Location = New System.Drawing.Point(351, 15)
        Me.SS_bar.Name = "SS_bar"
        Me.SS_bar.Size = New System.Drawing.Size(1, 16)
        Me.SS_bar.TabIndex = 5
        '
        'SS_IND
        '
        Me.SS_IND.BackColor = System.Drawing.Color.DimGray
        Me.SS_IND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SS_IND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS_IND.ForeColor = System.Drawing.Color.Red
        Me.SS_IND.Location = New System.Drawing.Point(349, 13)
        Me.SS_IND.Name = "SS_IND"
        Me.SS_IND.Size = New System.Drawing.Size(110, 20)
        Me.SS_IND.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Set Freq"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MEM5
        '
        Me.MEM5.Location = New System.Drawing.Point(329, 138)
        Me.MEM5.Name = "MEM5"
        Me.MEM5.Size = New System.Drawing.Size(60, 26)
        Me.MEM5.TabIndex = 12
        Me.MEM5.Text = "5"
        Me.MEM5.UseVisualStyleBackColor = True
        '
        'MEM4
        '
        Me.MEM4.Location = New System.Drawing.Point(263, 138)
        Me.MEM4.Name = "MEM4"
        Me.MEM4.Size = New System.Drawing.Size(60, 26)
        Me.MEM4.TabIndex = 11
        Me.MEM4.Text = "4"
        Me.MEM4.UseVisualStyleBackColor = True
        '
        'MEM2
        '
        Me.MEM2.Location = New System.Drawing.Point(329, 106)
        Me.MEM2.Name = "MEM2"
        Me.MEM2.Size = New System.Drawing.Size(60, 26)
        Me.MEM2.TabIndex = 9
        Me.MEM2.Text = "2"
        Me.MEM2.UseVisualStyleBackColor = True
        '
        'MEM1
        '
        Me.MEM1.Location = New System.Drawing.Point(263, 106)
        Me.MEM1.Name = "MEM1"
        Me.MEM1.Size = New System.Drawing.Size(60, 26)
        Me.MEM1.TabIndex = 8
        Me.MEM1.Text = "1"
        Me.MEM1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(4, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "RX:"
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 19200
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a Comm Port"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 248)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "RS-UV3 Control"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VOL_ctrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQ_ctrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SS_bar As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MEM1 As System.Windows.Forms.Button
    Friend WithEvents MEM5 As System.Windows.Forms.Button
    Friend WithEvents MEM4 As System.Windows.Forms.Button
    Friend WithEvents MEM2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SS_IND As System.Windows.Forms.Label
    Friend WithEvents SQ_ctrl As System.Windows.Forms.NumericUpDown
    Friend WithEvents VOL_ctrl As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SideT As System.Windows.Forms.CheckBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents LowP As System.Windows.Forms.CheckBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents ToneSD As System.Windows.Forms.Label
    Friend WithEvents ToneFD As System.Windows.Forms.Label
    Friend WithEvents MEM3 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button

End Class

Public Class Form1
    Public SSV As Int16
    Public Sc(10), Ls(10) As Boolean
    Public FRX, FTX As Single
    Public FR_flag, NS_flag As Short


    ' Form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        ToolTip1.SetToolTip(SS_IND, "Signal Strength")
        ToolTip1.SetToolTip(Button1, "Set RX and RX Frequency")
        ToolTip1.SetToolTip(Button2, "Set Up CTCSS encode and decode")
        ToolTip1.SetToolTip(Button3, "Send CW ID Now")
        ToolTip1.SetToolTip(Button4, "Set Up CD ID Parameters")
        ToolTip1.SetToolTip(Button5, "Set Up TX Time Out and CW ID Timers")
        ToolTip1.SetToolTip(Button6, "Send DTMF Tones")
        ToolTip1.SetToolTip(Button11, "Store Power-On Radio Settings")
        ToolTip1.SetToolTip(Button12, "Display Voltage and Temperature")
        ToolTip1.SetToolTip(SQ_ctrl, "Set Squelch: 0 = open, 9 = Mute")
        ToolTip1.SetToolTip(VOL_ctrl, "Set Volume Level")
        ToolTip1.SetToolTip(MEM1, "Recall Memory 1, <SHIFT> + Click to Store Memory 1")
        ToolTip1.SetToolTip(MEM2, "Recall Memory 2, <SHIFT> + Click to Store Memory 2")
        ToolTip1.SetToolTip(MEM3, "Recall Memory 3, <SHIFT> + Click to Store Memory 3")
        ToolTip1.SetToolTip(MEM4, "Recall Memory 4, <SHIFT> + Click to Store Memory 4")
        ToolTip1.SetToolTip(MEM5, "Recall Memory 5, <SHIFT> + Click to Store Memory 5")
        ToolTip1.SetToolTip(Button10, "Recall Memory 6, <SHIFT> + Click to Store Memory 6")
        ToolTip1.SetToolTip(Button9, "Recall Memory 7, <SHIFT> + Click to Store Memory 7")
        ToolTip1.SetToolTip(Button8, "Recall Memory 8, <SHIFT> + Click to Store Memory 8")
        ToolTip1.SetToolTip(Button7, "Recall Memory 9, <SHIFT> + Click to Store Memory 9")
        ToolTip1.SetToolTip(Button13, "Tells RS-UV3 to listen for Bootloader Connection")
        ToolTip1.SetToolTip(LowP, "Sets the RS-UV3 TX power to LOW when Checked")
        ToolTip1.SetToolTip(SideT, "CW and DTMF Tones are also heard in the Speaker")
        NS_flag = 0
        For k = 1 To 9 : Ls(k) = False : Sc(k) = True : Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SS_string As String
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.Open()
        Panel1.Visible = True
        Panel1.Enabled = True
        ComboBox1.Visible = False
        Label1.Visible = False
        Get_Freq()
        SerialPort1.Write("SD?" + Chr(13))
        Threading.Thread.Sleep(25)
        SS_string = SerialPort1.ReadExisting
        If Len(SS_string) > 6 Then
            If Mid(SS_string, 1, 7) = "SD:   1" Then SideT.Checked = True
        End If
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SS_string As String
        If FR_flag = 1 Then Get_Freq()
        SerialPort1.Write("SS" + Chr(13))
        Threading.Thread.Sleep(25)
        SS_string = SerialPort1.ReadExisting
        If Len(SS_string) > 8 Then
            If Mid(SS_string, 1, 6) = "SS: TX" Then
                SS_bar.Width = 0
                SS_IND.Text = "TX ON"
            Else
                SSV = Val(Microsoft.VisualBasic.Right(SS_string, 5))
                SS_bar.Width = SSV + 132
                SS_IND.Text = ""
            End If
        End If

        ToolTip1.SetToolTip(SS_IND, Format(SSV, "### dBm"))
        ToolTip1.SetToolTip(SS_bar, Format(SSV, "### dBm"))

    End Sub



    Public Sub Get_Freq()
        Dim FR_string As String
        Timer1.Enabled = False
        SerialPort1.Write("F?" + Chr(13))
        Threading.Thread.Sleep(60)
        FR_string = SerialPort1.ReadExisting
        FRX = Val(Mid(FR_string, 6, 7)) / 1000
        Label2.Text = Format(FRX, "RX: 000.000")
        Form2.TextBox1.Text = Format(FRX, "000.000")
        If NS_flag = 0 Then Form7.FRQ.Text = Format(FRX, "000.000")
        FTX = Val(Mid(FR_string, 20, 7)) / 1000
        Label2.Text += Format(FTX, "  TX: 000.000")
        Label2.Refresh()
        FR_flag = 0

        SerialPort1.Write("VU?" + Chr(13))
        Threading.Thread.Sleep(40)
        FR_string = SerialPort1.ReadExisting
        FR_string = Mid(FR_string, 4, Len(FR_string) - 4)

        VOL_ctrl.Value = Val(FR_string)
        VOL_ctrl.Refresh()

        SerialPort1.Write("SQ?" + Chr(13))
        Threading.Thread.Sleep(40)
        FR_string = SerialPort1.ReadExisting
        SQ_ctrl.Value = Val(Mid(FR_string, 3, Len(FR_string) - 3))
        SQ_ctrl.Refresh()
        SerialPort1.Write(Chr(13))
        Threading.Thread.Sleep(25)

        SerialPort1.Write("PW?" + Chr(13))
        Threading.Thread.Sleep(25)
        FR_string = SerialPort1.ReadExisting
        If Len(FR_string) > 6 Then
            If Mid(FR_string, 1, 6) = "PW: LO" Then
                LowP.Checked = True
            Else
                LowP.Checked = False
            End If

        End If
        SerialPort1.Write("TF?" + Chr(13))
        Threading.Thread.Sleep(25)
        FR_string = SerialPort1.ReadExisting
        Form3.T_freq.Text = Format(Val(FR_string) / 100, "#00.0")
        ToneFD.Text = Format(Val(FR_string) / 100, "#00.0")

        SerialPort1.Write("TM?" + Chr(13))
        Threading.Thread.Sleep(30)
        FR_string = SerialPort1.ReadExisting
        If Mid(FR_string, 5, 1) = "0" Then
            Form3.T_OFF.Checked = True : ToneSD.Text = "" : ToneFD.Text = ""
        End If
        If Mid(FR_string, 5, 1) = "1" Then
            Form3.T_TX.Checked = True : ToneSD.Text = "TONE"
        End If
        If Mid(FR_string, 5, 1) = "2" Then
            Form3.T_TXRX.Checked = True : ToneSD.Text = "T SQ."
        End If



        Timer1.Enabled = True

    End Sub
    Private Sub Set_Tone()
        Dim SS_string As String
        Timer1.Enabled = False

        Timer1.Enabled = True

    End Sub
    Private Sub MEM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM1.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 1?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST1" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC1" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()
        End If
        Timer1.Enabled = True

    End Sub

    Private Sub MEM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM2.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 2?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST2" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC2" + Chr(13))
            Threading.Thread.Sleep(40)
            Set_Tone()
            Get_Freq()

        End If
        Timer1.Enabled = True
    End Sub


    Private Sub MEM4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM4.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 4?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST4" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC4" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True

    End Sub

    Private Sub MEM5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM5.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 5?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST5" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC5" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    Private Sub SQ_ctrl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQ_ctrl.ValueChanged
        SerialPort1.Write(Format(SQ_ctrl.Value, "SQ0" + Chr(13)))
    End Sub

    Private Sub VOL_ctrl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOL_ctrl.ValueChanged
        SerialPort1.Write(Format(VOL_ctrl.Value, "VU00" + Chr(13)))
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SerialPort1.Write("ID" + Chr(13))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 6?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST6" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC6" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 7?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST7" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC7" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 8?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST8" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC8" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 9?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST9" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC9" + Chr(13))
            Threading.Thread.Sleep(40)
            Set_Tone()
            Get_Freq()

        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim Result As DialogResult


        Result = MessageBox.Show("Store Power-On Defaults?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            SerialPort1.Write("ST0" + Chr(13))
            Threading.Thread.Sleep(50)
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim VOLT, TEMP, FWV, status As String
        Timer1.Enabled = False

        SerialPort1.Write("VT" + Chr(13))
        Threading.Thread.Sleep(40)
        VOLT = SerialPort1.ReadExisting
        VOLT = Mid(VOLT, 4, Len(VOLT) - 4)

        SerialPort1.Write("TP" + Chr(13))
        Threading.Thread.Sleep(40)
        TEMP = SerialPort1.ReadExisting
        TEMP = Mid(TEMP, 4, Len(TEMP) - 4)

        SerialPort1.Write("FW" + Chr(13))
        Threading.Thread.Sleep(40)
        FWV = SerialPort1.ReadExisting
        FWV = Mid(FWV, 4, Len(FWV) - 4)

        Timer1.Enabled = True

        status = "VOLTS:" + VOLT + Chr(13) + Chr(10) + "TEMP:" + TEMP + Chr(13) + Chr(10) + "FIRMWARE:" + FWV

        MessageBox.Show(status, "RS_UV3 Status", MessageBoxButtons.OK)
    End Sub



    Private Sub SideT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideT.CheckedChanged
        If SideT.Checked Then SerialPort1.Write("SD1" + Chr(13))
        If Not SideT.Checked Then SerialPort1.Write("SD0" + Chr(13))
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim Result As DialogResult

        Result = MessageBox.Show("Listen for Bootloader and Exit?", "RS_UV3 Bootloader", MessageBoxButtons.YesNo)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            SerialPort1.Write(Chr(13))
            Threading.Thread.Sleep(25)
            SerialPort1.Write("BL" + Chr(13))
            Me.Close()
        End If

    End Sub

    Private Sub LowP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowP.CheckedChanged
        If LowP.Checked Then SerialPort1.Write("PW0" + Chr(13))
        If Not LowP.Checked Then SerialPort1.Write("PW1" + Chr(13))

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form7.Show()
    End Sub


    Private Sub MEM3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM3.Click
        Dim Result As DialogResult

        Timer1.Enabled = False
        If My.Computer.Keyboard.ShiftKeyDown Then
            Result = MessageBox.Show("Store Memory 3?", "RS_UV3 Memory", MessageBoxButtons.YesNo)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                SerialPort1.Write("ST3" + Chr(13))
                Threading.Thread.Sleep(50)
            End If
        Else
            SerialPort1.Write("RC3" + Chr(13))
            Threading.Thread.Sleep(40)
            Get_Freq()
            Set_Tone()

        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Form8.Show()
    End Sub
End Class

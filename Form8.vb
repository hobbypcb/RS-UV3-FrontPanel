Public Class Form8
    Public S_index As Int16



    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ss_str, ss As String
        Form1.Timer1.Enabled = False

        Form1.SerialPort1.Write("CP1" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR1.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF1.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF1.Text = "" : TM1.Text = ""
        If ss = "1" Then TM1.Text = "TONE"
        If ss = "2" Then TM1.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP2" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR2.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF2.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF2.Text = "" : TM2.Text = ""
        If ss = "1" Then TM2.Text = "TONE"
        If ss = "2" Then TM2.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP3" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR3.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF2.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF3.Text = "" : TM3.Text = ""
        If ss = "1" Then TM3.Text = "TONE"
        If ss = "2" Then TM3.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP4" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR4.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF4.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF4.Text = "" : TM4.Text = ""
        If ss = "1" Then TM4.Text = "TONE"
        If ss = "2" Then TM4.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP5" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR5.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF5.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF5.Text = "" : TM5.Text = ""
        If ss = "1" Then TM5.Text = "TONE"
        If ss = "2" Then TM5.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP6" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR6.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF6.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF6.Text = "" : TM6.Text = ""
        If ss = "1" Then TM6.Text = "TONE"
        If ss = "2" Then TM6.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP7" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR7.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF7.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF7.Text = "" : TM7.Text = ""
        If ss = "1" Then TM7.Text = "TONE"
        If ss = "2" Then TM7.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP8" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR8.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF8.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF8.Text = "" : TM8.Text = ""
        If ss = "1" Then TM8.Text = "TONE"
        If ss = "2" Then TM8.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.SerialPort1.Write("CP9" + Chr(13))
        Threading.Thread.Sleep(40)
        ss_str = ""
        For k = 1 To 8 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        FR9.Text = Format(Val(ss_str) / 1000, "000.000")
        For k = 1 To 10 : Form1.SerialPort1.ReadChar() : Next
        ss_str = ""
        For k = 1 To 5 : ss_str += Chr(Form1.SerialPort1.ReadChar()) : Next
        TF9.Text = Format(Val(ss_str) / 100, "#00.0")
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        ss = Chr(Form1.SerialPort1.ReadChar())
        If ss = "0" Then TF9.Text = "" : TM9.Text = ""
        If ss = "1" Then TM9.Text = "TONE"
        If ss = "2" Then TM9.Text = "T. SQ"
        Form1.SerialPort1.ReadExisting()

        Form1.Timer1.Enabled = True
        S_index = 0

        SC1.Checked = Form1.Sc(1)
        SC2.Checked = Form1.Sc(2)
        SC3.Checked = Form1.Sc(3)
        SC4.Checked = Form1.Sc(4)
        SC5.Checked = Form1.Sc(5)
        SC6.Checked = Form1.Sc(6)
        SC7.Checked = Form1.Sc(7)
        SC8.Checked = Form1.Sc(8)
        SC9.Checked = Form1.Sc(9)
        LS1.Checked = Form1.Ls(1)
        LS2.Checked = Form1.Ls(2)
        LS3.Checked = Form1.Ls(3)
        LS4.Checked = Form1.Ls(4)
        LS5.Checked = Form1.Ls(5)
        LS6.Checked = Form1.Ls(6)
        LS7.Checked = Form1.Ls(7)
        LS8.Checked = Form1.Ls(8)
        LS9.Checked = Form1.Ls(9)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "START SCAN" Then
            Button1.Text = "STOP SCAN"
            Form1.Timer1.Enabled = False
            Timer1.Enabled = True
        Else
            Button1.Text = "START SCAN"
            Timer1.Enabled = False
            Timer2.Enabled = False
            Form1.Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ss As String
        Dim WTI As Int16

        S_index += 1
        If S_index > 9 Then S_index = 1

        If S_index = 1 Then
            If AC9.BackColor = Color.Gray Then AC9.BackColor = Color.DimGray
            If SC1.Checked Then
                Form1.SerialPort1.Write("CC1" + Chr(13))
                If TM1.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC1.BackColor = Color.Lime
                    If LS1.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC1" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC1.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 2 Then
            If AC1.BackColor = Color.Gray Then AC1.BackColor = Color.DimGray
            If SC2.Checked Then
                Form1.SerialPort1.Write("CC2" + Chr(13))
                If TM2.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC2.BackColor = Color.Lime
                    If LS2.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC2" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC2.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 3 Then
            If AC2.BackColor = Color.Gray Then AC2.BackColor = Color.DimGray
            If SC3.Checked Then
                Form1.SerialPort1.Write("CC3" + Chr(13))
                If TM3.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC3.BackColor = Color.Lime
                    If LS3.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC3" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC3.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 4 Then
            If AC3.BackColor = Color.Gray Then AC3.BackColor = Color.DimGray
            If SC4.Checked Then
                Form1.SerialPort1.Write("CC4" + Chr(13))
                If TM4.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC4.BackColor = Color.Lime
                    If LS4.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC4" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC4.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 5 Then
            If AC4.BackColor = Color.Gray Then AC4.BackColor = Color.DimGray
            If SC5.Checked Then
                Form1.SerialPort1.Write("CC5" + Chr(13))
                If TM5.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC5.BackColor = Color.Lime
                    If LS5.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC5" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC5.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 6 Then
            If AC5.BackColor = Color.Gray Then AC5.BackColor = Color.DimGray
            If SC6.Checked Then
                Form1.SerialPort1.Write("CC6" + Chr(13))
                If TM6.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC6.BackColor = Color.Lime
                    If LS6.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC6" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC6.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 7 Then
            If AC6.BackColor = Color.Gray Then AC6.BackColor = Color.DimGray
            If SC7.Checked Then
                Form1.SerialPort1.Write("CC7" + Chr(13))
                If TM7.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC7.BackColor = Color.Lime
                    If LS7.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC7" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC7.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 8 Then
            If AC7.BackColor = Color.Gray Then AC7.BackColor = Color.DimGray
            If SC8.Checked Then
                Form1.SerialPort1.Write("CC8" + Chr(13))
                If TM8.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC8.BackColor = Color.Lime
                    If LS8.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC8" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC8.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If

        If S_index = 9 Then
            If AC8.BackColor = Color.Gray Then AC8.BackColor = Color.DimGray
            If SC9.Checked Then
                Form1.SerialPort1.Write("CC9" + Chr(13))
                If TM9.Text = "T. SQ" Then
                    WTI = 140
                    Timer1.Interval = 200
                Else
                    WTI = 70
                    Timer1.Interval = 100
                End If
                Threading.Thread.Sleep(WTI)
                ss = Form1.SerialPort1.ReadExisting()
                If Val(ss) = 1 Then
                    AC9.BackColor = Color.Lime
                    If LS9.Checked = True Then
                        Timer1.Enabled = False
                        Form1.SerialPort1.Write("RC9" + Chr(13))
                        Threading.Thread.Sleep(40)
                        Form1.Get_Freq()
                        Form1.Timer1.Enabled = False
                        Timer2.Enabled = True
                    End If
                Else
                    AC9.BackColor = Color.Gray
                End If
                Refresh()
            Else
                Timer1.Interval = 2
            End If
        End If


        If SLOW.Checked Then Timer1.Interval = 1000
    End Sub





    Private Sub SC1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC1.Click
        Form1.Sc(1) = SC1.Checked
        If LS1.Checked = True Then LS1.Checked = False
    End Sub
    Private Sub SC2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC2.Click
        Form1.Sc(2) = SC2.Checked
        If LS2.Checked = True Then LS2.Checked = False
    End Sub
    Private Sub SC3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC3.Click
        Form1.Sc(3) = SC3.Checked
        If LS3.Checked = True Then LS3.Checked = False
    End Sub
    Private Sub SC4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC4.Click
        Form1.Sc(4) = SC4.Checked
        If LS4.Checked = True Then LS4.Checked = False
    End Sub
    Private Sub SC5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC5.Click
        Form1.Sc(5) = SC5.Checked
        If LS5.Checked = True Then LS5.Checked = False
    End Sub
    Private Sub SC6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC6.Click
        Form1.Sc(6) = SC6.Checked
        If LS6.Checked = True Then LS6.Checked = False
    End Sub
    Private Sub SC7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC7.Click
        Form1.Sc(7) = SC7.Checked
        If LS7.Checked = True Then LS7.Checked = False
    End Sub
    Private Sub SC8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC8.Click
        Form1.Sc(8) = SC8.Checked
        If LS8.Checked = True Then LS8.Checked = False
    End Sub
    Private Sub SC9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SC9.Click
        Form1.Sc(9) = SC9.Checked
        If LS9.Checked = True Then LS9.Checked = False
    End Sub

    Private Sub LS1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS1.Click
        Form1.Ls(1) = LS1.Checked
        If SC1.Checked = False Then SC1.Checked = True
    End Sub
    Private Sub LS2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS2.Click
        Form1.Ls(2) = LS2.Checked
        If SC2.Checked = False Then SC2.Checked = True
    End Sub
    Private Sub LS3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS3.Click
        Form1.Ls(3) = LS3.Checked
        If SC3.Checked = False Then SC3.Checked = True
    End Sub
    Private Sub LS4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS4.Click
        Form1.Ls(4) = LS4.Checked
        If SC4.Checked = False Then SC4.Checked = True
    End Sub
    Private Sub LS5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS5.Click
        Form1.Ls(5) = LS5.Checked
        If SC5.Checked = False Then SC5.Checked = True
    End Sub
    Private Sub LS6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS6.Click
        Form1.Ls(6) = LS6.Checked
        If SC6.Checked = False Then SC6.Checked = True
    End Sub
    Private Sub LS7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS7.Click
        Form1.Ls(7) = LS7.Checked
        If SC7.Checked = False Then SC7.Checked = True
    End Sub
    Private Sub LS8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS8.Click
        Form1.Ls(8) = LS8.Checked
        If SC8.Checked = False Then SC8.Checked = True
    End Sub
    Private Sub LS9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LS9.Click
        Form1.Ls(9) = LS9.Checked
        If SC9.Checked = False Then SC9.Checked = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim s_data As String

        Form1.SerialPort1.Write("SO" + Chr(13))
        Threading.Thread.Sleep(40)
        s_data = Form1.SerialPort1.ReadExisting()

        If Mid(s_data, 5, 1) = 0 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub
End Class
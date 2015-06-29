Public Class Form4


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SS_string As String
        Dim SS_int As Int16

        Form1.SerialPort1.Write("CL?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 5, Len(SS_string) - 5)

        CW_mess.Text = SS_string

        Form1.SerialPort1.Write("IT?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = LTrim(Mid(SS_string, 4, Len(SS_string) - 4))
        SS_int = Val(SS_string)
        CW_int.Text = Format(SS_int, "###")

        Form1.SerialPort1.Write("CS?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = LTrim(Mid(SS_string, 4, Len(SS_string) - 4))
        SS_int = Val(SS_string)
        CW_speed.Text = Format(SS_int, "##")

        Form1.SerialPort1.Write("CF?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = LTrim(Mid(SS_string, 4, Len(SS_string) - 4))
        SS_int = Val(SS_string)
        CW_freq.Text = Format(SS_int, "####")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Form1.SerialPort1.Write("CL" + CW_mess.Text + Chr(13))

        Form1.SerialPort1.Write("IT" + Format(Val(CW_int.Text), "000") + Chr(13))

        Form1.SerialPort1.Write("CS" + Format(Val(CW_speed.Text), "00") + Chr(13))

        Form1.SerialPort1.Write("CF" + Format(Val(CW_freq.Text), "0000") + Chr(13))


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = CW_mess.Text

        Form1.SerialPort1.Write("CL" + CW_mess.Text + Chr(13))

        Form1.SerialPort1.Write("IT" + Format(Val(CW_int.Text), "000") + Chr(13))

        Form1.SerialPort1.Write("CS" + Format(Val(CW_speed.Text), "00") + Chr(13))

        Form1.SerialPort1.Write("CF" + Format(Val(CW_freq.Text), "0000") + Chr(13))

        Me.Close()
    End Sub

End Class
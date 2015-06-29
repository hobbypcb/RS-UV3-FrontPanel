Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SS_string As String
        Dim SS_int As Int16

        Form1.SerialPort1.Write("TG?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 5, Len(SS_string) - 5)
        TO_mess.Text = SS_string

        Form1.SerialPort1.Write("TO?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 3, Len(SS_string) - 3)
        SS_int = Val(SS_string)
        Timeout.Text = Format(SS_int, "##0")

        Form1.SerialPort1.Write("HT?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 3, Len(SS_string) - 3)
        SS_int = Val(SS_string)
        Hang.Text = Format(SS_int, "###0")

        Form1.SerialPort1.Write("BT?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 4, Len(SS_string) - 3)
        SS_int = Val(SS_string)
        BCN_Time.Text = Format(SS_int, "##0")

        Form1.SerialPort1.Write("BM?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 5, Len(SS_string) - 5)
        BCN_Mess.Text = SS_string

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.SerialPort1.Write("TG" + Mid(TO_mess.Text, 1, 7) + Chr(13))

        Form1.SerialPort1.Write("TO" + Format(Val(Timeout.Text), "000") + Chr(13))

        Form1.SerialPort1.Write("HT" + Format(Val(Hang.Text), "0000") + Chr(13))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.SerialPort1.Write("TG" + Mid(TO_mess.Text, 1, 7) + Chr(13))

        Form1.SerialPort1.Write("TO" + Format(Val(Timeout.Text), "000") + Chr(13))

        Form1.SerialPort1.Write("HT" + Format(Val(Hang.Text), "0000") + Chr(13))

        Form1.SerialPort1.Write("BT" + Format(Val(BCN_Time.Text), "000") + Chr(13))

        Form1.SerialPort1.Write("BM" + Mid(BCN_Mess.Text, 1, 25) + Chr(13))

        Me.Close()
    End Sub

End Class
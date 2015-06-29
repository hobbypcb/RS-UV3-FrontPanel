Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SS_string As String

        Form1.SerialPort1.Write("TF?" + Chr(13))
        Threading.Thread.Sleep(25)
        SS_string = Form1.SerialPort1.ReadExisting
        T_freq.Text = Format(Val(SS_string) / 100, "##0.0")

        Form1.SerialPort1.Write("TM?" + Chr(13))
        Threading.Thread.Sleep(30)
        SS_string = Form1.SerialPort1.ReadExisting
        If Mid(SS_string, 5, 1) = "0" Then T_OFF.Checked = True
        If Mid(SS_string, 5, 1) = "1" Then T_TX.Checked = True
        If Mid(SS_string, 5, 1) = "2" Then T_TXRX.Checked = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim T_data As Single

        T_data = Val(T_freq.Text) * 100
        Form1.SerialPort1.Write(Format(T_data, "TF00000") + Chr(13))
        Threading.Thread.Sleep(30)
        Form1.ToneFD.Text = Format(Val(T_data) / 100, "#00.0")

        If T_OFF.Checked Then T_data = 0
        If T_TX.Checked Then T_data = 1
        If T_TXRX.Checked Then T_data = 2
        If T_data = 0 Then
            Form1.ToneSD.Text = ""
            Form1.ToneFD.Text = ""
        End If
        If T_data = 1 Then Form1.ToneSD.Text = "TONE"
        If T_data = 2 Then Form1.ToneSD.Text = "T SQ."

        Form1.SerialPort1.Write(Format(T_data, "TM0") + Chr(13))


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim T_data As Single

        T_data = Val(T_freq.Text) * 100
        Form1.SerialPort1.Write(Format(T_data, "TF00000") + Chr(13))
        Threading.Thread.Sleep(30)


        If T_OFF.Checked Then T_data = 0
        If T_TX.Checked Then T_data = 1
        If T_TXRX.Checked Then T_data = 2
        Form1.SerialPort1.Write(Format(T_data, "TM0") + Chr(13))

        Me.Close()

    End Sub
End Class
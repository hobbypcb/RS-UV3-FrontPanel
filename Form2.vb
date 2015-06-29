Public Class Form2



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim freq As Single

        freq = Val(TextBox1.Text)
        freq *= 1000

        Form1.Timer1.Enabled = False
        If RXonly.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FR000000") + Chr(13))
        ElseIf TXonly.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FT000000") + Chr(13))
        ElseIf Simplex.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FS000000") + Chr(13))
        ElseIf RPT_U.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FU000000") + Chr(13))
        ElseIf RPT_D.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FD000000") + Chr(13))
        End If
        While (Form1.SerialPort1.BytesToWrite > 0) : End While
        Form1.FR_flag = 1
        Form1.Timer1.Enabled = True
        Me.Close()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim freq As Single

        freq = Val(TextBox1.Text)
        freq *= 1000

        Form1.Timer1.Enabled = False
        If RXonly.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FR000000") + Chr(13))
        ElseIf TXonly.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FT000000") + Chr(13))
        ElseIf Simplex.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FS000000") + Chr(13))
        ElseIf RPT_U.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FU000000") + Chr(13))
        ElseIf RPT_D.Checked = True Then
            Form1.SerialPort1.Write(Format(freq, "FD000000") + Chr(13))
        End If
        While (Form1.SerialPort1.BytesToWrite > 0) : End While
        Form1.FR_flag = 1
        Form1.Timer1.Enabled = True
    End Sub
End Class
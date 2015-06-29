Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DTMF.Text += "1"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DTMF.Text += "2"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DTMF.Text += "3"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DTMF.Text += "A"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        DTMF.Text += "4"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DTMF.Text += "5"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        DTMF.Text += "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DTMF.Text += "B"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        DTMF.Text += "7"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        DTMF.Text += "8"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        DTMF.Text += "9"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        DTMF.Text += "C"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        DTMF.Text += "*"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        DTMF.Text += "0"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        DTMF.Text += "#"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        DTMF.Text += "D"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.SerialPort1.Write("DS" + DTMF.Text + Chr(13))
        Threading.Thread.Sleep(300)

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        DTMF.Text = ""
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If Len(DTMF.Text) > 0 Then DTMF.Text = Mid(DTMF.Text, 1, Len(DTMF.Text) - 1)
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SS_string As String
        Dim SS_int As Int16

        Form1.SerialPort1.Write("DD?" + Chr(13))
        Threading.Thread.Sleep(50)
        SS_string = Form1.SerialPort1.ReadExisting
        SS_string = Mid(SS_string, 4, Len(SS_string) - 4)
        SS_int = Val(SS_string)
        DUR.Value = SS_int
        Label1.Text = "Duration: " + Format(SS_int, "###0")

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim SS_string As String
        Dim SS_int As Int16

        If DUR.Visible = False Then
            DUR.Visible = True
            Label1.Text = "ENTER"
        Else
            DUR.Visible = False
            Form1.SerialPort1.Write("DD" + Format(DUR.Value, "0000") + Chr(13))

            Form1.SerialPort1.Write("DD?" + Chr(13))
            Threading.Thread.Sleep(50)
            SS_string = Form1.SerialPort1.ReadExisting
            SS_string = Mid(SS_string, 4, Len(SS_string) - 4)
            SS_int = Val(SS_string)
            Label1.Text = "Duration: " + Format(SS_int, "###0")
        End If

    End Sub






End Class
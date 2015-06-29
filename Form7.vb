
Public Class Form7

    Private Sub Form7_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.NS_flag = 0


    End Sub



    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.NS_flag = 1


        Panel1.Visible = True
        Scan_Grid()

        Refresh()



    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Dim freq As Single

        freq = Val(C_LOC.Text)
        freq *= 1000

        Form1.SerialPort1.Write(Format(freq, "FS000000") + Chr(13))
        While (Form1.SerialPort1.BytesToWrite > 0) : End While
        Form1.FR_flag = 1

    End Sub

    Private Sub Panel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter
        Label2.Visible = True
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        C_LOC.Text = ""
        Label2.Visible = False
        Scan_Grid()

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        Dim freq, f_step, c_freq As Int32

        freq = Val(FRQ.Text) * 1000
        f_step = (e.X - 250) * Val(FRQ_S.Text) * 2


        c_freq = freq + f_step
        c_freq = Int(c_freq / 5) * 5
        C_LOC.Text = Format(c_freq / 1000, "000.000")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel1.Visible = False
        Refresh()
        Panel1.Visible = True

        Dim freq, f_step, x, y, l_x, l_y As Int32

        Dim s_data As String
        Dim g As Graphics
        ' Sets g to a Graphics object representing the drawing surface of the
        ' control or form g is a member of.
        g = Panel1.CreateGraphics

        Form1.SerialPort1.Write("SQ9" + Chr(13))
        Threading.Thread.Sleep(25)
        Form1.SerialPort1.Write("VU00" + Chr(13))
        Threading.Thread.Sleep(25)

        Dim myPen As New Pen(Color.Lime)
        myPen.Width = 2
        Dim wPen As New Pen(Color.Gray)
        wPen.Width = 1

        Scan_Grid()

        '        For k = 50 To 450 Step 50
        '        g.DrawLine(wPen, k, 0, k, 200)
        '       Next

        '      For k = 20 To 180 Step 20
        'g.DrawLine(wPen, 0, k, 500, k)
        'Next

        freq = Val(FRQ.Text) * 1000
        If FRQ_S.Text = "0.5" Then f_step = 5
        If FRQ_S.Text = "1.0" Then f_step = 10
        If FRQ_S.Text = "2.0" Then f_step = 20
        freq = freq - f_step * 50

        Form1.Timer1.Enabled = False
        Form1.SerialPort1.Write("FM" + Format(freq, "000000") + Chr(13))
        Threading.Thread.Sleep(85)
        s_data = Form1.SerialPort1.ReadExisting


        l_x = 1 : l_y = 200 - 2 * (135 + Val(s_data))

        For k = 5 To 500 Step 5
            freq = freq + f_step
            Form1.SerialPort1.Write("FM" + Format(freq, "000000") + Chr(13))
            Threading.Thread.Sleep(85)
            s_data = Form1.SerialPort1.ReadExisting

            x = k
            y = 200 - 2 * (135 + Val(s_data))
            g.DrawLine(myPen, l_x, l_y, x, y)

            l_x = x : l_y = y

        Next
        Form1.SerialPort1.Write(Format(Form1.SQ_ctrl.Value, "SQ0" + Chr(13)))
        Threading.Thread.Sleep(25)
        Form1.SerialPort1.Write(Format(Form1.VOL_ctrl.Value, "VU00" + Chr(13)))
        Form1.Timer1.Enabled = True

    End Sub
    Private Sub Scan_Grid()
        Dim g As Graphics
        ' Sets g to a Graphics object representing the drawing surface of the
        ' control or form g is a member of.
        g = Panel1.CreateGraphics

        Dim wPen As New Pen(Color.Gray)
        wPen.Width = 1


        For k = 50 To 450 Step 50
            g.DrawLine(wPen, k, 0, k, 200)
        Next

        For k = 20 To 180 Step 20
            g.DrawLine(wPen, 0, k, 500, k)
        Next

    End Sub
    Private Sub FRQ_S_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRQ_S.SelectedIndexChanged
        If FRQ_S.Text = "0.5" Then H_SCALE.Text = "-0.25        -0.20        -0.15        -0.10       -0.50         0.0       +0.05      +0.10      +0.15      +0.20      +0.25"
        If FRQ_S.Text = "1.0" Then H_SCALE.Text = "-0.50        -0.40        -0.30        -0.20       -0.10         0.0       +0.10      +0.20      +0.30      +0.40      +0.50"
        If FRQ_S.Text = "2.0" Then H_SCALE.Text = "-1.00        -0.80        -0.60        -0.40       -0.20         0.0       +0.20      +0.40      +0.60      +0.80      +1.00"

        Panel1.Visible = False
        Refresh()
        Panel1.Visible = True
        Scan_Grid()


    End Sub

    Private Sub FRQ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRQ.TextChanged
        Panel1.Visible = False
        Refresh()
        Panel1.Visible = True
        Scan_Grid()
    End Sub

    Private Sub Form7_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Panel1.Visible = True
        Scan_Grid()

    End Sub
End Class
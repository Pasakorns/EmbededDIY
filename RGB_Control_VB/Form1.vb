

Imports System.Net
Imports System.Net.Sockets
Imports Arduino_LED

Public Class Form1

    Dim color As MyRGB = New MyRGB
    Dim client As TcpClient = New TcpClient()
    Dim cmd() As Byte = {0, 0, 0, 255}
    Dim steam As NetworkStream

    Private Sub pnColor_Click(sender As Object, e As EventArgs) Handles pnColor.Click

        Dim colorResult As DialogResult = ColorDialog1.ShowDialog()
        If (colorResult = DialogResult.OK) Then
            color.setColor(ColorDialog1.Color)
            colorUpdate(color.rgb)

        End If

    End Sub

    Private Sub trbRGB_Scroll(sender As Object, e As EventArgs) Handles trbRed.Scroll, trbGreen.Scroll, trbBlue.Scroll
        color.setRED(trbRed.Value)
        color.setGreen(trbGreen.Value)
        color.setBLUE(trbBlue.Value)
        colorUpdate(color.rgb)
    End Sub

    Private Sub txbRGB_TextChanged(sender As Object, e As EventArgs) Handles txbRed.TextChanged, txbGrn.TextChanged, txbBlu.TextChanged

        If (txbRed.Text = "" Or txbGrn.Text = "" Or txbBlu.Text = "") Then
            If txbRed.Text = "" Then
                txbRed.Text = "0"
            End If
            If txbGrn.Text = "" Then
                txbGrn.Text = "0"
            End If
            If txbBlu.Text = "" Then
                txbBlu.Text = "0"
            End If
        ElseIf (Convert.ToInt32(txbRed.Text) > 255 Or
                Convert.ToInt32(txbGrn.Text) > 255 Or
                Convert.ToInt32(txbBlu.Text) > 255) Then
            If Convert.ToInt32(txbRed.Text) > 255 Then
                txbRed.Text = "255"
            End If
            If Convert.ToInt32(txbGrn.Text) > 255 Then
                txbGrn.Text = "255"
            End If
            If Convert.ToInt32(txbBlu.Text) > 255 Then
                txbBlu.Text = "255"
            End If
        End If

        color.setRED(Convert.ToInt32(txbRed.Text))
        color.setGreen(Convert.ToInt32(txbGrn.Text))
        color.setBLUE(Convert.ToInt32(txbBlu.Text))
        colorUpdate(color.rgb)

    End Sub

    Private Sub colorUpdate(rgb As Color)

        pnColor.BackColor = rgb

        trbRed.Value = rgb.R
        trbGreen.Value = rgb.G
        trbBlue.Value = rgb.B

        txbRed.Text = rgb.R
        txbGrn.Text = rgb.G
        txbBlu.Text = rgb.B

    End Sub

    Private Sub trbPow_Scroll(sender As Object, e As EventArgs) Handles trbPow.Scroll
        color.LEDPower = trbPow.Value
        txbPow.Text = trbPow.Value
    End Sub

    Private Sub txbPow_TextChanged(sender As Object, e As EventArgs) Handles txbPow.TextChanged

        If (txbPow.Text = "") Then
            txbPow.Text = "0"
        ElseIf (Convert.ToInt32(txbPow.Text) > 255) Then
            txbPow.Text = "255"
        End If
        color.LEDPower = Convert.ToInt32(txbPow.Text)
        trbPow.Value = color.LEDPower

    End Sub

    Private Sub rdbSerial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSerial.CheckedChanged
        gbSerial.Enabled = True
        cmbSerialPortNo.Enabled = True
        cmbSerialBaundRate.Enabled = True
        btnSerialConnect.Enabled = False
        btnSerialDiscon.Enabled = False

        cmbSerialPortNo.Items.Clear()
        Dim ports() As String = IO.Ports.SerialPort.GetPortNames
        cmbSerialPortNo.Items.AddRange(ports)

        gbTCP.Enabled = False
        If (client.Connected) Then
            client.Close()
        End If
        'disconnect TCP
    End Sub

    Private Sub SerialSetting_TextChanged(sender As Object, e As EventArgs) Handles cmbSerialPortNo.SelectedValueChanged, cmbSerialBaundRate.SelectedValueChanged
        If (cmbSerialPortNo.Text <> "" And cmbSerialBaundRate.Text <> "") Then
            SerialPort1.PortName = cmbSerialPortNo.Text
            SerialPort1.BaudRate = Convert.ToInt32(cmbSerialBaundRate.Text)
            btnSerialConnect.Enabled = True
        End If
    End Sub

    Private Sub btnSerialConnect_Click(sender As Object, e As EventArgs) Handles btnSerialConnect.Click
        Try
            SerialPort1.Open()
            btnSerialDiscon.Enabled = SerialPort1.IsOpen
            cmbSerialPortNo.Enabled = False
            cmbSerialBaundRate.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Can't open port")
        End Try
    End Sub

    Private Sub btnSerialDiscon_Click(sender As Object, e As EventArgs) Handles btnSerialDiscon.Click
        SerialPort1.Close()
        btnSerialConnect.Enabled = False
        btnSerialDiscon.Enabled = False
        cmbSerialPortNo.Enabled = True
        cmbSerialBaundRate.Enabled = True
    End Sub

    Private Sub rdbTCP_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTCP.CheckedChanged
        gbTCP.Enabled = True
        txbTcpIpAdd.Enabled = True
        txbTcpPortNo.Enabled = True
        btnSerialConnect.Enabled = False
        btnSerialDiscon.Enabled = False

        gbSerial.Enabled = False
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub txbTcpIpAdd_TextChanged(sender As Object, e As EventArgs) Handles txbTcpIpAdd.TextChanged

        Dim ip As IPAddress = IPAddress.IPv6Loopback
        If (IPAddress.TryParse(txbTcpIpAdd.Text, address:=ip)) Then
            btnTcpConnect.Enabled = True
        Else
            btnTcpConnect.Enabled = False
        End If

    End Sub

    Private Sub btnTcpConnect_Click(sender As Object, e As EventArgs) Handles btnTcpConnect.Click

        Try
            client.Connect(txbTcpIpAdd.Text, Convert.ToInt32(txbTcpPortNo.Text))
            steam = client.GetStream()
            btnTcpDiscon.Enabled = True
            txbTcpIpAdd.Enabled = False
            txbTcpPortNo.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Connection time out")
        End Try


    End Sub

    Private Sub btnTcpDiscon_Click(sender As Object, e As EventArgs) Handles btnTcpDiscon.Click

        client.Close()

        txbTcpIpAdd.Enabled = True
        txbTcpPortNo.Enabled = True
        btnTcpConnect.Enabled = False

    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        cmd(0) = Convert.ToByte(color.rgb.R)
        cmd(1) = Convert.ToByte(color.rgb.G)
        cmd(2) = Convert.ToByte(color.rgb.B)
        cmd(3) = Convert.ToByte(color.LEDPower)

        If (SerialPort1.IsOpen) Then
            SerialPort1.Write(cmd, 0, 4)
        ElseIf (client.Connected) Then
            steam.Write(cmd, 0, 4)
        End If

    End Sub
End Class

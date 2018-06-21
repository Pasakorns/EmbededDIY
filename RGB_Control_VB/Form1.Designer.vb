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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbPow = New System.Windows.Forms.TextBox()
        Me.trbPow = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbBlu = New System.Windows.Forms.TextBox()
        Me.trbBlue = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbGrn = New System.Windows.Forms.TextBox()
        Me.trbGreen = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.txbRed = New System.Windows.Forms.TextBox()
        Me.trbRed = New System.Windows.Forms.TrackBar()
        Me.pnColor = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbTCP = New System.Windows.Forms.RadioButton()
        Me.rdbSerial = New System.Windows.Forms.RadioButton()
        Me.gbTCP = New System.Windows.Forms.GroupBox()
        Me.btnTcpDiscon = New System.Windows.Forms.Button()
        Me.btnTcpConnect = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbTcpPortNo = New System.Windows.Forms.TextBox()
        Me.txbTcpIpAdd = New System.Windows.Forms.TextBox()
        Me.gbSerial = New System.Windows.Forms.GroupBox()
        Me.btnSerialDiscon = New System.Windows.Forms.Button()
        Me.btnSerialConnect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSerialBaundRate = New System.Windows.Forms.ComboBox()
        Me.cmbSerialPortNo = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trbPow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbTCP.SuspendLayout()
        Me.gbSerial.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txbPow)
        Me.GroupBox1.Controls.Add(Me.trbPow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txbBlu)
        Me.GroupBox1.Controls.Add(Me.trbBlue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txbGrn)
        Me.GroupBox1.Controls.Add(Me.trbGreen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnColor)
        Me.GroupBox1.Controls.Add(Me.txbRed)
        Me.GroupBox1.Controls.Add(Me.trbRed)
        Me.GroupBox1.Controls.Add(Me.pnColor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB control"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Power"
        '
        'txbPow
        '
        Me.txbPow.Location = New System.Drawing.Point(224, 260)
        Me.txbPow.Name = "txbPow"
        Me.txbPow.Size = New System.Drawing.Size(43, 20)
        Me.txbPow.TabIndex = 15
        Me.txbPow.Text = "255"
        Me.txbPow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trbPow
        '
        Me.trbPow.Location = New System.Drawing.Point(57, 261)
        Me.trbPow.Maximum = 255
        Me.trbPow.Name = "trbPow"
        Me.trbPow.Size = New System.Drawing.Size(148, 45)
        Me.trbPow.TabIndex = 14
        Me.trbPow.TickFrequency = 64
        Me.trbPow.Value = 255
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "B"
        '
        'txbBlu
        '
        Me.txbBlu.Location = New System.Drawing.Point(224, 209)
        Me.txbBlu.Name = "txbBlu"
        Me.txbBlu.Size = New System.Drawing.Size(43, 20)
        Me.txbBlu.TabIndex = 12
        Me.txbBlu.Text = "0"
        Me.txbBlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trbBlue
        '
        Me.trbBlue.Location = New System.Drawing.Point(57, 210)
        Me.trbBlue.Maximum = 255
        Me.trbBlue.Name = "trbBlue"
        Me.trbBlue.Size = New System.Drawing.Size(148, 45)
        Me.trbBlue.TabIndex = 11
        Me.trbBlue.TickFrequency = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "G"
        '
        'txbGrn
        '
        Me.txbGrn.Location = New System.Drawing.Point(224, 172)
        Me.txbGrn.Name = "txbGrn"
        Me.txbGrn.Size = New System.Drawing.Size(43, 20)
        Me.txbGrn.TabIndex = 9
        Me.txbGrn.Text = "0"
        Me.txbGrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trbGreen
        '
        Me.trbGreen.Location = New System.Drawing.Point(57, 173)
        Me.trbGreen.Maximum = 255
        Me.trbGreen.Name = "trbGreen"
        Me.trbGreen.Size = New System.Drawing.Size(148, 45)
        Me.trbGreen.TabIndex = 8
        Me.trbGreen.TickFrequency = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "R"
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(96, 317)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(92, 39)
        Me.btnColor.TabIndex = 6
        Me.btnColor.Text = "Update color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'txbRed
        '
        Me.txbRed.Location = New System.Drawing.Point(224, 134)
        Me.txbRed.Name = "txbRed"
        Me.txbRed.Size = New System.Drawing.Size(43, 20)
        Me.txbRed.TabIndex = 5
        Me.txbRed.Text = "0"
        Me.txbRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trbRed
        '
        Me.trbRed.Location = New System.Drawing.Point(57, 135)
        Me.trbRed.Maximum = 255
        Me.trbRed.Name = "trbRed"
        Me.trbRed.Size = New System.Drawing.Size(148, 45)
        Me.trbRed.TabIndex = 1
        Me.trbRed.TickFrequency = 64
        '
        'pnColor
        '
        Me.pnColor.BackColor = System.Drawing.Color.Black
        Me.pnColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnColor.Location = New System.Drawing.Point(75, 38)
        Me.pnColor.Name = "pnColor"
        Me.pnColor.Size = New System.Drawing.Size(131, 61)
        Me.pnColor.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbTCP)
        Me.GroupBox2.Controls.Add(Me.rdbSerial)
        Me.GroupBox2.Controls.Add(Me.gbTCP)
        Me.GroupBox2.Controls.Add(Me.gbSerial)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 380)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Communication"
        '
        'rdbTCP
        '
        Me.rdbTCP.AutoSize = True
        Me.rdbTCP.Location = New System.Drawing.Point(91, 25)
        Me.rdbTCP.Name = "rdbTCP"
        Me.rdbTCP.Size = New System.Drawing.Size(61, 17)
        Me.rdbTCP.TabIndex = 3
        Me.rdbTCP.TabStop = True
        Me.rdbTCP.Text = "TCP/IP"
        Me.rdbTCP.UseVisualStyleBackColor = True
        '
        'rdbSerial
        '
        Me.rdbSerial.AutoSize = True
        Me.rdbSerial.Location = New System.Drawing.Point(25, 25)
        Me.rdbSerial.Name = "rdbSerial"
        Me.rdbSerial.Size = New System.Drawing.Size(51, 17)
        Me.rdbSerial.TabIndex = 2
        Me.rdbSerial.TabStop = True
        Me.rdbSerial.Text = "Serial"
        Me.rdbSerial.UseVisualStyleBackColor = True
        '
        'gbTCP
        '
        Me.gbTCP.Controls.Add(Me.btnTcpDiscon)
        Me.gbTCP.Controls.Add(Me.btnTcpConnect)
        Me.gbTCP.Controls.Add(Me.Label8)
        Me.gbTCP.Controls.Add(Me.Label7)
        Me.gbTCP.Controls.Add(Me.txbTcpPortNo)
        Me.gbTCP.Controls.Add(Me.txbTcpIpAdd)
        Me.gbTCP.Enabled = False
        Me.gbTCP.Location = New System.Drawing.Point(14, 216)
        Me.gbTCP.Name = "gbTCP"
        Me.gbTCP.Size = New System.Drawing.Size(261, 153)
        Me.gbTCP.TabIndex = 1
        Me.gbTCP.TabStop = False
        Me.gbTCP.Text = "TCP/IP"
        '
        'btnTcpDiscon
        '
        Me.btnTcpDiscon.Enabled = False
        Me.btnTcpDiscon.Location = New System.Drawing.Point(164, 101)
        Me.btnTcpDiscon.Name = "btnTcpDiscon"
        Me.btnTcpDiscon.Size = New System.Drawing.Size(75, 23)
        Me.btnTcpDiscon.TabIndex = 9
        Me.btnTcpDiscon.Text = "Disconnect"
        Me.btnTcpDiscon.UseVisualStyleBackColor = True
        '
        'btnTcpConnect
        '
        Me.btnTcpConnect.Enabled = False
        Me.btnTcpConnect.Location = New System.Drawing.Point(164, 49)
        Me.btnTcpConnect.Name = "btnTcpConnect"
        Me.btnTcpConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnTcpConnect.TabIndex = 8
        Me.btnTcpConnect.Text = "Connect"
        Me.btnTcpConnect.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Port no."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "IP address"
        '
        'txbTcpPortNo
        '
        Me.txbTcpPortNo.Location = New System.Drawing.Point(23, 104)
        Me.txbTcpPortNo.Name = "txbTcpPortNo"
        Me.txbTcpPortNo.Size = New System.Drawing.Size(59, 20)
        Me.txbTcpPortNo.TabIndex = 1
        Me.txbTcpPortNo.Text = "8000"
        '
        'txbTcpIpAdd
        '
        Me.txbTcpIpAdd.Location = New System.Drawing.Point(23, 49)
        Me.txbTcpIpAdd.Name = "txbTcpIpAdd"
        Me.txbTcpIpAdd.Size = New System.Drawing.Size(100, 20)
        Me.txbTcpIpAdd.TabIndex = 0
        Me.txbTcpIpAdd.Text = "192.168.6.1"
        '
        'gbSerial
        '
        Me.gbSerial.Controls.Add(Me.btnSerialDiscon)
        Me.gbSerial.Controls.Add(Me.btnSerialConnect)
        Me.gbSerial.Controls.Add(Me.Label6)
        Me.gbSerial.Controls.Add(Me.Label5)
        Me.gbSerial.Controls.Add(Me.cmbSerialBaundRate)
        Me.gbSerial.Controls.Add(Me.cmbSerialPortNo)
        Me.gbSerial.Enabled = False
        Me.gbSerial.Location = New System.Drawing.Point(14, 56)
        Me.gbSerial.Name = "gbSerial"
        Me.gbSerial.Size = New System.Drawing.Size(261, 145)
        Me.gbSerial.TabIndex = 0
        Me.gbSerial.TabStop = False
        Me.gbSerial.Text = "Serial"
        '
        'btnSerialDiscon
        '
        Me.btnSerialDiscon.Enabled = False
        Me.btnSerialDiscon.Location = New System.Drawing.Point(164, 101)
        Me.btnSerialDiscon.Name = "btnSerialDiscon"
        Me.btnSerialDiscon.Size = New System.Drawing.Size(75, 23)
        Me.btnSerialDiscon.TabIndex = 5
        Me.btnSerialDiscon.Text = "Disconnect"
        Me.btnSerialDiscon.UseVisualStyleBackColor = True
        '
        'btnSerialConnect
        '
        Me.btnSerialConnect.Enabled = False
        Me.btnSerialConnect.Location = New System.Drawing.Point(164, 44)
        Me.btnSerialConnect.Name = "btnSerialConnect"
        Me.btnSerialConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnSerialConnect.TabIndex = 4
        Me.btnSerialConnect.Text = "Connect"
        Me.btnSerialConnect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Baund rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Port name"
        '
        'cmbSerialBaundRate
        '
        Me.cmbSerialBaundRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSerialBaundRate.FormattingEnabled = True
        Me.cmbSerialBaundRate.Items.AddRange(New Object() {"9600", "115200"})
        Me.cmbSerialBaundRate.Location = New System.Drawing.Point(23, 103)
        Me.cmbSerialBaundRate.Name = "cmbSerialBaundRate"
        Me.cmbSerialBaundRate.Size = New System.Drawing.Size(100, 21)
        Me.cmbSerialBaundRate.TabIndex = 1
        '
        'cmbSerialPortNo
        '
        Me.cmbSerialPortNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSerialPortNo.FormattingEnabled = True
        Me.cmbSerialPortNo.Location = New System.Drawing.Point(23, 46)
        Me.cmbSerialPortNo.Name = "cmbSerialPortNo"
        Me.cmbSerialPortNo.Size = New System.Drawing.Size(100, 21)
        Me.cmbSerialPortNo.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "LED control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trbPow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbTCP.ResumeLayout(False)
        Me.gbTCP.PerformLayout()
        Me.gbSerial.ResumeLayout(False)
        Me.gbSerial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents trbRed As TrackBar
    Friend WithEvents pnColor As Panel
    Friend WithEvents btnColor As Button
    Friend WithEvents txbRed As TextBox
    Friend WithEvents gbTCP As GroupBox
    Friend WithEvents gbSerial As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbTCP As RadioButton
    Friend WithEvents rdbSerial As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txbBlu As TextBox
    Friend WithEvents trbBlue As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents txbGrn As TextBox
    Friend WithEvents trbGreen As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents txbPow As TextBox
    Friend WithEvents trbPow As TrackBar
    Friend WithEvents btnSerialDiscon As Button
    Friend WithEvents btnSerialConnect As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSerialBaundRate As ComboBox
    Friend WithEvents cmbSerialPortNo As ComboBox
    Friend WithEvents btnTcpDiscon As Button
    Friend WithEvents btnTcpConnect As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbTcpPortNo As TextBox
    Friend WithEvents txbTcpIpAdd As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class

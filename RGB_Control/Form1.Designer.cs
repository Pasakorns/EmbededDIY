namespace RGB_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnUpdateColor = new System.Windows.Forms.Button();
            this.lbPower = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPower = new System.Windows.Forms.TextBox();
            this.txbBlue = new System.Windows.Forms.TextBox();
            this.txbGreen = new System.Windows.Forms.TextBox();
            this.txbRed = new System.Windows.Forms.TextBox();
            this.tbPower = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.gbCommu = new System.Windows.Forms.GroupBox();
            this.gbTCP = new System.Windows.Forms.GroupBox();
            this.btnTCPdiscon = new System.Windows.Forms.Button();
            this.btnTCPConnect = new System.Windows.Forms.Button();
            this.txbPortNo = new System.Windows.Forms.TextBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSerial = new System.Windows.Forms.GroupBox();
            this.btnSerialDiscon = new System.Windows.Forms.Button();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.rdbTCP = new System.Windows.Forms.RadioButton();
            this.rdbSerial = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            this.gbCommu.SuspendLayout();
            this.gbTCP.SuspendLayout();
            this.gbSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnUpdateColor);
            this.gbControl.Controls.Add(this.lbPower);
            this.gbControl.Controls.Add(this.lbBlue);
            this.gbControl.Controls.Add(this.lbGreen);
            this.gbControl.Controls.Add(this.lbRed);
            this.gbControl.Controls.Add(this.panel1);
            this.gbControl.Controls.Add(this.txbPower);
            this.gbControl.Controls.Add(this.txbBlue);
            this.gbControl.Controls.Add(this.txbGreen);
            this.gbControl.Controls.Add(this.txbRed);
            this.gbControl.Controls.Add(this.tbPower);
            this.gbControl.Controls.Add(this.tbBlue);
            this.gbControl.Controls.Add(this.tbGreen);
            this.gbControl.Controls.Add(this.tbRed);
            this.gbControl.Location = new System.Drawing.Point(22, 35);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(252, 383);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "RGB control";
            // 
            // btnUpdateColor
            // 
            this.btnUpdateColor.Enabled = false;
            this.btnUpdateColor.Location = new System.Drawing.Point(74, 323);
            this.btnUpdateColor.Name = "btnUpdateColor";
            this.btnUpdateColor.Size = new System.Drawing.Size(92, 35);
            this.btnUpdateColor.TabIndex = 13;
            this.btnUpdateColor.Text = "Update Color";
            this.btnUpdateColor.UseVisualStyleBackColor = true;
            this.btnUpdateColor.Click += new System.EventHandler(this.btnUpdateColor_Click);
            // 
            // lbPower
            // 
            this.lbPower.AutoSize = true;
            this.lbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPower.Location = new System.Drawing.Point(18, 273);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(37, 13);
            this.lbPower.TabIndex = 12;
            this.lbPower.Text = "Power";
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlue.Location = new System.Drawing.Point(37, 219);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(17, 17);
            this.lbBlue.TabIndex = 11;
            this.lbBlue.Text = "B";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreen.Location = new System.Drawing.Point(35, 180);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(19, 17);
            this.lbGreen.TabIndex = 10;
            this.lbGreen.Text = "G";
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRed.Location = new System.Drawing.Point(37, 139);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(18, 17);
            this.lbRed.TabIndex = 9;
            this.lbRed.Text = "R";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(49, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 81);
            this.panel1.TabIndex = 8;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // txbPower
            // 
            this.txbPower.Location = new System.Drawing.Point(185, 270);
            this.txbPower.Name = "txbPower";
            this.txbPower.Size = new System.Drawing.Size(39, 20);
            this.txbPower.TabIndex = 7;
            this.txbPower.Text = "255";
            this.txbPower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPower_KeyDown);
            // 
            // txbBlue
            // 
            this.txbBlue.Location = new System.Drawing.Point(185, 219);
            this.txbBlue.Name = "txbBlue";
            this.txbBlue.Size = new System.Drawing.Size(39, 20);
            this.txbBlue.TabIndex = 6;
            this.txbBlue.Text = "0";
            this.txbBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbBlue_KeyDown);
            // 
            // txbGreen
            // 
            this.txbGreen.Location = new System.Drawing.Point(185, 179);
            this.txbGreen.Name = "txbGreen";
            this.txbGreen.Size = new System.Drawing.Size(39, 20);
            this.txbGreen.TabIndex = 5;
            this.txbGreen.Text = "0";
            this.txbGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbGreen_KeyDown);
            // 
            // txbRed
            // 
            this.txbRed.Location = new System.Drawing.Point(185, 141);
            this.txbRed.Name = "txbRed";
            this.txbRed.Size = new System.Drawing.Size(39, 20);
            this.txbRed.TabIndex = 4;
            this.txbRed.Text = "0";
            this.txbRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbRed_KeyDown);
            // 
            // tbPower
            // 
            this.tbPower.LargeChange = 8;
            this.tbPower.Location = new System.Drawing.Point(59, 270);
            this.tbPower.Maximum = 255;
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(120, 45);
            this.tbPower.TabIndex = 3;
            this.tbPower.TickFrequency = 64;
            this.tbPower.Value = 255;
            this.tbPower.ValueChanged += new System.EventHandler(this.tbPower_ValueChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.LargeChange = 8;
            this.tbBlue.Location = new System.Drawing.Point(59, 219);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(120, 45);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.TickFrequency = 64;
            this.tbBlue.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            this.tbBlue.ValueChanged += new System.EventHandler(this.tbBlue_ValueChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.LargeChange = 8;
            this.tbGreen.Location = new System.Drawing.Point(59, 179);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(120, 45);
            this.tbGreen.TabIndex = 1;
            this.tbGreen.TickFrequency = 64;
            this.tbGreen.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            // 
            // tbRed
            // 
            this.tbRed.LargeChange = 8;
            this.tbRed.Location = new System.Drawing.Point(59, 139);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(120, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.TickFrequency = 64;
            this.tbRed.Scroll += new System.EventHandler(this.tbRGB_Scroll);
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            // 
            // gbCommu
            // 
            this.gbCommu.Controls.Add(this.gbTCP);
            this.gbCommu.Controls.Add(this.gbSerial);
            this.gbCommu.Controls.Add(this.rdbTCP);
            this.gbCommu.Controls.Add(this.rdbSerial);
            this.gbCommu.Location = new System.Drawing.Point(280, 35);
            this.gbCommu.Name = "gbCommu";
            this.gbCommu.Size = new System.Drawing.Size(289, 383);
            this.gbCommu.TabIndex = 1;
            this.gbCommu.TabStop = false;
            this.gbCommu.Text = "Communication";
            // 
            // gbTCP
            // 
            this.gbTCP.Controls.Add(this.btnTCPdiscon);
            this.gbTCP.Controls.Add(this.btnTCPConnect);
            this.gbTCP.Controls.Add(this.txbPortNo);
            this.gbTCP.Controls.Add(this.txbIP);
            this.gbTCP.Controls.Add(this.label4);
            this.gbTCP.Controls.Add(this.label3);
            this.gbTCP.Enabled = false;
            this.gbTCP.Location = new System.Drawing.Point(19, 225);
            this.gbTCP.Name = "gbTCP";
            this.gbTCP.Size = new System.Drawing.Size(252, 151);
            this.gbTCP.TabIndex = 3;
            this.gbTCP.TabStop = false;
            this.gbTCP.Text = "TCP communition setting";
            // 
            // btnTCPdiscon
            // 
            this.btnTCPdiscon.Location = new System.Drawing.Point(143, 94);
            this.btnTCPdiscon.Name = "btnTCPdiscon";
            this.btnTCPdiscon.Size = new System.Drawing.Size(95, 26);
            this.btnTCPdiscon.TabIndex = 5;
            this.btnTCPdiscon.Text = "Disconnect";
            this.btnTCPdiscon.UseVisualStyleBackColor = true;
            this.btnTCPdiscon.Click += new System.EventHandler(this.btnTCPdiscon_Click);
            // 
            // btnTCPConnect
            // 
            this.btnTCPConnect.Location = new System.Drawing.Point(143, 50);
            this.btnTCPConnect.Name = "btnTCPConnect";
            this.btnTCPConnect.Size = new System.Drawing.Size(95, 26);
            this.btnTCPConnect.TabIndex = 4;
            this.btnTCPConnect.Text = "Connect";
            this.btnTCPConnect.UseVisualStyleBackColor = true;
            this.btnTCPConnect.Click += new System.EventHandler(this.btnTCPConnect_Click);
            // 
            // txbPortNo
            // 
            this.txbPortNo.Location = new System.Drawing.Point(23, 98);
            this.txbPortNo.Name = "txbPortNo";
            this.txbPortNo.Size = new System.Drawing.Size(50, 20);
            this.txbPortNo.TabIndex = 3;
            this.txbPortNo.Text = "8000";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(23, 52);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(95, 20);
            this.txbIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port no.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP address";
            // 
            // gbSerial
            // 
            this.gbSerial.Controls.Add(this.btnSerialDiscon);
            this.gbSerial.Controls.Add(this.btnSerialConnect);
            this.gbSerial.Controls.Add(this.label2);
            this.gbSerial.Controls.Add(this.cmbBaudRate);
            this.gbSerial.Controls.Add(this.label1);
            this.gbSerial.Controls.Add(this.cmbPortName);
            this.gbSerial.Enabled = false;
            this.gbSerial.Location = new System.Drawing.Point(18, 66);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Size = new System.Drawing.Size(253, 141);
            this.gbSerial.TabIndex = 2;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "Serial communication setting";
            // 
            // btnSerialDiscon
            // 
            this.btnSerialDiscon.Location = new System.Drawing.Point(144, 93);
            this.btnSerialDiscon.Name = "btnSerialDiscon";
            this.btnSerialDiscon.Size = new System.Drawing.Size(91, 26);
            this.btnSerialDiscon.TabIndex = 5;
            this.btnSerialDiscon.Text = "Disconnect";
            this.btnSerialDiscon.UseVisualStyleBackColor = true;
            this.btnSerialDiscon.Click += new System.EventHandler(this.btnSerialDiscon_Click);
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(144, 46);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(91, 26);
            this.btnSerialConnect.TabIndex = 4;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(24, 97);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(95, 21);
            this.cmbBaudRate.TabIndex = 2;
            this.cmbBaudRate.SelectedIndexChanged += new System.EventHandler(this.SerialComSetupChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port name";
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(24, 50);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(95, 21);
            this.cmbPortName.TabIndex = 0;
            this.cmbPortName.SelectedIndexChanged += new System.EventHandler(this.SerialComSetupChange);
            // 
            // rdbTCP
            // 
            this.rdbTCP.AutoSize = true;
            this.rdbTCP.Location = new System.Drawing.Point(131, 28);
            this.rdbTCP.Name = "rdbTCP";
            this.rdbTCP.Size = new System.Drawing.Size(46, 17);
            this.rdbTCP.TabIndex = 1;
            this.rdbTCP.TabStop = true;
            this.rdbTCP.Text = "TCP";
            this.rdbTCP.UseVisualStyleBackColor = true;
            this.rdbTCP.Enter += new System.EventHandler(this.rdbTCP_Enter);
            // 
            // rdbSerial
            // 
            this.rdbSerial.AutoSize = true;
            this.rdbSerial.Location = new System.Drawing.Point(25, 28);
            this.rdbSerial.Name = "rdbSerial";
            this.rdbSerial.Size = new System.Drawing.Size(73, 17);
            this.rdbSerial.TabIndex = 0;
            this.rdbSerial.TabStop = true;
            this.rdbSerial.Text = "Serial Port";
            this.rdbSerial.UseVisualStyleBackColor = true;
            this.rdbSerial.Enter += new System.EventHandler(this.rdbSerial_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 441);
            this.Controls.Add(this.gbCommu);
            this.Controls.Add(this.gbControl);
            this.Name = "Form1";
            this.Text = "RGB Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.gbCommu.ResumeLayout(false);
            this.gbCommu.PerformLayout();
            this.gbTCP.ResumeLayout(false);
            this.gbTCP.PerformLayout();
            this.gbSerial.ResumeLayout(false);
            this.gbSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.TextBox txbPower;
        private System.Windows.Forms.TextBox txbBlue;
        private System.Windows.Forms.TextBox txbGreen;
        private System.Windows.Forms.TextBox txbRed;
        private System.Windows.Forms.TrackBar tbPower;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.GroupBox gbCommu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.RadioButton rdbTCP;
        private System.Windows.Forms.RadioButton rdbSerial;
        private System.Windows.Forms.GroupBox gbTCP;
        private System.Windows.Forms.GroupBox gbSerial;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Button btnSerialDiscon;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTCPConnect;
        private System.Windows.Forms.TextBox txbPortNo;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnTCPdiscon;
        private System.Windows.Forms.Button btnUpdateColor;
    }
}


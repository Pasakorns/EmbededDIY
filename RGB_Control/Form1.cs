using System;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Arduino_LED;

namespace RGB_Control
{
    public partial class Form1 : Form
    {
        private Byte[] cmd = { 0, 0, 0, 255 };
        private TcpClient client;
        private NetworkStream steam;
        private MyRGB color;
        
        public Form1()
        {
            InitializeComponent();
            serialPort1.ReadTimeout = 3000;          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            color = new MyRGB();
        }

        /////////////// Control Group /////////////////
        /// Panel
        private void panel1_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if(colorResult == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                tbRed.Value = colorDialog1.Color.R;
                tbGreen.Value = colorDialog1.Color.G;
                tbBlue.Value = colorDialog1.Color.B;
                color.setRGB(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }

        private void btnUpdateColor_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ControlMessage();
                serialPort1.Write(cmd,0,4);
            }
            else if (client.Connected)
            {
                ControlMessage();
                steam.Write(cmd, 0, 4);
            }
        }

        /// Track bar
        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            txbRed.Text = tbRed.Value.ToString();
            color.setRED(tbRed.Value);
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            txbGreen.Text = tbGreen.Value.ToString();
            color.setGreen(tbGreen.Value);
        }

        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            txbBlue.Text = tbBlue.Value.ToString();
            color.setBLUE(tbBlue.Value);
        }

        private void tbPower_ValueChanged(object sender, EventArgs e)
        {
            txbPower.Text = tbPower.Value.ToString();
            color.LEDPower = tbPower.Value;
        }

        private void tbRGB_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(color.rgb.R, color.rgb.G, color.rgb.B);
        }
        
        /// Text box
        private void txbRed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                try
                {
                    int data = Int32.Parse(txbRed.Text);
                    if (data <= 255)
                    {
                        tbRed.Value = data;
                        color.setRED(data);
                        panel1.BackColor = Color.FromArgb(color.rgb.R, color.rgb.G, color.rgb.B);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void txbGreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                try
                {
                    int data = Int32.Parse(txbGreen.Text);
                    if (data <= 255)
                    {
                        tbGreen.Value = data;
                        color.setGreen(data);
                        panel1.BackColor = Color.FromArgb(color.rgb.R, color.rgb.G, color.rgb.B);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void txbBlue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                try
                {
                    int data = Int32.Parse(txbBlue.Text);
                    if (data <= 255)
                    {
                        tbBlue.Value = data;
                        color.setBLUE(data);
                        panel1.BackColor = Color.FromArgb(color.rgb.R, color.rgb.G, color.rgb.B);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void txbPower_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                try
                {
                    int data = Int32.Parse(txbPower.Text);
                    if (data <= 255)
                    {
                        tbPower.Value = data;
                        color.LEDPower = data;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        
       
        //////////////// Communication Group ///////////////
        /// Serial
        private void rdbSerial_Enter(object sender, EventArgs e)
        {
            gbSerial.Enabled = true;
            gbTCP.Enabled = false;
            cmbPortName.Enabled = true;
            cmbBaudRate.Enabled = true;
            btnSerialConnect.Enabled = false;
            btnSerialDiscon.Enabled = false;
            GetAvailablePort();
            try
            {
                client.Close();
                btnUpdateColor.Enabled = false;
            }
            catch (Exception) { }                  
        }

        private void SerialComSetupChange(object sender, EventArgs e)
        {
            try
            {
                if (cmbPortName.Text != "" && cmbBaudRate.Text != "")
                {
                    serialPort1.PortName = cmbPortName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    btnSerialConnect.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                btnSerialDiscon.Enabled = true;
                cmbPortName.Enabled = false;
                cmbBaudRate.Enabled = false;
                btnUpdateColor.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Connect error!!!");
                //throw;
            }
        }

        private void btnSerialDiscon_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnSerialConnect.Enabled = false;
                btnSerialDiscon.Enabled = false;
                cmbPortName.Enabled = true;
                cmbBaudRate.Enabled = true;
                btnUpdateColor.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Disconnect error!!!");
                throw;
            }
        }

        /// TCP
        private void rdbTCP_Enter(object sender, EventArgs e)
        {
            gbSerial.Enabled = false;
            gbTCP.Enabled = true;
            btnTCPConnect.Enabled = true;
            btnTCPdiscon.Enabled = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnUpdateColor.Enabled = false;
            }

        }

        private void btnTCPConnect_Click(object sender, EventArgs e)
        {
            TCPClientInitail();
            try
            {
                if (client.Connected)
                {
                    btnUpdateColor.Enabled = true;
                    btnTCPConnect.Enabled = false;
                    btnTCPdiscon.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connect time out!");
            }
            
            
        }

        private void btnTCPdiscon_Click(object sender, EventArgs e)
        {
            try
            {
                client.Close();
                btnUpdateColor.Enabled = false;
                btnTCPConnect.Enabled = true;
                btnTCPdiscon.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        //-------- Method ----------//
        private void GetAvailablePort()
        {
            cmbPortName.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            cmbPortName.Items.AddRange(ports);
        }

        public void TCPClientInitail()
        {
            Int32 port = Convert.ToInt32(txbPortNo.Text);
            String serverIP = txbIP.Text;
            IPAddress ip;
            bool IPvalid = IPAddress.TryParse(serverIP, out ip);
            if (IPvalid)
            {
                try
                {
                    client = new TcpClient(serverIP, port);
                    steam = client.GetStream();
                }
                catch (Exception)
                {
                }                
            }
            else
            {
                MessageBox.Show("IP address not correct");
            }
            
        }

        private void ControlMessage()
        {
            cmd[0] = Convert.ToByte(color.rgb.R);
            cmd[1] = Convert.ToByte(color.rgb.G);
            cmd[2] = Convert.ToByte(color.rgb.B);
            cmd[3] = Convert.ToByte(color.LEDPower);          
        }
    }
}

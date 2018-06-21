using System.Drawing;

namespace Arduino_LED
{
    public class MyRGB
    {
        private int _RED = 0;
        private int _GRN = 0;
        private int _BLU = 0;

        /// Properties
        public int LEDPower { get; set; } = 255;
        public Color rgb
        {
            get
            {
                return Color.FromArgb(_RED, _GRN, _BLU);
            }
        }

        /// Constructor
        public MyRGB() { }
        public MyRGB(int R, int G, int B, int P)
        {
            this._RED = R;
            this._GRN = G;
            this._BLU = B;
            this.LEDPower = P;
        }

        /// Method
        public void setRGB(int R, int G, int B)
        {
            this._RED = R;
            this._GRN = G;
            this._BLU = B;
        }
        public void setColor(Color c)
        {
            this._RED = c.R;
            this._GRN = c.G;
            this._BLU = c.B;
        }
        public void setRED(int R)
        {
            this._RED = R;
        }
        public void setGreen(int G)
        {
            this._GRN = G;
        }
        public void setBLUE(int B)
        {
            this._BLU = B;
        }
    }
}
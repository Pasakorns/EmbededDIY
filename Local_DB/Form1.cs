using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.Table01' table. You can move, or remove it, as needed.
            this.table01TableAdapter.Fill(this.appDataSet.Table01);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appDataSet.Table01.AddTable01Row(appDataSet.Table01.NewTable01Row());
            table01BindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                table01BindingSource.RemoveCurrent();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table01BindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table01BindingSource.EndEdit();
            table01TableAdapter.Update(appDataSet.Table01);
            dataGridView1.Refresh();
        }
    }
}

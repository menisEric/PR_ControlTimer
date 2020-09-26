using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prControlTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

        }
        private int num = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            num = num + 1;
            if(num % 2 == 0)
            {
                label2.Visible = true;
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label2.Visible = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}

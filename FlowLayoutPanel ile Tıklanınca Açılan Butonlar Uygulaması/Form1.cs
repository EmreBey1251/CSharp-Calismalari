using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowlayoutpanel_senin_ta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int a = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            a++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int b = 140;
            if (a == 1)
            {
                if (flowLayoutPanel1.Height < b)
                {
                    flowLayoutPanel1.Height += 10;
                }
            }
            else
            {
                a = 0;
                if(flowLayoutPanel1.Height > 30) flowLayoutPanel1.Height -= 10;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height -= 10;
            int a = 30;
            if (flowLayoutPanel1.Height == a)
            {
                timer2.Stop();
            }
        }
    }
}

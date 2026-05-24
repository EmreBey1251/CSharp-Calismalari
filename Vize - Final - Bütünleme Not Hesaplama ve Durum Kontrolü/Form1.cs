using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_5
{
    public partial class Form1 : Form
    {
      double a,b,c,d;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            d = Convert.ToDouble(textBox4.Text);
            c = (d * 0.6) + (b * 0.4);
            textBox3.Text=c.ToString(); 
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text); 
            c = (a * 0.6) + (b * 0.4);
            textBox3.Text = c.ToString();
            if (c<50)
            {
                MessageBox.Show("Oh my goodness");
                textBox4.Enabled = true;
                label4.Enabled = true;
            }
               
            else
            {
                MessageBox.Show("Geçtiniz");
            }
        }
    }
}

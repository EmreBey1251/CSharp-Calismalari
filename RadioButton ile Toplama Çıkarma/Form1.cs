using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inan_hoca_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int sayi1;            
            sayi = Convert.ToInt32(textBox1.Text);
            sayi1 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                label1.Text = (sayi + sayi1).ToString();
            }
            else
            {
                label1.Text = (sayi - sayi1).ToString();
            }
     
        
        }
    }
}

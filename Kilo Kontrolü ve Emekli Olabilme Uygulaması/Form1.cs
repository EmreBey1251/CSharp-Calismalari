using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(textBox1.Text);
            if (i >= 100 || checkBox1.Checked)
            {
                MessageBox.Show("Kilonuza dikkat edin.");
            }
            else if (i <=50)
            {
                MessageBox.Show("Kilo almaya çalışın.");
            }
            else if (i >=65)
            {
                MessageBox.Show("Bu kiloyu koruyun.");
            }
            else if (i <=65)
            {
                MessageBox.Show("Biraz zayıfsınız."); 
            }            
            else 
            {
                MessageBox.Show("Yanlış işlem yaptınız.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(textBox2.Text);
            b = Convert.ToInt32(textBox3.Text);
            if (a > 65 || b > 10000 || checkBox2.Checked)
            {
                MessageBox.Show("Emekli olabilirsin.");
            }
            else
            {
                MessageBox.Show("Emekli olamazsın.");
            }        
        }
    }
}

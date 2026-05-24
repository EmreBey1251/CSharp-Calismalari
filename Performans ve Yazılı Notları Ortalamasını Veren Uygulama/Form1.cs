using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hocanın_verdiği_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yazili1, yazili2, ortalama1, performans1, performan2, ortalama2;
            yazili1 = Convert.ToDouble(textBox1.Text);
            yazili2 = Convert.ToDouble(textBox2.Text);
            ortalama1 = ((yazili1 + yazili2) / 2 * 0.60);
            textBox3.Text = ortalama1.ToString();
            performans1 = Convert.ToDouble(textBox4.Text);
            performan2 = Convert.ToDouble(textBox5.Text);
            ortalama2 = ((performans1 + performan2) / 2 * 0.40);
            textBox6.Text = ortalama2.ToString();
            double sonort = (ortalama1 + ortalama2);
            textBox7.Text = sonort.ToString();

            if (sonort >= 50)
            {
                MessageBox.Show("Kaldı");
           
            }

            else
            {
                MessageBox.Show("Sınıfı Geçti");
            }
        }
    }
}

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

namespace hoca_ör_6
{
    public partial class Form1 : Form
    {

        int yas;      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yas = Convert.ToInt32(textBox1.Text);
            if (yas < 0)
            {
                MessageBox.Show("UYARI:0'dan küçük yaş giridiniz.");
            }
            else if (yas < 6)
            {
                MessageBox.Show("Bebeksiniz.");
            }
            else if (yas < 18)
            {
                MessageBox.Show("Ergensiniz");
            }
            else if (yas < 22)
            {
                MessageBox.Show("Gençsiniz");
            }
            else if (radioButton1.Checked && yas < 25)
            {
                MessageBox.Show("Yanlış Değer Girdiniz");
            }
            else if (radioButton1.Checked && yas > 25)
            {
                MessageBox.Show("Doğru değer girdiniz");
            }
            else if (radioButton2.Checked && yas > 70)
            {
                MessageBox.Show("SEN AKSİSİN");
            }
            else if (yas < 35)
            {
                MessageBox.Show("Orta Yaşlısınız");
            }
            else if (yas <55)
            {
                MessageBox.Show("Yaşlı");
            }
            else if (yas <99)
            {
                MessageBox.Show("Dead");
            }
            else if (yas > 125)
            {
                MessageBox.Show("Vampirsiniz");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                    
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }    
    }
}

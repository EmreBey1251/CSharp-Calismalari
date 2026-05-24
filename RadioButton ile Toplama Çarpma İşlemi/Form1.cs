using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ünite_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool deger1Gecerli = int.TryParse(textBox1.Text, out int deger1);
            bool deger2Gecerli = int.TryParse(textBox2.Text, out int deger2);

            if (!deger1Gecerli || !deger2Gecerli)
            {
                MessageBox.Show("Lütfen her iki alana da geçerli bir tam sayı giriniz!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (radioButton1.Checked) 
            {
                label4.Text = (deger1 + deger2).ToString();
            }
            else
            {
                label4.Text = (deger1 * deger2).ToString();
            }
        }
    }
}

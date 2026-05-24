using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 3;
            double pi = 4;
            bool b = false; 

            // Kullanıcının textBox1'e girdiği adım sayısı kadar döngü döner
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                if (b == false)
                {
                    pi = pi - (4 / a); // Çıkarma işlemi
                    a = a + 2;         // Payda 2 artıyor (3 -> 5)
                    b = true;          // Bir dahaki sefere else bloğuna gitsin diye true yapıyoruz
                }
                else
                {
                    pi = pi + (4 / a); // DÜZELTİLEN YER: Burası toplama (+) olmalı!
                    a = a + 2;         // Payda 2 artıyor (5 -> 7)
                    b = false;         // Bir dahaki sefere if bloğuna gitsin diye false yapıyoruz
                }
            }

            // Çıkan sonucu ekrana yazdırıyoruz
            label2.Text = pi.ToString();
        }
    }
}

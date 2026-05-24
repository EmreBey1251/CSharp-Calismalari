using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ünite_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool skor1Gecerli = byte.TryParse(textBox1.Text, out byte skor1);
            bool skor2Gecerli = byte.TryParse(textBox2.Text, out byte skor2);

            if (!skor1Gecerli || !skor2Gecerli)
            {
                MessageBox.Show("Lütfen her iki takım için de geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (skor1 > skor2)
            {
                MessageBox.Show($"1. Takım {skor1}-{skor2} skorla maçı kazandı!", "Maç Sonucu");
            }
            else if (skor2 > skor1)
            {
                MessageBox.Show($"2. Takım {skor2}-{skor1} skorla maçı kazandı!", "Maç Sonucu");
            }
            else
            {
                MessageBox.Show($"Dostluk kazandı! Maç {skor1}-{skor2} berabere bitti.", "Maç Sonucu");
            }
        }
    }
}

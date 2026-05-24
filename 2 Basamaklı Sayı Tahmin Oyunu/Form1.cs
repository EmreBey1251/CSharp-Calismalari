using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inan_hoca_8
{
    public partial class Form1 : Form
    {
        int sayi;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = rnd.Next(0, 100);
            int hak = 1;
            string mesaj = "Lütfen tahmin yaz.";
            string baslık = "Borusan MTAL";
            bool bildiniz = false;
            while (hak <= 5)
            {
                string tahmin = Interaction.InputBox(mesaj, baslık);
                if (Convert.ToUInt32(tahmin) == sayi)
                {
                    bildiniz=true;
                    break;
                }
                else if (Convert.ToUInt32(tahmin) < sayi)
                {
                    mesaj = "Daha büyük bir sayı tahmin et.";
                    hak++;
                    baslık = hak + " . hakkınızdasınız.";
                }
                else
                {
                    mesaj = "Daha küçük bir sayı giriniz.";
                    hak++;
                    baslık = hak + " . hakkınızdasınız.";
                }
            }
            if (bildiniz)
            {
                MessageBox.Show(hak + ". hakkınızda bildiniz.", "Borusan MTAL");
            }
            else
            {
                MessageBox.Show("Bilemediniz: " + sayi, "Borusan MTAL");
            }
        }
    }
}

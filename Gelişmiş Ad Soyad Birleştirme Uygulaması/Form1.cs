using System;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Sağındaki solundaki gereksiz boşlukları temizleyerek metinleri alıyoruz
            string ad = textBox1.Text.Trim();
            string soyad = textBox2.Text.Trim();

            //  Kutular boş mu?
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen hem Ad hem de Soyad alanlarını doldurunuz!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  İçinde sayı veya özel karakter var mı?
            foreach (char karakter in ad + soyad)
            {
                // Eğer karakter harf değilse VE boşluk da değilse (Örn: sayı, nokta, ünlem vb.)
                if (!char.IsLetter(karakter) && !char.IsWhiteSpace(karakter))
                {
                    MessageBox.Show("Ad ve Soyad alanlarına sadece harf girebilirsiniz! Sayı veya özel karakter kullanamazsınız.", "Geçersiz Karakter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            //  Her şey temizse araya bir boşluk atıp birleştiriyoruz
            string tamAd = $"{ad} {soyad}";

            //  Sonucu üçüncü kutuya yazdırıyoruz
            textBox3.Text = tamAd;
        }
    }
}
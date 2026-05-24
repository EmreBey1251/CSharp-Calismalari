using System;
using System.Drawing;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yardımcı Fonksiyon: Her butonun içinde aynı kodu tekrar yazmamak için ortak hesaplama metodu
        private void IndirimHesapla(double indirimOrani)
        {
            // Sayı kontrolü yapıyoruz (Harf girilirse çökmeyi önler)
            bool gecerliMi = double.TryParse(textBox1.Text, out double etiketFiyati);

            if (!gecerliMi)
            {
                MessageBox.Show("Lütfen geçerli bir etiket fiyatı giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double indirimliFiyat = etiketFiyati - (etiketFiyati * indirimOrani);

            label2.Text = $"İndirimli Fiyat: {indirimliFiyat:F2} TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndirimHesapla(0.10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IndirimHesapla(0.25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IndirimHesapla(0.50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IndirimHesapla(0.75);
        }

        // ==========================================================
        // HATA GİDERİCİ HAYALET FONKSİYONLAR (SİLME!)
        // ==========================================================
        private void label1_Click(object sender, EventArgs e)
        {
            // Yanlışlıkla çift tıkladığın için burası boş durmalı, hata vermesini engeller.
        }

        private void textBox1_TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Yanlışlıkla çift tıkladığın için burası boş durmalı, hata vermesini engeller.
        }
    }
}
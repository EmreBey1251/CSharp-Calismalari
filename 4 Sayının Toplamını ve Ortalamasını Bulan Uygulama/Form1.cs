using System;
using System.Windows.Forms;

namespace _3.proje
{
    public partial class Form1 : Form
    {
        // Sayıları saklamak için global değişkenler tanımlıyoruz
        int s1, s2, s3, s4;
        int toplam = 0;
        int ortalama = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Önce girdiler sayı mı diye kontrol ediyoruz
            if (GirdileriKontrolEt())
            {
                toplam = s1 + s2 + s3 + s4;
                label1.Text = toplam.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Önce girdiler sayı mı diye kontrol ediyoruz
            if (GirdileriKontrolEt())
            {
                toplam = s1 + s2 + s3 + s4;
                ortalama = toplam / 4;
                label2.Text = ortalama.ToString();
            }
        }

        // TextBox'lardaki verileri güvenli bir şekilde doğrulayan yardımcı fonksiyon
        private bool GirdileriKontrolEt()
        {
            bool s1Gecerli = int.TryParse(textBox1.Text, out s1);
            bool s2Gecerli = int.TryParse(textBox2.Text, out s2);
            bool s3Gecerli = int.TryParse(textBox3.Text, out s3);
            bool s4Gecerli = int.TryParse(textBox4.Text, out s4);

            // Eğer kutulardan biri bile boşsa veya harf içeriyorsa false dönecek
            if (!s1Gecerli || !s2Gecerli || !s3Gecerli || !s4Gecerli)
            {
                MessageBox.Show("Lütfen tüm alanlara geçerli sayılar giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // "toplama" Butonuna Tıklandığında Çalışacak Kod
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // "ortalama" Butonuna Tıklandığında Çalışacak Kod
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
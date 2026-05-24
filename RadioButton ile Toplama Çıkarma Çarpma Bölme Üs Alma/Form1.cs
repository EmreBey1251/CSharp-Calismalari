using System;
using System.Drawing;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kutulardaki verilerin sayı olup olmadığını güvenli bir şekilde kontrol ediyoruz (Çökmeyi Önler)
            bool s1Gecerli = double.TryParse(textBox1.Text, out double sayi1);
            bool s2Gecerli = double.TryParse(textBox2.Text, out double sayi2);

            if (!s1Gecerli || !s2Gecerli)
            {
                MessageBox.Show("Lütfen alanlara geçerli sayılar giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kodun aşağıya devam etmesini engeller
            }

            double sonuc = 0;

            // 2. Hangi RadioButton seçiliyse ona göre matematiksel işlemi yapıyoruz
            if (radioButton1.Checked) // Toplama
            {
                sonuc = sayi1 + sayi2;
            }
            else if (radioButton2.Checked) // Çıkarma
            {
                sonuc = sayi1 - sayi2;
            }
            else if (radioButton3.Checked) // Çarpma
            {
                sonuc = sayi1 * sayi2;
            }
            else if (radioButton4.Checked) // Bölme
            {
                // Kritik Matematik Bariyeri: Sıfıra bölme hatasını engelliyoruz
                if (sayi2 == 0)
                {
                    MessageBox.Show("Bir sayı sıfıra bölünemez!", "Matematik Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sonuc = sayi1 / sayi2;
            }
            else if (radioButton5.Checked) // Üs Alma
            {
                sonuc = Math.Pow(sayi1, sayi2);
            }
            else
            {
                // Eğer kullanıcı hiçbir işlemi seçmeden butona bastıysa uyaralım
                MessageBox.Show("Lütfen yapmak istediğiniz işlemi seçin!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Hesaplanan sonucu üçüncü kutuya yazdırıyoruz
            textBox3.Text = sonuc.ToString();
        }

        // Aşağıdaki TextChanged ve CheckedChanged olayları tasarımın kararlı çalışması için boş kalabilir. 
        // Tasarımda bunlara çift tıkladığın için C# arkada hata aramasın diye burada durmaya devam ediyorlar.
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton5_CheckedChanged(object sender, EventArgs e) { }
    }
}
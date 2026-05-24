using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace direnç_ugulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hesaplama butonu, seçilen renk kodlarına göre direnç değerini hesaplar
        private void button1_Click(object sender, EventArgs e)
        {
            // 5 Bandlı Direnç Hesaplama: İlk 3 hanenin (TextBox) dolu olduğu durum
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                // İlk 3 rengin sayısal değerlerini yan yana string olarak birleştirir 
                textBox6.Text = Convert.ToString(textBox1.Text + textBox2.Text + textBox3.Text);

                // Birleştirilen string değeri tam sayıya dönüştürür
                int c = Convert.ToInt32(textBox6.Text);
                // Çarpan değerini TextBox4'ten alır
                int b = Convert.ToInt32(textBox4.Text);

                // Taban değer ile çarpanı çarparak toplam Ohm değerini hesaplar ve yazdırır
                textBox7.Text = Convert.ToString(c * b);
            }
            // 4 Bandlı Direnç Hesaplama: Sadece ilk 2 hanenin dolu olduğu durum
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                // İlk 2 rengi yan yana birleştirir 
                textBox6.Text = Convert.ToString(textBox1.Text + textBox2.Text);

                int a = Convert.ToInt32(textBox6.Text);
                int b = Convert.ToInt32(textBox4.Text);

                // Direnç değerini hesaplar (Taban Değer * Çarpan)
                textBox7.Text = Convert.ToString(a * b);
            }
        }

        // 1. BAND
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "siyah": comboBox1.BackColor = Color.Black; textBox1.Text = "0"; break;
                case "kahve": comboBox1.BackColor = Color.Brown; textBox1.Text = "1"; break;
                case "kırmızı": comboBox1.BackColor = Color.Red; textBox1.Text = "2"; break;
                case "turuncu": comboBox1.BackColor = Color.Orange; textBox1.Text = "3"; break;
                case "sarı": comboBox1.BackColor = Color.Yellow; textBox1.Text = "4"; break;
                case "yeşil": comboBox1.BackColor = Color.Green; textBox1.Text = "5"; break;
                case "mavi": comboBox1.BackColor = Color.Blue; textBox1.Text = "6"; break;
                case "mor": comboBox1.BackColor = Color.Purple; textBox1.Text = "7"; break;
                case "gri": comboBox1.BackColor = Color.Gray; textBox1.Text = "8"; break;
                case "beyaz": comboBox1.BackColor = Color.White; textBox1.Text = "9"; break;
            }
        }

        // 2. BAND 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "siyah": comboBox2.BackColor = Color.Black; textBox2.Text = "0"; break;
                case "kahve": comboBox2.BackColor = Color.Brown; textBox2.Text = "1"; break;
                case "kırmızı": comboBox2.BackColor = Color.Red; textBox2.Text = "2"; break;
                case "turuncu": comboBox2.BackColor = Color.Orange; textBox2.Text = "3"; break;
                case "sarı": comboBox2.BackColor = Color.Yellow; textBox2.Text = "4"; break;
                case "yeşil": comboBox2.BackColor = Color.Green; textBox2.Text = "5"; break;
                case "mavi": comboBox2.BackColor = Color.Blue; textBox2.Text = "6"; break;
                case "mor": comboBox2.BackColor = Color.Purple; textBox2.Text = "7"; break;
                case "gri": comboBox2.BackColor = Color.Gray; textBox2.Text = "8"; break;
                case "beyaz": comboBox2.BackColor = Color.White; textBox2.Text = "9"; break;
            }
        }

        // 3. BAND 
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "siyah": comboBox3.BackColor = Color.Black; textBox3.Text = "0"; break;
                case "kahve": comboBox3.BackColor = Color.Brown; textBox3.Text = "1"; break;
                case "kırmızı": comboBox3.BackColor = Color.Red; textBox3.Text = "2"; break;
                case "turuncu": comboBox3.BackColor = Color.Orange; textBox3.Text = "3"; break;
                case "sarı": comboBox3.BackColor = Color.Yellow; textBox3.Text = "4"; break;
                case "yeşil": comboBox3.BackColor = Color.Green; textBox3.Text = "5"; break;
                case "mavi": comboBox3.BackColor = Color.Blue; textBox3.Text = "6"; break;
                case "mor": comboBox3.BackColor = Color.Purple; textBox3.Text = "7"; break;
                case "gri": comboBox3.BackColor = Color.Gray; textBox3.Text = "8"; break;
                case "beyaz": comboBox3.BackColor = Color.White; textBox3.Text = "9"; break;
            }
        }

        // ÇARPAN BANDI
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "1": textBox4.Text = "1"; break;
                case "10": textBox4.Text = "10"; break;
                case "100": textBox4.Text = "100"; break;
                case "1000": textBox4.Text = "1000"; break;
                case "10000": textBox4.Text = "10000"; break;
                case "100000": textBox4.Text = "100000"; break;
                case "1000000": textBox4.Text = "1000000"; break;
            }

            // Özel Durum: Altın veya Gümüş gibi çarpanlar ve endeks bazlı kontroller
            if (comboBox4.SelectedIndex == 7)
            {
                textBox4.Text = "%1"; // Not: Bu kısmın çarpan değeri (Örn: 0.1) ile güncellenmesi gerekebilir
            }
            if (comboBox4.SelectedIndex == 8)
            {
                textBox4.Text = "0.01";
            }
        }

        // TOLERANS BANDI
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen tolerans değerine göre yüzdeyi atar ve ilgili rengi ComboBox arka planı yapar
            if (comboBox5.SelectedIndex == 0)
            {
                textBox5.Text = "%5"; // Altın Rengi
                comboBox5.BackColor = Color.LightYellow;
            }
            if (comboBox5.SelectedIndex == 1)
            {
                textBox5.Text = "%10"; // Gümüş Rengi
                comboBox5.BackColor = Color.Silver;
            }
            if (comboBox5.SelectedIndex == 2)
            {
                textBox5.Text = "%1"; // Kahverengi
                comboBox5.BackColor = Color.Brown;
            }
            if (comboBox5.SelectedIndex == 3)
            {
                textBox5.Text = "%2"; // Kırmızı Rengi
                comboBox5.BackColor = Color.Red;
            }
        }

        // BİRİM DÖNÜŞTÜRÜCÜ (ÖLÇEKLENDİRME
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Büyük değerlerde veri kaybı olmaması için 'decimal' veri tipi kullanılmıştır
            if (comboBox6.SelectedIndex == 0)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) / 1000000000000); // Teraohm (TOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 1)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) / 1000000000); // Gigaohm (GOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 2)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) / 1000000); // Megaohm (MOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 3)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) / 1000); // Kiloohm (KOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 4)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) * 1000); // Miliohm (mOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 5)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) * 1000000); // Mikroohm (uOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 6)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) * 1000000000); // Nanoohm (nOhm) dönüşümü
            }
            if (comboBox6.SelectedIndex == 7)
            {
                decimal v = Convert.ToDecimal(textBox7.Text);
                decimal a = v;
                textBox8.Text = Convert.ToString(Convert.ToDecimal(textBox7.Text) * 1000000000000); // Pikoohm (pOhm) dönüşümü
            }
        }

    }
}
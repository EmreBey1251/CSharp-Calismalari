using System;
using System.Drawing;
using System.Windows.Forms;

namespace direnç_2_off
{
    public partial class Form1 : Form
    {
        // Renklerin sayısal değerlerini tutan değişkenler
        int renk1, renk2, renk3, carpan;
        double tolerans;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. RENK GRUBU (BİRİNCİ ÇİZGİ) BUTTONLARI
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 1;
            textBox1.Text = renk1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 2;
            textBox1.Text = renk1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 3;
            textBox1.Text = renk1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 4;
            textBox1.Text = renk1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 5;
            textBox1.Text = renk1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 6;
            textBox1.Text = renk1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 7;
            textBox1.Text = renk1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 8;
            textBox1.Text = renk1.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 9;
            textBox1.Text = renk1.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            renk1 = 10;
            textBox1.Text = renk1.ToString();
        }

        // 2. RENK GRUBU (İKİNCİ ÇİZGİ) BUTTONLARI
        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 1;
            textBox2.Text = renk2.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 2;
            textBox2.Text = renk2.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 3;
            textBox2.Text = renk2.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 4;
            textBox2.Text = renk2.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 5;
            textBox2.Text = renk2.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 6;
            textBox2.Text = renk2.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 7;
            textBox2.Text = renk2.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 8;
            textBox2.Text = renk2.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 9;
            textBox2.Text = renk2.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            renk2 = 10;
            textBox2.Text = renk2.ToString();
        }

        // 3. RENK GRUBU (ÜÇÜNCÜ ÇİZGİ) BUTTONLARI
        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 1;
            textBox3.Text = renk3.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 2;
            textBox3.Text = renk3.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 3;
            textBox3.Text = renk3.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 4;
            textBox3.Text = renk3.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 5;
            textBox3.Text = renk3.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 6;
            textBox3.Text = renk3.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 7;
            textBox3.Text = renk3.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 8;
            textBox3.Text = renk3.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 9;
            textBox3.Text = renk3.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            renk3 = 10;
            textBox3.Text = renk3.ToString();
        }

        // ÇARPAN (MULTIPLİER) BUTTONLARI
        private void button31_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 1;
            textBox5.Text = carpan.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 10;
            textBox5.Text = carpan.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 100;
            textBox5.Text = carpan.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 1000;
            textBox5.Text = carpan.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 10000;
            textBox5.Text = carpan.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 100000;
            textBox5.Text = carpan.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            carpan = 1000000;
            textBox5.Text = carpan.ToString();
        }

        // TOLERANS BUTTONLARI
        private void button38_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            tolerans = 0.05;
            textBox6.Text = tolerans.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            tolerans = 0.1;
            textBox6.Text = tolerans.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            tolerans = 0.01;
            textBox6.Text = tolerans.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            tolerans = 0.02;
            textBox6.Text = tolerans.ToString();
        }

        // ANA HESAPLA BUTONU (HESAPLA)
        private void button42_Click(object sender, EventArgs e)
        {
            // Eğer 3 renk kutusu da doluysa 
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                // Yan yana harf gibi birleştiriyoruz 
                textBox4.Text = textBox1.Text + textBox2.Text + textBox3.Text;

                double c = Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox5.Text);
                double h = c * b; // Çarpanla çarpıp ana Ohm değerini buluyoruz

                textBox7.Text = h.ToString();
            }
            // Eğer sadece ilk 2 renk kutusu doluysa 
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                // Yan yana birleştiriyoruz ("4" + "5" -> "45")
                textBox4.Text = textBox1.Text + textBox2.Text;

                double a = Convert.ToDouble(textBox4.Text);
                double d = Convert.ToDouble(textBox5.Text);
                double m = a * d; // Çarpanla çarpıp ana Ohm değerini buluyoruz

                textBox7.Text = m.ToString();
            }
        }

        // YENİ EKLEDİĞİMİZ AKILLI BİRİM DÖNÜŞTÜRÜCÜSÜ
        // Sağ taraftaki piko, nano, mikro, mili, kilo, mega, giga, tera butonlarının tamamını
        // tasarım ekranından (Events -> Click) bu metoda bağlıyoruz.
        private void BirimDonustur_Click(object sender, EventArgs e)
        {
            // Ana Ohm sonucu (textBox7) boşsa işlem yapma
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Lütfen önce renkleri seçip Hesapla butonuna basın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tıklanan butonu yakalıyoruz
            Button tiklananButon = (Button)sender;

            //  textBox7'deki ana Ohm değerini double (ondalıklı) olarak alıyoruz
            double anaOhm = Convert.ToDouble(textBox7.Text);
            double donusenSonuc = 0;

            // BUTONUN METNİNE (TEXT) GÖRE KESİN MATEMATİKSEL HESAPLAMA
            // Butonunun üzerinde ne yazıyorsa ona göre doğru işlemi yapıyoruz.
            switch (tiklananButon.Text.ToLower().Trim())
            {
                // Üst birimleri Ohm değeriyle ilgili sayıya bölüyoruz
                case "kilo":
                    donusenSonuc = anaOhm / 1000.0;
                    break;
                case "mega":
                    donusenSonuc = anaOhm / 1000000.0;
                    break;
                case "giga":
                    donusenSonuc = anaOhm / 1000000000.0;
                    break;
                case "tera":
                    donusenSonuc = anaOhm / 1000000000000.0;
                    break;

                // Alt birimleri Ohm değeriyle ilgili sayıyla çarpıyoruz
                case "mili":
                    donusenSonuc = anaOhm * 1000.0;
                    break;
                case "mikro":
                    donusenSonuc = anaOhm * 1000000.0;
                    break;
                case "nano":
                    donusenSonuc = anaOhm * 1000000000.0;
                    break;
                case "piko":
                    donusenSonuc = anaOhm * 1000000000000.0;
                    break;

                default:
                    donusenSonuc = anaOhm;
                    break;
            }

            // "0.###########" kullanarak sıfırların yutulmasını engelliyoruz ve küsuratları net gösteriyoruz.
            textBox8.Text = donusenSonuc.ToString("0.###########");

            // 6. Label9 alanını güncelle
            label9.Text = tiklananButon.Text.ToUpper() + " Cinsinden Sonuç:";
        }
    }
}
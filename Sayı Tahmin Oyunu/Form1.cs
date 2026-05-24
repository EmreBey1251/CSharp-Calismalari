using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_7
{
    public partial class Form1 : Form
    {
        int sayi;
        int hak = 3;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = random.Next(1, 11); // 1-10 arası sayı tutar
            label1.Text = "1 ile 10 arasında bir sayı tahmin edin.\nToplam 3 hakkınız var."; 
            textBox1.Focus();
        }

        // Tahmin Et Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Giriş Kontrolü
                if (!int.TryParse(textBox1.Text, out int tahmin))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
                    return;
                }

                // Aralık Kontrolü
                if (tahmin < 1 || tahmin > 10)
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir sayı tahmin edin!");
                    return;
                }

                if (tahmin == sayi)
                {
                    MessageBox.Show("Tebrikler! Doğru bildiniz. 🎉");

                    // Programı Kapat
                    Application.Exit();
                }
                else
                {
                    hak--; // Hakkı azalt

                    if (hak > 0)
                    {
                        textBox1.Clear();
                        textBox1.Focus();

                        if (tahmin < sayi)
                        {
                            label1.Text = $"İpucu: Daha BÜYÜK bir sayı gir!\nKalan Hakkınız: {hak}"; //
                        }
                        else
                        {
                            label1.Text = $"İpucu: Daha KÜÇÜK bir sayı gir!\nKalan Hakkınız: {hak}"; //
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Hakkınız bitti! Oyunu kaybettiniz. 😢\nTuttuğum sayı şuydu: {sayi}");

                        // Programı Kapat
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
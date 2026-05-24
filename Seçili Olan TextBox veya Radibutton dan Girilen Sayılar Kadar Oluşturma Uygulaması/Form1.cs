using System;
using System.Drawing;
using System.Windows.Forms;

namespace SeciliElemanUretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Seçilen tipe göre girilen adet kadar dinamik kontrol üretir.
        /// Her yeni üretimde eski dinamik elemanları otomatik temizler.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni üretim başlamadan önce formda daha önce üretilmiş elemanları temizliyoruz
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Tag?.ToString() == "DinamikUretilen")
                {
                    this.Controls.RemoveAt(i);
                }
            }

            // Sayı dışında bir şey girilmiş mi veya geçersiz bir sayı mı girilmiş kontrolü
            if (!int.TryParse(textBox1.Text, out int sutunAdet) ||
                !int.TryParse(textBox2.Text, out int satirAdet) ||
                sutunAdet <= 0 ||
                satirAdet <= 0)
            {
                MessageBox.Show("Lütfen sıfırdan büyük, geçerli bir sayısal değer girin!", "Geçersiz Girdi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // İç içe döngüyle matris düzeninde kontrolleri oluşturuyoruz
            for (int i = 0; i < sutunAdet; i++)
            {
                for (int j = 0; j < satirAdet; j++)
                {
                    Control yeniKontrol;

                    // Hangi kontrolün seçildiğini tam ad alanı belirterek tespit ediyoruz
                    if (radioButton1.Checked)
                    {
                        yeniKontrol = new System.Windows.Forms.RadioButton { Text = $"Radio {i},{j}" };
                    }
                    else if (radioButton2.Checked)
                    {
                        yeniKontrol = new System.Windows.Forms.TextBox { Text = $"Text {i},{j}" };
                    }
                    else
                    {
                        MessageBox.Show("Lütfen üretilecek kontrol tipini seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Kontrolün ortak özelliklerini ve konumunu ayarlıyoruz
                    yeniKontrol.Width = 100;
                    yeniKontrol.Height = 25;
                    yeniKontrol.Location = new Point(50 + (i * 120), 100 + (j * 35));

                    // Sonradan temizlenebilmesi için imzayı basıyoruz
                    yeniKontrol.Tag = "DinamikUretilen";

                    this.Controls.Add(yeniKontrol);
                }
            }
        }

        // Temizle butonu ile istendiğinde manuel olarak tüm dinamik elemanları formdan silebiliriz
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Tag?.ToString() == "DinamikUretilen")
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }
    }
}
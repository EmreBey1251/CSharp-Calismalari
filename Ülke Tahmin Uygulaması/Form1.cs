using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ülke_bilmece
{
    public partial class Form1 : Form
    {
        // Soru yapısını tutacak modern bir model tanımlıyoruz
        public class Soru
        {
            public int ResimIndex { get; set; }
            public string[] Siklar { get; set; }
            public string DogruCevap { get; set; }
        }

        private List<Soru> sorular = new List<Soru>();
        private int mevcutSoruIndex = 0;
        private int puan = 0;

        public Form1()
        {
            InitializeComponent();
            SorulariHazirla();
            SoruYukle(mevcutSoruIndex);
        }

        // Tüm soruları, şıkları ve doğru cevapları tek bir merkezde topluyoruz
        private void SorulariHazirla()
        {
            sorular.Add(new Soru
            {
                ResimIndex = 0,
                Siklar = new string[] { "İstanbul", "İzmir", "Ankara", "Adana" },
                DogruCevap = "Ankara"
            });

            sorular.Add(new Soru
            {
                ResimIndex = 1,
                Siklar = new string[] { "Köln", "Frankfurt", "Stutgart", "Berlin" },
                DogruCevap = "Berlin"
            });

            sorular.Add(new Soru
            {
                ResimIndex = 2,
                Siklar = new string[] { "Kahire", "Pimyat", "İskenderiye", "Süveyş" },
                DogruCevap = "Kahire"
            });

            sorular.Add(new Soru
            {
                ResimIndex = 3,
                Siklar = new string[] { "Lyon", "Paris", "Marseille", "Nice" },
                DogruCevap = "Paris"
            });
        }

        // Aktif soru indeksine göre arayüzü günceller
        private void SoruYukle(int index)
        {
            if (index < sorular.Count)
            {
                var aktifSoru = sorular[index];
                pictureBox1.BackgroundImage = ımageList1.Images[aktifSoru.ResimIndex];

                button1.Text = aktifSoru.Siklar[0];
                button2.Text = aktifSoru.Siklar[1];
                button3.Text = aktifSoru.Siklar[2];
                button4.Text = aktifSoru.Siklar[3];

                // Şık butonlarını tekrar aktif et
                ButonlariAktifEt(true);
            }
        }

        /// Şıklara tıklandığında çalışacak ortak kontrol metodu
        private void CevapKontrolEt(Button secilenButon)
        {
            var aktifSoru = sorular[mevcutSoruIndex];

            if (secilenButon.Text == aktifSoru.DogruCevap)
            {
                MessageBox.Show("Doğru cevap! 🎉", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puan += 10;
            }
            else
            {
                MessageBox.Show($"Yanlış cevap! Doğru cevap: {aktifSoru.DogruCevap}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            label3.Text = puan.ToString(); // Puanı yazdır
            ButonlariAktifEt(false); // Soru geçilene kadar tekrar tıklanmasın
        }

        // Şık Butonlarının Click Olayları
        private void button1_Click(object sender, EventArgs e) => CevapKontrolEt(button1);
        private void button2_Click(object sender, EventArgs e) => CevapKontrolEt(button2);
        private void button3_Click(object sender, EventArgs e) => CevapKontrolEt(button3);
        private void button4_Click(object sender, EventArgs e) => CevapKontrolEt(button4);

        // "Sonraki" Butonu 
        private void button5_Click(object sender, EventArgs e)
        {
            mevcutSoruIndex++;

            // Oyun bitti mi kontrolü
            if (mevcutSoruIndex >= sorular.Count)
            {
                MessageBox.Show($"Oyun Bitti! Toplam Puanınız: {puan}", "Oyun Sonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu tamamen kapatır
            }
            else
            {
                SoruYukle(mevcutSoruIndex);
            }
        }

        private void ButonlariAktifEt(bool durum)
        {
            button1.Enabled = durum;
            button2.Enabled = durum;
            button3.Enabled = durum;
            button4.Enabled = durum;
        }
    }
}
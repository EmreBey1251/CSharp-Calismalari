using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        // Üretilen doğru cevabı 'button2_Click' altında da okuyabilmek için değişkeni sınıf seviyesinde tanımlıyoruz.
        string dogruCevap = "";

        // Belirtilen adette butonu forma ekler
        void btnolustur(int adet)
        {
            // Form elemanlarının altına binmemesi için başlangıç y değeri 80 olarak ayarlanmıştır.
            int konx = 10, kony = 80;

            // Döngü dışında 1 ile 'adet' arasında TEK BİR şanslı sayı seçilir.
            // Böylece 100 buton içinde sadece ve sadece 1 tane küçük "x" bulunması garanti edilir.
            int sansliSayi = rnd.Next(1, adet + 1);

            for (int i = 1; i <= adet; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString(); 
                btn.Size = new Size(50, 50); 
                btn.Location = new Point(konx, kony); // Hesaplanan koordinata yerleştirme
                konx += 50; // Bir sonraki buton için x ekseninde kaydırma

                // Mevcut butonun indeksi, şanslı sayı ile eşleşiyor mu?
                if (sansliSayi == i)
                {
                    btn.Text = "x" + i.ToString(); // Doğru butona küçük "x" yazılır
                    dogruCevap = btn.Text; // Doğru string değeri hafızaya alınır
                }
                else
                {
                    btn.Text = "X" + i.ToString(); // Diğer tüm butonlara büyük "X" yazılır
                }

                // Her 10 butonda bir alt satıra geçiş kontrolü
                if (i % 10 == 0)
                {
                    konx = 10; // x ekseni başa sarar
                    kony += 50; // y ekseni bir buton boyu aşağı indirilir
                }

                // Dinamik olarak türetilen buton Form bileşenlerine eklenir
                this.Controls.Add(btn);
            }
        }

        // OLUŞTUR BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            btnolustur(100);
        }

        // KONTROL ET BUTONU
        private void button2_Click(object sender, EventArgs e)
        {
            string tahmin = textBox1.Text;

            // Boş Değer Kontrolü
            if (string.IsNullOrEmpty(tahmin))
            {
                MessageBox.Show("Lütfen önce bir tahmin giriniz! (Örn: x45)");
                return;
            }

            // DOĞRULAMA ALGORİTMASI
            if (tahmin == dogruCevap)
            {
                MessageBox.Show("Doğru bildin!"); // Kullanıcıya başarı mesajı gösterilir
                Application.Exit(); // Başarılı eşleşme sonrası uygulamayı tamamen kapatır
            }
            else
            {
                // Başarısız eşleşme durumunda kullanıcıya bilgilendirme mesajı verilir
                MessageBox.Show("Yanlış tahmin! Doğru cevap: " + dogruCevap + " olmalıydı.");
            }
        }
    }
}
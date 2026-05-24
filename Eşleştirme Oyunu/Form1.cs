using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eşleştirme_oyunu
{
    public partial class Form1 : Form
    {
        // Durum Yönetimi ve Veri Yapıları
        static int[] sayi = new int[20];
        static int tik_say = 0;
        static PictureBox bir = new PictureBox();
        static PictureBox iki = new PictureBox();
        static int bilinen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Resimlere tıkladığında çalışacak event
        private void Resim_Click(object sender, EventArgs e)
        {
            PictureBox tekresim = (PictureBox)sender;
            int tiklamasirasi = (int)tekresim.Tag;

            // Tıklanan resmi açıyoruz
            tekresim.Image = ımageList1.Images[sayi[tiklamasirasi]];

            if (tik_say == 0)
            {
                // Birinci karta tıklandı
                bir = tekresim;
                bir.Click -= Resim_Click; // Aynı karta tekrar tıklanmasını önle
                tik_say = 1;
            }
            else if (tik_say == 1)
            {
                // İkinci karta tıklandı
                iki = tekresim;

                // Formun anlık olarak resmi çizmesini sağlıyoruz (Görsel gecikmeyi önler)
                iki.Refresh();
                System.Threading.Thread.Sleep(500); // Kullanıcı kartı görsün diye yarım saniye bekletme

                // Eşleşme Kotrolü
                if (sayi[(int)bir.Tag] == sayi[(int)iki.Tag])
                {
                    // Doğru eşleşme olduğunda kartları kalıcı olarak kapat 
                    bir.Image = ımageList1.Images[11];
                    bir.Click -= Resim_Click;

                    iki.Image = ımageList1.Images[11];
                    iki.Click -= Resim_Click;

                    bilinen++;
                }
                else
                {
                    // Yanlış eşleşme olduğunda kartları eski haline (arkasına) döndür
                    bir.Image = ımageList1.Images[0];
                    iki.Image = ımageList1.Images[0];

                    bir.Click += Resim_Click; // Tıklama özelliğini geri ver
                }

                // Tur bitti, tıklama sayacını sıfırla
                tik_say = 0;
            }

            // Oyun Bitti Kontrolü
            if (bilinen == 10)
            {
                MessageBox.Show("Tebrikler bitirdiniz!!!", "Oyun Bitti");
                Application.Exit(); // İstediğin gibi oyun başarılı mesajından sonra programı kapatır.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Diziyi sıfırlama
            for (int i = 0; i < 20; i++) { sayi[i] = 0; }

            // Random nesnesini döngünün dışına aldık
            Random r = new Random();

            // 10 çift resmi 20 boşluğa rastgele dağıtma
            for (int x = 1; x <= 10; x++)
            {
                int sayac = 0;
                do
                {
                    int s = r.Next(0, 20);
                    if (sayi[s] == 0)
                    {
                        sayi[s] = x;
                        sayac++;
                    }
                    if (sayac == 2) break;
                } while (true);
            }

            // Tasarım ve Dinamik UI Oluşturma
            this.Size = new Size(650, 750);
            this.Location = new Point(0, 0);
            int h = 0;
            for (int i = 0; i < 20; i++)
            {
                PictureBox resim = new PictureBox();
                resim.Name = "r" + i;
                resim.Size = new Size(125, 175);
                resim.SizeMode = PictureBoxSizeMode.StretchImage; // Resimleri tam sığdırmak için

                if (i % 5 == 0) h++;
                resim.Location = new Point((i % 5) * 126, (h - 1) * 176);
                resim.Image = ımageList1.Images[0]; // Kartın kapalı yüzü
                resim.Tag = i;
                resim.Click += Resim_Click;
                this.Controls.Add(resim);
            }
        }
    }
}
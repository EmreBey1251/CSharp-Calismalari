using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        // Kart sınırları ve oyun takibi için diziler 
        private PictureBox[] oyuncuKutulari;
        private PictureBox[] bilgisayarKutulari;
        private Label[] oyuncuLabelListesi;
        private Label[] bilgisayarLabelListesi;

        private int oyuncuKartSayaci = 0;
        private int bilgisayarKartSayaci = 0;

        private int oyuncuToplamSkor = 0;
        private int bilgisayarToplamSkor = 0;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            DiziElemanlariniBagla();
        }

        // Form üzerindeki nesneleri index ile yönetebilmek için dizilere topluyoruz
        private void DiziElemanlariniBagla()
        {
            oyuncuKutulari = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            bilgisayarKutulari = new PictureBox[] { pictureBox5, pictureBox6, pictureBox7, pictureBox8 };

            oyuncuLabelListesi = new Label[] { label3, label4, label5, label6 };
            bilgisayarLabelListesi = new Label[] { label9, label10, label11, label12 };
        }

        // Oyuncu Kart Çek Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            // 4 kart sınırını burası zaten kusursuz koruyor
            if (oyuncuKartSayaci >= 4)
            {
                MessageBox.Show("Maksimum kart sınırına ulaştınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int kartDegeri = KartCekVeYazdir(oyuncuKutulari[oyuncuKartSayaci], oyuncuLabelListesi[oyuncuKartSayaci]);
            oyuncuToplamSkor += kartDegeri;

            label7.Text = oyuncuToplamSkor.ToString(); 
            oyuncuKartSayaci++;
        }

        // Bilgisayar Kart Çek Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (bilgisayarKartSayaci >= 4)
            {
                MessageBox.Show("Bilgisayar maksimum kart sınırına ulaştınız!", "Bilgi");
                return;
            }

            int kartDegeri = KartCekVeYazdir(bilgisayarKutulari[bilgisayarKartSayaci], bilgisayarLabelListesi[bilgisayarKartSayaci]);
            bilgisayarToplamSkor += kartDegeri;

            label8.Text = bilgisayarToplamSkor.ToString(); 
            bilgisayarKartSayaci++;
        }

        // Kazanan Blackjack kurallarına göre belirlenir
        private void button3_Click(object sender, EventArgs e)
        {
            // Oyuncu pas dediğinde bilgisayarın skoru 17'den küçükse otomatik risk alıp kart çeksin
            while (bilgisayarToplamSkor < 17 && bilgisayarKartSayaci < 4)
            {
                int kartDegeri = KartCekVeYazdir(bilgisayarKutulari[bilgisayarKartSayaci], bilgisayarLabelListesi[bilgisayarKartSayaci]);
                bilgisayarToplamSkor += kartDegeri;
                label8.Text = bilgisayarToplamSkor.ToString();
                bilgisayarKartSayaci++;
            }

            // Kazanma / Kaybetme Mantık Kombinasyonları
            if (oyuncuToplamSkor > 21 && bilgisayarToplamSkor > 21)
            {
                MessageBox.Show("İki taraf da 21'i geçti! Berabere.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (oyuncuToplamSkor > 21)
            {
                MessageBox.Show("21'i geçtiniz. Kaybettiniz!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bilgisayarToplamSkor > 21)
            {
                MessageBox.Show("Bilgisayar 21'i geçti. KAZANDINIZ! 🎉", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // İki taraf da 21 veya altındaysa skora bakılır
                if (oyuncuToplamSkor > bilgisayarToplamSkor)
                {
                    MessageBox.Show("Daha yüksek skora sahipsiniz. KAZANDINIZ! 🎉", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (bilgisayarToplamSkor > oyuncuToplamSkor)
                {
                    MessageBox.Show("Bilgisayarın skoru daha yüksek. Kaybettiniz!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Skorlar eşit! Berabere.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
        private int KartCekVeYazdir(PictureBox pBox, Label lbl)
        {
            // Üst sınırı 9 yapıyoruz; böylece 0 ile 8 dahil arasında sayı üretir 
            int rastgeleIndex = rnd.Next(0, 9);

            // İndeks taşması imkansız hale getirdik
            pBox.Image = ımageList1.Images[rastgeleIndex];

            // İlk kart 2 değerini alır, son kart 10 değerini alır
            int oyunDegeri = rastgeleIndex + 2;

            lbl.Text = oyunDegeri.ToString();

            return oyunDegeri;
        }

    }
}
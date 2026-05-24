using System;
using System.Drawing;
using System.Windows.Forms;

namespace mayin_tarlasi
{
    public partial class Form1 : Form
    {
        // Oyun Ayarları
        private const int Satir_Sayisi = 10;
        private const int SutunSayisi = 10;
        private const int ToplamMayin = 15; // 100 butonun 15'i mayın olsun
        private const int ButtonBoyutu = 40; // Butonların kare boyutu 

        // Oyun Değişkenleri
        private Button[,] butonlar = new Button[Satir_Sayisi, SutunSayisi];
        private bool[,] mayinlar = new bool[Satir_Sayisi, SutunSayisi];

        public Form1()
        {
            InitializeComponent();
            OyunAlaniniKur();
            MayinlariYerlestir();
        }

        // 100 tane butonu döngüyle dinamik olarak forma ekler ve konumlandırır
        private void OyunAlaniniKur()
        {
            // Formun boyutlarını buton sayısına göre otomatik ayarla
            this.ClientSize = new Size(SutunSayisi * ButtonBoyutu + 20, Satir_Sayisi * ButtonBoyutu + 20);
            this.Text = "Mayın Tarlası Pro";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            for (int x = 0; x < Satir_Sayisi; x++)
            {
                for (int y = 0; y < SutunSayisi; y++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(ButtonBoyutu, ButtonBoyutu),
                        Location = new Point(y * ButtonBoyutu + 10, x * ButtonBoyutu + 10),
                        Tag = new Point(x, y), // Butonun koordinatlarını Tag içinde saklıyoruz
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        BackColor = Color.LightGray
                    };

                    // Her butonun tıklama olayını aynı metoda bağlıyoruz
                    btn.Click += Buton_Click;

                    butonlar[x, y] = btn;
                    this.Controls.Add(btn);
                }
            }
        }

        // Rastgele koordinatlara belirlenen sayıda mayın yerleştirir
        private void MayinlariYerlestir()
        {
            Random rnd = new Random();
            int yerlestirilenMayin = 0;

            while (yerlestirilenMayin < ToplamMayin)
            {
                int x = rnd.Next(Satir_Sayisi);
                int y = rnd.Next(SutunSayisi);

                // Eğer o koordinatta zaten mayın yoksa yerleştir
                if (!mayinlar[x, y])
                {
                    mayinlar[x, y] = true;
                    yerlestirilenMayin++;
                }
            }
        }

        /// Herhangi bir butona tıklandığında çalışacak ortak metot
        private void Buton_Click(object sender, EventArgs e)
        {
            if (sender is Button tiklananButon)
            {
                Point koordinat = (Point)tiklananButon.Tag;
                int x = koordinat.X;
                int y = koordinat.Y;

                // Mayına bastı mı kontrolü
                if (mayinlar[x, y])
                {
                    tiklananButon.BackColor = Color.Red;
                    tiklananButon.Text = "💣";
                    TumMayinlariGoster();
                    MessageBox.Show("Mayına bastınız! Oyun bitti.", "Kaybettiniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    OyunSifirla();
                }
                else
                {
                    // Mayın yoksa etrafındaki mayın sayısını hesapla
                    int etraftakiMayinlar = EtraftakiMayinlariSay(x, y);
                    tiklananButon.Enabled = false; // Tekrar tıklanmasın
                    tiklananButon.BackColor = Color.White;

                    if (etraftakiMayinlar > 0)
                    {
                        tiklananButon.Text = etraftakiMayinlar.ToString();
                        tiklananButon.ForeColor = AlArkaPlanRengi(etraftakiMayinlar);
                    }
                }
            }
        }

        // Tıklanan butonun etrafındaki 8 karede kaç mayın olduğunu hesaplar
        private int EtraftakiMayinlariSay(int satir, int sutun)
        {
            int sayac = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int yeniSatir = satir + i;
                    int yeniSutun = sutun + j;

                    // Form sınırları dışına çıkmayı engelle
                    if (yeniSatir >= 0 && yeniSatir < Satir_Sayisi && yeniSutun >= 0 && yeniSutun < SutunSayisi)
                    {
                        if (mayinlar[yeniSatir, yeniSutun])
                        {
                            sayac++;
                        }
                    }
                }
            }
            return sayac;
        }

        private void TumMayinlariGoster()
        {
            for (int i = 0; i < Satir_Sayisi; i++)
            {
                for (int j = 0; j < SutunSayisi; j++)
                {
                    if (mayinlar[i, j])
                    {
                        butonlar[i, j].BackColor = Color.Red;
                        butonlar[i, j].Text = "💣"; //Yapay zekaya oluşturttum
                    }
                }
            }
        }

        private void OyunSifirla()
        {
            for (int i = 0; i < Satir_Sayisi; i++)
            {
                for (int j = 0; j < SutunSayisi; j++)
                {
                    butonlar[i, j].Enabled = true;
                    butonlar[i, j].Text = "";
                    butonlar[i, j].BackColor = Color.LightGray;
                    mayinlar[i, j] = false;
                }
            }
            MayinlariYerlestir();
        }

        private Color AlArkaPlanRengi(int mayinSayisi)
        {
            switch (mayinSayisi)
            {
                case 1: return Color.Blue;
                case 2: return Color.Green;
                case 3: return Color.Red;
                default: return Color.DarkCyan;
            }
        }
    }
}
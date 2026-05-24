using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<int> sayilar = new List<int>();
        Dictionary<int, int> sayiSayilari = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sutunAraligi = 75;
            int satirAraligi = 75;
            int dugmeGenislik = 50;
            int dugmeYukseklik = 50;
            int yatayDugmeSayisi = 10;
            int dikeyDugmeSayisi = 10;
            Random rnd = new Random();
            this.Controls.Clear();
            sayilar.Clear();
            sayiSayilari.Clear();
            listBox1.Items.Clear();
            for (int i = 0; i < dikeyDugmeSayisi; i++)
            {
                for (int j = 0; j < yatayDugmeSayisi; j++)
                {
                    int sayi = rnd.Next(0, 50);
                    Button yeniDugme = new Button();
                    yeniDugme.Text = sayi.ToString();
                    yeniDugme.Width = dugmeGenislik;
                    yeniDugme.Height = dugmeYukseklik;
                    yeniDugme.Location = new Point(j * sutunAraligi, i * satirAraligi);
                    this.Controls.Add(yeniDugme);
                    sayilar.Add(sayi);
                    if (sayiSayilari.ContainsKey(sayi))
                        sayiSayilari[sayi]++;
                    else
                        sayiSayilari[sayi] = 1;
                }
            }

            foreach (var item in sayiSayilari)
            {
                listBox1.Items.Add($"Sayı: {item.Key} - Adet: {item.Value}");
            }


            this.Width = (yatayDugmeSayisi * sutunAraligi) + 50;
            this.Height = (dikeyDugmeSayisi * satirAraligi) + 150;

            if (!this.Controls.Contains(listBox1))
            {
                listBox1.Location = new Point(800, (dikeyDugmeSayisi * satirAraligi) + -700);
                listBox1.Size = new Size(100, 600);
                this.Controls.Add(listBox1);
            }
        }
    }
}

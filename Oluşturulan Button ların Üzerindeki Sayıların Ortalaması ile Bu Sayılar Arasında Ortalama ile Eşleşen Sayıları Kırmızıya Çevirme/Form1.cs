using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            // Sayı dışı karakter kontrolü
            int a, b;
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Lütfen sadece geçerli tam sayılar giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Maksimum 10x10 matris kontrolü
            if (a > 10 || b > 10 || a <= 0 || b <= 0)
            {
                MessageBox.Show("Satır ve sütun değerleri 1 ile 10 arasında olmalıdır (Maksimum 10x10)!", "Boyut Sınırı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Eski butonları temizleme
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Button && this.Controls[i].Name != "button1")
                {
                    this.Controls.RemoveAt(i);
                }
            }

            int konx = 10;
            int kony = 120;

            int toplamButonSayisi = a * b;
            double toplam = 0;

            List<Button> olusturulanButonlar = new List<Button>();

            // Butonları oluşturma
            for (int i = 1; i <= toplamButonSayisi; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Size = new Size(50, 50);
                btn.Location = new Point(konx, kony);

                int rastgeleSayi = rnd.Next(1, toplamButonSayisi + 1);
                btn.Text = rastgeleSayi.ToString();

                toplam += rastgeleSayi;

                konx += 50;
                if (i % b == 0)
                {
                    konx = 10;
                    kony += 50;
                }

                this.Controls.Add(btn);
                olusturulanButonlar.Add(btn);
            }

            // Net ortalamayı bulma
            if (toplamButonSayisi > 0)
            {
                // Gerçek matematiksel ortalamayı buluyoruz. (Örn: 5.43)
                double gercekOrtalama = toplam / toplamButonSayisi;

                // Butonların içindeki sayılardan, gerçek ortalamaya EN YAKIN olan tam sayıyı seçiyoruz.
                //  Böylece havada asılı değer kalmıyor.
                Button hedefButon = olusturulanButonlar[0];
                double enKucukFark = Math.Abs(Convert.ToDouble(hedefButon.Text) - gercekOrtalama);

                foreach (Button gelenButon in olusturulanButonlar)
                {
                    double fark = Math.Abs(Convert.ToDouble(gelenButon.Text) - gercekOrtalama);
                    if (fark < enKucukFark)
                    {
                        enKucukFark = fark;
                        hedefButon = gelenButon;
                    }
                }

                int netTamSayiOrtalama = Convert.ToInt32(hedefButon.Text);

                // TextBox a bu tam sayıyı yazıyoruz.
                textBox3.Text = netTamSayiOrtalama.ToString();

                // Değeri bu sayıya eşit olan tüm butonları KIRMIZI yap.
                // Eğer aynı sayıdan birden fazla varsa hepsi kırmızı olur.
                foreach (Button gelenButon in olusturulanButonlar)
                {
                    if (Convert.ToInt32(gelenButon.Text) == netTamSayiOrtalama)
                    {
                        gelenButon.BackColor = Color.Red;
                        gelenButon.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
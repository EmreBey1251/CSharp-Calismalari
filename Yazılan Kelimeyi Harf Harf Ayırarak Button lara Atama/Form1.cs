using System;
using System.Drawing;
using System.Windows.Forms;

namespace butonların_textini_değiştiren_kod
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
            string ifade = textBox1.Text;

            if (string.IsNullOrEmpty(ifade))
            {
                MessageBox.Show("Lütfen bir kelime girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ekrana her tıklandığında eski oluşturulan butonlar üst üste binmesin diye formun içini temizleyelim
            // (textBox1 ve button1 hariç)
            for (int x = this.Controls.Count - 1; x >= 0; x--) //Formdaki eleman sayısından 0'a doğru azalarak ihtiyacımız dışındaki her şeyi siliyor
            {
                if (this.Controls[x].Name != "button1" && this.Controls[x].Name != "textBox1")
                {
                    this.Controls.RemoveAt(x);
                }
            }

            // Döngü başlıyor
            for (int i = 0; i < ifade.Length; i++)
            {
                Button yeniButon = new Button();
                yeniButon.Name = "dug" + i; // Butonlara isim veriyoruz (dug0, dug1, dug2)
                yeniButon.Width = 60;
                yeniButon.Height = 60;

                // Konumlandırma
                yeniButon.Location = new Point(50 + (i * (yeniButon.Width + 10)), 120);

                // Harf parçalama kısmı: Kelimenin i. indeksindeki 1 adet harfi alır
                yeniButon.Text = ifade.Substring(i, 1).ToUpper(); // Harfi büyük yapar

                // Tamamen rastgele renk ataması
                yeniButon.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                yeniButon.ForeColor = Color.White; // Harfler renkli arka planda net okunsun diye beyaz yaptık
                yeniButon.Font = new Font("Arial", 14, FontStyle.Bold); // Yazıyı kalınlaştırdık

                // Butonu formun içine canlı olarak fırlatıyoruz!
                Controls.Add(yeniButon);
            }
        }
    }
}
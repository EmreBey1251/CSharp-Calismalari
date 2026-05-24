using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeciliElemaniGetirenSey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. ADIM: Her yeni üretimde eski dinamik elemanları temizle (Form kasmaya başlamasın)
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].Tag?.ToString() == "DinamikEleman")
                {
                    this.Controls.RemoveAt(i);
                }
            }

            // 2. ADIM: Girdi kontrolü ve hata yönetimi
            if (!int.TryParse(textBox1.Text, out int adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Standart kontrol boyutları (Okunabilir ve sığacak şekilde ayarladık)
            int controlGenislik = 120;
            int controlYukseklik = 25;

            int baslangicX = 30;
            int baslangicY = 150; // Yukarıdaki buton ve radiobutton'ların altına inmesi için
            int dikeyAralik = 35;
            int yatayAralik = 140;

            int maksimumSatir = 8; // Bir sütunda en fazla kaç eleman alt alta gelsin?

            // 3. ADIM: Tek bir döngü ile girilen adet kadar eleman üretme
            for (int i = 0; i < adet; i++)
            {
                Control yeniKontrol;

                // Seçili türe göre nesne örneği (Instance) oluşturma
                if (radioButton1.Checked)
                {
                    yeniKontrol = new System.Windows.Forms.RadioButton { Text = $"Radio {i + 1}" };
                }
                else if (radioButton2.Checked)
                {
                    yeniKontrol = new System.Windows.Forms.Button { Text = $"Button {i + 1}", BackColor = Color.LightGray };
                }
                else if (radioButton3.Checked)
                {
                    yeniKontrol = new System.Windows.Forms.CheckBox { Text = $"Check {i + 1}" };
                }
                else if (radioButton4.Checked)
                {
                    yeniKontrol = new System.Windows.Forms.TextBox { Text = $"Text {i + 1}" };
                }
                else
                {
                    MessageBox.Show("Lütfen bir kontrol tipi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Matris tipi konumlandırma hesabı (Elemanlar çok olunca yana doğru yeni sütun açar)
                int sutunIndeks = i / maksimumSatir;
                int satirIndeks = i % maksimumSatir;

                int posX = baslangicX + (sutunIndeks * yatayAralik);
                int posY = baslangicY + (satirIndeks * dikeyAralik);

                yeniKontrol.Location = new Point(posX, posY);
                yeniKontrol.Width = controlGenislik;
                yeniKontrol.Height = controlYukseklik;
                yeniKontrol.Tag = "DinamikEleman"; // Temizleme imzası

                this.Controls.Add(yeniKontrol);
            }

            // 4. ADIM: Formun boyutunu üretilen sütun sayısına göre dinamik ve akıllıca esnetme
            int toplamSutun_Sayisi = ((adet - 1) / maksimumSatir) + 1;
            this.Width = Math.Max(500, baslangicX + (toplamSutun_Sayisi * yatayAralik) + 50);
            this.Height = Math.Max(400, baslangicY + (Math.Min(adet, maksimumSatir) * dikeyAralik) + 60);
        }
    }
}

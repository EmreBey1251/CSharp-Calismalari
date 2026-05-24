using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "Boş koltuk sayısı:" + salon.bosKOLTUKSAYİSİ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonBakiye.Enabled = false;
            buttonBosKoltuk.Enabled = false;
            buttonSat.Enabled = false;
            buttonİptal.Enabled = false;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            güncelle();
        }
        void güncelle()
        {
            salon.fiyat(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

        }

        private void buttonSat_Click(object sender, EventArgs e)
        {
            if (salon.bosKOLTUKSAYİSİ() <= 0)
            {
                string mesaj = "Tüm koltuklar dolu, biletler bitti.";
                MessageBox.Show(mesaj);
            }
            else
            {
                salon.biletSat(checkBox1.Checked);
                label5.Text = "Bilet satıldı. Kalan koltuk sayısı:"+ salon.bosKOLTUKSAYİSİ();
            }
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            salon.biletİptal(checkBox1.Checked);
            label5.Text = "Bilet iptal edildi. Kalan koltuk sayısı:" + salon.bosKOLTUKSAYİSİ();
        }

        private void buttonBakiye_Click(object sender, EventArgs e)
        {
            label5.Text = "Şu anki bakiye:" + salon.Bakiye()+"TL";
        }
        Sinema salon;
        private void button2_Click(object sender, EventArgs e)
        {
            olustur();
        }
        void olustur()
        {
            try
            {
                salon = new Sinema(textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label5.Text = "Salon oluşturuldu. Koltuk sayısı:" + salon.bosKOLTUKSAYİSİ();
                buttonBakiye.Enabled = true;
                buttonBosKoltuk.Enabled = true;
                buttonSat.Enabled = true;
                buttonİptal.Enabled = true;
            }
            catch
            {
                label5.Text = "SAlon oluşturulamadı. Bilgileri kontrol edin.";
            }
        }
    }
}

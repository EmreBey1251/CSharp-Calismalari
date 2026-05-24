using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba_2
{
    public partial class Form1 : Form
    {
        private araba benimArabam;
        
        public Form1()
        {
            InitializeComponent();
            benimArabam = new araba("Ford", "Transit", 1500);
            GuncelleDurum("Uygulama başlatıldı.");
        }
        private void GuncelleDurum(string mesaj)
        {
            label1.Text = $"{mesaj}\n\n" +
                $"Marka: {benimArabam.Marka}, Model: {benimArabam.Model}\n"+
                $"Anlık Hız: {benimArabam.AnlikHiz} km/h\n" +
                $"Durum: {(benimArabam.CalisiyorMu ? "Çalışıyor" : "Kapalı")}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.ArabayiCalistir();
            GuncelleDurum(mesaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.Hizlan(5);
            GuncelleDurum(mesaj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.Yavasla(5);
            GuncelleDurum(mesaj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.ArabayiDurdur();
            GuncelleDurum(mesaj);
        }
    }
}

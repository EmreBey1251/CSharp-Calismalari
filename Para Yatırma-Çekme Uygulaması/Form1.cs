using Microsoft.VisualBasic; // Interaction.InputBox için bu satır yukarda kesinlikle olmalı!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_11
{
    public partial class Form1 : Form
    {
        int secim = 0;

        // Başlangıç bakiyelerin
        double cebimdekiPara = 2000;
        double karttakiBakiye = 10000;

        public Form1()
        {
            InitializeComponent();
        }

        // Program ilk açıldığında çalışan alan
        private void Form1_Load(object sender, EventArgs e)
        {
            // Girişte karttaki parayı gösteren ilk pop-up ekranı
            MessageBox.Show($"Bankamıza Hoş Geldiniz!\n\nKarttaki Güncel Bakiyeniz: {karttakiBakiye} TL", "Hesap Bilgisi");

            // Cebindeki parayı formun altındaki label1'e yazdırıyoruz
            label1.Text = $"Cebindeki Para:   {cebimdekiPara}";
        }

        // BAS BUTONU (button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. İşlem tespiti
                if (radioButton1.Checked) { secim = 1; }      // Para Yatırma
                else if (radioButton2.Checked) { secim = 2; } // Para Çekme
                else { secim = 0; }

                if (secim == 0)
                {
                    MessageBox.Show("Lütfen önce yapmak istediğiniz işlemi seçin (Para Yatırma / Çekme)!");
                    return;
                }

                // 2. İŞTE O EKRAN: Miktarı almak için InputBox penceresini açıyoruz
                string input = Interaction.InputBox("Lütfen işlem yapmak istediğiniz miktarı giriniz:", "Miktar Girişi");

                // Eğer kullanıcı iptal (Cancel) tuşuna basarsa işlemi durdur
                if (string.IsNullOrEmpty(input)) return;

                // Girilen metni sayıya çeviriyoruz
                if (!double.TryParse(input, out double miktar) || miktar <= 0)
                {
                    MessageBox.Show("Lütfen geçerli ve pozitif bir miktar giriniz!");
                    return;
                }

                // 3. Hesaplama mantığı
                switch (secim)
                {
                    case 1: // PARA YATIRMA (Cebinden çıkıp karta girecek)
                        if (cebimdekiPara >= miktar)
                        {
                            cebimdekiPara -= miktar;
                            karttakiBakiye += miktar;

                            MessageBox.Show($"İşlem Başarılı!\n{miktar} TL karta yatırıldı.\nKarttaki Yeni Bakiye: {karttakiBakiye} TL");
                        }
                        else
                        {
                            MessageBox.Show("Cebinizde bu kadar nakit para bulunmuyor!");
                        }
                        break;

                    case 2: // PARA ÇEKME (Karttan çıkıp cebine girecek)
                        if (karttakiBakiye >= miktar)
                        {
                            karttakiBakiye -= miktar;
                            cebimdekiPara += miktar;

                            MessageBox.Show($"İşlem Başarılı!\n{miktar} TL karttan çekildi.\nKartta Kalan Bakiye: {karttakiBakiye} TL");
                        }
                        else
                        {
                            MessageBox.Show("Kartınızda bu kadar bakiye yok!");
                        }
                        break;
                }

                // Her işlemden sonra formdaki cebindeki para yazısını güncelliyoruz
                label1.Text = $"Cebindeki Para:   {cebimdekiPara}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
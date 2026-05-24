using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto_ayırma_hoca_off
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fotoğraf Yükle Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıya işletim sistemi seviyesinde dosya seçme penceresi açar
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true; // Pencere kapandığında en son seçilen dizini hafızada tutar
            file.CheckFileExists = false; // Hata yönetimini manuel yapmak için
            file.Title = "Excel Dosyası Seçiniz.."; // Kullanıcıyı yönlendiren pencere başlığı
            file.ShowDialog(); // Diyalog penceresini ekranda gösterir

            string DosyaYolu = file.FileName; // Seçilen dosyanın bilgisayardaki tam adresini alır
            string DosyaAdi = file.SafeFileName; // Seçilen dosyanın sadece adını ve uzantısını alır

            // Alınan dosya yolundaki görseli belleğe yükleyip pictureBox1'e basar
            pictureBox1.Image = Image.FromFile(DosyaYolu);
        }

        // Fotoğrafı Böl Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            // Yüklenen görselin orijinal genişlik (Width) ve yükseklik (Height) değerleri alınır
            int genislik = pictureBox1.Image.Width;
            int yükseklik = pictureBox1.Image.Height;

            // Sol Parça x=0, y=0 koordinatından başlayıp genişliğin yarısı kadar olan alanı keser ve pictureBox2'ye atar
            pictureBox2.Image = resmibol(0, 0, genislik / 2, yükseklik, pictureBox1.Image);

            // Sağ Parça x=genislik/2 koordinatından (ortadan) başlayıp kalan yarısını keser ve pictureBox3'e atar
            pictureBox3.Image = resmibol(genislik / 2, 0, genislik / 2, yükseklik, pictureBox1.Image);
        }

        // Gelen resmi belirtilen dikdörtgen alan ölçülerine göre klonlar
        private Bitmap resmibol(int x, int y, int en, int boy, Image gelen)
        {
            // Image nesnesini piksel tabanlı işlem yapabilmek için Bitmap'e dönüştürür
            Bitmap resim = gelen as Bitmap;

            // Kırpılacak bölgenin başlangıç koordinatlarını ve boyutlarını (x, y, width, height) belirler
            Rectangle karealan = new Rectangle(x, y, en, boy);

            // Orjinal resmin piksel formatını (RGB, ARGB vb.) koruyarak sadece seçilen alanı belleğe kopyalar
            Bitmap kesilenparca = resim.Clone(karealan, resim.PixelFormat);

            // Elde edilen dinamik alt kırpılmış görseli geri döndürür
            return kesilenparca;
        }
    }
}
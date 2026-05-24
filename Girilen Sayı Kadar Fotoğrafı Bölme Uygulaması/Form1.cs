using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto_ayırmanın_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fotoğraf Yükleme Butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                RestoreDirectory = true,
                CheckFileExists = true,
                Title = "Select an Image File...",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        // Fotoğrafı Girilen Değer Kadar Bölme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please load an image first.");
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int parca) || parca <= 0 || parca > 10)
                {
                    MessageBox.Show("Please enter a valid number between 1 and 10.");
                    return;
                }

                // Eski dinamik pictureBox ları formdan temizle
                var toRemove = this.Controls.OfType<PictureBox>().Where(pb => pb.Name.StartsWith("dynamicPictureBox")).ToList();
                foreach (var pb in toRemove)
                {
                    this.Controls.Remove(pb);
                    pb.Image?.Dispose();
                    pb.Dispose();
                }

                // Resmin kendi boyutunu alıyoruz 
                int genislik = pictureBox1.Image.Width;
                int yükseklik = pictureBox1.Image.Height;

                // Küsuratlı pikselleri önlemek için Math.Floor ile tam sayıya yuvarlıyoruz
                int parcax = (int)Math.Floor((double)genislik / parca);
                int parcay = (int)Math.Floor((double)yükseklik / parca);

                Bitmap anaResim = new Bitmap(pictureBox1.Image);

                // Sağ taraftaki parçaların ekranda güzel durması için boyutlar 35x35 kalıyor.
                int kutuEn = 35;
                int kutuBoy = 35;
                int bosluk = 5;

                int pbCounter = 0;

                for (int satir = 0; satir < parca; satir++)
                {
                    for (int sutun = 0; sutun < parca; sutun++)
                    {
                        int xKoordinati = sutun * parcax;
                        int yKoordinati = satir * parcay;

                        int gecerliEn = parcax;
                        int gecerliBoy = parcay;
                        if (xKoordinati + gecerliEn > genislik) gecerliEn = genislik - xKoordinati;
                        if (yKoordinati + gecerliBoy > yükseklik) gecerliBoy = yükseklik - yKoordinati;

                        PictureBox newPb = new PictureBox
                        {
                            Name = "dynamicPictureBox" + pbCounter,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Width = kutuEn,
                            Height = kutuBoy,

                            // pictureBox1'in tam olarak bittiği yerin yanına hizalama
                            Left = pictureBox1.Right + 10 + (sutun * (kutuEn + bosluk)),
                            Top = pictureBox1.Top + (satir * (kutuBoy + bosluk))
                        };

                        // Resmi kırpıyoruz
                        newPb.Image = resmibol(xKoordinati, yKoordinati, gecerliEn, gecerliBoy, anaResim);

                        this.Controls.Add(newPb);
                        newPb.BringToFront();

                        pbCounter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Resmi Kesen Asıl Metod
        private Bitmap resmibol(int x, int y, int en, int boy, Bitmap kaynakResim)
        {
            Rectangle kesilecekAlan = new Rectangle(x, y, en, boy);
            return kaynakResim.Clone(kesilecekAlan, kaynakResim.PixelFormat);
        }
    }
}
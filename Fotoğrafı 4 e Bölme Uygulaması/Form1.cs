using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto_ayırmanın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                RestoreDirectory = true,
                CheckFileExists = true, 
                Title = "Excel Dosyası Seçiniz.."
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                pictureBox1.Image = Image.FromFile(DosyaYolu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçiniz.");
                return;
            }

            int genislik = pictureBox1.Image.Width;
            int yükseklik = pictureBox1.Image.Height;

            pictureBox2.Image = resmibol(0, 0, genislik / 2, yükseklik / 2, pictureBox1.Image);
            pictureBox3.Image = resmibol(genislik / 2, 0, genislik / 2, yükseklik / 2, pictureBox1.Image);
            pictureBox4.Image = resmibol(0, yükseklik / 2, genislik / 2, yükseklik / 2, pictureBox1.Image);
            pictureBox5.Image = resmibol(genislik / 2, yükseklik / 2, genislik / 2, yükseklik / 2, pictureBox1.Image);
        }

        private Bitmap resmibol(int x, int y, int en, int boy, Image gelen)
        {
            Bitmap resim = gelen as Bitmap;
            Rectangle karealan = new Rectangle(x, y, en, boy);
            Bitmap kesilenparca = resim.Clone(karealan, resim.PixelFormat);
            return kesilenparca;
        }

    }
}

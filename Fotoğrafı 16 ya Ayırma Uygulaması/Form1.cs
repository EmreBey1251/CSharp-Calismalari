using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotoğraf_ayırma_4_lü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Bir Fotoğraf Seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;


                Image originalImage = Image.FromFile(filePath);

                int partWidth = originalImage.Width / 4;
                int partHeight = originalImage.Height / 4;

                PictureBox[] pictureBoxes = {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9,
                pictureBox10, pictureBox11, pictureBox12,
                pictureBox13, pictureBox14, pictureBox15,
                pictureBox16,
            };

                int index = 0;
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        Rectangle cropArea = new Rectangle(col * partWidth, row * partHeight, partWidth, partHeight);
                        Bitmap croppedImage = new Bitmap(partWidth, partHeight);
                        using (Graphics g = Graphics.FromImage(croppedImage))
                        {
                            g.DrawImage(originalImage, new Rectangle(0, 0, partWidth, partHeight), cropArea, GraphicsUnit.Pixel);
                        }

                        pictureBoxes[index].Image = croppedImage;
                        pictureBoxes[index].SizeMode = PictureBoxSizeMode.StretchImage;
                        index++;
                    }
                }

                MessageBox.Show("Fotoğraf başarıyla 16 parçaya ayrıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

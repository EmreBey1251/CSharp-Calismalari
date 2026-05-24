using System;
using System.Windows.Forms;

namespace _9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Program ilk açıldığında kafa karışıklığı olmasın diye
            // form yüklendiğinde tüm pictureBox'ları gizliyoruz
            ResimleriGizle();
        }

        // Kod tekrarını engellemek için tüm resimleri gizleyen yardımcı bir fonksiyon yazıyoruz
        private void ResimleriGizle()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        // 1. Seçenek seçildiğinde
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ResimleriGizle(); 
                pictureBox1.Visible = true; 
            }
        }

        // 2. Seçenek seçildiğinde
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ResimleriGizle();
                pictureBox2.Visible = true;
            }
        }

        // 3. Seçenek seçildiğinde
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ResimleriGizle();
                pictureBox3.Visible = true; 
            }
        }

        // 4. Seçenek seçildiğinde
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ResimleriGizle();
                pictureBox4.Visible = true; 
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace ilk_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Butona tıklandığında textBox içindeki metni label a aktarıcaz
        private void button1_Click(object sender, EventArgs e)
        {
            // Eğer TextBox boşsa varsayılan bir uyarı verelim ki kod patlak durmasın
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label1.Text = "Lütfen bir metin girin!";
            }
            else
            {
                label1.Text = textBox1.Text;
            }
        }

        // Fare butonun üzerine basılı tutulduğu sürece tetiklenicek
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Butona basılı tutuluyor...";
        }

        // Fare butondan çekildiği an tetiklenir ve eski haline döner.
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // Fare bırakıldığında eğer kutuda yazı varsa onu yazdır, yoksa S harfine geri dönücek
            label1.Text = string.IsNullOrWhiteSpace(textBox1.Text) ? "S" : textBox1.Text;
        }
    }
}
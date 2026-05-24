using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ünite_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool gecerliMi = int.TryParse(textBox1.Text, out int ortalama);

            if (!gecerliMi || ortalama < 0 || ortalama > 100)
            {
                MessageBox.Show("Lütfen 0 ile 100 arasında geçerli bir not giriniz!", "Geçersiz Not", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (ortalama >= 85)
            {
                label1.Text = "Takdir Belgesi almaya hak kazandınız! 🏆";
            }
            else if (ortalama >= 70)
            {
                label1.Text = "Teşekkür Belgesi almaya hak kazandınız! 📜";
            }
            else if (ortalama >= 50)
            {
                label1.Text = "Belge almadan sınıfı geçtiniz. 👍";
            }
            else
            {
                label1.Text = "Sınıfı geçmek için yeterli not alamadınız. 🛑";
            }
        }
    }
}

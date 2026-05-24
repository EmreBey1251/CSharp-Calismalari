using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Butonun ilk tasarım ayarları
            button1.Text = "Dokunma Bana 🖐️";
            button1.BackColor = Color.LightGray;
            button1.Size = new Size(200, 50);
        }

        // Mouse butonun üzerine geldiğinde çalışacak kod
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "Üzerimde Geziniyorsun! 👀";
            button1.BackColor = Color.LightCoral;
        }

        // Mouse butonun üzerinden ayrıldığında çalışacak kod
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Gittin mi? 😢";
            button1.BackColor = Color.LightSkyBlue;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılan_harf_kadar_button_oluşturan_kod
{
    public partial class Form1 : Form
    {
        Button button = new Button();
        string ifade;
        private object radiobutton1;
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ifade = textBox1.Text;
            for (int i = 0; i < ifade.Length; i++)
            {
                Button button = new Button();
                button.Name = "dug";
                button.Width = 50;
                button.Height = 50;
                button.Location = new Point(i * button.Width, 150);
                button.Text = ifade.Substring(i, 1);
                Random rnd = new Random();
                button.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                buttons.Add(button);
                Controls.Add(button);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var button in buttons)
            {
                Controls.Remove(button);
            }
            buttons.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255) , rnd.Next(255));
            }
        }
    }
}

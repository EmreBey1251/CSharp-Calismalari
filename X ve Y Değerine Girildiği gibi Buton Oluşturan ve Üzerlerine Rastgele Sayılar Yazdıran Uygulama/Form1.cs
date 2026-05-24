using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saçma_sapan_buton
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text); // x değeri
            int b = Convert.ToInt32(textBox2.Text); // y değeri

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    int ran = rnd.Next(0, 50);                     
                    Button button = new Button();
                    button.Text = ""+ran;
                    button.Location = new Point(i, j);
                    button.Width = 50;
                    button.Height = 50;
                    button.Location = new Point(30*2*i, 30*2*j); 
                    this.Controls.Add(button);
                    listBox1.Items.Add(button.Text);
                }
            }
        }
    }
}

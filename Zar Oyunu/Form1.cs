using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        int zar1,zar2;
        int pc1,pc2;
        int top1,top2;
        int z1 = 0;
        int z2 = 0;
        int x = 0;
        int y = 0;
        int abkt;
        int bbkt;



        private void button2_Click(object sender, EventArgs e)
        {
            abkt = 0;
            bbkt++;
            if (bbkt == 1)
            {
                pc1 = rnd.Next(1, 7);
                textBox4.Text = pc1.ToString();
                pc2 = rnd.Next(1, 7);
                textBox5.Text = pc2.ToString();
                top2 = pc1 + pc2;
                textBox6.Text=Convert.ToString(top2);
                pictureBox1.Image = ımageList1.Images[pc1 - 1];
                pictureBox2.Image = ımageList1.Images[pc2 - 1];
                y += top2;
                textBox8.Text = y.ToString();
                if (y >= 100) { MessageBox.Show("Kaybettin");}
                button1.Enabled =true;
                button2.Enabled =false;
            }
        }

        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bbkt = 0;
            abkt++;
            if (abkt == 1)
            {
                zar1 = rnd.Next(1, 7);
                textBox1.Text = zar1.ToString();
                zar2 = rnd.Next(1, 7);
                textBox2.Text = zar2.ToString();
                top1 = Convert.ToInt32(zar1 + zar2);
                pictureBox1.Image = ımageList1.Images[zar1 - 1];
                pictureBox2.Image = ımageList1.Images[zar2 - 1];
                textBox3.Text = top1.ToString();
                x += top1;
                textBox7.Text = x.ToString();
                if (x >= 100)
                {
                    MessageBox.Show("Kazandın");
                }
                button1.Enabled = false;
                button2.Enabled =true;
            }
        }
    }
}

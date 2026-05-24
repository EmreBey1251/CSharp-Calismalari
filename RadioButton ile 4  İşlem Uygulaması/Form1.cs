using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_9
{
    public partial class Form1 : Form
    {
        int secim;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(secim)
            {
                case 1:
                    {
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text)); 
                        break;
                    }
                case 2:
                    {
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
                        break ;
                    }
                case 3:
                    {
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
                        break;
                    }
                case 4:
                    {
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) / int.Parse(textBox2.Text));
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Seçimini anlamadım");
                        break;
                    }
            }
        
        
        
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {secim = 1;}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) {secim = 2;}
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) {secim = 3;}
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) {secim = 4;}
        }
    }
}

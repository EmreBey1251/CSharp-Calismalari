using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inan_hoca_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            int b = Convert.ToInt32(textBox1.Text);
            int i = 2;
            while (i < b)
            {
                if (b % i == 0) a++;
                i++;
            }
                
                if (a != 0)    MessageBox.Show("Asal Değil!");
                else
                {
                    listBox1.Items.Add(textBox1.Text);
                }
            
        }
    }
}
